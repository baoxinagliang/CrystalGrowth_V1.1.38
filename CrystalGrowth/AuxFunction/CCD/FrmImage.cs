﻿using CamLibrary;
using CrystalGrowth.CrystalCtl;
using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction.CCD
{
    internal partial class FrmImage : Form
    {
        public static double AbsMeltDist = 0;
        /// <summary>
        /// 拟合法绝对液口距
        /// </summary>
        public static double AbsMeltGapAvg = 0;
        public static bool PnlZoom2 = false;
        //static bool MsgFlag1 = false, MsgFlag2 = false;
        static float PLCModeCnt, ChangeMode, ChangeGapMode;
        static int DiaErrCnt, MeltGapErrorCount, MeltCheckCount;
        //static Point MovePoint;
        static Size sizeValue1, sizeValue2;
        /// <summary>
        /// 画引晶测量点 标志位
        /// </summary>
        public static bool DrawNeckMeasuredPointFlag = false;
        public static bool IsNeedSaveImg = true;
        public static int TmpCount = 0;
        public static float LastAutoStatus = 100;
        public static Size SizeValue1
        {
            set
            {
                sizeValue1 = value;
                Single.panel1.Size = sizeValue1;
                CamUnity.PZoom1.ZoomRange = false;
                Single.panel1.BackgroundImage = CreateBtmp(ref sizeValue1);
                CamUnity.PZoom1.g = Graphics.FromImage(Single.panel1.BackgroundImage);
                CamUnity.PZoom1.Change(sizeValue1, new Size(ParasCam1.Width, ParasCam1.Height), new Point(ParasCam1.SeedCenterX, ParasCam1.SeedCenterY));
                Single.panel3.Location = new Point(Single.panel1.Width - Single.panel3.Width, 0);
                Single.panel5.Location = new Point(Single.panel1.Width - Single.panel5.Width, Single.panel1.Height - Single.panel5.Height);
            }
        }
        private static Size SizeValue2
        {
            set
            {
                sizeValue2 = value;
                Single.panel2.Size = sizeValue2;
                CamUnity.PZoom2.ZoomRange = false;
                Single.panel2.BackgroundImage = CreateBtmp(ref sizeValue2);
                CamUnity.PZoom2.g = Graphics.FromImage(Single.panel2.BackgroundImage);
                CamUnity.PZoom2.Change(sizeValue2, new Size(ParasCam2.Width, ParasCam2.Height), new Point(ParasCam2.SeedCenterX, ParasCam2.SeedCenterY));
            }
        }
        private static Bitmap CreateBtmp(ref Size size)
        {
            Bitmap bmp = new Bitmap(size.Width, size.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                SolidBrush b = new SolidBrush(Color.Black);//这里修改颜色
                g.FillRectangle(b, 0, 0, size.Width, size.Height);
            }
            return bmp;
        }
        public static void SizeValue2Change()
        {
            if (DualCam.DoubleCam == "2")
            {
                if (FrmCCD.IsOpen)
                {
                    Single.panel2.Location = new Point(654, 0);
                    SizeValue2 = new Size(316, 230);
                }
                else
                {
                    Single.panel2.Location = new Point(491, 0);
                    SizeValue2 = new Size(158, 115);
                }
            }
        }
        public FrmImage()
        {
            InitializeComponent();
            LblDraw1.Parent = panel1;
            LblDraw1.Dock = DockStyle.Fill;
            if (DualCam.DoubleCam == "2")
            {
                LblDraw2.Parent = panel2;
                LblDraw2.Dock = DockStyle.Fill;
            }
            else
            {
                panel2.Visible = false;
                LblDraw2.Visible = false;
            }
            Mode.Current = Mode.Idle;

            ShowBottomTxt(0);


        }
        public static FrmImage Single;
        public static FrmImage CreateInstance()
        {
            if (Single == null)
            {
                Single = new FrmImage();
                Single.FormClosed += Single_FormClosed;
                SizeValue1 = new Size(650, 475);
                SizeValue2Change();
            }
            return Single;
        }
        static void Single_FormClosed(object sender, FormClosedEventArgs e)
        {
            Single = null;
        }
        public static void RefreshPic1()
        {
            Single.panel1.Invalidate();
        }
        public static void RefreshPic2()
        {
            Single.panel2.Invalidate();
        }
        private void LblDraw1_MouseMove(object sender, MouseEventArgs e)
        {
            //if (FrmCCD.IsOpen && Cursor == Cursors.Hand)
            //{
            //    MovePoint.X = e.X;
            //    MovePoint.Y = e.Y;
            //    MGpMove1.Move(ref MovePoint);
            //    Single.panel1.Invalidate();
            //}
        }
        private void LblDraw2_MouseMove(object sender, MouseEventArgs e)
        {
            //if (FrmCCD.IsOpen && Cursor == Cursors.Hand)
            //{
            //    MovePoint.X = e.X;
            //    MovePoint.Y = e.Y;
            //    MGpMove2.Move(ref MovePoint);
            //    Single.panel2.Invalidate();
            //}
        }
        private void LblDraw1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //if (FrmCCD.IsOpen)
            //{
            //    if (Cursor == Cursors.Hand)
            //    {
            //        MsgFlag1 = true;
            //        if (MessageBox.Show("是否保存移动后的参数？", "安全提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //        {
            //            ParasCam1.WriteIn();
            //        }
            //        else
            //        {
            //            ParasCam1.ReadOut();
            //        }
            //        MGpMove1.Init();
            //        Cursor = Cursors.Arrow;
            //        IgAlgo1.Cursor = false;
            //    }
            //    else
            //    {
            //        MsgFlag1 = false;
            //        MGpBasic.RangeSize = LblDraw1.Size;
            //        MGpMove1.MousePoint = new Point(e.X, e.Y);
            //        Paras1.MouseNewRect();
            //        if (MGpMove1.VarJuage())
            //        {
            //            Cursor = Cursors.Hand;
            //            IgAlgo1.Cursor = true;
            //        }
            //    }
            //}
        }
        private void LblDraw2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //if (FrmCCD.IsOpen && PnlZoom2 && FrmCCD.MouseLock)
            //{
            //    if (Cursor == Cursors.Hand)
            //    {
            //        MsgFlag2 = true;
            //        if (MessageBox.Show("是否保存移动后的参数？", "安全提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //        {
            //            ParasCam2.WriteIn();
            //        }
            //        else
            //        {
            //            ParasCam2.ReadOut();
            //        }
            //        MGpMove2.Init();
            //        Cursor = Cursors.Arrow;
            //        IgAlgo2.Cursor = false;
            //    }
            //    else
            //    {
            //        MsgFlag2 = false;
            //        MGpBasic.RangeSize = LblDraw2.Size;
            //        MGpMove2.MousePoint = new Point(e.X, e.Y);
            //        Paras2.MouseNewRect();
            //        if (MGpMove2.VarJuage())
            //        {
            //            Cursor = Cursors.Hand;
            //            IgAlgo2.Cursor = true;
            //        }
            //    }
            //}
        }
        private void LblDraw1_MouseLeave(object sender, EventArgs e)
        {
            //if (!MsgFlag1 && Cursor == Cursors.Hand)
            //{
            //    Cursor = Cursors.Arrow;
            //    IgAlgo1.Cursor = false;
            //    MGpMove1.Init();
            //    ParasCam1.ReadOut();
            //}
        }
        private void LblDraw2_MouseLeave(object sender, EventArgs e)
        {
            //if (!MsgFlag2 && Cursor == Cursors.Hand)
            //{
            //    Cursor = Cursors.Arrow;
            //    IgAlgo2.Cursor = false;
            //    MGpMove2.Init();
            //    ParasCam2.ReadOut();
            //}
        }
        private void LblDraw1_Paint(object sender, PaintEventArgs e)
        {
            Paras1.g = e.Graphics;
            ParasBasic.DrawXLine(ref Paras1.g, ref sizeValue1, ref FrmCCD.DrawX1);
            ParasBasic.DrawCrossLine(ref Paras1.g, ref sizeValue1, ref FrmCCD.DrawCrossLine);
            Paras1.CalcBasicData(ref CamUnity.PZoom1.Scale);
            switch (Mode.Current)
            {
                case 1:
                    //Paras1.DrawNeck(ref CamUnity.PZoom1.Scale);
                    Paras1.DrawNeckFitCircle(ref CamUnity.PZoom1.Scale);
                    break;
                case 2:
                    Paras1.DrawCrown(ref CamUnity.PZoom1.Scale);
                    break;
                case 3:
                    Paras1.DrawBody(ref CamUnity.PZoom1.Scale);
                    if (FrmCutLineCheck.IsStart)
                    {
                        Paras1.DrawCutLineCheck(ref CamUnity.PZoom1.Scale);
                    }
                    break;
            }
            if (Mode.MeltGapFlag)
            {
                if (FrmMeltGapLArea.IsOpen)
                {
                    Paras1.DrawMeltGapLong(ref CamUnity.PZoom1.Scale);
                }
                else
                {
                    Paras1.DrawMeltGap(ref CamUnity.PZoom1.Scale);
                }
            }
            else
            {
                if (FrmMeltGapArea.IsOpen)
                {
                    Paras1.DrawMeltGap(ref CamUnity.PZoom1.Scale);
                }
                else
                {
                    Paras1.DrawMeltGapLong(ref CamUnity.PZoom1.Scale);
                }
            }
            if (FrmMeltTemp.PreTempRunningFlag)
            {
                Paras1.DrawPreTemp(ref CamUnity.PZoom1.Scale);
            }
            else
            {
                Paras1.DrawBright(ref CamUnity.PZoom1.Scale);
            }
            if (FrmShieldMeasure.StartFlag)
            {
                Paras1.DrawShieldMeasure(ref CamUnity.PZoom1.Scale);
            }

            if (IgAlgo1.MeltGapAbsMeasureManualStartFlag || IgAlgo1.MeltGapAbsMeasureAutoStartFlag)
            {//绝对液口距绘制
                if (IgAlgo1.MeltGapAbsShowAreaFlag)
                {
                    Paras1.DrawMeltGapAbsArea(ref CamUnity.PZoom1.Scale);
                }
                if (IgAlgo1.MeltGapAbsShowEllipseFlag)
                {
                    Paras1.DrawMeltGapAbs(ref CamUnity.PZoom1.Scale);
                }
            }
        }
        private void LblDraw2_Paint(object sender, PaintEventArgs e)
        {
            Paras2.g = e.Graphics;
            Paras2.CalcBasicData(ref CamUnity.PZoom2.Scale);
            ParasBasic.DrawXLine(ref Paras2.g, ref sizeValue2, ref FrmCCD.DrawX2);
            if (Mode.Current == 1)//等径
            {
                Paras2.DrawNeck(ref CamUnity.PZoom2.Scale);
            }
        }
        private void LblDraw1_DoubleClick(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmCCD"] == null && FrmVarTable.Single.SafeProtectOn == false)
            {
                Hide();
                FrmMeltGapPopUp.Visible1 = false;
                FrmSwitch.Open(FrmVarTable.Single, 0, new Point(638, 200), new Size(636, 485));
                FrmVarTable.Single.Visible = true;
            }
        }
        private void LblDraw2_DoubleClick(object sender, EventArgs e)
        {
            if (FrmCCD.MouseLock == false)
            {
                if (PnlZoom2)
                {
                    Size sz = FrmCCD.IsOpen ? new Size(316, 230) : new Size(158, 115);
                    SizeValue2 = sz;
                    panel2.Location = FrmCCD.IsOpen ? new Point(654, 0) : new Point(491, 0);
                    PnlZoom2 = false;
                }
                else
                {
                    Size sz = panel1.Size;
                    SizeValue2 = sz;
                    panel2.Location = panel1.Location;
                    PnlZoom2 = true;
                }
            }
        }
        private void Timer2_Tick(object sender, EventArgs e)
        {
            LabFinalDia.Text = Math.Round(PLC.ReadValue[7], 2).ToString("f2");//实际直径值mm
            //LabFinalDiaPixel.Text = Math.Round(PLCConn.ReadOthersValue[1] * CameraParas.FocalLength / CameraParas.PixelSize, 2).ToString("f2");
            LabRealDiaPixel.Text = Math.Round(IgAlgo1.PixelDiameter, 2).ToString("f2");//实际直径像素值
            LabFinalMeltGap.Text = Math.Round(PLC.ReadValue[41], 1).ToString("f1");
            LabMeltTemp.Text = Math.Round(PLC.ReadValue[32], 1).ToString("f1");
            LabPixlAvg.Text = Math.Round(IgAlgo1.BrightValue, 1).ToString("f1");
            LabPixlRt.Text = Math.Round(IgAlgo1.BrightRTimeValue, 1).ToString("f1");
            //LabLaser.Text = Math.Round(PLCConn.ReadAnalogValue[30], 1).ToString("f1");
            //绝对液口距测量
            //IgAlgo1.PixelLongMeltGap长液口滤波值，ParasCam1.CameraAngle相机与软轴夹角， ParasCam1.AbsoluteMeltGapRate绝对液口距校准值
            if (ParasCam1.ShieldDiafac != 0 && ParasCam1.CameraAngle + ParasCam1.AbsoluteMeltGapRate != 0)
            {
                //
                AbsMeltDist = Math.Round(IgAlgo1.PixelLongMeltGap * ParasCam1.ShieldCorrectCoef /
                    ParasCam1.ShieldDiafac / Math.Tan((ParasCam1.CameraAngle + ParasCam1.AbsoluteMeltGapRate) *
                    Math.PI / 180) + ParasCam1.AbsoluteMeltGapOffset, 1);
                LabLaser.Text = AbsMeltDist.ToString("f1");
            }
            LabShortMeltGapPxl.Text = Math.Round(IgAlgo1.PixelShortMeltGap, 1).ToString("f1");
            LabMiddleMeltGapPxl.Text = Math.Round(IgAlgo1.PixelMiddleMeltGap, 1).ToString("f1");
            LabLongMeltGapPxl.Text = Math.Round(IgAlgo1.PixelLongMeltGap, 1).ToString("f1");
            LabYPos.Text = ParasCam1.MeltGapLineYOffset.ToString();
            LabGrowthSpeed.Text = Math.Round(PLC.ReadValue[16], 1).ToString("f1");
            LabSL.Text = Math.Round(PLC.ReadValue[49], 1).ToString("f1");
            LabCutLineProp.Text = string.Concat((Math.Round(FrmCutLineCheck.Probability, 3) * 100).ToString("f1"), "%");
            LabCrystalShake.Text = Math.Round(FrmCrystalShake.Value, 1).ToString("f1");
            MeltCheckCount++;
            if (MeltCheckCount >= 12) { MeltCheckCount = 0; }
            if (MeltCheckCount == 0 && FrmMeltCheckArea.CheckFlag)
            {
                IgAlgo1.MeltingCheck();
            }
            if (DualCam.DoubleCam == "2")
            {
                if ((Avt.IsConn2 || Basler.IsConn2 || Hik.IsConn2 || Huaray.IsConn2) && CamUnity.Ptr2 != IntPtr.Zero)
                {
                    switch (Mode.Current)
                    {
                        case 1:
                            IgAlgo2.NeckMeasure();
                            break;
                    }
                }
                else
                {
                    RefreshPic2();
                }
            }

            if (IgAlgo1.MeltGapAbsMeasureAutoStartFlag || IgAlgo1.MeltGapAbsMeasureManualStartFlag)
            {//绝对液口距测量
                ShowBottomTxt(7);
            }
            else
            {
                ShowBottomTxt(0);
            }
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (PLC.IsConn) //PLC模式变化
            {
                if (PLCModeCnt < 10)
                {
                    PLCModeCnt++;
                }
                else
                {
                    if (PLC.ReadOthersValue[3] != ChangeMode)
                    {
                        Mode.Current = (int)PLC.ReadOthersValue[3];

                    }
                    if (PLC.ReadOthersValue[12] != ChangeGapMode)
                    {
                        FrmMeltGapArea.AgreeMeltGap = PLC.ReadOthersValue[12];
                    }
                }
            }
            else
            {
                PLCModeCnt = 10;
            }
            //模式改变初始化
            if (Mode.Current != ChangeMode)
            {
                ChangeMode = Mode.Current;
                PLC.SendFloat(31, 8, Mode.Current);
                PLCModeCnt = 0;
                DiaErrCnt = 0;
                Alarm.AlgoCalcuError = false;
                Alarm.CutLineError = false;
                IgAlgo1.FilterArray.Clear();
            }
            if (FrmMeltGapArea.AgreeMeltGap != ChangeGapMode)
            {
                ChangeGapMode = FrmMeltGapArea.AgreeMeltGap;
                PLC.SendFloat(31, 44, FrmMeltGapArea.AgreeMeltGap);
                PLCModeCnt = 0;
                MeltGapErrorCount = 0;
                IgAlgo1.InitMeltGapParas();
            }
            //采集图像
            if ((Avt.IsConn1 || Basler.IsConn1 || Hik.IsConn1 || Huaray.IsConn1 || VirtualCamera.IsConn1) && CamUnity.Ptr1 != IntPtr.Zero)
            {
                if (CamUnity.PicSize1.Width == ParasCam1.Width && CamUnity.PicSize1.Height == ParasCam1.Height)
                {
                    // 全工序存图判断
                    if (IsNeedSaveImg && TmpCount >= ParasCam1.SaveInterval && FrmCam1SavePic.IsSaveFullImg && FrmCam1SavePic.FullSaveDic[PLC.ReadValue[1]])
                    {

                        SaveImgAsync(CamUnity.Ptr1, ParasCam1.Width, ParasCam1.Height, false);
                        TmpCount = 0;
                    }
                    else if (IsNeedSaveImg && TmpCount < ParasCam1.SaveInterval && FrmCam1SavePic.IsSaveFullImg)
                    {
                        TmpCount++;
                    }
                    else
                    {
                        TmpCount = 0;
                    }

                    // 避免第一次误触发
                    if (LastAutoStatus == 100)
                    {
                        LastAutoStatus = PLC.ReadValue[1];
                    }
                    else if (LastAutoStatus != PLC.ReadValue[1])
                    {
                        if (IsNeedSaveImg && FrmCam1SavePic.IsSaveJumpImg && FrmCam1SavePic.JumpSaveDic[PLC.ReadValue[1]])
                        {


                            SaveImgAsync(CamUnity.Ptr1, ParasCam1.Width, ParasCam1.Height, true);
                        }
                    }
                    LastAutoStatus = PLC.ReadValue[1];

                    IgAlgo1.ShakeCheck();
                    IgAlgo1.ThresholdCalc();
                    IgAlgo1.BrightMeasure();
                    if (FrmShieldMeasure.StartFlag) { IgAlgo1.ShieldMeasure(); }
                    if (FrmMeltGapArea.IsOpen) { IgAlgo1.MeltGapMeasure(); }
                    if (FrmMeltGapLArea.IsOpen) { IgAlgo1.MeltGapLongMeasure(); }
                    if (IgAlgo1.MeltGapAbsMeasureAutoStartFlag || IgAlgo1.MeltGapAbsMeasureManualStartFlag)
                    {
                        IgAlgo1.MeltGapAbsMeasure();
                    }
                    else
                    {//未开始检测
                        IgAlgo1.YKJInfo.index = -1;
                    }

                    CutLineCheckInit();
                    switch (Mode.Current)
                    {
                        case 0:
                            FrmMain.Single.LabCameraStatus.Text = "相机-空闲模式";
                            break;
                        case 1:
                            FrmMain.Single.LabCameraStatus.Text = "相机-引晶模式";
                            DiaErrCnt = IgAlgo1.NeckMeasureFitCircle() ? 0 : ++DiaErrCnt;
                            break;
                        case 2:
                            FrmMain.Single.LabCameraStatus.Text = "相机-放肩模式";
                            DiaErrCnt = IgAlgo1.CrownMeasure() ? 0 : ++DiaErrCnt;
                            break;
                        case 3:
                            FrmMain.Single.LabCameraStatus.Text = "相机-等径模式";
                            DiaErrCnt = IgAlgo1.BodyMeasure() ? 0 : ++DiaErrCnt;
                            break;
                    }
                    if (DiaErrCnt == 0)
                    {
                        Alarm.AlgoCalcuError = false;
                    }
                    else if (DiaErrCnt > 5)
                    {
                        Alarm.AlgoCalcuError = true;
                    }
                    //8预热熔接 9调温 10引晶 11放肩 12转肩 13等径 14收尾 20取段冷却-液口距自动
                    if (PLC.ReadValue[1] == 8 || PLC.ReadValue[1] == 9 || PLC.ReadValue[1] == 10 || PLC.ReadValue[1] == 11 ||
                        PLC.ReadValue[1] == 12 || PLC.ReadValue[1] == 13 || PLC.ReadValue[1] == 14 || PLC.ReadValue[1] == 20)
                    {
                        Mode.MeltGapFlag = true;
                        if (FrmMeltGapArea.AgreeMeltGap == 0)
                        {
                            IgAlgo1.InitMeltGapParas();
                        }
                        else
                        {
                            if (IgAlgo1.MeltGapMeasure() == 0)
                            {
                                TriggerMeltGapError(false);
                            }
                            else
                            {
                                MeltGapErrorCount++;
                                if (MeltGapErrorCount > 10)
                                {
                                    TriggerMeltGapError(true);
                                }
                            }
                        }
                    }
                    else//液口距手动
                    {
                        Mode.MeltGapFlag = false;
                        if (FrmMeltGapArea.ManualCloseFlag == false)
                        {
                            FrmMeltGapArea.AgreeMeltGap = 1;
                            if (IgAlgo1.MeltGapLongMeasure() == 0)
                            {
                                TriggerMeltGapError(false);
                            }
                            else
                            {
                                MeltGapErrorCount++;
                                if (MeltGapErrorCount > 300)
                                {
                                    TriggerMeltGapError(true);
                                }
                            }
                        }
                        else
                        {
                            FrmMeltGapArea.AgreeMeltGap = 0;
                            IgAlgo1.InitMeltGapParas();
                        }
                    }
                }
            }
            else
            {
                FrmMain.Single.LabCameraStatus.Text = "相机-断开连接！";
                IgAlgo1.InitMeasureParas();
                RefreshPic1();
            }
            Mode.Last = Mode.Current;
        }
        private void CutLineCheckInit()
        {
            if (Mode.Body != Mode.Current) { FrmCutLineCheck.InitParas(); }
        }
        /// <summary>
        /// 触发液口距错误
        /// </summary>
        /// <param name="sign">是否触发错误</param>
        private static void TriggerMeltGapError(bool Flag)
        {
            if (Flag)
            {
                if (PLC.StatusAlarm[545] == 0)
                {
                    PLC.SendBit(36, 544, 1);
                }
                MeltGapErrorCount = 0;
                FrmMeltGapPopUp.Visible1 = true;
            }
            else
            {
                if (PLC.StatusAlarm[545] == 1)
                {
                    PLC.SendBit(36, 544, 0);
                }
                MeltGapErrorCount = 0;
                FrmMeltGapPopUp.Visible1 = false;
            }
        }

        private void ShowBottomTxt(int model)
        {
            if (model == 0)
            {
                panel3.Visible = false;
                return;
            }
            else
            {
                panel3.Visible = true;
            }


            AbsMeltGapAvg = model == 7 ? (IgAlgo1.MeltGapAbsAvgValue + ParasCam1.MeltGapAbsMeasure_OffSet) : 0;

            switch (model)
            {
                case 0:
                    panel3.Height = 4 + 18 * 0;
                    LabGeneral1.Visible = false;
                    LabGeneral2.Visible = false;
                    LabGeneral3.Visible = false;
                    LabGeneral4.Visible = false;
                    LabGeneral5.Visible = false;
                    LabGeneral6.Visible = false;
                    LabGeneral1.ForeColor = Color.White;
                    break;

                case 7:
                    panel3.Height = 4 + 18 * 3;
                    LabGeneral1.Visible = true;
                    LabGeneral2.Visible = true;
                    LabGeneral3.Visible = true;
                    LabGeneral4.Visible = false;
                    LabGeneral5.Visible = false;
                    LabGeneral6.Visible = false;
                    if (IgAlgo1.YKJInfo.index == 1)
                    {
                        LabGeneral1.Text = "绝对液口距R  :" + (IgAlgo1.YKJInfo.ykj_value + ParasCam1.MeltGapAbsMeasure_OffSet).ToString("f1");
                        LabGeneral2.Text = "绝对液口距Avg:" + (IgAlgo1.MeltGapAbsAvgValue + ParasCam1.MeltGapAbsMeasure_OffSet).ToString("f1");
                    }
                    var ErrorInfo = "";
                    if (IgAlgo1.MeltGapAbsOKAVG < 30 && IgAlgo1.YKJInfo.index > 1)
                    {
                        ErrorInfo = "ErrID:" + IgAlgo1.YKJInfo.index.ToString();
                        //ErrorInfo += " P:" + IgAlgo1.MeltGapAbsOKAVG.ToString("f0")+"%";
                    }
                    else if (IgAlgo1.MeltGapAbsOKAVG == 50)
                    {
                        ErrorInfo = "init ..." + IgAlgo1.MeltGapAbsFiveValue.ToString();
                    }
                    LabGeneral3.Text = ErrorInfo;
                    break;
                default:
                    panel3.Height = 4 + 18 * 0;
                    LabGeneral1.Visible = false;
                    LabGeneral2.Visible = false;
                    LabGeneral3.Visible = false;
                    LabGeneral4.Visible = false;
                    LabGeneral5.Visible = false;
                    LabGeneral6.Visible = false;
                    LabGeneral1.ForeColor = Color.White;
                    break;

            }
        }

        public static void SaveImgAsync(IntPtr imgData, int width, int height, bool IsJump = false)
        {
            Task.Run(() =>
        {
            DriveInfo[] driveInfos = DriveInfo.GetDrives();
            String driver = String.Empty;
            StringBuilder sb = new StringBuilder();

            // 非跳转存图
            if (!IsJump)
            {
                for (int i = 0; i < driveInfos.Length; i++)
                {
                    try
                    {
                        // 工序跳转的图片存储在本地D:LICCS_JUMP,整体大小不允许超过1GB
                        // 超过1GB直接删除整个文件，重新创建
                        if (!IsJump && !driveInfos[i].Name.Contains("C:")
                                && !driveInfos[i].Name.Contains("D:")
                            && driveInfos[i].AvailableFreeSpace > 107374182.400)   //100M以上
                        {
                            if (ParasCam1.SavePicPath.Contains(driveInfos[i].Name))
                            {
                                sb.Append(ParasCam1.SavePicPath);
                                break;
                            }
                        }
                    }
                    catch
                    {


                    }
                }
            }
            else
            {
                // 检查目录是否存在

                if (!Directory.Exists(FileHelper.JumpSavePath))
                {
                    Directory.CreateDirectory(FileHelper.JumpSavePath);
                }

                // 检查当前是，文件夹大小(字节)
                long len = FileHelper.GetDirectoryLength(FileHelper.JumpSavePath);
                // 1GB，超过1GB自动清理
                if (len > 1024 * 1024 * 1024)
                {
                    DirectoryInfo di = new DirectoryInfo(FileHelper.JumpSavePath);
                    di.Delete(true);
                }
                sb = sb.Append(FileHelper.JumpSavePath);
            }

            if (sb.ToString() != "")
            {
                // 目录检查
                if (!IsJump)
                {
                    sb.Append("\\").Append(ProcState.CurrentState(Math.Round(PLC.ReadValue[1], 1).ToString("f1"))).Append("\\");
                }
                else
                {
                    sb.Append("\\").Append("Jump").Append("\\").Append(ProcState.CurrentState(Math.Round(PLC.ReadValue[1], 1).ToString("f1"))).Append("\\");
                }

                if (!Directory.Exists(sb.ToString()))
                {
                    Directory.CreateDirectory(sb.ToString());
                }

                sb.Append(DateTime.Now.ToString("yyyyMMddHHmmssfff")).Append(".bmp");

                // 进行图片存储
                Bitmap bmp = new Bitmap(width, height, width, PixelFormat.Format8bppIndexed, imgData);
                if (CamUnity.Palette != null)
                {
                    bmp.Palette = CamUnity.Palette;
                }
                bmp.Save(sb.ToString());
                bmp.Dispose();



            }
            else
            {
                return;
            }
        });
        }
    }
}
