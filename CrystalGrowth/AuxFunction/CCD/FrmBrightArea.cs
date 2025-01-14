using CrystalGrowth.CrystalCtl;
using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction.CCD
{
    internal partial class FrmBrightArea : Form
    {
        private bool LeftXSub = false;
        private bool LeftXAdd = false;
        private bool RightXSub = false;
        private bool RightXAdd = false;
        private bool PointYSub = false;
        private bool PointYAdd = false;
        private bool PreLeftXSub = false;
        private bool PreLeftXAdd = false;
        private bool PreRightXSub = false;
        private bool PreRightXAdd = false;
        private bool PrePointYSub = false;
        private bool PrePointYAdd = false;
        public FrmBrightArea()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void BtnQuit_Click(object sender, EventArgs e)
        {
            ParasCam1.ReadOut();
            Close();
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnSave))
            {
                ParasCam1.WriteIn();
                if (FrmMeltTemp.PreTempRunningFlag == false)
                {
                    Record.WriteIn("CCD温度区域扫描线左X", LabLeftXOffset.Text, "Yellow");
                    Record.WriteIn("CCD温度区域扫描线右X", LabRightXOffset.Text, "Yellow");
                    Record.WriteIn("CCD温度区域两测点Y", LabPointYOffset.Text, "Yellow");
                }
                else
                {
                    Record.WriteIn("CCD预调温区域扫描线左X", LabPreLeftXOffset.Text, "Yellow");
                    Record.WriteIn("CCD预调温区域扫描线右X", LabPreRightXOffset.Text, "Yellow");
                    Record.WriteIn("CCD预调温区域两测点Y", LabPrePointYOffset.Text, "Yellow");
                }
                MessageBox.Show("保存成功！");
            }
        }
        private void LabLeftXOffset_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm
            {
                Location = new Point(400, 130)
            };
            kf.ImportData(ref LabLeftXOffset, -ParasCam1.SeedCenterX, ParasCam1.Width - ParasCam1.SeedCenterX);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                ParasCam1.BrightLeftXOffset = Convert.ToInt32(LabLeftXOffset.Text);
                ParasCam1.BrightLeftX = ParasCam1.SeedCenterX + ParasCam1.BrightLeftXOffset;
            }
        }
        private void BtnLeftXOffsetSub_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam1.BrightLeftX > 2)
            {
                ParasCam1.BrightLeftXOffset -= 2;
                ParasCam1.BrightLeftX = ParasCam1.SeedCenterX + ParasCam1.BrightLeftXOffset;
                LeftXSub = true;
            }
        }
        private void BtnLeftXOffsetSub_MouseUp(object sender, MouseEventArgs e)
        {
            LeftXSub = false;
        }
        private void BtnLeftXOffsetAdd_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam1.BrightLeftX < ParasCam1.Width - 2)
            {
                ParasCam1.BrightLeftXOffset += 2;
                ParasCam1.BrightLeftX = ParasCam1.SeedCenterX + ParasCam1.BrightLeftXOffset;
                LeftXAdd = true;
            }
        }
        private void BtnLeftXOffsetAdd_MouseUp(object sender, MouseEventArgs e)
        {
            LeftXAdd = false;
        }
        private void LabRightXOffset_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm
            {
                Location = new Point(400, 130)
            };
            kf.ImportData(ref LabRightXOffset, -ParasCam1.SeedCenterX, ParasCam1.Width - ParasCam1.SeedCenterX);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                ParasCam1.BrightRightXOffset = Convert.ToInt32(LabRightXOffset.Text);
                ParasCam1.BrightRightX = ParasCam1.SeedCenterX + ParasCam1.BrightRightXOffset;
            }
        }
        private void BtnRightXOffsetSub_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam1.BrightRightX > 2)
            {
                ParasCam1.BrightRightXOffset -= 2;
                ParasCam1.BrightRightX = ParasCam1.SeedCenterX + ParasCam1.BrightRightXOffset;
                RightXSub = true;
            }
        }
        private void BtnRightXOffsetSub_MouseUp(object sender, MouseEventArgs e)
        {
            RightXSub = false;
        }
        private void BtnRightXOffsetAdd_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam1.BrightRightX < ParasCam1.Width - 2)
            {
                ParasCam1.BrightRightXOffset += 2;
                ParasCam1.BrightRightX = ParasCam1.SeedCenterX + ParasCam1.BrightRightXOffset;
                RightXAdd = true;
            }
        }
        private void BtnRightXOffsetAdd_MouseUp(object sender, MouseEventArgs e)
        {
            RightXAdd = false;
        }
        private void LabPointYOffset_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm
            {
                Location = new Point(400, 130)
            };
            kf.ImportData(ref LabPointYOffset, -ParasCam1.SeedCenterY, ParasCam1.Height - ParasCam1.SeedCenterY - 50);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                ParasCam1.BrightPointYOffset = Convert.ToInt32(LabPointYOffset.Text);
                ParasCam1.BrightPointY = ParasCam1.SeedCenterY + ParasCam1.BrightPointYOffset;
            }
        }
        private void BtnPointYOffsetSub_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam1.BrightPointY > 2)
            {
                ParasCam1.BrightPointYOffset -= 2;
                ParasCam1.BrightPointY = ParasCam1.SeedCenterY + ParasCam1.BrightPointYOffset;
                PointYSub = true;
            }
        }
        private void BtnPointYOffsetSub_MouseUp(object sender, MouseEventArgs e)
        {
            PointYSub = false;
        }
        private void BtnPointYOffsetAdd_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam1.BrightPointY < ParasCam1.Height - 2)
            {
                ParasCam1.BrightPointYOffset += 2;
                ParasCam1.BrightPointY = ParasCam1.SeedCenterY + ParasCam1.BrightPointYOffset;
                PointYAdd = true;
            }
        }
        private void BtnPointYOffsetAdd_MouseUp(object sender, MouseEventArgs e)
        {
            PointYAdd = false;
        }
        private void LabPreLeftXOffset_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm
            {
                Location = new Point(400, 130)
            };
            kf.ImportData(ref LabPreLeftXOffset, -ParasCam1.SeedCenterX, ParasCam1.Width - ParasCam1.SeedCenterX);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                ParasCam1.BrightPreLeftXOffset = Convert.ToInt32(LabPreLeftXOffset.Text);
                ParasCam1.BrightPreLeftX = ParasCam1.SeedCenterX + ParasCam1.BrightPreLeftXOffset;
            }
        }
        private void BtnPreLeftXOffsetSub_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam1.BrightPreLeftX > 2)
            {
                ParasCam1.BrightPreLeftXOffset -= 2;
                ParasCam1.BrightPreLeftX = ParasCam1.SeedCenterX + ParasCam1.BrightPreLeftXOffset;
                PreLeftXSub = true;
            }
        }
        private void BtnPreLeftXOffsetSub_MouseUp(object sender, MouseEventArgs e)
        {
            PreLeftXSub = false;
        }
        private void BtnPreLeftXOffsetAdd_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam1.BrightPreLeftX < ParasCam1.Width - 2)
            {
                ParasCam1.BrightPreLeftXOffset += 2;
                ParasCam1.BrightPreLeftX = ParasCam1.SeedCenterX + ParasCam1.BrightPreLeftXOffset;
                PreLeftXAdd = true;
            }
        }
        private void BtnPreLeftXOffsetAdd_MouseUp(object sender, MouseEventArgs e)
        {
            PreLeftXAdd = false;
        }
        private void LabPreRightXOffset_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm
            {
                Location = new Point(400, 130)
            };
            kf.ImportData(ref LabPreRightXOffset, -ParasCam1.SeedCenterX, ParasCam1.Width - ParasCam1.SeedCenterX);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                ParasCam1.BrightPreRightXOffset = Convert.ToInt32(LabPreRightXOffset.Text);
                ParasCam1.BrightPreRightX = ParasCam1.SeedCenterX + ParasCam1.BrightPreRightXOffset;
            }
        }
        private void BtnPreRightXOffsetSub_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam1.BrightPreRightX > 2)
            {
                ParasCam1.BrightPreRightXOffset -= 2;
                ParasCam1.BrightPreRightX = ParasCam1.SeedCenterX + ParasCam1.BrightPreRightXOffset;
                PreRightXSub = true;
            }
        }
        private void BtnPreRightXOffsetSub_MouseUp(object sender, MouseEventArgs e)
        {
            PreRightXSub = false;
        }
        private void BtnPreRightXOffsetAdd_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam1.BrightPreRightX < ParasCam1.Width - 2)
            {
                ParasCam1.BrightPreRightXOffset += 2;
                ParasCam1.BrightPreRightX = ParasCam1.SeedCenterX + ParasCam1.BrightPreRightXOffset;
                PreRightXAdd = true;
            }
        }
        private void BtnPreRightXOffsetAdd_MouseUp(object sender, MouseEventArgs e)
        {
            PreRightXAdd = false;
        }
        private void LabPrePointYOffset_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm
            {
                Location = new Point(400, 130)
            };
            kf.ImportData(ref LabPrePointYOffset, -ParasCam1.SeedCenterY, ParasCam1.Height - ParasCam1.SeedCenterY - 50);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                ParasCam1.BrightPrePointYOffset = Convert.ToInt32(LabPrePointYOffset.Text);
                ParasCam1.BrightPrePointY = ParasCam1.SeedCenterY + ParasCam1.BrightPrePointYOffset;
            }
        }
        private void BtnPrePointYOffsetSub_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam1.BrightPrePointY > 2)
            {
                ParasCam1.BrightPrePointYOffset -= 2;
                ParasCam1.BrightPrePointY = ParasCam1.SeedCenterY + ParasCam1.BrightPrePointYOffset;
                PrePointYSub = true;
            }
        }
        private void BtnPrePointYOffsetSub_MouseUp(object sender, MouseEventArgs e)
        {
            PrePointYSub = false;
        }
        private void BtnPrePointYOffsetAdd_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam1.BrightPrePointY < ParasCam1.Height - 2)
            {
                ParasCam1.BrightPrePointYOffset += 2;
                ParasCam1.BrightPrePointY = ParasCam1.SeedCenterY + ParasCam1.BrightPrePointYOffset;
                PrePointYAdd = true;
            }
        }
        private void BtnPrePointYOffsetAdd_MouseUp(object sender, MouseEventArgs e)
        {
            PrePointYAdd = false;
        }
        private void TempPosChange()
        {
            if (LeftXSub && ParasCam1.BrightLeftX > 2)
            {
                ParasCam1.BrightLeftXOffset -= 2;
                ParasCam1.BrightLeftX = ParasCam1.SeedCenterX + ParasCam1.BrightLeftXOffset;
            }
            else if (LeftXAdd && ParasCam1.BrightLeftX < ParasCam1.Width - 2)
            {
                ParasCam1.BrightLeftXOffset += 2;
                ParasCam1.BrightLeftX = ParasCam1.SeedCenterX + ParasCam1.BrightLeftXOffset;
            }
            else if (RightXSub && ParasCam1.BrightRightX > 2)
            {
                ParasCam1.BrightRightXOffset -= 2;
                ParasCam1.BrightRightX = ParasCam1.SeedCenterX + ParasCam1.BrightRightXOffset;
            }
            else if (RightXAdd && ParasCam1.BrightRightX < ParasCam1.Width - 2)
            {
                ParasCam1.BrightRightXOffset += 2;
                ParasCam1.BrightRightX = ParasCam1.SeedCenterX + ParasCam1.BrightRightXOffset;
            }
            else if (PointYSub && ParasCam1.BrightPointY > 2)
            {
                ParasCam1.BrightPointYOffset -= 2;
                ParasCam1.BrightPointY = ParasCam1.SeedCenterY + ParasCam1.BrightPointYOffset;
            }
            else if (PointYAdd && ParasCam1.BrightPointY < ParasCam1.Height - 2)
            {
                ParasCam1.BrightPointYOffset += 2;
                ParasCam1.BrightPointY = ParasCam1.SeedCenterY + ParasCam1.BrightPointYOffset;
            }
            LabLeftXOffset.Text = ParasCam1.BrightLeftXOffset.ToString();
            LabRightXOffset.Text = ParasCam1.BrightRightXOffset.ToString();
            LabPointYOffset.Text = ParasCam1.BrightPointYOffset.ToString();
        }
        private void PreTempPosChange()
        {
            if (PreLeftXSub && ParasCam1.BrightPreLeftX > 2)
            {
                ParasCam1.BrightPreLeftXOffset -= 2;
                ParasCam1.BrightPreLeftX = ParasCam1.SeedCenterX + ParasCam1.BrightPreLeftXOffset;
            }
            else if (PreLeftXAdd && ParasCam1.BrightPreLeftX < ParasCam1.Width - 2)
            {
                ParasCam1.BrightPreLeftXOffset += 2;
                ParasCam1.BrightPreLeftX = ParasCam1.SeedCenterX + ParasCam1.BrightPreLeftXOffset;
            }
            else if (PreRightXSub && ParasCam1.BrightPreRightX > 2)
            {
                ParasCam1.BrightPreRightXOffset -= 2;
                ParasCam1.BrightPreRightX = ParasCam1.SeedCenterX + ParasCam1.BrightPreRightXOffset;
            }
            else if (PreRightXAdd && ParasCam1.BrightPreRightX < ParasCam1.Width - 2)
            {
                ParasCam1.BrightPreRightXOffset += 2;
                ParasCam1.BrightPreRightX = ParasCam1.SeedCenterX + ParasCam1.BrightPreRightXOffset;
            }
            else if (PrePointYSub && ParasCam1.BrightPointY > 2)
            {
                ParasCam1.BrightPrePointYOffset -= 2;
                ParasCam1.BrightPrePointY = ParasCam1.SeedCenterY + ParasCam1.BrightPrePointYOffset;
            }
            else if (PrePointYAdd && ParasCam1.BrightPrePointY < ParasCam1.Height - 2)
            {
                ParasCam1.BrightPrePointYOffset += 2;
                ParasCam1.BrightPrePointY = ParasCam1.SeedCenterY + ParasCam1.BrightPrePointYOffset;
            }
            LabPreLeftXOffset.Text = ParasCam1.BrightPreLeftXOffset.ToString();
            LabPreRightXOffset.Text = ParasCam1.BrightPreRightXOffset.ToString();
            LabPrePointYOffset.Text = ParasCam1.BrightPrePointYOffset.ToString();
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            TempPosChange();
            PreTempPosChange();
            if (FrmMeltTemp.PreTempRunningFlag == false)
            {
                ChangeState(true);
            }
            else
            {
                ChangeState(false);
            }
            BtnSave.Enabled = PLC.ReadStatus[5] != 1 || PLC.ReadStatus[6] != 1;
        }

        private void ChangeState(bool state)
        {
            LabLeftXOffset.Enabled = state;
            LabRightXOffset.Enabled = state;
            LabPointYOffset.Enabled = state;
            BtnLeftXOffsetSub.Enabled = state;
            BtnLeftXOffsetAdd.Enabled = state;
            BtnRightXOffsetSub.Enabled = state;
            BtnRightXOffsetAdd.Enabled = state;
            BtnPointYOffsetAdd.Enabled = state;
            BtnPointYOffsetSub.Enabled = state;
            LabPreLeftXOffset.Enabled = !state;
            LabPreRightXOffset.Enabled = !state;
            LabPrePointYOffset.Enabled = !state;
            BtnPreLeftXOffsetSub.Enabled = !state;
            BtnPreLeftXOffsetAdd.Enabled = !state;
            BtnPreRightXOffsetSub.Enabled = !state;
            BtnPreRightXOffsetAdd.Enabled = !state;
            BtnPrePointYOffsetAdd.Enabled = !state;
            BtnPrePointYOffsetSub.Enabled = !state;
        }
        private void FrmBrightArea_Load(object sender, EventArgs e)
        {
            ParasCam1.ReadOut();
        }
    }
}
