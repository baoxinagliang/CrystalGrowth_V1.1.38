using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.CrystalCtl
{
    internal partial class FrmCrown : Form
    {
        public FrmCrown()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            LabRealDia.Text = Math.Round(PLC.ReadValue[7], 2).ToString("f2");
            LabDegree.Text = Math.Round(PLC.ReadCalcValue[21], 1).ToString("f1");
            LabGrowSpeed.Text = Math.Round(PLC.ReadValue[16], 1).ToString("f1");
            LabFTPress.Text = PLC.ReadAnalogValue[5] < 100 ? Math.Round(PLC.ReadAnalogValue[5], 1).ToString("f1") : "---";
            LabMainPower.Text = Math.Round(PLC.PowerValue[3], 2).ToString("f2");
            LabDiaRate.Text = Math.Round(PLC.ReadValue[93], 1).ToString("f1");
            LabTargetDia.Text = Math.Round(PLC.ReadValue[94], 1).ToString("f1");
            LabCrownAVGSpeed.Text = Math.Round(PLC.ReadCalcValue[33], 1).ToString("f1");
            LabStatTime.Text = FrmMain.StateTime;
            LabRunTime.Text = FrmMain.RunTime;         
        }
        private void FrmCrown_DoubleClick(object sender, EventArgs e)
        {
            FrmSwitch.LastForm.Close();
            FrmCrownTrack fct = new FrmCrownTrack(false);
            FrmSwitch.Open(fct, 30, new Point(0, 200), new Size(520, 494));
            fct.Show();
            FrmSwitch.LastForm = fct;
        }
    }
}
