using CrystalGrowth.CrystalCtl;
using CrystalGrowth.Unities;
using System;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction.Calibration
{
    internal partial class FrmPulloutWeig : Form
    {
        public FrmPulloutWeig()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void FrmPulloutWeig_Load(object sender, EventArgs e)
        {
            LabDateTime.Text = Calibrate.ReadTime(29);
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (PLC.Count == 2)
            {
                LabRemainWeig.Text = Math.Round(PLC.ReadCalcValue[10], 2).ToString("f2");
                LabTotalWeig.Text = Math.Round(PLC.ReadCalcValue[11], 2).ToString("f2");
                LabPullOutWeig.Text = Math.Round(PLC.ReadCalcValue[9], 2).ToString("f2");
                LabPullOutWeigInc.Text = Math.Round(0f, 2).ToString("f2");
            }
        }
        private void LabPullOutWeigInc_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm();
            kf.ImportData(ref LabPullOutWeigInc, -500, 500);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                Calibrate.WriteValue(29, 1, LabPullOutWeigInc.Text);
            }
        }
    }
}
