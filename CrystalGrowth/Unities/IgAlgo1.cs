﻿using CamLibrary;
using CrystalGrowth.AuxFunction.CCD;
using NPOI.POIFS.Properties;
using System;
using System.Collections;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace CrystalGrowth.Unities
{
    internal static class IgAlgo1
    {
        public static Queue FilterArray = new Queue();
        private static Queue MeltGapShortArray = new Queue();
        private static Queue MeltGapMiddleArray = new Queue();
        private static Queue MeltGapLongArray = new Queue();
        private static Queue BrightArray = new Queue();
        private static Queue BrightRTimeArray = new Queue();
        private static Queue ShakeValArray = new Queue();
        private static bool PixelGapMiddleFilterStartFlag = false, PixelDiaFilterStartFlag = false, BrightFilterStartFlag = false;
        public static bool Cursor = false;
        //像素直径,像素短熔间隙,像素间熔间隙,像素长熔间隙
        public static float PixelDiameter = 0, PixelShortMeltGap = 0, PixelMiddleMeltGap = 0, PixelLongMeltGap = 0;
        //液口距像素短滤波短和,液口距像素中间滤波中间和
        private static float PixelGapShortFilterSumShort = 0, PixelGapMiddleFilterMiddleSum = 0;
        private static float PixelGapMiddleFilterLastGap = 0, PixelGapLongFilterLongSum = 0, PixelGapLongFilterLastGap = 0;
        private static float PixelDiaFilterSum = 0, PixelDiaFilterLastDia = 0;
        private static float OldPixelLongMeltGap = 0, OldPixelDiameter = 0, OldPixelMiddleMeltGap = 0;
        private static float BrightRTFilterSumRT = 0, BrightFilterSum = 0;
        private static float BrightFilterLastRawBright, BrightFilterLastAverBright;
        private static bool PixelGapLongFilterStartFlag = false;
        /// <summary>
        /// 发送直径
        /// </summary>
        private static void SendDiameter(float Dia, int status)
        {
            //if (FrmCrownArea.IsOpen || FrmBodyArea.IsOpen || FrmNeckArea.IsOpen) { return; }
            //float RealDia = (Dia / ParasCam1.ShieldDiafac) * ParasCam1.ShieldCorrectCoef;
            float RealDia = (float)(Dia / ParasCam1.ShieldDiafac);
            //switch (status)
            //{
            //    case 0:
            //        RealDia *= ParasCam1.NeckOffsetRate;
            //        break;
            //    case 1:
            //        RealDia *= ParasCam1.CrownOffsetRate;
            //        break;
            //    default:
            //        RealDia += ParasCam1.BodyOffsetRate;
            //        break;
            //}
            PLC.SendFloat(31, 0, RealDia);
        }
        //引晶测量
        public static double NeckMinX1 = 0, NeckMinY1 = 0, NeckMaxX1 = 0, NeckMaxY1 = 0;
        public static int NeckLongEdge = 0, NeckShortEdge = 0, NeckCenterX = 0, NeckCenterY = 0;
        public static bool NeckMeasure()
        {
            if (Cursor == false)
            {
                NeckLongEdge = ParasCam1.NeckRightX - ParasCam1.NeckLeftX;
                NeckShortEdge = ParasCam1.NeckBottomY - ParasCam1.NeckTopY;
                NeckCenterX = ParasCam1.NeckLeftX + NeckLongEdge / 2;
                NeckCenterY = ParasCam1.NeckTopY + NeckShortEdge / 2;
            }
            //算法测量
            int bRet = ExternDll.MeasureExtremum(CamUnity.Ptr1, ParasCam1.Width, ParasCam1.Height, NeckCenterX, NeckCenterY, NeckLongEdge, NeckShortEdge,
                   0, ParasCam1.NeckThreshold + ThresholdAvergeValue, 3, 3, 0, 0, 1, ref NeckMinX1, ref NeckMinY1, ref NeckMaxX1, ref NeckMaxY1);
            float Width = (float)(NeckMaxX1 - NeckMinX1);
            FindShakeRange(NeckMinX1, (int)NeckMinY1, 10, ref ShakeValArray);
            if (bRet == 1 && NeckMinX1 > 0 && NeckMaxX1 > 0 && Width > 0 && Width < NeckLongEdge - 10)
            {
                FrmCrystalShake.CurrentCenter.X = (int)((NeckMinX1 + NeckMaxX1) / 2.0);
                FrmCrystalShake.CurrentCenter.Y = (int)((NeckMinY1 + NeckMaxY1) / 2.0);
                PixelDiaFilter(Width, ParasCam1.NeckArrayNum, ParasCam1.NeckFilterCoef, ref FilterArray, ref PixelDiameter);
                SendDiameter(PixelDiameter, 0);
                return true;
            }
            else
            {
                return false;
            }
        }
        //20221201 拟合圆测量引晶直径
        /// <summary>
        /// 引晶拟合圆测量点指针
        /// </summary>
        public static IntPtr NeckDiaPointPtr = IntPtr.Zero;
        /// <summary>
        /// 拟合圆信息，坐标X，坐标Y，半径R
        /// </summary>
        public static double NeckX, NeckY, NeckR;
        /// <summary>
        /// 引晶拟合圆测量方法
        /// </summary>
        /// <returns>拟合圆测量结果</returns>
        public static bool NeckMeasureFitCircle()
        {
            if (Cursor == false)
            {
                NeckLongEdge = ParasCam1.NeckRightX - ParasCam1.NeckLeftX;
                NeckShortEdge = ParasCam1.NeckBottomY - ParasCam1.NeckTopY;
                NeckCenterX = ParasCam1.NeckLeftX + NeckLongEdge / 2;
                NeckCenterY = ParasCam1.NeckTopY + NeckShortEdge / 2;
            }
            //算法测量
            int bRet, Err = 0;
            bRet = ExternDll.NeckDiaFitMeasure(CamUnity.Ptr1, ParasCam1.Width, ParasCam1.Height, NeckCenterX, NeckCenterY,
                NeckLongEdge, NeckShortEdge, ParasCam1.NeckThreshold/* + ThresholdAvergeValue*/, 3, 3, 0, 1, 1, 48,
                ref NeckX, ref NeckY, ref NeckR);

            if (bRet == 0)
            {
                Err++;
            }
            else
            {
                NeckDiaPointPtr = ExternDll.GetNeckDiaPoints();
            }
            if (Err == 0 && (NeckX <= 0 || NeckY <= 0 || NeckR <= 0))
            {
                Err++;
            }

            if (Err == 0)
            {

                PixelDiaFilter((float)NeckR * 2, ParasCam1.NeckArrayNum, ParasCam1.NeckFilterCoef, ref FilterArray, ref PixelDiameter);

                SendDiameter(PixelDiameter, 2);

                //if (PLC.ReadStatus[180] == 1)
                //{
                //    if (PixelDiameter > Convert.ToUInt32(FrmNeckArea.ThrDia))
                //    {
                //        //PLC.SendBit(32, 179, 0);
                //        PLC.SendBit(32, 180, 1);
                //        PLC.SendFloat(31, 216, 1);
                //    }
                //}

                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 放肩测量
        /// </summary>
        /// <returns></returns>
        public static double CrownMinX1 = 0, CrownMinY1 = 0, CrownMaxX1 = 0, CrownMaxY1 = 0;
        private static int CrownLongEdge = 0, CrownShortEdge = 0, CrownCenterX = 0, CrownCenterY = 0;
        public static bool CrownMeasure()
        {
            if (Cursor == false)
            {
                CrownLongEdge = ParasCam1.CrownRightX - ParasCam1.CrownLeftX;
                CrownShortEdge = ParasCam1.CrownBottomY - ParasCam1.CrownTopY;
                CrownCenterX = ParasCam1.CrownLeftX + CrownLongEdge / 2;
                CrownCenterY = ParasCam1.CrownTopY + CrownShortEdge / 2;
            }
            //算法测量画点
            int bRet = ExternDll.MeasureExtremum(CamUnity.Ptr1, ParasCam1.Width, ParasCam1.Height, CrownCenterX, CrownCenterY, CrownLongEdge, CrownShortEdge,
                0, ParasCam1.CrownThreshold + ThresholdAvergeValue, 3, 3, 0, 0, 1, ref CrownMinX1, ref CrownMinY1, ref CrownMaxX1, ref CrownMaxY1);
            float Width = (float)(CrownMaxX1 - CrownMinX1);
            FindShakeRange(CrownMinX1, (int)CrownMinY1, 10, ref ShakeValArray);
            if (bRet == 1 && CrownMinX1 > 0 && CrownMaxX1 > 0 && Width > 0 && Width < CrownLongEdge - 10)
            {
                FrmCrystalShake.CurrentCenter.X = (int)((CrownMinX1 + CrownMaxX1) / 2.0);
                FrmCrystalShake.CurrentCenter.Y = (int)((CrownMinY1 + CrownMaxY1) / 2.0);
                PixelDiaFilter(Width, ParasCam1.CrownArrayNum, ParasCam1.CrownFilterCoef, ref FilterArray, ref PixelDiameter);
                SendDiameter(PixelDiameter, 1);
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 等径测量
        /// </summary>
        /// <returns></returns>
        public static double BodyX = 0, BodyY = 0, BodyR = 0, CutLineX = 0, CutLineY = 0;
        public static IntPtr BodyDiaPointPtr = IntPtr.Zero;
        private static int BodyLongEdge = 0, BodyShortEdge = 0, BodyCenterX = 0, BodyCenterY = 0;
        public static bool BodyMeasure()
        {
            int bRet, Err = 0;
            if (Cursor == false)
            {
                BodyLongEdge = ParasCam1.BodyRightX - ParasCam1.BodyLeftX;
                BodyShortEdge = ParasCam1.BodyBottomY - ParasCam1.BodyTopY;
                BodyCenterX = ParasCam1.BodyLeftX + BodyLongEdge / 2;
                BodyCenterY = ParasCam1.BodyTopY + BodyShortEdge / 2;
            }
            //晶体直径
            if (PLC.ReadCalcValue[14] >= ParasCam1.CutLineStartLine)
            {
                bRet = ExternDll.DiaFitMeasureWhitCL(CamUnity.Ptr1, ParasCam1.Width, ParasCam1.Height, BodyCenterX,
                     BodyCenterY, BodyLongEdge, BodyShortEdge, ParasCam1.BodyThreshold, 3, 3, 0, 1, 1, 48, ParasCam1.CutLineThroshold,
                    ref BodyX, ref BodyY, ref BodyR, ref CutLineX, ref CutLineY, ref FrmCutLineCheck.CatchFlag);
                FrmCutLineCheck.IsStart = true;
                if (FrmCutLineCheck.Timer.IsRunning == false)
                {
                    FrmCutLineCheck.Timer.Start();
                }
            }
            else
            {
                FrmCutLineCheck.IsStart = false;
                bRet = ExternDll.DiaFitMeasure(CamUnity.Ptr1, ParasCam1.Width, ParasCam1.Height, BodyCenterX, BodyCenterY,
                     BodyLongEdge, BodyShortEdge, ParasCam1.BodyThreshold, 3, 3, 0, 1, 1, 48, ref BodyX, ref BodyY, ref BodyR);
            }
            FrmCrystalShake.CurrentCenter.X = (int)BodyX;
            FrmCrystalShake.CurrentCenter.Y = (int)BodyY;
            if (bRet == 0)
            {
                Err++;
            }
            else
            {
                BodyDiaPointPtr = ExternDll.GetDiaPoints();
            }
            if (Err == 0 && (BodyX <= 0 || BodyY <= 0 || BodyR <= 750 || BodyR >= 2000))
            {
                Err++;
            }
            if (Err == 0)
            {
                CutLineCheck();
                PixelDiaFilter((float)BodyR * 2, ParasCam1.BodyArrayNum, ParasCam1.BodyFilterCoef, ref FilterArray, ref PixelDiameter);
                if (OldPixelDiameter == 0)
                {
                    OldPixelDiameter = PixelDiameter;
                }
                PixelDiameter = 2 * OldPixelDiameter / 3 + PixelDiameter / 3;
                OldPixelDiameter = PixelDiameter;
                SendDiameter(PixelDiameter, 2);
                if (PLC.ReadValue[1] == 13)
                {
                    SendCircleCenter(FrmCrystalShake.CurrentCenter.X, FrmCrystalShake.CurrentCenter.Y);
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 发送拟合圆圆心
        /// </summary>
        private static void SendCircleCenter(float center_x, float center_y)
        {
            PLC.SendFloat(31, 292, center_x);
        }
        private static void CutLineCheck()
        {
            FrmCrystalShake.CurrentCenter.X = (int)BodyX;
            FrmCrystalShake.CurrentCenter.Y = (int)BodyY;
            if (PLC.ReadCalcValue[14] >= ParasCam1.CutLineStartLine)
            {
                if (FrmCutLineCheck.CatchFlag == 1)
                {
                    FrmCutLineCheck.Count++;
                }
                if (FrmCutLineCheck.Timer.ElapsedMilliseconds >= ParasCam1.CutLineCheckPeriod * 60.0 * 1000)
                {
                    if (FrmCutLineCheck.LastCount != 0)
                    {
                        FrmCutLineCheck.Probability = Math.Round(1.0 - FrmCutLineCheck.Count / FrmCutLineCheck.LastCount, 2);
                    }
                    if (FrmCutLineCheck.Probability < 0)
                    {
                        FrmCutLineCheck.Probability = 0;
                    }
                    if (ParasCam1.CutLineCountAlarmThroshold != 0 && ParasCam1.CutLineCountAlarmThroshold >= FrmCutLineCheck.Count)
                    {
                        FrmCutLineCheck.Probability = 1;
                        Record.WriteIn("晶体断线报警", string.Concat((FrmCutLineCheck.Probability * 100).ToString(), "%"), "Red");
                    }
                    //else if (CameraParas.CutLine_CheckPeriod * 70 >= FrmCutLineCheck.Count)
                    //{
                    //    FrmCutLineCheck.Probability = 1;
                    //    RecordFile.WriteRecord("晶体断线报警",string.Format("{0}%",(FrmCutLineCheck.Probability * 100).ToString()), "Red");
                    //}
                    else if (FrmCutLineCheck.Probability >= 0.25)
                    {
                        Record.WriteIn("晶体断线报警", "", "Red");
                    }
                    FrmCutLineCheck.LastCount = FrmCutLineCheck.Count;
                    FrmCutLineCheck.Count = 0;
                    FrmCutLineCheck.Timer.Restart();
                }
            }
        }
        /// <summary>
        /// 液口距测量
        /// </summary>
        /// <returns></returns>
        public static double MeltGapX1 = 0, MeltGapX2 = 0, MeltGapY = 0, MeltGapDistance = 0;
        private static int MeltGapLeftX = 0, MeltGapRightX = 0, MeltGapLineY = 0;
        public static int MeltGapMeasure()
        {
            int Err = 0;
            if (Cursor == false)
            {
                MeltGapLeftX = ParasCam1.MeltGapLeftX;
                MeltGapRightX = ParasCam1.MeltGapRightX;
                MeltGapLineY = ParasCam1.MeltGapLineY;
            }
            int bRet = ExternDll.MeasureMeltGap(CamUnity.Ptr1, ParasCam1.Width, ParasCam1.Height,
                 MeltGapLeftX, MeltGapLineY, MeltGapRightX, MeltGapLineY, ParasCam1.MeltGapThreshold, 3, 3, 0,
                 ref MeltGapX1, ref MeltGapX2, ref MeltGapY, ref MeltGapDistance);
            if (bRet == 1)
            {
                if (MeltGapDistance >= 0 && MeltGapDistance < 1)
                {
                    Err = 1;
                }
            }
            else
            {
                Err = 1;
            }
            if (Err == 0)
            {
                float RawMeltGap = MeltGapCalc((int)MeltGapX1, (int)MeltGapX2);
                PixelGapShortFilter(RawMeltGap, ParasCam1.MeltGapShortArrayNum, ref MeltGapShortArray, ref PixelShortMeltGap);
                PixelGapMiddleFilter(RawMeltGap, ParasCam1.MeltGapMiddleArrayNum, ParasCam1.MeltGapMiddleFilterCoef,
                    ref MeltGapMiddleArray, ref PixelMiddleMeltGap);
                PixelGapLongFilter(RawMeltGap, ParasCam1.MeltGapLongArrayNum, ParasCam1.MeltGapLongFilterCoef,
                    ref MeltGapLongArray, ref PixelLongMeltGap);
                if (OldPixelLongMeltGap == 0)
                {
                    OldPixelLongMeltGap = PixelLongMeltGap;
                }
                PixelLongMeltGap = (float)(0.9 * OldPixelLongMeltGap + 0.1 * PixelLongMeltGap);
                OldPixelLongMeltGap = PixelLongMeltGap;
                if (OldPixelMiddleMeltGap == 0)
                {
                    OldPixelMiddleMeltGap = PixelMiddleMeltGap;
                }
                if (PixelMiddleMeltGap < OldPixelMiddleMeltGap * 1.2 || PixelMiddleMeltGap > OldPixelMiddleMeltGap * 0.8 || PixelMiddleMeltGap > 10)
                {
                    float PixelMiddleMeltGapFinal = 2 * OldPixelMiddleMeltGap / 3 + PixelMiddleMeltGap / 3;
                    OldPixelMiddleMeltGap = PixelMiddleMeltGapFinal;
                }
                PLC.SendFloat(31, 4, PixelLongMeltGap);
                PLC.SendFloat(31, 108, PixelMiddleMeltGap);
                PLC.SendFloat(31, 112, PixelShortMeltGap);
            }
            return Err;
        }
        /// <summary>
        /// 液口距长测量
        /// </summary>
        /// <returns></returns>
        public static double MeltGapLongX1 = 0, MeltGapLongX2 = 0, MeltGapLongY = 0, MeltGapLongDistance = 0;
        private static int MeltGapLongLeftX = 0, MeltGapLongRightX = 0, MeltGapLongLineY = 0;
        public static int MeltGapLongMeasure()
        {
            int Err = 0;
            if (Cursor == false)
            {
                MeltGapLongLeftX = ParasCam1.MeltGapLongLeftX;
                MeltGapLongRightX = ParasCam1.MeltGapLongRightX;
                MeltGapLongLineY = ParasCam1.MeltGapLineY;
            }
            int bRet = ExternDll.MeasureMeltGapLong(CamUnity.Ptr1, ParasCam1.Width, ParasCam1.Height,
                 MeltGapLongLeftX, MeltGapLongLineY, MeltGapLongRightX, MeltGapLongLineY, ParasCam1.MeltGapLongThreshold, 3, 3, 0,
                 ref MeltGapLongX1, ref MeltGapLongX2, ref MeltGapLongY, ref MeltGapLongDistance);
            if (bRet == 1)
            {
                if (MeltGapLongDistance >= 0 && MeltGapLongDistance < 1)
                {
                    Err = 1;
                }
            }
            else
            {
                Err = 1;
            }
            if (Err == 0)
            {
                float RawMeltGapLong = MeltGapCalc((int)MeltGapLongX1, (int)MeltGapLongX2);
                PixelGapMiddleFilter(RawMeltGapLong, ParasCam1.MeltGapMiddleArrayNum, ParasCam1.MeltGapMiddleFilterCoef,
                    ref MeltGapMiddleArray, ref PixelMiddleMeltGap);
                PixelGapShortFilter(RawMeltGapLong, ParasCam1.MeltGapShortArrayNum, ref MeltGapShortArray, ref PixelShortMeltGap);
                PixelGapLongFilter(RawMeltGapLong, ParasCam1.MeltGapLongArrayNum, ParasCam1.MeltGapLongFilterCoef,
                    ref MeltGapLongArray, ref PixelLongMeltGap);

                if (OldPixelLongMeltGap == 0)
                {
                    OldPixelLongMeltGap = PixelLongMeltGap;
                }
                PixelLongMeltGap = 0.9f * OldPixelLongMeltGap + 0.1f * PixelLongMeltGap;
                OldPixelLongMeltGap = PixelLongMeltGap;
                //add 20210910
                if (OldPixelMiddleMeltGap == 0)
                {
                    OldPixelMiddleMeltGap = PixelMiddleMeltGap;
                }
                PixelMiddleMeltGap = 2 * OldPixelMiddleMeltGap / 3 + PixelMiddleMeltGap / 3;
                OldPixelMiddleMeltGap = PixelMiddleMeltGap;
                PLC.SendFloat(31, 4, PixelLongMeltGap);
                PLC.SendFloat(31, 108, PixelMiddleMeltGap);
                PLC.SendFloat(31, 112, PixelShortMeltGap);
            }
            return Err;
        }
        public static void MeltGapReset()
        {
            MeltGapLongX1 = 0;
            MeltGapLongX2 = 0;
            MeltGapX1 = 0;
            MeltGapX2 = 0;
        }


        /// <summary>
        /// 绝对液口距信息
        /// </summary>
        public static YKJ_Info YKJInfo = new YKJ_Info();
        /// <summary>
        /// 绝对液口距信息(上一次准确值)
        /// </summary>
        public static YKJ_Info YKJInfoPre = new YKJ_Info();
        /// <summary>
        /// 绝对液口距参考点
        /// </summary>
        public static int[] XPre = new int[2000];
        /// <summary>
        /// 绝对液口距信息(上一次准确值)
        /// </summary>
        public static int[] yPre = new int[2000];
        /// <summary>
        /// 绝对液口距手动开启
        /// </summary>
        public static bool MeltGapAbsMeasureManualStartFlag = false;
        /// <summary>
        /// 绝对液口距自动开启
        /// </summary>
        public static bool MeltGapAbsMeasureAutoStartFlag = false;
        /// <summary>
        /// 绝对液口距边缘点显示
        /// </summary>
        public static bool MeltGapAbsShowAreaFlag = false;
        /// <summary>
        /// 绝对液口距参考线显示
        /// </summary>
        public static bool MeltGapAbsShowEllipseFlag = false;
        /// <summary>
        /// 绝对液口距点集指针
        /// </summary>
        public static IntPtr MeltGapAbsMeasureP = IntPtr.Zero;
        /// <summary>
        /// 绝对液口距数据集合
        /// </summary>
        public static Queue MeltGapAbsArray = new Queue();
        /// <summary>
        /// 绝对液口距识别正确结果记录
        /// </summary>
        public static int MeltGapAbsOKNum = 0;
        /// <summary>
        /// 绝对液口距识别异常结果记录
        /// </summary>
        public static Queue MeltGapAbsOkArray = new Queue();

        /// <summary>
        /// 绝对液口距识别正确率
        /// </summary>
        public static double MeltGapAbsOKAVG = 50;

        /// <summary>
        /// 绝对液口距识别参数
        /// </summary>
        public static int MeltGapAbsFiveValue = 12;


        /// <summary>
        /// 绝对液口距数值平均滤波值
        /// </summary>
        public static double MeltGapAbsAvgValue;

        /// <summary>
        /// 绝对液口距测量
        /// </summary>
        /// <returns>返回值含义：0=初始测量；  1=测量准确， 9=测量失败； -1=未启用  其余=未知 </returns>
        public static int MeltGapAbsMeasure()
        {
            int Num = ParasCam1.MeltGapAbsFilterNum;//滑动平均长度
            MeltGapAbsMeasureP = ExternDll.Calc_Fitting_Ellips_YKJ(CamUnity.Ptr1,
                ParasCam1.Width,
                ParasCam1.Height,
                ParasCam1.MeltGapAbsMeasure_H,
                ParasCam1.MeltGapAbsMeasure_R,
                ParasCam1.MeltGapAbsMeasure_T, MeltGapAbsFiveValue, ref YKJInfo);


             

            if (MeltGapAbsOkArray.Count >= 21)
            {
                if ((int)MeltGapAbsOkArray.Dequeue() == 1)
                {
                    MeltGapAbsOKNum--;
                }
            }
            MeltGapAbsOkArray.Enqueue(YKJInfo.index);
            if (YKJInfo.index == 1)
            {
                MeltGapAbsOKNum++;
            }

            if (MeltGapAbsOkArray.Count >= 21)
            {
                MeltGapAbsOKAVG = MeltGapAbsOKNum * 100.0 / MeltGapAbsOkArray.Count;
            }
            else
            {
                MeltGapAbsOKAVG = 50;
            }

            // ( 21/4=5.25 秒) 长时间处于识别失败,   2/21=9.5% 
            if (MeltGapAbsOKAVG < 10)
            {
                MeltGapAbsOkArray.Clear();
                MeltGapAbsArray.Clear();
                MeltGapAbsOKNum = 0;
                MeltGapAbsOKAVG = 50;

                if (MeltGapAbsFiveValue == 12)
                {
                    MeltGapAbsFiveValue = 10;
                }
                else if (MeltGapAbsFiveValue == 10)
                {
                    MeltGapAbsFiveValue = 7;
                }
                else if (MeltGapAbsFiveValue == 7)
                {
                    MeltGapAbsFiveValue = 5;
                }
                else if (MeltGapAbsFiveValue == 5)
                {
                    MeltGapAbsFiveValue = 12;
                }
                else
                {
                    MeltGapAbsFiveValue = 10;
                }
            }


            if (YKJInfo.index == 1)
            {
                YKJInfoPre = YKJInfo;
                MeltGapAbsArray.Enqueue(YKJInfo.ykj_value);

                if (MeltGapAbsArray.Count <= Num)
                { //取出平均数
                    MeltGapAbsAvgValue = filter_0(MeltGapAbsArray);
                }
                else
                {
                    while (MeltGapAbsArray.Count > Num)
                    {
                        MeltGapAbsArray.Dequeue();
                    }
                    if (MeltGapAbsArray.Count > 4)
                    {
                        MeltGapAbsAvgValue = filter_1(MeltGapAbsArray);
                    }
                    else
                    {
                        MeltGapAbsAvgValue = filter_0(MeltGapAbsArray);
                    }
                }
            }




            return YKJInfo.index;
        }



        /// <summary>
        /// 平均滤波
        /// </summary>
        /// <param name="Array"></param>
        /// <returns></returns>
        public static double filter_0(Queue Array)
        {
            double sum = 0;
            int Num = Array.Count;
            if (Num == 0)
            {
                return 0;
            }
            var bufArray = Array.ToArray();
            for (int i = 0; i < Num; i++)
            {
                sum += (double)bufArray[i];
            }
            return (sum / Num);
        }
        /// <summary>
        /// 中值平均滤波
        /// </summary>
        /// <param name="Array"></param>
        /// <returns></returns>
        public static double filter_1(Queue Array)
        {
            double sum = 0;
            int Num = Array.Count;
            if (Num <= 2)
            {
                return 0;
            }
            var bufArray =  (Array.ToArray());
            bufArray = BubbleSort(bufArray);
            if (bufArray.Length < 3)
            {
                for (int i = 0; i < Num; i++)
                {
                    sum += (double)bufArray[i];
                }
                return (sum / (Num - 0));
            }
            else if (bufArray.Length < 8)
            {
                for (int i = 1; i < Num - 1; i++)
                {
                    sum += (double)bufArray[i];
                }
                return (sum / (Num - 2));
            }
            else if (bufArray.Length < 15)
            {
                for (int i = 2; i < Num - 2; i++)
                {
                    sum += (double)bufArray[i];
                }
                return (sum / (Num - 4));
            }
            else if (bufArray.Length < 20)
            {
                for (int i = 3; i < Num - 3; i++)
                {
                    sum += (double)bufArray[i];
                }
                return (sum / (Num - 6));
            }
            else 
            {
                for (int i = 4; i < Num - 4; i++)
                {
                    sum += (double)bufArray[i];
                }
                return (sum / (Num - 8));
            }

        }

        static object[] BubbleSort(object[] intArray)
        {
            for (int i = 0; i < intArray.Length; i++)
            {
                for (int j = 0; j < intArray.Length - 1 - i; j++)
                {
                    if ((double)intArray[j] > (double)intArray[j + 1])
                    {
                        object temp = intArray[j];
                        intArray[j] = intArray[j + 1];
                        intArray[j + 1] = temp;
                    }
                }

            }
            return intArray;
        }

        /// <summary>
        /// 明亮测量
        /// </summary>
        public static float BrightValue = 0, BrightRTimeValue = 0, BrightRTVal;
        private static int BrightPointY = 0, BrightRightX = 0, BrightLeftX = 0;
        public static void BrightMeasure()
        {
            int Sum = 0, GaryValue, GrayCnt = 0, i = 0;
            if (Cursor == false)
            {
                BrightPointY = ParasCam1.BrightPointY;
                BrightLeftX = ParasCam1.BrightLeftX;
                //BrightRightX = ParasCam1.BrightRightX - ParasCam1.BrightWidth;
                BrightRightX = ParasCam1.BrightRightX;

            }
            while (i < ParasCam1.BrightWidth)
            {
                GrayCnt += 2;
                BrightPointY += i;
                GaryValue = ExternDll.GetPointPixel(CamUnity.Ptr1, ParasCam1.Width, ParasCam1.Height, BrightLeftX + i, BrightPointY);
                Sum += GaryValue;
                GaryValue = ExternDll.GetPointPixel(CamUnity.Ptr1, ParasCam1.Width, ParasCam1.Height, BrightRightX + i, BrightPointY);
                Sum += GaryValue;
                i++;
            }
            float TempBright = (float)Sum / GrayCnt;
            BrightRTVal = TempBright;
            BrightFilter(TempBright, ParasCam1.BrightArrayNum, ParasCam1.BrightFilterCoef, ref BrightArray, ref BrightValue);
            BrightRTFilter(TempBright, ParasCam1.BrightRTimeArrayNum, ref BrightRTimeArray, ref BrightRTimeValue);
            PLC.SendFloat(31, 28, BrightValue + Calibrate.Value[44]);
        }
        private static void BrightRTFilter(float RawBright, int BrightNum, ref Queue Array, ref float RealBright)
        {
            if (BrightNum < 1)
            {
                BrightNum = 1;
            }
            int ArrayCnt = Array.Count;
            if (ArrayCnt <= 0)
            {
                BrightRTFilterSumRT = 0;
            }
            Array.Enqueue(RawBright);
            BrightRTFilterSumRT += RawBright;
            ArrayCnt = Array.Count;
            if (ArrayCnt > BrightNum)
            {
                int xx = ArrayCnt - BrightNum;
                for (int i = 0; i < xx; i++)
                {
                    BrightRTFilterSumRT -= (float)Array.Dequeue();
                }
                ArrayCnt = Array.Count;
                RealBright = BrightRTFilterSumRT / ArrayCnt;
            }
            else
            {
                RealBright = BrightRTFilterSumRT / ArrayCnt;
            }
        }
        private static float MeltGapCalc(int LeftX, int RightX)
        {
            //int CenterX = ParasCam1.Width / 2;
            //int CenterY = ParasCam1.Height / 2;
            //double Min_Radian = Math.Cos(MinRadian * Angle);
            //double R1 = Math.Sqrt(Math.Pow((RightY - CenterY) * Min_Radian, 2) + Math.Pow(RightX - CenterX, 2));
            //double R2 = Math.Sqrt(Math.Pow((LeftY - CenterY) * Min_Radian, 2) + Math.Pow(LeftX - CenterX, 2));
            return Math.Abs(LeftX - RightX);
        }
        //private static float MeltGapLongCalc(int LeftX, int LeftY, int RightX, int RightY, float Angle)
        //{
        //    int CenterX = ParasCam1.Width / 2;
        //    int CenterY = ParasCam1.Height / 2;
        //    double Min_Radian = Math.Cos(MinRadian * Angle);
        //    double R1 = Math.Sqrt(Math.Pow((RightY - CenterY) * Min_Radian, 2) + Math.Pow(RightX - CenterX, 2));
        //    double R2 = Math.Sqrt(Math.Pow((LeftY - CenterY) * Min_Radian, 2) + Math.Pow(LeftX - CenterX, 2));
        //    return (float)Math.Abs(R1 - R2);
        //}
        private static void PixelGapLongFilter(float RawGap, float GapNum, float FilterCoef, ref Queue Array, ref float RealGap)
        {
            int ArrayCnt, TempIndex;
            float[] DevArray;
            int[] DevIndex;
            float TempDev, SectionSum = 0;
            //埚快升液口距不滤波
            if (PLC.ReadStatus[20] == 1)
            {
                if (Array.Count > 0)
                {
                    Array.Clear();
                }
                RealGap = RawGap;
            }
            else
            {
                if (GapNum < 10)
                {
                    GapNum = 10;
                }
                ArrayCnt = Array.Count;
                if (ArrayCnt <= 0)
                {
                    PixelGapLongFilterLongSum = 0;
                    PixelGapLongFilterStartFlag = false;
                }
                Array.Enqueue(RawGap);
                PixelGapLongFilterLongSum += RawGap;
                ArrayCnt = Array.Count;
                //正态分布滤波
                if (ArrayCnt > GapNum)
                {
                    int xx = (int)(ArrayCnt - GapNum);
                    for (int i = 0; i < xx; i++)
                    {
                        PixelGapLongFilterLongSum -= (float)Array.Dequeue();
                    }
                    ArrayCnt = Array.Count;
                    float Average = PixelGapLongFilterLongSum / ArrayCnt;
                    DevArray = new float[ArrayCnt + 1];
                    DevIndex = new int[ArrayCnt + 1];
                    for (int i = 0; i < ArrayCnt; i++)
                    {
                        DevArray[i] = Math.Abs((float)Array.ToArray()[i] - Average);
                        DevIndex[i] = i;
                    }
                    int jj, yy;
                    for (int i = 0; i < ArrayCnt; i++)
                    {
                        yy = ArrayCnt - i;
                        for (int j = 0; j < yy; j++)
                        {
                            jj = j + 1;
                            if (DevArray[j] > DevArray[jj])
                            {
                                TempDev = DevArray[j];
                                DevArray[j] = DevArray[jj];
                                DevArray[j + 1] = TempDev;
                                TempIndex = DevIndex[j];
                                DevIndex[j] = DevIndex[jj];
                                DevIndex[jj] = TempIndex;
                            }
                        }
                    }
                    ArrayCnt = (int)(ArrayCnt * 0.8);
                    for (int i = 0; i < ArrayCnt; i++)
                    {
                        SectionSum += (float)Array.ToArray()[DevIndex[i]];
                    }
                    float TempDia = SectionSum / ArrayCnt;
                    //一阶微分滤波Y(n)=aX(n) + (1-a)Y(n-1)
                    if (PixelGapLongFilterStartFlag == false)
                    {
                        PixelGapLongFilterStartFlag = true;
                        PixelGapLongFilterLastGap = TempDia;
                    }
                    RealGap = FilterCoef * TempDia + (1 - FilterCoef) * PixelGapLongFilterLastGap;
                    PixelGapLongFilterLastGap = RealGap;
                }
                else
                {
                    RealGap = PixelGapLongFilterLongSum / ArrayCnt;
                }
            }
        }
        private static void PixelGapMiddleFilter(float RawGap, int GapNum, float FilterCoef, ref Queue Array, ref float RealGap)
        {
            int ArrayCnt, TempIndex;
            int[] DevIndex;
            float TempDev, SectionSum = 0;
            //埚快升液口距不滤波
            if (PLC.ReadStatus[20] == 1)
            {
                if (Array.Count > 0)
                {
                    Array.Clear();
                }
                RealGap = RawGap;
            }
            else
            {
                if (GapNum < 10)
                {
                    GapNum = 10;
                }
                ArrayCnt = Array.Count;
                if (ArrayCnt <= 0)
                {
                    PixelGapMiddleFilterMiddleSum = 0;
                    PixelGapMiddleFilterStartFlag = false;
                }
                Array.Enqueue(RawGap);
                PixelGapMiddleFilterMiddleSum += RawGap;
                ArrayCnt = Array.Count;
                //正态分布滤波
                if (ArrayCnt > GapNum)
                {
                    int xx = ArrayCnt - GapNum;
                    for (int i = 0; i < xx; i++)
                    {
                        PixelGapMiddleFilterMiddleSum -= (float)Array.Dequeue();
                    }
                    ArrayCnt = Array.Count;
                    float Average = PixelGapMiddleFilterMiddleSum / ArrayCnt;
                    DevIndex = new int[ArrayCnt + 1];
                    float[] DevArray = new float[ArrayCnt + 1];
                    for (int i = 0; i < ArrayCnt; i++)
                    {
                        //异常
                        DevArray[i] = Math.Abs((float)Array.ToArray()[i] - Average);
                        DevIndex[i] = i;
                    }
                    int jj, yy;
                    for (int i = 0; i < ArrayCnt; i++)
                    {
                        yy = ArrayCnt - i;
                        for (int j = 0; j < yy; j++)
                        {
                            jj = j + 1;
                            if (DevArray[j] > DevArray[jj])
                            {
                                TempDev = DevArray[j];
                                DevArray[j] = DevArray[jj];
                                DevArray[jj] = TempDev;
                                TempIndex = DevIndex[j];
                                DevIndex[j] = DevIndex[jj];
                                DevIndex[jj] = TempIndex;
                            }
                        }
                    }
                    ArrayCnt = (int)(ArrayCnt * 0.8);
                    for (int i = 0; i < ArrayCnt; i++)
                    {
                        SectionSum += (float)Array.ToArray()[DevIndex[i]];
                    }
                    float TempDia = SectionSum / ArrayCnt;
                    //一阶微分滤波Y(n)=aX(n) + (1-a)Y(n-1)
                    if (PixelGapMiddleFilterStartFlag == false)
                    {
                        PixelGapMiddleFilterStartFlag = true;
                        PixelGapMiddleFilterLastGap = TempDia;
                    }
                    RealGap = FilterCoef * TempDia + (1 - FilterCoef) * PixelGapMiddleFilterLastGap;
                    PixelGapMiddleFilterLastGap = RealGap;
                }
                else
                {
                    RealGap = PixelGapMiddleFilterMiddleSum / ArrayCnt;
                }
            }
        }
        private static void PixelGapShortFilter(float RawGap, int GapNum, ref Queue Array, ref float RealGap)
        {
            //埚快升液口距不滤波
            if (PLC.ReadStatus[20] == 1)
            {
                if (Array.Count > 0)
                {
                    Array.Clear();
                }
                RealGap = RawGap;
            }
            else
            {
                if (GapNum < 1)
                {
                    GapNum = 1;
                }
                int ArrayCnt = Array.Count;
                if (ArrayCnt <= 0)
                {
                    PixelGapShortFilterSumShort = 0;
                }
                Array.Enqueue(RawGap);
                PixelGapShortFilterSumShort += RawGap;
                ArrayCnt = Array.Count;
                if (ArrayCnt > GapNum)
                {
                    int xx = ArrayCnt - GapNum;
                    for (int i = 0; i < xx; i++)
                    {
                        PixelGapShortFilterSumShort -= (float)Array.Dequeue();
                    }
                    ArrayCnt = Array.Count;
                    RealGap = PixelGapShortFilterSumShort / ArrayCnt;
                }
                else
                {
                    RealGap = PixelGapShortFilterSumShort / ArrayCnt;
                }
            }
        }
        private static void BrightFilter(float RawBright, int BrightNum, float FilterCoef, ref Queue Array, ref float RealBright)
        {
            //亮度测量偏差大重新滤波
            if (Math.Abs(RawBright - BrightFilterLastRawBright) > 20)
            {
                if (Array.Count > 0)
                {
                    Array.Clear();
                }
            }
            BrightFilterLastRawBright = RawBright;
            if (BrightNum < 10)
            {
                BrightNum = 10;
            }
            int ArrayCnt = Array.Count;
            if (ArrayCnt <= 0)
            {
                BrightFilterSum = 0;
                BrightFilterStartFlag = false;
            }
            Array.Enqueue(RawBright);
            BrightFilterSum += RawBright;
            ArrayCnt = Array.Count;
            //递推滤波
            if (ArrayCnt > BrightNum)
            {
                int xx = ArrayCnt - BrightNum;
                for (int i = 0; i < xx; i++)
                {
                    BrightFilterSum -= (float)Array.Dequeue();
                }
                ArrayCnt = Array.Count;
                float AverBright = BrightFilterSum / ArrayCnt;
                //一阶微分滤波Y(n)=aX(n) + (1-a)Y(n-1)
                if (BrightFilterStartFlag == false)
                {
                    BrightFilterStartFlag = true;
                    BrightFilterLastAverBright = AverBright;
                }
                RealBright = FilterCoef * AverBright + (1 - FilterCoef) * BrightFilterLastAverBright;
                BrightFilterLastAverBright = RealBright;
            }
            else
            {
                RealBright = BrightFilterSum / ArrayCnt;
            }
        }
        public static void ThresholdCalc()
        {
            switch (Mode.Current)
            {
                case 1:
                    if (ThresholdCount < 100)
                    {
                        ThresholdAverge(ParasCam1.NeckLeftX, ParasCam1.NeckTopY);
                    }
                    break;
                case 2:
                    if (ThresholdCount < 100)
                    {
                        ThresholdAverge(ParasCam1.CrownLeftX, ParasCam1.CrownTopY);
                    }
                    break;
                case 3:
                    if (ThresholdCount < 100)
                    {
                        ThresholdAverge(ParasCam1.BodyLeftX, ParasCam1.BodyTopY);
                    }
                    break;
            }
        }
        private static void PixelDiaFilter(float RawDia, int DiaNum, float FilterCoef, ref Queue Array, ref float RealDia)
        {
            float TempDev, SectionSum = 0;
            int TempIndex;
            if (DiaNum < 10)
            {
                DiaNum = 10;
            }
            int ArrayCnt = Array.Count;
            if (ArrayCnt <= 0)
            {
                PixelDiaFilterSum = 0;
                PixelDiaFilterStartFlag = false;
            }
            Array.Enqueue(RawDia);
            PixelDiaFilterSum += RawDia;
            ArrayCnt = Array.Count;
            //正态分布滤波
            if (ArrayCnt > DiaNum)
            {
                int xx = ArrayCnt - DiaNum;
                for (int i = 0; i < xx; i++)
                {
                    PixelDiaFilterSum -= (float)Array.Dequeue();
                }
                ArrayCnt = Array.Count;
                float Average = PixelDiaFilterSum / ArrayCnt;
                float[] DevArray = new float[ArrayCnt + 1];
                int[] DevIndex = new int[ArrayCnt + 1];
                for (int i = 0; i < ArrayCnt; i++)
                {
                    DevArray[i] = Math.Abs((float)Array.ToArray()[i] - Average);
                    DevIndex[i] = i;
                }
                int jj, yy;
                for (int i = 0; i < ArrayCnt; i++)
                {
                    yy = ArrayCnt - i;
                    for (int j = 0; j < yy; j++)
                    {
                        jj = j + 1;
                        if (DevArray[j] > DevArray[jj])
                        {
                            TempDev = DevArray[j];
                            DevArray[j] = DevArray[jj];
                            DevArray[j + 1] = TempDev;
                            TempIndex = DevIndex[j];
                            DevIndex[j] = DevIndex[jj];
                            DevIndex[jj] = (int)TempIndex;
                        }
                    }
                }
                ArrayCnt = (int)(ArrayCnt * 0.7);
                for (int i = 0; i < ArrayCnt; i++)
                {
                    SectionSum += (float)Array.ToArray()[DevIndex[i]];
                }
                float TempDia = SectionSum / ArrayCnt;
                //一阶微分滤波Y(n)=aX(n) + (1-a)Y(n-1)
                if (PixelDiaFilterStartFlag == false)
                {
                    PixelDiaFilterStartFlag = true;
                    PixelDiaFilterLastDia = TempDia;
                }
                RealDia = FilterCoef * TempDia + (1 - FilterCoef) * PixelDiaFilterLastDia;
                PixelDiaFilterLastDia = RealDia;
            }
            else
            {
                RealDia = PixelDiaFilterSum / ArrayCnt;
            }
        }
        public static double per, avg = 1.0;
        private static readonly float[] inputTensor = new float[256 * 256 * 3];
        private static readonly float[] return_im = new float[256 * 256 * 3];
        public static void MeltingCheck()
        {
            ExternDll.OpenCVDataBuffer(CamUnity.Ptr1, inputTensor, ParasCam1.Width, ParasCam1.Height); // 获得输入的tensor
            ExternDll.getPredictIm(FileHelper.PredictModelPath, 4, true, true, 100, inputTensor, return_im, 256, 256); // 获得预测的图片
            ExternDll.getPercent(ref per);
            ExternDll.compute(ref avg);
        }
        public static int sum = 0, ThresholdCount;
        public static double ThresholdAvergeValue;
        public static void ThresholdAverge(int leftX, int leftY)
        {
            ThresholdCount++;
            sum += ExternDll.GetPointPixel(CamUnity.Ptr1, ParasCam1.Width, ParasCam1.Height, leftX, leftY);
            ThresholdAvergeValue = sum / ThresholdCount;
        }
        private static double LeftXMin = 0, LeftXMax = 0, LeftYMin = 0, LeftYMax = 0;
        public static void FindShakeRange(double LeftX, int LeftY, double DiaNum, ref Queue Array)
        {
            LeftXMin = ParasCam1.Width;
            LeftYMin = ParasCam1.Height;
            if (DiaNum < 10)
            {
                DiaNum = 10;
            }
            Array.Enqueue(LeftX);
            if (LeftX < LeftXMin)
            {
                LeftXMin = LeftX;
            }
            if (LeftX > LeftXMax)
            {
                LeftXMax = LeftX;
            }
            if (LeftY < LeftYMin)
            {
                LeftYMin = LeftY;
            }
            if (LeftY > LeftYMax)
            {
                LeftYMax = LeftY;
            }
            if (Array.Count > DiaNum)
            {
                LeftXMin = ParasCam1.Width;
                LeftXMax = 0;
                LeftYMin = ParasCam1.Height;
                LeftYMax = 0;
                Array.Clear();
            }
        }
        public static double ShieldLeftX = 0, ShieldLeftY = 0, ShieldRightX = 0, ShieldRightY = 0, ShieldPixeDia = 0;
        private static int Shieldlx = 0, Shieldly = 0, Shieldlw = 0, Shieldlh = 0, Shieldrx = 0, Shieldry = 0, Shieldrw = 0, Shieldrh = 0;
        public static double ShieldX = 0, ShieldY = 0, ShieldR = 0;
        public static IntPtr ShieldPointPtr = IntPtr.Zero;
        public static void ShieldMeasure()
        {
            if (Cursor == false)
            {
                Shieldlx = ParasCam1.Shieldlx;
                Shieldly = ParasCam1.Shieldly;
                Shieldlw = ParasCam1.Shieldlw;
                Shieldlh = ParasCam1.Shieldlh;
                Shieldrx = ParasCam1.Shieldrx;
                Shieldry = ParasCam1.Shieldry;
                Shieldrw = ParasCam1.Shieldrw;
                Shieldrh = ParasCam1.Shieldrh;
            }
            int bRet = ExternDll.ShieldDiaFitMeasure(CamUnity.Ptr1, ParasCam1.Width, ParasCam1.Height, Shieldlx, Shieldly, Shieldlw, Shieldlh, Shieldrx, Shieldry, Shieldrw,
                Shieldrh, (short)ParasCam1.ShieldThresholdLeft, (short)ParasCam1.ShieldThresholdRight, 3, 3, 0, 1, 1, 48, ref ShieldX, ref ShieldY, ref ShieldR);
            if (bRet != 0) { ShieldPointPtr = ExternDll.GetShieldDiaPoints(); }
        }
        private static int ShakeCount = 0;
        public static void ShakeCheck()
        {
            if (ShakeCount >= 15)
            {
                if (FrmCrystalShake.StartFlag && Alarm.AlgoCalcuError == false && FrmCrystalShake.FirstTime == false && Mode.Current != Mode.Idle)
                {
                    double tempDis = Math.Sqrt(Math.Pow((FrmCrystalShake.CurrentCenter.X - FrmCrystalShake.LastCenter.X), 2) + Math.Pow((FrmCrystalShake.CurrentCenter.Y - FrmCrystalShake.LastCenter.Y), 2));
                    if (ParasCam1.ShieldDiafac != 0)
                    {
                        tempDis /= ParasCam1.ShieldDiafac;
                    }
                    FrmCrystalShake.Value = tempDis;
                    FrmCrystalShake.AlarmFlag = false;
                    if (Mode.Current == Mode.Neck && tempDis >= ParasCam1.ShakeNeckThreshold)
                    {
                        FrmCrystalShake.AlarmFlag = true;
                        Record.WriteIn("晶体发生晃动", Math.Round(tempDis, 2).ToString("f2"), "Red");
                    }
                    else if (Mode.Current == Mode.Crown && tempDis >= ParasCam1.ShakeCrownThreshold)
                    {
                        FrmCrystalShake.AlarmFlag = true;
                        Record.WriteIn("晶体发生晃动", Math.Round(tempDis, 2).ToString("f2"), "Red");
                    }
                    else if (Mode.Current == Mode.Body && tempDis >= ParasCam1.ShakeBodyThreshold && PLC.ReadCalcValue[14] >= 30)
                    {
                        FrmCrystalShake.AlarmFlag = true;
                        Record.WriteIn("晶体发生晃动", Math.Round(tempDis, 2).ToString("f2"), "Red");
                    }
                    FrmCrystalShake.LastCenter = FrmCrystalShake.CurrentCenter;
                    ShakeCount = 0;
                }
            }
            else
            {
                ShakeCount++;
            }
            if (FrmCrystalShake.StartFlag && FrmCrystalShake.FirstTime)
            {
                FrmCrystalShake.FirstTime = false;
                FrmCrystalShake.LastCenter = FrmCrystalShake.CurrentCenter;
                ShakeCount = 0;
            }
        }
        public static void InitMeasureParas()
        {
            PixelDiameter = 0;
            PixelShortMeltGap = 0;
            PixelMiddleMeltGap = 0;
            PixelLongMeltGap = 0;
            per = 0;
            avg = 0;
            sum = 0;
            ThresholdAvergeValue = 0;
            ThresholdCount = 0;
            ShieldLeftX = 0;
            ShieldLeftY = 0;
            ShieldRightX = 0;
            ShieldRightY = 0;
            ShieldPixeDia = 0;
            NeckMinX1 = 0;
            NeckMinY1 = 0;
            NeckMaxX1 = 0;
            NeckMaxY1 = 0;
            CrownMinX1 = 0;
            CrownMinY1 = 0;
            CrownMaxX1 = 0;
            CrownMaxY1 = 0;
            BodyX = 0;
            BodyY = 0;
            BodyR = 0;
            BodyDiaPointPtr = IntPtr.Zero;
            MeltGapX1 = 0;
            MeltGapX2 = 0;
            MeltGapY = 0;
            MeltGapDistance = 0;
            MeltGapLongX1 = 0;
            MeltGapLongX2 = 0;
            MeltGapLongY = 0;
            MeltGapLongDistance = 0;
        }
        public static void InitMeltGapParas()
        {
            MeltGapShortArray.Clear();
            MeltGapMiddleArray.Clear();
            MeltGapLongArray.Clear();
        }

        public static int MaxIterations = 5;
        public static bool IsFinded = false;
        public static bool IsAction = false;
        public static bool IsFailed = false;


        /// <summary>
        /// 自动曝光
        /// </summary>
        public static void AutoExposure(double TargetVal, double Step, double Tolerance, int StatisticNum)
        {
            if (!IsAction)
            {

                IsAction = true;
                IsFinded = false;
                IsFailed = false;
                Task AdjustTask = new Task(() =>
                {
                    try
                    {
                        Trace.WriteLine("开始自动曝光....");
                        // 每次的调整量
                        double CurrentBright = 0;
                        double Diff = 0;
                        bool IsWaiting = false;
                        double Sum = 0;
                        int StartVal = 0;
                        int EndVal = 0;

                        // 初始统计曝光值
                        IsWaiting = true;
                        // 等待统计曝光...
                        if (IsWaiting)
                        {
                            Sum = 0;
                            Trace.WriteLine("统计曝光中....");
                            for (int j = 1; j <= StatisticNum; j++)
                            {
                                Sum += BrightRTVal;
                                Thread.Sleep(200);
                            }
                            CurrentBright = Sum / StatisticNum;
                            Trace.WriteLine("曝光:" + CurrentBright);
                            IsWaiting = false;
                        }

                        // 判断是否需要调整
                        // 计算调整量
                        Diff = CurrentBright - TargetVal;
                        Trace.WriteLine("差值:" + Diff);
                        if (Diff > 0)
                        {
                            EndVal = ParasCam1.ExpoTime;
                            StartVal = (int)(ParasCam1.ExpoTime - Diff * Step);
                            if (StartVal < 0)
                            {
                                StartVal = 0;
                            }
                        }
                        else
                        {
                            StartVal = ParasCam1.ExpoTime;
                            EndVal = (int)(ParasCam1.ExpoTime - Diff * Step);
                            if (EndVal < 0)
                            {
                                EndVal = 0;
                            }
                        }

                        if (Math.Abs(Diff) < Tolerance)
                        {
                            IsFinded = true;
                            Trace.WriteLine("自动曝光成功");
                            return;
                        }
                        else
                        {
                            ParasCam1.ExpoTime = (StartVal + EndVal) / 2;
                            Trace.WriteLine("曝光调整:" + ParasCam1.ExpoTime);
                            DualCam.SetExpoTime1(DualCam.SelectCam, ParasCam1.ExpoTime);
                        }


                        for (int i = 0; i < MaxIterations; i++)
                        {
                            // 初始统计曝光值
                            IsWaiting = true;
                            // 等待统计曝光...
                            if (IsWaiting)
                            {
                                Trace.WriteLine("统计曝光中....");
                                Sum = 0;
                                for (int j = 1; j <= StatisticNum; j++)
                                {
                                    Sum += BrightRTVal;
                                    Thread.Sleep(200);
                                }
                                CurrentBright = Sum / StatisticNum;
                                Trace.WriteLine("曝光:" + CurrentBright);
                                IsWaiting = false;
                            }
                            // 判断是否需要调整
                            // 计算调整量
                            Diff = CurrentBright - TargetVal;
                            Trace.WriteLine("差值:" + Diff);
                            if (Math.Abs(Diff) < Tolerance)
                            {
                                Trace.WriteLine("自动曝光成功");
                                IsFinded = true;
                                return;
                            }
                            else
                            {

                                if (Diff > 0)
                                {
                                    EndVal = ParasCam1.ExpoTime;

                                }
                                else
                                {
                                    StartVal = ParasCam1.ExpoTime;

                                }
                            }
                            ParasCam1.ExpoTime = (StartVal + EndVal) / 2;
                            Trace.WriteLine("曝光调整:" + ParasCam1.ExpoTime);
                            DualCam.SetExpoTime1(DualCam.SelectCam, ParasCam1.ExpoTime);
                        }
                        IsFailed = true;
                        IsAction = false;
                    }
                    catch
                    {
                        IsFailed = true;
                        Trace.WriteLine("自动曝光异常....");
                        IsAction = false;
                    }
                    finally
                    {
                        IsAction = false;
                    }
                });

                AdjustTask.Start();

            }
        }

         /// <summary>
        /// 重置液温
        /// </summary>
        public static void ResetMeltTemp()
        {
            BrightArray.Clear();
        }
    }
}