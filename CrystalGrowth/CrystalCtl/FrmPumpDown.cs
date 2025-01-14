using CrystalGrowth.Unities;
using System;
using System.Windows.Forms;

namespace CrystalGrowth.CrystalCtl
{
    internal partial class FrmPumpDown : Form
    {
        public FrmPumpDown()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            LabPCPress.Text = Math.Round(PLC.ReadAnalogValue[7], 1).ToString("f1");
            LabFTLowPress.Text = PLC.ReadAnalogValue[4] < 1000 ? Math.Round(PLC.ReadAnalogValue[4], 1).ToString("f1") : "---";
            LabFTPress.Text = PLC.ReadAnalogValue[5] < 100 ? Math.Round(PLC.ReadAnalogValue[5], 1).ToString("f1") : "---";
            int AutoStep = (int)PLC.ReadValue[73];
            if (AutoStep == 1)
            {
                LabAutoStep.Text = "等待1torr压力检测";
            }
            else if (AutoStep == 2)
            {
                LabAutoStep.Text = "抽空I";
            }
            else if (AutoStep > 2 && AutoStep < 100)
            {
                LabAutoStep.Text = string.Format("抽空II第{0}次", (AutoStep - 2).ToString());
            }
            else if (AutoStep == 100)
            {
                LabAutoStep.Text = "等待基本压力检测";
            }
            else if (AutoStep == 101)
            {
                LabAutoStep.Text = "基本压力保持";
            }
            else
            {
                LabAutoStep.Text = "----";
            }
            LabStepTime.Text = AutoStep > 0 ? Math.Round(PLC.ReadValue[74] / 60, 1).ToString("f1") : "---";
            LabStatTime.Text = FrmMain.StateTime;
            LabRunTime.Text = FrmMain.RunTime;
        }
    }
}
