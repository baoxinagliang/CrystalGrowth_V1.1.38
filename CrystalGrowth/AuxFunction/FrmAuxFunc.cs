using CrystalGrowth.AuxFunction.Calibration;
using CrystalGrowth.AuxFunction.CCD;
using CrystalGrowth.AuxFunction.License;
using CrystalGrowth.AuxFunction.MainTain;
using CrystalGrowth.CrystalCtl;
using CrystalGrowth.GasVacuum;
using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction
{
    internal partial class FrmAuxFunc : Form
    {
        public FrmAuxFunc()
        {
            InitializeComponent();
        }
        private void BtnCalib_Click(object sender, EventArgs e)
        {
            FrmSwitch.LastForm.Close();
            FrmCalib fcb = new FrmCalib();
            FrmSwitch.Open(fcb, 130, new Point(0, 130), new Size(1366, 638));
            fcb.Show();
            FrmSwitch.LastForm = fcb;
        }
        private void BtnManager_Click(object sender, EventArgs e)
        {
            FrmSwitch.LastForm.Close();
            FrmManager fmr = new FrmManager();
            FrmSwitch.Open(fmr, 111, new Point(0, 130), new Size(1366, 638));
            fmr.Show();
            FrmSwitch.LastForm = fmr;
        }
        private void BtnManualNeck_Click(object sender, EventArgs e)
        {
            FrmSwitch.LastForm.Close();
            FrmLogin fln = new FrmLogin();
            FrmSwitch.Open(fln, 112, new Point(0, 130), new Size(1366, 638));
            fln.Show();
            FrmSwitch.LastForm = fln;
        }
        private void BtnCalculator_Click(object sender, EventArgs e)
        {
            FrmSwitch.LastForm.Close();
            FrmCalculator fcr = new FrmCalculator();
            FrmSwitch.Open(fcr, 113, new Point(0, 130), new Size(1366, 638));
            fcr.Show();
            FrmSwitch.LastForm = fcr;
        }
        private void BtnCrysCalc_Click(object sender, EventArgs e)
        {
            FrmSwitch.LastForm.Close();
            FrmCrystalCalc fcc = new FrmCrystalCalc();
            FrmSwitch.Open(fcc, 114, new Point(0, 130), new Size(1366, 638));
            fcc.Show();
            FrmSwitch.LastForm = fcc;
        }
        private void BtnCamera_Click(object sender, EventArgs e)
        {
            FrmSwitch.LastForm.Close();
            FrmCCD fccd = new FrmCCD();
            FrmSwitch.Open(fccd, 150, new Point(0, 50), new Size(1366, 718));
            fccd.Show();
            FrmSwitch.LastForm = fccd;
        }
        private void BtnMaintain_Click(object sender, EventArgs e)
        {
            FrmSwitch.LastForm.Close();
            FrmMaintain fmt = new FrmMaintain();
            FrmSwitch.Open(fmt, 140, new Point(0, 130), new Size(1366, 638));
            fmt.Show();
            FrmSwitch.LastForm = fmt;
        }
        private void BtnCtlSel_Click(object sender, EventArgs e)
        {
            FrmSwitch.LastForm.Close();
            FrmCtlSel fcs = new FrmCtlSel();
            FrmSwitch.Open(fcs, 120, new Point(0, 130), new Size(1366, 638));
            fcs.Show();
            FrmSwitch.LastForm = fcs;
        }
        private void BtnTimer_Click(object sender, EventArgs e)
        {
            FrmSwitch.LastForm.Close();
            FrmTimer ftr = new FrmTimer();
            FrmSwitch.Open(ftr, 121, new Point(0, 130), new Size(1366, 638));
            ftr.Show();
            FrmSwitch.LastForm = ftr;
        }
        private void BtnCrucCalc_Click(object sender, EventArgs e)
        {
            FrmSwitch.LastForm.Close();
            FrmCrucCalc fcc = new FrmCrucCalc();
            FrmSwitch.Open(fcc, 122, new Point(0, 130), new Size(1366, 638));
            fcc.Show();
            FrmSwitch.LastForm = fcc;
        }
        private void BtnLicense_Click(object sender, EventArgs e)
        {
            FrmSwitch.LastForm.Close();
            FrmLicense fle = new FrmLicense();
            FrmSwitch.Open(fle, 123, new Point(0, 130), new Size(1366, 638));
            fle.Show();
            FrmSwitch.LastForm = fle;
        }
        private void BtnThermalField_Click(object sender, EventArgs e)
        {
            FrmSwitch.LastForm.Close();
            FrmHotZone fhzm = new FrmHotZone();
            FrmSwitch.Open(fhzm, 111, new Point(0, 130), new Size(1366, 700));
            fhzm.Show();
            FrmSwitch.LastForm = fhzm;
        }
        private void FrmAuxFunc_Load(object sender, EventArgs e)
        {
            LabPLCVer.Text = GetPlcVersion();
        }
        private string GetPlcVersion()
        {
            string Version = "";
            if (PLC.IsConn)
            {
                char charTemp;
                int Lenght = PLC.ReadPLCVersion.Length;
                for (int i = 1; i < Lenght; i++)
                {
                    charTemp = Convert.ToChar(PLC.ReadPLCVersion[i]);
                    Version = string.Concat(Version, charTemp);
                }
            }
            return Version;
        }
        private void BtnVacummCalib_Click(object sender, EventArgs e)
        {
            BeginInvoke(new Action(() =>
            {
                FrmLevel frmLevel = new FrmLevel("SuperUser", "SuperUser");
                frmLevel.ShowDialog();
                if (frmLevel.DialogResult == DialogResult.OK)
                {
                    FrmSwitch.LastForm.Close();
                    FrmVacumm fvm = new FrmVacumm();
                    FrmSwitch.Open(fvm, 123, new Point(0, 130), new Size(1366, 638));
                    fvm.Show();
                    FrmSwitch.LastForm = fvm;
                }
            }));
         
        }
        private void BtnPCLockGraphUpDown_Click(object sender, EventArgs e)
        {
            FrmSwitch.LastForm.Close();
            FrmPCLockGraphUpDown fpgud = new FrmPCLockGraphUpDown();
            FrmSwitch.Open(fpgud, 124, new Point(0, 130), new Size(1366, 638));
            fpgud.Show();
            FrmSwitch.LastForm = fpgud;
        }
        private void BtnPCLockGraphRot_Click(object sender, EventArgs e)
        {
            FrmSwitch.LastForm.Close();
            FrmPCLockGraphRot fplgr = new FrmPCLockGraphRot();
            FrmSwitch.Open(fplgr, 125, new Point(0, 130), new Size(1366, 638));
            fplgr.Show();
            FrmSwitch.LastForm = fplgr;
        }
        private void BtnFTLockGraphUpDown_Click(object sender, EventArgs e)
        {
            FrmSwitch.LastForm.Close();
            FrmFTLockGraphUpDown ffgud = new FrmFTLockGraphUpDown();
            FrmSwitch.Open(ffgud, 126, new Point(0, 130), new Size(1366, 638));
            ffgud.Show();
            FrmSwitch.LastForm = ffgud;
        }
        private void BtnFTLockGraphRot_Click(object sender, EventArgs e)
        {
            FrmSwitch.LastForm.Close();
            FrmFTLockGraphRot ffgr = new FrmFTLockGraphRot();
            FrmSwitch.Open(ffgr, 127, new Point(0, 130), new Size(1366, 638));
            ffgr.Show();
            FrmSwitch.LastForm = ffgr;
        }
        private void BtnShieldLockGraphUpDown_Click(object sender, EventArgs e)
        {
            FrmSwitch.LastForm.Close();
            FrmShieldLockGraphUpDown fslgud = new FrmShieldLockGraphUpDown();
            FrmSwitch.Open(fslgud, 128, new Point(0, 130), new Size(1366, 638));
            fslgud.Show();
            FrmSwitch.LastForm = fslgud;
        }
        private void BtnCruLockGraphUpDown_Click(object sender, EventArgs e)
        {
            FrmSwitch.LastForm.Close();
            FrmCruLockGraphUpDown fclgud = new FrmCruLockGraphUpDown();
            FrmSwitch.Open(fclgud, 129, new Point(0, 130), new Size(1366, 638));
            fclgud.Show();
            FrmSwitch.LastForm = fclgud;
        }
        private void BtnValveLockGraphOpenClose_Click(object sender, EventArgs e)
        {
            FrmSwitch.LastForm.Close();
            FrmValveLockGraphOpenClose fvlgoc = new FrmValveLockGraphOpenClose();
            FrmSwitch.Open(fvlgoc, 130, new Point(0, 130), new Size(1366, 638));
            fvlgoc.Show();
            FrmSwitch.LastForm = fvlgoc;
        }
        private void BtnLockloopLockGragh_Click(object sender, EventArgs e)
        {
            FrmSwitch.LastForm.Close();
            FrmLockloopLockGraph fllg = new FrmLockloopLockGraph();
            FrmSwitch.Open(fllg, 131, new Point(0, 130), new Size(1366, 638));
            fllg.Show();
            FrmSwitch.LastForm = fllg;
        }
        private void BtnXTALLockGraph_Click(object sender, EventArgs e)
        {
            FrmSwitch.LastForm.Close();
            FrmXTALLockGraph fxlg = new FrmXTALLockGraph();
            FrmSwitch.Open(fxlg, 131, new Point(0, 130), new Size(1366, 638));
            fxlg.Show();
            FrmSwitch.LastForm = fxlg;
        }
        private void BtnHtrLockGraph_Click(object sender, EventArgs e)
        {
            FrmSwitch.LastForm.Close();
            FrmHtrLockGraph fhlg = new FrmHtrLockGraph();
            FrmSwitch.Open(fhlg, 131, new Point(0, 130), new Size(1366, 638));
            fhlg.Show();
            FrmSwitch.LastForm = fhlg;
        }
        private void BtnPcFtOper_Click(object sender, EventArgs e)
        {
            FrmSwitch.LastForm.Close();
            FrmFTPCAction ffpa = new FrmFTPCAction();
            FrmSwitch.Open(ffpa, 123, new Point(0, 130), new Size(1366, 638));
            ffpa.Show();
            FrmSwitch.LastForm = ffpa;
        }

        private void BtnDiaByWeight_Click(object sender, EventArgs e)
        {
            FrmSwitch.LastForm.Close();
            FrmDiaByWeight fdbw = new FrmDiaByWeight();
            FrmSwitch.Open(fdbw, 151, new Point(0, 130), new Size(1366, 768));
            fdbw.Show();
            FrmSwitch.LastForm = fdbw;
        }

        private void BtnMaintainLock_Click(object sender, EventArgs e)
        {
            FrmSwitch.LastForm.Close();
            FrmMaintainLock fmlk = new FrmMaintainLock();
            FrmSwitch.Open(fmlk, 151, new Point(0, 0), new Size(1366, 768));
            fmlk.Show();
            FrmSwitch.LastForm = fmlk;
        }

        private void BtnCrownG_Click(object sender, EventArgs e)
        {
            FrmSwitch.LastForm.Close();
            FrmCrownT fct1 = new FrmCrownT();
            FrmSwitch.Open(fct1, 140, new Point(0, 130), new Size(1366, 638));
            fct1.Show();
            FrmSwitch.LastForm = fct1;
        }
    }
}
