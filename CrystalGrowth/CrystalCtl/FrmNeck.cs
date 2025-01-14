using CrystalGrowth.Unities;
using System;
using System.Windows.Forms;

namespace CrystalGrowth.CrystalCtl
{
    internal partial class FrmNeck : Form
    {
        public FrmNeck()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            LabRealDia.Text = Math.Round(PLC.ReadValue[7], 2).ToString("f2");
            LabDiaSP.Text = Math.Round(PLC.ReadValue[6], 2).ToString("f2");
            LabGrowSpeed.Text = Math.Round(PLC.ReadValue[16], 1).ToString("f1");
            LabMeltTemp.Text = Math.Round(PLC.ReadValue[32], 1).ToString("f1");
            LabMainPower.Text = Math.Round(PLC.PowerValue[3], 2).ToString("f2");
            LabCycLen.Text = Math.Round(PLC.ReadCalcValue[14], 1).ToString("f1");
            LabNeckTailSL.Text = Math.Round(PLC.ReadAnalogValue[45], 1).ToString("f1");
            LabNeckTotalSL.Text = Math.Round(PLC.ReadValue[107], 1).ToString("f1");
            LabStatTime.Text = FrmMain.StateTime;
            LabRunTime.Text = FrmMain.RunTime;
        }
    }
}
