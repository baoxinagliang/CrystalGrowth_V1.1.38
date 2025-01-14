using CrystalGrowth.Unities;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.SOP
{
    internal partial class ProcStab6 : Form
    {
        public ProcStab6()
        {
            InitializeComponent();
            DataGridView1.Rows.Add(14);
            DataGridView1.Rows[0].HeaderCell.Value = "细颈前延长长度(mm)";
            DataGridView1.Rows[1].HeaderCell.Value = "目标直径(mm)";
            DataGridView1.Rows[2].HeaderCell.Value = "直径控制打开时间(s)";
            DataGridView1.Rows[3].HeaderCell.Value = "起始晶升速度(mm/hr)";
            DataGridView1.Rows[4].HeaderCell.Value = "目标晶升速度(mm/hr)";
            DataGridView1.Rows[5].HeaderCell.Value = "目标长度(mm)";
            DataGridView1.Rows[6].HeaderCell.Value = "最小安全直径(mm)";
            DataGridView1.Rows[7].HeaderCell.Value = "最大报警直径(mm)";
            DataGridView1.Rows[8].HeaderCell.Value = "安全晶升速度(mm/hr)";
            DataGridView1.Rows[9].HeaderCell.Value = "直径设定变化率(mm/min)";
            DataGridView1.Rows[10].HeaderCell.Value = "热场温度设定只减少(1=是 0=否)";
            DataGridView1.Rows[11].HeaderCell.Value = "最小报警直径(mm)";
            DataGridView1.Rows[12].HeaderCell.Value = "后段最小平均生长速度(mm/hr)";
            DataGridView1.Rows[13].HeaderCell.Value = "后段最大平均生长速度(mm/hr)";
            if (PLC.ReadStatus[57] == 1)
            {
                DataGridView1.Rows[10].Visible = false;
            }
            else
            {
                DataGridView1.Rows[10].Visible = true;
            }
            DataGridView2.Rows.Add(10);
            DataGridView2.Rows[0].HeaderCell.Value = "直径控制-增益";
            DataGridView2.Rows[1].HeaderCell.Value = "直径控制-微分(min)";
            DataGridView2.Rows[2].HeaderCell.Value = "直径控制-积分(1/min)";
            DataGridView2.Rows[3].HeaderCell.Value = "直径控制-晶升上限(mm/hr)";
            DataGridView2.Rows[4].HeaderCell.Value = "直径控制-晶升下限(mm/hr)";
            DataGridView2.Rows[5].HeaderCell.Value = "生长控制-增益";
            DataGridView2.Rows[6].HeaderCell.Value = "生长控制-温度上限(units)";
            DataGridView2.Rows[7].HeaderCell.Value = "生长控制-温度下限(units)";
            DataGridView2.Rows[8].HeaderCell.Value = "生长控制-功率上限(kw)";
            DataGridView2.Rows[9].HeaderCell.Value = "生长控制-功率下限(kw)";
            DataGridView2.Rows[0].Visible = false;
            DataGridView2.Rows[1].Visible = false;
            DataGridView2.Rows[2].Visible = false;
            DataGridView2.Rows[3].Visible = false;
            DataGridView2.Rows[4].Visible = false;
            if (PLC.ReadStatus[57] == 1)
            {
                DataGridView2.Rows[6].Visible = false;
                DataGridView2.Rows[7].Visible = false;
                DataGridView2.Rows[8].Visible = true;
                DataGridView2.Rows[9].Visible = true;
            }
            else
            {
                DataGridView2.Rows[6].Visible = true;
                DataGridView2.Rows[7].Visible = true;
                DataGridView2.Rows[8].Visible = false;
                DataGridView2.Rows[9].Visible = false;
            }
            DataGridView3.Rows.Add(1);
            DataGridView3.Rows[0].HeaderCell.Value = "氩气流量(slpm)";
            DataGridView4.Rows.Add(10);
            for (int i = 0; i < 10; i++)
            {
                DataGridView4.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
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

        private void ProcStab6_Load(object sender, System.EventArgs e)
        {
            TabPage3.Parent = null;
        }
    }
}
