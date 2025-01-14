using CrystalGrowth.CrystalCtl;
using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction.Calibration
{
    internal partial class FrmCL_Speed : Form
    {
        public FrmCL_Speed()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void FrmCL_Speed_Load(object sender, EventArgs e)
        {
            LabDateTime.Text = Calibrate.ReadTime(26);
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (PLC.Count == 2)
            {
                LabCLPV.Text = Math.Round(PLC.ReadValue[54], 1).ToString("f1");
                LabGain.Text = Math.Round(PLC.ReadCalibValue[40], 2).ToString("f2");
            }
        }
        private void LabCLCalib_Click(object sender, EventArgs e)
        {
            if (PLC.ReadValue[54] > 0)
            {
                KeyForm kf = new KeyForm();
                kf.ImportData(ref LabCLCalib, 1, 127);
                kf.ShowDialog();
                if (kf.DialogResult == DialogResult.OK)
                {
                    Calibrate.WriteValue(26, 1, LabCLCalib.Text);
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
