using CrystalGrowth.CrystalCtl;
using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction.Calibration
{
    internal partial class FrmWeightCalib : Form
    {
        private float SeedWeigCalib = 0;
        public FrmWeightCalib()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void FrmWeightCalib_Load(object sender, EventArgs e)
        {
            LabWeigSP.Text = Math.Round(SeedWeigCalib, 2).ToString("f2");
            LabDateTime.Text = Calibrate.ReadTime(9);
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (PLC.Count == 2)
            {
                LabRawWeig.Text = Math.Round(PLC.ReadAnalogValue[40], 2).ToString("f2");
                LabNetWeig.Text = Math.Round(PLC.ReadValue[70], 2).ToString("f2");
                LabWeightLoad.Text = Math.Round(PLC.ReadCalibValue[14], 2).ToString("f2");
            }
        }
        private void BtnSetZero_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnSetZero))
            {
                Calibrate.WriteValue(9, 1, "");
                LabDateTime.Text = Calibrate.DateTimeStr;
            }
        }
        private void LabWeigSP_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm();
            kf.ImportData(ref LabWeigSP, 1, 1000);
            kf.ShowDialog();
        }
        private void BtnSetSpan_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnSetSpan))
            {
                if (PLC.ReadAnalogValue[40] > PLC.ReadCalibValue[16])
                {
                    Calibrate.WriteValue(9, 2, LabWeigSP.Text);
                    LabDateTime.Text = Calibrate.DateTimeStr;
                }
                else
                {
                    LabDateTime.ForeColor = Color.Red;
                    LabDateTime.Text = "校准条件不具备";
                }
            }
        }
        private void LabWeigSP_TextChanged(object sender, EventArgs e)
        {
            SeedWeigCalib = float.Parse(LabWeigSP.Text);
        }
        private void LabWeightLoad_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm();
            kf.ImportData(ref LabWeightLoad, 0.0f, 50.0f);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                PLC.SendFloat(34, 52, Convert.ToSingle(LabWeightLoad.Text));
                Record.WriteIn("重锤初始重量", LabWeightLoad.Text, "Yellow");
            }
        }
        private void LabWeightLoad_TextChanged(object sender, EventArgs e)
        {
            if (PLC.IsConn)
            {
                SeedWeigCalib = Convert.ToSingle(LabWeigSP.Text);
            }
        }
    }
}
