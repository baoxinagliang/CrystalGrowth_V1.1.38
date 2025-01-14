using CrystalGrowth.CrystalCtl;
using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction.Calibration
{
    internal partial class FrmCrucTrv : Form
    {
        private float CrucTrvCalib = 0;
        public FrmCrucTrv()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void FrmCrucTrv_Load(object sender, EventArgs e)
        {
            LabTrvSP.Text = Math.Round(CrucTrvCalib, 1).ToString("f1");
            LabDateTime.Text = Calibrate.ReadTime(11);
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (PLC.Count == 2)
            {
                LabRawPV.Text = Math.Round(PLC.ReadAnalogValue[34], 1).ToString("f1");
                LabTrvPV.Text = Math.Round(PLC.ReadAnalogValue[36], 1).ToString("f1");
            }
        }
        private void BtnSetZero_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnSetZero))
            {
                Calibrate.WriteValue(11, 1, "");
                LabDateTime.Text = Calibrate.DateTimeStr;
            }
        }
        private void LabTrvSP_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm();
            kf.ImportData(ref LabTrvSP, -5000, 5000);
            kf.ShowDialog();
        }
        private void BtnSetSpan_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnSetSpan))
            {
                if (PLC.ReadAnalogValue[34] != PLC.ReadCalibValue[18])
                {
                    Calibrate.WriteValue(11, 2, LabTrvSP.Text);
                    LabDateTime.Text = Calibrate.DateTimeStr;
                }
                else
                {
                    LabDateTime.ForeColor = Color.Red;
                    LabDateTime.Text = "校准条件不具备";
                }
            }
        }
        private void LabTrvSP_TextChanged(object sender, EventArgs e)
        {
            CrucTrvCalib = float.Parse(LabTrvSP.Text);
        }
    }
}
