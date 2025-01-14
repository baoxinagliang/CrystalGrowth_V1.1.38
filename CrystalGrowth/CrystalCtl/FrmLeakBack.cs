using CrystalGrowth.Unities;
using System;
using System.Windows.Forms;

namespace CrystalGrowth.CrystalCtl
{
    internal partial class FrmLeakBack : Form
    {
        public FrmLeakBack()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            LabFTLowPress.Text = PLC.ReadAnalogValue[4] < 1000 ? Math.Round(PLC.ReadAnalogValue[4], 1).ToString("f1") : "---";
            LabLeakRate.Text = PLC.ReadStatus[58] == 1 ? Math.Round(PLC.ReadCalcValue[17], 1).ToString("f1") : "---";
            LabStatTime.Text = FrmMain.StateTime;
            LabRunTime.Text = FrmMain.RunTime;
        }
    }
}
