using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.SOP
{
    internal partial class ProcStab5 : Form
    {
        public ProcStab5()
        {
            InitializeComponent();
            DataGridView1.Rows.Add(18);
            DataGridView1.Rows[0].HeaderCell.Value = "液面温度设定值(degC)";
            DataGridView1.Rows[1].HeaderCell.Value = "温度偏差范围(degC)";
            DataGridView1.Rows[2].HeaderCell.Value = "稳温时间(min)";
            DataGridView1.Rows[3].HeaderCell.Value = "第一段稳温时间(min)";
            DataGridView1.Rows[4].HeaderCell.Value = "第二段稳温时间(min)";
            DataGridView1.Rows[5].HeaderCell.Value = "第二段稳温控制方式(0开环 1闭环)";
            DataGridView1.Rows[6].HeaderCell.Value = "回调液面温度(degC)";
            DataGridView1.Rows[7].HeaderCell.Value = "斜率回温功率上限(kw)";
            DataGridView1.Rows[8].HeaderCell.Value = "斜率回温功率下限(kw)";
            DataGridView1.Rows[9].HeaderCell.Value = "爬坡升功率触发温度(degC)";
            DataGridView1.Rows[10].HeaderCell.Value = "降温阶段功率系数";
            DataGridView1.Rows[11].HeaderCell.Value = "底部加热功率(kw)";
            DataGridView1.Rows[12].HeaderCell.Value = "晶转(rpm)";
            DataGridView1.Rows[13].HeaderCell.Value = "埚转(rpm)";
            DataGridView1.Rows[14].HeaderCell.Value = "氩气流量(slpm)";
            DataGridView1.Rows[15].HeaderCell.Value = "调温超温报警上限(degC)";
            DataGridView1.Rows[16].HeaderCell.Value = "调温超温报警下限(degC)";
            DataGridView1.Rows[17].HeaderCell.Value = "热场总质量(kg)";
            DataGridView2.Rows.Add(5);
            DataGridView2.Rows[0].HeaderCell.Value = "液面温度-增益";
            DataGridView2.Rows[1].HeaderCell.Value = "液面温度-微分(min)";
            DataGridView2.Rows[2].HeaderCell.Value = "液面温度-积分(1/min)";
            DataGridView2.Rows[3].HeaderCell.Value = "引晶功率偏移上限(kw)";
            DataGridView2.Rows[4].HeaderCell.Value = "引晶功率偏移下限(kw)";
            DataGridView3.Rows.Add(8);
            for (int i = 1; i <= 8; i++)
            {
                DataGridView3.Rows[i - 1].HeaderCell.Value = i.ToString();
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
                    sk.ImportData(DataGridView3.CurrentCell, new Point(950, 232));
                    sk.ShowDialog();
                }
            }
        }
    }
}
