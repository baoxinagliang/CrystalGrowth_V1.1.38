using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.CrystalCtl
{
    internal partial class FrmShieldPos : Form
    {
        public FrmShieldPos()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void FrmShieldPos_Load(object sender, EventArgs e)
        {
            if (PLC.ReadStatus[27] == 0)
            {
                PLC.SendFloat(33, 236, PLC.ReadValue[61]);
            }
            if (Level.PermitModify)
            {
                BtnSingeCtl.Visible = true;
            }
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (PLC.Count == 2)
            {
                LabMasterLocSP.Text = Math.Round(PLC.ReadValue[60], 1).ToString("f1");
                LabMasterLocPV.Text = Math.Round(PLC.ReadValue[61], 1).ToString("f1");
                LabMasterTorque.Text = Math.Round(PLC.ReadValue[92], 1).ToString("f1");
                LabMasterSpeed.Text = Math.Round(PLC.ReadValue[111], 1).ToString("f1");
                LabSlaveLocSP.Text = Math.Round(PLC.ReadValue[60], 1).ToString("f1");
                LabSlaveLocPV.Text = Math.Round(PLC.ReadValue[110], 1).ToString("f1"); 
                LabSlaveTorque.Text = Math.Round(PLC.ReadValue[109], 1).ToString("f1");
                LabSlaveSpeed.Text = Math.Round(PLC.ReadValue[112], 1).ToString("f1");
                if (PLC.ReadStatus[105] == 1)//热屏伺服双电机耦合联动状态位
                {
                    BtnJointCtl.BackColor = Color.Red;
                    BtnSingeCtl.BackColor = Color.Blue;
                    BtnMaster.Visible = false;
                    BtnSlave.Visible = false;
                }
                if (PLC.ReadStatus[106] == 1)//热屏伺服双电机耦合联动状态位
                {
                    BtnJointCtl.BackColor = Color.Blue;
                    BtnSingeCtl.BackColor = Color.Red;
                    BtnMaster.Visible = true;
                    BtnSlave.Visible = true;
                }
                if (PLC.ReadStatus[107] == 1)//单动主轴选择
                {
                    BtnSlave.BackColor = Color.Blue;
                    BtnMaster.BackColor = Color.Red;
                }
                if (PLC.ReadStatus[108] == 1)//单动从轴选择
                {
                    BtnSlave.BackColor = Color.Red;
                    BtnMaster.BackColor = Color.Blue;
                }
                if (PLC.ReadStatus[26] == 1)
                {
                    BtnManu.BackColor = Color.Red;
                    BtnAuto.BackColor = Color.Blue;
                    if (PLC.ReadStatus[27] == 1)
                    {
                        BtnShieldUp.Enabled = false;
                        BtnShieldDown.Enabled = false;
                    }
                    else
                    {
                        BtnShieldDown.Enabled = PLC.ReadStatus[77] != 1;
                        BtnShieldUp.Enabled = PLC.ReadStatus[78] != 1;
                    }
                    BtnLoc.Enabled = PLC.ReadStatus[1] != 1 && (PLC.ReadStatus[27] != 0 || PLC.ReadStatus[77] != 1 && PLC.ReadStatus[78] != 1);
                    LabMasterLocSP.BackColor = PLC.ReadStatus[27] == 1 || PLC.ReadStatus[1] == 1 || PLC.ReadStatus[77] == 1 || PLC.ReadStatus[78] == 1 ? Color.Gray : Color.White;
                    BtnBoxCtl.Enabled = PLC.ReadStatus[77] != 1 && PLC.ReadStatus[78] != 1;
                }
                else
                {
                    BtnManu.BackColor = Color.Blue;
                    BtnAuto.BackColor = Color.Red;
                    BtnLoc.Enabled = false;
                    BtnShieldUp.Enabled = false;
                    BtnShieldDown.Enabled = false;
                    BtnBoxCtl.Enabled = false;
                    LabMasterLocSP.BackColor = Color.Gray;
                }
                BtnLoc.BackColor = PLC.ReadStatus[27] == 1 ? Color.Red : Color.Blue;
                BtnShieldUp.BackColor = PLC.ReadStatus[77] == 1 ? Color.Red : Color.Blue;
                BtnShieldDown.BackColor = PLC.ReadStatus[78] == 1 ? Color.Red : Color.Blue;
                BtnBoxCtl.BackColor = PLC.ReadStatus[76] == 1 ? Color.Red : Color.Blue;
                BtnForce.Visible = PLC.ReadStatus[73] == 1;
                BtnForce.BackColor = PLC.ReadStatus[74] == 1 ? Color.Red : Color.Blue;
                //手柄控制显示            
                BtnBoxCtl.Visible = PLC.ReadStatus[1] != 1 || PLC.ReadValue[1] == 8;
            }
        }
        private void LabSP_Click(object sender, EventArgs e)
        {
            if (LabMasterLocSP.BackColor == Color.White)
            {
                KeyForm kf = new KeyForm();
                kf.ImportData(ref LabMasterLocSP, -500, 500);
                kf.ShowDialog();
                if (kf.DialogResult == DialogResult.OK)
                {
                    PLC.SendFloat(33, 236, Convert.ToSingle(LabMasterLocSP.Text));
                }
            }
        }
        private void BtnManu_Click(object sender, EventArgs e)
        {
            PLC.SendBit(30, 36, 1);
            Record.WriteIn("热屏位置手动", "ON", "Yellow");
            BtnManu.BackColor = Color.Red;
            BtnAuto.BackColor = Color.Blue;
            BtnShieldUp.Enabled = true;
            BtnShieldDown.Enabled = true;
            BtnBoxCtl.Enabled = true;
            if (PLC.ReadStatus[1] == 0)
            {
                BtnLoc.Enabled = true;
            }
            if (PLC.ReadStatus[27] == 0 && PLC.ReadStatus[1] == 0)
            {
                LabMasterLocSP.BackColor = Color.White;
            }
        }
        private void BtnAuto_Click(object sender, EventArgs e)
        {
            PLC.SendBit(30, 37, 1);
            Record.WriteIn("热屏位置自动", "ON", "Yellow");
            BtnManu.BackColor = Color.Blue;
            BtnAuto.BackColor = Color.Red;
            BtnLoc.Enabled = false;
            BtnShieldUp.Enabled = false;
            BtnShieldDown.Enabled = false;
            BtnBoxCtl.Enabled = false;
            LabMasterLocSP.BackColor = Color.Gray;
        }
        private void BtnLoc_Click(object sender, EventArgs e)
        {
            if (PLC.ReadValue[1] == 0.0)
            {
                PLC.SendBit(30, 38, 1);
                if (PLC.ReadStatus[27] == 1)
                {
                    Record.WriteIn("热屏位置定位", "OFF", "Yellow");
                }
                else
                {
                    Record.WriteIn("热屏位置定位", "ON", "Yellow");
                }
            }
            else
            {
                BtnLoc.Enabled = false;
            }
            if (BtnLoc.BackColor == Color.Red)
            {
                BtnLoc.BackColor = Color.Blue;
                LabMasterLocSP.BackColor = Color.White;
                BtnShieldUp.Enabled = true;
                BtnShieldDown.Enabled = true;
                BtnBoxCtl.Enabled = true;
            }
            else
            {
                BtnLoc.BackColor = Color.Red;
                LabMasterLocSP.BackColor = Color.Gray;
                BtnShieldUp.Enabled = false;
                BtnShieldDown.Enabled = false;
                BtnBoxCtl.Enabled = false;
            }
        }
        private void BtnShieldUp_MouseDown(object sender, MouseEventArgs e)
        {
            PLC.SendBit(30, 102, 1);
            Record.WriteIn("热屏位置提升按下", "ON", "Yellow");
            BtnShieldUp.BackColor = Color.Red;
            LabMasterLocSP.BackColor = Color.Gray;
            BtnLoc.Enabled = false;
            BtnShieldDown.Enabled = false;
            BtnBoxCtl.Enabled = false;
        }
        private void BtnShieldUp_MouseUp(object sender, MouseEventArgs e)
        {
            PLC.SendBit(30, 103, 1);
            Record.WriteIn("热屏位置提升松开", "ON", "Yellow");
            BtnShieldUp.BackColor = Color.Blue;
            LabMasterLocSP.BackColor = Color.White;
            BtnLoc.Enabled = true;
            BtnShieldDown.Enabled = true;
            BtnBoxCtl.Enabled = true;
        }
        private void BtnShieldUp_MouseLeave(object sender, EventArgs e)
        {
            PLC.SendBit(30, 103, 1);
            Record.WriteIn("热屏位置提升离开", "ON", "Yellow");
            BtnShieldUp.BackColor = Color.Blue;
            LabMasterLocSP.BackColor = Color.White;
            BtnLoc.Enabled = true;
            BtnShieldDown.Enabled = true;
            BtnBoxCtl.Enabled = true;
        }
        private void BtnShieldDown_MouseDown(object sender, MouseEventArgs e)
        {
            PLC.SendBit(30, 104, 1);
            Record.WriteIn("热屏位置下降按下", "ON", "Yellow");
            BtnShieldDown.BackColor = Color.Red;
            LabMasterLocSP.BackColor = Color.Gray;
            BtnLoc.Enabled = false;
            BtnShieldUp.Enabled = false;
            BtnBoxCtl.Enabled = false;
        }
        private void BtnShieldDown_MouseUp(object sender, MouseEventArgs e)
        {
            PLC.SendBit(30, 105, 1);
            Record.WriteIn("热屏位置下降松开", "ON", "Yellow");
            BtnShieldDown.BackColor = Color.Blue;
            LabMasterLocSP.BackColor = Color.White;
            BtnLoc.Enabled = true;
            BtnShieldUp.Enabled = true;
            BtnBoxCtl.Enabled = true;
        }
        private void BtnShieldDown_MouseLeave(object sender, EventArgs e)
        {
            PLC.SendBit(30, 105, 1);
            Record.WriteIn("热屏位置下降离开", "ON", "Yellow");
            BtnShieldDown.BackColor = Color.Blue;
            LabMasterLocSP.BackColor = Color.White;
            BtnLoc.Enabled = true;
            BtnShieldUp.Enabled = true;
            BtnBoxCtl.Enabled = true;
        }
        private void BtnForce_Click(object sender, EventArgs e)
        {
            PLC.SendBit(30, 99, 1);
            Record.WriteIn("热屏位置强制升降", "ON", "Yellow");
            BtnForce.BackColor = BtnForce.BackColor == Color.Red ? Color.Blue : Color.Red;
        }
        private void BtnBoxCtl_Click(object sender, EventArgs e)
        {
            PLC.SendBit(30, 101, 1);
            Record.WriteIn("热屏位置手柄控制", "ON", "Yellow");
            BtnBoxCtl.BackColor = BtnBoxCtl.BackColor == Color.Red ? Color.Blue : Color.Red;
        }
        private void BtnJointCtl_Click(object sender, EventArgs e)
        {
            PLC.SendBit(30, 164, 1);
            Record.WriteIn("热屏联控", "ON", "Yellow");
        }
        private void BtnSingeCtl_Click(object sender, EventArgs e)
        {
            PLC.SendBit(30, 163, 1);
            Record.WriteIn("热屏单控", "ON", "Yellow");
        }
        private void BtnMaster_Click(object sender, EventArgs e)
        {
            PLC.SendBit(30, 165, 1);
            Record.WriteIn("热屏主轴", "ON", "Yellow");
        }
        private void BtnSlave_Click(object sender, EventArgs e)
        {
            PLC.SendBit(30, 166, 1);
            Record.WriteIn("热屏从轴", "ON", "Yellow");
        }
        private void FrmShieldPos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Level.PermitModify = false;
        }
    }
}
