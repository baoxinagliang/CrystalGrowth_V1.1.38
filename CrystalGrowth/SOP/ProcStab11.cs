using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.SOP
{
    internal partial class ProcStab11 : Form
    {
        public ProcStab11()
        {
            InitializeComponent();
            DataGridView1.Rows.Add(16);
            DataGridView1.Rows[0].HeaderCell.Value = "停炉坩埚立即下降距离(mm)";
            DataGridView1.Rows[1].HeaderCell.Value = "晶体提升速度(mm/hr)";
            DataGridView1.Rows[2].HeaderCell.Value = "晶体提升时间(s)";
            DataGridView1.Rows[3].HeaderCell.Value = "功率下降速度(kw/s)";
            DataGridView1.Rows[4].HeaderCell.Value = "氩气关闭时间(min)";
            DataGridView1.Rows[5].HeaderCell.Value = "保压压力(torr)";
            DataGridView1.Rows[6].HeaderCell.Value = "做热泄漏检测(1=是 0=否)";
            DataGridView1.Rows[7].HeaderCell.Value = "热泄漏抽空时间(min)";
            DataGridView1.Rows[8].HeaderCell.Value = "最大热泄漏率(mtorr/hr)";
            DataGridView1.Rows[9].HeaderCell.Value = "泄漏率检测时间(min)";
            DataGridView1.Rows[10].HeaderCell.Value = "充氩气开启时间(min)";
            DataGridView1.Rows[11].HeaderCell.Value = "晶转速度设置(rpm)";
            DataGridView1.Rows[12].HeaderCell.Value = "埚转速度设置(rpm)";
            DataGridView1.Rows[13].HeaderCell.Value = "热屏坩埚动作时间到坩埚下降行程(mm)";
            DataGridView1.Rows[14].HeaderCell.Value = "热屏坩埚动作时间到热屏上升行程(mm)";
            DataGridView1.Rows[15].HeaderCell.Value = "热屏坩埚动作时间(min)";
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
    }
}
