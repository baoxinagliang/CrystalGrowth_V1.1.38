using CrystalGrowth.CrystalCtl;
using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction.Calibration
{
    internal partial class FrmCR_Speed : Form
    {
        public FrmCR_Speed()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void FrmCR_Speed_Load(object sender, EventArgs e)
        {
            LabDateTime.Text = Calibrate.ReadTime(27);
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (PLC.Count == 2)
            {
                LabCRPV.Text = Math.Round(PLC.ReadValue[56], 1).ToString("f1");
                LabGain.Text = Math.Round(PLC.ReadCalibValue[41], 2).ToString("f2");
            }
        }
        private void LabCRCalib_Click(object sender, EventArgs e)
        {
            if (PLC.ReadValue[56] > 0)
            {
                KeyForm kf = new KeyForm();
                kf.ImportData(ref LabCRCalib, 0.1f, 18);
                kf.ShowDialog();
                if (kf.DialogResult == DialogResult.OK)
                {
                    Calibrate.WriteValue(27, 1, LabCRCalib.Text);
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
