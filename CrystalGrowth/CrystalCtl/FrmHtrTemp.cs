﻿using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.CrystalCtl
{
    internal partial class FrmHtrTemp : Form
    {
        public FrmHtrTemp()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void FrmHtrTemp_Load(object sender, EventArgs e)
        {
            BtnTune.BackColor = Color.Fuchsia;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (PLC.Count == 2)
            {
                LabSP.Text = Math.Round(PLC.ReadValue[11], 1).ToString("f1");
                LabPV.Text = Math.Round(PLC.ReadValue[12], 1).ToString("f1");
                LabOut.Text = Math.Round(PLC.ReadValue[23], 2).ToString("f2");
                if (BtnTune.BackColor == Color.Fuchsia)
                {
                    LabGainVal.Text = Math.Round(PLC.ReadValue[26], 4).ToString("f4");
                    LabIntegVal.Text = Math.Round(PLC.ReadValue[27], 4).ToString("f4");
                    LabDifferVal.Text = Math.Round(PLC.ReadValue[28], 4).ToString("f4");
                }
                if (BtnLimit.BackColor == Color.Fuchsia)
                {
                    LabIntegVal.Text = Math.Round(PLC.ReadValue[24], 2).ToString("f2");
                    LabDifferVal.Text = Math.Round(PLC.ReadValue[25], 2).ToString("f2");
                }
                if (PLC.ReadStatus[1] == 1)
                {
                    BtnFixed.Visible = true;
                    BtnAuto.Visible = true;
                    LabSP.BackColor = PLC.ReadStatus[30] == 1 ? Color.White : Color.Gray;
                }
                else
                {
                    BtnFixed.Visible = false;
                    BtnAuto.Visible = false;
                    LabSP.BackColor = PLC.ReadStatus[5] == 1 ? Color.White : Color.Gray;
                }
                if (PLC.ReadStatus[30] == 1)
                {
                    BtnFixed.BackColor = Color.Red;
                    BtnAuto.BackColor = Color.Blue;
                }
                else
                {
                    BtnFixed.BackColor = Color.Blue;
                    BtnAuto.BackColor = Color.Red;
                }
                if (PLC.ReadStatus[5] == 1)
                {
                    BtnON.BackColor = Color.Red;
                    BtnOFF.BackColor = Color.Blue;
                }
                else
                {
                    BtnON.BackColor = Color.Blue;
                    BtnOFF.BackColor = Color.Red;
                }
                LabOut.BackColor = PLC.ReadStatus[5] == 1 || PLC.ReadStatus[6] == 1 ? Color.Gray : Color.White;
            }
        }
        private void BtnTune_Click(object sender, EventArgs e)
        {
            BtnTune.BackColor = Color.Fuchsia;
            BtnLimit.BackColor = Color.Blue;
            LabGainTxt.Visible = true;
            LabGainVal.Visible = true;
            LabDifferTxt.Text = "微分";
            LabIntegTxt.Text = "积分";
            LabGainVal.Text = Math.Round(PLC.ReadValue[26], 4).ToString("f4");
            LabIntegVal.Text = Math.Round(PLC.ReadValue[27], 4).ToString("f4");
            LabDifferVal.Text = Math.Round(PLC.ReadValue[28], 4).ToString("f4");
        }
        private void BtnLimit_Click(object sender, EventArgs e)
        {
            BtnTune.BackColor = Color.Blue;
            BtnLimit.BackColor = Color.Fuchsia;
            LabGainTxt.Visible = false;
            LabGainVal.Visible = false;
            LabDifferTxt.Text = "下限";
            LabIntegTxt.Text = "上限";
            LabIntegVal.Text = Math.Round(PLC.ReadValue[24], 2).ToString("f2");
            LabDifferVal.Text = Math.Round(PLC.ReadValue[25], 2).ToString("f2");
        }
        private void LabSP_Click(object sender, EventArgs e)
        {
            if (LabSP.BackColor == Color.White)
            {
                KeyForm kf = new KeyForm();
                kf.ImportData(ref LabSP, 0, 2000);
                kf.ShowDialog();
                if (kf.DialogResult == DialogResult.OK)
                {
                    PLC.SendFloat(33, 40, Convert.ToSingle(LabSP.Text));
                    if (PLC.ReadStatus[5] == 1)
                    {
                        Record.WriteIn("热场温度设定", LabSP.Text, "Yellow");
                    }
                }
            }
        }
        private void LabOut_Click(object sender, EventArgs e)
        {
            if (LabOut.BackColor == Color.White)
            {
                KeyForm kf = new KeyForm();
                kf.ImportData(ref LabOut, 0, 150);
                kf.ShowDialog();
                if (kf.DialogResult == DialogResult.OK)
                {
                    PLC.SendFloat(33, 84, Convert.ToSingle(LabOut.Text));
                    if (PLC.ReadStatusIn[13] == 1)
                    {
                        Record.WriteIn("主功率设定", LabOut.Text, "Yellow");
                    }
                }
            }
        }
        private void LabGainVal_Click(object sender, EventArgs e)
        {
            if (LabGainVal.BackColor == Color.White)
            {
                KeyForm kf = new KeyForm();
                kf.ImportData(ref LabGainVal, 0, 200);
                kf.ShowDialog();
                if (kf.DialogResult == DialogResult.OK)
                {
                    PLC.SendFloat(33, 100, Convert.ToSingle(LabGainVal.Text));
                    Record.WriteIn("热场温度控制增益", LabGainVal.Text, "Yellow");
                }
            }
        }
        private void LabDifferVal_Click(object sender, EventArgs e)
        {
            if (LabDifferVal.BackColor == Color.White)
            {
                KeyForm kf = new KeyForm();
                if (BtnTune.BackColor == Color.Fuchsia)
                {
                    kf.ImportData(ref LabDifferVal, 0, 100);
                }
                if (BtnLimit.BackColor == Color.Fuchsia)
                {
                    kf.ImportData(ref LabDifferVal, 0, 150);
                }
                kf.ShowDialog();
                if (kf.DialogResult == DialogResult.OK)
                {
                    if (BtnTune.BackColor == Color.Fuchsia)
                    {
                        PLC.SendFloat(33, 108, Convert.ToSingle(LabDifferVal.Text));
                        Record.WriteIn("热场温度控制微分", LabDifferVal.Text, "Yellow");
                    }
                    if (BtnLimit.BackColor == Color.Fuchsia)
                    {
                        PLC.SendFloat(33, 96, Convert.ToSingle(LabDifferVal.Text));
                        Record.WriteIn("热场温度控制下限", LabDifferVal.Text, "Yellow");
                    }
                }
            }
        }
        private void LabIntegVal_Click(object sender, EventArgs e)
        {
            if (LabIntegVal.BackColor == Color.White)
            {
                KeyForm kf = new KeyForm();
                if (BtnTune.BackColor == Color.Fuchsia)
                {
                    kf.ImportData(ref LabIntegVal, 0, 100);
                }
                if (BtnLimit.BackColor == Color.Fuchsia)
                {
                    kf.ImportData(ref LabIntegVal, 0, 150);
                }
                kf.ShowDialog();
                if (kf.DialogResult == DialogResult.OK)
                {
                    if (BtnTune.BackColor == Color.Fuchsia)
                    {
                        PLC.SendFloat(33, 104, Convert.ToSingle(LabIntegVal.Text));
                        Record.WriteIn("热场温度控制积分", LabIntegVal.Text, "Yellow");
                    }
                    if (BtnLimit.BackColor == Color.Fuchsia)
                    {
                        PLC.SendFloat(33, 92, Convert.ToSingle(LabIntegVal.Text));
                        Record.WriteIn("热场温度控制上限", LabIntegVal.Text, "Yellow");
                    }
                }
            }
        }
        private void BtnON_Click(object sender, EventArgs e)
        {
            if (PLC.ReadStatus[5] == 0)
            {
                PLC.SendBit(30, 7, 1);
                Record.WriteIn("热场温度控制", "ON", "Yellow");
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
            if (PLC.ReadStatus[5] == 1)
            {
                PLC.SendBit(30, 8, 1);
                Record.WriteIn("热场温度控制", "OFF", "Yellow");
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
            PLC.SendBit(30, 54, 1); 
            Record.WriteIn("热场温度控制自动", "ON", "Yellow");
            BtnAuto.BackColor = Color.Red;
            BtnFixed.BackColor = Color.Blue;
            if (PLC.ReadStatus[1] == 1)
            {
                LabSP.BackColor = Color.Gray;
            }
        }
        private void BtnFixed_Click(object sender, EventArgs e)
        {
            PLC.SendBit(30, 55, 1);
            Record.WriteIn("热场温度控制固定值", "ON", "Yellow");
            BtnAuto.BackColor = Color.Blue;
            BtnFixed.BackColor = Color.Red;
            if (PLC.ReadStatus[1] == 1)
            {
                LabSP.BackColor = Color.White;
            }
        }
    }
}
