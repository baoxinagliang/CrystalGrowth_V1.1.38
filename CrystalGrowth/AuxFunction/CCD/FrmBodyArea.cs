using CrystalGrowth.CrystalCtl;
using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction.CCD
{
    internal partial class FrmBodyArea : Form
    {
        public static bool IsOpen = false;
        private bool LeftXSub = false;
        private bool LeftXAdd = false;
        private bool RightXAdd = false;
        private bool RightXSub = false;
        private bool TopYAdd = false;
        private bool TopYSub = false;
        private bool BottomYAdd = false;
        private bool BottomYSub = false;
        string strInfo = "";
        CCDDataLimit ccdLimit;
        public FrmBodyArea()
        {
            InitializeComponent();
            ccdLimit = new CCDDataLimit();
            Load += Timer1_Tick;
        }
        private void FrmBodyArea_Load(object sender, EventArgs e)
        {
            ParasCam1.ReadOut();
            IsOpen = true;
        }
        private void FrmBodyArea_FormClosed(object sender, FormClosedEventArgs e)
        {
            ParasCam1.ReadOut();
            IsOpen = false;
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
                Record.WriteIn("CCD等径区域扫描线左X", LabLeftXOffset.Text, "Yellow");
                Record.WriteIn("CCD等径区域扫描线右X", LabRightXOffset.Text, "Yellow");
                Record.WriteIn("CCD等径区域上扫描线Y", LabTopYOffset.Text, "Yellow");
                Record.WriteIn("CCD等径区域下扫描线Y", LabBottomYOffset.Text, "Yellow");
                Record.WriteIn("CCD等径区域滤波值", LabBodyArrayNum.Text, "Yellow");
                Record.WriteIn("CCD等径区域阈值", LabThreshold.Text, "Yellow");
                MessageBox.Show("保存成功！");
            }
        }
        private void LabLeftXOffset_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm
            {
                LocPoint = new Point(400, 130)
            };
            kf.ImportData(ref LabLeftXOffset, -ParasCam1.SeedCenterX, 0);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                ParasCam1.BodyLeftXOffset = Convert.ToInt32(LabLeftXOffset.Text);
                ParasCam1.BodyLeftX = ParasCam1.SeedCenterX + ParasCam1.BodyLeftXOffset;
            }
        }
        private void BtnLeftXOffsetSub_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam1.BodyLeftX > 2)
            {
                ParasCam1.BodyLeftXOffset -= 2;
                ParasCam1.BodyLeftX = ParasCam1.SeedCenterX + ParasCam1.BodyLeftXOffset;
                LeftXSub = true;
            }
        }
        private void BtnLeftXOffsetSub_MouseUp(object sender, MouseEventArgs e)
        {
            LeftXSub = false;
        }
        private void BtnLeftXOffsetAdd_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam1.BodyLeftX < ParasCam1.BodyRightX - 2)
            {
                ParasCam1.BodyLeftXOffset += 2;
                ParasCam1.BodyLeftX = ParasCam1.SeedCenterX + ParasCam1.BodyLeftXOffset;
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
            kf.ImportData(ref LabRightXOffset, 0, ParasCam1.Width - ParasCam1.SeedCenterX);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                ParasCam1.BodyRightXOffset = Convert.ToInt32(LabRightXOffset.Text);
                ParasCam1.BodyRightX = ParasCam1.SeedCenterX + ParasCam1.BodyRightXOffset;
            }
        }
        private void BtnRightXOffsetSub_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam1.BodyRightX > ParasCam1.BodyLeftX + 2)
            {
                ParasCam1.BodyRightXOffset -= 2;
                ParasCam1.BodyRightX = ParasCam1.SeedCenterX + ParasCam1.BodyRightXOffset;
                RightXSub = true;
            }
        }
        private void BtnRightXOffsetSub_MouseUp(object sender, MouseEventArgs e)
        {
            RightXSub = false;
        }
        private void BtnRightXOffsetAdd_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam1.BodyRightX < ParasCam1.Width - 2)
            {
                ParasCam1.BodyRightXOffset += 2;
                ParasCam1.BodyRightX = ParasCam1.SeedCenterX + ParasCam1.BodyRightXOffset;
                RightXAdd = true;
            }
        }
        private void BtnRightXOffsetAdd_MouseUp(object sender, MouseEventArgs e)
        {
            RightXAdd = false;
        }
        private void LabTopYOffset_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm
            {
                Location = new Point(400, 130)
            };
            kf.ImportData(ref LabTopYOffset, ParasCam1.SeedCenterY - ParasCam1.Height, ParasCam1.BodyBottomYOffset);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                if (ccdLimit.YD(ref strInfo, Convert.ToInt32(LabTopYOffset.Text), Convert.ToInt32(LabBottomYOffset.Text)))
                {
                    LabTopYOffset.Text = ParasCam1.BodyTopYOffset.ToString();
                    LabDis.Text = strInfo;
                    return;
                }
                else
                {
                    LabDis.Text = strInfo;
                    ParasCam1.BodyTopYOffset = Convert.ToInt32(LabTopYOffset.Text);
                    ParasCam1.BodyTopY = ParasCam1.SeedCenterY + ParasCam1.BodyTopYOffset;
                }
            }
        }
        private void BtnTopYOffSetSub_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam1.BodyTopY > 2)
            {
                if (!ccdLimit.YD(ref strInfo, Convert.ToInt32(LabTopYOffset.Text), Convert.ToInt32(LabBottomYOffset.Text) + 4))
                {
                    LabDis.Text = strInfo;
                    ParasCam1.BodyTopYOffset -= 2;
                    ParasCam1.BodyTopY = ParasCam1.SeedCenterY + ParasCam1.BodyTopYOffset;
                    TopYSub = true;
                }
            }
        }
        private void BtnTopYOffSetSub_MouseUp(object sender, MouseEventArgs e)
        {
            TopYSub = false;
        }
        private void BtnTopYOffsetAdd_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam1.BodyTopY < ParasCam1.BodyBottomY - 2)
            {
                if (ccdLimit.YD(ref strInfo, Convert.ToInt32(LabTopYOffset.Text), Convert.ToInt32(LabBottomYOffset.Text)))
                {
                    LabTopYOffset.Text = ParasCam1.BodyTopYOffset.ToString();
                    LabDis.Text = strInfo;
                    return;
                }
                else
                {
                    LabDis.Text = strInfo;
                    ParasCam1.BodyTopYOffset += 2;
                    ParasCam1.BodyTopY = ParasCam1.SeedCenterY + ParasCam1.BodyTopYOffset;
                    TopYAdd = true;
                }
            }
        }
        private void BtnTopYOffsetAdd_MouseUp(object sender, MouseEventArgs e)
        {
            TopYAdd = false;
        }
        private void LabBottomYOffset_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm
            {
                Location = new Point(400, 130)
            };
            kf.ImportData(ref LabBottomYOffset, ParasCam1.BodyTopYOffset, ParasCam1.Height - ParasCam1.SeedCenterY);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                if (ccdLimit.YD(ref strInfo, Convert.ToInt32(LabTopYOffset.Text), Convert.ToInt32(LabBottomYOffset.Text)))
                {
                    LabBottomYOffset.Text = ParasCam1.BodyBottomYOffset.ToString();
                    LabDis.Text = strInfo;
                    return;
                }
                else
                {
                    LabDis.Text = strInfo;
                    ParasCam1.BodyBottomYOffset = Convert.ToInt32(LabBottomYOffset.Text);
                    ParasCam1.BodyBottomY = ParasCam1.SeedCenterY + ParasCam1.BodyBottomYOffset;
                }
            }
        }
        private void BtnBottomYOffsetSub_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam1.BodyBottomY > ParasCam1.BodyTopY - 2)
            {
                if (ccdLimit.YD(ref strInfo, Convert.ToInt32(LabTopYOffset.Text), Convert.ToInt32(LabBottomYOffset.Text)))
                {
                    LabBottomYOffset.Text = ParasCam1.BodyBottomYOffset.ToString();
                    LabDis.Text = strInfo;
                    return;
                }
                else
                {
                    LabDis.Text = strInfo;
                    ParasCam1.BodyBottomYOffset -= 2;
                    ParasCam1.BodyBottomY = ParasCam1.SeedCenterY + ParasCam1.BodyBottomYOffset;
                    BottomYSub = true;
                }
            }
        }
        private void BtnBottomYOffsetSub_MouseUp(object sender, MouseEventArgs e)
        {
            BottomYSub = false;
        }
        private void BtnBottomYOffsetAdd_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam1.BodyBottomY < ParasCam1.Height - 2)
            {
                if (!ccdLimit.YD(ref strInfo, Convert.ToInt32(LabTopYOffset.Text), Convert.ToInt32(LabBottomYOffset.Text) + 4))
                {
                    LabDis.Text = strInfo;
                    ParasCam1.BodyBottomYOffset += 2;
                    ParasCam1.BodyBottomY = ParasCam1.SeedCenterY + ParasCam1.BodyBottomYOffset;
                    BottomYAdd = true;
                }           
            }
        }
        private void BtnBottomYOffsetAdd_MouseUp(object sender, MouseEventArgs e)
        {
            BottomYAdd = false;
        }
        private void LabThreshold_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm
            {
                Location = new Point(400, 130)
            };
            kf.ImportData(ref LabThreshold, 0, 255);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                ParasCam1.BodyThreshold = Convert.ToInt32(LabThreshold.Text);
            }
        }
        private void LabBodyArrayNum_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm
            {
                Location = new Point(400, 130)
            };
            kf.ImportData(ref LabBodyArrayNum, 0, 255);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                ParasCam1.BodyArrayNum = Convert.ToInt32(LabBodyArrayNum.Text);
            }
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (LeftXSub && ParasCam1.BodyLeftX > 2)
            {
                ParasCam1.BodyLeftXOffset -= 2;
                ParasCam1.BodyLeftX = ParasCam1.SeedCenterX + ParasCam1.BodyLeftXOffset;
            }
            else if (LeftXAdd && ParasCam1.BodyLeftX < ParasCam1.BodyRightX - 2)
            {
                ParasCam1.BodyLeftXOffset += 2;
                ParasCam1.BodyLeftX = ParasCam1.SeedCenterX + ParasCam1.BodyLeftXOffset;
            }
            else if (RightXSub && ParasCam1.BodyRightX > ParasCam1.BodyLeftX + 2)
            {
                ParasCam1.BodyRightXOffset -= 2;
                ParasCam1.BodyRightX = ParasCam1.SeedCenterX + ParasCam1.BodyRightXOffset;
            }
            else if (RightXAdd && ParasCam1.BodyRightX < ParasCam1.Width - 2)
            {
                ParasCam1.BodyRightXOffset += 2;
                ParasCam1.BodyRightX = ParasCam1.SeedCenterX + ParasCam1.BodyRightXOffset;
            }
            else if (TopYSub && ParasCam1.BodyTopY > 2)
            {
                ParasCam1.BodyTopYOffset -= 2;
                ParasCam1.BodyTopY = ParasCam1.SeedCenterY + ParasCam1.BodyTopYOffset;
            }
            else if (TopYAdd && ParasCam1.BodyTopY < ParasCam1.BodyBottomY - 2)
            {
                if (!ccdLimit.YD(ref strInfo, Convert.ToInt32(LabTopYOffset.Text), Convert.ToInt32(LabBottomYOffset.Text)))
                {
                    ParasCam1.BodyTopYOffset += 2;
                    ParasCam1.BodyTopY = ParasCam1.SeedCenterY + ParasCam1.BodyTopYOffset;
                }
            }
            else if (BottomYSub && ParasCam1.BodyBottomY > ParasCam1.BodyTopY - 2)
            {
                if (!ccdLimit.YD(ref strInfo, Convert.ToInt32(LabTopYOffset.Text), Convert.ToInt32(LabBottomYOffset.Text)))
                {
                    ParasCam1.BodyBottomYOffset -= 2;
                    ParasCam1.BodyBottomY = ParasCam1.SeedCenterY + ParasCam1.BodyBottomYOffset;
                }
            }
            else if (BottomYAdd && ParasCam1.BodyBottomY < ParasCam1.Height - 2)
            {
                ParasCam1.BodyBottomYOffset += 2;
                ParasCam1.BodyBottomY = ParasCam1.SeedCenterY + ParasCam1.BodyBottomYOffset;
            }
            LabLeftXOffset.Text = ParasCam1.BodyLeftXOffset.ToString();
            LabRightXOffset.Text = ParasCam1.BodyRightXOffset.ToString();
            LabTopYOffset.Text = ParasCam1.BodyTopYOffset.ToString();
            LabBottomYOffset.Text = ParasCam1.BodyBottomYOffset.ToString();
            LabThreshold.Text = ParasCam1.BodyThreshold.ToString();
            LabBodyArrayNum.Text = ParasCam1.BodyArrayNum.ToString();
            BtnSave.Enabled = PLC.ReadStatus[2] != 1;
        }
    }
}