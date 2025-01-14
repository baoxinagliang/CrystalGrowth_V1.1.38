using CrystalGrowth.Unities;
using System;
using System.Windows.Forms;

namespace CrystalGrowth.CrystalCtl
{
    internal partial class FrmBakeout : Form
    {
        public FrmBakeout()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            LabMainPower.Text = Math.Round(PLC.PowerValue[3], 2).ToString("f2");
            LabCrucPos.Text = Math.Round(PLC.ReadValue[59], 1).ToString("f1");
            LabFTPress.Text = PLC.ReadAnalogValue[5] < 100 ? Math.Round(PLC.ReadAnalogValue[5], 1).ToString("f1") : "---";
            switch ((int)PLC.ReadValue[73])
            {
                case 1:
                    LabAutoStep.Text = "功率线性上升";
                    break;
                case 2:
                    LabAutoStep.Text = "功率保持";
                    break;
                case 3:
                    LabAutoStep.Text = "功率线性下降";
                    break;
                default:
                    LabAutoStep.Text = "----";
                    break;
            }
            LabStepTime.Text = PLC.ReadValue[73] > 0 ? Math.Round(PLC.ReadValue[74], 0).ToString() : "---";
            LabStatTime.Text = FrmMain.StateTime;
            LabRunTime.Text = FrmMain.RunTime;
        }
    }
}
