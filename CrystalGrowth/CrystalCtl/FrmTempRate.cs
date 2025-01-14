using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.CrystalCtl
{
    internal partial class FrmTempRate : Form
    {
        public FrmTempRate()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (PLC.Count == 2)
            {
                LabTempRate.Text = Math.Round(PLC.ReadValue[21], 1).ToString("f1");
                LabTempTotal.Text = Math.Round(PLC.ReadValue[76], 1).ToString("f1");
                if (PLC.ReadStatus[4] == 1)
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
        private void LabTempRate_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm();
            kf.ImportData(ref LabTempRate, -1000, 1000);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                PLC.SendFloat(33, 80, Convert.ToSingle(LabTempRate.Text));
                if (PLC.ReadStatus[4] == 1)
                {
                    Record.WriteIn("热场温度变化速率", LabTempRate.Text, "Yellow");
                }
            }
        }
        private void LabTempTotal_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm();
            kf.ImportData(ref LabTempTotal, -200, 200);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                PLC.SendFloat(33, 300, Convert.ToSingle(LabTempTotal.Text));
                if (PLC.ReadStatus[4] == 1)
                {
                    Record.WriteIn("热场温度变化总量", LabTempTotal.Text, "Yellow");
                }
            }
        }
        private void BtnON_Click(object sender, EventArgs e)
        {
            if (PLC.ReadStatus[4] == 0)
            {
                PLC.SendBit(30, 5, 1);
                Record.WriteIn("热场温度变化速率", "ON", "Yellow");
                BtnON.BackColor = Color.Red;
                BtnOFF.BackColor = Color.Blue;
            }
        }
        private void BtnOFF_Click(object sender, EventArgs e)
        {
            if (PLC.ReadStatus[4] == 1)
            {
                PLC.SendBit(30, 6, 1);
                Record.WriteIn("热场温度变化速率", "OFF", "Yellow");
                BtnON.BackColor = Color.Blue;
                BtnOFF.BackColor = Color.Red;
            }
        }
    }
}
