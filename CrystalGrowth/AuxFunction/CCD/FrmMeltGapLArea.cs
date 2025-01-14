using CrystalGrowth.CrystalCtl;
using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction.CCD
{
    internal partial class FrmMeltGapLArea : Form
    {
        public static bool IsOpen = false;
        private bool LeftXSub = false;
        private bool LeftXAdd = false;
        private bool RightXSub = false;
        private bool RightXAdd = false;
        private bool LineYSub = false;
        private bool LineYAdd = false;


        /// <summary>
        /// 参数修改标志
        /// </summary>
        private bool modifyFlag = false;


        /// <summary>
        /// 参数可以修改标志
        /// </summary>
        private bool modifyEnable = false;




        public FrmMeltGapLArea()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void FrmMeltGapLArea_Load(object sender, EventArgs e)
        {
            ParasCam1.ReadOut();
            ParasCam1.MeltGapAbsMeasure_OffSet = FrmMain.GlobalParameter.MeltGapAbsMeasure_OffSet;
            ParasCam1.MeltGapAbsFilterNum = FrmMain.GlobalParameter.MeltGapAbsFilterNum;
            IsOpen = true;
        }
        private void FrmMeltGapLArea_FormClosed(object sender, FormClosedEventArgs e)
        {
            ParasCam1.ReadOut();
            ParasCam1.MeltGapAbsMeasure_OffSet = FrmMain.GlobalParameter.MeltGapAbsMeasure_OffSet;
            ParasCam1.MeltGapAbsFilterNum = FrmMain.GlobalParameter.MeltGapAbsFilterNum;
            IsOpen = false;
            Level.MeltGapLArea = false;
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
                FrmMain.GlobalParameter.MeltGapAbsMeasure_OffSet = ParasCam1.MeltGapAbsMeasure_OffSet;
                FrmMain.GlobalParameter.MeltGapAbsFilterNum = ParasCam1.MeltGapAbsFilterNum;

                Record.WriteIn("CCD液口距保护区域扫描线左X", LabLeftXOffset.Text, "Yellow");
                Record.WriteIn("CCD液口距保护区域扫描线右X", LabRightXOffset.Text, "Yellow");
                Record.WriteIn("CCD液口距保护区域上扫描线Y", LabLineYOffset.Text, "Yellow");
                Record.WriteIn("CCD液口距保护区域阈值", LabThreshold.Text, "Yellow");
                Record.WriteIn("绝对液口距偏移量", Lbl_OffSet.Text, "Yellow");
                Record.WriteIn("绝对液口距滤波长度", Lbl_FilterNum.Text, "Yellow");
                ModifyReset();
            }
        }

        private void LabLeftXOffset_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm
            {
                Location = new Point(400, 130)
            };
            kf.ImportData(ref LabLeftXOffset, -ParasCam1.ShieldCenterX, ParasCam1.MeltGapLongRightXOffset);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                ParasCam1.MeltGapLongLeftXOffset = Convert.ToInt32(LabLeftXOffset.Text);
                ParasCam1.MeltGapLongLeftX = ParasCam1.ShieldCenterX + ParasCam1.MeltGapLongLeftXOffset;
                Modify();
            }
        }
        private void BtnLeftXOffsetSub_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam1.MeltGapLongLeftX > 2)
            {
                ParasCam1.MeltGapLongLeftXOffset -= 2;
                ParasCam1.MeltGapLongLeftX = ParasCam1.ShieldCenterX + ParasCam1.MeltGapLongLeftXOffset;
                LeftXSub = true;
                Modify();
            }
        }
        private void BtnLeftXOffsetSub_MouseUp(object sender, MouseEventArgs e)
        {
            LeftXSub = false;
        }
        private void BtnLeftXOffsetAdd_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam1.MeltGapLongLeftX < ParasCam1.MeltGapLongRightX - 2)
            {
                ParasCam1.MeltGapLongLeftXOffset += 2;
                ParasCam1.MeltGapLongLeftX = ParasCam1.ShieldCenterX + ParasCam1.MeltGapLongLeftXOffset;
                LeftXAdd = true;
                Modify();
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
            kf.ImportData(ref LabRightXOffset, ParasCam1.MeltGapLongLeftXOffset, ParasCam1.Width - ParasCam1.ShieldCenterX);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                ParasCam1.MeltGapLongRightXOffset = Convert.ToInt32(LabRightXOffset.Text);
                ParasCam1.MeltGapLongRightX = ParasCam1.ShieldCenterX + ParasCam1.MeltGapLongRightXOffset;
                Modify();
            }
        }
        private void BtnRightXOffsetSub_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam1.MeltGapLongRightX > ParasCam1.MeltGapLongLeftX + 2)
            {
                ParasCam1.MeltGapLongRightXOffset -= 2;
                ParasCam1.MeltGapLongRightX = ParasCam1.ShieldCenterX + ParasCam1.MeltGapLongRightXOffset;
                RightXSub = true;
                Modify();
            }
        }
        private void BtnRightXOffsetSub_MouseUp(object sender, MouseEventArgs e)
        {
            RightXSub = false;
        }
        private void BtnRightXOffsetAdd_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam1.MeltGapLongRightX < ParasCam1.Width - 2)
            {
                ParasCam1.MeltGapLongRightXOffset += 2;
                ParasCam1.MeltGapLongRightX = ParasCam1.ShieldCenterX + ParasCam1.MeltGapLongRightXOffset;
                RightXAdd = true;
                Modify();
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
                Modify();
            }
        }
        private void BtnLineYOffsetSub_MouseDown(object sender, MouseEventArgs e)
        {
            if (ParasCam1.MeltGapLineY > 2)
            {
                ParasCam1.MeltGapLineYOffset -= 2;
                ParasCam1.MeltGapLineY = ParasCam1.ShieldCenterY + ParasCam1.MeltGapLineYOffset;
                LineYSub = true;
                Modify();
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
                Modify();
            }
        }
        private void BtnLineYOffsetAdd_MouseUp(object sender, MouseEventArgs e)
        {
            LineYAdd = false;
        }
        private void LabThreshold_Click(object sender, EventArgs e)
        {
            if (Level.MeltGapLArea)
            {
                KeyForm kf = new KeyForm
                {
                    Location = new Point(400, 130)
                };
                kf.ImportData(ref LabThreshold, 0, 255);
                kf.ShowDialog();
                ParasCam1.MeltGapLongThreshold = Convert.ToInt32(LabThreshold.Text);
                Modify();
            }
            else
            {
                MessageBox.Show("无设定值修改权限，或已过期需要再次获取权限！");
            }
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (LeftXSub && ParasCam1.MeltGapLongLeftX > 2)
            {
                ParasCam1.MeltGapLongLeftXOffset -= 2;
                ParasCam1.MeltGapLongLeftX = ParasCam1.ShieldCenterX + ParasCam1.MeltGapLongLeftXOffset;
            }
            else if (LeftXAdd && ParasCam1.MeltGapLongLeftX < ParasCam1.MeltGapLongRightX - 2)
            {
                ParasCam1.MeltGapLongLeftXOffset += 2;
                ParasCam1.MeltGapLongLeftX = ParasCam1.ShieldCenterX + ParasCam1.MeltGapLongLeftXOffset;
            }
            else if (RightXSub && ParasCam1.MeltGapLongRightX > ParasCam1.MeltGapLongLeftX + 2)
            {
                ParasCam1.MeltGapLongRightXOffset -= 2;
                ParasCam1.MeltGapLongRightX = ParasCam1.ShieldCenterX + ParasCam1.MeltGapLongRightXOffset;
            }
            else if (RightXAdd && ParasCam1.MeltGapLongRightX < ParasCam1.Width - 2)
            {
                ParasCam1.MeltGapLongRightXOffset += 2;
                ParasCam1.MeltGapLongRightX = ParasCam1.ShieldCenterX + ParasCam1.MeltGapLongRightXOffset;
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
            LabLeftXOffset.Text = ParasCam1.MeltGapLongLeftXOffset.ToString();
            LabRightXOffset.Text = ParasCam1.MeltGapLongRightXOffset.ToString();
            LabLineYOffset.Text = ParasCam1.MeltGapLineYOffset.ToString();
            LabThreshold.Text = ParasCam1.MeltGapLongThreshold.ToString();

            modifyEnable = PLC.ReadStatus[9] != 1;
            panel1.Enabled = modifyEnable;
            Panel2.Enabled = modifyEnable;
            Panel3.Enabled = modifyEnable;
            Lbl_OffSet.Enabled = modifyEnable;
            Lbl_FilterNum.Enabled = modifyEnable;

            

            Lbl_OffSet.Text = ParasCam1.MeltGapAbsMeasure_OffSet.ToString("f1");
            Lbl_FilterNum.Text = ParasCam1.MeltGapAbsFilterNum.ToString();

            if (IgAlgo1.MeltGapAbsMeasureManualStartFlag)
            {
                BtnMeltGapAbsOpen.BackColor = Color.Lime;
            }
            else
            {
                BtnMeltGapAbsOpen.BackColor = Color.RoyalBlue;
            }
            if (IgAlgo1.MeltGapAbsShowAreaFlag)
            {
                BtnShowArea.BackColor = Color.Lime;
            }
            else
            {
                BtnShowArea.BackColor = Color.RoyalBlue;
            }
            if (IgAlgo1.MeltGapAbsShowEllipseFlag)
            {
                BtnShowE.BackColor = Color.Lime;
            }
            else
            {
                BtnShowE.BackColor = Color.RoyalBlue;
            }
             //提醒内容修改，需要保存
            if (modifyFlag)
            {
                BtnSave.ForeColor = Color.Lime;
            }
            else
            {
                BtnSave.ForeColor = Color.White;
            }
        }



        /// <summary>
        /// 手动开启绝对液口距测量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMeltGapAbsOpen_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnMeltGapAbsOpen))
            {
                if (IgAlgo1.MeltGapAbsMeasureManualStartFlag)
                {
                    IgAlgo1.MeltGapAbsMeasureManualStartFlag = false;
                    BtnMeltGapAbsOpen.BackColor = Color.RoyalBlue;
                }
                else
                {
                    //清空缓存数据
                    IgAlgo1.MeltGapAbsArray.Clear();
                    IgAlgo1.MeltGapAbsOkArray.Clear();
                    IgAlgo1.MeltGapAbsOKNum = 0;

                    IgAlgo1.MeltGapAbsMeasureManualStartFlag = true;
                    BtnMeltGapAbsOpen.BackColor = Color.Lime;
                }

            }
        }

        /// <summary>
        /// 显示绝对液口距边缘点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnShowArea_Click(object sender, EventArgs e)
        {
            if (IgAlgo1.MeltGapAbsShowAreaFlag)
            {
                IgAlgo1.MeltGapAbsShowAreaFlag = false;
                BtnShowArea.BackColor = Color.RoyalBlue;
            }
            else
            {
                IgAlgo1.MeltGapAbsShowAreaFlag = true;
                BtnShowArea.BackColor = Color.Lime;
            }

        }
        /// <summary>
        /// 显示绝对液口距参考线
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnShowE_Click(object sender, EventArgs e)
        {
            if (IgAlgo1.MeltGapAbsShowEllipseFlag)
            {
                IgAlgo1.MeltGapAbsShowEllipseFlag = false;
                BtnShowE.BackColor = Color.RoyalBlue; 
            }
            else
            {
                IgAlgo1.MeltGapAbsShowEllipseFlag = true;
                BtnShowE.BackColor = Color.Lime;
            }
        }




        private void Lbl_OffSet_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm
            {
                Location = new Point(400, 130)
            };
            kf.ImportData(ref Lbl_OffSet, -50, 50);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                ParasCam1.MeltGapAbsMeasure_OffSet = Convert.ToSingle(Lbl_OffSet.Text);
                Modify();
            }

        }

        private void Lbl_FilterNum_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm
            {
                Location = new Point(400, 130)
            };
            kf.ImportData(ref Lbl_FilterNum, 5, 50);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                ParasCam1.MeltGapAbsFilterNum = Convert.ToInt32(Lbl_FilterNum.Text);
                Modify();
            }

        }


        private void Modify()
        {
            modifyFlag = true;
        }
        private void ModifyReset()
        {
            modifyFlag = false;
        }

        private void LabName_DoubleClick(object sender, EventArgs e)
        {
            BeginInvoke(new Action(() =>
            {
                if (panel1.Visible)
                {
                    panel1.Visible = false;
                }
                else
                {
                    FrmLevel frmLevel = new FrmLevel("SuperUser", "SuperUser");
                    frmLevel.ShowDialog();
                    if (frmLevel.DialogResult == DialogResult.OK)
                    {
                        panel1.Visible = true;
                    }
                }
            }));
        }

        
    }
}
