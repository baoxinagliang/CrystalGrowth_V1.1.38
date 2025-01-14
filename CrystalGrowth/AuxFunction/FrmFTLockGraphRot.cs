using CrystalGrowth.Unities;
using System;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction
{
    internal partial class FrmFTLockGraphRot : Form
    {
        LockPic lockp;
        public FrmFTLockGraphRot()
        {
            InitializeComponent();
            lockp = new LockPic();
            Load += Timer1_Tick;
        }
        private void FrmFTLockGraphRot_FormClosed(object sender, FormClosedEventArgs e)
        {
            lockp.Dispose();
            lockp = null;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            //左旋LImage.InterlockOff : LImage.InterlockOn;
            LabFT001.Image = PLC.ReadStatusIn[13] == 0 ? lockp.On : lockp.Off;
            LabFT002.Image = PLC.ReadStatusIn[35] == 1 ? lockp.On : lockp.Off;
            LabFT003.Image = PLC.ReadStatusIn[55] == 0 ? lockp.On : lockp.Off;
            LabFT004.Image = PLC.ReadStatusIn[33] == 1 ? lockp.On : lockp.Off;
            LabFT005.Image = PLC.ReadStatusIn[51] == 1 ? lockp.On : lockp.Off;
            //LabFT006.Image = PLCConn.ReadStatusOut[49] == 1 ? lockp.On : lockp.Off;
            //右旋
            LabFT101.Image = PLC.ReadStatusIn[13] == 0 ? lockp.On : lockp.Off;
            LabFT102.Image = PLC.ReadStatusIn[35] == 1 ? lockp.On : lockp.Off;
            LabFT103.Image = PLC.ReadStatusIn[56] == 0 ? lockp.On : lockp.On;
            LabFT104.Image = PLC.ReadStatusIn[52] == 1 ? lockp.On : lockp.Off;
            // LabFT105.Image = PLCConn.ReadStatusOut[50] == 1 ? lockp.On : lockp.Off;
        }
    }
}
