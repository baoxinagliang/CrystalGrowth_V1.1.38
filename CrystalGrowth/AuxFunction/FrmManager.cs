using CrystalGrowth.CrystalCtl;
using CrystalGrowth.Unities;
using System;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction
{
    internal partial class FrmManager : Form
    {
        public FrmManager()
        {
            InitializeComponent();
        }
        private void BtnQuit_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnQuit))
            {

                DualCam.CloseCameras();
                Record.WriteIn("软件关闭", "", "Yellow");
                Environment.Exit(0);

            }
        }
        private void BtnMin_Click(object sender, EventArgs e)
        {
            FrmMain.Single.MinForm();
            FrmMain.Single.SendToBack();
        }
    }
}
