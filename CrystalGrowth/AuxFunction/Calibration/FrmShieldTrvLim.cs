using CrystalGrowth.CrystalCtl;
using CrystalGrowth.Unities;
using System;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction.Calibration
{
    internal partial class FrmShieldTrvLim : Form
    {
        public FrmShieldTrvLim()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void FrmShieldTrvLim_Load(object sender, EventArgs e)
        {
            LabDateTime.Text = Calibrate.ReadTime(15);
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (PLC.Count == 2)
            {
                LabTrvPV.Text = Math.Round(PLC.ReadAnalogValue[37], 1).ToString("f1");
                LabUpLim.Text = Math.Round(PLC.ReadCalibValue[25], 1).ToString("f1");
                LabDownLim.Text = Math.Round(PLC.ReadCalibValue[26], 1).ToString("f1");
            }
        }
        private void LabUpLim_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm();
            kf.ImportData(ref LabUpLim, -20000, 20000);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                Calibrate.WriteValue(15, 1, LabUpLim.Text);
            }
        }
        private void LabDownLim_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm();
            kf.ImportData(ref LabDownLim, -20000, 20000);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                Calibrate.WriteValue(15, 2, LabDownLim.Text);
            }
        }
    }
}
