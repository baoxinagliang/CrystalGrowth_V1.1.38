using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.SOP
{
    internal partial class ProcStab23 : Form
    {
        public ProcStab23()
        {
            InitializeComponent();
            DataGridView1.Rows.Add(4);
            DataGridView1.Rows[0].HeaderCell.Value = "目标放埚像素值(pxl)";
            DataGridView1.Rows[1].HeaderCell.Value = "最大坩埚位置(mm)";
            DataGridView1.Rows[2].HeaderCell.Value = "坩埚上升超时时间(s)";
            DataGridView1.Rows[3].HeaderCell.Value = "埚升1mm最小像素随动值(pxl)";
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
