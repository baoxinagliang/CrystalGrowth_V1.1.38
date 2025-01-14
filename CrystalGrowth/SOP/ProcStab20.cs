using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.SOP
{
    internal partial class ProcStab20 : Form
    {
        public ProcStab20()
        {
            InitializeComponent();
            DataGridView1.Rows.Add(5);
            DataGridView1.Rows[0].HeaderCell.Value = "主炉筒升超时保护(s)";
            DataGridView1.Rows[1].HeaderCell.Value = "主炉筒降超时保护(s)";
            DataGridView1.Rows[1].Visible = false;
            DataGridView1.Rows[2].HeaderCell.Value = "主室提升臂旋转超时保护(s)";
            DataGridView1.Rows[3].HeaderCell.Value = "主炉筒旋回下降时间(s)";
            DataGridView1.Rows[4].HeaderCell.Value = "主炉筒旋出下降时间(s)";
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
