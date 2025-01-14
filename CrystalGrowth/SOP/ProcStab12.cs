using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.SOP
{
    internal partial class ProcStab12 : Form
    {
        public ProcStab12()
        {
            InitializeComponent();
            DataGridView1.Rows.Add(7);
            DataGridView1.Rows[0].HeaderCell.Value = "抽空I压力(torr)";
            DataGridView1.Rows[1].HeaderCell.Value = "快充I压力(torr)";
            DataGridView1.Rows[2].HeaderCell.Value = "抽空II压力(torr)";
            DataGridView1.Rows[3].HeaderCell.Value = "快充II压力(torr)";
            DataGridView1.Rows[4].HeaderCell.Value = "抽空/快充II次数";
            DataGridView1.Rows[5].HeaderCell.Value = "目标压力偏移量(torr)";
            DataGridView1.Rows[6].HeaderCell.Value = "副室净化超时时间(s)";
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
