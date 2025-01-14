using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CrystalGrowth.Unities
{

    /// <summary>
    /// 单个椭圆信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct LKELLIPS
    {
        public double x;
        public double y;
        public double lkellips_width;
        public double lkellips_height;
        public double lkellips_angle;
    }


    /// <summary>
    /// 绝对液口距计算结果
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct YKJ_Info
    {
        [MarshalAs(UnmanagedType.Struct)]
        public LKELLIPS far_ellips;
        [MarshalAs(UnmanagedType.Struct)]
        public LKELLIPS near_ellips;
        public double ykj_value;
        public int index;
    }
}
