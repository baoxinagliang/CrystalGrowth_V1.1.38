using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.CrystalCtl
{
    internal partial class FrmPowerRate : Form
    {
        public FrmPowerRate()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (PLC.Count == 2)
            {
                LabPowerRate.Text = Math.Round(PLC.ReadValue[20], 2).ToString("f2");
                LabPowerTotal.Text = Math.Round(PLC.ReadValue[82], 2).ToString("f2");
                if (PLC.ReadStatus[28] == 1)
                {
                    BtnON.BackColor = Color.Red;
                    BtnOFF.BackColor = Color.Blue;
                }
                else
                {
                    BtnON.BackColor = Color.Blue;
                    BtnOFF.BackColor = Color.Red;
                }
            }
        }
        private void LabPowerRate_Click(object sender, EventArgs e)
        {
            if (LabPowerRate.BackColor == Color.White)
            {
                KeyForm kf = new KeyForm();
                kf.ImportData(ref LabPowerRate, -1000, 1000);
                kf.ShowDialog();
                if (kf.DialogResult == DialogResult.OK)
                {
                    PLC.SendFloat(33, 76, Convert.ToSingle(LabPowerRate.Text));
                    if (PLC.ReadStatus[28] == 1)
                    {
                        Record.WriteIn("主功率变化速率", LabPowerRate.Text, "Yellow"); ;
                    }
                }
            }
        }
        private void LabPowerTotal_Click(object sender, EventArgs e)
        {
            if (LabPowerTotal.BackColor == Color.White)
            {
                KeyForm kf = new KeyForm();
                kf.ImportData(ref LabPowerTotal, -100, 100);
                kf.ShowDialog();
                if (kf.DialogResult == DialogResult.OK)
                {
                    PLC.SendFloat(33, 324, Convert.ToSingle(LabPowerTotal.Text));
                    if (PLC.ReadStatus[28] == 1)
                    {
                        Record.WriteIn("主功率变化总量", LabPowerTotal.Text, "Yellow"); ;
                    }
                }
            }
        }
        private void BtnON_Click(object sender, EventArgs e)
        {
            if (PLC.ReadStatus[28] == 0)
            {
                PLC.SendBit(30, 50, 1);
                Record.WriteIn("主功率变化速率", "ON", "Yellow");
                BtnON.BackColor = Color.Red;
                BtnOFF.BackColor = Color.Blue;
            }
        }
        private void BtnOFF_Click(object sender, EventArgs e)
        {
            if (PLC.ReadStatus[28] == 1)
            {
                PLC.SendBit(30, 51, 1);
                Record.WriteIn("主功率变化速率", "OFF", "Yellow");
                BtnON.BackColor = Color.Blue;
                BtnOFF.BackColor = Color.Red;
            }
        }
    }
}
