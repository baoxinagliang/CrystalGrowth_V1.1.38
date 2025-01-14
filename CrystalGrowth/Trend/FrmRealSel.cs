using CrystalGrowth.CrystalCtl;
using CrystalGrowth.SOP;
using CrystalGrowth.Unities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CrystalGrowth.Trend
{
    internal partial class FrmRealSel : Form
    {
        int SelVarNum = 0;
        readonly DateT dateT;
        public FrmRealSel()
        {
            InitializeComponent();
            DataGridView1.Rows.Add(5);
            int Lenght = TData.LimitValue.Count;
            DataGridView2.Rows.Add(Lenght);
            string[] strArray = TData.LimitValue.Keys.ToArray();
            for (int i = 0; i < Lenght; i++)
            {
                DataGridView2.Rows[i].Cells[0].Value = strArray[i];
            }
            dateT = new DateT();
            LabTIme.Text = dateT.Value.ToString("yyyy-MM-dd HH:mm:ss");
            LoadVarFile();
        }
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridView1.CurrentCell.Value != null && (e.ColumnIndex == 2 || e.ColumnIndex == 3))
            {
                string LastObj = DataGridView1.CurrentCell.Value.ToString();
                SmallKey sk = new SmallKey();
                sk.ImportData(DataGridView1.CurrentCell, new Point(768, 200), 1);
                sk.ShowDialog();
                if (sk.DialogResult == DialogResult.OK)
                {
                    TData.WriteLimitValue(DataGridView1.CurrentCell.Value.ToString(), e.RowIndex, e.ColumnIndex);
                }
                LabInfo.Text = LastObj != DataGridView1.CurrentCell.Value.ToString() ? "界限值已更改，请重新查询显示!" : "";
            }
        }
        private void DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelVarNum = e.RowIndex;
            DataGridView2[0, SelVarNum].Style.SelectionBackColor = Color.Blue;
            DataGridView2[0, SelVarNum].Style.SelectionForeColor = Color.White;
            BtnSelect.Enabled = true;
        }
        private void BtnSelect_Click(object sender, EventArgs e)
        {
            bool ExistFlag = false;
            for (int i = 0; i < 5; i++)
            {
                if (DataGridView1.Rows[i].Cells[1].Value.ToString() == DataGridView2.Rows[SelVarNum].Cells[0].Value.ToString())
                {
                    TData.SelValue[i].Index = 0;
                    DataGridView1.Rows[i].Cells[1].Value = "";
                    DataGridView1.Rows[i].Cells[2].Value = "";
                    DataGridView1.Rows[i].Cells[3].Value = "";
                    ExistFlag = true;
                }
            }
            if (ExistFlag == false)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (DataGridView1.Rows[i].Cells[1].Value.ToString() == "")
                    {
                        DataGridView1.Rows[i].Cells[1].Value = DataGridView2.Rows[SelVarNum].Cells[0].Value;
                        TData.SelValue[i].Name = DataGridView1.Rows[i].Cells[1].Value.ToString();
                        TData.SelValue[i].Value = "";
                        TData.SelValue[i].Index = Convert.ToInt32(TData.Paras[DataGridView2.Rows[SelVarNum].Cells[0].Value.ToString()].Num);
                        TData.SelValue[i].Min = TData.LimitValue[TData.SelValue[i].Name].Min;
                        TData.SelValue[i].Max = TData.LimitValue[TData.SelValue[i].Name].Max;
                        DataGridView1.Rows[i].Cells[2].Value = TData.SelValue[i].Min;
                        DataGridView1.Rows[i].Cells[3].Value = TData.SelValue[i].Max;
                        return;
                    }
                }
            }
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnSave))
            {
                TData.SaveVarFile();
                TData.SaveLimitValue();
            }
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnClear))
            {
                FrmTrend.Single.chart1.Series.Clear();
                FrmTrend.Single.ChartAddSeries(FrmTrend.Single.chart1);
                for (int i = 0; i < 5; i++)
                {
                    DataGridView1.Rows[i].Cells[1].Value = "";
                    DataGridView1.Rows[i].Cells[2].Value = "";
                    DataGridView1.Rows[i].Cells[3].Value = "";
                    TData.SelValue[i].Index = 0;
                }
            }
        }
        private void LoadVarFile()
        {
            string[] Lines = File.ReadAllLines(FileHelper.HisSelPath, Encoding.UTF8);
            int Length = Lines.Length;
            if (Length > 0)
            {
                string[] TempVar = Lines[0].Split(new char[] { ' ' });
                for (int i = 0; i < 5; i++)
                {
                    TData.SelValue[i].Index = Convert.ToInt32(TempVar[i]);
                    if (TData.SelValue[i].Index > 0)
                    {
                        DataGridView1.Rows[i].Cells[1].Value = FrmVarTable.VarStr[TData.SelValue[i].Index];
                        TData.SelValue[i].Name = DataGridView1.Rows[i].Cells[1].Value.ToString();
                        TData.SelValue[i].Value = "";
                        TData.SelValue[i].Min = TData.LimitValue[TData.SelValue[i].Name].Min;
                        TData.SelValue[i].Max = TData.LimitValue[TData.SelValue[i].Name].Max;
                        DataGridView1.Rows[i].Cells[2].Value = TData.SelValue[i].Min;
                        DataGridView1.Rows[i].Cells[3].Value = TData.SelValue[i].Max;
                    }
                    else
                    {
                        TData.SelValue[i].Index = 0;
                        DataGridView1.Rows[i].Cells[1].Value = "";
                        DataGridView1.Rows[i].Cells[2].Value = "";
                        DataGridView1.Rows[i].Cells[3].Value = "";
                    }
                }
            }
        }
        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void CBData_DropDown(object sender, EventArgs e)
        {
            DirectoryInfo Dir = new DirectoryInfo("D:\\LICCS_DB");
            FileInfo[] Files = Dir.GetFiles("*.db3", SearchOption.TopDirectoryOnly);
            int Length = Files.Length;
            CBData.Items.Clear();
            if (Length > 0)
            {
                for (int i = 0; i < Length; i++)
                {
                    CBData.Items.Add(Path.GetFileNameWithoutExtension(Files[i].FullName));
                    if (CBData.Items[i] == CBData.SelectedItem)
                    {
                        CBData.SelectedItem = CBData.Items[i];
                    }
                }
            }
        }
        private void BtnQuery_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnQuery))
            {
                if (CBData.SelectedItem == null)
                {
                    LabInfo.Text = "请选查询数据文件！";
                    return;
                }
                string DataSource = string.Format("D:\\LICCS_DB\\{0}.db3", CBData.SelectedItem.ToString());
                if (File.Exists(DataSource))
                {
                    string[] para1 = new string[5];
                    GetConnectStr(ref para1);
                    string para = string.Join("", para1).TrimEnd(',');
                    if (para == "")
                    {
                        LabInfo.Text = "查寻参数不存在！";
                        return;
                    }
                    FrmTrend.Single.chart1.Series.Clear();//清除所有数据集 
                    FrmTrend.Single.ChartAddSeries(FrmTrend.Single.chart1);
                    string strStart = LabTIme.Text;
                    DateTime objStart = Convert.ToDateTime(strStart);
                    DateTime objEnd = objStart.AddMinutes(-FrmChangeTime.SpanHistoryTime);
                    string strEnd = objEnd.ToString("yyyy-MM-dd HH:mm:ss");
                    string CmdStr = $"SELECT DATE_TIME,{para} FROM PROCESS_DATA WHERE DATE_TIME BETWEEN DATETIME('{strEnd}') AND DATETIME('{strStart}')";
                    using (DataTable dt = SqliteHelper.GetDataTable(string.Format("Data Source={0};Pooling=true;FailIfMissing=false", DataSource), CmdStr))
                    {
                        List<double> doubX = new List<double>();
                        List<double>[] doubY = { new List<double>(), new List<double>(), new List<double>(), new List<double>(), new List<double>() };
                        if (dt != null && dt.Rows.Count >= 2)
                        {
                            LabInfo.Text = "数据加载中,请等待完成........";
                            LabInfo.Refresh();
                            ConvertDatas(ref para1, ref doubX, ref doubY, dt);
                            BindingParas(ref para1, ref doubX, ref doubY);
                            FrmTrend.Single.TimeChange(FrmTrend.Single.chart1, doubX[doubX.Count - 1], doubX[0]);
                            LabInfo.Text = "";
                        }
                        else
                        {
                            LabInfo.Text = "查询数据不存在！";
                            return;
                        }
                        GC.Collect();
                    }
                }
                else
                {
                    LabInfo.Text = "数据文件不存在！";
                }
            }
        }
        private void ConvertDatas(ref string[] para1, ref List<double> doubX, ref List<double>[] doubY, DataTable dt)
        {
                            object tempData;
                            foreach (DataRow dataRow in dt.Rows)
                            {
                                doubX.Add(Convert.ToDateTime(dataRow[0]).ToOADate());
                for (int i = 0; i <= 4; i++)
                                {
                    if (para1[i] != "")
                    {
                        tempData = dataRow[$"{para1[i].TrimEnd(',')}"];
                        doubY[i].Add(DataCovert.Juage(tempData) ? DataCovert.NumVar(tempData, TData.SelValue[i].Min, TData.SelValue[i].Max) : 0);
                    }
                }
                                }
                                }
        private void BindingParas(ref string[] para1, ref List<double> doubX, ref List<double>[] doubY)
                                {
            FrmTrend.Single.chart1.Series.Clear();
            FrmTrend.Single.ChartAddSeries(FrmTrend.Single.chart1);
            for (int i = 0; i <= 4; i++)
                                {
                if (para1[i] != "")
                                {
                    FrmTrend.Single.chart1.Series[i].Points.DataBindXY(doubX, doubY[i]);
                                }
                            }
                        }
        private void GetConnectStr(ref string[] para1)
                        {
            for (int i = 0; i <= 4; i++)
                {
                para1[i] = TData.SelValue[i].Index == 0 ? "" : string.Concat(TData.Paras[TData.SelValue[i].Name].Name, ",");
            }
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (CbbSelect.SelectedItem != null)
            {
                LabTIme.Text = dateT.Add(CbbSelect.SelectedItem.ToString());
            }
        }

        private void BtnRed_Click(object sender, EventArgs e)
        {
            if (CbbSelect.SelectedItem != null)
            {
                LabTIme.Text = dateT.Reduce(CbbSelect.SelectedItem.ToString());
            }
        }
    }
}