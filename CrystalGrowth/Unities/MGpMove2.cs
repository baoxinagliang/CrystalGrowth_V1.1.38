using CamLibrary;
using System.Drawing;

namespace CrystalGrowth.Unities
{
    internal class MGpMove2 : MGpBasic
    {
        public static Point MousePoint;
        public static Rectangle CrossRect, RectNCB;
        public static bool CrossFlag = false, RectNCBFlag = false;
        private static int picXoff = 0, picYoff = 0;
        public static void Move(ref Point movePoint)
        {
            xoff = movePoint.X - MousePoint.X;
            yoff = movePoint.Y - MousePoint.Y;
            picXoff = (int)(xoff / CamUnity.PZoom2.Scale);
            picYoff = (int)(yoff / CamUnity.PZoom2.Scale);
            if (CrossFlag)
            {
                ParasCam2.SeedCenterX += picXoff;
                ParasCam2.SeedCenterY += picYoff;
                if (Mode.Current == Mode.Neck)
                {
                    CalcBody(false);
                }
                MoveArea(ref CrossRect);
            }
            if (RectNCBFlag)
            {
                if (Mode.Current == Mode.Neck)
                {
                    CalcBody(true);
                }
                MoveArea(ref RectNCB);
            }
            MousePoint = movePoint;
        }
        public static void Init()
        {
            CrossFlag = false;
            RectNCBFlag = false;
        }
        public static bool VarJuage()
        {
            if (CrossRect.Contains(MousePoint))
            {
                CrossFlag = true;
                return CrossFlag;
            }
            if (RectNCB.Contains(MousePoint))
            {
                RectNCBFlag = true;
                return RectNCBFlag;
            }
            return false;
        }
        private static void CalcBody(bool sign)
        {
            if (sign)
            {
                ParasCam2.NeckLeftXOffset += picXoff;
                ParasCam2.NeckRightXOffset += picXoff;
                ParasCam2.NeckTopYOffset += picYoff;
                ParasCam2.NeckBottomYOffset += picYoff;
            }
            ParasCam2.NeckLeftX = ParasCam2.SeedCenterX + ParasCam2.NeckLeftXOffset;
            ParasCam2.NeckRightX = ParasCam2.SeedCenterX + ParasCam2.NeckRightXOffset;
            ParasCam2.NeckTopY = ParasCam2.SeedCenterY + ParasCam2.NeckTopYOffset;
            ParasCam2.NeckBottomY = ParasCam2.SeedCenterY + ParasCam2.NeckBottomYOffset;
        }
    }
}
