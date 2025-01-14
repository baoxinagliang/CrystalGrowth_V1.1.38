using CrystalGrowth.CrystalCtl;
using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction.CCD
{
    internal partial class FrmCrownArea : Form
    {
        public static bool IsOpen = false;
        private bool LeftXSub = false;
        private bool LeftXAdd = false;
        private bool RightXSub = false;
        private bool RightXAdd = false;
        private bool TopYSub = false;
        private bool TopYAdd = false;
        private bool BottomYSub = false;
        private bool BottomYAdd = false;
        string strInfo = "";
        CCDDataLimit ccdLimit;
        public FrmCrownArea()
        {
            InitializeComponent();
            ccdLimit = new CCDDataLimit();
            Load += Timer1_Tick;
        }
        private void FrmCrownArea_Load(object sender, EventArgs e)
        {
            ParasCam1.ReadOut();
            IsOpen = true;
        }
        private void FrmCrownArea_FormClosed(object sender, FormClosedEventArgs e)
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
                Record.WriteIn("CCD放肩区域扫描线左X", LabLeftXOffset.Text, "Yellow");
                Record.WriteIn("CCD放肩区域扫描线右X", LabRightXOffset.Text, "Yellow");
                Record.WriteIn("CCD放肩区域上扫描线Y", LabTopYOffset.Text, "Yellow");
                Record.WriteIn("CCD放肩区域下扫描线Y", LabBottomYOffset.Text, "Yellow");
                Record.WriteIn("CCD放肩区域滤波值", LabCrownArrayNum.Text, "Yellow");
                Record.WriteIn("CCD放肩区域阈值", LabThreshold.Text, "Yellow");
                MessageBox.Show("保存成功！");
            }
        }
        private void LabLeftXOffset_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm
            {
                Location = new Point(400, 130)
            };
            kf.ImportData(ref LabLeftXOffset, -ParasCam1.SeedCenterX, 0);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                ParasCam1.CrownLeftXOffset = Convert.ToInt32(LabLeftXOffset.Text);
                ParasCam1.CrownLeftX = ParasCam1.SeedCenterX + ParasCam1.CrownLeftXOffset;
            }
        }
        private void BtnLeftXOffsetSub_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam1.CrownLeftX > 2)
            {
                ParasCam1.CrownLeftXOffset -= 2;
                ParasCam1.CrownLeftX = ParasCam1.SeedCenterX + ParasCam1.CrownLeftXOffset;
                LeftXSub = true;
            }
        }
        private void BtnLeftXOffsetSub_MouseUp(object sender, MouseEventArgs e)
        {
            LeftXSub = false;
        }
        private void BtnLeftXOffsetAdd_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam1.CrownLeftX < ParasCam1.CrownRightX - 2)
            {
                ParasCam1.CrownLeftXOffset += 2;
                ParasCam1.CrownLeftX = ParasCam1.SeedCenterX + ParasCam1.CrownLeftXOffset;
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
                ParasCam1.CrownRightXOffset = Convert.ToInt32(LabRightXOffset.Text);
                ParasCam1.CrownRightX = ParasCam1.SeedCenterX + ParasCam1.CrownRightXOffset;
            }
        }
        private void BtnRightXOffsetSub_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam1.CrownRightX > ParasCam1.CrownLeftX + 2)
            {
                ParasCam1.CrownRightXOffset -= 2;
                ParasCam1.CrownRightX = ParasCam1.SeedCenterX + ParasCam1.CrownRightXOffset;
                RightXSub = true;
            }
        }
        private void BtnRightXOffsetSub_MouseUp(object sender, MouseEventArgs e)
        {
            RightXSub = false;
        }
        private void BtnRightXOffsetAdd_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam1.CrownRightX < ParasCam1.Width - 2)
            {
                ParasCam1.CrownRightXOffset += 2;
                ParasCam1.CrownRightX = ParasCam1.SeedCenterX + ParasCam1.CrownRightXOffset;
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
            kf.ImportData(ref LabTopYOffset, ParasCam1.SeedCenterY - ParasCam1.Height, ParasCam1.CrownBottomYOffset);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                if (ccdLimit.YNC(ref strInfo, Convert.ToInt32(LabTopYOffset.Text), Convert.ToInt32(LabBottomYOffset.Text)))
                {
                    LabTopYOffset.Text = ParasCam1.CrownTopYOffset.ToString();
                    LabDis.Text = strInfo;
                    return;
                }
                else
                {
                    LabDis.Text = strInfo;
                    ParasCam1.CrownTopYOffset = Convert.ToInt32(LabTopYOffset.Text);
                    ParasCam1.CrownTopY = ParasCam1.SeedCenterY + ParasCam1.CrownTopYOffset;
                }
            }
        }
        private void BtnTopYOffsetSub_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam1.CrownTopY > 2)
            {
                if (!ccdLimit.YNC(ref strInfo, Convert.ToInt32(LabTopYOffset.Text), Convert.ToInt32(LabBottomYOffset.Text) + 4))
                {
                    LabDis.Text = strInfo;
                    ParasCam1.CrownTopYOffset -= 2;
                    ParasCam1.CrownTopY = ParasCam1.SeedCenterY + ParasCam1.CrownTopYOffset;
                    TopYSub = true;
                }
            }
        }
        private void BtnTopYOffsetSub_MouseUp(object sender, MouseEventArgs e)
        {
            TopYSub = false;
        }
        private void BtnTopYOffsetAdd_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam1.CrownTopY < ParasCam1.CrownBottomY - 2)
            {
                if (ccdLimit.YNC(ref strInfo, Convert.ToInt32(LabTopYOffset.Text), Convert.ToInt32(LabBottomYOffset.Text)))
                {
                    LabTopYOffset.Text = ParasCam1.CrownTopYOffset.ToString();
                    LabDis.Text = strInfo;
                    return;
                }
                else
                {
                    LabDis.Text = strInfo;
                    ParasCam1.CrownTopYOffset += 2;
                    ParasCam1.CrownTopY = ParasCam1.SeedCenterY + ParasCam1.CrownTopYOffset;
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
            kf.ImportData(ref LabBottomYOffset, ParasCam1.CrownTopYOffset, ParasCam1.Height - ParasCam1.SeedCenterY);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                if (ccdLimit.YNC(ref strInfo, Convert.ToInt32(LabTopYOffset.Text), Convert.ToInt32(LabBottomYOffset.Text)))
                {
                    LabBottomYOffset.Text = ParasCam1.CrownBottomYOffset.ToString();
                    LabDis.Text = strInfo;
                    return;
                }
                else
                {
                    LabDis.Text = strInfo;
                    ParasCam1.CrownBottomYOffset = Convert.ToInt32(LabBottomYOffset.Text);
                    ParasCam1.CrownBottomY = ParasCam1.SeedCenterY + ParasCam1.CrownBottomYOffset;
                }
            }
        }
        private void BtnBottomYOffsetSub_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam1.CrownBottomY > ParasCam1.CrownTopY - 2)
            {
                if (ccdLimit.YNC(ref strInfo, Convert.ToInt32(LabTopYOffset.Text), Convert.ToInt32(LabBottomYOffset.Text)))
                {
                    LabBottomYOffset.Text = ParasCam1.CrownBottomYOffset.ToString();
                    LabDis.Text = strInfo;
                    return;
                }
                else
                {
                    LabDis.Text = strInfo;
                    ParasCam1.CrownBottomYOffset -= 2;
                    ParasCam1.CrownBottomY = ParasCam1.SeedCenterY + ParasCam1.CrownBottomYOffset;
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
            if (ParasCam1.CrownBottomY < ParasCam1.Height - 2)
            {
                if (!ccdLimit.YNC(ref strInfo, Convert.ToInt32(LabTopYOffset.Text), Convert.ToInt32(LabBottomYOffset.Text) + 4))
                {
                    LabDis.Text = strInfo;
                    ParasCam1.CrownBottomYOffset += 2;
                    ParasCam1.CrownBottomY = ParasCam1.SeedCenterY + ParasCam1.CrownBottomYOffset;
                    BottomYAdd = true;
                }
            }
        }
        private void BtnBottomYOffsetAdd_MouseUp(object sender, MouseEventArgs e)
        {
            BottomYAdd = false;
        }
        private void LabCrownArrayNum_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm
            {
                Location = new Point(400, 130)
            };
            kf.ImportData(ref LabCrownArrayNum, 0, 255);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                ParasCam1.CrownArrayNum = Convert.ToInt32(LabCrownArrayNum.Text);
            }
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
                ParasCam1.CrownThreshold = Convert.ToInt32(LabThreshold.Text);
            }
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (LeftXSub && ParasCam1.CrownLeftX > 2)
            {
                ParasCam1.CrownLeftXOffset -= 2;
                ParasCam1.CrownLeftX = ParasCam1.SeedCenterX + ParasCam1.CrownLeftXOffset;
            }
            else if (LeftXAdd && ParasCam1.CrownLeftX < ParasCam1.CrownRightX - 2)
            {
                ParasCam1.CrownLeftXOffset += 2;
                ParasCam1.CrownLeftX = ParasCam1.SeedCenterX + ParasCam1.CrownLeftXOffset;
            }
            else if (RightXSub && ParasCam1.CrownRightX > ParasCam1.CrownLeftX + 2)
            {
                ParasCam1.CrownRightXOffset -= 2;
                ParasCam1.CrownRightX = ParasCam1.SeedCenterX + ParasCam1.CrownRightXOffset;
            }
            else if (RightXAdd && ParasCam1.CrownRightX < ParasCam1.Width - 2)
            {
                ParasCam1.CrownRightXOffset += 2;
                ParasCam1.CrownRightX = ParasCam1.SeedCenterX + ParasCam1.CrownRightXOffset;
            }
            else if (TopYSub && ParasCam1.CrownTopY > 2)
            {
                ParasCam1.CrownTopYOffset -= 2;
                ParasCam1.CrownTopY = ParasCam1.SeedCenterY + ParasCam1.CrownTopYOffset;
            }
            else if (TopYAdd && ParasCam1.CrownTopY < ParasCam1.CrownBottomY - 2)
            {
                if (!ccdLimit.YNC(ref strInfo, Convert.ToInt32(LabTopYOffset.Text), Convert.ToInt32(LabBottomYOffset.Text)))
                {
                    ParasCam1.CrownTopYOffset += 2;
                    ParasCam1.CrownTopY = ParasCam1.SeedCenterY + ParasCam1.CrownTopYOffset;
                }
            }
            else if (BottomYSub && ParasCam1.CrownBottomY > ParasCam1.CrownTopY - 2)
            {
                if (!ccdLimit.YNC(ref strInfo, Convert.ToInt32(LabTopYOffset.Text), Convert.ToInt32(LabBottomYOffset.Text)))
                {
                    ParasCam1.CrownBottomYOffset -= 2;
                    ParasCam1.CrownBottomY = ParasCam1.SeedCenterY + ParasCam1.CrownBottomYOffset;
                }
            }
            else if (BottomYAdd && ParasCam1.CrownBottomY < ParasCam1.Height - 2)
            {
                ParasCam1.CrownBottomYOffset += 2;
                ParasCam1.CrownBottomY = ParasCam1.SeedCenterY + ParasCam1.CrownBottomYOffset;
            }
            LabLeftXOffset.Text = ParasCam1.CrownLeftXOffset.ToString();
            LabRightXOffset.Text = ParasCam1.CrownRightXOffset.ToString();
            LabTopYOffset.Text = ParasCam1.CrownTopYOffset.ToString();
            LabBottomYOffset.Text = ParasCam1.CrownBottomYOffset.ToString();
            LabThreshold.Text = ParasCam1.CrownThreshold.ToString();
            LabCrownArrayNum.Text = ParasCam1.CrownArrayNum.ToString();
        }
    }
}