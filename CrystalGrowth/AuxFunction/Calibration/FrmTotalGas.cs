using CrystalGrowth.Unities;
using System;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction.Calibration
{
    internal partial class FrmTotalGas : Form
    {
        public FrmTotalGas()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void FrmTotalGas_Load(object sender, EventArgs e)
        {
            LabDateTime.Text = Calibrate.ReadTime(21);
            LabCurDateTime.Text = Calibrate.ReadTime(32);
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (PLC.Count == 2)
            {
                LabCurPV.Text = Math.Round(PLC.ReadCalibValue[52], 3).ToString("f3");
                LabTotalPV.Text = Math.Round(PLC.ReadCalibValue[34], 3).ToString("f3");
            }
        }
        private void BtnReset_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnReset))
            {
                Calibrate.WriteValue(21, 1, "");
                LabDateTime.Text = Calibrate.DateTimeStr;
            }
        }
        private void BtnCurReset_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnCurReset))
            {
                Calibrate.WriteValue(21, 2, "");
                LabCurDateTime.Text = Calibrate.DateTimeStr;
            }
        }
    }
}
