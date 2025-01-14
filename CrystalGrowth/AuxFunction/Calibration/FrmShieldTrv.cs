using CrystalGrowth.CrystalCtl;
using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction.Calibration
{
    internal partial class FrmShieldTrv : Form
    {
        private float ShieldTrvCalib = 0;
        public FrmShieldTrv()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void FrmShieldTrv_Load(object sender, EventArgs e)
        {
            LabTrvSP.Text = Math.Round(ShieldTrvCalib, 1).ToString("f1");
            LabShieldUpTorque.Text = Math.Round(PLC.ReadCalibValue[42], 1).ToString("f1");
            LabShieldDownTorque.Text = Math.Round(PLC.ReadCalibValue[43], 1).ToString("f1");
            LabShieldPosDev.Text = Math.Round(PLC.ReadCalibValue[44], 1).ToString("f1");
            LabDateTime.Text = Calibrate.ReadTime(14);
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (PLC.Count == 2)
            {
                LabRawSlavePV.Text = Math.Round(PLC.ReadAnalogValue[23], 1).ToString("f1");
                LabRawMainPV.Text = Math.Round(PLC.ReadAnalogValue[50], 1).ToString("f1");
                LabTrvPV.Text = Math.Round(PLC.ReadAnalogValue[37], 1).ToString("f1");
                LabShieldActTorque.Text = Math.Round(PLC.ReadValue[92], 1).ToString("f1");
            }
        }
        private void BtnSetZero_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnSetZero))
            {
                Calibrate.WriteValue(14, 2, "");
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
                if (PLC.ReadAnalogValue[23] != PLC.ReadCalibValue[24])
                {
                    Calibrate.WriteValue(14, 1, LabTrvSP.Text);
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
            ShieldTrvCalib = float.Parse(LabTrvSP.Text);
        }
        private void LabShieldUpTorque_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm();
            kf.ImportData(ref LabShieldUpTorque, -20000, 20000);
            kf.ShowDialog();
        }
        private void LabShieldDownTorque_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm();
            kf.ImportData(ref LabShieldDownTorque, -20000, 20000);
            kf.ShowDialog();
        }
        private void LabShieldPosDev_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm();
            kf.ImportData(ref LabShieldPosDev, -20000, 20000);
            kf.ShowDialog();
        }
        private void BtnShieldConfirm_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否发送力矩参数？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                Calibrate.WriteValue(31, 1, LabShieldUpTorque.Text);
                Calibrate.WriteValue(32, 1, LabShieldDownTorque.Text);
                Calibrate.WriteValue(33, 1, LabShieldPosDev.Text);
                LabDateTime.Text = Calibrate.DateTimeStr;
            }
            else
            {
                LabShieldUpTorque.Text = Math.Round(PLC.ReadCalibValue[42], 1).ToString("f1");
                LabShieldDownTorque.Text = Math.Round(PLC.ReadCalibValue[43], 1).ToString("f1");
                LabShieldPosDev.Text = Math.Round(PLC.ReadCalibValue[44], 1).ToString("f1");
            }
        }
        private void BtnShieldCoderSyn_Click(object sender, EventArgs e)
        {
            PLC.SendBit(30, 151, 1);
        }
    }
}
