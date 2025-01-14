using CrystalGrowth.GrowRecord;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CrystalGrowth.Unities
{
    internal class RecordInfo
    {
        public string Time;
        public string Name;
        public string Value;
        public string Color;
    }
    internal static class Record
    {
        public static Queue<RecordInfo> RecQueue;
        /// <summary>
        /// 读出文件信息
        /// </summary>
        public static void ReadOut()
        {
            try
            {
                string[] Lines = File.ReadAllLines(FileHelper.RecordPath, Encoding.UTF8);
                int Length = Lines.Length;
                string[] TempVar;
                char[] SplitChar = new char[] { ',' };
                if (Length > 0)
                {
                    int TopRow = Length > 5000 ? Length - 5000 : 0;
                    for (int i = TopRow; i < Length; i++)
                    {
                        TempVar = Lines[i].Split(SplitChar);
                        if (TempVar.Length == 4)
                        {
                            RecQueue.Enqueue(new RecordInfo() { Time = TempVar[0], Name = TempVar[1], Value = TempVar[2], Color = TempVar[3] });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Record("读取数据记录文件错误!", ex);
            }
        }
        private static void WriteFile(string Str1, string Str2, string Str3, string Str4)
        {
            string str = string.Format("{0},{1},{2},{3}", Str1, Str2, Str3, Str4);
            //.Csv写入记录
            using (FileStream fStream = new FileStream(FileHelper.RecordPath, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter SWriter = new StreamWriter(fStream, Encoding.UTF8))
                {
                    SWriter.WriteLine(str);
                    SWriter.Flush();
                }
            }
            if (!Directory.Exists("D:\\Record_bak"))
            {
                Directory.CreateDirectory("D:\\Record_bak");
            }
            if (File.Exists(FileHelper.RecordLogName))
            {
                using (FileStream fStream = new FileStream(FileHelper.RecordLogName, FileMode.Append, FileAccess.Write))
                {
                    using (StreamWriter SWriter = new StreamWriter(fStream, Encoding.UTF8))
                    {
                        SWriter.WriteLine(str);
                        SWriter.Flush();
                    }
                }
            }
            else
            {
                using (FileStream fStream = new FileStream(FileHelper.RecordLogName, FileMode.Create, FileAccess.Write))
                {
                    using (StreamWriter SWriter = new StreamWriter(fStream, Encoding.UTF8))
                    {
                        SWriter.WriteLine(str);
                        SWriter.Flush();
                    }
                }
            }
        }
        /// <summary>
        /// 写入记录文件
        /// </summary>
        public static void WriteIn(string RecStr, string RecValue, string ColorType)
        {
            string StrDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            WriteFile(StrDateTime, RecStr, RecValue, ColorType);
            if (Record.RecQueue != null)
            {
                RecQueue.Enqueue(new RecordInfo() { Time = StrDateTime, Name = RecStr, Value = RecValue, Color = ColorType });
                if (RecQueue.Count > 5000)
                {
                    RecQueue.Dequeue();
                }
            }
        }
        /// <summary>
        /// 清空文件信息
        /// </summary>
        public static void Clear()
        {
            using (FileStream fStream = new FileStream(FileHelper.RecordPath, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter SWriter = new StreamWriter(fStream, Encoding.UTF8))
                {
                    SWriter.WriteLine("");
                    SWriter.Flush();
                }
            }
            FrmGrowRecord.PageNum = 1;
            //删除三个月前的文件
            FileHelper.RecordLogName = string.Format("D:\\Record_bak\\Record_Log{0}.csv", DateTime.Now.ToString("yyyyMMddHHmmss"));
            FileHelper.Delete("D:\\Record_bak", "*.csv", FileHelper.RecordLogName, 90);
            FileHelper.Delete("D:\\LICCS_DB", "*.db3", SqliteHelper.Conn.FileName, 90);
            Log.Delete();
        }
    }
}
