using CrystalGrowth.CrystalCtl;
using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction.CCD
{
    internal partial class FrmBodyTemp : Form
    {
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
        public FrmBodyTemp()
        {
            InitializeComponent();
            ccdLimit = new CCDDataLimit();
            Load += Timer1_Tick;
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnSave))
            {
                ParasCam2.WriteIn();
                Record.WriteIn("CCD引晶区域扫描线左X", LabLeftXOffset.Text, "Yellow");
                Record.WriteIn("CCD引晶区域扫描线右X", LabRightXOffset.Text, "Yellow");
                Record.WriteIn("CCD引晶区域上扫描线Y", LabTopYOffset.Text, "Yellow");
                Record.WriteIn("CCD引晶区域下扫描线Y", LabBottomYOffset.Text, "Yellow");
                Record.WriteIn("CCD引晶区域阈值", LabThreshold.Text, "Yellow");
                MessageBox.Show("保存成功！");
            }
        }
        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void LabLeftXOffset_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm
            {
                Location = new Point(400, 130)
            };
            kf.ImportData(ref LabLeftXOffset, -ParasCam2.SeedCenterX, 0);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                ParasCam2.NeckLeftXOffset = Convert.ToInt32(LabLeftXOffset.Text);
                ParasCam2.NeckLeftX = ParasCam2.SeedCenterX + ParasCam2.NeckLeftXOffset;
            }
        }
        private void BtnLeftXOffsetSub_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam2.NeckLeftX > 2)
            {
                ParasCam2.NeckLeftXOffset -= 2;
                ParasCam2.NeckLeftX = ParasCam2.SeedCenterX + ParasCam2.NeckLeftXOffset;
                LeftXSub = true;
            }
        }
        private void BtnLeftXOffsetSub_MouseUp(object sender, MouseEventArgs e)
        {
            LeftXSub = false;
        }
        private void BtnLeftXOffsetAdd_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam2.NeckLeftX < ParasCam2.NeckRightX - 2)
            {
                ParasCam2.NeckLeftXOffset += 2;
                ParasCam2.NeckLeftX = ParasCam2.SeedCenterX + ParasCam2.NeckLeftXOffset;
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
            kf.ImportData(ref LabRightXOffset, 0, ParasCam2.Width - ParasCam2.SeedCenterX);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                ParasCam2.NeckRightXOffset = Convert.ToInt32(LabRightXOffset.Text);
                ParasCam2.NeckRightX = ParasCam2.SeedCenterX + ParasCam2.NeckRightXOffset;
            }
        }
        private void BtnRightXOffsetSub_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam2.NeckRightX > ParasCam2.NeckLeftX + 2)
            {
                ParasCam2.NeckRightXOffset -= 2;
                ParasCam2.NeckRightX = ParasCam2.SeedCenterX + ParasCam2.NeckRightXOffset;
                RightXSub = true;
            }
        }
        private void BtnRightXOffsetSub_MouseUp(object sender, MouseEventArgs e)
        {
            RightXSub = false;
        }
        private void BtnRightXOffsetAdd_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam2.NeckRightX < ParasCam2.Width - 2)
            {
                ParasCam2.NeckRightXOffset += 2;
                ParasCam2.NeckRightX = ParasCam2.SeedCenterX + ParasCam2.NeckRightXOffset;
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
            kf.ImportData(ref LabTopYOffset, ParasCam2.SeedCenterY - ParasCam2.Height, ParasCam2.NeckBottomYOffset);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                if (ccdLimit.YNC(ref strInfo, Convert.ToInt32(LabTopYOffset.Text), Convert.ToInt32(LabBottomYOffset.Text)))
                {
                    LabTopYOffset.Text = ParasCam2.NeckTopYOffset.ToString();
                    LabDis.Text = strInfo;
                    return;
                }
                else
                {
                    LabDis.Text = strInfo;
                    ParasCam2.NeckTopYOffset = Convert.ToInt32(LabTopYOffset.Text);
                    ParasCam2.NeckTopY = ParasCam2.SeedCenterY + ParasCam2.NeckTopYOffset;
                }
            }
        }
        private void BtnTopYOffSetSub_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam2.NeckTopY > 2)
            {
                if (!ccdLimit.YNC(ref strInfo, Convert.ToInt32(LabTopYOffset.Text), Convert.ToInt32(LabBottomYOffset.Text) + 4))
                {
                    LabDis.Text = strInfo;
                    ParasCam2.NeckTopYOffset -= 2;
                    ParasCam2.NeckTopY = ParasCam2.SeedCenterY + ParasCam2.NeckTopYOffset;
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
            if (ParasCam2.NeckTopY < ParasCam2.NeckBottomY - 2)
            {
                if (ccdLimit.YNC(ref strInfo, Convert.ToInt32(LabTopYOffset.Text), Convert.ToInt32(LabBottomYOffset.Text)))
                {
                    LabTopYOffset.Text = ParasCam2.NeckTopYOffset.ToString();
                    LabDis.Text = strInfo;
                    return;
                }
                else
                {
                    LabDis.Text = strInfo;
                    ParasCam2.NeckTopYOffset += 2;
                    ParasCam2.NeckTopY = ParasCam2.SeedCenterY + ParasCam2.NeckTopYOffset;
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
            kf.ImportData(ref LabBottomYOffset, ParasCam2.NeckTopYOffset, ParasCam2.Height - ParasCam2.SeedCenterY);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                if (ccdLimit.YNC(ref strInfo, Convert.ToInt32(LabTopYOffset.Text), Convert.ToInt32(LabBottomYOffset.Text)))
                {
                    LabBottomYOffset.Text = ParasCam2.NeckBottomYOffset.ToString();
                    LabDis.Text = strInfo;
                    return;
                }
                else
                {
                    LabDis.Text = strInfo;
                    ParasCam2.NeckBottomYOffset = Convert.ToInt32(LabBottomYOffset.Text);
                    ParasCam2.NeckBottomY = ParasCam2.SeedCenterY + ParasCam2.NeckBottomYOffset;
                }
            }
        }
        private void BtnBottomYOffsetSub_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam2.NeckBottomY > ParasCam2.NeckTopY - 2)
            {
                if (ccdLimit.YNC(ref strInfo, Convert.ToInt32(LabTopYOffset.Text), Convert.ToInt32(LabBottomYOffset.Text)))
                {
                    LabBottomYOffset.Text = ParasCam2.NeckBottomYOffset.ToString();
                    LabDis.Text = strInfo;
                    return;
                }
                else
                {
                    LabDis.Text = strInfo;
                    ParasCam2.NeckBottomYOffset -= 2;
                    ParasCam2.NeckBottomY = ParasCam2.SeedCenterY + ParasCam2.NeckBottomYOffset;
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
            if (ParasCam2.NeckBottomY < ParasCam2.Height - 2)
            {
                if (!ccdLimit.YNC(ref strInfo, Convert.ToInt32(LabTopYOffset.Text), Convert.ToInt32(LabBottomYOffset.Text) + 4))
                {
                    LabDis.Text = strInfo;
                    ParasCam2.NeckBottomYOffset += 2;
                    ParasCam2.NeckBottomY = ParasCam2.SeedCenterY + ParasCam2.NeckBottomYOffset;
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
                ParasCam2.NeckThreshold = Convert.ToInt32(LabThreshold.Text);
            }
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (LeftXSub && ParasCam2.NeckLeftX > 2)
            {
                ParasCam2.NeckLeftXOffset -= 2;
                ParasCam2.NeckLeftX = ParasCam2.SeedCenterX + ParasCam2.NeckLeftXOffset;
            }
            else if (LeftXAdd && ParasCam2.NeckLeftX < ParasCam2.NeckRightX - 2)
            {
                ParasCam2.NeckLeftXOffset += 2;
                ParasCam2.NeckLeftX = ParasCam2.SeedCenterX + ParasCam2.NeckLeftXOffset;
            }
            else if (RightXSub && ParasCam2.NeckRightX > ParasCam2.NeckLeftX + 2)
            {
                ParasCam2.NeckRightXOffset -= 2;
                ParasCam2.NeckRightX = ParasCam2.SeedCenterX + ParasCam2.NeckRightXOffset;
            }
            else if (RightXAdd && ParasCam2.NeckRightX < ParasCam2.Width - 2)
            {
                ParasCam2.NeckRightXOffset += 2;
                ParasCam2.NeckRightX = ParasCam2.SeedCenterX + ParasCam2.NeckRightXOffset;
            }
            else if (TopYSub && ParasCam2.NeckTopY > 2)
            {
                ParasCam2.NeckTopYOffset -= 2;
                ParasCam2.NeckTopY = ParasCam2.SeedCenterY + ParasCam2.NeckTopYOffset;
            }
            else if (TopYAdd && ParasCam2.NeckTopY < ParasCam2.NeckBottomY - 2)
            {
                if (!ccdLimit.YNC(ref strInfo, Convert.ToInt32(LabTopYOffset.Text), Convert.ToInt32(LabBottomYOffset.Text)))
                {
                    ParasCam2.NeckTopYOffset += 2;
                    ParasCam2.NeckTopY = ParasCam2.SeedCenterY + ParasCam2.NeckTopYOffset;
                }
            }
            else if (BottomYSub && ParasCam2.NeckBottomY > ParasCam2.NeckTopY - 2)
            {
                if (!ccdLimit.YNC(ref strInfo, Convert.ToInt32(LabTopYOffset.Text), Convert.ToInt32(LabBottomYOffset.Text)))
                {
                    ParasCam2.NeckBottomYOffset -= 2;
                    ParasCam2.NeckBottomY = ParasCam2.SeedCenterY + ParasCam2.NeckBottomYOffset;
                }
            }
            else if (BottomYAdd && ParasCam2.NeckBottomY < ParasCam2.Height - 2)
            {
                ParasCam2.NeckBottomYOffset += 2;
                ParasCam2.NeckBottomY = ParasCam2.SeedCenterY + ParasCam2.NeckBottomYOffset;
            }
            LabLeftXOffset.Text = ParasCam2.NeckLeftXOffset.ToString();
            LabRightXOffset.Text = ParasCam2.NeckRightXOffset.ToString();
            LabTopYOffset.Text = ParasCam2.NeckTopYOffset.ToString();
            LabBottomYOffset.Text = ParasCam2.NeckBottomYOffset.ToString();
            LabThreshold.Text = ParasCam2.NeckThreshold.ToString();
        }
        private void FrmBodyTemp_Load(object sender, EventArgs e)
        {
            ParasCam2.ReadOut();
        }
        private void FrmBodyTemp_FormClosed(object sender, FormClosedEventArgs e)
        {
            ParasCam2.ReadOut();
        }
    }
}
