﻿namespace CrystalGrowth.Unities
{
    internal static class Mode
    {
        public static bool CutLine = false;
        /// <summary>
        /// 液口距手自动标识
        /// </summary>
        public static bool MeltGapFlag = false;
        /// <summary>
        /// 空闲模式 
        /// </summary>
        public static int Idle = 0;
        /// <summary>
        /// 引晶模式
        /// </summary> 
        public static int Neck = 1;
        /// <summary>
        /// 放肩模式
        /// </summary>
        public static int Crown = 2;
        /// <summary>
        /// 等径模式
        /// </summary>
        public static int Body = 3;
        public static int Last = 0;
        /// <summary>
        /// 当前模式
        /// </summary>
        private static int current = -1;
        public static int Current
        {
            get
            {
                return current;
            }
            set
            {
                if (current != value)
                {
                    current = value;
                    IgAlgo1.ThresholdCount = 0;
                    IgAlgo1.sum = 0;
                    IgAlgo1.ThresholdAvergeValue = 0;
                }
            }
        }
    }
}