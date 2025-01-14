using CrystalGrowth.Unities;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.SOP
{
    internal partial class ProcStab8 : Form
    {
        public ProcStab8()
        {
            InitializeComponent();
            DataGridView1.Rows.Add(17);
            DataGridView1.Rows[0].HeaderCell.Value = "起始晶升速度(mm/hr)";
            DataGridView1.Rows[1].HeaderCell.Value = "直径控制打开长度(mm)";
            DataGridView1.Rows[2].HeaderCell.Value = "转肩方式选择（0=传统方式 1=斜率方式）";
            DataGridView1.Rows[3].HeaderCell.Value = "埚跟比控制埚升上限(mm/hr)";
            DataGridView1.Rows[4].HeaderCell.Value = "转肩下降温度(units)";
            DataGridView1.Rows[5].HeaderCell.Value = "转肩功率偏移(kw)";
            DataGridView1.Rows[6].HeaderCell.Value = "转肩埚升控制选择(0=埚跟比 1=液口距 2=埚跟比+液口距)";
            DataGridView1.Rows[7].HeaderCell.Value = "转肩压力设置";
            if (PLC.ReadStatus[57] == 1)
            {
                DataGridView1.Rows[4].Visible = false;
                DataGridView1.Rows[5].Visible = true;
            }
            else
            {
                DataGridView1.Rows[4].Visible = true;
                DataGridView1.Rows[5].Visible = false;
            }
            for (int i = 8; i <= 16; i++)
            {
                DataGridView1.Rows[i].Visible = false;
            }
            DataGridView3.Rows.Add(16);
            for (int i = 1; i <= 16; i++)
            {
                DataGridView3.Rows[i - 1].HeaderCell.Value = i.ToString();
            }
            DataGridView4.Rows.Add(5);
            DataGridView4.Rows[0].HeaderCell.Value = "直径控制-增益(传统方式)";
            DataGridView4.Rows[1].HeaderCell.Value = "直径控制-微分(传统方式min)";
            DataGridView4.Rows[2].HeaderCell.Value = "直径控制-积分(传统方式1/min)";
            DataGridView4.Rows[3].HeaderCell.Value = "直径控制-晶升上限(mm/hr)";
            DataGridView4.Rows[4].HeaderCell.Value = "直径控制-晶升下限(mm/hr)";
            DataGridView5.Rows.Add(5);
            DataGridView5.Rows[0].HeaderCell.Value = "转肩完成直径变化率(mm/min)";
            DataGridView5.Rows[1].HeaderCell.Value = "转肩完成变化率延迟时间(s)";
            DataGridView5.Rows[2].HeaderCell.Value = "转肩直径设定变化率（传统方式）";
            for (int i = 3; i <= 4; i++)
            {
                DataGridView5.Rows[i].Visible = false;
            }
            DataGridView6.Rows.Add(10);
            for (int i = 0; i < 10; i++)
            {
                DataGridView6.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
            DataGridView7.Rows.Add(8);
            for (int i = 0; i < 8; i++)
            {
                DataGridView7.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
            DataGridView2.Rows.Add(11);
            DataGridView2.Rows[0].HeaderCell.Value = "液口距控制-增益";
            DataGridView2.Rows[1].HeaderCell.Value = "液口距控制-微分(min)";
            DataGridView2.Rows[2].HeaderCell.Value = "液口距控制-积分(1/min)";
            DataGridView2.Rows[3].HeaderCell.Value = "头部埚升上限(mm/hr)";
            DataGridView2.Rows[4].HeaderCell.Value = "头部Xmm埚升上限";
            DataGridView2.Rows[5].HeaderCell.Value = "头部长度(mm)";
            DataGridView2.Rows[6].HeaderCell.Value = "尾部埚升上限(mm/hr)";
            DataGridView2.Rows[7].HeaderCell.Value = "埚升下限(mm/hr)";
            DataGridView2.Rows[8].HeaderCell.Value = "剩余重量(kg)";
            DataGridView2.Rows[9].HeaderCell.Value = "起始埚升速度(mm/hr)";
            DataGridView2.Rows[10].HeaderCell.Value = "液口距设定变化率(mm/min)";
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
                    sk.ImportData(DataGridView2.CurrentCell, new Point(550, 232));
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
                    sk.ImportData(DataGridView3.CurrentCell, new Point(950, 232));
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
                    sk.ImportData(DataGridView4.CurrentCell, new Point(550, 232));
                    sk.ShowDialog();
                }
            }
        }
        private void DataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 & e.ColumnIndex >= 0)
            {
                if (ProcSel.AgreeEdit == 1)
                {
                    SmallKey sk = new SmallKey();
                    sk.ImportData(DataGridView5.CurrentCell, new Point(500, 232));
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
                    if (Cursor.Position.X >= 658)
                    {
                        sk.ImportData(DataGridView6.CurrentCell, new Point(200, 232));
                    }
                    else
                    {
                        sk.ImportData(DataGridView6.CurrentCell, new Point(768, 232));
                    }
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
                    if (Cursor.Position.X >= 658)
                    {
                        sk.ImportData(DataGridView7.CurrentCell, new Point(200, 232));
                    }
                    else
                    {
                        sk.ImportData(DataGridView7.CurrentCell, new Point(768, 232));
                    }
                    sk.ShowDialog();
                }
            }
        }
    }
}
