using CrystalGrowth.CrystalCtl;
using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction.Calibration
{
    internal partial class FrmCameraTemp : Form
    {
        private float MeltTempCalib = 0;
        public FrmCameraTemp()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void FrmCameraTemp_Load(object sender, EventArgs e)
        {
            LabCalib.Text = Math.Round(MeltTempCalib, 1).ToString("f1");
            LabDateTime.Text = Calibrate.ReadTime(19);
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (PLC.Count == 2)
            {
                LabRawPV.Text = Math.Round(PLC.ReadAnalogValue[39], 1).ToString("f1");//BrightValue + 1400
                LabRealTemp.Text = Math.Round(PLC.ReadCalcValue[26], 1).ToString("f1");
                LabMeltTempCoef.Text = Math.Round(PLC.ReadCalibValue[29], 5).ToString("f5");
                LabMeltTempOffset.Text = Math.Round(Calibrate.Value[44], 2).ToString("f2");
            }
        }
        private void LabCalib_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm();
            kf.ImportData(ref LabCalib, 1300, 1850);
            kf.ShowDialog();
        }
        private void BtnCalib_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnCalib))
            {
                if (PLC.ReadStatus[6] == 0 && PLC.ReadAnalogValue[39] > 0)
                {
                    Calibrate.WriteValue(19, 1, LabCalib.Text);
                    LabDateTime.Text = Calibrate.DateTimeStr;
                }
                else
                {
                    LabDateTime.ForeColor = Color.Red;
                    LabDateTime.Text = "校准条件不具备";
                }
            }
        }
        private void LabCalib_TextChanged(object sender, EventArgs e)
        {
            MeltTempCalib = float.Parse(LabCalib.Text);
        }
        private void BtnOffsetCalib_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnOffsetCalib))
            {
                if (PLC.ReadStatus[6] == 0 && PLC.ReadAnalogValue[39] > 0)
                {
                    Calibrate.WriteValue(19, 2, LabCalib.Text);
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
