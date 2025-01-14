using CrystalGrowth.Unities;
using System;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction
{
    internal partial class FrmShieldLockGraphUpDown : Form
    {
        LockPic lockp;
        public FrmShieldLockGraphUpDown()
        {
            InitializeComponent();
            lockp = new LockPic();
            Load += Timer1_Tick;
        }
        private void FrmShieldLockGraphUpDown_FormClosed(object sender, FormClosedEventArgs e)
        {
            lockp.Dispose();
            lockp = null;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            float shldTrvPV = PLC.ReadAnalogValue[37];
            float shldUpLimit = PLC.ReadCalibValue[25];
            float shldDownLimit = PLC.ReadCalibValue[26];
            float cruTrvPV = PLC.ReadAnalogValue[36];
            float cruDownLim = PLC.ReadCalibValue[21];
            //上升
            LabShield001.Image = PLC.ReadStatusIn[31] == 1 ? lockp.Off : lockp.On;
            LabShield002.Image = shldTrvPV > shldUpLimit ? lockp.Off : lockp.On;
            //下降
            LabShield101.Image = PLC.ReadStatusIn[32] == 1 ? lockp.Off : lockp.On;
            LabShield102.Image = shldTrvPV < shldDownLimit ? lockp.Off : lockp.On;
            LabShield103.Image = PLC.StatusAlarm[380] == 1 ? lockp.Off : lockp.On;
            LabShield104.Image = cruTrvPV > cruDownLim ? lockp.Off : lockp.On;
        }
    }
}
