using CrystalGrowth.CrystalCtl;
using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction.CCD
{
    internal partial class FrmHArea : Form
    {
        private bool LeftXSub = false;
        private bool LeftXAdd = false;
        private bool RightXSub = false;
        private bool RightXAdd = false;
        private bool LineYSub = false;
        private bool LineYAdd = false;
        public FrmHArea()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnSave))
            {
                ParasCam1.WriteIn();
                Record.WriteIn("CCD H形区域扫描线左X", LabLeftXOffset.Text, "Yellow");
                Record.WriteIn("CCD H形区域扫描线右X", LabRightXOffset.Text, "Yellow");
                Record.WriteIn("CCD H形区域扫描线Y", LabLineYOffset.Text, "Yellow");
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
            kf.ImportData(ref LabLeftXOffset, -ParasCam1.ShieldCenterX, ParasCam1.HAreaRightXOffset);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                ParasCam1.HAreaLeftXOffset = Convert.ToInt32(LabLeftXOffset.Text);
                ParasCam1.HAreaLeftX = ParasCam1.ShieldCenterX + ParasCam1.HAreaLeftXOffset;
            }
        }
        private void BtnLeftXOffsetSub_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam1.HAreaLeftX > 2)
            {
                ParasCam1.HAreaLeftXOffset -= 2;
                ParasCam1.HAreaLeftX = ParasCam1.ShieldCenterX + ParasCam1.HAreaLeftXOffset;
                LeftXSub = true;
            }
        }
        private void BtnLeftXOffsetSub_MouseUp(object sender, MouseEventArgs e)
        {
            LeftXSub = false;
        }
        private void BtnLeftXOffsetAdd_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam1.HAreaLeftX < ParasCam1.HAreaRightX - 2)
            {
                ParasCam1.HAreaLeftXOffset += 2;
                ParasCam1.HAreaLeftX = ParasCam1.ShieldCenterX + ParasCam1.HAreaLeftXOffset;
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
            kf.ImportData(ref LabRightXOffset, ParasCam1.HAreaLeftXOffset, ParasCam1.Width - ParasCam1.ShieldCenterX);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                ParasCam1.HAreaRightXOffset = Convert.ToInt32(LabRightXOffset.Text);
                ParasCam1.HAreaRightX = ParasCam1.ShieldCenterX + ParasCam1.HAreaRightXOffset;
            }
        }
        private void BtnRightXOffsetSub_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam1.HAreaRightX > ParasCam1.HAreaLeftX + 2)
            {
                ParasCam1.HAreaRightXOffset -= 2;
                ParasCam1.HAreaRightX = ParasCam1.ShieldCenterX + ParasCam1.HAreaRightXOffset;
                RightXSub = true;
            }
        }
        private void BtnRightXOffsetSub_MouseUp(object sender, MouseEventArgs e)
        {
            RightXSub = false;
        }
        private void BtnRightXOffsetAdd_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam1.HAreaRightX < ParasCam1.Width - 2)
            {
                ParasCam1.HAreaRightXOffset += 2;
                ParasCam1.HAreaRightX = ParasCam1.ShieldCenterX + ParasCam1.HAreaRightXOffset;
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
                ParasCam1.HAreaLineYOffset = Convert.ToInt32(LabLineYOffset.Text);
                ParasCam1.HAreaLineY = ParasCam1.ShieldCenterY + ParasCam1.HAreaLineYOffset;
            }
        }
        private void BtnLineYOffsetSub_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam1.HAreaLineY > 2)
            {
                ParasCam1.HAreaLineYOffset -= 2;
                ParasCam1.HAreaLineY = ParasCam1.ShieldCenterY + ParasCam1.HAreaLineYOffset;
                LineYSub = true;
            }
        }
        private void BtnLineYOffsetSub_MouseUp(object sender, MouseEventArgs e)
        {
            LineYSub = false;
        }
        private void BtnLineYOffsetAdd_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam1.HAreaLineY < ParasCam1.Height - 2)
            {
                ParasCam1.HAreaLineYOffset += 2;
                ParasCam1.HAreaLineY = ParasCam1.ShieldCenterY + ParasCam1.HAreaLineYOffset;
                LineYAdd = true;
            }
        }
        private void BtnLineYOffsetAdd_MouseUp(object sender, MouseEventArgs e)
        {
            LineYAdd = false;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (LeftXSub && ParasCam1.HAreaLeftX > 2)
            {
                ParasCam1.HAreaLeftXOffset -= 2;
                ParasCam1.HAreaLeftX = ParasCam1.ShieldCenterX + ParasCam1.HAreaLeftXOffset;
            }
            else if (LeftXAdd && ParasCam1.HAreaLeftX < ParasCam1.HAreaRightX - 2)
            {
                ParasCam1.HAreaLeftXOffset += 2;
                ParasCam1.HAreaLeftX = ParasCam1.ShieldCenterX + ParasCam1.HAreaLeftXOffset;
            }
            else if (RightXSub && ParasCam1.HAreaRightX > ParasCam1.HAreaLeftX + 2)
            {
                ParasCam1.HAreaRightXOffset -= 2;
                ParasCam1.HAreaRightX = ParasCam1.ShieldCenterX + ParasCam1.HAreaRightXOffset;
            }
            else if (RightXAdd && ParasCam1.HAreaRightX < ParasCam1.Width - 2)
            {
                ParasCam1.HAreaRightXOffset += 2;
                ParasCam1.HAreaRightX = ParasCam1.ShieldCenterX + ParasCam1.HAreaRightXOffset;
            }
            else if (LineYSub && ParasCam1.HAreaLineY > 2)
            {
                ParasCam1.HAreaLineYOffset -= 2;
                ParasCam1.HAreaLineY = ParasCam1.ShieldCenterY + ParasCam1.HAreaLineYOffset;
            }
            else if (LineYAdd && ParasCam1.HAreaLineY < ParasCam1.Height - 2)
            {
                ParasCam1.HAreaLineYOffset += 2;
                ParasCam1.HAreaLineY = ParasCam1.ShieldCenterY + ParasCam1.HAreaLineYOffset;
            }
            LabLeftXOffset.Text = ParasCam1.HAreaLeftXOffset.ToString();
            LabRightXOffset.Text = ParasCam1.HAreaRightXOffset.ToString();
            LabLineYOffset.Text = ParasCam1.HAreaLineYOffset.ToString();
        }
        private void FrmHArea_Load(object sender, EventArgs e)
        {
            ParasCam1.ReadOut();
        }
        private void FrmHArea_FormClosed(object sender, FormClosedEventArgs e)
        {
            ParasCam1.ReadOut();
        }
    }
}
