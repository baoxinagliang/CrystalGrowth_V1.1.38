using CrystalGrowth.Unities;
using System;
using System.Windows.Forms;

namespace CrystalGrowth.CrystalCtl
{
    internal partial class FrmStabilizationDip : Form
    {
        public FrmStabilizationDip()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            LabSeedPos.Text = Math.Round(PLC.ReadAnalogValue[35], 1).ToString("f1");
            LabMeltGap.Text = Math.Round(PLC.ReadValue[41], 1).ToString("f1");
            LabMeltTemp.Text = Math.Round(PLC.ReadValue[32], 1).ToString("f1");
            LabMainPower.Text = Math.Round(PLC.PowerValue[3], 2).ToString("f2");
            LabRealDia.Text = Math.Round(PLC.ReadValue[7], 2).ToString("f2");
            LabFTPress.Text = PLC.ReadAnalogValue[5] < 100 ? Math.Round(PLC.ReadAnalogValue[5], 1).ToString("f1") : "---";
            LabStatTime.Text = FrmMain.StateTime;
            LabRunTime.Text = FrmMain.RunTime;
        }
    }
}
