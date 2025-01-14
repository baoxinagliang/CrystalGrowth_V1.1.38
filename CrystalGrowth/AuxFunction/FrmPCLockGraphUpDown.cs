using CrystalGrowth.Unities;
using System;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction
{
    internal partial class FrmPCLockGraphUpDown : Form
    {
        LockPic lockp;
        public FrmPCLockGraphUpDown()
        {
            InitializeComponent();
            lockp = new LockPic();
            Load += Timer1_Tick;
        }
        private void FrmPCLockGraphUpDown_FormClosed(object sender, FormClosedEventArgs e)
        {
            lockp.Dispose();
            lockp = null;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            //上升
            LabPC201.Image = PLC.ReadStatusIn[13] == 1 ? lockp.Off : lockp.On;
            LabPC202.Image = PLC.ReadStatus[89] == 0 ? lockp.Off : lockp.On;
            LabPC203.Image = PLC.ReadStatusIn[19] == 0 ? lockp.Off : lockp.On;
            LabPC204.Image = PLC.ReadStatusIn[77] == 0 ? lockp.Off : lockp.On;
            LabPC205.Image = PLC.ReadStatusIn[45] == 0 ? lockp.Off : lockp.On;
            LabPC206.Image = PLC.ReadAnalogValue[7] <= 500 ? lockp.Off : lockp.On;
            LabPC207.Image = PLC.ReadStatusIn[49] == 0 ? lockp.Off : lockp.On;
            LabPC208.Image = PLC.ReadStatusIn[40] == 1 ? lockp.Off : lockp.On;
            LabPC209.Image = PLC.ReadStatusIn[77] == 1 ? lockp.Off : lockp.On;
            LabPC210.Image = PLC.ReadStatusOut[5] == 0 ? lockp.Off : lockp.On;
            LabPC211.Image = PLC.ReadStatusIn[19] == 1 ? lockp.Off : lockp.On;
            LabPC212.Image = PLC.ReadStatus[88] == 0 ? lockp.Off : lockp.On;
            LabPC213.Image = PLC.ReadStatusIn[36] == 0 ? lockp.Off : lockp.On;
            LabPC214.Image = PLC.ReadStatusIn[33] == 0 ? lockp.Off : lockp.On;
            LabPC215.Image = PLC.ReadStatusIn[19] == 1 ? lockp.Off : lockp.On;
            LabPC216.Image = PLC.ReadStatusIn[13] == 0 ? lockp.Off : lockp.On;
            LabPC217.Image = PLC.ReadStatusIn[34] == 0 ? lockp.Off : lockp.On;
            LabPC218.Image = PLC.ReadStatus[89] == 0 ? lockp.Off : lockp.On;
            LabPC219.Image = PLC.ReadStatusIn[19] == 0 ? lockp.Off : lockp.On;
            LabPC220.Image = PLC.ReadStatusIn[77] == 0 ? lockp.Off : lockp.On;
            LabPC221.Image = PLC.ReadStatusIn[45] == 0 ? lockp.Off : lockp.On;
            LabPC222.Image = PLC.ReadAnalogValue[7] <= 500 ? lockp.Off : lockp.On;
            LabPC223.Image = PLC.ReadStatusIn[77] == 1 ? lockp.Off : lockp.On;
            LabPC224.Image = PLC.ReadStatusIn[19] == 1 ? lockp.Off : lockp.On;
            //下降
            LabPC301.Image = PLC.ReadStatusIn[33] == 0 ? lockp.Off : lockp.On;
            LabPC302.Image = PLC.ReadStatusIn[19] == 1 ? lockp.Off : lockp.On;
            LabPC303.Image = PLC.ReadStatusIn[19] == 0 ? lockp.Off : lockp.On;
            LabPC304.Image = PLC.ReadStatusIn[45] == 0 ? lockp.Off : lockp.On;
            LabPC305.Image = PLC.ReadStatusIn[46] == 1 ? lockp.Off : lockp.On;
            LabPC306.Image = PLC.ReadStatusIn[50] == 0 ? lockp.Off : lockp.On;
            LabPC307.Image = PLC.ReadStatusIn[77] == 1 ? lockp.Off : lockp.On;
            LabPC308.Image = PLC.ReadStatusIn[33] == 1 ? lockp.Off : lockp.On;
            LabPC309.Image = PLC.ReadStatus[88] == 0 ? lockp.Off : lockp.On;
            LabPC310.Image = PLC.ReadStatusIn[59] == 1 ? lockp.Off : lockp.On;
            LabPC311.Image = PLC.ReadStatusIn[19] == 1 ? lockp.Off : lockp.On;
            LabPC312.Image = PLC.ReadStatusOut[6] == 0 ? lockp.Off : lockp.On;
            LabPC313.Image = PLC.ReadStatus[89] == 0 ? lockp.Off : lockp.On;
            LabPC314.Image = PLC.ReadAnalogValue[36] > PLC.ReadCalibValue[21] ? lockp.Off : lockp.On;
            LabPC315.Image = PLC.ReadAnalogValue[37] > PLC.ReadCalibValue[25] ? lockp.On : lockp.Off;
            LabPC316.Image = PLC.ReadStatusIn[19] == 0 ? lockp.Off : lockp.On;
        }
    }
}