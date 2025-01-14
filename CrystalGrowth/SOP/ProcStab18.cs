using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.SOP
{
    internal partial class ProcStab18 : Form
    {
        public ProcStab18()
        {
            InitializeComponent();
            DataGridView1.Rows.Add(3);
            DataGridView1.Rows[0].HeaderCell.Value = "晶升目标位置(mm)";
            DataGridView1.Rows[1].HeaderCell.Value = "副室下降时间(s)";
            DataGridView1.Rows[2].HeaderCell.Value = "允许最大净重(kg)";
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
