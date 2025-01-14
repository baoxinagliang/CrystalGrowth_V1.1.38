using System.IO;
using System.Text;

namespace CrystalGrowth.Unities
{
    internal static class IdNum
    {
        static readonly string[] StrName = new string[6];
        static readonly string[] StrValue = new string[6];
        public static string FurnaceID = string.Empty, CrystalID = string.Empty, RunNumID = string.Empty, StaffID = string.Empty;
        /// <summary>
        ///登录读取ID_Num.dat
        /// </summary>
        public static void ReadOut()
        {
            string[] Lines = File.ReadAllLines(FileHelper.IdNumPath, Encoding.UTF8);
            int Length = Lines.Length;
            string[] TempVar;
            char[] SplitChar = new char[] { '=' };
            if (Length > 0)
            {
                for (int i = 0; i < Length; i++)
                {
                    TempVar = Lines[i].Split(SplitChar);
                    if ((TempVar.Length == 2))
                    {
                        StrName[i] = TempVar[0];
                        StrValue[i] = TempVar[1];
                    }
                }
            }
            FurnaceID = StrValue[0];
            CrystalID = StrValue[1];
            RunNumID = StrValue[2];
            StaffID = StrValue[3];
        }
        /// <summary>
        /// 退出写入数据ID_Num.dat
        /// </summary>
        public static void WriteIn()
        {
            string[] Lines = new string[StrName.Length - 2];
            int Length = Lines.Length;
            StrValue[0] = FurnaceID;
            StrValue[1] = CrystalID;
            StrValue[2] = RunNumID;
            StrValue[3] = StaffID;
            if (Length > 0)
            {
                for (int i = 0; i < Length; i++)
                {
                    if (StrName[i] != "")
                    {
                        Lines[i] = string.Concat(StrName[i], "=", StrValue[i]);
                    }
                }
            }
            File.WriteAllLines(FileHelper.IdNumPath, Lines);
        }
    }
}