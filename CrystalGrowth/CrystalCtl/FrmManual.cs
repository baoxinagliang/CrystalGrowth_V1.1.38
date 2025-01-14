using CrystalGrowth.Unities;
using System;
using System.Windows.Forms;

namespace CrystalGrowth.CrystalCtl
{
    internal partial class FrmManual : Form
    {
        public FrmManual()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            LabMainPower.Text = Math.Round(PLC.PowerValue[3], 2).ToString("f2");
            LabHtrTemp.Text = Math.Round(PLC.ReadValue[12], 1).ToString("f1");
            LabSeedSpeed.Text = Math.Round(PLC.ReadValue[49], 1).ToString("f1");
            LabFTPress.Text = PLC.ReadAnalogValue[5] < 100 ? Math.Round(PLC.ReadAnalogValue[5], 1).ToString("f1") : "---";
            LabStatTime.Text = FrmMain.StateTime;
            LabRunTime.Text = FrmMain.RunTime;
        }
    }
}
