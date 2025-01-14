using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace CrystalGrowth.CrystalCtl
{
    internal partial class FrmCrucLiftActived : Form
    {
        bool MouseDownFlag = false;
        public FrmCrucLiftActived()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (PLC.Count == 2)
            {
                LabLiquidDepth.Text = Math.Round(PLC.ReadValue[117], 1).ToString("f1");
                LabCrucPos.Text = Math.Round(PLC.ReadValue[59], 1).ToString("f1");
                LabCL.Text = Math.Round(PLC.ReadValue[54], 1).ToString("f1");
                BtnUp.BackColor = PLC.ReadStatus[17] == 1 ? Color.Red : Color.Blue;
                BtnDown.BackColor = PLC.ReadStatus[18] == 1 ? Color.Red : Color.Blue;
                BtnFast.Enabled = PLC.ReadStatus[19] != 1 && PLC.ReadStatus[25] != 1;
                BtnFast.BackColor = PLC.ReadStatus[20] == 1 ? Color.Red : Color.Blue;
                if (PLC.ReadStatus[19] == 1 || PLC.ReadStatus[20] == 1)
                {
                    BtnUp.Enabled = false;
                    BtnDown.Enabled = false;
                }
                else
                {
                    BtnUp.Enabled = true;
                    BtnDown.Enabled = true;
                }
            }
        }
        private void BtnUp_Click(object sender, EventArgs e)
        {
            PLC.SendBit(30, 26, 1);
            Record.WriteIn("埚升快速上升", "ON", "Yellow");
            BtnUp.BackColor = Color.Red;
            BtnDown.BackColor = Color.Blue;
        }
        private void BtnDown_Click(object sender, EventArgs e)
        {
            PLC.SendBit(30, 27, 1);
            Record.WriteIn("埚升快速下降", "ON", "Yellow");
            BtnUp.BackColor = Color.Blue;
            BtnDown.BackColor = Color.Red;
        }
        private void BtnFast_MouseDown(object sender, MouseEventArgs e)
        {
            //FrmCrucLift,BtnSlow.BackColor=Color.Blue;
            if (PLC.ReadStatus[19] == 0)
            {
                PLC.SendBit(30, 29, 1);
                Record.WriteIn("埚升快速按下", "ON", "Yellow");
                BtnFast.BackColor = Color.Red;
                BtnUp.Enabled = false;
                BtnDown.Enabled = false;
            }
            MouseDownFlag = true;
        }
        private void BtnFast_MouseUp(object sender, MouseEventArgs e)
        {
            PLC.SendBit(30, 30, 1);
            Record.WriteIn("埚升快速松开", "ON", "Yellow");
            BtnFast.BackColor = Color.Blue;
            BtnUp.Enabled = true;
            BtnDown.Enabled = true;
        }
        private void BtnFast_MouseLeave(object sender, EventArgs e)
        {
            if (MouseDownFlag)
            {
                PLC.SendBit(30, 30, 1);
                Record.WriteIn("埚升快速离开", "ON", "Yellow");
                BtnFast.BackColor = Color.Blue;
                BtnUp.Enabled = true;
                BtnDown.Enabled = true;
            }
        }
        private void BtnFast_MouseHover(object sender, EventArgs e)
        {
            toolTip1.AutoPopDelay = 5000;//设置显示样式       
            toolTip1.InitialDelay = 500;   //提示信息的可见时间
            toolTip1.ReshowDelay = 500;//事件触发多久后出现提示
            toolTip1.ShowAlways = true; //指针从一个控件移向另一个控件时，经过多久才会显示下一个提示框
            //是否显示提示框,设置伴随的对象,设置提示按钮和提示内容
            toolTip1.SetToolTip(BtnFast, "警告：请确认炉内是否为高温状态,\r\n打开快速或点动按钮是否安全？！");
        }
    }
}
