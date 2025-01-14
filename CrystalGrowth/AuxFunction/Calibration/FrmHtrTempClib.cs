using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction.Calibration
{
    internal partial class FrmHtrTempClib : Form
    {
        public FrmHtrTempClib()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void FrmHtrTempClib_Load(object sender, EventArgs e)
        {
            LabDateTime.Text = Calibrate.ReadTime(17);
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (PLC.Count == 2)
            {
                LabRawPV.Text = Math.Round(PLC.ReadAnalogValue[38], 1).ToString("f1");
                LabGain.Text = Math.Round(PLC.ReadCalibValue[28], 2).ToString("f2");
                LabTempPV.Text = Math.Round(PLC.ReadValue[12], 1).ToString("f1");
            }
        }
        private void BtnCalib_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnCalib))
            {
                if (PLC.ReadStatus[5] == 0 && PLC.ReadAnalogValue[38] > 0)
                {
                    Calibrate.WriteValue(17, 1, "");
                    LabDateTime.Text = Calibrate.DateTimeStr;
                }
                else
                {
                    LabDateTime.ForeColor = Color.Red;
                    LabDateTime.Text = "校准条件不具备";
                }
            }
        }
    }
}
