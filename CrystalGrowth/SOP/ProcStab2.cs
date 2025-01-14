using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.SOP
{
    internal partial class ProcStab2 : Form
    {
        public ProcStab2()
        {
            InitializeComponent();
            DataGridView1.Rows.Add(14);
            DataGridView1.Rows[0].HeaderCell.Value = "抽空到1Torr检测时间(min)";
            DataGridView1.Rows[1].HeaderCell.Value = "抽空I时间(min)";
            DataGridView1.Rows[2].HeaderCell.Value = "抽空I氩气流量(slpm)";
            DataGridView1.Rows[3].HeaderCell.Value = "抽空I通氩气时间(sec)";
            DataGridView1.Rows[4].HeaderCell.Value = "抽空II时间(min)";
            DataGridView1.Rows[5].HeaderCell.Value = "抽空II氩气流量(slpm)";
            DataGridView1.Rows[6].HeaderCell.Value = "抽空II通氩气时间(sec)";
            DataGridView1.Rows[7].HeaderCell.Value = "抽空II次数";
            DataGridView1.Rows[8].HeaderCell.Value = "基本压力检测时间(min)";
            DataGridView1.Rows[9].HeaderCell.Value = "基本真空压力(mtorr)";
            DataGridView1.Rows[10].HeaderCell.Value = "基本压力维持时间(min)";
            DataGridView1.Rows[11].HeaderCell.Value = "最大泄漏率(mtorr/hr)";
            DataGridView1.Rows[12].HeaderCell.Value = "最小泄漏率(mtorr/hr)";
            DataGridView1.Rows[13].HeaderCell.Value = "泄漏率检测时间(min)";
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
