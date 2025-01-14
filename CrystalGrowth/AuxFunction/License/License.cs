using CrystalGrowth.CrystalCtl;
using CrystalGrowth.Unities;
using Microsoft.Win32;
using System;
using System.IO;

namespace CrystalGrowth.AuxFunction.License
{
    internal static class License
    {
        public static string Key;
        private static string DateKey;
        public static string LoadMsgStr;
        public static string MD5Key;
        public static string State;
        public static string ProjectNum;
        public static string Expiration;
        public static bool IsRegist = false;
        /// <summary>
        /// 系统提前五天就提示到期错误
        /// </summary>
        public static bool IsExpire = false;
        public static long ExpirationDelayTime = 0;
        // 延迟授权机制
        public static bool RegistStatus = false;
        // 是否要延迟过期
        public static bool IsDelayExpiration = false;
        public static void Read()
        {
            string TempLicense = string.Empty;
            string TempDate = string.Empty;
            if (File.Exists(FileHelper.LicPath))
            {
                using (StreamReader SR = new StreamReader(FileHelper.LicPath))
                {
                    TempLicense = SR.ReadLine();
                }
            }
            if (File.Exists(FileHelper.StartLicPath))
            {
                using (StreamReader SR = new StreamReader(FileHelper.StartLicPath))
                {
                    TempDate = SR.ReadLine();
                }
            }
            Key = TempLicense;
            DateKey = TempDate;
        }
        public static void Check()
        {
            RegistStatus = IsRegist; // Check之前记录一下当前的授权状态
            EncryptionHelper EncryHelp = new EncryptionHelper();
            string Designer = "LintonKayex-LiuJianYong";
            string RecordDate = "2019-01-01";
            string[] TempStr;
            string ComputerKey = ComputerInfo.GetComputerInfo();
            string EncryptComputer = EncryHelp.EncryptString(ComputerKey);
            MD5Key = EncryHelp.GetMD5String(EncryptComputer);
            if (Key.Length == 0)
            {
                NoLicense();
                return;
            }
            if (DateKey.Length == 0)
            {
                NoLicense();
                return;
            }
            else
            {
                string DateRecord = EncryHelp.DecryptString(DateKey);
                if (DateRecord == string.Empty)
                {
                    NoLicense();
                    return;
                }
                TempStr = DateRecord.Split(new char[] { ',' });
                if (TempStr.Length > 0)
                {
                    if (TempStr[0] == Designer)
                    {
                        RecordDate = TempStr[1];
                    }
                    else
                    {
                        NoLicense();
                        return;
                    }
                }
                else
                {
                    NoLicense();
                    return;
                }
            }
            var DecryHelp = new EncryptionHelper(EncryptionKeyEnum.KeyB);
            string RegistData = DecryHelp.DecryptString(Key);
            if (RegistData.Length == 0)
            {
                NoLicense();
                return;
            }
            TempStr = RegistData.Split(new char[] { ',' });
            if (TempStr.Length > 0)
            {
                if (TempStr[0] == MD5Key)
                {
                    //当前时间比较上下授权日期
                    DateTime LicenseDate = Convert.ToDateTime(TempStr[2]);
                    int DownDiffTime = DateTime.Now.Subtract(LicenseDate).Days;
                    LicenseDate = Convert.ToDateTime(TempStr[3]);
                    int UpDiffTime = LicenseDate.Subtract(DateTime.Now).Days;
                    if (DownDiffTime >= 0 && UpDiffTime >= 0)
                    {
                        //当前时间比较记录时间与上授权日期
                        DateTime NewRecord = Convert.ToDateTime(TempStr[2]);
                        DownDiffTime = (int)(DateTime.Now.Subtract(NewRecord).TotalDays);
                        LicenseDate = Convert.ToDateTime(TempStr[3] + " 23:59:59");
                        UpDiffTime = (int)(LicenseDate.Subtract(DateTime.Now).TotalHours);
                        if (DownDiffTime >= 0 && UpDiffTime >= 0)
                        {
                            LicenseSuccess(TempStr[1], TempStr[3]);
                            int DiffDay = DateTime.Now.Subtract(NewRecord).Days;
                            if (DiffDay == 0)
                            {
                                RecordDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                                WriteDate(RecordDate);
                            }
                            Random rand = new Random();
                            int rnd = rand.Next(1, 6);
                            if (UpDiffTime < 120)
                            {
                                if (UpDiffTime % rnd == 0)
                                {
                                    IsExpire = true;
                                }
                            }
                        }
                        else
                        {
                            if (DownDiffTime < 0)
                            {
                                NoLicense();
                                int time2 = Math.Abs(UpDiffTime) / 24;
                                if (time2 % 2 == 1)
                                {
                                    IsExpire = true;
                                }
                            }
                            if (UpDiffTime < 0)
                            {
                                LicenseExpiration(TempStr[1], TempStr[3]);
                                int time2 = Math.Abs(UpDiffTime) / 24;
                                if (time2 % 2 == 1)
                                {
                                    IsExpire = true;
                                }
                            }
                        }
                    }
                    else
                    {
                        if (DownDiffTime < 0)
                        {
                            NoLicense();
                            if (Math.Abs(UpDiffTime) % 2 == 0)
                            {
                                IsExpire = true;
                            }
                        }
                        if (UpDiffTime < 0)
                        {
                            LicenseExpiration(TempStr[1], TempStr[3]);
                            if (Math.Abs(UpDiffTime) % 2 == 0)
                            {
                                IsExpire = true;
                            }
                        }
                    }
                }
                else
                {
                    NoLicense();
                }
            }
            else
            {
                NoLicense();
            }
        }
        public static void RegDelayCheck()
        {
            // 如果发现授权，清空延迟授权
            if (IsRegist && ExpirationDelayTime != 0)
            {
                ExpirationDelayTime = 0;
                IsDelayExpiration = false;
                SetDelayTime(0);
                return;
            }
            if (ExpirationDelayTime - 1 > 0)
            {
                ExpirationDelayTime--;
                IsDelayExpiration = true;
                SetDelayTime(ExpirationDelayTime);
            }
            else
            {
                SetDelayTime(0);
                IsDelayExpiration = false;
            }
        }
        public static void SetDelayTime(long DelayTime)
        {
            RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software");
            using (RegistryKey subKey = registryKey.CreateSubKey("CrystalGrowth"))
            {
                if (subKey != null)
                {
                    subKey.SetValue("DelayTime", DelayTime);
                }
            }
        }
        public static bool IsSystemCanRun()
        {
            return (IsRegist || IsDelayExpiration);
        }
        public static long GetDelayTime()
        {
            long ret = 0;
            RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software");
            using (RegistryKey subKey = registryKey.CreateSubKey("CrystalGrowth"))
            {
                if (subKey != null)
                {
                    if (subKey.GetValue("DelayTime") != null)
                    {
                        if (long.TryParse(subKey.GetValue("DelayTime").ToString(), out long temp))
                        {
                            ret = temp;
                        }
                    }
                    else
                    {
                        subKey.SetValue("DelayTime", 0);
                    }
                }
            }
            return ret;
        }
        private static void NoLicense()
        {
            // 如果RegistStatus为True说明Check之前系统是有授权的
            // 如果代码执行到这里说明授权丢失了，则开启系统的延迟授权
            if (RegistStatus)
            {
                ExpirationDelayTime = 48 * 60 * 60;
                // 延迟48小时
                SetDelayTime(ExpirationDelayTime);
            }


            State = "未授权";
            ProjectNum = "......";
            Expiration = "......";
            FrmMain.Single.LabLicense.BeginInvoke(new Action(() =>
            {
                FrmMain.Single.LabLicense.Visible = true;
                FrmMain.Single.LabLicense.Text = State;
            }));
            IsRegist = false;
        }
        private static void LicenseSuccess(string Project, string NewDate)
        {
            State = "授权成功";
            ProjectNum = Project;
            Expiration = NewDate;
            FrmMain.Single.LabLicense.BeginInvoke(new Action(() =>
            {
                FrmMain.Single.LabLicense.Visible = false;
                FrmMain.Single.LabLicense.Text = string.Empty;
            }));
            IsRegist = true;
        }
        private static void LicenseExpiration(string Project, string NewDate)
        {
            // 如果RegistStatus为True说明Check之前系统是有授权的
            // 如果代码执行到这里说明授权丢失了，则开启系统的延迟授权
            if (RegistStatus)
            {
                ExpirationDelayTime = 48 * 60 * 60;
                // 延迟48小时
                SetDelayTime(ExpirationDelayTime);
            }

            State = "授权过期";
            ProjectNum = Project;
            Expiration = NewDate;
            FrmMain.Single.LabLicense.Visible = true;
            FrmMain.Single.LabLicense.Text = State;
            IsRegist = false;
        }
        public static void WriteDate(string NewDate)
        {
            string Designer = "LintonKayex-LiuJianYong";
            EncryptionHelper EncryHelp = new EncryptionHelper();
            string EncryptTxt = EncryHelp.EncryptString(string.Concat(Designer, ",", NewDate));
            using (FileStream fStream = new FileStream(FileHelper.StartLicPath, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter SWriter = new StreamWriter(fStream))
                {
                    SWriter.WriteLine(EncryptTxt);
                    SWriter.Flush();
                }
            }
        }
    }
}
