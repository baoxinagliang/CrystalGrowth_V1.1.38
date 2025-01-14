using CrystalGrowth.CrystalCtl;
using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction.CCD
{
    internal partial class FrmNeckArea : Form
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
        public FrmNeckArea()
        {
            InitializeComponent();
            ccdLimit = new CCDDataLimit();
            Load += Timer1_Tick;
        }
        private void FrmNeckArea_Load(object sender, EventArgs e)
        {
            ParasCam1.ReadOut();
            IsOpen = true;
        }
        private void FrmNeckArea_FormClosed(object sender, FormClosedEventArgs e)
        {
            ParasCam1.ReadOut();
            IsOpen = false;
        }
        private void BtnQuit_Click(object sender, EventArgs e)
        {
            //取消测量点
            FrmImage.DrawNeckMeasuredPointFlag = false;

            Close();
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnSave))
            {
                ParasCam1.WriteIn();
                Record.WriteIn("CCD引晶区域扫描线左X", LabLeftXOffset.Text, "Yellow");
                Record.WriteIn("CCD引晶区域扫描线右X", LabRightXOffset.Text, "Yellow");
                Record.WriteIn("CCD引晶区域上扫描线Y", LabTopYOffset.Text, "Yellow");
                Record.WriteIn("CCD引晶区域下扫描线Y", LabBottomYOffset.Text, "Yellow");
                Record.WriteIn("CCD引晶区域滤波值", LabNeckArrayNum.Text, "Yellow");
                Record.WriteIn("CCD引晶区域阈值", LabThreshold.Text, "Yellow");

                //清空测量点
                IgAlgo1.NeckDiaPointPtr = IntPtr.Zero;
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
                ParasCam1.NeckLeftXOffset = Convert.ToInt32(LabLeftXOffset.Text);
                ParasCam1.NeckLeftX = ParasCam1.SeedCenterX + ParasCam1.NeckLeftXOffset;
            }
        }
        private void BtnLeftXOffsetSub_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam1.NeckLeftX > 2)
            {
                ParasCam1.NeckLeftXOffset -= 2;
                ParasCam1.NeckLeftX = ParasCam1.SeedCenterX + ParasCam1.NeckLeftXOffset;
                LeftXSub = true;
            }
        }
        private void BtnLeftXOffsetSub_MouseUp(object sender, MouseEventArgs e)
        {
            LeftXSub = false;
        }
        private void BtnLeftXOffsetAdd_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam1.NeckLeftX < ParasCam1.NeckRightX - 2)
            {
                ParasCam1.NeckLeftXOffset += 2;
                ParasCam1.NeckLeftX = ParasCam1.SeedCenterX + ParasCam1.NeckLeftXOffset;
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
                ParasCam1.NeckRightXOffset = Convert.ToInt32(LabRightXOffset.Text);
                ParasCam1.NeckRightX = ParasCam1.SeedCenterX + ParasCam1.NeckRightXOffset;
            }
        }
        private void BtnRightXOffsetSub_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam1.NeckRightX > ParasCam1.NeckLeftX + 2)
            {
                ParasCam1.NeckRightXOffset -= 2;
                ParasCam1.NeckRightX = ParasCam1.SeedCenterX + ParasCam1.NeckRightXOffset;
                RightXSub = true;
            }
        }
        private void BtnRightXOffsetSub_MouseUp(object sender, MouseEventArgs e)
        {
            RightXSub = false;
        }
        private void BtnRightXOffsetAdd_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam1.NeckRightX < ParasCam1.Width - 2)
            {
                ParasCam1.NeckRightXOffset += 2;
                ParasCam1.NeckRightX = ParasCam1.SeedCenterX + ParasCam1.NeckRightXOffset;
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
            kf.ImportData(ref LabTopYOffset, ParasCam1.SeedCenterY - ParasCam1.Height, ParasCam1.NeckBottomYOffset);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                if (ccdLimit.YNC(ref strInfo, Convert.ToInt32(LabTopYOffset.Text), Convert.ToInt32(LabBottomYOffset.Text)))
                {
                    LabTopYOffset.Text = ParasCam1.NeckTopYOffset.ToString();
                    LabDis.Text = strInfo;
                    return;
                }
                else
                {
                    LabDis.Text = strInfo;
                    ParasCam1.NeckTopYOffset = Convert.ToInt32(LabTopYOffset.Text);
                    ParasCam1.NeckTopY = ParasCam1.SeedCenterY + ParasCam1.NeckTopYOffset;
                }
            }
        }
        private void LabTopYOffsetSub_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam1.NeckTopY > 2)
            {
                if (!ccdLimit.YNC(ref strInfo, Convert.ToInt32(LabTopYOffset.Text), Convert.ToInt32(LabBottomYOffset.Text) + 4))
                {
                    LabDis.Text = strInfo;
                    ParasCam1.NeckTopYOffset -= 2;
                    ParasCam1.NeckTopY = ParasCam1.SeedCenterY + ParasCam1.NeckTopYOffset;
                    TopYSub = true;
                }
            }
        }
        private void LabTopYOffsetSub_MouseUp(object sender, MouseEventArgs e)
        {
            TopYSub = false;
        }
        private void BtnTopYOffsetAdd_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam1.NeckTopY < ParasCam1.NeckBottomY - 2)
            {
                if (ccdLimit.YNC(ref strInfo, Convert.ToInt32(LabTopYOffset.Text), Convert.ToInt32(LabBottomYOffset.Text)))
                {
                    LabTopYOffset.Text = ParasCam1.NeckTopYOffset.ToString();
                    LabDis.Text = strInfo;
                    return;
                }
                else
                {
                    LabDis.Text = strInfo;
                    ParasCam1.NeckTopYOffset += 2;
                    ParasCam1.NeckTopY = ParasCam1.SeedCenterY + ParasCam1.NeckTopYOffset;
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
            kf.ImportData(ref LabBottomYOffset, ParasCam1.NeckTopYOffset, ParasCam1.Height - ParasCam1.SeedCenterY);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                if (ccdLimit.YNC(ref strInfo, Convert.ToInt32(LabTopYOffset.Text), Convert.ToInt32(LabBottomYOffset.Text)))
                {
                    LabBottomYOffset.Text = ParasCam1.NeckBottomYOffset.ToString();
                    LabDis.Text = strInfo;
                    return;
                }
                else
                {
                    LabDis.Text = strInfo;
                    ParasCam1.NeckBottomYOffset = Convert.ToInt32(LabBottomYOffset.Text);
                    ParasCam1.NeckBottomY = ParasCam1.SeedCenterY + ParasCam1.NeckBottomYOffset;
                }
            }
        }
        private void BtnBottomYOffsetSub_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam1.NeckBottomY > ParasCam1.NeckTopY - 2)
            {
                if (ccdLimit.YNC(ref strInfo, Convert.ToInt32(LabTopYOffset.Text), Convert.ToInt32(LabBottomYOffset.Text)))
                {
                    LabBottomYOffset.Text = ParasCam1.NeckBottomYOffset.ToString();
                    LabDis.Text = strInfo;
                    return;
                }
                else
                {
                    LabDis.Text = strInfo;
                    ParasCam1.NeckBottomYOffset -= 2;
                    ParasCam1.NeckBottomY = ParasCam1.SeedCenterY + ParasCam1.NeckBottomYOffset;
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
            if (ParasCam1.NeckBottomY < ParasCam1.Height - 2)
            {
                if (!ccdLimit.YNC(ref strInfo, Convert.ToInt32(LabTopYOffset.Text), Convert.ToInt32(LabBottomYOffset.Text) + 4))
                {
                    LabDis.Text = strInfo;
                    ParasCam1.NeckBottomYOffset += 2;
                    ParasCam1.NeckBottomY = ParasCam1.SeedCenterY + ParasCam1.NeckBottomYOffset;
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
                ParasCam1.NeckThreshold = Convert.ToInt32(LabThreshold.Text);
            }
        }

        private void LabNeckArrayNum_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm
            {
                Location = new Point(400, 130)
            };
            kf.ImportData(ref LabNeckArrayNum, 0.0f, 255.0f);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                ParasCam1.NeckArrayNum = Convert.ToInt32(LabNeckArrayNum.Text);
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (LeftXSub && ParasCam1.NeckLeftX > 2)
            {
                ParasCam1.NeckLeftXOffset -= 2;
                ParasCam1.NeckLeftX = ParasCam1.SeedCenterX + ParasCam1.NeckLeftXOffset;
            }
            else if (LeftXAdd && ParasCam1.NeckLeftX < ParasCam1.NeckRightX - 2)
            {
                ParasCam1.NeckLeftXOffset += 2;
                ParasCam1.NeckLeftX = ParasCam1.SeedCenterX + ParasCam1.NeckLeftXOffset;
            }
            else if (RightXSub && ParasCam1.NeckRightX > ParasCam1.NeckLeftX + 2)
            {
                ParasCam1.NeckRightXOffset -= 2;
                ParasCam1.NeckRightX = ParasCam1.SeedCenterX + ParasCam1.NeckRightXOffset;
            }
            else if (RightXAdd && ParasCam1.NeckRightX < ParasCam1.Width - 2)
            {
                ParasCam1.NeckRightXOffset += 2;
                ParasCam1.NeckRightX = ParasCam1.SeedCenterX + ParasCam1.NeckRightXOffset;
            }
            else if (TopYSub && ParasCam1.NeckTopY > 2)
            {
                ParasCam1.NeckTopYOffset -= 2;
                ParasCam1.NeckTopY = ParasCam1.SeedCenterY + ParasCam1.NeckTopYOffset;
            }
            else if (TopYAdd && ParasCam1.NeckTopY < ParasCam1.NeckBottomY - 2)
            {
                if (!ccdLimit.YNC(ref strInfo, Convert.ToInt32(LabTopYOffset.Text), Convert.ToInt32(LabBottomYOffset.Text)))
                {
                    ParasCam1.NeckTopYOffset += 2;
                    ParasCam1.NeckTopY = ParasCam1.SeedCenterY + ParasCam1.NeckTopYOffset;
                }
            }
            else if (BottomYSub && ParasCam1.NeckBottomY > ParasCam1.NeckTopY - 2)
            {
                if (!ccdLimit.YNC(ref strInfo, Convert.ToInt32(LabTopYOffset.Text), Convert.ToInt32(LabBottomYOffset.Text)))
                {
                    ParasCam1.NeckBottomYOffset -= 2;
                    ParasCam1.NeckBottomY = ParasCam1.SeedCenterY + ParasCam1.NeckBottomYOffset;
                }
            }
            else if (BottomYAdd && ParasCam1.NeckBottomY < ParasCam1.Height - 2)
            {
                ParasCam1.NeckBottomYOffset += 2;
                ParasCam1.NeckBottomY = ParasCam1.SeedCenterY + ParasCam1.NeckBottomYOffset;
            }
            LabLeftXOffset.Text = ParasCam1.NeckLeftXOffset.ToString();
            LabRightXOffset.Text = ParasCam1.NeckRightXOffset.ToString();
            LabTopYOffset.Text = ParasCam1.NeckTopYOffset.ToString();
            LabBottomYOffset.Text = ParasCam1.NeckBottomYOffset.ToString();
            LabThreshold.Text = ParasCam1.NeckThreshold.ToString();
            LabNeckArrayNum.Text = ParasCam1.NeckArrayNum.ToString();
            BtnSave.Enabled = PLC.ReadStatus[2] != 1;
        }
    }
}
