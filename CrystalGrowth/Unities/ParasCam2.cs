using System;
using System.IO;
using System.Text;

namespace CrystalGrowth.Unities
{
    internal static class ParasCam2
    {
        private static string[] FileValue;
        private static string[] FileStrName;
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
        public static int NeckThreshold = 0;
        public static float CameraAngle = 0;
        public static int NeckArrayNum = 0;
        public static float NeckFilterCoef = 0;

        //等径区域偏移量
        public static int NeckLeftXOffset = 0;
        public static int NeckRightXOffset = 0;
        public static int NeckTopYOffset = 0;
        public static int NeckBottomYOffset = 0;

        /// <summary>
        /// 读取文件
        /// </summary>
        private static void ReadFile()
        {
            string[] Lines = File.ReadAllLines(FileHelper.Cam2Path, Encoding.UTF8);
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
            File.WriteAllLines(FileHelper.Cam2Path, Lines);
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
            }

            SeedCenterX = Convert.ToInt32(FileValue[15]);
            SeedCenterY = Convert.ToInt32(FileValue[16]);

            NeckLeftXOffset = Convert.ToInt32(FileValue[17]);
            NeckRightXOffset = Convert.ToInt32(FileValue[18]);
            NeckTopYOffset = Convert.ToInt32(FileValue[19]);
            NeckBottomYOffset = Convert.ToInt32(FileValue[20]);
            NeckThreshold = Convert.ToInt32(FileValue[21]);
            CameraAngle = Convert.ToSingle(FileValue[22]);
            NeckArrayNum = Convert.ToInt32(FileValue[23]);
            NeckFilterCoef = Convert.ToSingle(FileValue[24]);
        }
        /// <summary>
        /// 恢复值
        /// </summary>
        private static void RecoveryValue()
        {
            NeckLeftX = SeedCenterX + NeckLeftXOffset;
            NeckRightX = SeedCenterX + NeckRightXOffset;
            NeckTopY = SeedCenterY + NeckTopYOffset;
            NeckBottomY = SeedCenterY + NeckBottomYOffset;
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
            }
            FileValue[15] = SeedCenterX.ToString();
            FileValue[16] = SeedCenterY.ToString();
            FileValue[17] = NeckLeftXOffset.ToString();
            FileValue[18] = NeckRightXOffset.ToString();
            FileValue[19] = NeckTopYOffset.ToString();
            FileValue[20] = NeckBottomYOffset.ToString();
            FileValue[21] = NeckThreshold.ToString();
            FileValue[22] = CameraAngle.ToString();
        }
    }
}
