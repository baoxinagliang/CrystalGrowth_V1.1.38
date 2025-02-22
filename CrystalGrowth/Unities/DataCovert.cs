﻿using System;

namespace CrystalGrowth.Unities
{
    internal static class DataCovert
    {
        public static string TimeToStr(this float rawTime)
        {
            int Hour = (int)rawTime / 3600;
            int Minute = (int)((rawTime - Hour * 3600) / 60);
            int Second = (int)(rawTime - Hour * 3600 - Minute * 60);
            string HourStr = Hour < 10 ? string.Concat("0", Hour.ToString()) : Hour.ToString();
            string MinuteStr = Minute < 10 ? string.Concat("0", Minute.ToString()) : Minute.ToString();
            string SecondStr = Second < 10 ? string.Concat("0", Second.ToString()) : Second.ToString();
            return string.Format("{0}:{1}:{2}", HourStr, MinuteStr, SecondStr);
        }
        public static double NumVar(object Var, object LimValMin, object LimValMax)
        {
            double RealValue = Convert.ToDouble(Var);
            double MinValue = Convert.ToDouble(LimValMin);
            double MaxValue = Convert.ToDouble(LimValMax);
            if (MaxValue > MinValue)
            {
                double CurveData = (RealValue - MinValue) * 100 / (MaxValue - MinValue);
                if (CurveData < 0)
                {
                    return 0;
                }
                else if (CurveData > 100)
                {
                    return 100;
                }
                else
                {
                    return CurveData;
                }
            }
            else
            {
                return 0;
            }
        }
        public static string Analog(short AnalogValue, int Type)
        {
            double CalcValue, Min = 0, Max = 10;
            switch (Type)
            {
                case 1:     // 0-10v
                    Min = 0;
                    Max = 10;
                    break;
                case 2:     // 0-5v
                    Min = 0;
                    Max = 5;
                    break;
                case 3:     // 4-20 mA
                    Min = 4;
                    Max = 20;
                    break;
            }
            if (Type == 4)
            {
                CalcValue = Math.Round((double)AnalogValue / 10, 1);
            }
            else
            {
                CalcValue = AnalogValue >= 0 ? Math.Round(((Max - Min) / 32767) * AnalogValue + Min, 1) : Math.Round(((Max - Min) / 32767) * AnalogValue - Min, 1);
            }
            return CalcValue.ToString("f1");
        }
        public static string RealToStr(int lenght, string strText)
        {
            int index = strText.IndexOf(".");
            if (index == -1)
            {
                return Convert.ToDouble(strText).ToString(string.Concat("f", lenght.ToString()));
            }
            else
            {
                char[] SplitChar = new char[] { '.' };
                string[] Str = strText.Split(SplitChar);
                if (Str[1].Length == 0 || Str[1].Length < lenght)
                {
                    int dis = lenght - Str[1].Length;
                    if (dis == 0)
                    {
                        return Str[0];
                    }
                    for (int i = 0; i < dis; i++)
                    {
                        strText = string.Concat(strText, "0");
                    }
                    return strText;
                }
                else
                {
                    if (lenght == 0)
                    {
                        return Str[0];
                    }
                    else
                    {
                        return string.Concat(Str[0], ".", Str[1].Substring(0, lenght));
                    }
                }
            }
        }
        public static bool Juage(object obj)
        {
            try
            {
                double value = Convert.ToDouble(obj);
                if (double.IsNaN(value) || double.IsInfinity(value) || double.IsNegativeInfinity(value) || double.IsPositiveInfinity(value))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static string[] FloatToStr(this float[] FloatArr)
        {
            string[] strArr = new string[FloatArr.Length];
            for (int i = 0; i < FloatArr.Length; i++)
            {
                strArr[i] = FloatArr[i].ToString();
            }
            return strArr;
        }
        public static float[] StrToFloat(this string[] strArr)
        {
            float[] floatArr = new float[strArr.Length];
            for (int i = 0; i < strArr.Length; i++)
            {
                floatArr[i] = strArr[i].Length == 0 ? 0 : (float)Convert.ToDouble(strArr[i]);
            }
            return floatArr;
        }
        public static bool IsDate(this string strDate)
        {
            try
            {
                DateTime.Parse(strDate);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
