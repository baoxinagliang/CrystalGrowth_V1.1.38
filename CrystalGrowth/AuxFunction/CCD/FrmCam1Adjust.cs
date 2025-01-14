using CrystalGrowth.CrystalCtl;
using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction.CCD
{
    internal partial class FrmCam1Adjust : Form
    {
        private bool CenterXAdd = false;
        private bool CenterXSub = false;
        private bool CenterYAdd = false;
        private bool CenterYSub = false;
         Form lastForm;
        FrmCam1SavePic frmCam1SavePic;
        public FrmCam1Adjust()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnSave))
            {
                ParasCam1.WriteIn();
                DualCam.SetExpoTime1(DualCam.SelectCam, ParasCam1.ExpoTime);
                Record.WriteIn("CCD相机1中心点X", LabCenterX.Text, "Yellow");
                Record.WriteIn("CCD相机1中心点Y", LabCenterY.Text, "Yellow");
                Record.WriteIn("CCD相机1曝光时间", LabExposure.Text, "Yellow");
                MessageBox.Show("保存成功！");
            }
        }
        private void LabCenterX_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm
            {
                Location = new Point(400, 130)
            };
            kf.ImportData(ref LabCenterX, 0, ParasCam1.Width);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                ParasCam1.SeedCenterX = Convert.ToInt32(LabCenterX.Text);
            }
        }
        private void BtnCenterXR_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam1.SeedCenterX < ParasCam1.Width - 2)
            {
                ParasCam1.SeedCenterX += 2;
                CenterXAdd = true;
            }
        }
        private void BtnCenterXR_MouseUp(object sender, MouseEventArgs e)
        {
            CenterXAdd = false;
        }
        private void BtnCenterXL_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam1.SeedCenterX > 2)
            {
                ParasCam1.SeedCenterX -= 2;
                CenterXSub = true;
            }
        }
        private void BtnCenterXL_MouseUp(object sender, MouseEventArgs e)
        {
            CenterXSub = false;
        }
        private void LabCenterY_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm
            {
                Location = new Point(400, 130)
            };
            kf.ImportData(ref LabCenterY, 0, ParasCam1.Height);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                ParasCam1.SeedCenterY = Convert.ToInt32(LabCenterY.Text);
            }
        }
        private void BtnCenterYUp_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam1.SeedCenterY > 2)
            {
                ParasCam1.SeedCenterY -= 2;
                CenterYSub = true;
            }
        }
        private void BtnCenterYUp_MouseUp(object sender, MouseEventArgs e)
        {
            CenterYSub = false;
        }
        private void BtnCenterYDown_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam1.SeedCenterY < ParasCam1.Height - 2)
            {
                ParasCam1.SeedCenterY += 2;
                CenterYAdd = true;
            }
        }
        private void BtnCenterYDown_MouseUp(object sender, MouseEventArgs e)
        {
            CenterYAdd = false;
        }
        private void LabExposure_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm
            {
                Location = new Point(400, 130)
            };
            kf.ImportData(ref LabExposure, 100, 50000);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                ParasCam1.ExpoTime = Convert.ToInt32(LabExposure.Text);
                DualCam.SetExpoTime1(DualCam.SelectCam, ParasCam1.ExpoTime);
            }
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            LabCenterX.Text = ParasCam1.SeedCenterX.ToString();
            LabCenterY.Text = ParasCam1.SeedCenterY.ToString();
            LabExposure.Text = ParasCam1.ExpoTime.ToString();
            if (CenterXAdd && ParasCam1.SeedCenterX < ParasCam1.Width - 2)
            {
                ParasCam1.SeedCenterX += 2;
            }
            if (CenterXSub && ParasCam1.SeedCenterX > 2)
            {
                ParasCam1.SeedCenterX -= 2;
            }
            if (CenterYAdd && ParasCam1.SeedCenterY < ParasCam1.Height - 2)
            {
                ParasCam1.SeedCenterY += 2;
            }
            if (CenterYSub && ParasCam1.SeedCenterY > 2)
            {
                ParasCam1.SeedCenterY -= 2;
            }

            if (IgAlgo1.IsAction)
            { 
                LabAutoExpoStatus.Visible = true;
                BtnAutoExpo.Enabled = false;
            }
            else
            { 
                 //LabAutoExpoStatus.Visible = false;
                 BtnAutoExpo.Enabled = true;

            }
            if (IgAlgo1.IsAction && IgAlgo1.IsFinded == false && !IgAlgo1.IsFailed)
            { 
                LabAutoExpoStatus.ForeColor = Color.Lime;
                LabAutoExpoStatus.Text = "自动曝光中...";
            }
            else if (IgAlgo1.IsFinded)
            { 
                LabAutoExpoStatus.ForeColor = Color.Lime;
                LabAutoExpoStatus.Text = "自动曝光成功";
            }
            if (IgAlgo1.IsFailed)
            { 
                LabAutoExpoStatus.ForeColor = Color.Red;    
                LabAutoExpoStatus.Text = "自动曝光失败";
            }
        }
      
        private void FrmCam1Adjust_Load(object sender, EventArgs e)
        {
            ParasCam1.ReadOut();
        }
        private void FrmCam1Adjust_FormClosed(object sender, FormClosedEventArgs e)
        {
            ParasCam1.ReadOut();
            DualCam.SetExpoTime1(DualCam.SelectCam, ParasCam1.ExpoTime);
            if (lastForm != null)
            {
                lastForm.Close();
            }
        }

        private void BtnAutoExpo_Click(object sender, EventArgs e)
        {
            double target = double.Parse(LabTarget.Text);
            double step = double.Parse(LabStep.Text);
            double tolerance = double.Parse(LabTolerance.Text);
            int statistic = (int)double.Parse(LabStatistics.Text);

            IgAlgo1.AutoExposure(target, step, tolerance, statistic);
        }

        private void BtnResetMeltTemp_Click(object sender, EventArgs e)
        {
           IgAlgo1.ResetMeltTemp();
        }

        private void BtnSaveImg_Click(object sender, EventArgs e)
        {
            BeginInvoke(new Action(() =>
            { 
                    if (lastForm != null) { lastForm.Close(); }
                    frmCam1SavePic = new FrmCam1SavePic();
                    FrmSwitch.Open(frmCam1SavePic, 154, new Point(4, 130), new Size(380, 638));
                    frmCam1SavePic.Show();
                    lastForm = frmCam1SavePic; 
            }));
        }

        private void LabTarget_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm
            {
                Location = new Point(400, 130)
            };
            kf.ImportData(ref LabTarget, 1, 255);
            kf.ShowDialog();
        }

        private void LabStep_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm
            {
                Location = new Point(400, 130)
            };
            kf.ImportData(ref LabStep, 0, 500);
            kf.ShowDialog();
        }

        private void LabTolerance_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm
            {
                Location = new Point(400, 130)
            };
            kf.ImportData(ref LabTolerance, 0, 255);
            kf.ShowDialog();
        }

        private void LabStatistics_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm
            {
                Location = new Point(400, 130)
            };
            kf.ImportData(ref LabStatistics, 1, 100);
            kf.ShowDialog();
        }
    }
}
