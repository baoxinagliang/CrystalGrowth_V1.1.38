﻿using CrystalGrowth.Unities;
using System;
using System.Windows.Forms;

namespace CrystalGrowth.CrystalCtl
{
    internal partial class FrmPressurization : Form
    {
        public FrmPressurization()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            LabPCPress.Text = Math.Round(PLC.ReadAnalogValue[7], 1).ToString("f1");
            LabFTPress.Text = PLC.ReadAnalogValue[5] < 100 ? Math.Round(PLC.ReadAnalogValue[5], 1).ToString("f1") : "---";
            LabGasFlow.Text = Math.Round(PLC.ReadAnalogValue[1], 1).ToString("f1");
            LabStatTime.Text = FrmMain.StateTime;
            LabRunTime.Text = FrmMain.RunTime;
        }
    }
}
