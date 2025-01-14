using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.CrystalCtl
{
    internal partial class FrmCrucLift : Form
    {
        public FrmCrucLift()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (PLC.Count == 2)
            {
                LabSP.Text = Math.Round(PLC.ReadValue[37], 1).ToString("f1");
                LabPV.Text = Math.Round(PLC.ReadValue[54], 1).ToString("f1");
                LabCrucPos.Text = Math.Round(PLC.ReadValue[59], 1).ToString("f1");
                BtnUp.BackColor = PLC.ReadStatus[17] == 1 ? Color.Red : Color.Blue;
                BtnDown.BackColor = PLC.ReadStatus[18] == 1 ? Color.Red : Color.Blue;
                BtnSlow.BackColor = PLC.ReadStatus[19] == 1 ? Color.Red : Color.Blue;
                BtnFastCrucPos.Enabled = PLC.ReadStatus[19] != 1 && PLC.ReadStatus[25] != 1;
                if (PLC.ReadStatus[20] == 1)
                {
                    BtnFastCrucPos.BackColor = Color.Red;
                    BtnSlow.Enabled = false;
                }
                else
                {
                    BtnFastCrucPos.BackColor = Color.Blue;
                    BtnSlow.Enabled = true;
                }
                if (PLC.ReadStatus[19] == 1 || PLC.ReadStatus[20] == 1)
                {
                    BtnUp.Enabled = false;
                    BtnDown.Enabled = false;
                    BtnBoxCtl.Enabled = false;
                }
                else
                {
                    BtnUp.Enabled = true;
                    BtnDown.Enabled = true;
                    BtnBoxCtl.Enabled = true;
                }
                BtnForce.Visible = PLC.ReadStatus[36] == 1;
                BtnForce.BackColor = PLC.ReadStatus[37] == 1 ? Color.Red : Color.Blue;
                //手柄控制显示
                BtnBoxCtl.BackColor = PLC.ReadStatus[75] == 1 ? Color.Red : Color.Blue;
                BtnBoxCtl.Visible = PLC.ReadStatus[1] != 1 || PLC.ReadValue[1] == 8;
                if (PLC.ReadStatus[85] == 1)
                {
                    BtnMeltGapBlock.BackColor = Color.Red;
                    BtnMeltGapBlock.Text = "视觉液口距保护取消";
                }
                else
                {
                    BtnMeltGapBlock.BackColor = Color.Blue;
                    BtnMeltGapBlock.Text = "视觉液口距保护屏蔽";
                }
            }
        }
        private void LabSP_Click(object sender, EventArgs e)
        {
            if (LabSP.BackColor == Color.White)
            {
                KeyForm kf = new KeyForm();
                kf.ImportData(ref LabSP, 0, 127);
                kf.ShowDialog();
                if (kf.DialogResult == DialogResult.OK)
                {
                    PLC.SendFloat(33, 140, Convert.ToSingle(LabSP.Text));
                    if (PLC.ReadStatus[19] == 1)
                    {
                        Record.WriteIn("埚升速度设定", LabSP.Text, "Yellow");
                    }
                }
            }
        }
        private void BtnUp_Click(object sender, EventArgs e)
        {
            PLC.SendBit(30, 26, 1);
            Record.WriteIn("埚升上升", "ON", "Yellow");
            BtnUp.BackColor = Color.Red;
            BtnDown.BackColor = Color.Blue;
        }
        private void BtnDown_Click(object sender, EventArgs e)
        {
            PLC.SendBit(30, 27, 1);
            Record.WriteIn("埚升下降", "ON", "Yellow");
            BtnUp.BackColor = Color.Blue;
            BtnDown.BackColor = Color.Red;
        }
        private void BtnSlow_Click(object sender, EventArgs e)
        {
            if (BtnSlow.BackColor == Color.Red)
            {
                BtnSlow.BackColor = Color.Blue;
                BtnUp.Enabled = true;
                BtnDown.Enabled = true;
                BtnFastCrucPos.Enabled = true;
                BtnBoxCtl.Enabled = true;
                PLC.SendBit(30, 28, 1);
                Record.WriteIn("埚升慢速升降", "OFF", "Yellow");
            }
            else
            {
                BtnSlow.BackColor = Color.Red;
                BtnUp.Enabled = false;
                BtnDown.Enabled = false;
                BtnFastCrucPos.Enabled = false;
                BtnBoxCtl.Enabled = false;
                PLC.SendBit(30, 28, 1);
                Record.WriteIn("埚升慢速升降", "ON", "Yellow");
                Record.WriteIn("   埚升速度设定", Math.Round(PLC.ReadValue[37], 1).ToString("f1"), "Yellow");
            }
        }
        private void BtnForce_Click(object sender, EventArgs e)
        {
            PLC.SendBit(30, 64, 1);
            Record.WriteIn("埚升强制升降", "ON", "Yellow");
            BtnForce.BackColor = BtnForce.BackColor == Color.Red ? Color.Blue : Color.Red;
        }
        private void BtnBoxCtl_Click(object sender, EventArgs e)
        {
            PLC.SendBit(30, 100, 1);
            BtnBoxCtl.BackColor = BtnBoxCtl.BackColor == Color.Red ? Color.Blue : Color.Red;
            LabName.Focus();
        }
        private void FrmCrucLift_MouseHover(object sender, EventArgs e)
        {
            //设置显示样式
            toolTip1.AutoPopDelay = 8000;
            //提示信息的可见时间
            toolTip1.InitialDelay = 500;
            //事件触发多久后出现提示
            toolTip1.ReshowDelay = 500;
            //指针从一个控件移向另一个控件时，经过多久才会显示下一个提示框
            toolTip1.ShowAlways = true;
            //是否显示提示框
            //设置伴随的对象.
            //设置提示按钮和提示内容
            toolTip1.SetToolTip(this, "警告：炉内是否高温或加热器已经打开,\r\n请确认快速或点动按钮状态是否安全！");
        }
        private void BtnFastCrucPos_Click(object sender, EventArgs e)
        {
            FrmSwitch.LastForm.Close();
            FrmCrucLiftActived fcla = new FrmCrucLiftActived();
            FrmSwitch.Open(fcla, 11, new Point(0, 200), new Size(531, 494));
            fcla.Show();
            FrmSwitch.LastForm = fcla;
        }
        private void BtnMeltGapBlock_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnMeltGapBlock))
            {
                if (BtnMeltGapBlock.BackColor == Color.Blue)
                {
                    BtnMeltGapBlock.BackColor = Color.Red;
                    BtnMeltGapBlock.Text = "视觉液口距保护取消";
                    //液口距屏蔽置1
                    PLC.SendBit(30, 117, 1);
                    Record.WriteIn("视觉液口距保护屏蔽", "ON", "Yellow");
                }
                else if (BtnMeltGapBlock.BackColor == Color.Red)
                {
                    BtnMeltGapBlock.BackColor = Color.Blue;
                    BtnMeltGapBlock.Text = "视觉液口距保护屏蔽";
                    //液口距屏蔽置取消置0
                    PLC.SendBit(30, 117, 0);
                    Record.WriteIn("视觉液口距保护屏蔽取消", "OFF", "Yellow");
                }
            }
        }
    }
}
