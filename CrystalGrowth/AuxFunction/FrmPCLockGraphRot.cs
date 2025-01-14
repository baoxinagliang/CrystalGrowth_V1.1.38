using CrystalGrowth.Unities;
using System;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction
{
    internal partial class FrmPCLockGraphRot : Form
    {
        LockPic lockp;
        public FrmPCLockGraphRot()
        {
            InitializeComponent();
            lockp = new LockPic();
            Load += Timer1_Tick;
        }
        private void FrmPCLockGraphRot_FormClosed(object sender, FormClosedEventArgs e)
        {
            lockp.Dispose();
            lockp = null;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            //左旋        
            LabPC001.Image = PLC.ReadStatusIn[13] == 0 ? lockp.Off : lockp.On;
            LabPC002.Image = PLC.ReadStatusIn[34] == 0 ? lockp.Off : lockp.On;
            LabPC003.Image = PLC.ReadStatusIn[39] == 0 ? lockp.Off : lockp.On;
            LabPC004.Image = PLC.ReadStatusIn[40] == 0 ? lockp.Off : lockp.On;
            LabPC005.Image = PLC.ReadStatusIn[57] == 0 ? lockp.Off : lockp.On;
            LabPC006.Image = PLC.ReadStatusIn[33] == 1 ? lockp.Off : lockp.On;
            LabPC007.Image = PLC.ReadStatusIn[93] == 0 ? lockp.Off : lockp.On;
            //LabPC008.Image = PLCConn.ReadStatusOut[47] == 0 ? lockp.Off : lockp.On;
            LabPC009.Image = PLC.ReadStatusIn[13] == 1 ? lockp.Off : lockp.On;
            LabPC010.Image = PLC.ReadStatus[88] == 0 ? lockp.Off : lockp.On;
            LabPC011.Image = PLC.ReadStatusIn[40] == 0 ? lockp.Off : lockp.On;
            LabPC012.Image = PLC.ReadStatus[89] == 0 ? lockp.Off : lockp.On;
            LabPC013.Image = PLC.ReadStatusIn[40] == 0 ? lockp.Off : lockp.On;
            LabPC014.Image = PLC.ReadStatusIn[93] == 0 ? lockp.Off : lockp.On;
            //热屏上软限位
            LabPC015.Image = PLC.ReadAnalogValue[37] > PLC.ReadCalibValue[25] ? lockp.On : lockp.Off;
            //右旋
            LabPC101.Image = PLC.ReadStatusIn[13] == 0 ? lockp.Off : lockp.On;
            LabPC102.Image = PLC.ReadStatusIn[34] == 0 ? lockp.Off : lockp.On;
            LabPC103.Image = PLC.ReadStatusIn[39] == 0 ? lockp.Off : lockp.On;
            LabPC104.Image = PLC.ReadStatusIn[40] == 0 ? lockp.Off : lockp.On;
            LabPC105.Image = PLC.ReadStatusIn[58] == 0 ? lockp.Off : lockp.On;
            LabPC106.Image = PLC.ReadStatusIn[19] == 1 ? lockp.Off : lockp.On;
            LabPC107.Image = PLC.ReadStatusIn[56] == 0 ? lockp.Off : lockp.On;
            LabPC108.Image = PLC.ReadStatusIn[93] == 0 ? lockp.Off : lockp.On;
            //LabPC109.Image = PLCConn.ReadStatusOut[48] == 0 ? lockp.Off : lockp.On;
            LabPC110.Image = PLC.ReadStatusIn[13] == 1 ? lockp.Off : lockp.On;
            LabPC111.Image = PLC.ReadStatus[88] == 0 ? lockp.Off : lockp.On;
            LabPC112.Image = PLC.ReadStatusIn[40] == 0 ? lockp.Off : lockp.On;
            LabPC113.Image = PLC.ReadStatus[89] == 0 ? lockp.Off : lockp.On;
            LabPC114.Image = PLC.ReadStatusIn[40] == 0 ? lockp.Off : lockp.On;
            LabPC115.Image = PLC.ReadStatusIn[93] == 0 ? lockp.Off : lockp.On;
            LabPC116.Image = PLC.ReadAnalogValue[37] > PLC.ReadCalibValue[25] ? lockp.On : lockp.Off;
        }
    }
}
