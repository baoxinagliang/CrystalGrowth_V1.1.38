using CrystalGrowth.Unities;
using System;
using System.Windows.Forms;

namespace CrystalGrowth.CrystalCtl
{
    internal partial class FrmBody : Form
    {
        public FrmBody()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            LabRealDia.Text = Math.Round(PLC.ReadValue[7], 2).ToString("f2");
            LabLength.Text = Math.Round(PLC.ReadCalcValue[14], 1).ToString("f1");
            LabGrowSpeed.Text = Math.Round(PLC.ReadValue[16], 1).ToString("f1");
            LabFTPress.Text = PLC.ReadAnalogValue[5] < 100 ? Math.Round(PLC.ReadAnalogValue[5], 1).ToString("f1") : "---";
            LabMainPower.Text = Math.Round(PLC.PowerValue[3], 2).ToString("f2");
            LabAvgSpeed.Text = Math.Round(PLC.ReadCalcValue[23], 1).ToString("f1");//平均拉速
            LabStatTime.Text = FrmMain.StateTime;
            LabRunTime.Text = FrmMain.RunTime;
        }
    }
}
