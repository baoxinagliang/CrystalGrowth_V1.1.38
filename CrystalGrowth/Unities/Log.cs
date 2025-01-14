using log4net;
using System;
using System.IO;

namespace CrystalGrowth.Unities
{
    internal static class Log
    {
        static readonly ILog LogMsg = LogManager.GetLogger("Info");
        public static void Record(string msg)
        {
            LogMsg.Debug(msg);
        }
        public static void Record(string msg, Exception ex)
        {
            LogMsg.Debug(msg, ex);
        }
        public static void Delete()
        {
            try
            {
                var files = Directory.GetFiles(string.Concat(Environment.CurrentDirectory, "\\Log\\"));
                foreach (string file in files)
                {
                    string[] fileName = Path.GetFileNameWithoutExtension(file).Split('.');
                    string fileNameDate = string.Concat(fileName[0], "-01 00:00:00");
                    if (fileNameDate.IsDate())
                    {
                        TimeSpan t = DateTime.Now - Convert.ToDateTime(fileNameDate);
                        if (t.Days > 31 || fileName.Length == 2)
                    {
                        File.Delete(file);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogMsg.Debug("删除日志文件失败!", ex);
            }
        }
        public static void ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            LogMsg.Debug("异常", e.Exception);
        }
        public static void UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            LogMsg.Debug("异常", e.ExceptionObject as Exception);
        }
    }
}
