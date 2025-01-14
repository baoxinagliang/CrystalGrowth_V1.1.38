using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.CrystalCtl
{
    internal partial class FrmPressCtl : Form
    {
        public FrmPressCtl()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (PLC.Count == 2)
            {
                LabSP.Text = Math.Round(PLC.ReadValue[47], 1).ToString("f1");
                LabPV.Text = PLC.ReadValue[48] < 100 ? Math.Round(PLC.ReadValue[48], 1).ToString("f1") : "---";
                LabOut.Text = Math.Round(PLC.ReadValue[46], 1).ToString("f1");
                LabOutTxt.Text = PLC.ReadStatus[60] == 0 ? "节流阀开度" : "干泵频率";
                if (PLC.ReadStatus[1] == 1)
                {
                    BtnManu.Visible = true;
                    BtnAuto.Visible = true;
                    LabSP.BackColor = PLC.ReadStatus[61] == 1 ? Color.White : Color.Gray;
                }
                else
                {
                    BtnManu.Visible = false;
                    BtnAuto.Visible = false;
                    LabSP.BackColor = PLC.ReadStatus[10] == 1 ? Color.White : Color.Gray;
                }
                if (PLC.ReadStatus[61] == 1)
                {
                    BtnManu.BackColor = Color.Red;
                    BtnAuto.BackColor = Color.Blue;
                }
                else
                {
                    BtnManu.BackColor = Color.Blue;
                    BtnAuto.BackColor = Color.Red;
                }
                if (PLC.ReadStatus[10] == 1)
                {
                    BtnON.BackColor = Color.Red;
                    BtnOFF.BackColor = Color.Blue;
                    LabOut.BackColor = Color.Gray;
                }
                else
                {
                    BtnON.BackColor = Color.Blue;
                    BtnOFF.BackColor = Color.Red;
                    LabOut.BackColor = Color.White;
                }
            }
        }
        private void LabSP_Click(object sender, EventArgs e)
        {
            if (LabSP.BackColor == Color.White)
            {
                KeyForm kf = new KeyForm();
                kf.ImportData(ref LabSP, 0, 760);
                kf.ShowDialog();
                if (kf.DialogResult == DialogResult.OK)
                {
                    PLC.SendFloat(33, 184, Convert.ToSingle(LabSP.Text));
                    if (PLC.ReadStatus[10] == 1)
                    {
                        Record.WriteIn("压力设定", LabSP.Text, "Yellow"); ;
                    }
                }
            }
        }
        private void LabOut_Click(object sender, EventArgs e)
        {
            if (LabOut.BackColor == Color.White)
            {
                KeyForm kf = new KeyForm();
                kf.ImportData(ref LabOut, 0, 100);
                kf.ShowDialog();
                if (kf.DialogResult == DialogResult.OK)
                {
                    PLC.SendFloat(33, 180, Convert.ToSingle(LabOut.Text));
                    Record.WriteIn("节流阀开度设定", LabOut.Text, "Yellow");
                }
            }
        }
        private void BtnON_Click(object sender, EventArgs e)
        {
            if (PLC.ReadStatus[10] == 0)
            {
                PLC.SendBit(30, 17, 1);
                Record.WriteIn("压力控制", "ON", "Yellow");
                BtnON.BackColor = Color.Red;
                BtnOFF.BackColor = Color.Blue;
                LabOut.BackColor = Color.Gray;
                if (PLC.ReadStatus[1] == 0)
                {
                    LabSP.BackColor = Color.White;
                }
            }
        }
        private void BtnOFF_Click(object sender, EventArgs e)
        {
            if (PLC.ReadStatus[10] == 1)
            {
                PLC.SendBit(30, 18, 1);
                Record.WriteIn("压力控制", "OFF", "Yellow");
                BtnON.BackColor = Color.Blue;
                BtnOFF.BackColor = Color.Red;
                LabOut.BackColor = Color.White;
                if (PLC.ReadStatus[1] == 0)
                {
                    LabSP.BackColor = Color.Gray;
                }
            }
        }
        private void BtnAuto_Click(object sender, EventArgs e)
        {
            PLC.SendBit(30, 85, 1);
            Record.WriteIn("压力控制自动", "ON", "Yellow");
            BtnAuto.BackColor = Color.Red;
            BtnManu.BackColor = Color.Blue;
            if (PLC.ReadStatus[1] == 1)
            {
                LabSP.BackColor = Color.Gray;
            }
        }
        private void BtnManu_Click(object sender, EventArgs e)
        {
            PLC.SendBit(30, 84, 1);
            Record.WriteIn("压力控制手动", "ON", "Yellow");
            BtnAuto.BackColor = Color.Blue;
            BtnManu.BackColor = Color.Red;
            if (PLC.ReadStatus[1] == 1)
            {
                LabSP.BackColor = Color.White;
            }
        }
    }
}
