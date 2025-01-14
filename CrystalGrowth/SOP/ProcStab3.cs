using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.SOP
{
    internal partial class ProcStab3 : Form
    {
        public ProcStab3()
        {
            InitializeComponent();
            DataGridView1.Rows.Add(9);
            DataGridView1.Rows[0].HeaderCell.Value = "氩气流量(splm)";
            DataGridView1.Rows[1].HeaderCell.Value = "压力设定值(torr)";
            DataGridView1.Rows[2].HeaderCell.Value = "压力上限值(torr)";
            DataGridView1.Rows[3].HeaderCell.Value = "压力下限值(torr)";
            for (int i = 4; i <= 8; i++)
            {
                DataGridView1.Rows[i].Visible = false;
            }
            DataGridView2.Rows.Add(6);
            DataGridView2.Rows[0].HeaderCell.Value = "抽空方式选择(0=给定频率/开度； 1=给定压力)";
            for (int i = 1; i <= 5; i++)
            {
                DataGridView2.Rows[i].Visible = false;
            }
            DataGridView3.Rows.Add(10);
            for (int i = 0; i < 10; i++)
            {
                DataGridView3.Rows[i].HeaderCell.Value = (i + 1).ToString();
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
                    sk.ImportData(DataGridView2.CurrentCell, new Point(500, 232));
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
                    if (Cursor.Position.X >= 658)
                    {
                        sk.ImportData(DataGridView3.CurrentCell, new Point(200, 232));
                    }
                    else
                    {
                        sk.ImportData(DataGridView3.CurrentCell, new Point(768, 232));
                    }
                    sk.ShowDialog();
                }
            }
        }
    }
}
