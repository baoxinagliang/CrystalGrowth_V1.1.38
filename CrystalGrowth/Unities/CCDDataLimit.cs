using System;

namespace CrystalGrowth.Unities
{
    internal class CCDDataLimit
    {
        /// <summary>
        /// 引晶，放肩Y值限制
        /// </summary>
        public bool YNC(ref string info, int para1, int para2)
        {
            if (Math.Abs(para1 - para2) < 30)
            {
                info = "Y轴值绝对差值不能低于30！";
                return true;
            }
            else
            {
                info = "";
                return false;
            }
        }
        /// <summary>
        /// 等径Y值限制
        /// </summary>
        public bool YD(ref string info, int para1, int para2)
        {
            if (Math.Abs(para1 - para2) < 55)
            {
                info = "Y轴值绝对差值不能低于55！";
                return true;
            }
            else
            {
                info = "";
                return false;
            }
        }
    }
}
