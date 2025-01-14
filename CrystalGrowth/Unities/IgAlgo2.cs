using CamLibrary;
using CrystalGrowth.AuxFunction.CCD;
using System;

namespace CrystalGrowth.Unities
{
    internal static class IgAlgo2
    {
        // <summary>
        /// 等径测量
        /// </summary>
        /// <returns></returns>
        public static bool Cursor = false;
        public static double NeckX = 0, NeckY = 0, NeckR = 0, CutLineX = 0, CutLineY = 0;
        public static IntPtr NeckDiaPointPtr = IntPtr.Zero;
        private static int NeckLongEdge = 0, NeckShortEdge = 0, NeckCenterX = 0, NeckCenterY = 0;
        public static bool NeckMeasure()
        {
            int bRet, Err = 0;
            if (Cursor == false)
            {
                NeckLongEdge = ParasCam2.NeckRightX - ParasCam2.NeckLeftX;
                NeckShortEdge = ParasCam2.NeckBottomY - ParasCam2.NeckTopY;
                NeckCenterX = ParasCam2.NeckLeftX + NeckLongEdge / 2;
                NeckCenterY = ParasCam2.NeckTopY + NeckShortEdge / 2;
            }
            //晶体直径
            if (PLC.ReadCalcValue[14] >= ParasCam1.CutLineStartLine)
            {
                bRet = ExternDll.DiaFitMeasureWhitCL2(CamUnity.Ptr2, ParasCam2.Width, ParasCam2.Height, NeckCenterX,
                    NeckCenterY, NeckLongEdge, NeckShortEdge, ParasCam2.NeckThreshold, 3, 3, 0, 1, 1, 48, ParasCam1.CutLineThroshold,
                    ref NeckX, ref NeckY, ref NeckR, ref CutLineX, ref CutLineY, ref FrmCutLineCheck.CatchFlag);
            }
            else
            {
                bRet = ExternDll.DiaFitMeasure2(CamUnity.Ptr2, ParasCam2.Width, ParasCam2.Height, NeckCenterX, NeckCenterY,
                    NeckLongEdge, NeckShortEdge, ParasCam2.NeckThreshold, 3, 3, 0, 1, 1, 48, ref NeckX, ref NeckY, ref NeckR);
            }
            if (bRet == 0)
            {
                Err++;
            }
            else
            {
                NeckDiaPointPtr = ExternDll.GetDiaPoints2();
            }
            if (Err == 0 && (NeckX <= 0 || NeckY <= 0 || NeckR <= 750 || NeckR >= 2000))
            {
                Err++;
            }
            if (Err == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
