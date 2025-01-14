using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.SOP
{
    internal partial class ProcStab21 : Form
    {
        public ProcStab21()
        {
            InitializeComponent();
            DataGridView1.Rows.Add(4);
            DataGridView1.Rows[0].HeaderCell.Value = "埚升装料位置(mm)";
            DataGridView1.Rows[1].HeaderCell.Value = "埚升下降位置(mm)";
            DataGridView1.Rows[2].HeaderCell.Value = "主室悬臂装料下降时间(s)";
            DataGridView1.Rows[3].HeaderCell.Value = "主室悬臂返回下降时间(s)";
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
