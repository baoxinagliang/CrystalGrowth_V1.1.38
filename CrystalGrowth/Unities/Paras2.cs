using CamLibrary;
using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace CrystalGrowth.Unities
{
    internal class Paras2 : ParasBasic
    {
        public static Graphics g;
        private static int CenterX, CenterY;
        private static int NeckLeftX, NeckTopY, NeckWidth, NeckHeight, NeckPointX, NeckPointY;
        private static int NeckX, NeckY, NeckR, NeckPX, NeckPY;
        /// <summary>
        /// 计算页面现实基础数据
        /// </summary>
        public static void CalcBasicData(ref double scale)
        {
            CenterX = (int)((ParasCam2.SeedCenterX - CamUnity.PZoom2.SrcSX) * scale);
            CenterY = (int)((ParasCam2.SeedCenterY - CamUnity.PZoom2.SrcSY) * scale);
            g.DrawLine(PenGreen, CenterX - 3, CenterY, CenterX + 3, CenterY);//画十字横线
            g.DrawLine(PenGreen, CenterX, CenterY - 3, CenterX, CenterY + 3);//画十字竖线
        }
        /// <summary>
        /// 画等径
        /// </summary>
        public static void DrawNeck(ref double Scale)
        {
            int i = 0;
            NeckLeftX = (int)((ParasCam2.NeckLeftX - CamUnity.PZoom2.SrcSX) * Scale);
            NeckTopY = (int)((ParasCam2.NeckTopY - CamUnity.PZoom2.SrcSY) * Scale);
            NeckWidth = (int)((ParasCam2.NeckRightX - ParasCam2.NeckLeftX) * Scale);
            NeckHeight = (int)((ParasCam2.NeckBottomY - ParasCam2.NeckTopY) * Scale);
            NeckX = (int)((IgAlgo2.NeckX - CamUnity.PZoom2.SrcSX) * Scale);
            NeckY = (int)((IgAlgo2.NeckY - CamUnity.PZoom2.SrcSY) * Scale);
            NeckR = (int)(IgAlgo2.NeckR * Scale);
            while (i < 100 && IgAlgo2.NeckDiaPointPtr != IntPtr.Zero)
            {
                NeckPointX = Marshal.ReadInt32(IgAlgo2.NeckDiaPointPtr, i * 8);
                NeckPointY = Marshal.ReadInt32(IgAlgo2.NeckDiaPointPtr, i * 8 + 4);
                if (NeckPointX > 0 && NeckPointY > 0)
                {
                    NeckPX = (int)((NeckPointX - CamUnity.PZoom2.SrcSX) * Scale);
                    NeckPY = (int)((NeckPointY - CamUnity.PZoom2.SrcSY) * Scale);
                    g.FillEllipse(BrushBlue, NeckPX - 2, NeckPY - 2, 4, 4);
                }
                i++;
            }
            g.DrawRectangle(PenGreen, NeckLeftX, NeckTopY, NeckWidth, NeckHeight);
            g.FillEllipse(BrushBlue, NeckX - 4, NeckY - 4, 8, 8);
            //g.DrawEllipse(PenRed, BodyX - BodyR, BodyY - BodyR, BodyR * 2, BodyR * 2);
            if (NeckR >= 10)
                g.DrawArc(PenRed, NeckX - NeckR, NeckY - NeckR, NeckR * 2, NeckR * 2, 15, 150);
        }
        public static void MouseNewRect()
        {
            Cross();
            ModeNCB();
        }
        private static void Cross()
        {
            MGpMove2.CrossRect = new Rectangle(CenterX - 6, CenterY - 6, 12, 12);
        }
        private static void ModeNCB()
        {
            if (Mode.Current == Mode.Neck)
            {
                MGpMove2.RectNCB = new Rectangle(NeckLeftX, NeckTopY, NeckWidth, NeckHeight);
            }
        }
    }
}
