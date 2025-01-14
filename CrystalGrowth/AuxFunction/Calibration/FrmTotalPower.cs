using CrystalGrowth.Unities;
using System;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction.Calibration
{
    internal partial class FrmTotalPower : Form
    {
        public FrmTotalPower()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void FrmTotalPower_Load(object sender, EventArgs e)
        {
            LabDateTime.Text = Calibrate.ReadTime(18);
            LabCurDateTime.Text = Calibrate.ReadTime(31);
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (PLC.Count == 2)
            {
                LabCurPV.Text = Math.Round(PLC.ReadCalibValue[51], 3).ToString("f3");
                LabTotalPV.Text = Math.Round(PLC.ReadCalibValue[32], 3).ToString("f3");
            }
        }
        private void BtnReset_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnReset))
            {
                Calibrate.WriteValue(18, 1, "");
                LabDateTime.Text = Calibrate.DateTimeStr;
            }
        }
        private void BtnCurReset_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnReset))
            {
                Calibrate.WriteValue(18, 2, "");
                LabCurDateTime.Text = Calibrate.DateTimeStr;
            }
        }
    }
}
