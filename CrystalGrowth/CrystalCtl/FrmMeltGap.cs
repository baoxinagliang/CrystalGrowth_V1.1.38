using CrystalGrowth.AuxFunction.CCD;
using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.CrystalCtl
{
    internal partial class FrmMeltGap : Form
    {
        public FrmMeltGap()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void FrmMeltGap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Level.PermitModify = false;
        }
        private void FrmMeltGap_Load(object sender, EventArgs e)
        {
            BtnTune.BackColor = Color.Fuchsia;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (PLC.Count == 2)
            {
                LabSP.Text = Math.Round(PLC.ReadValue[40], 1).ToString("f1");
                LabPV.Text = Math.Round(PLC.ReadValue[41], 1).ToString("f1");//液口距反馈值mm
                LabOut.Text = Math.Round(PLC.ReadValue[37], 1).ToString("f1");
                LabMeltLevelOffset.Text = Math.Round(PLC.ReadValue[67], 3).ToString("f3");
                LabMeltLevelCoaf.Text = Math.Round(PLC.ReadValue[68], 5).ToString("f5");
                if (BtnTune.BackColor == Color.Fuchsia)
                {
                    LabGainVal.Text = Math.Round(PLC.ReadValue[42], 4).ToString("f4");
                    LabIntegVal.Text = Math.Round(PLC.ReadValue[43], 4).ToString("f4");
                    LabDifferVal.Text = Math.Round(PLC.ReadValue[44], 4).ToString("f4");
                }
                if (BtnLimit.BackColor == Color.Fuchsia)
                {
                    LabIntegVal.Text = Math.Round(PLC.ReadValue[38], 1).ToString("f1");
                    LabDifferVal.Text = Math.Round(PLC.ReadValue[39], 1).ToString("f1");
                }
                LabSP.BackColor = PLC.ReadStatus[1] == 1 && PLC.ReadStatus[32] == 1 ? Color.White : Color.Gray;
                LabSP.BackColor = PLC.ReadStatus[1] == 0 && PLC.ReadStatus[9] == 1 ? Color.White : Color.Gray;
                LabOut.BackColor = PLC.ReadStatus[7] == 1 || PLC.ReadStatus[9] == 1 ? Color.Gray : Color.White;
                if (PLC.ReadStatus[9] == 1)
                {
                    BtnON.BackColor = Color.Red;
                    BtnOFF.BackColor = Color.Blue;
                }
                else
                {
                    BtnON.BackColor = Color.Blue;
                    BtnOFF.BackColor = Color.Red;
                }
                if (PLC.ReadStatus[85] == 1)
                {
                    BtnMeltGapShield.BackColor = Color.Red;
                    BtnMeltGapShield.Text = "液口距屏蔽取消";
                }
                else
                {
                    BtnMeltGapShield.BackColor = Color.Blue;
                    BtnMeltGapShield.Text = "液口距屏蔽";
                }
                if (PLC.ReadStatus[1] == 1)
                {
                    BtnFixed.Visible = true;
                    BtnAuto.Visible = true;
                    LabSP.BackColor = PLC.ReadStatus[32] == 1 ? Color.White : Color.Gray;
                }
                else
                {
                    BtnFixed.Visible = false;
                    BtnAuto.Visible = false;
                    LabSP.BackColor = PLC.ReadStatus[3] == 1 ? Color.White : Color.Gray;
                }
                if (PLC.ReadStatus[32] == 1)
                {
                    BtnFixed.BackColor = Color.Red;
                    BtnAuto.BackColor = Color.Blue;
                }
                else
                {
                    BtnFixed.BackColor = Color.Blue;
                    BtnAuto.BackColor = Color.Red;
                }
            }
        }
        private void BtnTune_Click(object sender, EventArgs e)
        {
            BtnTune.BackColor = Color.Fuchsia;
            BtnLimit.BackColor = Color.Blue;
            LabGainTxt.Visible = true;
            LabGainVal.Visible = true;
            LabDifferTxt.Text = "微分";
            LabIntegTxt.Text = "积分";
            LabGainVal.Text = Math.Round(PLC.ReadValue[42], 4).ToString("f4");
            LabIntegVal.Text = Math.Round(PLC.ReadValue[43], 4).ToString("f4");
            LabDifferVal.Text = Math.Round(PLC.ReadValue[44], 4).ToString("f4");
        }
        private void BtnLimit_Click(object sender, EventArgs e)
        {
            BtnTune.BackColor = Color.Blue;
            BtnLimit.BackColor = Color.Fuchsia;
            LabGainTxt.Visible = false;
            LabGainVal.Visible = false;
            LabDifferTxt.Text = "下限";
            LabIntegTxt.Text = "上限";
            LabIntegVal.Text = Math.Round(PLC.ReadValue[38], 1).ToString("f1");
            LabDifferVal.Text = Math.Round(PLC.ReadValue[39], 1).ToString("f1");
        }
        private void LabSP_Click(object sender, EventArgs e)
        {
            if (LabSP.BackColor == Color.White)
            {
                KeyForm kf = new KeyForm();
                kf.ImportData(ref LabSP, 0, 100);
                kf.ShowDialog();
                if (kf.DialogResult == DialogResult.OK)
                {
                    PLC.SendFloat(33, 156, Convert.ToSingle(LabSP.Text));
                }
            }
        }
        private void LabOut_Click(object sender, EventArgs e)
        {
            if (LabOut.BackColor == Color.White)
            {
                KeyForm kf = new KeyForm();
                kf.ImportData(ref LabOut, 0, 127);
                kf.ShowDialog();
                if (kf.DialogResult == DialogResult.OK)
                {
                    PLC.SendFloat(33, 140, Convert.ToSingle(LabOut.Text));
                    if (PLC.ReadStatus[19] == 1)
                    {
                        Record.WriteIn("埚升速度设定", LabOut.Text, "Yellow");
                    }
                }
            }
        }
        private void LabGainVal_Click(object sender, EventArgs e)
        {
            if (LabGainVal.BackColor == Color.White)
            {
                KeyForm kf = new KeyForm();
                kf.ImportData(ref LabGainVal, 0, 200);
                kf.ShowDialog();
                if (kf.DialogResult == DialogResult.OK)
                {
                    PLC.SendFloat(33, 164, Convert.ToSingle(LabGainVal.Text));
                    Record.WriteIn("视觉液口距控制增益", LabGainVal.Text, "Yellow");
                }
            }
        }
        private void LabDifferVal_Click(object sender, EventArgs e)
        {
            if (LabDifferVal.BackColor == Color.White)
            {
                KeyForm kf = new KeyForm();
                if (BtnTune.BackColor == Color.Fuchsia)
                {
                    kf.ImportData(ref LabDifferVal, 0, 100);
                }
                if (BtnLimit.BackColor == Color.Fuchsia)
                {
                    kf.ImportData(ref LabDifferVal, 0, 127);
                }
                kf.ShowDialog();
                if (kf.DialogResult == DialogResult.OK)
                {
                    if (BtnTune.BackColor == Color.Fuchsia)
                    {
                        PLC.SendFloat(33, 172, Convert.ToSingle(LabDifferVal.Text));
                        Record.WriteIn("视觉液口距控制微分", LabDifferVal.Text, "Yellow");
                    }
                    if (BtnLimit.BackColor == Color.Fuchsia)
                    {
                        PLC.SendFloat(33, 152, Convert.ToSingle(LabDifferVal.Text));
                        Record.WriteIn("视觉液口距控制下限", LabDifferVal.Text, "Yellow");
                    }
                }
            }
        }
        private void LabIntegVal_Click(object sender, EventArgs e)
        {
            if (LabIntegVal.BackColor == Color.White)
            {
                KeyForm kf = new KeyForm();
                if (BtnTune.BackColor == Color.Fuchsia)
                {
                    kf.ImportData(ref LabIntegVal, 0, 100);
                }
                if (BtnLimit.BackColor == Color.Fuchsia)
                {
                    kf.ImportData(ref LabIntegVal, 0, 127);
                }
                kf.ShowDialog();
                if (kf.DialogResult == DialogResult.OK)
                {
                    if (BtnTune.BackColor == Color.Fuchsia)
                    {
                        PLC.SendFloat(33, 168, Convert.ToSingle(LabIntegVal.Text));
                        Record.WriteIn("视觉液口距控制积分", LabIntegVal.Text, "Yellow");
                    }
                    if (BtnLimit.BackColor == Color.Fuchsia)
                    {
                        PLC.SendFloat(33, 148, Convert.ToSingle(LabIntegVal.Text));
                        Record.WriteIn("视觉液口距控制上限", LabIntegVal.Text, "Yellow");
                    }
                }
            }
        }
        private void BtnON_Click(object sender, EventArgs e)
        {
            //液口距测量关闭时，液口距控制不能开
            if (FrmMeltGapArea.AgreeMeltGap == 0)
            {
                return;
            }
            if (PLC.ReadStatus[9] == 0)
            {
                PLC.SendBit(30, 15, 1);
                Record.WriteIn("液口距控制", "ON", "Yellow");
                BtnON.BackColor = Color.Red;
                BtnOFF.BackColor = Color.Blue;
                LabOut.BackColor = Color.Gray;
                if (PLC.ReadStatus[1] == 0)
                {
                    LabSP.BackColor = Color.White;
                }
            }
        }
        private void BtnOFF_Click(object sender, EventArgs e)
        {
            if (PLC.ReadStatus[9] == 1)
            {
                PLC.SendBit(30, 16, 1);
                Record.WriteIn("液口距控制", "OFF", "Yellow");
                BtnON.BackColor = Color.Blue;
                BtnOFF.BackColor = Color.Red;
                LabOut.BackColor = Color.White;
                if (PLC.ReadStatus[1] == 0)
                {
                    LabSP.BackColor = Color.Gray;
                }
            }
        }
        private void BtnMeltGapSafe_Click(object sender, EventArgs e)
        {
            FrmSwitch.LastForm.Close();
            FrmMeltGapSafe fmgs = new FrmMeltGapSafe();
            FrmSwitch.Open(fmgs, 6, new Point(0, 195), new Size(520, 505));
            fmgs.Show();
            FrmSwitch.LastForm = fmgs;
        }
        private void BtnMeltGapShield_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnMeltGapShield))
            {
                if (BtnMeltGapShield.BackColor == Color.Blue)
                {
                    BtnMeltGapShield.BackColor = Color.Red;
                    BtnMeltGapShield.Text = "液口距屏蔽取消";
                    //液口距屏蔽置1
                    PLC.SendBit(30, 117, 1);
                }
                else if (BtnMeltGapShield.BackColor == Color.Red)
                {
                    BtnMeltGapShield.BackColor = Color.Blue;
                    BtnMeltGapShield.Text = "液口距屏蔽";
                    //液口距屏蔽置取消置0
                    PLC.SendBit(30, 117, 0);
                }
            }
        }
        private void BtnAuto_Click(object sender, EventArgs e)
        {
            PLC.SendBit(30, 58, 1);
            Record.WriteIn("视觉液口距控制自动", "ON", "Yellow");
            BtnAuto.BackColor = Color.Red;
            BtnFixed.BackColor = Color.Blue;
            if (PLC.ReadStatus[1] == 1)
            {
                LabSP.BackColor = Color.Gray;
            }
        }
        private void BtnFixed_Click(object sender, EventArgs e)
        {
            PLC.SendBit(30, 59, 1);
            Record.WriteIn("视觉液口距控制固定值", "ON", "Yellow");
            BtnAuto.BackColor = Color.Blue;
            BtnFixed.BackColor = Color.Red;
            if (PLC.ReadStatus[1] == 1)
            {
                LabSP.BackColor = Color.White;
            }
        }
        private void LabMeltLevelCoaf_Click(object sender, EventArgs e)
        {
            if (Level.PermitModify == false)
            {
                MessageBox.Show("无设定值修改权限，或已过期需要再次获取权限！");
            }
            else
            {
                KeyForm kf = new KeyForm();
                kf.ImportData(ref LabMeltLevelCoaf, 0, 100);
                kf.ShowDialog();
                if (kf.DialogResult == DialogResult.OK)
                {
                    PLC.SendFloat(33, 268, Convert.ToSingle(LabMeltLevelCoaf.Text));
                }
            }
        }
    }
}
