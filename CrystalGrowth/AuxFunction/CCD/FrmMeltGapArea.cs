using CrystalGrowth.CrystalCtl;
using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction.CCD
{
    internal partial class FrmMeltGapArea : Form
    {
        public static float AgreeMeltGap = 0;
        public static bool IsOpen = false;
        public static bool ManualCloseFlag = false;
        private bool LeftXSub = false;
        private bool LeftXAdd = false;
        private bool RightXSub = false;
        private bool RightXAdd = false;
        private bool LineYSub = false;
        private bool LineYAdd = false;
        public FrmMeltGapArea()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void FrmMeltGapArea_Load(object sender, EventArgs e)
        {
            ParasCam1.ReadOut();
            IsOpen = true;
        }
        private void FrmMeltGapArea_FormClosed(object sender, FormClosedEventArgs e)
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
                Record.WriteIn("CCD等径液口距区域扫描线左X", LabLeftXOffset.Text, "Yellow");
                Record.WriteIn("CCD等径液口距区域扫描线右X", LabRightXOffset.Text, "Yellow");
                Record.WriteIn("CCD等径液口距区域上扫描线Y", LabLineYOffset.Text, "Yellow");
                Record.WriteIn("CCD等径液口距区域阈值", LabThreshold.Text, "Yellow");
                MessageBox.Show("保存成功！");
            }
        }
        private void LabLeftXOffset_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm
            {
                Location = new Point(400, 130)
            };
            kf.ImportData(ref LabLeftXOffset, -ParasCam1.ShieldCenterX, ParasCam1.MeltGapRightXOffset);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                ParasCam1.MeltGapLeftXOffset = Convert.ToInt32(LabLeftXOffset.Text);
                ParasCam1.MeltGapLeftX = ParasCam1.ShieldCenterX + ParasCam1.MeltGapLeftXOffset;
            }
        }
        private void BtnLeftXOffsetSub_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam1.MeltGapLeftX > 2)
            {
                ParasCam1.MeltGapLeftXOffset -= 2;
                ParasCam1.MeltGapLeftX = ParasCam1.ShieldCenterX + ParasCam1.MeltGapLeftXOffset;
                LeftXSub = true;
            }
        }
        private void BtnLeftXOffsetSub_MouseUp(object sender, MouseEventArgs e)
        {
            LeftXSub = false;
        }
        private void BtnLeftXOffsetAdd_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam1.MeltGapLeftX < ParasCam1.MeltGapRightX - 2)
            {
                ParasCam1.MeltGapLeftXOffset += 2;
                ParasCam1.MeltGapLeftX = ParasCam1.ShieldCenterX + ParasCam1.MeltGapLeftXOffset;
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
            kf.ImportData(ref LabRightXOffset, ParasCam1.MeltGapLeftXOffset, ParasCam1.Width - ParasCam1.ShieldCenterX);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                ParasCam1.MeltGapRightXOffset = Convert.ToInt32(LabRightXOffset.Text);
                ParasCam1.MeltGapRightX = ParasCam1.ShieldCenterX + ParasCam1.MeltGapRightXOffset;
            }
        }
        private void BtnRightXOffsetSub_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam1.MeltGapRightX > ParasCam1.MeltGapLeftX + 2)
            {
                ParasCam1.MeltGapRightXOffset -= 2;
                ParasCam1.MeltGapRightX = ParasCam1.ShieldCenterX + ParasCam1.MeltGapRightXOffset;
                RightXSub = true;
            }
        }
        private void BtnRightXOffsetSub_MouseUp(object sender, MouseEventArgs e)
        {
            RightXSub = false;
        }
        private void BtnRightXOffsetAdd_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam1.MeltGapRightX < ParasCam1.Width - 2)
            {
                ParasCam1.MeltGapRightXOffset += 2;
                ParasCam1.MeltGapRightX = ParasCam1.ShieldCenterX + ParasCam1.MeltGapRightXOffset;
                RightXAdd = true;
            }
        }
        private void BtnRightXOffsetAdd_MouseUp(object sender, MouseEventArgs e)
        {
            RightXAdd = false;
        }
        private void LabLineYOffset_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm
            {
                Location = new Point(400, 130)
            };
            kf.ImportData(ref LabLineYOffset, -ParasCam1.ShieldCenterY, ParasCam1.Height - ParasCam1.ShieldCenterY - 50);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                ParasCam1.MeltGapLineYOffset = Convert.ToInt32(LabLineYOffset.Text);
                ParasCam1.MeltGapLineY = ParasCam1.ShieldCenterY + ParasCam1.MeltGapLineYOffset;
            }
        }
        private void BtnLineYOffsetSub_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam1.MeltGapLineY > 2)
            {
                ParasCam1.MeltGapLineYOffset -= 2;
                ParasCam1.MeltGapLineY = ParasCam1.ShieldCenterY + ParasCam1.MeltGapLineYOffset;
                LineYSub = true;
            }
        }
        private void BtnLineYOffsetSub_MouseUp(object sender, MouseEventArgs e)
        {
            LineYSub = false;
        }
        private void BtnLineYOffsetAdd_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam1.MeltGapLineY < ParasCam1.Height - 2)
            {
                ParasCam1.MeltGapLineYOffset += 2;
                ParasCam1.MeltGapLineY = ParasCam1.ShieldCenterY + ParasCam1.MeltGapLineYOffset;
                LineYAdd = true;
            }
        }
        private void BtnLineYOffsetAdd_MouseUp(object sender, MouseEventArgs e)
        {
            LineYAdd = false;
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
                ParasCam1.MeltGapThreshold = Convert.ToInt32(LabThreshold.Text);
            }
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (LeftXSub && ParasCam1.MeltGapLeftX > 2)
            {
                ParasCam1.MeltGapLeftXOffset -= 2;
                ParasCam1.MeltGapLeftX = ParasCam1.ShieldCenterX + ParasCam1.MeltGapLeftXOffset;
            }
            else if (LeftXAdd && ParasCam1.MeltGapLeftX < ParasCam1.MeltGapRightX - 2)
            {
                ParasCam1.MeltGapLeftXOffset += 2;
                ParasCam1.MeltGapLeftX = ParasCam1.ShieldCenterX + ParasCam1.MeltGapLeftXOffset;
            }
            else if (RightXSub && ParasCam1.MeltGapRightX > ParasCam1.MeltGapLeftX + 2)
            {
                ParasCam1.MeltGapRightXOffset -= 2;
                ParasCam1.MeltGapRightX = ParasCam1.ShieldCenterX + ParasCam1.MeltGapRightXOffset;
            }
            else if (RightXAdd && ParasCam1.MeltGapRightX < ParasCam1.Width - 2)
            {
                ParasCam1.MeltGapRightXOffset += 2;
                ParasCam1.MeltGapRightX = ParasCam1.ShieldCenterX + ParasCam1.MeltGapRightXOffset;
            }
            else if (LineYSub && ParasCam1.MeltGapLineY > 2)
            {
                ParasCam1.MeltGapLineYOffset -= 2;
                ParasCam1.MeltGapLineY = ParasCam1.ShieldCenterY + ParasCam1.MeltGapLineYOffset;
            }
            else if (LineYAdd && ParasCam1.MeltGapLineY < ParasCam1.Height - 2)
            {
                ParasCam1.MeltGapLineYOffset += 2;
                ParasCam1.MeltGapLineY = ParasCam1.ShieldCenterY + ParasCam1.MeltGapLineYOffset;
            }
            LabLeftXOffset.Text = ParasCam1.MeltGapLeftXOffset.ToString();
            LabRightXOffset.Text = ParasCam1.MeltGapRightXOffset.ToString();
            LabLineYOffset.Text = ParasCam1.MeltGapLineYOffset.ToString();
            LabThreshold.Text = ParasCam1.MeltGapThreshold.ToString();
            BtnSave.Enabled = PLC.ReadStatus[9] != 1;
        }
    }
}
