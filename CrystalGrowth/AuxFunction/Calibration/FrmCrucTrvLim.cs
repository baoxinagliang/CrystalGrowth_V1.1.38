using CrystalGrowth.CrystalCtl;
using CrystalGrowth.Unities;
using System;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction.Calibration
{
    internal partial class FrmCrucTrvLim : Form
    {
        public FrmCrucTrvLim()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void FrmCrucTrvLim_Load(object sender, EventArgs e)
        {
            LabDateTime.Text = Calibrate.ReadTime(12);
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (PLC.Count == 2)
            {
                LabTrvPV.Text = Math.Round(PLC.ReadAnalogValue[36], 1).ToString("f1");
                LabUpLim.Text = Math.Round(PLC.ReadCalibValue[20], 1).ToString("f1");
                LabDownLim.Text = Math.Round(PLC.ReadCalibValue[21], 1).ToString("f1");
            }
        }
        private void LabUpLim_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm();
            kf.ImportData(ref LabUpLim, -5000, 5000);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                Calibrate.WriteValue(12, 1, LabUpLim.Text);
            }
        }
        private void LabDownLim_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm();
            kf.ImportData(ref LabDownLim, -5000, 5000);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                Calibrate.WriteValue(12, 2, LabDownLim.Text);
            }
        }
    }
}
