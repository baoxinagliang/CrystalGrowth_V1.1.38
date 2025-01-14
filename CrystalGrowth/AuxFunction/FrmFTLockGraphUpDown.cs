using CrystalGrowth.Unities;
using System;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction
{
    internal partial class FrmFTLockGraphUpDown : Form
    {
        LockPic lockp;
        public FrmFTLockGraphUpDown()
        {
            InitializeComponent();
            lockp = new LockPic();
            Load += Timer1_Tick;
        }
        private void FrmFTLockGraphUpDown_FormClosed(object sender, FormClosedEventArgs e)
        {
            lockp.Dispose();
            lockp = null;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            //上升
            //LabFT201.Image = PLC.ReadStatusIn[13] == 1 ? lockp.Off : lockp.On;
            //LabFT202.Image = PLC.ReadStatusIn[59] == 1 ? lockp.Off : lockp.On;
            LabFT202.Image = PLC.ReadStatusIn[13] == 1 ? lockp.Off : lockp.On;
            LabFT203.Image = PLC.ReadStatusIn[55] == 0 ? lockp.Off : lockp.On;
            LabFT204.Image = PLC.ReadStatusIn[33] == 0 ? lockp.Off : lockp.On;
            LabFT205.Image = PLC.ReadStatusIn[35] == 1 ? lockp.Off : lockp.On;
            LabFT206.Image = PLC.ReadStatusIn[53] == 0 ? lockp.Off : lockp.On;
            LabFT207.Image = PLC.ReadStatusIn[56] == 0 ? lockp.Off : lockp.On;
            //LabFT208.Image = PLCConn.ReadStatusOut[7] == 0 ? lockp.Off : lockp.On;
            LabFT209.Image = PLC.ReadStatusIn[87] == 0 ? lockp.Off : lockp.On;
            LabFT211.Image = PLC.ReadStatusIn[89] == 0 ? lockp.Off : lockp.On;
            LabFT213.Image = PLC.ReadStatusIn[88] == 0 ? lockp.Off : lockp.On;

            LabFT210.Image = PLC.ReadStatusIn[84] == 0 ? lockp.Off : lockp.On;
            LabFT212.Image = PLC.ReadStatusIn[86] == 0 ? lockp.Off : lockp.On;
            LabFT214.Image = PLC.ReadStatusIn[85] == 0 ? lockp.Off : lockp.On;
            //下降
            //LabFT301.Image = PLC.ReadStatusIn[13] == 1 ? lockp.Off : lockp.On;
            //LabFT302.Image = PLC.ReadStatusIn[59] == 1 ? lockp.Off : lockp.On;
            LabFT302.Image = PLC.ReadStatusIn[13] == 1 ? lockp.Off : lockp.On;
            LabFT303.Image = PLC.ReadStatusIn[55] == 0 ? lockp.Off : lockp.On;
            LabFT304.Image = PLC.ReadStatusIn[33] == 0 ? lockp.Off : lockp.On;
            LabFT305.Image = PLC.ReadStatusIn[76] == 1 ? lockp.Off : lockp.On;
            LabFT306.Image = PLC.ReadStatusIn[54] == 0 ? lockp.Off : lockp.On;
            LabFT307.Image = PLC.ReadStatusIn[56] == 0 ? lockp.Off : lockp.On;
            //LabFT308.Image = PLCConn.ReadStatusOut[8] == 0 ? lockp.Off : lockp.On;
            LabFT309.Image = PLC.ReadStatusIn[87] == 0 ? lockp.Off : lockp.On;
            LabFT311.Image = PLC.ReadStatusIn[89] == 0 ? lockp.Off : lockp.On;
            LabFT313.Image = PLC.ReadStatusIn[88] == 0 ? lockp.Off : lockp.On;
            LabFT310.Image = PLC.ReadStatusIn[84] == 0 ? lockp.Off : lockp.On;
            LabFT312.Image = PLC.ReadStatusIn[86] == 0 ? lockp.Off : lockp.On;
            LabFT314.Image = PLC.ReadStatusIn[85] == 0 ? lockp.Off : lockp.On;
        }
    }
}
