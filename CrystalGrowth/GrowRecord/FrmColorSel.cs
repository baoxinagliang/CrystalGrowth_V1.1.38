using CrystalGrowth.CrystalCtl;
using CrystalGrowth.SOP;
using CrystalGrowth.Trend;
using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CrystalGrowth.GrowRecord
{
    internal partial class FrmColorSel : Form
    {
        int SelVarNum = 0;
        public FrmColorSel()
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
                LabInfo.Text = LastObj != DataGridView1.CurrentCell.Value.ToString() ? "界限值已更改，请退出重新查询数据!" : "";
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
                    FrmHistTrend.Single.ClearCurve(i);
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
                        TData.SelValue[i].Index = Convert.ToInt32(TData.Paras[DataGridView2.Rows[SelVarNum].Cells[0].Value.ToString()].Num);
                        TData.SelValue[i].Name = DataGridView1.Rows[i].Cells[1].Value.ToString();
                        TData.SelValue[i].Value = "";
                        TData.SelValue[i].Min = TData.LimitValue[TData.SelValue[i].Name].Min;
                        TData.SelValue[i].Max = TData.LimitValue[TData.SelValue[i].Name].Max;
                        DataGridView1.Rows[i].Cells[2].Value = TData.SelValue[i].Min;
                        DataGridView1.Rows[i].Cells[3].Value = TData.SelValue[i].Max;
                        FrmHistTrend.Single.RefreshCurve(i);
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
                FrmHistTrend.Single.Chart1.Series.Clear();
                FrmTrend.Single.ChartAddSeries(FrmHistTrend.Single.Chart1);
                FrmHistTrend.Single.Chart2.Series.Clear();
                FrmTrend.Single.ChartAddSeries(FrmHistTrend.Single.Chart2);
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
            Hide();
        }
        private void FrmColorSel_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                DataGridView2.ClearSelection();
                DataGridView2.FirstDisplayedScrollingRowIndex = 0;
            }
        }
    }
}