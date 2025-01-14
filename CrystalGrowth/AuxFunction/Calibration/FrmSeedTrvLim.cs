using CrystalGrowth.CrystalCtl;
using CrystalGrowth.Unities;
using System;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction.Calibration
{
    internal partial class FrmSeedTrvLim : Form
    {
        public FrmSeedTrvLim()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void FrmSeedTrvLim_Load(object sender, EventArgs e)
        {
            LabDateTime.Text = Calibrate.ReadTime(7);
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (PLC.Count == 2)
            {
                LabTrvPV.Text = Math.Round(PLC.ReadAnalogValue[35], 1).ToString("f1");
                LabUpLim.Text = Math.Round(PLC.ReadCalibValue[11], 1).ToString("f1");
                LabDownLim.Text = Math.Round(PLC.ReadCalibValue[12], 1).ToString("f1");
            }
        }
        private void LabUpLim_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm();
            kf.ImportData(ref LabUpLim, -10000, 10000);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                Calibrate.WriteValue(7, 1, LabUpLim.Text);
            }
        }
        private void LabDownLim_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm();
            kf.ImportData(ref LabDownLim, -10000, 10000);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                Calibrate.WriteValue(7, 2, LabDownLim.Text);
            }
        }
    }
}
