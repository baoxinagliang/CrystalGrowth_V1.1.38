using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CrystalGrowth.Unities
{
    internal static class FileHelper
    {
        public static string LicPath = string.Concat(Application.StartupPath, "\\License\\LICCSLICENSE.LIC");
        public static string StartLicPath = string.Concat(Application.StartupPath, "\\License\\StartLicense.dat");
        public static string RecordPath = string.Concat(Application.StartupPath, "\\Record\\Record.csv");
        public static string GrowthDataPath = string.Concat(Application.StartupPath, "\\Record\\GrowthData.dat");
        public static string DBDataPath = string.Concat(Application.StartupPath, "\\Record\\DBData.csv");
        public static string IdNumPath = string.Concat(Application.StartupPath, "\\Record\\ID_Num.dat");
        public static string AlarmMsgPath = string.Concat(Application.StartupPath, "\\Record\\Alarm.csv");
        public static string VarTabPath = string.Concat(Application.StartupPath, "\\VarShow\\VarTab.dat");
        public static string ConfigPath = string.Concat(Application.StartupPath, "\\SOP\\Config.txt");
        public static string Cam1Path = string.Concat(Application.StartupPath, "\\CCD\\Camera1Config.dat");
        public static string Cam2Path = string.Concat(Application.StartupPath, "\\CCD\\Camera2Config.dat");
        public static string DualCamPath = string.Concat(Application.StartupPath, "\\CCD\\DualCamera.dat");
        public static string PredictModelPath = string.Concat(Application.StartupPath, "\\Model\\infer_model");
        public static string LoginDataPath = string.Concat(Application.StartupPath, "\\Login\\LOGIN_DATA.db3");
        public static string CalibrationPath = string.Concat(Application.StartupPath, "\\Calibration\\CalibValue.cal");
        public static string CalibDateTimePath = string.Concat(Application.StartupPath, "\\Calibration\\CalibDateTime.dat");
        public static string CLSLCalcPath = string.Concat(Application.StartupPath, "\\WeightSafe\\CL_SL_Calc.dat");
        public static string CrucParaPath = string.Concat(Application.StartupPath, "\\WeightSafe\\CrucPara.dat");
        public static string HotZonePath = string.Concat(Application.StartupPath, "\\HotZone\\HotZone.dat");
        public static string LimitValAIPath = string.Concat(Application.StartupPath, "\\Trend\\LimitValAI.dat");
        public static string LimitValAOPath = string.Concat(Application.StartupPath, "\\Trend\\LimitValAO.dat");
        public static string LimitValCalcPath = string.Concat(Application.StartupPath, "\\Trend\\LimitValCalc.dat");
        public static string HisSelPath = string.Concat(Application.StartupPath, "\\Trend\\HisVarSel.dat");
        public static string LimitValPath = string.Concat(Application.StartupPath, "\\Trend\\LimitVal.dat");
        public static string TVarSelPath = string.Concat(Application.StartupPath, "\\Trend\\VarSel.dat");
        public static string FeedPath = string.Concat(Application.StartupPath, "\\Record\\Feed.dat");
        public static string FeedCurPath = string.Concat(Application.StartupPath, "\\Record\\FeedCur.dat");
        public static string RecordLogName = string.Format("D:\\Record_bak\\Record_Log{0}.csv", DateTime.Now.ToString("yyyyMMddHHmmss"));
        public static string RecordAlarm = string.Format("D:\\LICCS_ALARM\\Alarm.csv");
         // 工序跳转存图默认路径
        public static string JumpSavePath = "D:\\LICCS_JUMP";
        // 虚拟相机图片路径
        public static string VirtualCameraPath = string.Concat(@"C:\2");

        //持久化参数文件
        public static string ParameterPath = string.Concat(Application.StartupPath, "\\Parameter\\parameter.json");

        /// <summary>
        /// 删除数据文件
        /// </summary>
        public static void Delete(string directory, string likestr, string currentFileName, int day)
        {
            DirectoryInfo Dir = new DirectoryInfo(directory);
            FileInfo[] Files = Dir.GetFiles(likestr, SearchOption.TopDirectoryOnly);
            int Length = Files.Length;
            if (Length > 0)
            {
                for (int i = 0; i < Length; i++)
                {
                    if (Math.Abs((Files[i].CreationTime - DateTime.Now).Days) > day && Files[i].FullName != currentFileName)
                    {
                        File.Delete(Files[i].FullName);
                    }
                }
            }
        }
        public static void WriteIn(string path, string[] contxt)
        {
            string pathfile = Path.GetDirectoryName(path);
            if (!Directory.Exists(pathfile))
            {
                Directory.CreateDirectory(pathfile);
            }
            using (FileStream fStream = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter SWriter = new StreamWriter(fStream, Encoding.UTF8))
                {
                    for (int i = 0; i < contxt.Length; i++)
                    {
                        SWriter.WriteLine(contxt[i]);
                    }
                    SWriter.Flush();   
                }
            }
        }

        public static long GetDirectoryLength(string dirPath)
        {
          //判断给定的路径是否存在,如果不存在则退出
           if (!Directory.Exists(dirPath))
             return 0;
           long len = 0;
          //定义一个DirectoryInfo对象
           DirectoryInfo di = new DirectoryInfo(dirPath);
           //通过GetFiles方法,获取di目录中的所有文件的大小
           foreach (FileInfo fi in di.GetFiles())
           {
             len += fi.Length;
           }
           //获取di中所有的文件夹,并存到一个新的对象数组中,以进行递归
           DirectoryInfo[] dis = di.GetDirectories();
           if (dis.Length > 0)
           {
             for (int i = 0; i < dis.Length; i++)
             {
               len += GetDirectoryLength(dis[i].FullName);
             }
           }
           return len;
        }
    }
}
