using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.SOP
{
    internal partial class ProcStab7 : Form
    {
        public ProcStab7()
        {
            InitializeComponent();
            DataGridView1.Rows.Add(4);
            DataGridView1.Rows[0].HeaderCell.Value = "放肩慢报警(min)";
            DataGridView1.Rows[1].HeaderCell.Value = "放肩快报警(min)";
            DataGridView1.Rows[2].HeaderCell.Value = "转肩触发直径(mm)";
            DataGridView1.Rows[3].HeaderCell.Value = "直径控制打开长度(mm)";
            DataGridView2.Rows.Add(16);
            for (int i = 1; i <= 16; i++)
            {
                DataGridView2.Rows[i - 1].HeaderCell.Value = i.ToString();
            }
            if (PLC.ReadStatus[57] == 1)
            {
                DataGridView2.Columns[3].Visible = false;
                DataGridView2.Columns[4].Visible = true;
            }
            else
            {
                DataGridView2.Columns[3].Visible = true;
                DataGridView2.Columns[4].Visible = false;
            }
            DataGridView3.Rows.Add(24);
            DataGridView3.Rows[0].HeaderCell.Value = "直径控制选择(0直径控制，1直径变化率控制)";
            DataGridView3.Rows[1].HeaderCell.Value = "温度下降速率(units/hr)";
            DataGridView3.Rows[2].HeaderCell.Value = "功率下降速率(kw/hr)";
            DataGridView3.Rows[2].Visible = false;
            DataGridView3.Rows[3].HeaderCell.Value = "起始晶升速度(mm/hr)";
            DataGridView3.Rows[3].Visible = false;
            DataGridView3.Rows[4].HeaderCell.Value = "触发计算直径(mm)";
            DataGridView3.Rows[5].HeaderCell.Value = "放肩下降温度(units)";
            DataGridView3.Rows[6].HeaderCell.Value = "放肩下降功率(kw)";
            DataGridView3.Rows[7].HeaderCell.Value = "温度下降总量(units)";
            DataGridView3.Rows[8].HeaderCell.Value = "功率偏移最大值(kw)";
            DataGridView3.Rows[9].HeaderCell.Value = "功率偏移最小值(kw)";
            DataGridView3.Rows[10].HeaderCell.Value = "自动补偿功率(kw)";
            DataGridView3.Rows[11].HeaderCell.Value = "晶升基础速度变化率(mm/h/s)";
            DataGridView3.Rows[12].HeaderCell.Value = "埚升控制选择 (0=表格速度 1=埚跟比)";
            DataGridView3.Rows[13].HeaderCell.Value = "埚跟比触发直径(mm)";
            DataGridView3.Rows[11].Visible = false;
            DataGridView3.Rows[12].Visible = false;
            DataGridView3.Rows[13].Visible = false;
            if (PLC.ReadStatus[57] == 1)
            {
                DataGridView3.Rows[1].Visible = false;
                DataGridView3.Rows[2].Visible = true;
                DataGridView3.Rows[5].Visible = false;
                DataGridView3.Rows[6].Visible = true;
                DataGridView3.Rows[7].Visible = false;
                DataGridView3.Rows[8].Visible = true;
                DataGridView3.Rows[9].Visible = true;
            }
            else
            {
                DataGridView3.Rows[1].Visible = true;
                DataGridView3.Rows[2].Visible = false;
                DataGridView3.Rows[5].Visible = true;
                DataGridView3.Rows[6].Visible = false;
                DataGridView3.Rows[7].Visible = true;
                DataGridView3.Rows[8].Visible = false;
                DataGridView3.Rows[9].Visible = false;
            }
            for (int i = 14; i <= 23; i++)
            {
                DataGridView3.Rows[i].Visible = false;
            }
            DataGridView4.Rows.Add(16);
            for (int i = 1; i <= 16; i++)
            {
                DataGridView4.Rows[i - 1].HeaderCell.Value = i.ToString();
            }
            DataGridView5.Rows.Add(14);
            DataGridView6.Rows.Add(8);
            for (int i = 1; i <= 8; i++)
            {
                DataGridView6.Rows[i - 1].HeaderCell.Value = i.ToString();
            }
            DataGridView7.Rows.Add(15);
            DataGridView7.Rows[0].HeaderCell.Value = "引晶速度1(mm/hr)";
            DataGridView7.Rows[1].HeaderCell.Value = "起始功率偏移量1(kw)";
            DataGridView7.Rows[2].HeaderCell.Value = "功率系数1";
            DataGridView7.Rows[3].HeaderCell.Value = "晶升速度1(mm/hr)";
            DataGridView7.Rows[4].HeaderCell.Value = "触发长度1(mm)";
            DataGridView7.Rows[5].HeaderCell.Value = "引晶速度2(mm/hr)";
            DataGridView7.Rows[6].HeaderCell.Value = "起始功率偏移量2(kw)";
            DataGridView7.Rows[7].HeaderCell.Value = "功率系数2";
            DataGridView7.Rows[8].HeaderCell.Value = "晶升速度2(mm/hr)";
            DataGridView7.Rows[9].HeaderCell.Value = "触发长度2(mm)";
            DataGridView7.Rows[10].HeaderCell.Value = "引晶速度3(mm/hr)";
            DataGridView7.Rows[11].HeaderCell.Value = "起始功率偏移量3(kw)";
            DataGridView7.Rows[12].HeaderCell.Value = "功率系数3";
            DataGridView7.Rows[13].HeaderCell.Value = "晶升速度3(mm/hr)";
            DataGridView7.Rows[14].HeaderCell.Value = "触发长度3(mm)";
            DataGridView8.Rows.Add(8);
            for (int i = 1; i <= 8; i++)
            {
                DataGridView8.Rows[i - 1].HeaderCell.Value = i.ToString();
            }
        }
        private void ProcStab7_Load(object sender, EventArgs e)
        {
            TabpagesChanged();
        }
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (ProcSel.AgreeEdit == 1)
                {
                    SmallKey sk = new SmallKey();
                    sk.ImportData(DataGridView1.CurrentCell, new Point(550, 232));
                    sk.ShowDialog();
                }
            }
        }
        private void DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (ProcSel.AgreeEdit == 1)
                {
                    SmallKey sk = new SmallKey();
                    if (Cursor.Position.X >= 658)
                    {
                        sk.ImportData(DataGridView2.CurrentCell, new Point(200, 232));
                    }
                    else
                    {
                        sk.ImportData(DataGridView2.CurrentCell, new Point(768, 232));
                    }
                    sk.ShowDialog();
                }
            }
        }
        private void DataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (ProcSel.AgreeEdit == 1)
                {
                    SmallKey sk = new SmallKey();
                    sk.ImportData(DataGridView3.CurrentCell, new Point(550, 232));
                    sk.ShowDialog();
                }
            }
        }
        private void DataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (ProcSel.AgreeEdit == 1)
                {
                    SmallKey sk = new SmallKey();
                    if (Cursor.Position.X >= 658)
                    {
                        sk.ImportData(DataGridView4.CurrentCell, new Point(200, 232));
                    }
                    else
                    {
                        sk.ImportData(DataGridView4.CurrentCell, new Point(768, 232));
                    }
                    sk.ShowDialog();
                }
            }
        }
        private void DataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (ProcSel.AgreeEdit == 1)
                {
                    SmallKey sk = new SmallKey();
                    if (Cursor.Position.X >= 658)
                    {
                        sk.ImportData(DataGridView5.CurrentCell, new Point(200, 232));
                    }
                    else
                    {
                        sk.ImportData(DataGridView5.CurrentCell, new Point(768, 232));
                    }
                    sk.ShowDialog();
                }
            }
        }
        private void DataGridView6_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (ProcSel.AgreeEdit == 1)
                {
                    SmallKey sk = new SmallKey();
                    sk.ImportData(DataGridView6.CurrentCell, new Point(950, 232));
                    sk.ShowDialog();
                }
            }
        }
        private void DataGridView7_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (ProcSel.AgreeEdit == 1)
                {
                    SmallKey sk = new SmallKey();
                    sk.ImportData(DataGridView7.CurrentCell, new Point(550, 232));
                    sk.ShowDialog();
                }
            }
        }
        public void TabpagesChanged()
        {
            if (PLC.InitSetValue[13] == 1)
            {
                TabPage1.Parent = TabControl1;
                TabPage2.Parent = null;
                TabPage3.Parent = TabControl1;
                TabPage4.Parent = TabControl1;
                TabPage5.Parent = null;
                TabPage6.Parent = TabControl1;
                TabPage7.Parent = Level.KayexAdmin == true ? TabControl1 : null;
            }
            else
            {
                TabPage1.Parent = TabControl1;
                TabPage2.Parent = TabControl1;
                TabPage3.Parent = null;
                TabPage4.Parent = TabControl1;
                TabPage5.Parent = null;
                TabPage6.Parent = TabControl1;
                TabPage7.Parent = null;
            }
        }
        private void ProcStab7_FormClosed(object sender, FormClosedEventArgs e)
        {
            Level.KayexAdmin = false;
        }
        private void DataGridView8_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (ProcSel.AgreeEdit == 1)
                {
                    SmallKey sk = new SmallKey();
                    if (Cursor.Position.X >= 658)
                    {
                        sk.ImportData(DataGridView8.CurrentCell, new Point(200, 232));
                    }
                    else
                    {
                        sk.ImportData(DataGridView8.CurrentCell, new Point(768, 232));
                    }
                    sk.ShowDialog();
                }
            }
        }
      
    }
}
