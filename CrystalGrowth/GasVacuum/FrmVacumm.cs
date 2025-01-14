using CrystalGrowth.CrystalCtl;
using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.GasVacuum
{
    internal partial class FrmVacumm : Form
    {
        public FrmVacumm()
        {
            InitializeComponent();
        }
        private void FrmVacumm_Load(object sender, EventArgs e)
        {
            Lab1000torrOffSP.Text = Math.Round(PLC.ReadCalibValue[45], 1).ToString("f1");
            Lab1000torrGainSP.Text = Math.Round(PLC.ReadCalibValue[46], 1).ToString("f1");
            Lab100torrOffSP.Text = Math.Round(PLC.ReadCalibValue[47], 1).ToString("f1");
            Lab100torrGainSP.Text = Math.Round(PLC.ReadCalibValue[48], 1).ToString("f1");
            Lab1torrOffSP.Text = Math.Round(PLC.ReadCalibValue[49], 1).ToString("f1");
            Lab1torrGainSP.Text = Math.Round(PLC.ReadCalibValue[50], 1).ToString("f1");
        }
        private void BtnVacummConfirm_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否发送校准参数？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                Calibrate.WriteValue(34, 1, Lab1000torrOffSP.Text);
                Calibrate.WriteValue(34, 2, Lab1000torrGainSP.Text);
                Calibrate.WriteValue(34, 3, Lab100torrOffSP.Text);
                Calibrate.WriteValue(34, 4, Lab100torrGainSP.Text);
                Calibrate.WriteValue(34, 5, Lab1torrOffSP.Text);
                Calibrate.WriteValue(34, 6, Lab1torrGainSP.Text);
            }
            else
            {
                Lab1000torrOffSP.Text = Math.Round(PLC.ReadCalibValue[45], 1).ToString("f1");
                Lab1000torrGainSP.Text = Math.Round(PLC.ReadCalibValue[46], 1).ToString("f1");
                Lab100torrOffSP.Text = Math.Round(PLC.ReadCalibValue[47], 1).ToString("f1");
                Lab100torrGainSP.Text = Math.Round(PLC.ReadCalibValue[48], 1).ToString("f1");
                Lab1torrOffSP.Text = Math.Round(PLC.ReadCalibValue[49], 1).ToString("f1");
                Lab1torrGainSP.Text = Math.Round(PLC.ReadCalibValue[50], 1).ToString("f1");
            }
        }
        private void Lab1torrOffSP_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm();
            kf.ImportData(ref Lab1torrOffSP, -20, 20);
            kf.Location = new Point(900, 200);
            kf.ShowDialog();
        }
        private void Lab1torrGainSP_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm();
            kf.ImportData(ref Lab1torrGainSP, (float)0.5, (float)1.5);
            kf.Location = new Point(900, 200);
            kf.ShowDialog();
        }
        private void Lab100torrOffSP_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm();
            kf.ImportData(ref Lab100torrOffSP, -20, 20);
            kf.Location = new Point(900, 200);
            kf.ShowDialog();
        }
        private void Lab100torrGainSP_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm();
            kf.ImportData(ref Lab100torrGainSP, (float)0.5, (float)1.5);
            kf.Location = new Point(900, 200);
            kf.ShowDialog();
        }
        private void Lab1000torrOffSP_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm();
            kf.ImportData(ref Lab1000torrOffSP, -20, 20);
            kf.Location = new Point(900, 200);
            kf.ShowDialog();
        }
        private void Lab1000torrGainSP_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm();
            kf.ImportData(ref Lab1000torrGainSP, (float)0.5, (float)1.5);
            kf.Location = new Point(900, 200);
            kf.ShowDialog();
        }
        double tempFTPress = 0;
        double tempPCPress = 0;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (PLC.Count == 2)
            {
                //主室1torr没做偏移和增量
                LabFTLowPress.Text = PLC.ReadAnalogValue[4] < 1000 ? Math.Round(PLC.ReadAnalogValue[4], 1).ToString("f1") : "---";
                //主室百托真空计             
                if (Math.Round(PLC.ReadCalibValue[48], 1) != 0)
                {
                    if (Math.Round(PLC.ReadCalibValue[47], 1) > 0)
                    {
                        tempFTPress = Math.Round(PLC.ReadAnalogValue[5] / PLC.ReadCalibValue[48], 1);
                    }
                    else
                    {
                        tempFTPress = Math.Round(PLC.ReadAnalogValue[5] / PLC.ReadCalibValue[48] - PLC.ReadCalibValue[47], 1);
                    }
                    LabFTPress.Text = tempFTPress < 100.0 ? Math.Round(PLC.ReadAnalogValue[5], 1).ToString("f1") : "---";
                }
                //副室千托真空计
                if (Math.Round(PLC.ReadCalibValue[46], 1) != 0)
                {
                    if (Math.Round(PLC.ReadCalibValue[45], 1) > 0)
                    {
                        tempPCPress = Math.Round(PLC.ReadAnalogValue[7] / PLC.ReadCalibValue[46], 1);
                    }
                    else
                    {
                        tempPCPress = Math.Round(PLC.ReadAnalogValue[7] / PLC.ReadCalibValue[46] - PLC.ReadCalibValue[45], 1);
                    }
                    LabPCPress.Text = tempPCPress < 1000.0 ? Math.Round(PLC.ReadAnalogValue[7], 1).ToString("f1") : "---";
                }
            }
        }
    }
}
