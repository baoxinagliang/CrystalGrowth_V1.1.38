using CrystalGrowth.Unities;
using System;
using System.Windows.Forms;

namespace CrystalGrowth.CrystalCtl
{
    internal partial class FrmShutDown : Form
    {
        public FrmShutDown()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            LabMainPower.Text = Math.Round(PLC.PowerValue[3], 2).ToString("f2");
            LabSeedPos.Text = Math.Round(PLC.ReadAnalogValue[35], 1).ToString("f1");
            LabFTLowPress.Text = PLC.ReadAnalogValue[4] < 1000 ? Math.Round(PLC.ReadAnalogValue[4], 1).ToString("f1") : "---";
            LabFTPress.Text = PLC.ReadAnalogValue[5] < 100 ? Math.Round(PLC.ReadAnalogValue[5], 1).ToString("f1") : "---";
            LabStatTime.Text = FrmMain.StateTime;
            LabRunTime.Text = FrmMain.RunTime;
        }
    }
}
