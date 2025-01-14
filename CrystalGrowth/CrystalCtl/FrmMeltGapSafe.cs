using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.CrystalCtl
{
    internal partial class FrmMeltGapSafe : Form
    {
        public FrmMeltGapSafe()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void FrmMeltGapSafe_FormClosed(object sender, FormClosedEventArgs e)
        {
            Level.MeltGapSafe = false;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (PLC.Count == 2)
            {
                LabMeltGapSafeValue.Text = Math.Round(PLC.ReadOthersValue[27], 1).ToString("f1");
                LabExtDia.Text = Math.Round(CrucPara.ExtDia, 2).ToString("f2");
                LabWallThick.Text = Math.Round(CrucPara.WallThick, 2).ToString("f2");
                LabTotalHight.Text = Math.Round(CrucPara.TotalHeight, 2).ToString("f2");
                LabAngleRadius.Text = Math.Round(CrucPara.AngleRadius, 2).ToString("f2");
                LabArcRadius.Text = Math.Round(CrucPara.ArcRadius, 2).ToString("f2");
                LabMeltShield.Text = Math.Round(PLC.ReadCalcValue[1], 1).ToString("f1");
                LabMeltDepth.Text = Math.Round(PLC.ReadCalcValue[4], 1).ToString("f1");
                LabMaxLoad.Text = Math.Round(CrystalCalc.MaxLoad, 2).ToString("f2");
                if (PLC.ReadStatus[66] == 0)
                {
                    BtnON_1.BackColor = Color.Blue;
                    BtnOFF_1.BackColor = Color.Red;
                }
                else
                {
                    BtnON_1.BackColor = Color.Red;
                    BtnOFF_1.BackColor = Color.Blue;
                }
                if (PLC.ReadStatus[69] == 0)
                {
                    BtnON_2.BackColor = Color.Blue;
                    BtnOFF_2.BackColor = Color.Red;
                }
                else
                {
                    BtnON_2.BackColor = Color.Red;
                    BtnOFF_2.BackColor = Color.Blue;
                }
            }
        }
        private void LabExtDia_Click(object sender, EventArgs e)
        {
            FrmLevel frmLevel = new FrmLevel("Engineer", "Engineer");
            frmLevel.ShowDialog();
            if (frmLevel.DialogResult == DialogResult.OK)
            {
                KeyForm kf = new KeyForm();
                kf.ImportData(ref LabExtDia, 100, 2000);
                kf.ShowDialog();
            }
        }
        private void LabWallThick_Click(object sender, EventArgs e)
        {
            FrmLevel frmLevel = new FrmLevel("Engineer", "Engineer");
            frmLevel.ShowDialog();
            if (frmLevel.DialogResult == DialogResult.OK)
            {
                KeyForm kf = new KeyForm();
                kf.ImportData(ref LabWallThick, 1, 50);
                kf.ShowDialog();
            }
        }
        private void LabTotalHight_Click(object sender, EventArgs e)
        {
            FrmLevel frmLevel = new FrmLevel("Engineer", "Engineer");
            frmLevel.ShowDialog();
            if (frmLevel.DialogResult == DialogResult.OK)
            {
                KeyForm kf = new KeyForm();
                kf.ImportData(ref LabTotalHight, 100, 2000);
                kf.ShowDialog();
            }
        }
        private void LabAngleRadius_Click(object sender, EventArgs e)
        {
            FrmLevel frmLevel = new FrmLevel("Engineer", "Engineer");
            frmLevel.ShowDialog();
            if (frmLevel.DialogResult == DialogResult.OK)
            {
                KeyForm kf = new KeyForm();
                kf.ImportData(ref LabAngleRadius, 10, 360);
                kf.ShowDialog();
            }
        }
        private void LabArcRadius_Click(object sender, EventArgs e)
        {
            FrmLevel frmLevel = new FrmLevel("Engineer", "Engineer");
            frmLevel.ShowDialog();
            if (frmLevel.DialogResult == DialogResult.OK)
            {
                KeyForm kf = new KeyForm();
                kf.ImportData(ref LabArcRadius, 200, 2000);
                kf.ShowDialog();
            }
        }
        private void LabExtDia_TextChanged(object sender, EventArgs e)
        {
            CrucPara.ExtDia = Convert.ToDouble(LabExtDia.Text);
            CrucPara.WriteIn(LabExtDia.Text, 1);
            CrystalCalc.Weight();
        }
        private void LabWallThick_TextChanged(object sender, EventArgs e)
        {
            CrucPara.WallThick = Convert.ToDouble(LabWallThick.Text);
            CrucPara.WriteIn(LabWallThick.Text, 2);
            CrystalCalc.Weight();
        }
        private void LabTotalHight_TextChanged(object sender, EventArgs e)
        {
            CrucPara.TotalHeight = Convert.ToDouble(LabTotalHight.Text);
            CrucPara.WriteIn(LabTotalHight.Text, 3);
            CrystalCalc.Weight();
        }
        private void LabAngleRadius_TextChanged(object sender, EventArgs e)
        {
            CrucPara.AngleRadius = Convert.ToDouble(LabAngleRadius.Text);
            CrucPara.WriteIn(LabAngleRadius.Text, 4);
            CrystalCalc.Weight();
        }
        private void LabArcRadius_TextChanged(object sender, EventArgs e)
        {
            CrucPara.ArcRadius = Convert.ToDouble(LabArcRadius.Text);
            CrucPara.WriteIn(LabArcRadius.Text, 5);
            CrystalCalc.Weight();
        }
        private void BtnON_1_Click(object sender, EventArgs e)
        {
            PLC.SendBit(30, 90, 1);
            BtnON_1.BackColor = Color.Red;
            BtnOFF_1.BackColor = Color.Blue;
            Record.WriteIn("   重量液口距保护", "ON", "Yellow");
        }
        private void BtnOFF_1_Click(object sender, EventArgs e)
        {
            PLC.SendBit(30, 91, 1);
            BtnON_1.BackColor = Color.Blue;
            BtnOFF_1.BackColor = Color.Red;
            Record.WriteIn("   重量液口距保护", "OFF", "Yellow");
        }
        private void BtnON_2_Click(object sender, EventArgs e)
        {
            PLC.SendBit(30, 92, 1);
            BtnON_2.BackColor = Color.Red;
            BtnOFF_2.BackColor = Color.Blue;
            Record.WriteIn("   视觉液口距保护", "ON", "Yellow");
        }
        private void BtnOFF_2_Click(object sender, EventArgs e)
        {
            PLC.SendBit(30, 93, 1);
            BtnON_2.BackColor = Color.Blue;
            BtnOFF_2.BackColor = Color.Red;
            Record.WriteIn("   视觉液口距保护", "OFF", "Yellow");
        }
        private void LabMeltGapSafeValue_Click(object sender, EventArgs e)
        {
            FrmLevel frmLevel = new FrmLevel("Engineer", "Engineer");
            frmLevel.ShowDialog();
            if (frmLevel.DialogResult == DialogResult.OK)
            {
                KeyForm kf = new KeyForm();
                kf.ImportData(ref LabMeltGapSafeValue, 20, 80);
                kf.ShowDialog();
                if (kf.DialogResult == DialogResult.OK)
                {
                    PLC.SendFloat(31, 104, Convert.ToSingle(LabMeltGapSafeValue.Text));
                    Record.WriteIn("视觉液口距安全保护值", LabMeltGapSafeValue.Text, "yellow");
                }
            }
        }
        private void BtnQuit_Click(object sender, EventArgs e)
        {
            FrmSwitch.LastForm.Close();
            FrmMeltGap fmg = new FrmMeltGap();
            FrmSwitch.Open(fmg, 7, new Point(0, 200), new Size(531, 494));
            fmg.Show();
            FrmSwitch.LastForm = fmg;
        }
    }
}