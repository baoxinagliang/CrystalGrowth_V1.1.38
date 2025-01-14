using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.SOP
{
    internal partial class ProcStab4 : Form
    {
        public ProcStab4()
        {
            InitializeComponent();
            DataGridView1.Rows.Add(20);
            DataGridView1.Rows[0].HeaderCell.Value = "熔接目标温度上限(degC)";
            DataGridView1.Rows[1].HeaderCell.Value = "熔接目标温度下限(degC)";
            DataGridView1.Rows[2].HeaderCell.Value = "熔接超温报警上限(degC)";
            DataGridView1.Rows[3].HeaderCell.Value = "熔接超温报警下限(degC)";
            DataGridView1.Rows[4].HeaderCell.Value = "升温目标功率(主加)(kw)";
            DataGridView1.Rows[5].HeaderCell.Value = "降温目标功率(主加)(kw)";
            DataGridView1.Rows[6].HeaderCell.Value = "升温功率变化速率(主加)(kw/hr)";
            DataGridView1.Rows[7].HeaderCell.Value = "降温功率变化速率(主加)(kw/hr)";
            DataGridView1.Rows[8].HeaderCell.Value = "升降温功率给定方式(0固定值 1速率)";
            DataGridView1.Rows[9].HeaderCell.Value = "底加功率(kw)";
            DataGridView1.Rows[10].HeaderCell.Value = "熔接时间(min)";
            DataGridView1.Rows[11].HeaderCell.Value = "籽晶最小熔接直径(mm)";
            DataGridView1.Rows[12].HeaderCell.Value = "晶转(rpm)";
            DataGridView1.Rows[13].HeaderCell.Value = "埚转(rpm)";
            DataGridView1.Rows[14].HeaderCell.Value = "氩气流量(slpm)";
            DataGridView1.Rows[15].HeaderCell.Value = "液口距报警上限(mm)";
            DataGridView1.Rows[16].HeaderCell.Value = "液口距报警下限(mm)";
            DataGridView1.Rows[17].Visible = false;
            DataGridView1.Rows[18].Visible = false;
            DataGridView1.Rows[19].Visible = false;
            DataGridView2.Rows.Add(11);
            DataGridView2.Rows[0].HeaderCell.Value = "籽晶位置1(mm)";
            DataGridView2.Rows[1].HeaderCell.Value = "静置时间1(min)";
            DataGridView2.Rows[2].HeaderCell.Value = "籽晶位置2(mm)";
            DataGridView2.Rows[3].HeaderCell.Value = "静置时间2(min)";
            DataGridView2.Rows[4].HeaderCell.Value = "籽晶位置3(mm)";
            DataGridView2.Rows[5].HeaderCell.Value = "静置时间3(min)";
            for (int i = 6; i < 11; i++)
            {
                DataGridView2.Rows[i].Visible = false;
            }
            DataGridView3.Rows.Add(5);
            DataGridView3.Rows[0].HeaderCell.Value = "预调温基础功率系数";
            DataGridView3.Rows[1].HeaderCell.Value = "预调温目标液面温度(degC)";
            DataGridView3.Rows[2].HeaderCell.Value = "预调温增益";
            DataGridView3.Rows[3].HeaderCell.Value = "预调温功率上限(kw)";
            DataGridView3.Rows[4].HeaderCell.Value = "预调温功率下限(kw)";
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
    }
}
