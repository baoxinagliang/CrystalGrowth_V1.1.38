﻿using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.CrystalCtl
{
    internal partial class FrmPowerCtl : Form
    {
        public FrmPowerCtl()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            LabSupplyValid.Visible = PLC.PowerValue[1] <= 0;
            LabNeckSP.Text = Math.Round(PLC.ReadOthersValue[20], 2).ToString("f2");
            LabBodySP.Text = Math.Round(PLC.ReadOthersValue[33], 2).ToString("f2");
            if (PLC.Count == 2)
            {
                LabMainSP.Text = Math.Round(PLC.ReadValue[23], 2).ToString("f2");
                LabMainPV.Text = Math.Round(PLC.PowerValue[3], 2).ToString("f2");
                LabBotSP.Text = Math.Round(PLC.ReadValue[53], 2).ToString("f2");
                LabBotPV.Text = Math.Round(PLC.PowerValue[7], 2).ToString("f2");
                if (PLC.ReadStatus[1] == 1)
                {
                    BtnMainManu.Visible = true;
                    BtnMainAuto.Visible = true;
                    BtnBotManu.Visible = true;
                    BtnBotAuto.Visible = true;
                    LabMainSP.BackColor = PLC.ReadStatus[40] == 1 ? Color.White : Color.Gray;
                    LabBotSP.BackColor = PLC.ReadStatus[41] == 1 ? Color.White : Color.Gray;
                }
                else
                {
                    BtnMainManu.Visible = false;
                    BtnMainAuto.Visible = false;
                    BtnBotManu.Visible = false;
                    BtnBotAuto.Visible = false;
                }
                if (PLC.ReadStatus[40] == 1)
                {
                    BtnMainManu.BackColor = Color.Red;
                    BtnMainAuto.BackColor = Color.Blue;
                }
                else
                {
                    BtnMainManu.BackColor = Color.Blue;
                    BtnMainAuto.BackColor = Color.Red;
                }
                if (PLC.ReadStatus[41] == 1)
                {
                    BtnBotManu.BackColor = Color.Red;
                    BtnBotAuto.BackColor = Color.Blue;
                }
                else
                {
                    BtnBotManu.BackColor = Color.Blue;
                    BtnBotAuto.BackColor = Color.Red;
                }
            }
        }
        private void LabMainSP_Click(object sender, EventArgs e)
        {
            if (LabMainSP.BackColor == Color.White)
            {
                KeyForm kf = new KeyForm();
                kf.ImportData(ref LabMainSP, 0, 150);
                kf.ShowDialog();
                if (kf.DialogResult == DialogResult.OK)
                {
                    PLC.SendFloat(33, 84, Convert.ToSingle(LabMainSP.Text));
                    if (PLC.ReadStatusIn[13] == 1)
                    {
                        Record.WriteIn("主功率设定", LabMainSP.Text, "Yellow"); ;
                    }
                }
            }
        }
        private void LabBotSP_Click(object sender, EventArgs e)
        {
            if (LabBotSP.BackColor == Color.White)
            {
                KeyForm kf = new KeyForm();
                kf.ImportData(ref LabBotSP, 0, 150);
                kf.ShowDialog();
                if (kf.DialogResult == DialogResult.OK)
                {
                    PLC.SendFloat(33, 208, Convert.ToSingle(LabBotSP.Text));
                    if (PLC.ReadStatusIn[13] == 1)
                    {
                        Record.WriteIn("底部功率设定", LabBotSP.Text, "Yellow");
                    }
                }
            }
        }
        private void BtnMainManu_Click(object sender, EventArgs e)
        {
            PLC.SendBit(30, 69, 1);
            Record.WriteIn("加热功率-主加功率手动", "ON", "Yellow");
            BtnMainManu.BackColor = Color.Red;
            BtnMainAuto.BackColor = Color.Blue;
            if (PLC.ReadStatus[1] == 1)
            {
                LabMainSP.BackColor = Color.White;
            }
        }
        private void BtnMainAuto_Click(object sender, EventArgs e)
        {
            PLC.SendBit(30, 70, 1);
            Record.WriteIn("加热功率-主加功率自动", "ON", "Yellow");
            BtnMainManu.BackColor = Color.Blue;
            BtnMainAuto.BackColor = Color.Red;
            if (PLC.ReadStatus[1] == 1)
            {
                LabMainSP.BackColor = Color.Gray;
            }
        }
        private void BtnBotManu_Click(object sender, EventArgs e)
        {
            PLC.SendBit(30, 71, 1);
            Record.WriteIn("加热功率-底加功率手动", "ON", "Yellow");
            BtnBotManu.BackColor = Color.Red;
            BtnBotAuto.BackColor = Color.Blue;
            if (PLC.ReadStatus[1] == 1)
            {
                LabBotSP.BackColor = Color.White;
            }
        }
        private void BtnBotAuto_Click(object sender, EventArgs e)
        {
            PLC.SendBit(30, 72, 1);
            Record.WriteIn("加热功率-底加功率自动", "ON", "Yellow");
            BtnBotManu.BackColor = Color.Blue;
            BtnBotAuto.BackColor = Color.Red;
            if (PLC.ReadStatus[1] == 1)
            {
                LabBotSP.BackColor = Color.Gray;
            }
        }
        private void LabNeckSP_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm();
            kf.ImportData(ref LabNeckSP, 0, 150);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                PLC.SendFloat(31, 76, Convert.ToSingle(LabNeckSP.Text));
                Record.WriteIn("引晶功率设定", LabNeckSP.Text, "Yellow");
            }
        }

        private void LabBodySP_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm();
            kf.ImportData(ref LabBodySP, 0, 150);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                PLC.SendFloat(31, 128, Convert.ToSingle(LabBodySP.Text));
                Record.WriteIn("等径头部功率设定", LabBodySP.Text, "Yellow");
            }
        }
    }
}
