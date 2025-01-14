using CrystalGrowth.Unities;
using System;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction
{
    internal partial class FrmLockloopLockGraph : Form
    {
        LockPic lockp;
        public FrmLockloopLockGraph()
        {
            InitializeComponent();
            lockp = new LockPic();
            Load += Timer1_Tick;
        }
        private void FrmLockloopLockGraph_FormClosed(object sender, FormClosedEventArgs e)
        {
            lockp.Dispose();
            lockp = null;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            //升
            LabLL001.Image = PLC.ReadStatusIn[59] == 0 ? lockp.Off : lockp.On;
            LabLL002.Image = PLC.ReadStatusIn[77] == 0 ? lockp.Off : lockp.On;
            LabLL003.Image = PLC.ReadStatusIn[19] == 0 ? lockp.Off : lockp.On;
            //降
            LabLL101.Image = PLC.ReadStatusIn[59] == 0 ? lockp.Off : lockp.On;
            LabLL102.Image = PLC.ReadStatusIn[77] == 0 ? lockp.Off : lockp.On;
            LabLL103.Image = PLC.ReadStatusIn[19] == 0 ? lockp.Off : lockp.On;
        }
    }
}
