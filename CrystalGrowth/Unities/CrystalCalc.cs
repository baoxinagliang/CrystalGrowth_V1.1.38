using CrystalGrowth.CrystalCtl;
using System;

namespace CrystalGrowth.Unities
{
    internal static class CrystalCalc
    {
        static int Cnt = 1, Aver = 1;
        static readonly double[] RecordSL = new double[901];
        static double TotalSpeed = 0;
        static float GrowSpeed1 = 0;
        static bool SubFlag = false;
        public static void GrowSpeed()
        {
            if (FrmMain.LastValue != PLC.ReadValue[1])
            {
                Cnt = 1;
                Aver = 1;
                TotalSpeed = 0;
                GrowSpeed1 = 0;
                SubFlag = false;
            }
            if (PLC.ReadValue[3] >= 0)
            {
                if (Cnt > 900)
                {
                    Cnt = 1;
                    SubFlag = true;
                }
                TotalSpeed += PLC.ReadValue[3];
                if (SubFlag)
                {
                    TotalSpeed -= RecordSL[Cnt];
                }
                RecordSL[Cnt] = PLC.ReadValue[3];
                GrowSpeed1 = (float)(TotalSpeed / Aver);
                Cnt++;
                if (Aver < 900)
                {
                    Aver++;
                }
            }
            PLC.SendFloat(33, 60, GrowSpeed1);
        }
        static bool StartFlag = false, StartCalc = false, FilterFlag = false;
        static readonly double[] RecLen = new double[601];
        static readonly double[] RecRad = new double[601];
        static readonly double FilterCoef = 0.05;
        static double LastDegree = 0, CrownDegree1 = 0;
        static readonly int TimeCycle = 300;
        static int Cnt1 = 1;
        public static void CrownDegree()
        {
            double LenDev = 0;
            double RadDev = 0;
            if (PLC.ReadValue[1] == 11)
            {
                double Length = PLC.ReadCalcValue[14];
                double Radius = PLC.ReadValue[7] / 2;
                if (StartFlag == false)
                {
                    StartFlag = true;
                    Cnt1 = 1;
                    CrownDegree1 = 0;
                    RecLen[1] = Length;
                    RecRad[1] = Radius;
                    StartCalc = false;
                    FilterFlag = false;
                }
                if (StartCalc)
                {
                    LenDev = Length - RecLen[Cnt1];
                    RadDev = Radius - RecRad[Cnt1];
                }
                else
                {
                    if (Cnt1 > 60)
                    {
                        LenDev = Length - RecLen[1];
                        RadDev = Radius - RecRad[1];
                    }
                }
                if (RadDev > 0)
                {
                    double TempDegree = Math.Atan(LenDev / RadDev) * 180 / Math.PI;
                    //一阶微分滤波Y(n)=aX(n) + (1-a)Y(n-1)
                    if (FilterFlag == false)
                    {
                        FilterFlag = true;
                        LastDegree = TempDegree;
                    }
                    CrownDegree1 = FilterCoef * TempDegree + (1 - FilterCoef) * LastDegree;
                    LastDegree = CrownDegree1;
                }
                RecLen[Cnt1] = Length; //实时存储晶体长度
                RecRad[Cnt1] = Radius;//实时存储晶体半径
                Cnt1++;
                if (Cnt1 > TimeCycle)
                {
                    Cnt1 = 1;
                    StartCalc = true;
                }
                PLC.SendFloat(35, 80, (float)CrownDegree1);
            }
            else
            {
                StartFlag = false;
            }
        }
        public static void WeightSafe()
        {
            //硅固体密度为2.33g/cm3, 硅液体密度为2.56g/cm3
            //圆柱体积V=πr²h
            double MeltDepth = 0;
            double RemainWeig = PLC.ReadCalcValue[10];//784.26
            double CrucPos = PLC.ReadValue[59];//-29.7
            double HrtToShield = PLC.ReadCalibValue[37];//98.1//热屏插入加热器深度
            double InterRadius = (CrucPara.ExtDia - CrucPara.WallThick * 2) / 2;//坩埚内半径
            double ColumnWeig = RemainWeig - (AngleWeig + ArcWeig);
            if (ColumnWeig >= 0)
            {
                double MeltColumnHeight = (ColumnWeig * Math.Pow(10, 6) / 2.56) / (Math.PI * Math.Pow(InterRadius, 2));
                MeltDepth = MeltColumnHeight + AngleHeight + ArcHeight;
            }
            else
            {
                if (RemainWeig >= ArcWeig)
                {
                    double AngleWeig = RemainWeig - ArcWeig;
                    int Head = 0;
                    int Tail = Wa.Length - 1;
                    int Mid;
                    while (Tail - Head > 256)
                    {
                        Mid = (Tail - Head) / 2 + Head;
                        if (AngleWeig == Wa[Mid])
                        {
                            Head = Mid;
                            Tail = Mid;
                            break;
                        }
                        else if (AngleWeig < Wa[Mid])
                        {
                            Tail = Mid;
                        }
                        else
                        {
                            Head = Mid;
                        }
                    }
                    for (int i = Head; i <= Tail; i++)
                    {
                        if (AngleWeig < Wa[i])
                        {
                            MeltDepth = Ha[i] + ArcHeight;
                            break;
                        }
                    }
                }
                else if (RemainWeig > 0)
                {
                    int Head = 0;
                    int Tail = Wc.Length - 1;
                    int Mid;
                    while (Tail - Head > 256)
                    {
                        Mid = (Tail - Head) / 2 + Head;
                        if (RemainWeig == Wc[Mid])
                        {
                            Head = Mid;
                            Tail = Mid;
                            break;
                        }
                        else if (RemainWeig < Wc[Mid])
                        {
                            Tail = Mid;
                        }
                        else
                        {
                            Head = Mid;
                        }
                    }
                    for (int i = Head; i <= Tail; i++)
                    {
                        if (RemainWeig < Wc[i])
                        {
                            MeltDepth = Hc[i];
                            break;
                        }
                    }
                }
                else
                {
                    MeltDepth = 0;
                }
            }
            double MeltToShield = CrucPara.TotalHeight - CrucPara.WallThick - MeltDepth - HrtToShield - CrucPos;
            PLC.SendFloat(35, 12, (float)MeltDepth);//溶液深度
            PLC.SendFloat(35, 0, (float)MeltToShield);//重量液口距
        }
        static bool StartFlag1 = false, StartCalc1 = false, FilterFlag1 = false;
        static readonly int TimeCycle1 = 1200;
        static int Cnt2 = 1;
        static readonly double[] RecLength = new double[2401];
        static readonly double[] RecWeight = new double[2401];
        static double LastDiameter = 0, WeightDiameter1 = 0, LastLength = 0, AccumLength = 0;
        static readonly double FilterCoef1 = 0.05;

        public static void WeightDiameter()
        {
            double TempDiameter, Length, TotalLength, Weight, LenDev = 0, WeigDev = 0;
            //放肩、转肩、等径、收尾、快速收尾都计算
            if (PLC.ReadValue[1] == 11 || PLC.ReadValue[1] == 12 || PLC.ReadValue[1] == 13 || PLC.ReadValue[1] == 14 || PLC.ReadValue[1] == 15)
            {
                Length = PLC.ReadCalcValue[14];
                Weight = PLC.ReadCalcValue[8];
                if (StartFlag1 == false)
                {
                    StartFlag1 = true;
                    Cnt2 = 1;
                    LastLength = 0;
                    AccumLength = 0;
                    WeightDiameter1 = 0;
                    RecLength[1] = Length;
                    RecWeight[1] = Weight;
                    StartCalc1 = false;
                    FilterFlag1 = false;
                }
                if (Length <= LastLength - 1)
                {
                    AccumLength += LastLength;
                }
                TotalLength = AccumLength + Length;
                LastLength = Length;
                if (StartCalc1)
                {
                    LenDev = TotalLength - RecLength[Cnt2];
                    WeigDev = Weight - RecWeight[Cnt2];
                }
                else
                {
                    if (Cnt2 > 300)
                    {
                        LenDev = TotalLength - RecLength[1];
                        WeigDev = Weight - RecWeight[1];
                    }
                }
                if (WeigDev > 0 && LenDev > 0)
                {
                    TempDiameter = Math.Sqrt((WeigDev * 1000000) / (LenDev * 2.33 * Math.PI)) * 2;
                    //一阶微分滤波Y(n)=aX(n) + (1-a)Y(n-1)
                    if (FilterFlag1 == false)
                    {
                        FilterFlag1 = true;
                        LastDiameter = TempDiameter;
                    }
                    WeightDiameter1 = FilterCoef1 * TempDiameter + (1 - FilterCoef1) * LastDiameter;
                    LastDiameter = WeightDiameter1;
                }
                RecLength[Cnt2] = TotalLength;//实时存储晶体总长度
                RecWeight[Cnt2] = Weight;//实时存储晶体重量
                Cnt2++;
                if (Cnt2 > TimeCycle1)
                {
                    Cnt2 = 1;
                    StartCalc1 = true;
                }
                //PLCConn.SendAutoFloat(35, 80, WeightDiameter)
            }
            else
            {
                StartFlag1 = false;
            }
        }
        //Weight Safe
        public static double AngleHeight, ArcHeight, MaxLoad, AngleWeig, ArcWeig;//AngleWeig倒角部分重量,ArcWeig圆弧部分重量
        public static double[] Wa, Ha, Wc, Hc; //Wa倒角部分从上往下累计体积, Ha倒角部分从上往下累计高度 ,Wc内圆弧部分从上往下累计体积,Hc内圆弧部分从上往下累计高度
        public static void Weight()
        {
            //硅固体密度为2.33g/cm3, 硅液体密度为2.56g/cm3
            //圆柱体积V=πr²h
            //圆台体积V=1/3πh(r²+R²+rR)
            //球冠体积V=1/6πh(3r²+h²)
            const double Density = 2.56;
            double[] Ra;//倒角部分半径        
            int AngleNum;//倒角部分体积分割数量
            double Vb;//内圆弧部分体积
            double Rb;//内圆弧部分半径
            int ArcNum;//圆弧部分体积分割数量        
            double[] Rc;//内圆弧部分半径
            double InterRadius = (CrucPara.ExtDia - CrucPara.WallThick * 2) / 2;//坩埚内半径
            AngleHeight = (CrucPara.AngleRadius / (CrucPara.ArcRadius - CrucPara.AngleRadius)) * Math.Sqrt(Math.Pow(CrucPara.ArcRadius - CrucPara.AngleRadius, 2) - Math.Pow(InterRadius - CrucPara.AngleRadius, 2));//圆弧高度计算
            ArcHeight = CrucPara.ArcRadius - ((CrucPara.ArcRadius / (CrucPara.ArcRadius - CrucPara.AngleRadius)) * Math.Sqrt(Math.Pow(CrucPara.ArcRadius - CrucPara.AngleRadius, 2) - Math.Pow(InterRadius - CrucPara.AngleRadius, 2)));//圆柱高度计算
            CrucPara.ColumnHeight = CrucPara.TotalHeight - CrucPara.WallThick - AngleHeight - ArcHeight;//倒角部分重量计算
            AngleNum = (int)(AngleHeight * 100);
            Ra = new double[AngleNum + 1];
            Ha = new double[AngleNum];
            Wa = new double[AngleNum];
            Ra[0] = InterRadius;
            for (int i = 1; i <= AngleNum; i++)
            {
                Ra[i] = InterRadius - CrucPara.AngleRadius + Math.Sqrt(Math.Pow(CrucPara.AngleRadius, 2) - Math.Pow(0.01 * i, 2));
            }
            Ha[0] = 0.01;
            Wa[0] = ((1f / 3) * Math.PI * 0.01 * (Math.Pow(Ra[AngleNum], 2) + Math.Pow(Ra[AngleNum - 1], 2) + Ra[AngleNum] * Ra[AngleNum - 1])) * Density / Math.Pow(10, 6);
            for (int i = 1; i <= AngleNum - 1; i++)
            {
                Ha[i] = Ha[i - 1] + 0.01;
                Wa[i] = Wa[i - 1] + ((1f / 3) * Math.PI * 0.01 * (Math.Pow(Ra[AngleNum - i], 2) + Math.Pow(Ra[AngleNum - 1 - i], 2) + Ra[AngleNum - i] * Ra[AngleNum - 1 - i])) * Density / Math.Pow(10, 6);
            }
            AngleWeig = Wa[AngleNum - 1];
            Rb = Math.Sqrt(Math.Pow(CrucPara.ArcRadius, 2) - Math.Pow(CrucPara.ArcRadius - ArcHeight, 2)); //圆弧部分重量计算
            Vb = (1f / 6) * Math.PI * ArcHeight * (3 * Math.Pow(Rb, 2) + Math.Pow(ArcHeight, 2));
            ArcWeig = Vb * Density / Math.Pow(10, 6);
            ArcNum = (int)(ArcHeight / 0.01);
            Rc = new double[ArcNum + 1];
            Hc = new double[ArcNum];
            Wc = new double[ArcNum];
            Rc[0] = Rb;//圆弧内半径
            for (int i = 1; i <= ArcNum; i++)
            {
                Rc[i] = Math.Sqrt(Math.Pow(CrucPara.ArcRadius, 2) - Math.Pow(CrucPara.ArcRadius - ArcHeight + 0.01 * i, 2));
            }
            for (int i = 1; i < ArcNum; i++)
            {
                Hc[i - 1] = 0.01 * i;
                Wc[i - 1] = ((1f / 6) * Math.PI * (ArcHeight - 0.01 * (ArcNum - i)) * (3f * Math.Pow(Rc[ArcNum - i], 2) + Math.Pow(ArcHeight - 0.01 * (ArcNum - i), 2))) * Density / Math.Pow(10, 6);
            }
            //圆柱部分及总重量计算
            double ColumnWeig = Math.PI * Math.Pow(Ra[0], 2) * (CrucPara.ColumnHeight) * Density / Math.Pow(10, 6);
            MaxLoad = ColumnWeig + AngleWeig + ArcWeig;
        }
    }
}
