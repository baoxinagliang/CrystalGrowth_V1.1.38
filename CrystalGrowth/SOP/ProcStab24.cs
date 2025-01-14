using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.SOP
{
    public partial class ProcStab24 : Form
    {
        public ProcStab24()
        {
            InitializeComponent();
            DataGridView1.Rows.Add(5);
            for (int i = 1; i <= 5; i++)
            {
                DataGridView1.Rows[i - 1].HeaderCell.Value = i.ToString();
            }
        }
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (ProcSel.AgreeEdit == 1)
                {
                    SmallKey sk = new SmallKey();
                    if (Cursor.Position.X >= 658)
                    {
                        sk.ImportData(DataGridView1.CurrentCell, new Point(200, 232));
                    }
                    else
                    {
                        sk.ImportData(DataGridView1.CurrentCell, new Point(768, 232));
                    }
                    sk.ShowDialog();
                }
            }
        }
    }
}
