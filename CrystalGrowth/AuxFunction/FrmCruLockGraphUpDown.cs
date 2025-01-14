using CrystalGrowth.Unities;
using System;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction
{
    public partial class FrmCruLockGraphUpDown : Form
    {
        LockPic lockp;
        public FrmCruLockGraphUpDown()
        {
            InitializeComponent();
            lockp = new LockPic();
            Load += Timer1_Tick;
        }
        private void FrmCruLockGraphUpDown_FormClosed(object sender, FormClosedEventArgs e)
        {
            lockp.Dispose();
            lockp = null;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            float cruTrvPV = PLC.ReadAnalogValue[36];
            float cruUpLim = PLC.ReadCalibValue[20];
            float cruDownLim = PLC.ReadCalibValue[21];
            //上升
            LabCrucible001.Image = PLC.ReadStatusIn[1] == 1 ? lockp.Off : lockp.On;
            LabCrucible002.Image = cruTrvPV > cruUpLim ? lockp.Off : lockp.On;
            LabCrucible003.Image = PLC.StatusAlarm[380] == 1 ? lockp.Off : lockp.On;
            LabCrucible004.Image = PLC.StatusAlarm[293] == 1 ? lockp.Off : lockp.On;
            LabCrucible005.Image = PLC.StatusAlarm[295] == 1 ? lockp.Off : lockp.On;
            LabCrucible006.Image = PLC.ReadStatus[77] == 1 || PLC.ReadStatus[78] == 1 ? lockp.Off : lockp.On;
            LabCrucible007.Image = PLC.ReadStatusIn[57] == 1 || PLC.ReadStatusIn[58] == 1 ? lockp.Off : lockp.On;
            //下降
            LabCrucible101.Image = PLC.ReadStatusIn[2] == 1 ? lockp.Off : lockp.On;
            LabCrucible102.Image = cruTrvPV < cruDownLim ? lockp.Off : lockp.On;
        }
    }
}
