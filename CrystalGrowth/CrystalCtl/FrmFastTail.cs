using CrystalGrowth.Unities;
using System;
using System.Windows.Forms;

namespace CrystalGrowth.CrystalCtl
{
    internal partial class FrmFastTail : Form
    {
        public FrmFastTail()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            LabRealDia.Text = Math.Round(PLC.ReadValue[7], 2).ToString("f2");
            LabDiaSP.Text = Math.Round(PLC.ReadValue[6], 2).ToString("f2");
            LabGrowSpeed.Text = Math.Round(PLC.ReadValue[16], 1).ToString("f1");
            LabFTPress.Text = PLC.ReadAnalogValue[5] < 100 ? Math.Round(PLC.ReadAnalogValue[5], 1).ToString("f1") : "---";
            LabMainPower.Text = Math.Round(PLC.PowerValue[3], 2).ToString("f2");
            LabHtrTemp.Text = Math.Round(PLC.ReadValue[12], 1).ToString("f1");
            LabStatTime.Text = FrmMain.StateTime;
            LabRunTime.Text = FrmMain.RunTime;
        }
    }
}
