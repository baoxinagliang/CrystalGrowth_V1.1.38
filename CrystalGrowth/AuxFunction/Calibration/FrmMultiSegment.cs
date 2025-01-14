using CrystalGrowth.CrystalCtl;
using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction.Calibration
{
    internal partial class FrmMultiSegment : Form
    {
        public FrmMultiSegment()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void FrmMultiSegment_Load(object sender, EventArgs e)
        {
            LabDateTime.Text = Calibrate.ReadTime(28);
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (PLC.Count == 2)
            {
                LabMultiSegment.Text = Math.Round(PLC.ReadCalcValue[22], 1).ToString("f1");
                LabCrystalLen.Text = Math.Round(PLC.ReadCalcValue[14], 1).ToString("f1");
                LabPullOutLen.Text = Math.Round(PLC.ReadCalcValue[29], 1).ToString("f1");
            }
        }
        private void LabPullOutLen_Click(object sender, EventArgs e)
        {
            if (PLC.ReadValue[1] == 13)
            {
                KeyForm kf = new KeyForm();
                kf.ImportData(ref LabPullOutLen, 0, 5000);
                kf.ShowDialog();
                if (kf.DialogResult == DialogResult.OK)
                {
                    Calibrate.WriteValue(28, 1, LabPullOutLen.Text);
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
