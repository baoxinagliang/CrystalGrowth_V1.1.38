﻿using CrystalGrowth.AuxFunction.License;
using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.CrystalCtl
{
    internal partial class FrmDiaCtl : Form
    {
        public FrmDiaCtl()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void FrmDiaCtl_Load(object sender, EventArgs e)
        {
            BtnTune.BackColor = Color.Fuchsia;
            BtnAuto.Visible = false;
            BtnFixed.Visible = false;
            GBSeedLift.Visible = false;   
            LabDiaCalibVal.Visible = false;
            //GBDiaCalib.Visible = false;
            //BtnCalib.Visible = false;
            //Label7.Visible = false;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (PLC.Count == 2)
            {
                LabSP.Text = PLC.ReadValue[1] == 11 ? Math.Round(PLC.ReadValue[6] + 1E-10 - 0.05, 1).ToString("f1") : Math.Round(PLC.ReadValue[6], 2).ToString("f2");
                LabPV.Text = Math.Round(PLC.ReadValue[7], 2).ToString("f2");
                LabOut.Text = Math.Round(PLC.ReadValue[3], 1).ToString("f1");
                if (BtnTune.BackColor == Color.Fuchsia)
                {
                    LabGainVal.Text = Math.Round(PLC.ReadValue[8], 4).ToString("f4");
                    LabIntegVal.Text = Math.Round(PLC.ReadValue[9], 4).ToString("f4");
                    LabDifferVal.Text = Math.Round(PLC.ReadValue[10], 4).ToString("f4");
                }
                if (BtnLimit.BackColor == Color.Fuchsia)
                {
                    LabIntegVal.Text = Math.Round(PLC.ReadValue[4], 1).ToString("f1");
                    LabDifferVal.Text = Math.Round(PLC.ReadValue[5], 1).ToString("f1");
                }
                if (PLC.ReadStatus[2] == 1)
                {
                    BtnON.BackColor = Color.Red;
                    BtnOFF.BackColor = Color.Blue;
                    //LabOut.BackColor = PLC.ReadValue[1] == 11 ? Color.White : Color.Gray;
                    LabSP.BackColor = PLC.ReadStatus[1] == 1 ? Color.Gray : Color.White;
                }
                else
                {
                    BtnON.BackColor = Color.Blue;
                    BtnOFF.BackColor = Color.Red;
                    //LabOut.BackColor = Color.White;
                    LabSP.BackColor = Color.Gray;
                }
                if (PLC.ReadStatus[94] == 1)
                {
                    BtnFixed.BackColor = Color.Red;
                    BtnAuto.BackColor = Color.Blue;
                }
                else
                {
                    BtnFixed.BackColor = Color.Blue;
                    BtnAuto.BackColor = Color.Red;
                }
                if (PLC.ReadValue[1] == 11)
                {
                    GBSeedLift.Visible = true;
                    BtnAuto.Visible = true;
                    BtnFixed.Visible = true;
                }
                else
                {
                    GBSeedLift.Visible = false;
                    BtnAuto.Visible = false;
                    BtnFixed.Visible = false;
                }
                //if ((Mode.Current == Mode.Crown && PLC.ReadStatus[1] == 1) || (Mode.Current == Mode.Body && PLC.ReadStatus[1] == 1))
                //{
                //    //GBDiaCalib.Visible = true;
                //    //LabDiaCalibVal.Visible = true;
                //    //BtnCalib.Visible = true;
                //    Label7.Visible = true;
                //}
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
            LabGainVal.Text = Math.Round(PLC.ReadValue[8], 4).ToString("f4");
            LabIntegVal.Text = Math.Round(PLC.ReadValue[9], 4).ToString("f4");
            LabDifferVal.Text = Math.Round(PLC.ReadValue[10], 4).ToString("f4");
        }
        private void BtnLimit_Click(object sender, EventArgs e)
        {
            BtnTune.BackColor = Color.Blue;
            BtnLimit.BackColor = Color.Fuchsia;
            LabGainTxt.Visible = false;
            LabGainVal.Visible = false;
            LabDifferTxt.Text = "下限";
            LabIntegTxt.Text = "上限";
            LabIntegVal.Text = Math.Round(PLC.ReadValue[4], 1).ToString("f1");
            LabDifferVal.Text = Math.Round(PLC.ReadValue[5], 1).ToString("f1");
        }
        private void LabSP_Click(object sender, EventArgs e)
        {
            if (LabSP.BackColor == Color.White)
            {
                KeyForm kf = new KeyForm();
                kf.ImportData(ref LabSP, 0, 1000);
                kf.ShowDialog();
                if (kf.DialogResult == DialogResult.OK)
                {
                    PLC.SendFloat(33, 20, Convert.ToSingle(LabSP.Text));
                }
            }
        }
        private void LabOut_Click(object sender, EventArgs e)
        {
            //if (LabOut.BackColor == Color.White)
            //{
            KeyForm kf = new KeyForm();
            kf.ImportData(ref LabOut, 0, 580);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                PLC.SendFloat(33, 4, Convert.ToSingle(LabOut.Text));
                //if (PLC.ReadStatus[13] == 1)
                //{
                Record.WriteIn("晶升速度设定", LabOut.Text, "Yellow");
                //}
            }
            //}
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
                    PLC.SendFloat(33, 28, Convert.ToSingle(LabGainVal.Text));
                    Record.WriteIn("直径控制增益", LabGainVal.Text, "Yellow");
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
                    kf.ImportData(ref LabDifferVal, 0, 508);
                }
                kf.ShowDialog();
                if (kf.DialogResult == DialogResult.OK)
                {
                    if (BtnTune.BackColor == Color.Fuchsia)
                    {
                        PLC.SendFloat(33, 36, Convert.ToSingle(LabDifferVal.Text));
                        Record.WriteIn("直径控制微分", LabDifferVal.Text, "Yellow");
                    }
                    if (BtnLimit.BackColor == Color.Fuchsia)
                    {
                        PLC.SendFloat(33, 16, Convert.ToSingle(LabDifferVal.Text));
                        Record.WriteIn("直径控制下限", LabDifferVal.Text, "Yellow");
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
                    kf.ImportData(ref LabIntegVal, 0, 508);
                }
                kf.ShowDialog();
                if (kf.DialogResult == DialogResult.OK)
                {
                    if (BtnTune.BackColor == Color.Fuchsia)
                    {
                        PLC.SendFloat(33, 32, Convert.ToSingle(LabIntegVal.Text));
                        Record.WriteIn("直径控制积分", LabIntegVal.Text, "Yellow");
                    }
                    if (BtnLimit.BackColor == Color.Fuchsia)
                    {
                        PLC.SendFloat(33, 12, Convert.ToSingle(LabIntegVal.Text));
                        Record.WriteIn("直径控制上限", LabIntegVal.Text, "Yellow");
                    }
                }
            }
        }
        private void BtnON_Click(object sender, EventArgs e)
        {
            if (PLC.ReadStatus[2] == 0 && License.IsSystemCanRun())
            {
                PLC.SendBit(30, 1, 1);
                Record.WriteIn("直径控制", "ON", "Yellow");
                BtnON.BackColor = Color.Red;
                BtnOFF.BackColor = Color.Blue;
                //LabOut.BackColor = Color.Gray;
                if (PLC.ReadStatus[1] == 0)
                {
                    LabSP.BackColor = Color.White;
                }
            }
        }
        private void BtnOFF_Click(object sender, EventArgs e)
        {
            if (PLC.ReadStatus[2] == 1)
            {
                PLC.SendBit(30, 2, 1);
                Record.WriteIn("直径控制", "OFF", "Yellow");
                BtnON.BackColor = Color.Blue;
                BtnOFF.BackColor = Color.Red;
                //LabOut.BackColor = Color.White;
                LabSP.BackColor = Color.Gray;
            }
        }
        private void BtnAuto_Click(object sender, EventArgs e)
        {
            PLC.SendBit(30, 160, 1);
            BtnAuto.BackColor = Color.Red;
            BtnFixed.BackColor = Color.Blue;
        }
        private void BtnFixed_Click(object sender, EventArgs e)
        {
            PLC.SendBit(30, 161, 1);
            BtnAuto.BackColor = Color.Blue;
            BtnFixed.BackColor = Color.Red;
        }

        private void LabDiaCalibVal_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm();
            kf.ImportData(ref LabDiaCalibVal, 0, 500);
            kf.ShowDialog();
        }

        private void BtnCalib_Click(object sender, EventArgs e)
        {
            if (PLC.ReadOthersValue[1] > 0 && PLC.ReadStatus[1] == 1 && Mode.Current == Mode.Crown)
            {
                Calibrate.WriteValue(3, 1, LabDiaCalibVal.Text);
                Record.WriteIn("放肩直径校准", LabDiaCalibVal.Text, "Yellow");

            }
            else if (PLC.ReadOthersValue[1] > 0 && PLC.ReadStatus[1] == 1 && Mode.Current == Mode.Body)
            {
                Calibrate.WriteValue(4, 1, LabDiaCalibVal.Text);
                Record.WriteIn("等径直径校准", LabDiaCalibVal.Text, "Yellow");
            }
            else
            {
                MessageBox.Show("校准条件不具备!");
            }
        }
    }
}
