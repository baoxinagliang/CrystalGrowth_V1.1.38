using CrystalGrowth.CrystalCtl;
using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction.CCD
{
    public partial class FrmCam2Adjust : Form
    {
        private bool CenterXAdd = false;
        private bool CenterXSub = false;
        private bool CenterYAdd = false;
        private bool CenterYSub = false;
        public FrmCam2Adjust()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnSave))
            {
                ParasCam2.WriteIn();
                DualCam.SetExpoTime2(DualCam.SelectCam, ParasCam2.ExpoTime);
                Record.WriteIn("CCD相机2中心点X", LabCenterX.Text, "Yellow");
                Record.WriteIn("CCD相机2中心点Y", LabCenterY.Text, "Yellow");
                Record.WriteIn("CCD相机2曝光时间", LabExposure.Text, "Yellow");
                MessageBox.Show("保存成功！");
            }
        }
        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void LabCenterX_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm
            {
                Location = new Point(400, 130)
            };
            kf.ImportData(ref LabCenterX, 0, ParasCam2.Width);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                ParasCam2.SeedCenterX = Convert.ToInt32(LabCenterX.Text);
            }
        }
        private void BtnCenterXR_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam2.SeedCenterX < ParasCam2.Width - 2)
            {
                ParasCam2.SeedCenterX += 2;
                CenterXAdd = true;
            }
        }
        private void BtnCenterXR_MouseUp(object sender, MouseEventArgs e)
        {
            CenterXAdd = false;
        }
        private void BtnCenterXL_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam2.SeedCenterX > 2)
            {
                ParasCam2.SeedCenterX -= 2;
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
            kf.ImportData(ref LabCenterY, 0, ParasCam2.Height);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                ParasCam2.SeedCenterY = Convert.ToInt32(LabCenterY.Text);
            }
        }
        private void BtnCenterYUp_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam2.SeedCenterY > 2)
            {
                ParasCam2.SeedCenterY -= 2;
                CenterYSub = true;
            }
        }
        private void BtnCenterYUp_MouseUp(object sender, MouseEventArgs e)
        {
            CenterYSub = false;
        }
        private void BtnCenterYDown_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam2.SeedCenterY < ParasCam2.Height - 2)
            {
                ParasCam2.SeedCenterY += 2;
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
                ParasCam2.ExpoTime = Convert.ToInt32(LabExposure.Text);
                DualCam.SetExpoTime2(DualCam.SelectCam, ParasCam2.ExpoTime);
            }
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            LabCenterX.Text = ParasCam2.SeedCenterX.ToString();
            LabCenterY.Text = ParasCam2.SeedCenterY.ToString();
            LabExposure.Text = ParasCam2.ExpoTime.ToString();
            if (CenterXAdd && ParasCam2.SeedCenterX < ParasCam2.Width - 2)
            {
                ParasCam2.SeedCenterX += 2;
            }
            if (CenterXSub && ParasCam2.SeedCenterX > 2)
            {
                ParasCam2.SeedCenterX -= 2;
            }
            if (CenterYAdd && ParasCam2.SeedCenterY < ParasCam2.Height - 2)
            {
                ParasCam2.SeedCenterY += 2;
            }
            if (CenterYSub && ParasCam2.SeedCenterY > 2)
            {
                ParasCam2.SeedCenterY -= 2;
            }
        }
        private void FrmCam2Adjust_Load(object sender, EventArgs e)
        {
            ParasCam2.ReadOut();
        }
        private void FrmCam2Adjust_FormClosed(object sender, FormClosedEventArgs e)
        {
            ParasCam2.ReadOut();
            DualCam.SetExpoTime2(DualCam.SelectCam, ParasCam2.ExpoTime);
        }
    }
}
