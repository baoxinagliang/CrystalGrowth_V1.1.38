using CamLibrary;
using CrystalGrowth.AuxFunction.CCD;
using CrystalGrowth.CrystalCtl;
using System.Drawing;

namespace CrystalGrowth.Unities
{
    internal class MGpMove1 : MGpBasic
    {
        public static Point MousePoint;
        public static Rectangle CrossRect, BrightRect1, BrightRect2, RectNCB, RectH, ShieldRectL, ShieldRectR, RectMeltGapH;
        public static bool CrossFlag = false, RectNCBFlag = false, RectHFlag = false, RectMeltGapHFlag = false;
        public static bool BrightRect1Flag = false, BrightRect2Flag = false, ShieldRectLFlag = false, ShieldRectRFlag = false;
        private static int picXoff = 0, picYoff = 0;
        public static void Move(ref Point movePoint)
        {
            xoff = movePoint.X - MousePoint.X;
            yoff = movePoint.Y - MousePoint.Y;
            picXoff = (int)(xoff / CamUnity.PZoom1.Scale);
            picYoff = (int)(yoff / CamUnity.PZoom1.Scale);
            if (CrossFlag)
            {
                ParasCam1.SeedCenterX += picXoff;
                ParasCam1.SeedCenterY += picYoff;
                switch (Mode.Current)
                {
                    case 1:
                        CalcNeck(false);
                        break;
                    case 2:
                        CalcCrown(false);
                        break;
                    case 3:
                        CalcBody(false);
                        break;
                }
                MoveArea(ref CrossRect);
            }
            if (RectNCBFlag)
            {
                switch (Mode.Current)
                {
                    case 1:
                        CalcNeck(true);
                        break;
                    case 2:
                        CalcCrown(true);
                        break;
                    case 3:
                        CalcBody(true);
                        break;
                }
                MoveArea(ref RectNCB);
            }
            if (RectHFlag)
            {
                CalcHData();
                MoveArea(ref RectH);
            }
            if (RectMeltGapHFlag)
            {
                if (Mode.MeltGapFlag)
                {
                    if (FrmMeltGapLArea.IsOpen)
                    {
                        CalcMeltGapLong();
                    }
                    else
                    {
                        CalcMeltGap();
                    }
                }
                else//PLC手动液口距画图long
                {
                    if (FrmMeltGapArea.IsOpen)
                    {
                        CalcMeltGap();
                    }
                    else
                    {
                        CalcMeltGapLong();
                    }
                }
                MoveArea(ref RectMeltGapH);
            }
            if (BrightRect1Flag)
            {
                if (FrmMeltTemp.PreTempRunningFlag)
                {
                    CalcBrightPreL();
                }
                else
                {
                    CalcBrightL();
                }
                MoveArea(ref BrightRect1);
            }
            if (BrightRect2Flag)
            {
                if (FrmMeltTemp.PreTempRunningFlag)
                {
                    CalcBrightPreR();
                }
                else
                {
                    CalcBrightR();
                }
                MoveArea(ref BrightRect2);
            }
            if (ShieldRectLFlag)
            {
                ParasCam1.Shieldlx += picXoff;
                ParasCam1.Shieldly += picYoff;
                MoveArea(ref ShieldRectL);
            }
            if (ShieldRectRFlag)
            {
                ParasCam1.Shieldrx += picXoff;
                ParasCam1.Shieldry += picYoff;
                MoveArea(ref ShieldRectR);
            }
            MousePoint = movePoint;
        }
        public static void Init()
        {
            CrossFlag = false;
            RectNCBFlag = false;
            RectHFlag = false;
            RectMeltGapHFlag = false;
            BrightRect1Flag = false;
            BrightRect2Flag = false;
            ShieldRectLFlag = false;
            ShieldRectRFlag = false;
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
            if (RectH.Contains(MousePoint))
            {
                RectHFlag = true;
                return RectHFlag;
            }
            if (RectMeltGapH.Contains(MousePoint))
            {
                RectMeltGapHFlag = true;
                return RectMeltGapHFlag;
            }
            if (BrightRect1.Contains(MousePoint))
            {
                BrightRect1Flag = true;
                return BrightRect1Flag;
            }
            if (BrightRect2.Contains(MousePoint))
            {
                BrightRect2Flag = true;
                return BrightRect2Flag;
            }
            if (ShieldRectL.Contains(MousePoint))
            {
                ShieldRectLFlag = true;
                return ShieldRectLFlag;
            }
            if (ShieldRectR.Contains(MousePoint))
            {
                ShieldRectRFlag = true;
                return ShieldRectRFlag;
            }
            return false;
        }
        private static void CalcBrightR()
        {
            ParasCam1.BrightRightXOffset += picXoff;
            ParasCam1.BrightPointYOffset += picYoff;
            ParasCam1.BrightRightX = ParasCam1.SeedCenterX + ParasCam1.BrightRightXOffset;
            ParasCam1.BrightPointY = ParasCam1.SeedCenterY + ParasCam1.BrightPointYOffset;
        }
        private static void CalcBrightPreR()
        {
            ParasCam1.BrightPreRightXOffset += picXoff;
            ParasCam1.BrightPrePointYOffset += picYoff;
            ParasCam1.BrightPreRightX = ParasCam1.SeedCenterX + ParasCam1.BrightPreRightXOffset;
            ParasCam1.BrightPrePointY = ParasCam1.SeedCenterY + ParasCam1.BrightPrePointYOffset;
        }
        private static void CalcBrightL()
        {
            ParasCam1.BrightLeftXOffset += picXoff;
            ParasCam1.BrightPointYOffset += picYoff;
            ParasCam1.BrightLeftX = ParasCam1.SeedCenterX + ParasCam1.BrightLeftXOffset;
            ParasCam1.BrightPointY = ParasCam1.SeedCenterY + ParasCam1.BrightPointYOffset;
        }
        private static void CalcBrightPreL()
        {
            ParasCam1.BrightPreLeftXOffset += picXoff;
            ParasCam1.BrightPrePointYOffset += picYoff;
            ParasCam1.BrightPreLeftX = ParasCam1.SeedCenterX + ParasCam1.BrightPreLeftXOffset;
            ParasCam1.BrightPrePointY = ParasCam1.SeedCenterY + ParasCam1.BrightPrePointYOffset;
        }
        private static void CalcMeltGap()
        {
            ParasCam1.MeltGapLeftXOffset += picXoff;
            ParasCam1.MeltGapRightXOffset += picXoff;
            ParasCam1.MeltGapLineYOffset += picYoff;
            ParasCam1.MeltGapLeftX = ParasCam1.SeedCenterX + ParasCam1.MeltGapLeftXOffset;
            ParasCam1.MeltGapRightX = ParasCam1.SeedCenterX + ParasCam1.MeltGapRightXOffset;
            ParasCam1.MeltGapLineY = ParasCam1.SeedCenterY + ParasCam1.MeltGapLineYOffset;
        }
        private static void CalcMeltGapLong()
        {
            ParasCam1.MeltGapLongLeftXOffset += picXoff;
            ParasCam1.MeltGapLongRightXOffset += picXoff;
            //CameraParas.MeltGapLineYOffset += picYoff;
            ParasCam1.MeltGapLongLeftX = ParasCam1.SeedCenterX + ParasCam1.MeltGapLongLeftXOffset;
            ParasCam1.MeltGapLongRightX = ParasCam1.SeedCenterX + ParasCam1.MeltGapLongRightXOffset;
            //CameraParas.MeltGapLineY = CameraParas.ShieldCenterY + CameraParas.MeltGapLineYOffset;
        }
        private static void CalcHData()
        {
            ParasCam1.HAreaLeftXOffset += picXoff;
            ParasCam1.HAreaRightXOffset += picXoff;
            ParasCam1.HAreaLineYOffset += picYoff;
            ParasCam1.HAreaLeftX = ParasCam1.SeedCenterX + ParasCam1.HAreaLeftXOffset;
            ParasCam1.HAreaRightX = ParasCam1.SeedCenterX + ParasCam1.HAreaRightXOffset;
            ParasCam1.HAreaLineY = ParasCam1.SeedCenterY + ParasCam1.HAreaLineYOffset;
        }
        private static void CalcNeck(bool sign)
        {
            if (sign)
            {
                ParasCam1.NeckLeftXOffset += picXoff;
                ParasCam1.NeckRightXOffset += picXoff;
                ParasCam1.NeckTopYOffset += picYoff;
                ParasCam1.NeckBottomYOffset += picYoff;
            }
            ParasCam1.NeckLeftX = ParasCam1.SeedCenterX + ParasCam1.NeckLeftXOffset;
            ParasCam1.NeckRightX = ParasCam1.SeedCenterX + ParasCam1.NeckRightXOffset;
            ParasCam1.NeckTopY = ParasCam1.SeedCenterY + ParasCam1.NeckTopYOffset;
            ParasCam1.NeckBottomY = ParasCam1.SeedCenterY + ParasCam1.NeckBottomYOffset;
        }
        private static void CalcCrown(bool sign)
        {
            if (sign)
            {
                ParasCam1.CrownLeftXOffset += picXoff;
                ParasCam1.CrownRightXOffset += picXoff;
                ParasCam1.CrownTopYOffset += picYoff;
                ParasCam1.CrownBottomYOffset += picYoff;
            }
            ParasCam1.CrownLeftX = ParasCam1.SeedCenterX + ParasCam1.CrownLeftXOffset;
            ParasCam1.CrownRightX = ParasCam1.SeedCenterX + ParasCam1.CrownRightXOffset;
            ParasCam1.CrownTopY = ParasCam1.SeedCenterY + ParasCam1.CrownTopYOffset;
            ParasCam1.CrownBottomY = ParasCam1.SeedCenterY + ParasCam1.CrownBottomYOffset;
        }
        private static void CalcBody(bool sign)
        {
            if (sign)
            {
                ParasCam1.BodyLeftXOffset += picXoff;
                ParasCam1.BodyRightXOffset += picXoff;
                ParasCam1.BodyTopYOffset += picYoff;
                ParasCam1.BodyBottomYOffset += picYoff;
            }
            ParasCam1.BodyLeftX = ParasCam1.SeedCenterX + ParasCam1.BodyLeftXOffset;
            ParasCam1.BodyRightX = ParasCam1.SeedCenterX + ParasCam1.BodyRightXOffset;
            ParasCam1.BodyTopY = ParasCam1.SeedCenterY + ParasCam1.BodyTopYOffset;
            ParasCam1.BodyBottomY = ParasCam1.SeedCenterY + ParasCam1.BodyBottomYOffset;
        }
    }
}
