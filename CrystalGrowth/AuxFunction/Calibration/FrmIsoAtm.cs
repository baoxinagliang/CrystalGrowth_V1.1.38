using CrystalGrowth.CrystalCtl;
using CrystalGrowth.Unities;
using System;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction.Calibration
{
    internal partial class FrmIsoAtm : Form
    {
        public FrmIsoAtm()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void FrmIsoAtm_Load(object sender, EventArgs e)
        {
            LabDateTime.Text = Calibrate.ReadTime(20);
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (PLC.Count == 2)
            {
                LabAtmSP.Text = Math.Round(PLC.ReadCalibValue[35], 1).ToString("f1");
                LabFastPress.Text = Math.Round(PLC.ReadValue[66], 1).ToString("f1");
            }
        }
        private void LabAtmSP_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm();
            kf.ImportData(ref LabAtmSP, 0, 800);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                Calibrate.WriteValue(20, 1, LabAtmSP.Text);
                Record.WriteIn("大气压力设定", LabAtmSP.Text, "Yellow");
            }
        }
        private void LabFastPress_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm();
            kf.ImportData(ref LabFastPress, 0, 1000);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                Calibrate.WriteValue(20, 2, LabFastPress.Text);
                Record.WriteIn("快充压力设定", LabFastPress.Text, "Yellow");
            }
        }
    }
}
