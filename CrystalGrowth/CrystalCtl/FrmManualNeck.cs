using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.CrystalCtl
{
    internal partial class FrmManualNeck : Form
    {
        public FrmManualNeck()
        {
            InitializeComponent();
        }
        private void BtnQuit_Click(object sender, EventArgs e)
        {
            FrmSwitch.LastForm.Close();
            FrmSeedLift fsl = new FrmSeedLift();
            FrmSwitch.Open(fsl, 9, new Point(0, 200), new Size(531, 494));
            fsl.Show();
            FrmSwitch.LastForm = fsl;
        }
        private void LabMaxSP_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm();
            kf.ImportData(ref LabMaxSP, 0, 580);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                PLC.SendFloat(33, 252, Convert.ToSingle(LabMaxSP.Text));
                Record.WriteIn("手动引晶设定高速", LabMaxSP.Text, "Yellow");
            }
        }
        private void LabMinSP_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm();
            kf.ImportData(ref LabMinSP, 0, 580);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                PLC.SendFloat(33, 256, Convert.ToSingle(LabMinSP.Text));
                Record.WriteIn("手动引晶设定低速", LabMinSP.Text, "Yellow");
            }
        }
        private void BtnON_Click(object sender, EventArgs e)
        {
            PLC.SendBit(30, 61, 1);
            Record.WriteIn("手动引晶ON", "ON", "Yellow");
            BtnON.BackColor = Color.Red;
            BtnOFF.BackColor = Color.Blue;
        }
        private void BtnOFF_Click(object sender, EventArgs e)
        {
            PLC.SendBit(30, 62, 1);
            Record.WriteIn("手动引晶OFF", "ON", "Yellow");
            BtnON.BackColor = Color.Blue;
            BtnOFF.BackColor = Color.Red;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (PLC.Count == 2)
            {
                LabMaxSP.Text = Math.Round(PLC.ReadValue[64], 1).ToString("f1");
                LabMinSP.Text = Math.Round(PLC.ReadValue[65], 1).ToString("f1");
                LabPV.Text = Math.Round(PLC.ReadValue[49], 1).ToString("f1");
                if (PLC.ReadStatus[33] == 1)
                {
                    BtnON.BackColor = Color.Red;
                    BtnOFF.BackColor = Color.Blue;
                }
                else
                {
                    BtnON.BackColor = Color.Blue;
                    BtnOFF.BackColor = Color.Red;
                }
                if (PLC.ReadStatus[1] == 1 && PLC.ReadStatus[13] == 1)
                {
                    BtnON.Enabled = true;
                    BtnOFF.Enabled = true;
                }
                else
                {
                    BtnON.Enabled = false;
                    BtnOFF.Enabled = false;
                }
            }
        }
    }
}
