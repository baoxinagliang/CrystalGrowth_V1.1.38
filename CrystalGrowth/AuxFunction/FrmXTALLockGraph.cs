using CrystalGrowth.Unities;
using System;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction
{
    internal partial class FrmXTALLockGraph : Form
    {
        LockPic lockp;
        public FrmXTALLockGraph()
        {
            InitializeComponent();
            lockp = new LockPic();
            Load += Timer1_Tick;
        }
        private void FrmXTALLockGraph_FormClosed(object sender, FormClosedEventArgs e)
        {
            lockp.Dispose();
            lockp = null;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            LabXTAL101.Image = PLC.ReadStatusIn[40] == 0 ? lockp.Off : lockp.On;
            LabXTAL102.Image = PLC.ReadStatusIn[39] == 0 ? lockp.Off : lockp.On;
        }
    }
}
