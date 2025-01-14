using CrystalGrowth.CrystalCtl;
using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction.Calibration
{
    internal partial class FrmSeedTrv : Form
    {
        private float SeedTrvCalib = 0;
        public FrmSeedTrv()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void FrmSeedTrv_Load(object sender, EventArgs e)
        {
            LabTrvSP.Text = Math.Round(SeedTrvCalib, 1).ToString("f1");
            LabDateTime.Text = Calibrate.ReadTime(6);
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (PLC.Count == 2)
            {
                LabRawPV.Text = Math.Round(PLC.ReadAnalogValue[33], 1).ToString("f1");
                LabTrvPV.Text = Math.Round(PLC.ReadAnalogValue[35], 1).ToString("f1");
            }
        }
        private void BtnSetZero_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnSetZero))
            {
                Calibrate.WriteValue(6, 1, "");
                LabDateTime.Text = Calibrate.DateTimeStr;
            }
        }
        private void LabTrvSP_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm();
            kf.ImportData(ref LabTrvSP, -10000, 10000);
            kf.ShowDialog();
        }
        private void BtnSetSpan_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnSetSpan))
            {
                if (PLC.ReadAnalogValue[33] != PLC.ReadCalibValue[9])
                {
                    Calibrate.WriteValue(6, 2, LabTrvSP.Text);
                    LabDateTime.Text = Calibrate.DateTimeStr;
                }
                else
                {
                    LabDateTime.ForeColor = Color.Red;
                    LabDateTime.Text = "校准条件不具备";
                }
            }
        }
        private void LabTrvSP_TextChanged(object sender, EventArgs e)
        {
            SeedTrvCalib = float.Parse(LabTrvSP.Text);
        }
    }
}
