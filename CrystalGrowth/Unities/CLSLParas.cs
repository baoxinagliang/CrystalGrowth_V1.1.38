using System;
using System.IO;
using System.Text;

namespace CrystalGrowth.Unities
{
    internal static class CLSLParas
    {
        public static double ExtDia, WallThick, TotalHeight, DegreeRadius, ArcHeight, LoadWeight, Diameter, ArcRadius, TailDiameter;//收尾直径计算
        static double LenghtDifference, QualityDifference;
        static float crystalQuality = 0;
        static int count = 0;
        static bool once1 = false, once = false;
        public static float CrystalQuality
        {
            get { return crystalQuality; }
            set
            {
                if (PLC.ReadValue[1] == 14.0 || PLC.ReadValue[1] == 14.1 || PLC.ReadValue[1] == 15.0)
                {
                    //收尾计算  7s计算一次（大致晶棒转一圈），如果转速太快，计算不准
                    if (count >= 7 && crystalQuality != value)
                    {
                        count = 0;
                        //第一次值为0计算不准舍弃
                        if (once1 && LenghtDifference != 0)
                        {
                            QualityDifference = Math.Abs(value - crystalQuality);
                            TailDiameter = Math.Round(Math.Sqrt(QualityDifference * 1000 * 10 / 2.33 / 3.1415926 / LenghtDifference) * 20, 2);
                        }
                        crystalQuality = value;
                    }
                    once1 = true;
                    count++;
                }
            }
        }
        private static float crystalLength = 0.0f;
        public static float CrystalLength
        {
            get { return crystalLength; }
            set
            {
                if (PLC.ReadValue[1] == 14.0 || PLC.ReadValue[1] == 14.1 || PLC.ReadValue[1] == 15.0)
                {
                    //收尾计算  7s计算一次（大致晶棒转一圈），如果转速太快，计算不准
                    if (count >= 7 && crystalLength != value)
                    {
                        if (once)
                        {
                            LenghtDifference = Math.Abs(value - crystalLength);
                        }
                        once = true;
                        crystalLength = value;
                    }
                }
            }
        }
        public static void WriteIn(string Para, int Line)
        {
            string[] Lines = File.ReadAllLines(FileHelper.CLSLCalcPath, Encoding.UTF8);
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
            File.WriteAllLines(FileHelper.CLSLCalcPath, Lines, Encoding.UTF8);
        }
        public static void ReadOut()
        {
            string[] Lines = File.ReadAllLines(FileHelper.CLSLCalcPath, Encoding.UTF8);
            int Length = Lines.Length;
            string[] TempVar;
            double tempVaule;
            char[] SplitChar = new char[] { '=' };
            for (int i = 1; i <= Length; i++)
            {
                TempVar = Lines[i - 1].Split(SplitChar);
                tempVaule = double.Parse(TempVar[1]);
                switch (i)
                {
                    case 1:
                        ExtDia = tempVaule;
                        break;
                    case 2:
                        WallThick = tempVaule;
                        break;
                    case 3:
                        TotalHeight = tempVaule;
                        break;
                    case 4:
                        DegreeRadius = tempVaule;
                        break;
                    case 5:
                        ArcRadius = tempVaule;
                        break;
                    case 6:
                        LoadWeight = tempVaule;
                        break;
                    case 7:
                        Diameter = tempVaule;
                        break;
                }
            }
        }
    }
}
