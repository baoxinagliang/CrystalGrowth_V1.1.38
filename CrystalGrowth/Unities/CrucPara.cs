using System;
using System.IO;
using System.Text;

namespace CrystalGrowth.Unities
{
    internal static class CrucPara
    {
        public static double ExtDia, WallThick, TotalHeight, ColumnHeight, AngleRadius, ArcRadius;
        public static void WriteIn(string Para, int Line)
        {
            string[] Lines = File.ReadAllLines(FileHelper.CrucParaPath, Encoding.UTF8);
            int Length = Lines.Length;
            string[] TempVar;
            char[] SplitChar = new char[] { '=' };
            for (int i = 0; i < Length; i++)
            {
                if (i + 1 == Line)
                {
                    TempVar = Lines[i].Split(SplitChar);
                    Lines[i] = string.Concat(TempVar[0], "=", Para);
                }
            }
            File.WriteAllLines(FileHelper.CrucParaPath, Lines, Encoding.UTF8);
        }
        public static void ReadOut()
        {
            string[] Lines = File.ReadAllLines(FileHelper.CrucParaPath, Encoding.UTF8);
            int Length = Lines.Length;
            string[] TempVar;
            char[] SplitChar = new char[] { '=' };
            for (int i = 1; i <= Length; i++)
            {
                TempVar = Lines[i - 1].Split(SplitChar);
                switch (i)
                {
                    case 1:
                        ExtDia = Convert.ToDouble(TempVar[1]);
                        break;
                    case 2:
                        WallThick = Convert.ToDouble(TempVar[1]);
                        break;
                    case 3:
                        TotalHeight = Convert.ToDouble(TempVar[1]);
                        break;
                    case 4:
                        AngleRadius = Convert.ToDouble(TempVar[1]);
                        break;
                    case 5:
                        ArcRadius = Convert.ToDouble(TempVar[1]);
                        break;
                }
            }
        }
    }
}
