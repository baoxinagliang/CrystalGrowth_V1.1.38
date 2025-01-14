using CrystalGrowth.CrystalCtl;
using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction.Calibration
{
    internal partial class FrmSL_Speed : Form
    {
        public FrmSL_Speed()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void FrmSL_Speed_Load(object sender, EventArgs e)
        {
            LabDateTime.Text = Calibrate.ReadTime(24);
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (PLC.Count == 2)
            {
                LabSLPV.Text = Math.Round(PLC.ReadValue[49], 1).ToString("f1");
                LabSLCalib.Text = Math.Round(0f, 2).ToString("f2");
                LabGain.Text = Math.Round(PLC.ReadCalibValue[38], 2).ToString("f2");
            }
        }
        private void LabSLCalib_Click(object sender, EventArgs e)
        {
            if (PLC.ReadValue[49] > 0)
            {
                KeyForm kf = new KeyForm();
                kf.ImportData(ref LabSLCalib, 1, 508);
                kf.ShowDialog();
                if (kf.DialogResult == DialogResult.OK)
                {
                    Calibrate.WriteValue(24, 1, LabSLCalib.Text);
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
