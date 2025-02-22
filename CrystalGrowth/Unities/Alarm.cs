﻿using CamLibrary;
using CrystalGrowth.AuxFunction;
using CrystalGrowth.AuxFunction.CCD;
using CrystalGrowth.AuxFunction.License;
using CrystalGrowth.CrystalCtl;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CrystalGrowth.Unities
{
    internal static class Alarm
    {
        private static readonly string[] Info = new string[519];//报警信息
        private static List<string> MoveList = new List<string>();//跑马灯移动列表
        public static List<string> RealList = new List<string>();//实时报警列表
        public static List<string> LastRealList = new List<string>();
        private static readonly int[] RcvStatus = new int[519];//报警接收数组
        public static bool LostWeightFlag = false;
        public static bool LostSmallWeightFlag = false;
        public static bool CutLineError = false;
        public static bool AlgoCalcuError = false;
        private static bool OverMaxWeightFlag = false;
        private static bool WeightThresholdFlag = false;
        private static bool CrownGrowthFastFlag = false;
        private static bool HotCheckLeakbackFlag = false;
        private static bool LiftCoverPreFlag = false;
        private static bool CrystalColdDlgFlag = true;
        private static bool FullMeltFlag = false;

        private static bool CrucLiftMotorFlag = false;
        private static bool CrucRotMotorFlag = false;
        private static bool SeedLiftMotorFlag = false;
        private static bool SeedRotMotorFlag = false;
        private static bool ShieldMMotorFlag = false;
        private static bool ShieldSMotorFlag = false;
        private static bool SmartFlag = false;
        private static bool SeedLiftEncoderFlag = false;
        private static bool CrucLiftEncoderFlag = false;
        private static bool ShieldEncoderFlag = false;

        public static bool SqliteErr1Flag = false;
        public static bool SqliteErr2Flag = false;
        private static int CamDisConnCount1 = 0;// 相机断开连接次数
        private static int CamDisConnCount2 = 0;
        private static int LoopCount = 0;
        private static int Index = 0;
        private static string ShowStr = "";
        public static void LoadInfo()
        {
            ////第一级报警1~128;
            ////第二级报警129~256
            ////第三级报警257~512
            ////第四级报警513~517
            string[] Lines = File.ReadAllLines(FileHelper.AlarmMsgPath, Encoding.Default);
            int Lenght = Lines.Length;
            for (int i = 0; i < Lenght; i++)
            {
                Info[i + 1] = Lines[i];
            }
        }
        private static void CyclicDisplay()
        {
            LoopCount++;
            if (LoopCount <= RealList.Count)
            {
                FrmMain.Single.LabAlarm.Text = RealList[LoopCount - 1];
            }
            else
            {
                FrmMain.Single.LabAlarm.Text = "";
                LoopCount = 0;
            }
        }
        private static void Trigger()
        {
            for (int i = 1; i <= 517; i++)
            {
                //如果通信成功
                if (PLC.IsConn)
                {
                    if (i != 512)
                    {
                        RcvStatus[i] = PLC.StatusAlarm[i];
                    }
                }
                else
                {
                    if (i != 393 && i != 394 && i != 399 && i != 182 && i != 512)
                    {
                        RcvStatus[i] = 0;
                    }
                }
                if (i >= 257)
                {
                    //存在三级报警
                    if (RcvStatus[i] == 0 && RealList.Contains(Info[i]))
                    {
                        RealList.Remove(Info[i]);
                    }
                    if (RcvStatus[i] == 1 && !RealList.Contains(Info[i]) && Info[i] != "")
                    {
                        RealList.Add(Info[i]);
                        DbRecord(Info[i]);
                    }
                }
                else
                {
                    //存在二级一级报警   
                    if (RcvStatus[i] == 0 && MoveList.Contains(Info[i]))
                    {
                        MoveList.Remove(Info[i]);
                    }
                    if (RcvStatus[i] == 1 && !MoveList.Contains(Info[i]) && Info[i] != "")
                    {
                        MoveList.Add(Info[i]);
                        Record.WriteIn(Info[i], "", "Red");
                    }
                }
            }
        }
        private static void ClearState()
        {
            if (RealList.Count == 0 && MoveList.Count == 0)
            {
                FrmMain.Single.Panel3.BackColor = FrmMain.Single.Panel2.BackColor;
                FrmMain.Single.LabAlarm.Text = "";
                FrmMain.Single.LabAutoStat.Text = "";
            }
            else
            {
                FrmMain.Single.Panel3.BackColor = Color.Red;
            }
        }
        public static void RunnLampOut(ref List<string> AlarmList, int ShowLength)
        {
            string CheckStr = "";
            foreach (string TempStr in AlarmList)
            {
                CheckStr = string.Concat(CheckStr, TempStr, " ");
            }
            if (CheckStr != ShowStr)
            {
                ShowStr = CheckStr;
                Index = 0;
            }
            if (ShowLength >= ShowStr.Length)
            {
                FrmMain.Single.LabAutoStat.Text = ShowStr;
            }
            else
            {
                if (Index + ShowLength <= ShowStr.Length)
                {
                    FrmMain.Single.LabAutoStat.Text = ShowStr.Substring(Index, ShowLength);
                }
                else
                {
                    FrmMain.Single.LabAutoStat.Text = ShowStr.Substring(Index, ShowStr.Length - Index) + ShowStr.Substring(0, ShowLength - (ShowStr.Length - Index));
                }
                Index = (Index + 8) % ShowStr.Length;
            }
        }
        public static void Output()
        {
            ClearState();//清除报警状态
            CyclicDisplay();//循环显示
            Trigger();//报警触发器
            RunnLampOut(ref MoveList, 16);//跑马灯显示
            ExpTrigger();//额外报警触发
        }
        public static void ExpTrigger()
        {
            //连接PLC失败，此时通讯未通，只能上位机处理，StatusAlarm(393) = 1
            if (PLC.IsConn)
            {
                //如果连接成功，PLC报警状态置位0
                if (PLC.StatusAlarm[393] == 1)
                {
                    PLC.SendBit(36, 392, 0);
                }
                RcvStatus[393] = 0;
            }
            else
            {
                //连接PLC失败
                if (RcvStatus[393] == 0)
                {
                    RcvStatus[393] = 1;
                    PLC.SendBit(36, 392, 1);
                }
            }
            //倒计时完成
            if (FrmTimer.TimerSw == 1 && FrmTimer.TimerValReal == 0 && RcvStatus[182] == 0)
            {
                RcvStatus[182] = 1;
                PLC.SendBit(36, 181, 1);
            }
            if (FrmTimer.TimerSw == 0 && FrmTimer.TimerValReal == 0 && RcvStatus[182] == 1)
            {
                RcvStatus[182] = 0;
                PLC.SendBit(36, 181, 0);
            }
            //数据库报警
            if (SqliteErr1Flag || SqliteErr2Flag)
            {
                if (RcvStatus[512] == 0)
                {
                    RcvStatus[512] = 1;
                }
            }
            else
            {
                RcvStatus[512] = 0;
            }
            //连接相机故障
            if (!Hik.IsConn1 && !Basler.IsConn1 && !Avt.IsConn1)
            {
                CamDisConnCount1++;
                if (CamDisConnCount1 > 5)
                {
                    if (RcvStatus[394] == 0)
                    {
                        RcvStatus[394] = 1;
                        PLC.SendBit(36, 393, 1);
                        //相机故障，相关变量置空
                        PLC.SendBit(36, 394, 0);
                        PLC.SendBit(36, 395, 0);
                        PLC.SendBit(36, 396, 0);
                        PLC.SendBit(36, 397, 0);
                    }
                    CamDisConnCount1 = 0;
                }
            }
            else
            {
                if (DualCam.DoubleCam == "2")
                {
                    if ((Avt.IsConn1 && Avt.IsConn2 || Basler.IsConn1 && Basler.IsConn2
                        || Hik.IsConn1 && Hik.IsConn2) && RcvStatus[394] == 1)
                    {
                        PLC.SendBit(36, 393, 0);
                        RcvStatus[394] = 0;
                    }
                }
                else
                {
                    if ((Avt.IsConn1 || Basler.IsConn1 || Hik.IsConn1) && RcvStatus[394] == 1)
                    {
                        PLC.SendBit(36, 393, 0);
                        RcvStatus[394] = 0;
                    }
                }
            }
            if (DualCam.DoubleCam == "2")
            {
                if (!Avt.IsConn2 && !Basler.IsConn2 && !Hik.IsConn2)
                {
                    CamDisConnCount2++;
                    if (CamDisConnCount2 > 5)
                    {
                        if (RcvStatus[394] == 0)
                        {
                            RcvStatus[394] = 1;
                            PLC.SendBit(36, 393, 1);
                        }
                        CamDisConnCount2 = 0;
                    }
                }
                else
                {
                    if ((Avt.IsConn1 && Avt.IsConn2 || Basler.IsConn1 && Basler.IsConn2
                        || Hik.IsConn1 && Hik.IsConn2) && RcvStatus[394] == 1)
                    {
                        PLC.SendBit(36, 393, 0);
                        RcvStatus[394] = 0;
                    }
                }
            }
            if (Avt.IsConn1 || Basler.IsConn1 || Hik.IsConn1)
            {
                //相机采集引晶直径错误
                if (Mode.Current == Mode.Neck && AlgoCalcuError)
                {
                    if (RcvStatus[395] == 0)
                    {
                        RcvStatus[395] = 1;
                        PLC.SendBit(36, 394, 1);
                    }
                }
                else
                {
                    if (RcvStatus[395] == 1)
                    {
                        PLC.SendBit(36, 394, 0);
                    }
                    RcvStatus[395] = 0;
                }
                //相机测量放肩直径错误
                if (Mode.Current == Mode.Crown && AlgoCalcuError)
                {
                    if (RcvStatus[396] == 0)
                    {
                        RcvStatus[396] = 1;
                        PLC.SendBit(36, 395, 1);
                    }
                }
                else
                {
                    if (RcvStatus[396] == 1)
                    {
                        PLC.SendBit(36, 395, 0);
                    }
                    RcvStatus[396] = 0;
                }
                //相机测量等径直径错误
                if (Mode.Current == Mode.Body && AlgoCalcuError)
                {
                    if (RcvStatus[397] == 0)
                    {
                        RcvStatus[397] = 1;
                        PLC.SendBit(36, 396, 1);
                    }
                }
                else
                {
                    if (RcvStatus[397] == 1)
                    {
                        PLC.SendBit(36, 396, 0);
                    }
                    RcvStatus[397] = 0;
                }
                //晶体已经断棱线
                if (PLC.ReadValue[1] == 13 && CutLineError)
                {
                    if (RcvStatus[398] == 0)
                    {
                        RcvStatus[398] = 1;
                        PLC.SendBit(36, 397, 1);
                    }
                }
                else
                {
                    if (RcvStatus[398] == 1)
                    {
                        PLC.SendBit(36, 397, 0);
                    }
                    RcvStatus[398] = 0;
                }
            }
            else
            {
                RcvStatus[395] = 0;
                RcvStatus[396] = 0;
                RcvStatus[397] = 0;
                RcvStatus[398] = 0;
                if (PLC.StatusAlarm[395] == 1)
                {
                    PLC.SendBit(36, 394, 0);
                }
                if (PLC.StatusAlarm[396] == 1)
                {
                    PLC.SendBit(36, 395, 0);
                }
                if (PLC.StatusAlarm[397] == 1)
                {
                    PLC.SendBit(36, 396, 0);
                }
                if (PLC.StatusAlarm[398] == 1)
                {
                    PLC.SendBit(36, 397, 0);
                }
            }
            //到期异常报警
            if (License.IsExpire)
            {
                if (RcvStatus[399] == 0)
                {
                    RcvStatus[399] = 1;
                    PLC.SendBit(36, 398, 1);
                }
            }
            else
            {
                if (RcvStatus[399] == 1)
                {
                    PLC.SendBit(36, 398, 0);
                }
                RcvStatus[399] = 0;
            }
            if (FrmMeltCheckArea.CheckFlag)
            {
                if (IgAlgo1.avg <= ParasCam1.FullMelt)
                {
                    if (FullMeltFlag == false)
                    {
                        FullMeltFlag = true;
                        PLC.SendBit(30, 167, 1);
                    }
                }
                else
                {
                    FullMeltFlag = false;
                    PLC.SendBit(30, 167, 0);
                }
            }
            if (PLC.IsConn)
            {
                //等待副室旋转完成对话框
                if (PLC.StatusAlarm[158] == 1)
                {
                    if (CrystalColdDlgFlag)
                    {
                        CrystalColdDlgFlag = false;
                        new FrmPopUp().ShowDialog();
                    }
                }
                else
                {
                        CrystalColdDlgFlag = true;
                    }
                //放肩过快
                if (PLC.StatusAlarm[271] == 1)
                {
                    if (CrownGrowthFastFlag == false)
                    {
                        CrownGrowthFastFlag = true;
                        DialogResult dr = MessageBox.Show("放肩过快，是否继续请确认？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dr == DialogResult.Yes)
                        {
                            PLC.SendBit(30, 131, 1);
                        }
                        else
                        {
                            PLC.SendBit(30, 132, 1);
                        }
                    }
                }
                else
                {
                    CrownGrowthFastFlag = false;
                }
                //最大投料量警告值
                if (PLC.StatusAlarm[279] == 1)
                {
                    if (WeightThresholdFlag == false)
                    {
                        WeightThresholdFlag = true;
                        DialogResult dr = MessageBox.Show("投料重量已达到预警值，是否继续加料请确认！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dr == DialogResult.Yes)
                        {
                            PLC.SendBit(30, 118, 1);
                        }
                        else
                        {
                            PLC.SendBit(30, 120, 1);
                        }
                    }
                }
                else
                {
                    WeightThresholdFlag = false;
                }
                //达到最大加料量上限值
                if (PLC.StatusAlarm[280] == 1)
                {
                    if (OverMaxWeightFlag == false)
                    {
                        OverMaxWeightFlag = true; //确认对话框
                        DialogResult dr = MessageBox.Show("投料重量已超过最大上限，是否继续加料请确认！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dr == DialogResult.Yes)
                        {
                            PLC.SendBit(30, 119, 1);
                        }
                        else
                        {
                            PLC.SendBit(30, 121, 1);
                        }
                    }
                }
                else
                {
                    OverMaxWeightFlag = false;
                }
                //失重安全保护倒计时
                if (PLC.StatusAlarm[517] == 1)
                {
                    if (LostWeightFlag == false)
                    {
                        LostWeightFlag = true;
                        new FrmLostWeightPopUp().ShowDialog();
                    }
                }
                else
                {
                    LostWeightFlag = false;
                }
                if (PLC.StatusAlarm[518] == 1)
                {
                    if (LostSmallWeightFlag == false)
                    {
                        LostSmallWeightFlag = true;
                        new FrmLostSmallWeightPopUp().ShowDialog();
                    }
                }
                else
                {
                    LostSmallWeightFlag = false;
                }
            }
            if (PLC.StatusAlarm[39] == 1)
            {
                if (HotCheckLeakbackFlag == false)
                {
                    Record.WriteIn("   泄漏率(mtorr/hr)", Math.Round(PLC.ReadCalcValue[17], 1).ToString("f1"), "White");
                    HotCheckLeakbackFlag = true;
                }
            }
            else
            {
                HotCheckLeakbackFlag = false;
            }
            //提渣预调温
            if (PLC.StatusAlarm[41] == 1)
            {
                if (LiftCoverPreFlag == false)
                {
                    LiftCoverPreFlag = true;
                    DialogResult answer = MessageBox.Show("是否打开提渣预调温功能请确认？", "提渣预调温", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (answer == DialogResult.Yes)
                    {
                        PLC.SendBit(30, 141, 1);
                    }
                    else
                    {
                        PLC.SendBit(30, 141, 0);
                    }
                }
            }
            else
            {
                LiftCoverPreFlag = false;
            }
            //编码器故障
            if (PLC.StatusAlarm[278] == 1 && PLC.ReadValue[99] != 0)
            {
                if (SeedLiftEncoderFlag == false)
                {
                    DbRecord(string.Format("晶升编码器反馈异常,偏差值{0}", PLC.ReadValue[99].ToString()));
                    SeedLiftEncoderFlag = true;
                }
            }
            else
            {
                SeedLiftEncoderFlag = false;
            }
            if (PLC.StatusAlarm[450] == 1 && PLC.ReadValue[101] != 0)
            {
                if (ShieldEncoderFlag == false)
                {
                    DbRecord(string.Format("热屏编码器反馈异常,偏差值{0}", PLC.ReadValue[101].ToString()));
                    ShieldEncoderFlag = true;
                }
            }
            else
            {
                ShieldEncoderFlag = false;
            }
            if (PLC.StatusAlarm[451] == 1 && PLC.ReadValue[100] != 0)
            {
                if (CrucLiftEncoderFlag == false)
                {
                    DbRecord(string.Format("埚升编码器反馈异常,偏差值{0}", PLC.ReadValue[100].ToString()));
                    CrucLiftEncoderFlag = true;
                }
            }
            else
            {
                CrucLiftEncoderFlag = false;
            }
            //20211114 -电机故障
            if (PLC.StatusAlarm[355] == 1 && PLC.ReadAnalogIn[34] != 0)
            {
                if (CrucLiftMotorFlag == false)
                {
                    DbRecord(string.Format("埚升电机故障,状态码0x{0:X}", PLC.ReadAnalogIn[34]));
                    CrucLiftMotorFlag = true;
                }
            }
            else
            {
                CrucLiftMotorFlag = false;
            }
            if (PLC.StatusAlarm[356] == 1 && PLC.ReadAnalogIn[38] != 0)
            {
                if (CrucRotMotorFlag == false)
                {
                    DbRecord(string.Format("埚转电机故障,状态码0x{0:X}", PLC.ReadAnalogIn[38]));
                    CrucRotMotorFlag = true;
                }
            }
            else
            {
                CrucRotMotorFlag = false;
            }
            if (PLC.StatusAlarm[357] == 1 && PLC.ReadAnalogIn[33] != 0)
            {
                if (SeedLiftMotorFlag == false)
                {
                    DbRecord(string.Format("晶升电机故障,状态码0x{0:X}", PLC.ReadAnalogIn[33]));
                    SeedLiftMotorFlag = true;
                }
            }
            else
            {
                SeedLiftMotorFlag = false;
            }
            if (PLC.StatusAlarm[358] == 1 && PLC.ReadAnalogIn[39] != 0)
            {
                if (SeedRotMotorFlag == false)
                {
                    DbRecord(string.Format("晶转电机故障,状态码0x{0:X}", PLC.ReadAnalogIn[39]));
                    SeedRotMotorFlag = true;
                }
            }
            else
            {
                SeedRotMotorFlag = false;
            }
            if (PLC.StatusAlarm[359] == 1 && PLC.ReadAnalogIn[40] != 0)
            {
                if (ShieldMMotorFlag == false)
                {
                    DbRecord(string.Format("热屏主电机故障,状态码0x{0:X}", PLC.ReadAnalogIn[40]));
                    ShieldMMotorFlag = true;
                }
            }
            else
            {
                ShieldMMotorFlag = false;
            }
            if (PLC.StatusAlarm[468] == 1 && PLC.ReadAnalogIn[41] != 0)
            {
                if (ShieldSMotorFlag == false)
                {
                    DbRecord(string.Format("热屏从电机故障,状态码0x{0:X}", PLC.ReadAnalogIn[41]));
                    ShieldSMotorFlag = true;
                }
            }
            else
            {
                ShieldSMotorFlag = false;
            }
            if (PLC.StatusAlarm[464] == 1)
            {
                if (SmartFlag == false)
                {
                    DbRecord("网络站12 - Smart200编码器通讯故障！");
                    SmartFlag = true;
                }
            }
            else
            {
                SmartFlag = false;
            }
        }
        private static void DbRecord(string msg)
        {
            try
            {
                SqliteHelper.InsertData(string.Format("INSERT INTO HistoricalAlarm (DATE_TIME,INFO)VALUES('{0}','{1}')", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), msg));
                SqliteHelper.InsertData("DELETE FROM HistoricalAlarm WHERE DATE('NOW', '-20 DAY') >= DATE(DATE_TIME)");
                SqliteErr2Flag = false;
            }
            catch
            {
                SqliteErr2Flag = true;
            }
            Append(string.Concat(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), ":", msg));
        }
        private static void Append(string str)
        {
            if (!Directory.Exists("D:\\LICCS_ALARM"))
            {
                Directory.CreateDirectory("D:\\LICCS_ALARM");
            }
            if (File.Exists(FileHelper.RecordAlarm))
            {
                using (FileStream fStream = new FileStream(FileHelper.RecordAlarm, FileMode.Append, FileAccess.Write))
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
                using (FileStream fStream = new FileStream(FileHelper.RecordAlarm, FileMode.Create, FileAccess.Write))
                {
                    using (StreamWriter SWriter = new StreamWriter(fStream, Encoding.UTF8))
                    {
                        SWriter.WriteLine(str);
                        SWriter.Flush();
                    }
                }
            }
        }
        public static void Clear()
        {
            using (FileStream fStream = new FileStream(FileHelper.RecordAlarm, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter SWriter = new StreamWriter(fStream, Encoding.UTF8))
                {
                    SWriter.Flush();
                }
            }
        }
    }
}
