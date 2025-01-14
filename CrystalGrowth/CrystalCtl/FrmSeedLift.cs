using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace CrystalGrowth.CrystalCtl
{
    internal partial class FrmSeedLift : Form
    {
        bool MouseDownFlag = false;
        public FrmSeedLift()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (PLC.Count == 2)
            {
                LabSP.Text = Math.Round(PLC.ReadValue[3], 1).ToString("f1");
                LabPV.Text = Math.Round(PLC.ReadValue[49], 1).ToString("f1");
                LabSeedTrv.Text = Math.Round(PLC.ReadAnalogValue[35], 1).ToString("f1");
                LabSLFastSet.Text = Math.Round(PLC.ReadValue[103], 1).ToString("f1");
                BtnUp.BackColor = PLC.ReadStatus[11] == 1 ? Color.Red : Color.Blue;
                BtnDown.BackColor = PLC.ReadStatus[12] == 1 ? Color.Red : Color.Blue;
                if (PLC.ReadStatus[13] == 1)
                {
                    BtnSlow.BackColor = Color.Red;
                    BtnFast.Enabled = false;
                }
                else
                {
                    BtnSlow.BackColor = Color.Blue;
                    BtnFast.Enabled = true;
                }
                BtnFast.BackColor = PLC.ReadStatus[14] == 1 ? Color.Red : Color.Blue;
                BtnSlow.Enabled = PLC.ReadStatus[14] != 1 && PLC.ReadStatus[33] != 1;
                BtnForce.Visible = PLC.ReadStatus[34] == 1;
                BtnForce.BackColor = PLC.ReadStatus[35] == 1 ? Color.Red : Color.Blue;
                if (PLC.ReadStatus[13] == 1 || PLC.ReadStatus[14] == 1)
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
                //手柄控制显示
                BtnBoxCtl.BackColor = PLC.ReadStatus[62] == 1 ? Color.Red : Color.Blue;
                BtnBoxCtl.Visible = PLC.ReadStatus[1] != 1 || PLC.ReadValue[1] == 8 || PLC.ReadValue[1] == 34;
            }
        }
        private void BtnManualNeck_Click(object sender, EventArgs e)
        {
            FrmSwitch.LastForm.Close();
            FrmManualNeck fmn = new FrmManualNeck();
            FrmSwitch.Open(fmn, 10, new Point(0, 200), new Size(531, 380));
            fmn.Show();
            FrmSwitch.LastForm = fmn;
        }
        private void LabSP_Click(object sender, EventArgs e)
        {
            if (LabSP.BackColor == Color.White)
            {
                KeyForm kf = new KeyForm();
                kf.ImportData(ref LabSP, 0, 580);
                kf.ShowDialog();
                if (kf.DialogResult == DialogResult.OK)
                {
                    PLC.SendFloat(33, 4, Convert.ToSingle(LabSP.Text));
                    if (PLC.ReadStatus[13] == 1)
                    {
                        Record.WriteIn("晶升速度设定", LabSP.Text, "Yellow"); ;
                    }
                }
            }
        }
        private void BtnUp_Click(object sender, EventArgs e)
        {
            PLC.SendBit(30, 19, 1);
            Record.WriteIn("晶升上升", "ON", "Yellow");
            BtnUp.BackColor = Color.Red;
            BtnDown.BackColor = Color.Blue;
        }
        private void BtnDown_Click(object sender, EventArgs e)
        {
            PLC.SendBit(30, 20, 1);
            Record.WriteIn("晶升下降", "ON", "Yellow");
            BtnUp.BackColor = Color.Blue;
            BtnDown.BackColor = Color.Red;
        }
        private void BtnSlow_Click(object sender, EventArgs e)
        {
            if (Math.Round(PLC.ReadValue[1], 1).ToString("f1") == "13.0")
            {
                DialogResult dr = MessageBox.Show("等径，请确认是否开启晶升慢！", "晶升提示", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }
            }
            if (BtnSlow.BackColor == Color.Red)
            {
                BtnSlow.BackColor = Color.Blue;
                BtnUp.Enabled = true;
                BtnDown.Enabled = true;
                BtnFast.Enabled = true;
                BtnBoxCtl.Enabled = true;
                PLC.SendBit(30, 21, 1);
                Record.WriteIn("晶升驱动器", "OFF", "Yellow");
            }
            else
            {
                BtnSlow.BackColor = Color.Red;
                BtnUp.Enabled = false;
                BtnDown.Enabled = false;
                BtnFast.Enabled = false;
                BtnBoxCtl.Enabled = false;
                PLC.SendBit(30, 21, 1);
                Record.WriteIn("晶升驱动器", "ON", "Yellow");
                Record.WriteIn("   晶升速度设定", Math.Round(PLC.ReadValue[3], 1).ToString("f1"), "Yellow");
            }
        }
        private void BtnFast_MouseDown(object sender, MouseEventArgs e)
        {
            if (BtnSlow.BackColor == Color.Blue)
            {
                PLC.SendBit(30, 22, 1);
                Record.WriteIn("晶升快速升降按下", "ON", "Yellow");
                BtnFast.BackColor = Color.Red;
                BtnUp.Enabled = false;
                BtnDown.Enabled = false;
                BtnSlow.Enabled = false;
                BtnBoxCtl.Enabled = false;
            }
            MouseDownFlag = true;
        }
        private void BtnFast_MouseUp(object sender, MouseEventArgs e)
        {
            PLC.SendBit(30, 23, 1);
            Record.WriteIn("晶升快速升降松开", "ON", "Yellow");
            BtnFast.BackColor = Color.Blue;
            BtnUp.Enabled = true;
            BtnDown.Enabled = true;
            BtnSlow.Enabled = true;
            BtnBoxCtl.Enabled = true;
        }
        private void BtnFast_MouseLeave(object sender, EventArgs e)
        {
            if (MouseDownFlag)
            {
                PLC.SendBit(30, 23, 1);
                Record.WriteIn("晶升快速升降离开", "ON", "Yellow");
                BtnFast.BackColor = Color.Blue;
                BtnUp.Enabled = true;
                BtnDown.Enabled = true;
                BtnSlow.Enabled = true;
                BtnBoxCtl.Enabled = true;
                MouseDownFlag = false;
            }
        }
        private void BtnForce_Click(object sender, EventArgs e)
        {
            PLC.SendBit(30, 63, 1);
            Record.WriteIn("晶升强制升降", "ON", "Yellow");
            BtnForce.BackColor = BtnForce.BackColor == Color.Red ? Color.Blue : Color.Red;
        }
        private void BtnBoxCtl_Click(object sender, EventArgs e)
        {
            PLC.SendBit(30, 86, 1);
            Record.WriteIn("晶升-手柄控制", "ON", "Yellow");
            BtnBoxCtl.BackColor = BtnBoxCtl.BackColor == Color.Red ? Color.Blue : Color.Red;
        }

        private void LabSLFastSet_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm();
            kf.ImportData(ref LabSLFastSet, 0, 48000);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                PLC.SendFloat(33, 408, Convert.ToSingle(LabSLFastSet.Text));
                Record.WriteIn("晶升-手动快速设置", LabSLFastSet.Text, "Yellow");
            }
        }
    }
}