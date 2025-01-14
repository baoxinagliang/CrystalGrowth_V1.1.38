using CamLibrary;
using CrystalGrowth.CrystalCtl;
using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction.CCD
{
    internal partial class FrmCCD : Form
    {
        public static bool IsOpen = false;
        public static bool DrawX1 = false;
        public static bool DrawCrossLine = false;
        public static bool DrawX2 = false;
        public static bool MouseLock = false;
        Form lastForm;
        FrmCam1Adjust frmCam1Adjust;
        FrmCam2Adjust frmCam2Adjust;
        FrmNeckArea frmNeckArea;
        FrmCrownArea frmCrownArea;
        FrmBodyArea frmBodyArea;
        FrmBodyTemp frmBodyTemp;
        FrmMeltGapArea frmMeltGapArea;
        FrmMeltGapLArea frmMeltGapLArea;
        FrmHArea frmHArea;
        FrmBrightArea frmBrightArea;
        FrmMeltCheckArea frmMeltCheckArea;
        FrmCrystalShake frmCrystalShakeArea;
        FrmCutLineCheck frmCutLine;
        FrmShieldMeasure frmShieldMeasure;
        FrmPicSave frmPicSave;
        FrmReferenceLine frmReferenceLine;
        public FrmCCD()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void FrmCCD_Load(object sender, EventArgs e)
        {
            IsOpen = true;
            FrmSwitch.Open(FrmImage.Single, 200, new Point(390, 55), new Size(970, 710));
            FrmImage.SizeValue1 = new Size(970, 710);
            FrmImage.SizeValue2Change();
            FrmImage.Single.Visible = true;
            if (DualCam.DoubleCam == "1")
            {
                BtnX2Area.Enabled = false;
                BtnZoom2.Enabled = false;
                BtnScanArea2.Enabled = false;
                BtnCam2Adjust.Enabled = false;
                BtnLock.Enabled = false;
                BtnX2Area.BackColor = Color.DarkSlateBlue;
                BtnZoom2.BackColor = Color.DarkSlateBlue;
                BtnScanArea2.BackColor = Color.DarkSlateBlue;
                BtnCam2Adjust.BackColor = Color.DarkSlateBlue;
                BtnLock.BackColor = Color.DarkSlateBlue;
            }
        }
        private void FrmCCD_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (FrmImage.Single != null) FrmImage.Single.Hide();
            if (frmCam1Adjust != null) frmCam1Adjust.Close();
            if (frmCam2Adjust != null) frmCam2Adjust.Close();
            if (frmNeckArea != null) frmNeckArea.Close();
            if (frmCrownArea != null) frmCrownArea.Close();
            if (frmBodyArea != null) frmBodyArea.Close();
            if (frmBodyTemp != null) frmBodyTemp.Close();
            if (frmMeltGapArea != null) frmMeltGapArea.Close();
            if (frmMeltGapLArea != null) frmMeltGapLArea.Close();
            if (frmHArea != null) frmHArea.Close();
            if (frmBrightArea != null) frmBrightArea.Close();
            if (frmMeltCheckArea != null) frmMeltCheckArea.Close();
            if (frmCrystalShakeArea != null) frmCrystalShakeArea.Close();
            if (frmCutLine != null) frmCutLine.Close();
            if (frmShieldMeasure != null) frmShieldMeasure.Close();
            if (frmPicSave != null) frmPicSave.Close();
            if (frmReferenceLine != null) frmReferenceLine.Close();
            BtnX1Area.BackColor = Color.RoyalBlue;
            BtnX2Area.BackColor = Color.RoyalBlue;
            IsOpen = false;
            DrawX1 = false;
            DrawX2 = false;
            MouseLock = false;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            BtnZoom1.BackColor = CamUnity.PZoom1.Flag ? Color.LightSalmon : Color.RoyalBlue;
            if (Mode.Current == Mode.Crown || Mode.Current == Mode.Neck || Mode.Current == Mode.Body)
            {
                BtnScanArea1.Enabled = true;
                BtnShield.Enabled = false;
                BtnScanArea1.BackColor = Color.RoyalBlue;
                BtnShield.BackColor = Color.DarkSlateBlue;
            }
            else
            {
                BtnScanArea1.Enabled = false;
                BtnShield.Enabled = true;
                BtnScanArea1.BackColor = Color.DarkSlateBlue;
                BtnShield.BackColor = Color.RoyalBlue;
            }
            switch (Mode.Current)
            {
                case 0:
                    BtnIdleMode.BackColor = Color.Red;
                    BtnNeckMode.BackColor = Color.RoyalBlue;
                    BtnCrownMode.BackColor = Color.RoyalBlue;
                    BtnBodyMode.BackColor = Color.RoyalBlue;
                    break;
                case 1:
                    BtnIdleMode.BackColor = Color.RoyalBlue;
                    BtnNeckMode.BackColor = Color.Red;
                    BtnCrownMode.BackColor = Color.RoyalBlue;
                    BtnBodyMode.BackColor = Color.RoyalBlue;
                    break;
                case 2:
                    BtnIdleMode.BackColor = Color.RoyalBlue;
                    BtnNeckMode.BackColor = Color.RoyalBlue;
                    BtnCrownMode.BackColor = Color.Red;
                    BtnBodyMode.BackColor = Color.RoyalBlue;
                    break;
                case 3:
                    BtnIdleMode.BackColor = Color.RoyalBlue;
                    BtnNeckMode.BackColor = Color.RoyalBlue;
                    BtnCrownMode.BackColor = Color.RoyalBlue;
                    BtnBodyMode.BackColor = Color.Red;
                    break;
            }
            if (MouseLock == false)
            {
                if (IsOpen && FrmImage.PnlZoom2)
                {
                    BtnLock.Enabled = true;
                    BtnLock.BackColor = Color.RoyalBlue;
                }
                else
                {
                    BtnLock.Enabled = false;
                    BtnLock.BackColor = Color.DarkSlateBlue;
                }
            }
            if (FrmMeltGapArea.AgreeMeltGap == 1)
            {
                BtnGapClose.BackColor = Color.DarkSlateBlue;
                BtnGapOpen.BackColor = Color.Red;
            }
            else
            {
                BtnGapClose.BackColor = Color.Red;
                BtnGapOpen.BackColor = Color.RoyalBlue;
            }
            if (DrawX1 || DrawCrossLine)
            {
                BtnX1Area.BackColor = Color.Red;

            }
            else
            {
                BtnX1Area.BackColor = Color.RoyalBlue;
            }
        }
        private void BtnCam1Adjust_Click(object sender, EventArgs e)
        {
            BeginInvoke(new Action(() =>
            {
                FrmLevel frmLevel = new FrmLevel("Engineer", "Engineer");
                frmLevel.ShowDialog();
                if (frmLevel.DialogResult == DialogResult.OK)
                {
                    if (lastForm != null) { lastForm.Close(); }
                    frmCam1Adjust = new FrmCam1Adjust();
                    FrmSwitch.Open(frmCam1Adjust, 154, new Point(4, 130), new Size(380, 638));
                    frmCam1Adjust.Show();
                    lastForm = frmCam1Adjust;
                }
            }));
        }
        private void BtnScanArea1_Click(object sender, EventArgs e)
        {
            if (lastForm != null) { lastForm.Close(); }
            switch (Mode.Current)
            {
                case 1:
                    FrmImage.DrawNeckMeasuredPointFlag = true;
                    frmNeckArea = new FrmNeckArea();
                    FrmSwitch.Open(frmNeckArea, 155, new Point(4, 130), new Size(380, 638));
                    frmNeckArea.Show();
                    lastForm = frmNeckArea;
                    break;
                case 2:
                    frmCrownArea = new FrmCrownArea();
                    FrmSwitch.Open(frmCrownArea, 156, new Point(4, 130), new Size(380, 638));
                    frmCrownArea.Show();
                    lastForm = frmCrownArea;
                    break;
                case 3:
                    frmBodyArea = new FrmBodyArea();
                    FrmSwitch.Open(frmBodyArea, 157, new Point(4, 130), new Size(380, 638));
                    frmBodyArea.Show();
                    lastForm = frmBodyArea;
                    break;
            }
        }
        private void BtnMeltGap_Click(object sender, EventArgs e)
        {
            if (lastForm != null) { lastForm.Close(); }
            frmMeltGapArea = new FrmMeltGapArea();
            FrmSwitch.Open(frmMeltGapArea, 158, new Point(4, 130), new Size(380, 638));
            frmMeltGapArea.Show();
            lastForm = frmMeltGapArea;
        }
        private void BtnMeltGapL_Click(object sender, EventArgs e)
        {
            if (lastForm != null) { lastForm.Close(); }
            frmMeltGapLArea = new FrmMeltGapLArea();
            FrmSwitch.Open(frmMeltGapLArea, 160, new Point(4, 130), new Size(380, 638));
            frmMeltGapLArea.Show();
            lastForm = frmMeltGapLArea;
        }
        private void BtnHArea_Click(object sender, EventArgs e)
        {
            BeginInvoke(new Action(() =>
            {
                FrmLevel frmLevel = new FrmLevel("Engineer", "Engineer");
                frmLevel.ShowDialog();
                if (frmLevel.DialogResult == DialogResult.OK)
                {
                    if (lastForm != null) { lastForm.Close(); }
                    frmHArea = new FrmHArea();
                    FrmSwitch.Open(frmHArea, 159, new Point(4, 130), new Size(380, 638));
                    frmHArea.Show();
                    lastForm = frmHArea;
                }
            }));
        }
        private void BtnX1Area_Click(object sender, EventArgs e)
        {
             BeginInvoke(new Action(() =>
            {
               
                if (lastForm != null) { lastForm.Close(); }
                frmReferenceLine = new FrmReferenceLine();
                FrmSwitch.Open(frmReferenceLine, 154, new Point(4, 130), new Size(380, 638));
                frmReferenceLine.Show();
                lastForm = frmReferenceLine;
                
            }));
        }
        private void BtnX2Area_Click(object sender, EventArgs e)
        {
            if (DrawX2)
            {
                DrawX2 = false;
                BtnX2Area.BackColor = Color.RoyalBlue;
            }
            else
            {
                DrawX2 = true;
                BtnX2Area.BackColor = Color.LightSalmon;
            }
        }
        private void BtnBright_Click(object sender, EventArgs e)
        {
            BeginInvoke(new Action(() =>
            {
                FrmLevel frmLevel = new FrmLevel("Engineer", "Engineer");
                frmLevel.ShowDialog();
                if (frmLevel.DialogResult == DialogResult.OK)
                {
                    if (lastForm != null) { lastForm.Close(); }
                    frmBrightArea = new FrmBrightArea();
                    FrmSwitch.Open(frmBrightArea, 162, new Point(4, 130), new Size(380, 638));
                    frmBrightArea.Show();
                    lastForm = frmBrightArea;
                }
            }));
        }
        private void BtnZoom1_Click(object sender, EventArgs e)
        {
            if (CamUnity.PZoom1.Flag)
            {
                CamUnity.PZoom1.Flag = false;
                CamUnity.PZoom1.IsZoom = false;
                CamUnity.PZoom1.ZoomRange = false;
                BtnZoom1.BackColor = Color.RoyalBlue;
            }
            else
            {
                CamUnity.PZoom1.Flag = true;
                CamUnity.PZoom1.IsZoom = true;
                CamUnity.PZoom1.ZoomRange = true;
                BtnZoom1.BackColor = Color.LightSalmon;
            }
            CamUnity.PZoom1.ChangeParas(new Point(ParasCam1.SeedCenterX, ParasCam1.SeedCenterY), new Size(ParasCam1.Width, ParasCam1.Height));
        }
        private void BtnMeltingCheck_Click(object sender, EventArgs e)
        {
            BeginInvoke(new Action(() =>
            {
                FrmLevel frmLevel = new FrmLevel("Engineer", "Engineer");
                frmLevel.ShowDialog();
                if (frmLevel.DialogResult == DialogResult.OK)
                {
                    if (lastForm != null) { lastForm.Close(); }
                    frmMeltCheckArea = new FrmMeltCheckArea();
                    FrmSwitch.Open(frmMeltCheckArea, 163, new Point(4, 130), new Size(380, 638));
                    frmMeltCheckArea.Show();
                    lastForm = frmMeltCheckArea;
                }
            }));
        }
        private void BtnCrysShake_Click(object sender, EventArgs e)
        {
            BeginInvoke(new Action(() =>
            {
                FrmLevel frmLevel = new FrmLevel("Engineer", "Engineer");
                frmLevel.ShowDialog();
                if (frmLevel.DialogResult == DialogResult.OK)
                {
                    if (lastForm != null) { lastForm.Close(); }
                    frmCrystalShakeArea = new FrmCrystalShake();
                    FrmSwitch.Open(frmCrystalShakeArea, 164, new Point(4, 130), new Size(380, 638));
                    frmCrystalShakeArea.Show();
                    lastForm = frmCrystalShakeArea;
                }
            }));
        }
        private void BtnCutlineCheck_Click(object sender, EventArgs e)
        {
            BeginInvoke(new Action(() =>
            {
                FrmLevel frmLevel = new FrmLevel("Engineer", "Engineer");
                frmLevel.ShowDialog();
                if (frmLevel.DialogResult == DialogResult.OK)
                {
                    if (lastForm != null) { lastForm.Close(); }
                    frmCutLine = new FrmCutLineCheck();
                    FrmSwitch.Open(frmCutLine, 165, new Point(4, 130), new Size(380, 638));
                    frmCutLine.Show();
                    lastForm = frmCutLine;
                }
            }));
        }
        private void BtnFurnaceCtl_Click(object sender, EventArgs e)
        {
            FrmSwitch.LastFormClose();
            FrmSwitch.OpenAutoForm();
        }
        private void BtnShield_Click(object sender, EventArgs e)
        {
            BeginInvoke(new Action(() =>
            {
                FrmLevel frmLevel = new FrmLevel("Engineer", "Engineer");
                frmLevel.ShowDialog();
                if (frmLevel.DialogResult == DialogResult.OK)
                {
                    if (lastForm != null) { lastForm.Close(); }
                    frmShieldMeasure = new FrmShieldMeasure();
                    FrmSwitch.Open(frmShieldMeasure, 165, new Point(4, 130), new Size(380, 638));
                    frmShieldMeasure.Show();
                    lastForm = frmShieldMeasure;
                }
            }));
        }
        private void BtnZoom2_Click(object sender, EventArgs e)
        {
            if (CamUnity.PZoom2.Flag)
            {
                CamUnity.PZoom2.Flag = false;
                CamUnity.PZoom2.IsZoom = false;
                CamUnity.PZoom2.ZoomRange = false;
                BtnZoom2.BackColor = Color.LightSalmon;
            }
            else
            {
                CamUnity.PZoom2.Flag = true;
                CamUnity.PZoom2.IsZoom = true;
                CamUnity.PZoom2.ZoomRange = true;
                BtnZoom2.BackColor = Color.RoyalBlue;
            }
            CamUnity.PZoom2.ChangeParas(new Point(ParasCam2.SeedCenterX, ParasCam2.SeedCenterY), new Size(ParasCam2.Width, ParasCam2.Height));
        }
        private void BtnScanArea2_Click(object sender, EventArgs e)
        {
            BeginInvoke(new Action(() =>
            {
                FrmLevel frmLevel = new FrmLevel("Engineer", "Engineer");
                frmLevel.ShowDialog();
                if (frmLevel.DialogResult == DialogResult.OK)
                {
                    if (lastForm != null) { lastForm.Close(); }
                    if (Mode.Current == Mode.Neck)
                    {
                        frmBodyTemp = new FrmBodyTemp();
                        FrmSwitch.Open(frmBodyTemp, 157, new Point(4, 130), new Size(380, 638));
                        frmBodyTemp.Show();
                        lastForm = frmBodyTemp;
                    }
                }
            }));
        }
        private void BtnLock_Click(object sender, EventArgs e)
        {
            if (MouseLock)
            {
                MouseLock = false;
                BtnLock.BackColor = Color.RoyalBlue;
            }
            else
            {
                MouseLock = true;
                BtnLock.BackColor = Color.LightSalmon;
            }
        }
        private void BtnIdleMode_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnIdleMode))
            {
                BtnIdleMode.BackColor = Color.Red;
                BtnNeckMode.BackColor = Color.RoyalBlue;
                BtnCrownMode.BackColor = Color.RoyalBlue;
                BtnBodyMode.BackColor = Color.RoyalBlue;
                Mode.Current = Mode.Idle;
            }
        }
        private void BtnNeckMode_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnNeckMode))
            {
                BtnIdleMode.BackColor = Color.RoyalBlue;
                BtnNeckMode.BackColor = Color.Red;
                BtnCrownMode.BackColor = Color.RoyalBlue;
                BtnBodyMode.BackColor = Color.RoyalBlue;
                Mode.Current = Mode.Neck;
            }
        }
        private void BtnCrownMode_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnCrownMode))
            {
                BtnIdleMode.BackColor = Color.RoyalBlue;
                BtnNeckMode.BackColor = Color.RoyalBlue;
                BtnCrownMode.BackColor = Color.Red;
                BtnBodyMode.BackColor = Color.RoyalBlue;
                Mode.Current = Mode.Crown;
            }
        }
        private void BtnBodyMode_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnBodyMode))
            {
                BtnIdleMode.BackColor = Color.RoyalBlue;
                BtnNeckMode.BackColor = Color.RoyalBlue;
                BtnCrownMode.BackColor = Color.RoyalBlue;
                BtnBodyMode.BackColor = Color.Red;
                Mode.Current = Mode.Body;
            }
        }
        private void BtnGapClose_Click(object sender, EventArgs e)
        {
            //液口距控制开时，液口距测量不能关闭
            if (DouClick.ThreeSec(ref BtnGapClose))
            {
                DialogResult answer = MessageBox.Show("请确认是否要关闭液口距？", "液口距提示", MessageBoxButtons.YesNo);
                if (answer == DialogResult.Yes)
                {
                    BtnGapClose.BackColor = Color.Red;
                    BtnGapOpen.BackColor = Color.RoyalBlue;
                    FrmMeltGapArea.AgreeMeltGap = 0;
                    if (PLC.ReadValue[1] == 0)
                    {
                        FrmMeltGapArea.ManualCloseFlag = true;
                    }
                }
            }
        }
        private void BtnGapOpen_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnGapOpen))
            {
                BtnGapClose.BackColor = Color.RoyalBlue;
                BtnGapOpen.BackColor = Color.Red;
                if (FrmMeltGapArea.AgreeMeltGap == 0)
                {
                    FrmMeltGapArea.AgreeMeltGap = 1;
                }
                if (PLC.ReadValue[1] == 0)
                {
                    FrmMeltGapArea.ManualCloseFlag = false;
                }
            }
        }
        private void BtnCam2Adjust_Click(object sender, EventArgs e)
        {
            BeginInvoke(new Action(() =>
            {
                FrmLevel frmLevel = new FrmLevel("Engineer", "Engineer");
                frmLevel.ShowDialog();
                if (frmLevel.DialogResult == DialogResult.OK)
                {
                    if (lastForm != null) { lastForm.Close(); }
                    frmCam2Adjust = new FrmCam2Adjust();
                    FrmSwitch.Open(frmCam2Adjust, 154, new Point(4, 130), new Size(380, 638));
                    frmCam2Adjust.Show();
                    lastForm = frmCam2Adjust;
                }
            }));
        }

        private void BtnPicSave_Click(object sender, EventArgs e)
        {
            BeginInvoke(new Action(() =>
            {
                FrmLevel frmLevel = new FrmLevel("SuperUser", "SuperUser");
                frmLevel.ShowDialog();
                if (frmLevel.DialogResult == DialogResult.OK)
                {
                    if (lastForm != null) { lastForm.Close(); }
                    frmPicSave = new FrmPicSave();
                    FrmSwitch.Open(frmPicSave, 154, new Point(4, 130), new Size(380, 638));
                    frmPicSave.Show();
                    lastForm = frmPicSave;
                }
            }));
        }
    }
}