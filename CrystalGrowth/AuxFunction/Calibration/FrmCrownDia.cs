using CrystalGrowth.CrystalCtl;
using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction.Calibration
{
    internal partial class FrmCrownDia : Form
    {
        private float DiaCrownCalib = 0;
        public FrmCrownDia()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void BtnCalib_Load(object sender, EventArgs e)
        {
            LabDiaCalib.Text = Math.Round(DiaCrownCalib, 2).ToString("f2");
            LabDateTime.Text = Calibrate.ReadTime(3);
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (PLC.Count == 2)
            {
                LabDiaPV.Text = Math.Round(PLC.ReadValue[7], 2).ToString("f2");
                LabRawPV.Text = Math.Round(PLC.ReadOthersValue[1], 2).ToString("f2");
                LabDiaOffs.Text = Math.Round(PLC.ReadCalibValue[4], 2).ToString("f2");
            }
        }
        private void LabDiaCalib_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm();
            kf.ImportData(ref LabDiaCalib, 1, 1000);
            kf.ShowDialog();
        }
        private void BtnCalib_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnCalib))
            {
                if (PLC.ReadOthersValue[1] > 0)
                {
                    Calibrate.WriteValue(3, 1, LabDiaCalib.Text);
                    LabDateTime.Text = Calibrate.DateTimeStr;
                }
                else
                {
                    LabDateTime.ForeColor = Color.Red;
                    LabDateTime.Text = "校准条件不具备";
                }
            }
        }
        private void LabDiaOffs_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm();
            kf.ImportData(ref LabDiaOffs, -100, 100);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                Calibrate.WriteValue(3, 2, LabDiaOffs.Text);
            }
        }
        private void LabDiaCalib_TextChanged(object sender, EventArgs e)
        {
            DiaCrownCalib = float.Parse(LabDiaCalib.Text);
        }
    }
}