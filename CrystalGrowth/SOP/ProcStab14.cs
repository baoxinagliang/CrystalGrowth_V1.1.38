using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.SOP
{
    internal partial class ProcStab14 : Form
    {
        public ProcStab14()
        {
            InitializeComponent();
            DataGridView1.Rows.Add(5);
            DataGridView1.Rows[0].HeaderCell.Value = "热场控制-增益";
            DataGridView1.Rows[1].HeaderCell.Value = "热场控制-微分(min)";
            DataGridView1.Rows[2].HeaderCell.Value = "热场控制-积分(1/min)";
            DataGridView1.Rows[3].HeaderCell.Value = "热场控制-功率上限(kw)";
            DataGridView1.Rows[4].HeaderCell.Value = "热场控制-功率下限(kw)";
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
