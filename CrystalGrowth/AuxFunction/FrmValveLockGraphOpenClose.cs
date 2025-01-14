using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction
{
    internal partial class FrmValveLockGraphOpenClose : Form
    {
        public FrmValveLockGraphOpenClose()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            //隔离阀开
            LabValve001.BackColor = PLC.ReadAnalogValue[35] > PLC.InitSetValue[18] ? Color.Green : Color.Red;
            LabValve002.BackColor = PLC.ReadStatusIn[42] == 1 ? Color.Red : Color.Green;
            //隔离阀关
            LabValve101.BackColor = PLC.ReadAnalogValue[35] > PLC.InitSetValue[18] ? Color.Green : Color.Red;
            LabValve102.BackColor = PLC.ReadStatusIn[42] == 1 ? Color.Red : Color.Green;
        }
    }
}
