namespace CrystalGrowth.Unities
{
    internal struct LineFile
    {
        public string Name;
        public string Stat;
    }
    internal struct LastInputInfo
    {
        public int cbSize;
        public int dwTime;
    }
    internal static class Level
    {
        /// <summary>
        /// 登录用户名
        /// </summary>
        public static string UserName = "";
        /// <summary>
        /// 角度放肩斜率表
        /// </summary>
        public static bool KayexAdmin = false;
        /// <summary>
        /// 真空计校准
        /// </summary>
        public static bool SuperUser = false;
        /// <summary>
        /// 校准参数，液位补偿系数,sop直径保护，热屏
        /// </summary>
        public static bool PermitModify = false;
        /// <summary>
        /// 主副室强制
        /// </summary>
        public static bool FTPCForce = false;
        /// <summary>
        /// 液口距安全
        /// </summary>
        public static bool MeltGapSafe = false;
        /// <summary>
        /// 长液口距
        /// </summary>
        public static bool MeltGapLArea = false;
        /// <summary>
        /// SOP编辑，下载
        /// </summary>
        public static bool Operator = false;
    }
}
