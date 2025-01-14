using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.SOP
{
    internal partial class ProcStab16 : Form
    {
        public ProcStab16()
        {
            InitializeComponent();
            DataGridView1.Rows.Add(15);
            DataGridView1.Rows[0].HeaderCell.Value = "籽晶位置偏移1(mm)";
            DataGridView1.Rows[1].HeaderCell.Value = "籽晶位置偏移2(mm)";
            DataGridView1.Rows[2].HeaderCell.Value = "籽晶位置偏移3(mm)";
            DataGridView1.Rows[3].HeaderCell.Value = "籽晶位置触发(mm)";
            DataGridView1.Rows[4].HeaderCell.Value = "静置时间2(min)";
            DataGridView1.Rows[4].Visible = false;
            DataGridView1.Rows[5].HeaderCell.Value = "静置时间3(min)";
            DataGridView1.Rows[5].Visible = false;
            DataGridView1.Rows[6].HeaderCell.Value = "最终上升位置(mm)";
            DataGridView1.Rows[7].HeaderCell.Value = "最终下降位置(mm)";
            DataGridView1.Rows[8].HeaderCell.Value = "副室上升超时保护(s)";
            DataGridView1.Rows[9].HeaderCell.Value = "副室旋转超时保护(s)";
            DataGridView1.Rows[10].HeaderCell.Value = "主加功率设定值(kw)";
            DataGridView1.Rows[11].HeaderCell.Value = "底加功率设定值(kw)";
            DataGridView1.Rows[12].HeaderCell.Value = "坩埚下降距离(mm)";
            DataGridView1.Rows[13].HeaderCell.Value = "晶转(rpm)";
            DataGridView1.Rows[14].HeaderCell.Value = "埚转(rpm)";
            DataGridView2.Rows.Add(5);
            for (int i = 0; i < 5; i++)
            {
                DataGridView2.Rows[i].HeaderCell.Value = i.ToString();
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
                    if (Cursor.Position.X >= 658)
                    {
                        sk.ImportData(DataGridView2.CurrentCell, new Point(200, 232));
                    }
                    else
                    {
                        sk.ImportData(DataGridView2.CurrentCell, new Point(768, 232));
                    }
                    sk.ShowDialog();
                }
            }
        }
    }
}
