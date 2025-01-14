using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.SOP
{
    internal partial class ProcStab17 : Form
    {
        public ProcStab17()
        {
            InitializeComponent();
            DataGridView1.Rows.Add(14);
            DataGridView1.Rows[0].HeaderCell.Value = "料筒提出-保压压力(torr)";
            DataGridView1.Rows[1].HeaderCell.Value = "料筒提出-保压时间(min)";
            DataGridView1.Rows[2].HeaderCell.Value = "料筒提入/提出-自动提升目标位置(mm)";
            DataGridView1.Rows[3].HeaderCell.Value = "料筒提出-自动提升触发位置(mm)";
            DataGridView1.Rows[4].HeaderCell.Value = "料筒提出-自动下降目标位置(mm)";
            DataGridView1.Rows[5].HeaderCell.Value = "料筒提入-自动提升触发位置(mm)";
            DataGridView1.Rows[6].HeaderCell.Value = "加料过程-自动下降目标位置(mm)";
            DataGridView1.Rows[7].HeaderCell.Value = "料筒提入-下降时间(s)";
            DataGridView1.Rows[8].HeaderCell.Value = "副室上升超时保护(s)";
            DataGridView1.Rows[9].HeaderCell.Value = "副室旋转超时保护(s)";
            DataGridView1.Rows[10].HeaderCell.Value = "料筒提出埚转设定(rmp)";
            DataGridView1.Rows[11].HeaderCell.Value = "料筒提入-二加副室净化主加功率设定(kw)";
            DataGridView1.Rows[12].HeaderCell.Value = "料筒提入-二加副室净化底加功率设定(kw)";
            DataGridView1.Rows[13].HeaderCell.Value = "自动加料超时时间(s)";
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
