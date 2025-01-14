using CrystalGrowth.CrystalCtl;
using CrystalGrowth.Unities;
using System;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction.Calibration
{
    internal partial class FrmWeightTune : Form
    {
        public FrmWeightTune()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void FrmWeightTune_Load(object sender, EventArgs e)
        {
            LabDateTime.Text = Calibrate.ReadTime(10);
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (PLC.Count == 2)
            {
                LabTotalWeig.Text = Math.Round(PLC.ReadCalcValue[11], 2).ToString("f2");
                LabLoadWeig.Text = Math.Round(0f, 2).ToString("f2");
                LabPullOutWeig.Text = Math.Round(PLC.ReadCalcValue[9], 2).ToString("f2");
                LabRemainWeig.Text = Math.Round(PLC.ReadCalcValue[10], 2).ToString("f2");
            }
        }
        private void LabLoadWeig_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm();
            kf.ImportData(ref LabLoadWeig, -500, 500);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                Calibrate.WriteValue(10, 1, LabLoadWeig.Text);
            }
        }
    }
}
