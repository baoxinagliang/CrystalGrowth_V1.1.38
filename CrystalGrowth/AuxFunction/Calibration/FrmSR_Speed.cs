using CrystalGrowth.CrystalCtl;
using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction.Calibration
{
    internal partial class FrmSR_Speed : Form
    {
        public FrmSR_Speed()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void FrmSR_Speed_Load(object sender, EventArgs e)
        {
            LabDateTime.Text = Calibrate.ReadTime(25);
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (PLC.Count == 2)
            {
                LabSRPV.Text = Math.Round(PLC.ReadValue[51], 1).ToString("f1");
                LabSRCalib.Text = Math.Round(0f, 2).ToString("f2");
                LabGain.Text = Math.Round(PLC.ReadCalibValue[39], 2).ToString("f2");
            }
        }
        private void LabSRCalib_Click(object sender, EventArgs e)
        {
            if (PLC.ReadValue[51] > 0)
            {
                KeyForm kf = new KeyForm();
                kf.ImportData(ref LabSRCalib, 0.1f, 30);
                kf.ShowDialog();
                if (kf.DialogResult == DialogResult.OK)
                {
                    Calibrate.WriteValue(25, 1, LabSRCalib.Text);
                }
            }
            else
            {
                LabDateTime.ForeColor = Color.Red;
                LabDateTime.Text = "校准条件不具备";
            }
        }
    }
}
