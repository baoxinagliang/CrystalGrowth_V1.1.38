using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction
{
    internal partial class FrmCtlSel : Form
    {
        private int SelFlag1 = 0;
        private int SelFlag3 = 0;
        public FrmCtlSel()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void FrmCtlSel_Load(object sender, EventArgs e)
        {
            // 隐藏和拉晶控制选择部分
            Label1.Visible = false;
            DataGridView1.Visible = false;
            BtnHtrSel.Visible = false;
            DataGridView1.Rows.Add(2);
            DataGridView1.Rows[0].Cells[0].Value = "传统拉晶工艺";
            DataGridView1.Rows[1].Cells[0].Value = "第二拉晶工艺";
            DataGridView3.Rows.Add(2);
            DataGridView3.Rows[0].Cells[0].Value = "节流阀控制";
            DataGridView3.Rows[1].Cells[0].Value = "干泵变频控制";
        }
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView1.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.Blue;
            DataGridView1.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.White;
            SelFlag1 = e.RowIndex + 1;
        }
        private void DataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView3.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.Blue;
            DataGridView3.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.White;
            SelFlag3 = e.RowIndex + 1;
        }
        private void BtnHtrSel_Click(object sender, EventArgs e)
        {
            if (SelFlag1 > 0)
            {
                if (DouClick.ThreeSec(ref BtnHtrSel))
                {
                    // 默认选择第二拉晶工艺 
                    PLC.SendBit(30, 81, 1);
                }
            }
        }
        private void BtnPressCtl_Click(object sender, EventArgs e)
        {
            if (SelFlag3 > 0)
            {
                if (DouClick.ThreeSec(ref BtnPressCtl))
                {
                    switch (SelFlag3)
                    {
                        case 1:
                            PLC.SendBit(30, 83, 0);
                            break;
                        case 2:
                            PLC.SendBit(30, 83, 1);
                            break;
                    }
                }
            }
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (PLC.ReadStatus[57] == 0)
            {
                DataGridView1.Rows[0].Cells[1].Value = "ON";
                DataGridView1.Rows[1].Cells[1].Value = "OFF";
            }
            else
            {
                DataGridView1.Rows[0].Cells[1].Value = "OFF";
                DataGridView1.Rows[1].Cells[1].Value = "ON";
            }
            if (PLC.ReadStatus[60] == 0)
            {
                DataGridView3.Rows[0].Cells[1].Value = "ON";
                DataGridView3.Rows[1].Cells[1].Value = "OFF";
            }
            else
            {
                DataGridView3.Rows[0].Cells[1].Value = "OFF";
                DataGridView3.Rows[1].Cells[1].Value = "ON";
            }
            BtnHtrSel.Enabled = PLC.ReadStatus[1] == 0;
            BtnPressCtl.Enabled = PLC.ReadStatus[10] == 0;
        }
    }
}
