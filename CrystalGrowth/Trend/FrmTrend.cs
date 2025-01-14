using CrystalGrowth.CrystalCtl;
using CrystalGrowth.SOP;
using CrystalGrowth.Unities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CrystalGrowth.Trend
{
    internal partial class FrmTrend : Form
    {
        public int MaxSpan = 21600;
        readonly SelValue[] RealList = new SelValue[5];
        readonly double MaxNum = 0;
        float LastValue = 100;
        int TimeCnt = 0;
        bool StopFlag = false;
        private FrmTrend()
        {
            InitializeComponent();
            DataGridView1.Rows.Add(5);
            MaxNum = MaxSpan * 60 / 8;
            chart1.Series.Clear();
            ChartAddSeries(chart1);
        }
        FrmChangeTime fct;
        FrmVarSel fvs;
        FrmRealSel frs;
        public static FrmTrend Single;
        public static FrmTrend CreateInstrance()
        {
            if (Single == null)
            {
                Single = new FrmTrend();
                Single.FormClosed += Single_FormClosed;
            }
            return Single;
        }
        static void Single_FormClosed(object sender, FormClosedEventArgs e)
        {
            Single = null;
        }
        public void ChartAddSeries(Chart chart)
        {
            for (int i = 0; i < 5; i++)
            {
                AddSingelCurve(i, chart);
            }
        }
        private void AddSingelCurve(int index, Chart chart)
        {
            chart.Series.Add(new Series($"Series{index}")
                {
                    ChartType = SeriesChartType.FastLine, //直线
                    BorderWidth = 1,
                    XValueType = ChartValueType.Time,
                    IsValueShownAsLabel = false
                });
            chart.Series[index].Color = ChartSeriesColor(index);
        }
        private Color ChartSeriesColor(int index)
        {
            switch (index)
            {
                case 0:
                    return Color.Red;
                case 1:
                    return Color.Green;
                case 2:
                    return Color.Blue;
                case 3:
                    return Color.Yellow;
                default:
                    return Color.Fuchsia;
            }
        }
        public void BtnReset()
        {
            BtnTime.Visible = true;
            BtnSave.Visible = true;
            BtnClear.Visible = true;
        }
        private async void Timer1_Tick(object sender, EventArgs e)
        {
            if (LastValue != PLC.ReadValue[1])
            {
                LastValue = PLC.ReadValue[1];
                LoadVarData(Math.Round(LastValue, 1).ToString("f1"));//根据切换状态，加载当前状态数据，到最后一条状态清空实时曲线。   
                LabInfo.Text = "数据加载中，请等待完成........";
                LabInfo.Refresh();
                DataTable dataTable = await TaskQueryData();
                UpdateChartSeries(dataTable, 5);
            }
            if (TimeCnt == 0 || TimeCnt > 7)
            {
                TimeCnt = 1;
                AddRealData();//刷新表格显示数据
                if (StopFlag == false)
                {
                    DateTime timeNow = DateTime.Now;
                    TimeChange(chart1, timeNow.ToOADate(), timeNow.AddMinutes(-MaxSpan).ToOADate());
                }
            }
            TimeCnt++;
        }
        private void LoadVarData(string state)
        {
            string[] Lines = File.ReadAllLines(FileHelper.TVarSelPath, Encoding.UTF8);
            int Length = Lines.Length;
            char[] SplitChar = new char[] { ' ' };
            string[] TempVar;
            for (int i = 0; i < Length; i++)
            {
                TempVar = Lines[i].Split(SplitChar);
                if (TempVar[0] == state)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        RealList[j].Index = Convert.ToInt32(TempVar[j + 1]);
                        if (RealList[j].Index > 0)
                        {
                            DataGridView1.Rows[j].Cells[1].Value = FrmVarTable.VarStr[RealList[j].Index];
                            RealList[j].Name = DataGridView1.Rows[j].Cells[1].Value.ToString();
                            RealList[j].Value = FrmVarTable.VarValue[RealList[j].Index];
                            RealList[j].Min = TData.LimitValue[RealList[j].Name].Min;
                            RealList[j].Max = TData.LimitValue[RealList[j].Name].Max;
                            DataGridView1.Rows[j].Cells[2].Value = RealList[j].Value;
                            DataGridView1.Rows[j].Cells[3].Value = RealList[j].Min;
                            DataGridView1.Rows[j].Cells[4].Value = RealList[j].Max;
                        }
                        else
                        {
                            RealList[j].Index = 0;
                            DataGridView1.Rows[j].Cells[1].Value = "";
                            DataGridView1.Rows[j].Cells[2].Value = "";
                            DataGridView1.Rows[j].Cells[3].Value = "";
                            DataGridView1.Rows[j].Cells[4].Value = "";
                        }
                    }
                    break;
                }
                if (i + 1 == Length)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        ClearCurveInfo(j);
                    }
                }
            }
        }
        private void AddRealData()
        {
            for (int i = 0; i < 5; i++)
            {
                if (RealList[i].Index > 0)
                {
                    RealList[i].Value = FrmVarTable.VarValue[RealList[i].Index];
                    if (DataCovert.Juage(RealList[i].Value))
                    {
                        double odaTime = DateTime.Now.ToOADate();
                        if (StopFlag == false)
                        {
                            DataGridView1.Rows[i].Cells[2].Value = RealList[i].Value;
                            chart1.Series[i].Points.AddXY(odaTime, DataCovert.NumVar(RealList[i].Value, RealList[i].Min, RealList[i].Max));
                            if (chart1.Series[i].Points.Count > MaxNum) { chart1.Series[i].Points.RemoveAt(0); }
                        }
                    }
                }
                else
                {
                    DataGridView1.Rows[i].Cells[2].Value = "";
                    DataGridView1.Rows[i].Cells[3].Value = "";
                    DataGridView1.Rows[i].Cells[4].Value = "";
                }
            }
        }
        public void TimeChange(Chart chart, double min, double max)
        {
            chart.ChartAreas[0].AxisX.Minimum = max;
            chart.ChartAreas[0].AxisX.Maximum = min;
            DateTime dt = DateTime.Now;
            double tSpan = dt.ToOADate() - dt.AddMinutes(-FrmChangeTime.SpanRealTime).ToOADate();
            chart.ChartAreas[0].AxisX.MajorGrid.Interval = tSpan / 24;
            chart.ChartAreas[0].AxisX.LabelStyle.Interval = tSpan / 12;
            chart.ChartAreas[0].AxisX.LabelStyle.IntervalOffset = tSpan / 24;
            chart.ChartAreas[0].AxisX.ScaleView.Size = tSpan;
            chart.ChartAreas[0].AxisX.ScaleView.SmallScrollMinSize = tSpan / 24;
            chart.ChartAreas[0].AxisX.ScaleView.Scroll(ScrollType.Last);
        }
        public async void WriteLimitValue(string Value, int RowNum, int ColumnNum)
        {
            if (string.IsNullOrEmpty(Value) || RowNum < 0) return;
            if (LabInfo.Text != "") { return; }
            switch (ColumnNum)
            {
                case 3:
                    TData.LimitValue[RealList[RowNum].Name].Min = Value;
                    RealList[RowNum].Min = Value;
                    break;
                case 4:
                    TData.LimitValue[RealList[RowNum].Name].Max = Value;
                    RealList[RowNum].Max = Value;
                    break;
            }
            TData.SaveLimitValue();
            LabInfo.Text = "数据加载中，请等待完成........";
            LabInfo.Refresh();
            DataTable dataTable = await TaskQueryData();
            UpdateChartSeries(dataTable, RowNum);
            LabInfo.Text = "";
        }
        private void SaveVarFile()
        {
            string[] Lines = File.ReadAllLines(FileHelper.TVarSelPath, Encoding.UTF8);
            int Length = Lines.Length;
            string TempVar;
            char[] SplitChar = new char[] { ' ' };
            for (int i = 0; i < Length; i++)
            {
                TempVar = Lines[i].Split(SplitChar)[0];
                if (TempVar == Math.Round(PLC.ReadValue[1], 1).ToString("f1"))
                {
                    for (int j = 0; j < 5; j++)
                    {
                        TempVar = string.Concat(TempVar, " ", RealList[j].Index);
                    }
                    Lines[i] = TempVar;
                    break;
                }
            }
            File.WriteAllLines(FileHelper.TVarSelPath, Lines);
        }
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridView1.CurrentCell != null)
            {
                if (e.ColumnIndex == 3 || e.ColumnIndex == 4)
                {
                    SmallKey sk = new SmallKey();
                    sk.ImportData(DataGridView1.CurrentCell, new Point(768, 200), 1);
                    sk.ShowDialog();
                    if (sk.DialogResult == DialogResult.OK)
                    {
                        WriteLimitValue(DataGridView1.CurrentCell.Value.ToString(), e.RowIndex, e.ColumnIndex);
                    }
                }
            }
        }
        private void BtnVarSel_Click(object sender, EventArgs e)
        {
            BtnTime.Visible = false;
            BtnSave.Visible = false;
            BtnClear.Visible = false;
            BtnVarSel.Enabled = false;
            fvs = new FrmVarSel();
            FrmSwitch.Open(fvs, 66, new Point(600, 200), new Size(337, 550));
            fvs.Show();
        }
        private void BtnTime_Click(object sender, EventArgs e)
        {
            fct = new FrmChangeTime();
            FrmSwitch.Open(fct, 67, new Point(0, 130), new Size(1366, 254));
            fct.Show();
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnClear))
            {
                chart1.Series.Clear();
                for (int i = 0; i < 5; i++)
                {
                    ClearCurveInfo(i);
                }
                ChartAddSeries(chart1);
            }
        }
        public void ClearCurveInfo(int index)
        {
            DataGridView1.Rows[index].Cells[1].Value = "";
            DataGridView1.Rows[index].Cells[2].Value = "";
            DataGridView1.Rows[index].Cells[3].Value = "";
            DataGridView1.Rows[index].Cells[4].Value = "";
            RealList[index].Index = 0;
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnSave))
            {
                SaveVarFile();
                TData.SaveLimitValue();
            }
        }
        private void CBGrid_Click(object sender, EventArgs e)
        {
            if (CBGrid.Checked)
            {
                CBGrid.Checked = false;
                chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            }
            else
            {
                CBGrid.Checked = true;
                chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
                chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
            }
        }
        private void FrmTrend_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible == false)
            {
                if (fct != null) { fct.Close(); }
                if (fvs != null) { fvs.Close(); }
                if (frs != null) { frs.Close(); }
                if (BtnStop.BackColor == Color.Red) { StopChange(); }
                GC.Collect();
            }
        }
        public async void VarAdd(object obj)
        {
            int VarExist = 0;
            if (LabInfo.Text != "") { return; }
            for (int i = 0; i < 5; i++)
            {
                if (DataGridView1.Rows[i].Cells[1].Value.ToString() == obj.ToString())
                {
                    LabInfo.Text = "数据加载中，请等待完成........";
                    LabInfo.Refresh();
                    VarExist = 1;
                    ClearCurveInfo(i);
                    chart1.Series[i].Points.Clear();
                }
            }
            LabInfo.Text = "";
            if (VarExist == 0)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (DataGridView1.Rows[i].Cells[1].Value.ToString().Length == 0)
                    {
                        LabInfo.Text = "数据加载中，请等待完成........";
                        LabInfo.Refresh();
                        RealList[i].Name = obj.ToString();
                        RealList[i].Index = Convert.ToInt32(TData.Paras[RealList[i].Name].Num);
                        RealList[i].Value = FrmVarTable.VarValue[RealList[i].Index];
                        RealList[i].Min = TData.LimitValue[RealList[i].Name].Min;
                        RealList[i].Max = TData.LimitValue[RealList[i].Name].Max;

                        LabInfo.Text = "数据加载中，请等待完成........";
                        LabInfo.Refresh();
                        DataTable dataTable = await TaskQueryData();
                        UpdateChartSeries(dataTable, i);

                        DataGridView1.Rows[i].Cells[1].Value = RealList[i].Name;
                        DataGridView1.Rows[i].Cells[2].Value = RealList[i].Value;
                        DataGridView1.Rows[i].Cells[3].Value = RealList[i].Min;
                        DataGridView1.Rows[i].Cells[4].Value = RealList[i].Max;
                        break;
                    }
                }
            }
        }
        private DataTable QueryData()
        {
            DataTable dataTable = new DataTable();
            string DataBaseName = IdNum.CrystalID == "" ? "ID_XXXXXXXX" : string.Concat("ID_", IdNum.CrystalID);
            string DataSource = string.Format("D:\\LICCS_DB\\{0}.db3", DataBaseName);
            if (File.Exists(DataSource))
            {
                string[] para1 = new string[5];
                GetConnectStr(ref para1);
                string para = string.Join("", para1).TrimEnd(',');
                if (para == "") { return dataTable; }
                DateTime objStart = DateTime.Now;
                DateTime objEnd = objStart.AddMinutes(-MaxSpan);
                string strStart = objStart.ToString("yyyy-MM-dd HH:mm:ss");
                string strEnd = objEnd.ToString("yyyy-MM-dd HH:mm:ss");
                string CmdStr = $"SELECT DATE_TIME,{para} FROM PROCESS_DATA WHERE DATE_TIME BETWEEN DATETIME('{strEnd}') AND DATETIME('{strStart}')";
                using (DataTable dt = SqliteHelper.GetDataTable1(CmdStr))
                {
                    dataTable = dt;
                }
            }
            return dataTable;
        }

        async Task<DataTable> TaskQueryData()
        {
            return await Task.Run(() => QueryData());
        }

        public async void UpdateChartSeries(DataTable dt, int index)
        {
            string[] para1 = new string[5];
            GetConnectStr(ref para1);
            List<double> doubX = new List<double>();
            List<double>[] doubY = { new List<double>(), new List<double>(), new List<double>(), new List<double>(), new List<double>() };
            if (dt != null && dt.Rows.Count >= 2)
            {
                await Task.Run(() => ConvertDatas(ref para1, ref doubX, ref doubY, dt, ref index));
                BindingParas(ref para1, ref doubX, ref doubY, ref index);
                TimeChange(chart1, doubX[doubX.Count - 1], doubX[0]);
                chart1.ChartAreas[0].AxisX.ScaleView.Scroll(ScrollType.Last);
            }
            LabInfo.Text = "";
        }
        private void ConvertDatas(ref string[] para1, ref List<double> doubX, ref List<double>[] doubY, DataTable dt, ref int index)
        {
            object tempData;
            foreach (DataRow dataRow in dt.Rows)
            {
                doubX.Add(Convert.ToDateTime(dataRow[0]).ToOADate());
                if (index == 5)
                {
                    for (int i = 0; i <= 4; i++)
                    {
                        if (para1[i] != "")
                        {
                            tempData = dataRow[$"{para1[i].TrimEnd(',')}"];
                            doubY[i].Add(DataCovert.Juage(tempData) ? DataCovert.NumVar(tempData, RealList[i].Min, RealList[i].Max) : 0);
                        }
                    }
                }
                else
                {
                    if (para1[index] != "")
                    {
                        tempData = dataRow[$"{para1[index].TrimEnd(',')}"];
                        doubY[index].Add(DataCovert.Juage(tempData) ? DataCovert.NumVar(tempData, RealList[index].Min, RealList[index].Max) : 0);
                    }
                }
            }
        }

        private void BindingParas(ref string[] para1, ref List<double> doubX, ref List<double>[] doubY, ref int index)
        {
            if (index == 5)
        {
            chart1.Series.Clear();
            ChartAddSeries(chart1);
                for (int i = 0; i <= 4; i++)
                {
                    if (para1[i] != "")
                    {
                        chart1.Series[i].Points.DataBindXY(doubX, doubY[i]);
                    }
                }
        }
            else
        {
                if (para1[index] != "")
            {
                    chart1.Series[index].Points.DataBindXY(doubX, doubY[index]);
                }
            }
        }
        private void GetConnectStr(ref string[] para1)
                {
            for (int i = 0; i <= 4; i++)
                    {
                para1[i] = RealList[i].Index == 0 ? "" : string.Concat(TData.Paras[RealList[i].Name].Name, ",");
            }
        }
        private void BtnStop_Click(object sender, EventArgs e)
        {
            StopChange();
        }
        private async void StopChange()
        {
            if (StopFlag)
            {
                StopFlag = false;
                BtnStop.Text = "启动";
                BtnStop.BackColor = Color.RoyalBlue;
                BtnTime.Enabled = true;
                BtnSave.Enabled = true;
                BtnClear.Enabled = true;
                BtnVarSel.Enabled = true;
                BtnHistory.Enabled = false;
                LabInfo.Text = "数据加载中，请等待完成........";
                LabInfo.Refresh();
                DataTable dataTable = await TaskQueryData();
                UpdateChartSeries(dataTable, 5);
            }
            else
            {
                StopFlag = true;
                BtnStop.BackColor = Color.Red;
                BtnStop.Text = "暂停";
                BtnTime.Enabled = false;
                BtnSave.Enabled = false;
                BtnClear.Enabled = false;
                BtnVarSel.Enabled = false;
                BtnHistory.Enabled = true;
            }
        }
        private void BtnHistory_Click(object sender, EventArgs e)
        {
            frs = new FrmRealSel();
            FrmSwitch.Open(frs, 103, new Point(0, 130), new Size(1366, 254));
            frs.Show();
        }
        int CurrentXValue = 0;
        private void chart1_MouseDown(object sender, MouseEventArgs e)
        {
            HitTestResult myTestResult = chart1.HitTest(e.X, e.Y);
            if (myTestResult.ChartElementType == ChartElementType.DataPoint || myTestResult.ChartElementType == ChartElementType.PlottingArea || myTestResult.ChartElementType == ChartElementType.Gridlines)
            {
                if (e.X == CurrentXValue) { return; }
                CurrentXValue = e.X;
                if (e.X >= 1360 || e.X <= 10) { return; }
                double xValue = chart1.ChartAreas[0].AxisX.PixelPositionToValue(e.X);
                int index = 162000;
                int SeriesNumber = 0;
                DataPoint last, next;
                for (int i = 0; i < 5; i++)
                {
                    if (RealList[i].Index > 0)
                    {
                        SeriesNumber = i;
                    }
                }
                for (int i = 0; i < chart1.Series[$"Series{SeriesNumber}"].Points.Count - 1; i++)
                {
                    last = chart1.Series[$"Series{SeriesNumber}"].Points[i];
                    next = chart1.Series[$"Series{SeriesNumber}"].Points[i + 1];
                    if (last.XValue <= xValue && xValue <= next.XValue)//确定在哪两个点中间
                    {
                        index = (last.XValue + next.XValue) / 2 <= xValue ? i + 1 : i;
                    }
                }
                if (index != 162000)
                {
                    DataPoint pX = chart1.Series[$"Series{SeriesNumber}"].Points[index];
                    StringBuilder strB = new StringBuilder();
                    strB.Append($"选中时间:\r\n{DateTime.FromOADate(pX.XValue).ToString("yyyy-MM-dd HH:mm:ss")}\r\n");
                    for (int i = 0; i < 5; i++)
                    {
                        if (RealList[i].Index > 0)
                        {
                            DataPoint p1 = chart1.Series[$"Series{i}"].Points[index];
                            double max = Convert.ToDouble(RealList[i].Max);
                            double min = Convert.ToDouble(RealList[i].Min);
                            double showValue = Math.Round((p1.YValues[0] * (max - min)) / 100 + min, 2);
                            if (p1.YValues[0] > 0 && p1.YValues[0] < 100)
                            {
                                strB.Append(string.Format("{0}:{1}\r\n", FrmVarTable.VarStr[RealList[i].Index], showValue));
                            }
                            else
                            {
                                strB.Append(string.Format("{0}: --\r\n", FrmVarTable.VarStr[RealList[i].Index]));
                            }
                        }
                    }
                    LabChartData.Text = strB.ToString();
                }
            }
        }
        private void chart1_MouseLeave(object sender, EventArgs e)
        {
            LabChartData.Text = "";
        }
    }
}