using CrystalGrowth.Unities;
using System;
using System.Windows.Forms;

namespace CrystalGrowth.CrystalCtl
{
    internal partial class FrmMelting : Form
    {
        public FrmMelting()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            LabMainPower.Text = Math.Round(PLC.PowerValue[3], 2).ToString("f2");
            LabBotPower.Text = Math.Round(PLC.PowerValue[7], 2).ToString("f2");
            LabCrucPos.Text = Math.Round(PLC.ReadValue[59], 1).ToString("f1");
            LabFTPress.Text = PLC.ReadAnalogValue[5] < 100 ? Math.Round(PLC.ReadAnalogValue[5], 1).ToString("f1") : "---";
            int AutoStep = (int)PLC.ReadValue[73];
            switch (AutoStep)
            {
                case 1:
                    LabAutoStep.Text = "功率线性上升";
                    break;
                case 2:
                    LabAutoStep.Text = "功率保持";
                    break;
                default:
                    LabAutoStep.Text = "----";
                    break;
            }
            LabStepTime.Text = AutoStep > 0 ? Math.Round(PLC.ReadValue[74], 0).ToString() : "---";
            LabStatTime.Text = FrmMain.StateTime;
            LabRunTime.Text = FrmMain.RunTime;
        }
    }
}
