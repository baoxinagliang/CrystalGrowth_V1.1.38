﻿using CrystalGrowth.Unities;
using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction.License
{
    internal partial class FrmLicense : Form
    {
        public FrmLicense()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void FrmLicense_Load(object sender, EventArgs e)
        {
            LabReqMsg.Visible = false;
            LabLicenseMsg.Visible = false;
            LabReqMsg.Text = string.Empty;
            LabLicenseMsg.Text = string.Empty;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            LabLicenseState.Text = License.State;
            LabProjectNum.Text = License.ProjectNum;
            LabExpiration.Text = License.Expiration;

            if (License.IsDelayExpiration)
            {
                label4.Visible = true;
                LabRegDelay.Visible = true;
                LabRegDelay.Text = (License.ExpirationDelayTime / 60).ToString() + " min";
            }
            else
            {
                label4.Visible = false;
                LabRegDelay.Visible = false;
            }
        }
        private void BtnRequestFile_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnRequestFile))
            {
                try
                {
                    DriveInfo[] DriveSymbol = DriveInfo.GetDrives();
                    int Length = DriveSymbol.Length;
                    string FileName = License.ProjectNum == "......" ? "LICCSLICENSE.REQ" : string.Format("LICCSLICENSE_{0}.REQ", License.ProjectNum);
                    for (int i = 0; i < Length; i++)
                    {
                        if (DriveSymbol[i].IsReady && DriveSymbol[i].DriveFormat == "FAT32")
                        {
                            using (FileStream fStream = new FileStream(string.Concat(DriveSymbol[i].Name, FileName), FileMode.Create, FileAccess.Write))
                            {
                                using (StreamWriter SWriter = new StreamWriter(fStream))
                                {
                                    SWriter.WriteLine(License.MD5Key);
                                    SWriter.Flush();
                                }
                            }       
                            LabReqMsg.Visible = true;
                            LabReqMsg.Text = "创建授权请求文件成功";
                            break;
                        }
                        if (i + 1 == DriveSymbol.Length)
                        {
                            LabReqMsg.Visible = true;
                            LabReqMsg.Text = "未找到FAT32格式移动盘";
                        }
                    }
                }
                catch (Exception ex)
                {
                    LabReqMsg.Text = "写入移动盘文件异常!";
                    Log.Record("写入移动盘文件异常!", ex);
                }
            }
        }
        private void LoadLicense()
        {
            try
            {
                DriveInfo[] DriveSymbol = DriveInfo.GetDrives();
                int Length = DriveSymbol.Length;
                int FilesLength = 0;
                bool Success = false;
                License.LoadMsgStr = "";
                DirectoryInfo Dir;
                FileInfo[] Files;
                StreamReader SR;
                for (int i = 0; i < Length; i++)
                {
                    if (DriveSymbol[i].IsReady && DriveSymbol[i].DriveFormat == "FAT32")
                    {
                        Dir = new DirectoryInfo(DriveSymbol[i].Name);
                        Files = Dir.GetFiles("*.LIC", SearchOption.AllDirectories);
                        FilesLength = Files.Length;
                        if (FilesLength > 0)
                        {
                            for (int j = 0; j < FilesLength; j++)
                            {
                                using (SR = new StreamReader(Files[j].FullName))
                                {
                                    License.Key = SR.ReadLine();
                                }
                                License.Check();
                                if (License.IsRegist)
                                {
                                    File.Copy(Files[j].FullName, FileHelper.LicPath, true);
                                    Success = true;
                                    LabLicenseMsg.BeginInvoke(new Action(() =>
                                    {
                                        LabLicenseMsg.Visible = true;
                                        LabLicenseMsg.Text = "加载授权文件完成";
                                    }));
                                    License.LoadMsgStr = "加载授权文件完成";
                                    break;
                                }
                            }
                            if (Success)
                            {
                                break;
                            }
                            if (i + 1 == Length)
                            {
                                License.Read();
                                License.Check();
                                LabLicenseMsg.BeginInvoke(new Action(() =>
                                {
                                    LabLicenseMsg.Visible = true;
                                    LabLicenseMsg.Text = "加载授权文件无效";
                                }));
                                License.LoadMsgStr = "加载授权文件无效";
                                break;
                            }
                        }
                        else
                        {
                            if (i + 1 == Length)
                            {
                                LabLicenseMsg.BeginInvoke(new Action(() =>
                                {
                                    LabLicenseMsg.Visible = true;
                                    LabLicenseMsg.Text = "未找到授权文件";
                                }));
                                License.LoadMsgStr = "未找到授权文件";
                                break;
                            }
                        }
                    }
                    if (i + 1 == DriveSymbol.Length)
                    {
                        LabLicenseMsg.BeginInvoke(new Action(() =>
                        {
                            LabLicenseMsg.Text = "未找到FAT32格式移动盘";
                            LabLicenseMsg.Visible = true; LabLicenseMsg.Refresh();
                        }));
                        License.LoadMsgStr = "未找到FAT32格式移动盘";
                    }
                }
            }
            catch (Exception ex)
            {
                LabLicenseMsg.BeginInvoke(new Action(() =>
                {
                    LabLicenseMsg.Visible = true;
                    LabLicenseMsg.Text = "读取移动盘文件异常";
                }));
                License.LoadMsgStr = "读取移动盘文件异常";
                Log.Record("读取移动盘文件异常！", ex);
            }
        }
        private void BtnLicense_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnLicense))
            {
                BtnLicense.Enabled = false;
                Thread thread = new Thread(LoadLicense);
                thread.Start();
                thread.Join();
                LabLicenseMsg.Visible = true;
                LabLicenseMsg.Text = License.LoadMsgStr;
                License.Check();
                BtnLicense.Enabled = true;
            }
        }
    }
}
