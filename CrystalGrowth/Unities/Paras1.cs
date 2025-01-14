using CamLibrary;
using CrystalGrowth.AuxFunction.CCD;
using CrystalGrowth.CrystalCtl;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace CrystalGrowth.Unities
{
    internal class Paras1 : ParasBasic
    {
        private static int HAreaLeftX, HAreaLineY, HAreaRightX, HAreaLineYUp, HAreaLineYDown;
        private static int CenterX, CenterY, ShieldCenterX, ShieldCenterY;
        private static int BrightLeftX, BrightPointY, BrightWidth, BrightRightX;
        private static int PreLeftX, PreRightX, PrePointY;
        private static int MeltGapLongLeftX, MeltGapLongRightX, MeltGapLeftX, MeltGapRightX;
        private static int MeltGapLongX1, MeltGapLongX2, MeltGapX1, MeltGapX2, MeltGapY, MeltGapYUp, MeltGapYDown;
        private static int NeckLeftX, NeckTopY, NeckWidth, NeckHeight, NeckPointX, NeckPointY;
        private static int NeckMinX, NeckMinY, NeckMaxX, NeckMaxY;
        private static int NeckX, NeckY, NeckR, NeckPX, NeckPY;
        private static int CrownLeftX, CrownTopY, CrownWidth, CrownHeight;
        private static int CrownMinX, CrownMinY, CrownMaxX, CrownMaxY;
        private static int BodyLeftX, BodyTopY, BodyWidth, BodyHeight, BodyPointX, BodyPointY;
        private static int BodyX, BodyY, BodyR, BodyPX, BodyPY;
        private static int Shieldlx, Shieldly, Shieldlw, Shieldlh, Shieldrx, Shieldry, Shieldrw, Shieldrh;
        private static int ShieldX, ShieldY, ShieldR, ShieldPointX, ShieldPointY, ShieldPX, ShieldPY;
        private static int CutLineX, CutLineY;
        public static Graphics g;
        /// <summary>
        /// 计算页面现实基础数据
        /// </summary>
        public static void CalcBasicData(ref double Scale)
        {
            CenterX = (int)((ParasCam1.SeedCenterX - CamUnity.PZoom1.SrcSX) * Scale);
            CenterY = (int)((ParasCam1.SeedCenterY - CamUnity.PZoom1.SrcSY) * Scale);
            ShieldCenterX = (int)((ParasCam1.ShieldCenterX - CamUnity.PZoom1.SrcSX) * Scale);
            ShieldCenterY = (int)((ParasCam1.ShieldCenterY - CamUnity.PZoom1.SrcSY) * Scale);
            HAreaLeftX = (int)((ParasCam1.HAreaLeftX - CamUnity.PZoom1.SrcSX) * Scale);
            HAreaLineY = (int)((ParasCam1.HAreaLineY - CamUnity.PZoom1.SrcSY) * Scale);
            HAreaRightX = (int)((ParasCam1.HAreaRightX - CamUnity.PZoom1.SrcSX) * Scale);
            HAreaLineYUp = HAreaLineY + 3;
            HAreaLineYDown = HAreaLineY - 3;
            g.FillEllipse(BrushGreen, ShieldCenterX - 4, ShieldCenterY - 4, 8, 8);
            g.DrawLine(PenGreen, CenterX - 3, CenterY, CenterX + 3, CenterY);//画十字横线
            g.DrawLine(PenGreen, CenterX, CenterY - 3, CenterX, CenterY + 3);//画十字竖线
            g.DrawLine(PenGreen, HAreaLeftX, HAreaLineY, HAreaRightX, HAreaLineY);//画HArea线长度       
            g.DrawLine(PenGreen, HAreaLeftX, HAreaLineYUp, HAreaLeftX, HAreaLineYDown);//画HArea左竖线
            g.DrawLine(PenGreen, HAreaRightX, HAreaLineYUp, HAreaRightX, HAreaLineYDown);//画HArea右竖线
        }
        /// <summary>
        /// 画引晶
        /// </summary>
        public static void DrawNeck(ref double Scale)
        {
            NeckMinX = (int)((IgAlgo1.NeckMinX1 - CamUnity.PZoom1.SrcSX) * Scale);
            NeckMinY = (int)((IgAlgo1.NeckMinY1 - CamUnity.PZoom1.SrcSY) * Scale);
            NeckMaxX = (int)((IgAlgo1.NeckMaxX1 - CamUnity.PZoom1.SrcSX) * Scale);
            NeckMaxY = (int)((IgAlgo1.NeckMaxY1 - CamUnity.PZoom1.SrcSY) * Scale);
            NeckLeftX = (int)((ParasCam1.NeckLeftX - CamUnity.PZoom1.SrcSX) * Scale);
            NeckTopY = (int)((ParasCam1.NeckTopY - CamUnity.PZoom1.SrcSY) * Scale);
            NeckWidth = (int)((ParasCam1.NeckRightX - ParasCam1.NeckLeftX) * Scale);
            NeckHeight = (int)((ParasCam1.NeckBottomY - ParasCam1.NeckTopY) * Scale);
            g.DrawRectangle(PenGreen, NeckLeftX, NeckTopY, NeckWidth, NeckHeight);//框
            g.DrawLine(PenRed, NeckMinX, NeckMinY + 3, NeckMinX, NeckMinY - 3);//竖线
            g.DrawLine(PenRed, NeckMaxX, NeckMaxY + 3, NeckMaxX, NeckMaxY - 3);//竖线
            if (NeckMinX < NeckMaxX)
            {
                g.DrawLine(PenRed, NeckLeftX, NeckMinY, NeckMinX, NeckMinY);//横线
                g.DrawLine(PenRed, NeckMaxX, NeckMaxY, NeckLeftX + NeckWidth, NeckMaxY);//横线      
            }
        }
        //20221201  拟合圆测量引晶直径
        /// <summary>
        /// 绘制引晶拟合圆和测量点
        /// </summary>
        /// <param name="Scale"></param>
        public static void DrawNeckFitCircle(ref double Scale)
        {
            int i = 0;
            NeckLeftX = (int)((ParasCam1.NeckLeftX - CamUnity.PZoom1.SrcSX) * Scale);
            NeckTopY = (int)((ParasCam1.NeckTopY - CamUnity.PZoom1.SrcSY) * Scale);
            NeckWidth = (int)((ParasCam1.NeckRightX - ParasCam1.NeckLeftX) * Scale);
            NeckHeight = (int)((ParasCam1.NeckBottomY - ParasCam1.NeckTopY) * Scale);
            NeckX = (int)((IgAlgo1.NeckX - CamUnity.PZoom1.SrcSX) * Scale);
            NeckY = (int)((IgAlgo1.NeckY - CamUnity.PZoom1.SrcSY) * Scale);
            NeckR = (int)(IgAlgo1.NeckR * Scale);
            while (i < IgAlgo1.NeckShortEdge && IgAlgo1.NeckDiaPointPtr != IntPtr.Zero)
            {
                NeckPointX = Marshal.ReadInt32(IgAlgo1.NeckDiaPointPtr, i * 8);
                NeckPointY = Marshal.ReadInt32(IgAlgo1.NeckDiaPointPtr, i * 8 + 4);
                if (NeckPointX > 0 && NeckPointY > 0)
                {
                    NeckPX = (int)((NeckPointX - CamUnity.PZoom1.SrcSX) * Scale);
                    NeckPY = (int)((NeckPointY - CamUnity.PZoom1.SrcSY) * Scale);
                    //连续测量时不显示测量点
                    if (FrmImage.DrawNeckMeasuredPointFlag == true)
                    {
                        g.FillEllipse(BrushBlue, NeckPX - 2, NeckPY - 2, 4, 4);
                    }
                }
                i++;
            }
            g.DrawRectangle(PenGreen, NeckLeftX, NeckTopY, NeckWidth, NeckHeight);
            if (NeckR >= 10)
            {
                g.DrawArc(PenRed, NeckX - NeckR, NeckY - NeckR, NeckR * 2, NeckR * 2, 0, 180);
            }
        }
        /// <summary>
        /// 画放肩
        /// </summary>
        public static void DrawCrown(ref double Scale)
        {
            CrownLeftX = (int)((ParasCam1.CrownLeftX - CamUnity.PZoom1.SrcSX) * Scale);
            CrownTopY = (int)((ParasCam1.CrownTopY - CamUnity.PZoom1.SrcSY) * Scale);
            CrownWidth = (int)((ParasCam1.CrownRightX - ParasCam1.CrownLeftX) * Scale);
            CrownHeight = (int)((ParasCam1.CrownBottomY - ParasCam1.CrownTopY) * Scale);
            CrownMinX = (int)((IgAlgo1.CrownMinX1 - CamUnity.PZoom1.SrcSX) * Scale);
            CrownMinY = (int)((IgAlgo1.CrownMinY1 - CamUnity.PZoom1.SrcSY) * Scale);
            CrownMaxX = (int)((IgAlgo1.CrownMaxX1 - CamUnity.PZoom1.SrcSX) * Scale);
            CrownMaxY = (int)((IgAlgo1.CrownMaxY1 - CamUnity.PZoom1.SrcSY) * Scale);
            g.DrawRectangle(PenGreen, CrownLeftX, CrownTopY, CrownWidth, CrownHeight);
            g.DrawLine(PenRed, CrownMinX, CrownMinY + 3, CrownMinX, CrownMinY - 3);//竖线 
            g.DrawLine(PenRed, CrownMaxX, CrownMaxY + 3, CrownMaxX, CrownMaxY - 3);//竖线
            if (CrownMinX < CrownMaxX)
            {
                g.DrawLine(PenRed, CrownLeftX, CrownMinY, CrownMinX, CrownMinY);//横线
                g.DrawLine(PenRed, CrownMaxX, CrownMaxY, CrownLeftX + CrownWidth, CrownMaxY);//横线
            }
        }
        /// <summary>
        /// 画等径
        /// </summary>
        public static void DrawBody(ref double Scale)
        {
            int i = 0;
            BodyLeftX = (int)((ParasCam1.BodyLeftX - CamUnity.PZoom1.SrcSX) * Scale);
            BodyTopY = (int)((ParasCam1.BodyTopY - CamUnity.PZoom1.SrcSY) * Scale);
            BodyWidth = (int)((ParasCam1.BodyRightX - ParasCam1.BodyLeftX) * Scale);
            BodyHeight = (int)((ParasCam1.BodyBottomY - ParasCam1.BodyTopY) * Scale);
            BodyX = (int)((IgAlgo1.BodyX - CamUnity.PZoom1.SrcSX) * Scale);
            BodyY = (int)((IgAlgo1.BodyY - CamUnity.PZoom1.SrcSY) * Scale);
            BodyR = (int)(IgAlgo1.BodyR * Scale);
            while (i < 100 && IgAlgo1.BodyDiaPointPtr != IntPtr.Zero)
            {
                BodyPointX = Marshal.ReadInt32(IgAlgo1.BodyDiaPointPtr, i * 8);
                BodyPointY = Marshal.ReadInt32(IgAlgo1.BodyDiaPointPtr, i * 8 + 4);
                if (BodyPointX > 0 && BodyPointY > 0)
                {
                    BodyPX = (int)((BodyPointX - CamUnity.PZoom1.SrcSX) * Scale);
                    BodyPY = (int)((BodyPointY - CamUnity.PZoom1.SrcSY) * Scale);
                    g.FillEllipse(BrushBlue, BodyPX - 2, BodyPY - 2, 4, 4);
                }
                i++;
            }
            g.DrawRectangle(PenGreen, BodyLeftX, BodyTopY, BodyWidth, BodyHeight);
            //if (BodyX > 15)
            //{
            //    g.FillEllipse(BrushBlue, BodyX - 4, BodyY - 4, 8, 8);
            //}
            // g.DrawEllipse(PenRed, BodyX - BodyRX, BodyY - BodyRY, BodyRX * 2, BodyRY * 2);
            if (BodyR >= 10)
            {
                g.DrawArc(PenRed, BodyX - BodyR, BodyY - BodyR, BodyR * 2, BodyR * 2, 15, 150);
            }
        }
        /// <summary>
        /// 画长液口距
        /// </summary>
        public static void DrawMeltGapLong(ref double Scale)
        {
            if (IgAlgo1.MeltGapLongX1 == 0 && IgAlgo1.MeltGapLongX2 == 0)
            {
                MeltGapLongX1 = (int)((ParasCam1.MeltGapLongLeftX - CamUnity.PZoom1.SrcSX) * Scale);
                MeltGapLongX2 = (int)((ParasCam1.MeltGapLongRightX - CamUnity.PZoom1.SrcSX) * Scale);
            }
            else
            {
                MeltGapLongX1 = (int)((IgAlgo1.MeltGapLongX1 - CamUnity.PZoom1.SrcSX) * Scale);
                MeltGapLongX2 = (int)((IgAlgo1.MeltGapLongX2 - CamUnity.PZoom1.SrcSX) * Scale);
            }
            MeltGapY = (int)((ParasCam1.MeltGapLineY - CamUnity.PZoom1.SrcSY) * Scale);
            MeltGapLongLeftX = (int)((ParasCam1.MeltGapLongLeftX - CamUnity.PZoom1.SrcSX) * Scale);
            MeltGapLongRightX = (int)((ParasCam1.MeltGapLongRightX - CamUnity.PZoom1.SrcSX) * Scale);
            MeltGapYUp = MeltGapY + 3;
            MeltGapYDown = MeltGapY - 3;
            g.DrawLine(PenRed, MeltGapLongLeftX, MeltGapY, MeltGapLongRightX, MeltGapY);//画MeltGap直线长度
            g.DrawLine(PenRed, MeltGapLongX1, MeltGapYUp, MeltGapLongX1, MeltGapYDown);
            g.DrawLine(PenRed, MeltGapLongX2, MeltGapYUp, MeltGapLongX2, MeltGapYDown);
        }

        /// <summary>
        /// 画绝对液口距
        /// </summary>
        public static void DrawMeltGapAbs(ref double Scale)
        {
            bool isBrush = !CamUnity.PZoom1.Flag;
            //计算出参考圆，未缩放
            if (IgAlgo1.YKJInfoPre.index == 1 && isBrush)
            {

                Matrix SoureceMatrix = g.Transform;

                var aR = IgAlgo1.YKJInfoPre.far_ellips.lkellips_height * Scale;
                var bR = IgAlgo1.YKJInfoPre.far_ellips.lkellips_width * Scale;
                var Angle = IgAlgo1.YKJInfoPre.far_ellips.lkellips_angle;
                var x = IgAlgo1.YKJInfoPre.far_ellips.x * Scale - aR / 2 - CamUnity.PZoom1.SrcSX * Scale;
                var y = IgAlgo1.YKJInfoPre.far_ellips.y * Scale - bR / 2 - CamUnity.PZoom1.SrcSY * Scale;
                Matrix matrix = g.Transform;
                matrix = g.Transform;
                matrix.RotateAt((float)(Angle - 90), new PointF((float)(IgAlgo1.YKJInfoPre.near_ellips.x * Scale - CamUnity.PZoom1.SrcSX * Scale), (float)(IgAlgo1.YKJInfoPre.near_ellips.y * Scale - CamUnity.PZoom1.SrcSY * Scale)));
                g.Transform = matrix;
                Pen PenBlue = new Pen(Color.Blue, 1);//蓝色
                g.DrawEllipse(PenBlue, (float)x, (float)y, (float)aR, (float)bR);
                g.Transform = SoureceMatrix;
                aR = IgAlgo1.YKJInfoPre.near_ellips.lkellips_height * Scale;
                bR = IgAlgo1.YKJInfoPre.near_ellips.lkellips_width * Scale;
                Angle = IgAlgo1.YKJInfoPre.near_ellips.lkellips_angle;
                x = IgAlgo1.YKJInfoPre.near_ellips.x * Scale - aR / 2 - CamUnity.PZoom1.SrcSX * Scale;
                y = IgAlgo1.YKJInfoPre.near_ellips.y * Scale - bR / 2 - CamUnity.PZoom1.SrcSY * Scale;
                //g.DrawArc(PenRed, (float)x, (float)y, (float)aR, (float)bR, -210, 240);

                matrix = g.Transform;
                matrix.RotateAt((float)(Angle - 90), new PointF((float)(IgAlgo1.YKJInfoPre.near_ellips.x * Scale - CamUnity.PZoom1.SrcSX * Scale), (float)(IgAlgo1.YKJInfoPre.near_ellips.y * Scale - CamUnity.PZoom1.SrcSY * Scale)));
                g.Transform = matrix;
                Pen PenRed = new Pen(Color.Red, 1);//红色
                g.DrawEllipse(PenRed, (float)x, (float)y, (float)aR, (float)bR);
                g.Transform = SoureceMatrix;
            }
        }


        /// <summary>
        /// 画绝对液口距识别边缘点
        /// </summary>
        /// <param name="Scale"></param>
        public static void DrawMeltGapAbsArea(ref double Scale)
        {
            bool isBrush = !CamUnity.PZoom1.Flag;
            int BreakNum = 15;//间隔显示长度
            SolidBrush BrushBlue = new SolidBrush(Color.Blue);
            SolidBrush BrushGreen = new SolidBrush(Color.FromArgb(0, 255, 0));
            //绘制到边缘点
            if (IgAlgo1.MeltGapAbsMeasureP != IntPtr.Zero && IgAlgo1.YKJInfo.index == 1)
            {
                for (int i = 0; i < 1000; i = i + BreakNum)
                {
                    var bufX = Marshal.ReadInt32(IgAlgo1.MeltGapAbsMeasureP, i * 8);
                    var bufY = Marshal.ReadInt32(IgAlgo1.MeltGapAbsMeasureP, i * 8 + 4);
                    IgAlgo1.XPre[i] = bufX;
                    IgAlgo1.yPre[i] = bufY;
                    if (bufX > 0 && bufY > 0)
                    {
                        var bufPX = (int)((bufX - CamUnity.PZoom1.SrcSX) * Scale);
                        var bufPY = (int)((bufY - CamUnity.PZoom1.SrcSY) * Scale);
                        if (isBrush)
                        {
                            g.FillEllipse(BrushBlue, bufPX - 2, bufPY - 2, 4, 4);
                        }
                    }
                }
                for (int i = 1000; i < 2000; i = i + BreakNum)
                {
                    var bufX = Marshal.ReadInt32(IgAlgo1.MeltGapAbsMeasureP, i * 8);
                    var bufY = Marshal.ReadInt32(IgAlgo1.MeltGapAbsMeasureP, i * 8 + 4);
                    IgAlgo1.XPre[i] = bufX;
                    IgAlgo1.yPre[i] = bufY;
                    if (bufX > 0 && bufY > 0)
                    {
                        var bufPX = (int)((bufX - CamUnity.PZoom1.SrcSX) * Scale);
                        var bufPY = (int)((bufY - CamUnity.PZoom1.SrcSY) * Scale);
                        if (isBrush)
                        {
                            g.FillEllipse(BrushGreen, bufPX - 2, bufPY - 2, 4, 4);
                        }
                    }
                }
            }
            else if (IgAlgo1.MeltGapAbsMeasureP != IntPtr.Zero)
            {
                for (int i = 0; i < 1000; i = i + BreakNum)
                {
                    var bufX = IgAlgo1.XPre[i];
                    var bufY = IgAlgo1.yPre[i];

                    if (bufX > 0 && bufY > 0)
                    {
                        var bufPX = (int)((bufX - CamUnity.PZoom1.SrcSX) * Scale);
                        var bufPY = (int)((bufY - CamUnity.PZoom1.SrcSY) * Scale);
                        if (isBrush)
                        {
                            g.FillEllipse(BrushBlue, bufPX - 2, bufPY - 2, 4, 4);
                        }
                    }
                }
                for (int i = 1000; i < 2000; i = i + BreakNum)
                {
                    var bufX = IgAlgo1.XPre[i];
                    var bufY = IgAlgo1.yPre[i];
                    if (bufX > 0 && bufY > 0)
                    {
                        var bufPX = (int)((bufX - CamUnity.PZoom1.SrcSX) * Scale);
                        var bufPY = (int)((bufY - CamUnity.PZoom1.SrcSY) * Scale);
                        if (isBrush)
                        {
                            g.FillEllipse(BrushGreen, bufPX - 2, bufPY - 2, 4, 4);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 画短液口距
        /// </summary>
        public static void DrawMeltGap(ref double Scale)
        {
            if (IgAlgo1.MeltGapX1 == 0 && IgAlgo1.MeltGapX2 == 0)
            {
                MeltGapX1 = (int)((ParasCam1.MeltGapLeftX - CamUnity.PZoom1.SrcSX) * Scale);
                MeltGapX2 = (int)((ParasCam1.MeltGapRightX - CamUnity.PZoom1.SrcSX) * Scale);
            }
            else
            {
                MeltGapX1 = (int)((IgAlgo1.MeltGapX1 - CamUnity.PZoom1.SrcSX) * Scale);
                MeltGapX2 = (int)((IgAlgo1.MeltGapX2 - CamUnity.PZoom1.SrcSX) * Scale);
            }
            MeltGapY = (int)((ParasCam1.MeltGapLineY - CamUnity.PZoom1.SrcSY) * Scale);
            MeltGapLeftX = (int)((ParasCam1.MeltGapLeftX - CamUnity.PZoom1.SrcSX) * Scale);
            MeltGapRightX = (int)((ParasCam1.MeltGapRightX - CamUnity.PZoom1.SrcSX) * Scale);
            MeltGapYUp = MeltGapY + 3;
            MeltGapYDown = MeltGapY - 3;
            g.DrawLine(PenRed, MeltGapX1, MeltGapYUp, MeltGapX1, MeltGapYDown);
            g.DrawLine(PenRed, MeltGapX2, MeltGapYUp, MeltGapX2, MeltGapYDown);
            g.DrawLine(PenGreen, MeltGapLeftX, MeltGapY, MeltGapRightX, MeltGapY);//画MeltGap直线长度
        }
        /// <summary>
        /// 画预热
        /// </summary>
        public static void DrawPreTemp(ref double Scale)
        {
            PreLeftX = (int)((ParasCam1.BrightPreLeftX - CamUnity.PZoom1.SrcSX) * Scale);
            PreRightX = (int)((ParasCam1.BrightPreRightX - CamUnity.PZoom1.SrcSX) * Scale);
            PrePointY = (int)((ParasCam1.BrightPrePointY - CamUnity.PZoom1.SrcSY) * Scale);
            BrightWidth = (int)(ParasCam1.BrightWidth * Scale);
            g.DrawRectangle(PenGreen, PreLeftX, PrePointY, BrightWidth, BrightWidth);
            g.DrawRectangle(PenGreen, PreRightX, PrePointY, BrightWidth, BrightWidth);
        }
        /// <summary>
        /// 画明亮度
        /// </summary>
        public static void DrawBright(ref double Scale)
        {
            BrightLeftX = (int)((ParasCam1.BrightLeftX - CamUnity.PZoom1.SrcSX) * Scale);
            BrightPointY = (int)((ParasCam1.BrightPointY - CamUnity.PZoom1.SrcSY) * Scale);
            BrightRightX = (int)((ParasCam1.BrightRightX - CamUnity.PZoom1.SrcSX) * Scale);
            BrightWidth = (int)(ParasCam1.BrightWidth * Scale);
            g.DrawRectangle(PenGreen, BrightLeftX, BrightPointY, BrightWidth, BrightWidth);
            g.DrawRectangle(PenGreen, BrightRightX, BrightPointY, BrightWidth, BrightWidth);
        }
        /// <summary>
        /// 画断线检测
        /// </summary>
        public static void DrawCutLineCheck(ref double Scale)
        {
            CutLineX = (int)((IgAlgo1.CutLineX - CamUnity.PZoom1.SrcSX) * Scale);
            CutLineY = (int)((IgAlgo1.CutLineY - CamUnity.PZoom1.SrcSY) * Scale);
            if (CutLineX > 20)
            {
                g.DrawRectangle(PenRed, CutLineX - 9, CutLineY - 9, 16, 16);
            }
        }
        /// <summary>
        /// 画导流筒
        /// </summary>
        public static void DrawShieldMeasure(ref double Scale)
        {
            int i = 0;
            Shieldlx = (int)((ParasCam1.Shieldlx - CamUnity.PZoom1.SrcSX) * Scale);
            Shieldly = (int)((ParasCam1.Shieldly - CamUnity.PZoom1.SrcSY) * Scale);
            Shieldlw = (int)(ParasCam1.Shieldlw * Scale);
            Shieldlh = (int)(ParasCam1.Shieldlh * Scale);
            Shieldrx = (int)((ParasCam1.Shieldrx - CamUnity.PZoom1.SrcSX) * Scale);
            Shieldry = (int)((ParasCam1.Shieldry - CamUnity.PZoom1.SrcSY) * Scale);
            Shieldrw = (int)(ParasCam1.Shieldrw * Scale);
            Shieldrh = (int)(ParasCam1.Shieldrh * Scale);
            ShieldX = (int)((IgAlgo1.ShieldX - CamUnity.PZoom1.SrcSX) * Scale);
            ShieldY = (int)((IgAlgo1.ShieldY - CamUnity.PZoom1.SrcSY) * Scale);
            ShieldR = (int)(IgAlgo1.ShieldR * Scale);
            g.DrawRectangle(PenGreen, Shieldlx, Shieldly, Shieldlw, Shieldlh);
            g.DrawRectangle(PenGreen, Shieldrx, Shieldry, Shieldrw, Shieldrh);         
            while (i < 200 && IgAlgo1.ShieldPointPtr != IntPtr.Zero)
            {
                ShieldPointX = Marshal.ReadInt32(IgAlgo1.ShieldPointPtr, i * 8);
                ShieldPointY = Marshal.ReadInt32(IgAlgo1.ShieldPointPtr, i * 8 + 4);
                if (ShieldPointX > 0 && ShieldPointY > 0)
                {
                    ShieldPX = (int)((ShieldPointX - CamUnity.PZoom1.SrcSX) * Scale);
                    ShieldPY = (int)((ShieldPointY - CamUnity.PZoom1.SrcSY) * Scale);
                    g.FillEllipse(BrushBlue, ShieldPX - 2, ShieldPY - 2, 4, 4);
                }
                i++;
            }
            g.FillEllipse(BrushGreen, ShieldX - 4, ShieldY - 4, 8, 8);
            if (ShieldR >= 10)
            {
                g.DrawArc(PenRed, ShieldX - ShieldR, ShieldY - ShieldR, ShieldR * 2, ShieldR * 2, 0, 360);
            }
        }
        #region 鼠标移动绘图参数赋值
        public static void MouseNewRect()
        {
            HCross();
            ModeNCB();
            MeltGap();
            Bright();
            Shield();
        }
        private static void HCross()
        {
            MGpMove1.CrossRect = new Rectangle(CenterX - 6, CenterY - 6, 12, 12);
            MGpMove1.RectH = new Rectangle(HAreaLeftX, HAreaLineY - 6, HAreaRightX - HAreaLeftX, 12);
        }
        private static void Shield()
        {
            if (FrmShieldMeasure.StartFlag)
            {
                MGpMove1.ShieldRectL = new Rectangle(Shieldlx, Shieldly, Shieldlw, Shieldlh);
                MGpMove1.ShieldRectR = new Rectangle(Shieldrx, Shieldry, Shieldrw, Shieldrh);
            }
        }
        private static void Bright()
        {
            if (FrmMeltTemp.PreTempRunningFlag)
            {
                MGpMove1.BrightRect1 = new Rectangle(PreLeftX, PrePointY, BrightWidth + 8, BrightWidth + 8);
                MGpMove1.BrightRect2 = new Rectangle(PreRightX, PrePointY, BrightWidth + 8, BrightWidth + 8);
            }
            else
            {
                MGpMove1.BrightRect1 = new Rectangle(BrightLeftX, BrightPointY, BrightWidth, BrightWidth);
                MGpMove1.BrightRect2 = new Rectangle(BrightRightX, BrightPointY, BrightWidth, BrightWidth);
            }
        }
        private static void ModeNCB()
        {
            switch (Mode.Current)
            {
                case 1:
                    MGpMove1.RectNCB = new Rectangle(NeckLeftX, NeckTopY, NeckWidth, NeckHeight);
                    break;
                case 2:
                    MGpMove1.RectNCB = new Rectangle(CrownLeftX, CrownTopY, CrownWidth, CrownHeight);
                    break;
                case 3:
                    MGpMove1.RectNCB = new Rectangle(BodyLeftX, BodyTopY, BodyWidth, BodyHeight);
                    break;
            }
        }
        private static void MeltGap()
        {
            if (Mode.MeltGapFlag)
            {
                if (FrmMeltGapLArea.IsOpen)
                {
                    MGpMove1.RectMeltGapH = new Rectangle(MeltGapLongLeftX, MeltGapY - 6, MeltGapLongRightX - MeltGapLongLeftX, 12);
                }
                else
                {
                    MGpMove1.RectMeltGapH = new Rectangle(MeltGapLeftX, MeltGapY - 6, MeltGapRightX - MeltGapLeftX, 12);
                }
            }
            else//PLC手动液口距画图long
            {
                if (FrmMeltGapArea.IsOpen)
                {
                    MGpMove1.RectMeltGapH = new Rectangle(MeltGapLeftX, MeltGapY - 6, MeltGapRightX - MeltGapLeftX, 12);
                }
                else
                {
                    MGpMove1.RectMeltGapH = new Rectangle(MeltGapLongLeftX, MeltGapY - 6, MeltGapLongRightX - MeltGapLongLeftX, 12);
                }
            }
        }
        #endregion
    }
}
