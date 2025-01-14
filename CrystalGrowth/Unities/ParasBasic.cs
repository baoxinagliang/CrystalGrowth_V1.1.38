using CrystalGrowth.CrystalCtl;
using System.Drawing;

namespace CrystalGrowth.Unities
{
    internal class ParasBasic
    {
        public static Pen PenGreen = new Pen(Color.FromArgb(0, 255, 0), 1);//绿色
        public static Pen PenRed = new Pen(Color.Red, 1);//红色
        public static Pen PenPurple = new Pen(Color.Purple, 1);
        public static Pen PenYellow = new Pen(Color.Yellow, 1);
        public static Pen PenTomato = new Pen(Color.Tomato);
        public static SolidBrush BrushBlue = new SolidBrush(Color.Blue);
        public static SolidBrush BrushGreen = new SolidBrush(Color.FromArgb(0, 255, 0));
        /// <summary>
        /// 画对角线
        /// </summary>
        public static void DrawXLine(ref Graphics g, ref Size size, ref bool DrawX)
        {
           if (DrawX)
            {

                int HalfWidth = size.Width / 2, HalfWSubOne = HalfWidth - 1, HalfWAddOne = HalfWidth + 1;
                int HalfHeight = size.Height / 2, HalfHSubOne = HalfHeight - 1, HalfHAddOne = HalfHeight + 1;
                int TempY, TempYSubOne, TempYAddOne;
                int TempY1, TempY1SubOne, TempY1AddOne;
                int TempX, TempXSubOne;
                int i = 2, j;
                g.DrawLine(PenPurple, HalfWidth, 0, HalfWidth, size.Height);
                g.DrawLine(PenPurple, 0, HalfHeight, size.Width, HalfHeight);
                Font font = new Font("宋体", 10);
                Brush brush = Brushes.Red;
                int thickcount = 0;
                int count = 0;
                while (i <= HalfWidth)
                {

                    j = i - 1;
                    // TempY 
                    TempY = (size.Height * i) / size.Width;
                    TempYSubOne = TempY - 1;
                    TempYAddOne = TempY + 1;

                    TempY1 = size.Height - TempY;
                    TempY1SubOne = TempY1 - 1;
                    TempY1AddOne = TempY1 + 1;

                    TempX = size.Width - i;
                    TempXSubOne = TempX - 1;

                    if (thickcount >= FrmMain.GlobalParameter.XLineLongGap)
                    {
                        g.DrawRectangle(PenYellow, j, TempYSubOne, 2, 2);
                        g.DrawRectangle(PenYellow, j, TempY1SubOne, 2, 2);
                        g.DrawRectangle(PenYellow, TempXSubOne, TempYSubOne, 2, 2);
                        g.DrawRectangle(PenYellow, TempXSubOne, TempY1SubOne, 2, 2);
                        g.DrawRectangle(PenYellow, j, HalfHSubOne, 2, 2);
                        g.DrawRectangle(PenYellow, TempXSubOne, HalfHSubOne, 2, 2);
                        g.DrawRectangle(PenYellow, HalfWSubOne, TempYSubOne, 2, 2);
                        g.DrawRectangle(PenYellow, HalfWSubOne, TempY1SubOne, 2, 2);
                        if (i + FrmMain.GlobalParameter.XLineLongGap * FrmMain.GlobalParameter.XLineShortGap < HalfWidth)
                        {
                            g.DrawString(count.ToString(), font, brush, new PointF(j + 10, TempYSubOne - 15));
                            g.DrawString(count.ToString(), font, brush, new PointF(j + 10, TempY1SubOne + 15));
                            g.DrawString(count.ToString(), font, brush, new PointF(TempXSubOne - 10, TempYSubOne - 15));
                            g.DrawString(count.ToString(), font, brush, new PointF(TempXSubOne - 10, TempY1SubOne + 15));

                            g.DrawString(count.ToString(), font, brush, new PointF(j - 5, HalfHSubOne + 10));
                            g.DrawString(count.ToString(), font, brush, new PointF(TempXSubOne - 5, HalfHSubOne + 10));
                            g.DrawString(count.ToString(), font, brush, new PointF(HalfWSubOne + 10, TempYSubOne - 5));
                            g.DrawString(count.ToString(), font, brush, new PointF(HalfWSubOne + 10, TempY1SubOne - 5));
                        }
                        count++;
                        thickcount = 1;
                    }
                    else
                    {
                        
                        g.DrawLine(PenTomato, i, TempYAddOne, i, TempYSubOne);
                        g.DrawLine(PenTomato, i, TempY1AddOne, i, TempY1SubOne);
                        g.DrawLine(PenTomato, TempX, TempYAddOne, TempX, TempYSubOne);
                        g.DrawLine(PenTomato, TempX, TempY1AddOne, TempX, TempY1SubOne);
                        g.DrawLine(PenTomato, i, HalfHAddOne, i, HalfHSubOne);
                        g.DrawLine(PenTomato, TempX, HalfHAddOne, TempX, HalfHSubOne);
                        g.DrawLine(PenTomato, i, HalfHAddOne, i, HalfHSubOne);
                        g.DrawLine(PenTomato, TempX, HalfHAddOne, TempX, HalfHSubOne);
                        g.DrawLine(PenTomato, HalfWAddOne, TempY, HalfWSubOne, TempY);
                        g.DrawLine(PenTomato, HalfWAddOne, TempY1, HalfWSubOne, TempY1);
                        thickcount++;
                    }
                    i += FrmMain.GlobalParameter.XLineShortGap;
                }
            }
        }

        public static void DrawCrossLine(ref Graphics g1, ref Size size, ref bool DrawX)
        {

            if (DrawX)
            {

                int HalfWidth = size.Width / 2, HalfWSubOne = HalfWidth - 1, HalfWAddOne = HalfWidth + 1;
                int HalfHeight = size.Height / 2, HalfHSubOne = HalfHeight - 1, HalfHAddOne = HalfHeight + 1;

                int TempY, TempYSubOne;
                int TempY1, TempY1SubOne;
                int TempX, TempXSubOne;
                int i = 2, j;
                g1.DrawLine(PenPurple, HalfWidth, 0, HalfWidth, size.Height);
                g1.DrawLine(PenPurple, 0, HalfHeight, size.Width, HalfHeight);
                Font font = new Font("宋体", 10);
                Brush brush = Brushes.Red;
                int thickcount = 0;
                int count = 0;
                while (i <= HalfWidth)
                {
                    j = i - 1;
                    TempY = (size.Height * i) / size.Width;
                    TempYSubOne = TempY - 1;

                    TempY1 = size.Height - TempY;
                    TempY1SubOne = TempY1 - 1;

                    TempX = size.Width - i;
                    TempXSubOne = TempX - 1;

                    
                    if (thickcount >= FrmMain.GlobalParameter.CrossLineLongGap)
                    {
                        g1.DrawRectangle(PenYellow, j, HalfHSubOne, 2, 2);
                        //g1.DrawString(count.ToString(),font,brush,new PointF(j-3, HalfHSubOne+10));
                        g1.DrawRectangle(PenYellow, TempXSubOne, HalfHSubOne, 2, 2);
                        //g1.DrawString(count.ToString(),font,brush,new PointF(TempXSubOne-3, HalfHSubOne+10));
                        g1.DrawRectangle(PenYellow, HalfWSubOne, TempYSubOne, 2, 2);
                        //g1.DrawString(count.ToString(),font,brush,new PointF(HalfWSubOne-15, TempYSubOne-3));
                        g1.DrawRectangle(PenYellow, HalfWSubOne, TempY1SubOne, 2, 2);
                        //g1.DrawString(count.ToString(),font,brush,new PointF(HalfWSubOne-15, TempY1SubOne-3));
                        if (i + FrmMain.GlobalParameter.XLineLongGap * FrmMain.GlobalParameter.XLineShortGap < HalfWidth)
                        {
                            g1.DrawString(count.ToString(), font, brush, new PointF(j - 5, HalfHSubOne + 10));
                            g1.DrawString(count.ToString(), font, brush, new PointF(TempXSubOne - 5, HalfHSubOne + 10));
                            g1.DrawString(count.ToString(), font, brush, new PointF(HalfWSubOne + 10, TempYSubOne - 5));
                            g1.DrawString(count.ToString(), font, brush, new PointF(HalfWSubOne + 10, TempY1SubOne - 5));
                        }
                        
                        
                        
                        count++;
                        thickcount = 1;
                        
                    }
                    else
                    {
                        // 从左往右画细格
                        g1.DrawLine(PenTomato, i, HalfHAddOne, i, HalfHSubOne);
                        // 从右往左画细格
                        g1.DrawLine(PenTomato, TempX, HalfHAddOne, TempX, HalfHSubOne);
                        // 从上往下画细格
                        g1.DrawLine(PenTomato, HalfWAddOne, TempY, HalfWSubOne, TempY);
                        // 从下往上画细格
                        g1.DrawLine(PenTomato, HalfWAddOne, TempY1, HalfWSubOne, TempY1);
                        thickcount++;
                    }
                    i += FrmMain.GlobalParameter.CrossLineShortGap;
                    
                    
                }
            }
        }
    }
}
