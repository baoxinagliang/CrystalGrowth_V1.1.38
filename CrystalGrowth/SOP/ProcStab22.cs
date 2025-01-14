using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.SOP
{
    internal partial class ProcStab22 : Form
    {
        public ProcStab22()
        {
            InitializeComponent();
            DataGridView1.Rows.Add(13);
            DataGridView1.Rows[0].HeaderCell.Value = "回熔肩部(1:是；0：否)";
            DataGridView1.Rows[1].HeaderCell.Value = "回熔方式选择(1：时间；0：熔接板)";
            DataGridView1.Rows[1].Visible = false;
            DataGridView1.Rows[2].HeaderCell.Value = "氩气流量设定(slpm)";
            DataGridView1.Rows[3].HeaderCell.Value = "主加热器功率设定(kw)";
            DataGridView1.Rows[4].HeaderCell.Value = "低加热器功率设定(kw)";
            DataGridView1.Rows[5].HeaderCell.Value = "晶转(rpm)";
            DataGridView1.Rows[6].HeaderCell.Value = "埚转(rpm)";
            for (int i = 7; i <= 12; i++)
            {
                DataGridView1.Rows[i].Visible = false;
            }
            DataGridView2.Rows.Add(16);
            DataGridView2.Rows[0].HeaderCell.Value = "阶段1坩埚位置偏移量(mm)";
            DataGridView2.Rows[1].HeaderCell.Value = "阶段1晶体提升距离(mm)";
            DataGridView2.Rows[2].HeaderCell.Value = "阶段1静置时间(s)";
            for (int i = 3; i <= 6; i++)
            {
                DataGridView2.Rows[i].Visible = false;
            }
            DataGridView2.Rows[7].HeaderCell.Value = "阶段2坩埚相对引晶埚位偏移位置(mm)";
            DataGridView2.Rows[8].HeaderCell.Value = "阶段2静置时间(s)";
            for (int i = 9; i <= 12; i++)
            {
                DataGridView2.Rows[i].Visible = false;
            }
            DataGridView2.Rows[13].HeaderCell.Value = "阶段3晶体到达熔接面静置时间(s)";
            DataGridView2.Rows[14].HeaderCell.Value = "阶段3晶体单次下降距离(mm)";
            DataGridView2.Rows[15].HeaderCell.Value = "阶段3晶体单次静置时间(s)";
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
    }
}
