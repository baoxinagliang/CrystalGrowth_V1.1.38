﻿using System;
using System.IO;
using System.Text;

namespace CrystalGrowth.Unities
{
    internal static class ParasCam1
    {
        public const int VIRTUAL_IMG_WIDTH = 2448;
        public const int VIRTUAL_IMG_HEIGHT = 2048;

        private static string[] FileValue, FileStrName;
        public static float PixelSize = 0;
        public static int FocalLength = 0;
        public static int Width = 0;
        public static int Height = 0;
        public static int ExpoTime = 0;
        public static int SeedCenterX = 0;
        public static int SeedCenterY = 0;

        public static int NeckLeftX = 0;
        public static int NeckRightX = 0;
        public static int NeckTopY = 0;
        public static int NeckBottomY = 0;
        public static float NeckScale = 0;
        public static int NeckThreshold = 0;
        public static int NeckArrayNum = 0;
        public static float NeckFilterCoef = 0;

        public static int CrownLeftX = 0;
        public static int CrownRightX = 0;
        public static int CrownTopY = 0;
        public static int CrownBottomY = 0;
        public static int CrownThreshold = 0;
        public static int CrownArrayNum = 0;
        public static float CrownFilterCoef = 0;

        public static int BodyLeftX = 0;
        public static int BodyRightX = 0;
        public static int BodyTopY = 0;
        public static int BodyBottomY = 0;
        public static int BodyThreshold = 0;
        public static float CameraAngle = 0;
        public static int BodyArrayNum = 0;
        public static float BodyFilterCoef = 0;

        public static int MeltGapLeftX = 0;
        public static int MeltGapRightX = 0;
        public static int MeltGapLineY = 0;
        public static int MeltGapThreshold = 0;
        public static int MeltGapShortArrayNum = 0;
        public static float MeltGapShortFilterCoef = 0;

        public static int BrightLeftX = 0;
        public static int BrightRightX = 0;
        public static int BrightPointY = 0;
        public static int BrightWidth = 0;
        public static int BrightArrayNum = 0;
        public static int BrightRTimeArrayNum = 0;
        public static float BrightFilterCoef = 0;
        public static float CutLineDev = 0;
        public static int MeltGapScanMode = 0;
        public static int HAreaLeftX = 0;
        public static int HAreaRightX = 0;
        public static int HAreaLineY = 0;
        // 熔炉盖
        public static int MeltGapLongLeftX = 0;
        public static int MeltGapLongRightX = 0;
        //Public MeltGapLongLineY As Integer = 0
        public static int MeltGapLongThreshold = 0;
        public static int MeltGapLongArrayNum = 0;
        public static float MeltGapLongFilterCoef = 0;
        public static int MeltGapLongScanMode = 0;
        public static int MeltGapMiddleArrayNum = 0;
        public static float MeltGapMiddleFilterCoef = 0;
        public static int BrightPreLeftX = 0;
        public static int BrightPreRightX = 0;
        public static int BrightPrePointY = 0;
        public static float NeckOffsetRate = 0;
        public static float CrownOffsetRate = 0;
        public static float BodyOffsetRate = 0;
        //引晶区域偏移量
        public static int CrownThresholdTemp = 0;
        public static int NeckLeftXOffset = 0;
        public static int NeckRightXOffset = 0;
        public static int NeckTopYOffset = 0;
        public static int NeckBottomYOffset = 0;
        //放肩区域偏移量
        public static int CrownLeftXOffset = 0;
        public static int CrownRightXOffset = 0;
        public static int CrownTopYOffset = 0;
        public static int CrownBottomYOffset = 0;
        //等径区域偏移量
        public static int BodyLeftXOffset = 0;
        public static int BodyRightXOffset = 0;
        public static int BodyTopYOffset = 0;
        public static int BodyBottomYOffset = 0;
        //液口距偏移量
        public static int MeltGapLeftXOffset = 0;
        public static int MeltGapRightXOffset = 0;
        public static int MeltGapLongLeftXOffset = 0;
        public static int MeltGapLongRightXOffset = 0;
        public static int MeltGapLineYOffset = 0;
        //H区域偏移量
        public static int HAreaLeftXOffset = 0;
        public static int HAreaRightXOffset = 0;
        public static int HAreaLineYOffset = 0;
        //调温点
        public static int BrightLeftXOffset = 0;
        public static int BrightRightXOffset = 0;
        public static int BrightPointYOffset = 0;
        //预调温点
        public static int BrightPreLeftXOffset = 0;
        public static int BrightPreRightXOffset = 0;
        public static int BrightPrePointYOffset = 0;

        public static int Shieldlx = 0;
        public static int Shieldly = 0;
        public static int Shieldlw = 0;
        public static int Shieldlh = 0;
        public static int Shieldrx = 0;
        public static int Shieldry = 0;
        public static int Shieldrw = 0;
        public static int Shieldrh = 0;
        public static int ShieldThresholdLeft = 0;
        public static int ShieldThresholdRight = 0;
        public static int ShieldRealDia = 0;
        public static int ShieldCenterX = 0;
        public static int ShieldCenterY = 0;
        public static float ShieldDiafac = 0;
        public static float ShieldTargetDia = 0;
        public static float ShieldCorrectCoef = 0;
        public static float ShieldRealPixD = 0;
        public static float ShieldDownAlarm = 0;
        public static float ShieldUpAlarm = 0;

        public static float AbsoluteMeltGapRate = 0;
        public static float AbsoluteMeltGapOffset = 0;
        //断线检测参数
        public static float CutLineStartLine = 0;
        public static float CutLineCheckPeriod = 0;
        public static float CutLineThroshold = 0;
        public static int CutLineCountAlarmThroshold = 0;//断线检测周期计时器
        //晃动检测
        public static float ShakeNeckThreshold = 0;
        public static float ShakeCrownThreshold = 0;
        public static float ShakeBodyThreshold = 0;
        public static float FullMelt = 0;


        //绝对液口距信息  (Jason配置文件)
        public static float MeltGapAbsMeasure_T = 443;
        public static float MeltGapAbsMeasure_H = 1500;
        public static float MeltGapAbsMeasure_R = 153;
        public static float MeltGapAbsMeasure_OffSet = 12;
        public static int MeltGapAbsFilterNum = 15;

        /// <summary>
        /// 存图间隔（1-10000帧）
        /// </summary>
        public static int SaveInterval = 4;
        /// <summary>
        /// 存图文件夹路径
        /// </summary>
        public static string SavePicPath = @"D:\LICCS_PIC";
        /// <summary>
        /// 读取文件
        /// </summary>
        private static void ReadFile()
        {
            string[] Lines = File.ReadAllLines(FileHelper.Cam1Path, Encoding.UTF8);
            int Length = Lines.Length;
            FileStrName = new string[Length];
            FileValue = new string[Length];
            string[] TempVar;
            char[] SplitChar = new char[] { '=' };
            if (Length > 0)
            {
                for (int i = 0; i < Length; i++)
                {
                    TempVar = Lines[i].Split(SplitChar);
                    if (TempVar.Length == 2)
                    {
                        FileStrName[i] = TempVar[0];
                        FileValue[i] = TempVar[1];
                    }
                }
            }
        }
        /// <summary>
        /// 写入文件
        /// </summary>
        private static void WriteFile()
        {
            string[] Lines = new string[FileStrName.Length];
            int Length = Lines.Length;
            if (Length > 0)
            {
                for (int i = 0; i < Length; i++)
                {
                    if (FileStrName[i] != "")
                    {
                        Lines[i] = string.Concat(FileStrName[i], "=", FileValue[i]);
                    }
                }
            }
            File.WriteAllLines(FileHelper.Cam1Path, Lines);
        }
        /// <summary>
        /// 读取
        /// </summary>
        public static void ReadOut()
        {
            ReadFile();
            ReadValue();
            RecoveryValue();
        }
        /// <summary>
        /// 读取值
        /// </summary>
        private static void ReadValue()
        {
            switch (DualCam.SelectCam)
            {

                case "0":
                    Width = VIRTUAL_IMG_WIDTH;
                    Height = VIRTUAL_IMG_HEIGHT;
                	break;
                case "1":
                    PixelSize = Convert.ToSingle(FileValue[0]);
                    FocalLength = Convert.ToInt32(FileValue[1]);
                    Width = Convert.ToInt32(FileValue[2]);
                    Height = Convert.ToInt32(FileValue[3]);
                    ExpoTime = Convert.ToInt32(FileValue[4]);
                    break;
                case "2":
                    PixelSize = Convert.ToSingle(FileValue[5]);
                    FocalLength = Convert.ToInt32(FileValue[6]);
                    Width = Convert.ToInt32(FileValue[7]);
                    Height = (Convert.ToInt32(FileValue[8]));
                    ExpoTime = Convert.ToInt32(FileValue[9]);
                    break;
                case "3":
                    PixelSize = Convert.ToSingle(FileValue[10]);
                    FocalLength = Convert.ToInt32(FileValue[11]);
                    Width = Convert.ToInt32(FileValue[12]);
                    Height = (Convert.ToInt32(FileValue[13]));
                    ExpoTime = Convert.ToInt32(FileValue[14]);
                    break;
                case "4":
                    PixelSize = Convert.ToSingle(FileValue[5]);
                    FocalLength = Convert.ToInt32(FileValue[6]);
                    Width = Convert.ToInt32(FileValue[7]);
                    Height = (Convert.ToInt32(FileValue[8]));
                    ExpoTime = Convert.ToInt32(FileValue[9]);
                    break;
            }

            SeedCenterX = Convert.ToInt32(FileValue[15]);
            SeedCenterY = Convert.ToInt32(FileValue[16]);

            NeckLeftXOffset = Convert.ToInt32(FileValue[17]);
            NeckRightXOffset = Convert.ToInt32(FileValue[18]);
            NeckTopYOffset = Convert.ToInt32(FileValue[19]);
            NeckBottomYOffset = Convert.ToInt32(FileValue[20]);
            NeckScale = Convert.ToSingle(FileValue[21]);
            NeckThreshold = Convert.ToInt32(FileValue[22]);
            NeckArrayNum = Convert.ToInt32(FileValue[23]);
            NeckFilterCoef = Convert.ToSingle(FileValue[24]);

            CrownLeftXOffset = Convert.ToInt32(FileValue[25]);
            CrownRightXOffset = Convert.ToInt32(FileValue[26]);
            CrownTopYOffset = Convert.ToInt32(FileValue[27]);
            CrownBottomYOffset = Convert.ToInt32(FileValue[28]);
            CrownThreshold = Convert.ToInt32(FileValue[29]);
            CrownArrayNum = Convert.ToInt32(FileValue[30]);
            CrownFilterCoef = Convert.ToSingle(FileValue[31]);

            BodyLeftXOffset = Convert.ToInt32(FileValue[32]);
            BodyRightXOffset = Convert.ToInt32(FileValue[33]);
            BodyTopYOffset = Convert.ToInt32(FileValue[34]);
            BodyBottomYOffset = Convert.ToInt32(FileValue[35]);
            BodyThreshold = Convert.ToInt32(FileValue[36]);
            CameraAngle = Convert.ToSingle(FileValue[37]);
            BodyArrayNum = Convert.ToInt32(FileValue[38]);
            BodyFilterCoef = Convert.ToSingle(FileValue[39]);

            MeltGapLeftXOffset = Convert.ToInt32(FileValue[40]);
            MeltGapRightXOffset = Convert.ToInt32(FileValue[41]);
            MeltGapLineYOffset = Convert.ToInt32(FileValue[42]);
            MeltGapThreshold = Convert.ToInt32(FileValue[43]);
            MeltGapShortArrayNum = Convert.ToInt32(FileValue[44]);
            MeltGapShortFilterCoef = Convert.ToSingle(FileValue[45]);

            BrightLeftXOffset = Convert.ToInt32(FileValue[46]);
            BrightRightXOffset = Convert.ToInt32(FileValue[47]);
            BrightPointYOffset = Convert.ToInt32(FileValue[48]);
            BrightWidth = Convert.ToInt32(FileValue[49]);
            BrightArrayNum = Convert.ToInt32(FileValue[50]);
            BrightFilterCoef = Convert.ToSingle(FileValue[51]);
            CutLineDev = Convert.ToSingle(FileValue[52]);
            MeltGapScanMode = Convert.ToInt32(FileValue[53]);

            HAreaLeftXOffset = Convert.ToInt32(FileValue[54]);
            HAreaRightXOffset = Convert.ToInt32(FileValue[55]);
            HAreaLineYOffset = Convert.ToInt32(FileValue[56]);

            MeltGapLongLeftXOffset = Convert.ToInt32(FileValue[57]);
            MeltGapLongRightXOffset = Convert.ToInt32(FileValue[58]);
            //MeltGapLongLineY = CType(FileValue(55), Integer)
            MeltGapLongThreshold = Convert.ToInt32(FileValue[60]);
            MeltGapLongArrayNum = Convert.ToInt32(FileValue[61]);
            MeltGapLongFilterCoef = Convert.ToSingle(FileValue[62]);
            MeltGapLongScanMode = Convert.ToInt32(FileValue[63]);
            MeltGapMiddleArrayNum = Convert.ToInt32(FileValue[64]);
            MeltGapMiddleFilterCoef = Convert.ToSingle(FileValue[65]);

            BrightRTimeArrayNum = Convert.ToInt32(FileValue[66]);
            BrightPreLeftXOffset = Convert.ToInt32(FileValue[67]);
            BrightPreRightXOffset = Convert.ToInt32(FileValue[68]);
            BrightPrePointYOffset = Convert.ToInt32(FileValue[69]);

            NeckOffsetRate = Convert.ToSingle(FileValue[70]);
            CrownOffsetRate = Convert.ToSingle(FileValue[71]);
            BodyOffsetRate = Convert.ToSingle(FileValue[72]);

            Shieldlx = Convert.ToInt32(FileValue[73]);
            Shieldly = Convert.ToInt32(FileValue[74]);
            Shieldlw = Convert.ToInt32(FileValue[75]);
            Shieldlh = Convert.ToInt32(FileValue[76]);
            Shieldrx = Convert.ToInt32(FileValue[77]);
            Shieldry = Convert.ToInt32(FileValue[78]);
            Shieldrw = Convert.ToInt32(FileValue[79]);
            Shieldrh = Convert.ToInt32(FileValue[80]);
            ShieldThresholdLeft = Convert.ToInt32(FileValue[81]);
            ShieldThresholdRight = Convert.ToInt32(FileValue[82]);
            ShieldRealDia = Convert.ToInt32(FileValue[83]);
            ShieldCenterX = Convert.ToInt32(FileValue[84]);
            ShieldCenterY = Convert.ToInt32(FileValue[85]);
            ShieldDiafac = Convert.ToSingle(FileValue[86]);

            CutLineStartLine = Convert.ToInt32(FileValue[87]);
            CutLineCheckPeriod = Convert.ToSingle(FileValue[88]);
            CutLineThroshold = Convert.ToSingle(FileValue[89]);

            //晶晃检测
            ShakeNeckThreshold = Convert.ToInt32(FileValue[90]);
            ShakeCrownThreshold = Convert.ToInt32(FileValue[91]);
            ShakeBodyThreshold = Convert.ToInt32(FileValue[92]);
            CutLineCountAlarmThroshold = Convert.ToInt32(FileValue[93]);
            ShieldTargetDia = Convert.ToSingle(FileValue[94]);
            ShieldCorrectCoef = Convert.ToSingle(FileValue[95]);
            AbsoluteMeltGapRate = Convert.ToSingle(FileValue[96]);
            AbsoluteMeltGapOffset = Convert.ToSingle(FileValue[97]);
            FullMelt = Convert.ToSingle(FileValue[98]);
            ShieldRealPixD = Convert.ToSingle(FileValue[99]);
            ShieldDownAlarm = Convert.ToSingle(FileValue[100]);
            ShieldUpAlarm = Convert.ToSingle(FileValue[101]);
        }
        /// <summary>
        /// 恢复值
        /// </summary>
        private static void RecoveryValue()
        {
            MeltGapLeftX = ShieldCenterX + MeltGapLeftXOffset;
            MeltGapRightX = ShieldCenterX + MeltGapRightXOffset;
            MeltGapLongLeftX = ShieldCenterX + MeltGapLongLeftXOffset;
            MeltGapLongRightX = ShieldCenterX + MeltGapLongRightXOffset;
            MeltGapLineY = ShieldCenterY + MeltGapLineYOffset;

            HAreaLeftX = ShieldCenterX + HAreaLeftXOffset;
            HAreaRightX = ShieldCenterX + HAreaRightXOffset;
            HAreaLineY = ShieldCenterY + HAreaLineYOffset;

            NeckLeftX = SeedCenterX + NeckLeftXOffset;
            NeckRightX = SeedCenterX + NeckRightXOffset;
            NeckTopY = SeedCenterY + NeckTopYOffset;
            NeckBottomY = SeedCenterY + NeckBottomYOffset;

            CrownLeftX = SeedCenterX + CrownLeftXOffset;
            CrownRightX = SeedCenterX + CrownRightXOffset;
            CrownTopY = SeedCenterY + CrownTopYOffset;
            CrownBottomY = SeedCenterY + CrownBottomYOffset;

            BodyLeftX = SeedCenterX + BodyLeftXOffset;
            BodyRightX = SeedCenterX + BodyRightXOffset;
            BodyTopY = SeedCenterY + BodyTopYOffset;
            BodyBottomY = SeedCenterY + BodyBottomYOffset;

            BrightLeftX = SeedCenterX + BrightLeftXOffset;
            BrightRightX = SeedCenterX + BrightRightXOffset;
            BrightPointY = SeedCenterY + BrightPointYOffset;

            BrightPreLeftX = SeedCenterX + BrightPreLeftXOffset;
            BrightPreRightX = SeedCenterX + BrightPreRightXOffset;
            BrightPrePointY = SeedCenterY + BrightPrePointYOffset;
        }
        /// <summary>
        /// 写入
        /// </summary>
        public static void WriteIn()
        {
            WriteValue();
            WriteFile();
            RecoveryValue();
        }
        /// <summary>
        /// 写入值
        /// </summary>
        private static void WriteValue()
        {
            switch (DualCam.SelectCam)
            {
                case "1":
                    FileValue[4] = ExpoTime.ToString();
                    break;
                case "2":
                    FileValue[9] = ExpoTime.ToString();
                    break;
                case "3":
                    FileValue[14] = ExpoTime.ToString();
                    break;
                case "4":
                    FileValue[9] = ExpoTime.ToString();
                    break;
            }
            FileValue[15] = SeedCenterX.ToString();
            FileValue[16] = SeedCenterY.ToString();

            FileValue[17] = NeckLeftXOffset.ToString();
            FileValue[18] = NeckRightXOffset.ToString();
            FileValue[19] = NeckTopYOffset.ToString();
            FileValue[20] = NeckBottomYOffset.ToString();
            FileValue[22] = NeckThreshold.ToString();
            FileValue[23] = NeckArrayNum.ToString();

            FileValue[25] = CrownLeftXOffset.ToString();
            FileValue[26] = CrownRightXOffset.ToString();
            FileValue[27] = CrownTopYOffset.ToString();
            FileValue[28] = CrownBottomYOffset.ToString();
            FileValue[29] = CrownThreshold.ToString();
            FileValue[30] = CrownArrayNum.ToString();

            FileValue[32] = BodyLeftXOffset.ToString();
            FileValue[33] = BodyRightXOffset.ToString();
            FileValue[34] = BodyTopYOffset.ToString();
            FileValue[35] = BodyBottomYOffset.ToString();
            FileValue[36] = BodyThreshold.ToString();
            FileValue[37] = CameraAngle.ToString();
            FileValue[38] = BodyArrayNum.ToString();

            FileValue[40] = MeltGapLeftXOffset.ToString();
            FileValue[41] = MeltGapRightXOffset.ToString();
            FileValue[42] = MeltGapLineYOffset.ToString();
            FileValue[43] = MeltGapThreshold.ToString();

            FileValue[46] = BrightLeftXOffset.ToString();
            FileValue[47] = BrightRightXOffset.ToString();
            FileValue[48] = BrightPointYOffset.ToString();
            FileValue[53] = MeltGapScanMode.ToString();

            FileValue[54] = HAreaLeftXOffset.ToString();
            FileValue[55] = HAreaRightXOffset.ToString();
            FileValue[56] = HAreaLineYOffset.ToString();

            FileValue[57] = MeltGapLongLeftXOffset.ToString();
            FileValue[58] = MeltGapLongRightXOffset.ToString();
            FileValue[60] = MeltGapLongThreshold.ToString();
            FileValue[63] = MeltGapLongScanMode.ToString();

            FileValue[67] = BrightPreLeftXOffset.ToString();
            FileValue[68] = BrightPreRightXOffset.ToString();
            FileValue[69] = BrightPrePointYOffset.ToString();

            FileValue[73] = Shieldlx.ToString();
            FileValue[74] = Shieldly.ToString();
            FileValue[75] = Shieldlw.ToString();
            FileValue[76] = Shieldlh.ToString();
            FileValue[77] = Shieldrx.ToString();
            FileValue[78] = Shieldry.ToString();
            FileValue[79] = Shieldrw.ToString();
            FileValue[80] = Shieldrh.ToString();
            FileValue[81] = ShieldThresholdLeft.ToString();
            FileValue[82] = ShieldThresholdRight.ToString();
            FileValue[83] = ShieldRealDia.ToString();
            FileValue[84] = ShieldCenterX.ToString();
            FileValue[85] = ShieldCenterY.ToString();
            FileValue[86] = ShieldDiafac.ToString();
            //断线检测参数
            FileValue[87] = CutLineStartLine.ToString();
            FileValue[88] = CutLineCheckPeriod.ToString();
            FileValue[89] = CutLineThroshold.ToString();
            //晶晃检测
            FileValue[90] = ShakeNeckThreshold.ToString();
            FileValue[91] = ShakeCrownThreshold.ToString();
            FileValue[92] = ShakeBodyThreshold.ToString();
            FileValue[93] = CutLineCountAlarmThroshold.ToString();
            FileValue[94] = ShieldTargetDia.ToString();
            FileValue[95] = ShieldCorrectCoef.ToString();
            FileValue[98] = FullMelt.ToString();
            FileValue[99] = ShieldRealPixD.ToString();
            FileValue[100] = ShieldDownAlarm.ToString();
            FileValue[101] = ShieldUpAlarm.ToString();
        }
    }
}
