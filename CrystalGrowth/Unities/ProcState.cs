using CrystalGrowth.AuxFunction.CCD;
using CrystalGrowth.CrystalCtl;
using System;

namespace CrystalGrowth.Unities
{
    internal static class ProcState
    {
        static string LastValue1 = "100.0";
        static float ShoulderDiaVal = 0;
        static bool MeltGapSafeStatusFlag = false;
        public static bool UpStatusFlag = false;
        public static bool DownStatusFlag = false;
        public static bool FeedManualFlag = false;
        public static bool BodyPower500Flag = false;
        public static bool BodyPower1000Flag = false;
        public static bool BodyPower1500Flag = false;
        public static bool MeltPixelFlag = false;
        public static bool MeltPixelWFlag = false;


        public static event Action LoadWeightEvent;
        public static string CurrentState(string str)
        {
            switch (str)
            {
                case "0.0":     //Manual
                    return "手动";
                case "1.0":     //Start Auto Growth
                    return "开始自动生长";
                case "2.0":      //PumpDown  
                    return "抽空";
                case "3.0":     //LeakBack
                    return "检漏";
                case "4.0":     //Pressurization
                    return "压力化";
                case "5.0":     //Melting
                    return "熔料";
                case "8.0":     //StabilizationII,Dip
                    return "预热/熔接";
                case "9.0":     //Dip
                    return "调温";
                case "10.0":    // Neck Growth
                    return "引晶";
                case "11.0":    //Crown Growth
                    return "放肩";
                case "12.0":    //Shoulder Growth
                    return "转肩";
                case "13.0":    //Body Growth
                    return "等径";
                case "14.0":    //Tail Growth
                    return "取段收尾";
                case "14.1":    //Tail Growth
                    return "完结收尾";
                case "15.0":    //Fast Tail Growth
                    return "快速收尾";
                case "16.0":    //Shutdown
                    return "停炉";
                case "17.0":    //Isolation
                    return "隔离";
                case "18.0":    //Purge
                    return "副室净化";
                case "19.0":    //Bakeout
                    return "煅烧";
                case "20.0":    //Crystal Cold Pull Out
                    return "取段冷却加料";
                case "20.1":    //Crystal Cold Pull Out
                    return "取段冷却调温";
                case "20.2":    //Crystal Cold Pull Out
                    return "取段冷却结晶";
                case "21.0":    //Cover Pull Out
                    return "渣盖提出";
                case "22.0":    //Tube Pull In
                    return "料筒提入";
                case "23.0":    //Tube Pull Out
                    return "料筒提出";
                case "24.0":    //Charing
                    return "开始加料";
                case "25.0":    //Charing
                    return "籽晶提入";
                case "26.0":    //Charing
                    return "炉盖旋回";
                case "27.0":    //Charing
                    return "炉盖旋开";
                case "28.0":     //Charing
                    return "炉筒旋回";
                case "29.0":    //Charing
                    return "炉筒旋开";
                case "30.0":    //Emergency Safe Protect
                    return "紧急安全保护";
                case "31.0":    //Charing
                    return "自动装料";
                case "32.0":    //ReMelting
                    return "回熔";
                case "33.0":    //One Key Set Cru
                    return "一键放埚";
                case "34.0":  //Silicon Preheat
                    return "硅料预热";
                case "35.0":  //Silicon Preheat
                    return "自动拆炉";
                default:
                    return "";
            }
        }
        public static float CurrentStateNum(string str)
        {
            switch (str)
            {
                case "手动":     //Manual
                    return 0.0f;
                case "开始自动生长":     //Start Auto Growth
                    return 1.0f;
                case "抽空":      //PumpDown  
                    return 2.0f;
                case "检漏":     //LeakBack
                    return 3.0f;
                case "压力化":     //Pressurization
                    return 4.0f;
                case "熔料":     //Melting
                    return 5.0f;
                case "预热/熔接":     //StabilizationII,Dip
                    return 8.0f;
                case "调温":     //Dip
                    return 9.0f;
                case "引晶":    // Neck Growth
                    return 10.0f;
                case "放肩":    //Crown Growth
                    return 11.0f;
                case "转肩":    //Shoulder Growth
                    return 12.0f;
                case "等径":    //Body Growth
                    return 13.0f;
                case "循环收尾":    //Tail Growth
                    return 14.0f;
                case "完结收尾":    //Tail Growth
                    return 14.1f;
                case "快速收尾":    //Fast Tail Growth
                    return 15.0f;
                case "停炉":    //Shutdown
                    return 16.0f;
                case "隔离":    //Isolation
                    return 17.0f;
                case "副室净化":    //Purge
                    return 18.0f;
                case "煅烧":    //Bakeout
                    return 19.0f;
                case "取段冷却加料":    //Crystal Cold Pull Out
                    return 20.0f;
                case "取段冷却调温":    //Crystal Cold Pull Out
                    return 20.1f;
                case "取段冷却结晶":    //Crystal Cold Pull Out
                    return 20.2f;
                case "渣盖提出":    //Cover Pull Out
                    return 21.0f;
                case "粘渣准备":    //Cover Pull Out
                    return 21.1f;
                case "料筒提入":    //Tube Pull In
                    return 22.0f;
                case "料筒提出":    //Tube Pull Out
                    return 23.0f;
                case "开始加料":    //Charing
                    return 24.0f;
                case "二次加料":    //Charing
                    return 24.1f;
                case "籽晶提入":    //Charing
                    return 25.0f;
                case "籽晶提出":    //Charing
                    return 25.1f;
                case "炉盖旋回":    //Charing
                    return 26.0f;
                case "炉盖旋开":    //Charing
                    return 27.0f;
                case "炉筒旋回":     //Charing
                    return 28.0f;
                case "炉筒旋开":    //Charing
                    return 29.0f;
                case "紧急安全保护":    //Emergency Safe Protect
                    return 30.0f;
                case "自动装料":    //Charing
                    return 31.0f;
                case "回熔":    //ReMelting
                    return 32.0f;
                case "一键放埚":    //One Key Set Cru
                    return 33.0f;
                case "硅料预热":  //Silicon Preheat
                    return 34.0f;
                case "自动拆炉":  //自动拆炉
                    return 35.0f;
                default:
                    return -1;
            }
        }
        public static void ChangeRecord()
        {
            string strTemp = Math.Round(PLC.ReadValue[1], 1).ToString("f1");
            if (LastValue1 != strTemp)
            {
                OnceRecord(); //记录上一次结束数据    
                RecordData();//记录改变状态
                LastValue1 = strTemp;
            }
            BodyPowerRecord();
            ExpGrowthRecord();
            MeltPixelRecord();
        }
        private static void BodyPowerRecord()
        {
            if (PLC.ReadValue[1] == 11 && Math.Round(PLC.ReadValue[7], 2) > 0)
            {
                ShoulderDiaVal = (float)Math.Round(PLC.ReadValue[7], 2);
            }
            float BodyLenght = PLC.ReadCalcValue[14];
            if (PLC.ReadValue[1] == 13)
            {
                if (BodyPower500Flag == false && BodyLenght >= 500 && BodyLenght < 1000)
                {
                    FrmMeltTemp.BodyPower500 = Math.Round(PLC.PowerValue[3], 2).ToString("f2");
                    BodyPower500Flag = true;
                }
                else if (BodyPower1000Flag == false && BodyLenght >= 1000 && BodyLenght < 1500)
                {
                    FrmMeltTemp.BodyPower1000 = Math.Round(PLC.PowerValue[3], 2).ToString("f2");
                    BodyPower1000Flag = true;
                }
                else if (BodyPower1500Flag == false && BodyLenght >= 1500)
                {
                    FrmMeltTemp.BodyPower1500 = Math.Round(PLC.PowerValue[3], 2).ToString("f2");
                    BodyPower1500Flag = true;
                }
            }
            else
            {
                BodyPower500Flag = false;
                BodyPower1000Flag = false;
                BodyPower1500Flag = false;
            }
        }
        private static void OnceRecord()
        {
            switch (LastValue1)
            {
                case "0.0"://Manual
                    break;
                case "2.0"://PumpDown
                    Record.WriteIn("   主室低压力(mtorr)", Math.Round(PLC.ReadAnalogValue[4], 1).ToString("f1"), "White");
                    break;
                case "3.0"://LeakBack
                    Record.WriteIn("   泄漏率(mtorr/hr)", Math.Round(PLC.ReadCalcValue[17], 1).ToString("f1"), "White");
                    Record.WriteIn("   主室低压力(mtorr)", Math.Round(PLC.ReadAnalogValue[4], 1).ToString("f1"), "White");
                    break;
                case "4.0": //Pressurization
                case "5.0"://Melting
                    break;
                case "8.0": //StabilizationII/Dip
                case "9.0":  //Dip
                    Record.WriteIn("   液面温度(degC)", Math.Round(PLC.ReadValue[32], 1).ToString("f1"), "White");
                    if (PLC.ReadStatus[57] == 0)
                    {
                        Record.WriteIn("   热场温度(units)", Math.Round(PLC.ReadValue[12], 1).ToString("f1"), "White");
                    }
                    Record.WriteIn("   晶体位置(mm)", Math.Round(PLC.ReadAnalogValue[35], 1).ToString("f1"), "White");
                    Record.WriteIn("   坩埚位置(mm)", Math.Round(PLC.ReadValue[59], 1).ToString("f1"), "White");
                    Record.WriteIn("   视觉液口距(mm)", Math.Round(PLC.ReadCalcValue[24], 1).ToString("f1"), "White");
                    Record.WriteIn("   视觉液口距像素值(pixel)", Math.Round(IgAlgo1.PixelMiddleMeltGap, 1).ToString("f1"), "White");
                    Record.WriteIn("   视觉液调整系数", Math.Round(PLC.ReadOthersValue[19], 2).ToString("f2"), "White");
                    Record.WriteIn("   直径像素值(pixel)", Math.Round(IgAlgo1.PixelDiameter, 1).ToString("f1"), "White");
                    Record.WriteIn("   主加热器功率(KW)", Math.Round(PLC.ReadValue[72], 2).ToString("f2"), "White");
                    Record.WriteIn("   籽晶转速(rpm)", Math.Round(PLC.ReadValue[51], 1).ToString("f1"), "White");
                    Record.WriteIn("   坩埚转速(rpm)", Math.Round(PLC.ReadValue[56], 1).ToString("f1"), "White");
                    Record.WriteIn("   氩气流量(slpm)", Math.Round(PLC.ReadAnalogValue[1], 1).ToString("f1"), "White");
                    Record.WriteIn("   主室压力(torr)", Math.Round(PLC.ReadAnalogValue[5], 1).ToString("f1"), "White");
                    break;
                case "10.0"://Neck Growth
                    Record.WriteIn("   主加热器功率(KW)", Math.Round(PLC.ReadValue[72], 2).ToString("f2"), "White");
                    if (PLC.ReadStatus[57] == 0)
                    {
                        Record.WriteIn("   热场温度设定(units)", Math.Round(PLC.ReadValue[11], 1).ToString("f1"), "White");
                        Record.WriteIn("   热场温度(units)", Math.Round(PLC.ReadValue[12], 1).ToString("f1"), "White");
                    }
                    Record.WriteIn("   生长速度(mm/hr)", Math.Round(PLC.ReadValue[16], 1).ToString("f1"), "White");
                    Record.WriteIn("   引晶长度(mm)", Math.Round(PLC.ReadValue[81], 1).ToString("f1"), "White");
                    Record.WriteIn("   剩余重量(kg)", Math.Round(PLC.ReadCalcValue[10], 2).ToString("f2"), "White");
                    Record.WriteIn("   液面温度(degC)", Math.Round(PLC.ReadValue[32], 1).ToString("f1"), "White");
                    Record.WriteIn("   晶体位置(mm)", Math.Round(PLC.ReadAnalogValue[35], 1).ToString("f1"), "White");
                    Record.WriteIn("   坩埚位置(mm)", Math.Round(PLC.ReadValue[59], 1).ToString("f1"), "White");
                    Record.WriteIn("   视觉液口距(mm)", Math.Round(PLC.ReadCalcValue[24], 1).ToString("f1"), "White");
                    Record.WriteIn("   视觉液口距像素值(pixel)", Math.Round(IgAlgo1.PixelMiddleMeltGap, 1).ToString("f1"), "White");
                    Record.WriteIn("   视觉液调整系数", Math.Round(PLC.ReadOthersValue[19], 2).ToString("f2"), "White");
                    Record.WriteIn("   直径像素值(pixel)", Math.Round(IgAlgo1.PixelDiameter, 1).ToString("f1"), "White");
                    Record.WriteIn("   细晶后60mm平均拉速(mm/hr)", Math.Round(PLC.ReadAnalogValue[45], 1).ToString("f1"), "White");
                    Record.WriteIn("   细晶整段平均拉速(mm/hr)", Math.Round(PLC.ReadValue[107], 1).ToString("f1"), "White");
                    //液面温度页面显示值存储
                    FrmMeltTemp.CalcParas();
                    break;
                case "11.0": //Crown Growth
                    Record.WriteIn("   主加热器功率(KW)", Math.Round(PLC.ReadValue[23], 2).ToString("f2"), "White");
                    if (PLC.ReadStatus[57] == 0)
                    {
                        Record.WriteIn("   热场温度设定(units)", Math.Round(PLC.ReadValue[11], 1).ToString("f1"), "White");
                        Record.WriteIn("   热场温度(units)", Math.Round(PLC.ReadValue[12], 1).ToString("f1"), "White");
                    }
                    Record.WriteIn("   肩部重量(kg)", Math.Round(PLC.ReadCalcValue[18], 2).ToString("f2"), "White");
                    Record.WriteIn("   剩余重量(kg)", Math.Round(PLC.ReadCalcValue[10], 2).ToString("f2"), "White");
                    Record.WriteIn("   放肩角度(degree)", Math.Round(PLC.ReadCalcValue[21], 1).ToString("f1"), "White");
                    Record.WriteIn("   放肩长度(mm)", Math.Round(PLC.ReadValue[81], 1).ToString("f1"), "White");
                    Record.WriteIn("   晶体位置(mm)", Math.Round(PLC.ReadAnalogValue[35], 1).ToString("f1"), "White");
                    Record.WriteIn("   坩埚位置(mm)", Math.Round(PLC.ReadValue[59], 1).ToString("f1"), "White");
                    Record.WriteIn("   视觉液口距(mm)", Math.Round(PLC.ReadCalcValue[24], 1).ToString("f1"), "White");
                    Record.WriteIn("   视觉液口距像素值(pixel)", Math.Round(IgAlgo1.PixelMiddleMeltGap, 1).ToString("f1"), "White");
                    Record.WriteIn("   视觉液调整系数", Math.Round(PLC.ReadOthersValue[19], 2).ToString("f2"), "White");
                    Record.WriteIn("   生长速度(mm/hr)", Math.Round(PLC.ReadValue[16], 1).ToString("f1"), "White");
                    Record.WriteIn("   实际直径(mm)", Math.Round(ShoulderDiaVal, 2).ToString("f2"), "White");
                    Record.WriteIn("   直径像素值(pixel)", Math.Round(IgAlgo1.PixelDiameter, 1).ToString("f1"), "White");
                    Record.WriteIn("   直径变化率(mm/min)", Math.Round(PLC.ReadValue[123], 1).ToString("f1"), "White");
                    break;
                case "12.0": //Shoulder Growth
                    Record.WriteIn("   主加热器功率(KW)", Math.Round(PLC.ReadValue[72], 2).ToString("f2"), "White");
                    if (PLC.ReadStatus[57] == 0)
                    {
                        Record.WriteIn("   热场温度设定(units)", Math.Round(PLC.ReadValue[11], 1).ToString("f1"), "White");
                        Record.WriteIn("   热场温度(units)", Math.Round(PLC.ReadValue[12], 1).ToString("f1"), "White");
                    }
                    Record.WriteIn("   晶体重量(kg)", Math.Round(PLC.ReadCalcValue[8], 2).ToString("f2"), "White");
                    Record.WriteIn("   剩余重量(kg)", Math.Round(PLC.ReadCalcValue[10], 2).ToString("f2"), "White");
                    Record.WriteIn("   转肩长度(mm)", Math.Round(PLC.ReadValue[81], 1).ToString("f1"), "White");
                    Record.WriteIn("   晶体位置(mm)", Math.Round(PLC.ReadAnalogValue[35], 1).ToString("f1"), "White");
                    Record.WriteIn("   坩埚位置(mm)", Math.Round(PLC.ReadValue[59], 1).ToString("f1"), "White");
                    Record.WriteIn("   视觉液口距(mm)", Math.Round(PLC.ReadCalcValue[24], 1).ToString("f1"), "White");
                    Record.WriteIn("   视觉液口距像素值(pixel)", Math.Round(IgAlgo1.PixelMiddleMeltGap, 1).ToString("f1"), "White");
                    Record.WriteIn("   视觉液调整系数", Math.Round(PLC.ReadOthersValue[19], 2).ToString("f2"), "White");
                    Record.WriteIn("   实际直径(mm)", Math.Round(PLC.ReadValue[7], 2).ToString("f2"), "White");
                    Record.WriteIn("   直径像素值(pixel)", Math.Round(IgAlgo1.PixelDiameter, 1).ToString("f1"), "White");
                    FrmMeltTemp.BodyPowerStart = Math.Round(PLC.ReadValue[72], 2).ToString("f2");
                    break;
                case "13.0"://Body Growth
                    Record.WriteIn("   等径长度(mm)", Math.Round(PLC.ReadValue[81], 1).ToString("f1"), "White");
                    Record.WriteIn("   等径多段长度(mm)", Math.Round(PLC.ReadCalcValue[22], 1).ToString("f1"), "White");
                    Record.WriteIn("   等径总长度(mm)", Math.Round(PLC.ReadCalcValue[13], 1).ToString("f1"), "White");
                    //Record.WriteIn("   等径重量(kg)", Math.Round(PLC.ReadCalcValue[19], 2).ToString("f2"), "White");
                    Record.WriteIn("   剩余重量(kg)", Math.Round(PLC.ReadCalcValue[10], 2).ToString("f2"), "White");
                    Record.WriteIn("   晶体位置(mm)", Math.Round(PLC.ReadAnalogValue[35], 1).ToString("f1"), "White");
                    Record.WriteIn("   坩埚位置(mm)", Math.Round(PLC.ReadValue[59], 1).ToString("f1"), "White");
                    Record.WriteIn("   视觉液口距(mm)", Math.Round(PLC.ReadCalcValue[24], 1).ToString("f1"), "White");
                    Record.WriteIn("   视觉液口距像素值(pixel)", Math.Round(IgAlgo1.PixelMiddleMeltGap, 1).ToString("f1"), "White");
                    Record.WriteIn("   视觉液调整系数", Math.Round(PLC.ReadOthersValue[19], 2).ToString("f2"), "White");
                    Record.WriteIn("   直径像素值(pixel)", Math.Round(IgAlgo1.PixelDiameter, 1).ToString("f1"), "White");
                    Record.WriteIn("   主加热器功率(KW)", Math.Round(PLC.ReadValue[72], 2).ToString("f2"), "White");
                    if (PLC.ReadStatus[57] == 0)
                    {
                        Record.WriteIn("   热场温度设定(units)", Math.Round(PLC.ReadValue[11], 1).ToString("f1"), "White");
                        Record.WriteIn("   热场温度(units)", Math.Round(PLC.ReadValue[12], 1).ToString("f1"), "White");
                    }
                    Record.WriteIn("   生长速度(mm/hr)", Math.Round(PLC.ReadValue[16], 1).ToString("f1"), "White");
                    Record.WriteIn("   等径整段平均拉速(mm/hr)", Math.Round(PLC.ReadCalcValue[23], 1).ToString("f1"), "White");
                    //液面温度页面显示值存储
                    FrmMeltTemp.BodyLength = Math.Round(PLC.ReadValue[81], 1).ToString("f1");
                    FrmMeltTemp.BodyMeltGap = Math.Round(PLC.ReadCalcValue[24], 1).ToString("f1");
                    FrmMeltTemp.Dispaly();
                    FrmMeltTemp.BodyPower500 = "0";
                    FrmMeltTemp.BodyPower1000 = "0";
                    FrmMeltTemp.BodyPower1500 = "0";
                    break;
                case "14.0": //段收尾
                    Record.WriteIn("   晶体重量(kg)", Math.Round(PLC.ReadCalcValue[8], 2).ToString("f2"), "White");
                    Record.WriteIn("   剩余重量(kg)", Math.Round(PLC.ReadCalcValue[10], 2).ToString("f2"), "White");
                    Record.WriteIn("   尾部重量(kg)", Math.Round(PLC.ReadCalcValue[27], 2).ToString("f2"), "White");
                    Record.WriteIn("   收尾长度(mm)", Math.Round(PLC.ReadValue[81], 1).ToString("f1"), "White");
                    Record.WriteIn("   主加热器功率(KW)", Math.Round(PLC.ReadValue[72], 2).ToString("f2"), "White");
                    if (PLC.ReadStatus[57] == 0)
                    {
                        Record.WriteIn("   热场温度设定(units)", Math.Round(PLC.ReadValue[11], 1).ToString("f1"), "White");
                        Record.WriteIn("   热场温度(units)", Math.Round(PLC.ReadValue[12], 1).ToString("f1"), "White");
                    }
                    Record.WriteIn("   晶体位置(mm)", Math.Round(PLC.ReadAnalogValue[35], 1).ToString("f1"), "White");
                    Record.WriteIn("   坩埚位置(mm)", Math.Round(PLC.ReadValue[59], 1).ToString("f1"), "White");
                    break;
                case "14.1":  //完结段收尾
                    Record.WriteIn("   晶体重量(kg)", Math.Round(PLC.ReadCalcValue[8], 2).ToString("f2"), "White");
                    Record.WriteIn("   剩余重量(kg)", Math.Round(PLC.ReadCalcValue[10], 2).ToString("f2"), "White");
                    Record.WriteIn("   尾部重量(kg)", Math.Round(PLC.ReadCalcValue[27], 2).ToString("f2"), "White");
                    Record.WriteIn("   收尾长度(mm)", Math.Round(PLC.ReadValue[81], 1).ToString("f1"), "White");
                    Record.WriteIn("   主加热器功率(KW)", Math.Round(PLC.ReadValue[72], 2).ToString("f2"), "White");
                    if (PLC.ReadStatus[57] == 0)
                    {
                        Record.WriteIn("   热场温度设定(units)", Math.Round(PLC.ReadValue[11], 1).ToString("f1"), "White");
                        Record.WriteIn("   热场温度(units)", Math.Round(PLC.ReadValue[12], 1).ToString("f1"), "White");
                    }
                    Record.WriteIn("   晶体位置(mm)", Math.Round(PLC.ReadAnalogValue[35], 1).ToString("f1"), "White");
                    Record.WriteIn("   坩埚位置(mm)", Math.Round(PLC.ReadValue[59], 1).ToString("f1"), "White");
                    break;
                case "15.0": //Fast Tail Growth
                    Record.WriteIn("   晶体重量(kg)", Math.Round(PLC.ReadCalcValue[8], 2).ToString("f2"), "White");
                    Record.WriteIn("   剩余重量(kg)", Math.Round(PLC.ReadCalcValue[10], 2).ToString("f2"), "White");
                    Record.WriteIn("   主加热器功率(KW)", Math.Round(PLC.ReadValue[72], 2).ToString("f2"), "White");
                    if (PLC.ReadStatus[57] == 0)
                    {
                        Record.WriteIn("   热场温度设定(units)", Math.Round(PLC.ReadValue[11], 1).ToString("f1"), "White");
                        Record.WriteIn("   热场温度(units)", Math.Round(PLC.ReadValue[12], 1).ToString("f1"), "White");
                    }
                    Record.WriteIn("   晶体位置(mm)", Math.Round(PLC.ReadAnalogValue[35], 1).ToString("f1"), "White");
                    Record.WriteIn("   坩埚位置(mm)", Math.Round(PLC.ReadValue[59], 1).ToString("f1"), "White");
                    break;
                case "16.0"://Shutdown
                    Record.WriteIn("   泄漏率(mtorr/hr)", Math.Round(PLC.ReadCalcValue[17], 1).ToString("f1"), "White");
                    Record.WriteIn("   主室低压力(mtorr)", Math.Round(PLC.ReadAnalogValue[4], 1).ToString("f1"), "White");
                    Record.WriteIn("   晶体重量(kg)", Math.Round(PLC.ReadCalcValue[8], 2).ToString("f2"), "White");
                    Record.WriteIn("   剩余重量(kg)", Math.Round(PLC.ReadCalcValue[10], 2).ToString("f2"), "White");
                    Record.WriteIn("   总加热功耗(MWh)", Math.Round(PLC.ReadCalibValue[32], 3).ToString("f3"), "White");
                    Record.WriteIn("   总氩气消耗(m³)", Math.Round(PLC.ReadCalibValue[34], 3).ToString("f3"), "White");
                    break;
                case "17.0"://Isolation
                case "18.0"://Purge
                    Record.WriteIn("   主室压力(torr)", Math.Round(PLC.ReadAnalogValue[5], 1).ToString("f1"), "White");
                    Record.WriteIn("   副室压力(torr)", Math.Round(PLC.ReadAnalogValue[7], 1).ToString("f1"), "White");
                    if (PLC.ReadStatusOut[14] == 1)
                    {
                        Record.WriteIn("   上氩气阀", "ON", "White");
                    }
                    else
                    {
                        Record.WriteIn("   上氩气阀", "OFF", "White");
                    }
                    if (PLC.ReadStatusOut[13] == 1)
                    {
                        Record.WriteIn("   下氩气阀", "ON", "White");
                    }
                    else
                    {
                        Record.WriteIn("   下氩气阀", "OFF", "White");
                    }
                    if (PLC.ReadStatusOut[19] == 1)
                    {
                        Record.WriteIn("   快充阀", "ON", "White");
                    }
                    else
                    {
                        Record.WriteIn("   快充阀", "OFF", "White");
                    }
                    break;
                case "19.0":  //Bakeout
                case "20.0"://取段加料
                case "20.1":// 取段调温
                case "20.2":// 取段结晶
                case "21.0": //Cover Pull Out
                case "22.0"://Tube Pull In
                case "23.0": //Tube Pull Out
                case "24.0"://Charing
                case "25.0":
                case "26.0":
                case "27.0":
                case "28.0":
                case "29.0":
                case "30.0": //Emergency Safe Protect
                case "31.0":
                case "32.0":
                case "33.0":
                case "34.0":
                case "35.0":
                    break;
            }
            Record.WriteIn("   当前炉次功耗(MWh)", Math.Round(PLC.ReadCalibValue[51], 2).ToString("f2"), "White");
            Record.WriteIn("   当前炉次氩气消耗(立方米)", Math.Round(PLC.ReadCalibValue[52], 2).ToString("f2"), "White");
            Record.WriteIn("   运行时间", PLC.ReadValue[80].TimeToStr(), "White");
            Record.WriteIn("   总运行时间", PLC.ReadValue[71].TimeToStr(), "White");
        }
        private static void RecordData()
        {
            string StateStr = Math.Round(PLC.ReadValue[1], 1).ToString("f1");
            switch (StateStr)
            {
                case "0.0"://Manual
                    Record.WriteIn("手动", "", "White");
                    break;
                case "1.0": //Start Auto Grow
                    Record.WriteIn("开始自动生长", "", "White");
                    Alarm.Clear();
                    break;
                case "2.0"://PumpDown
                    float[] InitSetVal = new float[4];
                    if (LastValue1 == "1.0")
                    {
                        Record.Clear();
                        PLC.RecvFloat(40, 0, 3, ref InitSetVal);
                        Record.WriteIn("开始自动生长", "", "White");
                        Record.WriteIn("   晶向", Math.Round(InitSetVal[1], 0).ToString(), "White");
                        Record.WriteIn("   初始加料重量(kg)", Math.Round(PLC.ReadCalcValue[7], 2).ToString("f2"), "White");
                        Record.WriteIn("   距加热器口初始液面位置(mm)", Math.Round(InitSetVal[3], 1).ToString("f1"), "White");
                        Record.WriteIn("   员工编号", Math.Round(PLC.ReadValue[69], 0).ToString(), "White");
                    }
                    Record.WriteIn("抽空", "", "White");
                    break;
                case "3.0": //LeakBack
                    Record.WriteIn("检漏", "", "White");
                    Record.WriteIn("   主室低压力(mtorr)", Math.Round(PLC.ReadAnalogValue[4], 1).ToString("f1"), "White");
                    break;
                case "4.0"://Pressurization
                    Record.WriteIn("压力化", "", "White");
                    Record.WriteIn("   主室压力(torr)", Math.Round(PLC.ReadAnalogValue[5], 1).ToString("f1"), "White");
                    Record.WriteIn("   副室压力(torr)", Math.Round(PLC.ReadAnalogValue[7], 1).ToString("f1"), "White");
                    break;
                case "5.0"://Melting
                    Record.WriteIn("熔料", "", "White");
                    Record.WriteIn("   坩埚位置(mm)", Math.Round(PLC.ReadValue[59], 1).ToString("f1"), "White");
                    Record.WriteIn("   主室压力(torr)", Math.Round(PLC.ReadAnalogValue[5], 1).ToString("f1"), "White");
                    Record.WriteIn("   副室压力(torr)", Math.Round(PLC.ReadAnalogValue[7], 1).ToString("f1"), "White");
                    break;
                case "8.0"://Dip
                    Record.WriteIn("预热/熔接", "", "White");
                    Record.WriteIn("   液面温度(degC)", Math.Round(PLC.ReadValue[32], 1).ToString("f1"), "White");
                    if (PLC.ReadStatus[57] == 0)
                    {
                        Record.WriteIn("   热场温度(units)", Math.Round(PLC.ReadValue[12], 1).ToString("f1"), "White");
                    }
                    Record.WriteIn("   主加热器功率(KW)", Math.Round(PLC.ReadValue[72], 2).ToString("f2"), "White");
                    Feed feed = new Feed();
                    feed.WriteIn();
                    FrmShieldMeasure.CheckPos();//检测导流筒
                    LoadWeightEvent();
                    break;
                case "9.0": //Stabilization
                    Record.WriteIn("调温", "", "White");
                    Record.WriteIn("   液面温度(degC)", Math.Round(PLC.ReadValue[32], 1).ToString("f1"), "White");
                    if (PLC.ReadStatus[57] == 0)
                    {
                        Record.WriteIn("   热场温度(units)", Math.Round(PLC.ReadValue[12], 1).ToString("f1"), "White");
                    }
                    Record.WriteIn("   主加热器功率(KW)", Math.Round(PLC.ReadValue[72], 2).ToString("f2"), "White");
                    break;
                case "10.0": //Neck Growth
                    Record.WriteIn("引晶", "", "White");
                    Record.WriteIn("   主加热器功率(KW)", Math.Round(PLC.ReadValue[72], 2).ToString("f2"), "White");
                    if (PLC.ReadStatus[57] == 0)
                    {
                        Record.WriteIn("   热场温度设定(units)", Math.Round(PLC.ReadValue[11], 1).ToString("f1"), "White");
                        Record.WriteIn("   热场温度(units)", Math.Round(PLC.ReadValue[12], 1).ToString("f1"), "White");
                    }
                    Record.WriteIn("   液面温度(degC)", Math.Round(PLC.ReadValue[32], 1).ToString("f1"), "White");
                    Record.WriteIn("   籽晶转速(rpm)", Math.Round(PLC.ReadValue[51], 1).ToString("f1"), "White");
                    Record.WriteIn("   坩埚转速(rpm)", Math.Round(PLC.ReadValue[56], 1).ToString("f1"), "White");
                    Record.WriteIn("   晶体位置(mm)", Math.Round(PLC.ReadAnalogValue[35], 1).ToString("f1"), "White");
                    Record.WriteIn("   坩埚位置(mm)", Math.Round(PLC.ReadValue[59], 1).ToString("f1"), "White");
                    Record.WriteIn("   视觉液口距(mm)", Math.Round(PLC.ReadCalcValue[24], 1).ToString("f1"), "White");
                    Record.WriteIn("   视觉液调整系数", Math.Round(PLC.ReadOthersValue[19], 2).ToString("f2"), "White");
                    Record.WriteIn("   剩余重量(kg)", Math.Round(PLC.ReadCalcValue[10], 2).ToString("f2"), "White");
                    break;
                case "11.0": //Crown Growth
                    Record.WriteIn("放肩", "", "White");
                    break;
                case "12.0"://Shoulder Growth
                    Record.WriteIn("转肩", "", "White");
                    break;
                case "13.0"://Body Growth
                    Record.WriteIn("等径", "", "White");
                    break;
                case "14.0"://Tail Growth
                    Record.WriteIn("取段收尾", "", "White");
                    break;
                case "14.1"://Tail Growth
                    Record.WriteIn("完结收尾", "", "White");
                    break;
                case "15.0": //Fast Tail Growth
                    Record.WriteIn("快速收尾", "", "White");
                    break;
                case "16.0"://Shutdown
                    Record.WriteIn("停炉", "", "White");
                    break;
                case "17.0"://Isolation
                    Record.WriteIn("隔离", "", "White");
                    Record.WriteIn("   主室压力(torr)", Math.Round(PLC.ReadAnalogValue[5], 1).ToString("f1"), "White");
                    Record.WriteIn("   副室压力(torr)", Math.Round(PLC.ReadAnalogValue[7], 1).ToString("f1"), "White");
                    break;
                case "18.0"://Purge
                    Record.WriteIn("副室净化", "", "White");
                    break;
                case "19.0"://Bakeout
                    Record.WriteIn("煅烧", "", "White");
                    break;
                case "20.0"://Crystal Cold Pull Out
                    Record.WriteIn("取段冷却加料", "", "White");
                    break;
                case "20.1":
                    Record.WriteIn("取段冷却调温", "", "White");
                    break;
                case "20.2":
                    Record.WriteIn("取段冷却结晶", "", "White");
                    break;
                case "21.0"://Cover Pull Out
                    Record.WriteIn("渣盖提出", "", "White");
                    //Record.WriteIn("   提出重量", Math.Round(PLC.ReadCalcValue[8], 2).ToString("f2"), "White");
                    break;
                case "22.0"://Tube Pull In
                    Record.WriteIn("料筒提入", "", "White");
                    break;
                case "23.0"://Tube Pull Out
                    Record.WriteIn("料筒提出", "", "White");
                    break;
                case "24.0"://Charing
                    Record.WriteIn("开始加料", "", "White");
                    break;
                case "25.0"://Charing
                    Record.WriteIn("籽晶提入", "", "White");
                    break;
                case "26.0"://in
                    Record.WriteIn("炉盖旋回", "", "White");
                    break;
                case "27.0"://open
                    Record.WriteIn("炉盖旋开", "", "White");
                    break;
                case "28.0"://in
                    Record.WriteIn("炉筒旋回", "", "White");
                    break;
                case "29.0"://open
                    Record.WriteIn("炉筒旋开", "", "White");
                    break;
                case "30.0"://Emergency Safe Protect
                    Record.WriteIn("紧急安全保护", "", "White");
                    break;
                case "31.0"://自动装料
                    Record.WriteIn("自动装料", "", "White");
                    break;
                case "32.0":
                    //回熔
                    Record.WriteIn("回熔", "", "White");
                    break;
                case "33.0"://一键放埚
                    Record.WriteIn("一键放埚", "", "White");
                    break;
                case "34.0":// 硅料预热
                    Record.WriteIn("硅料预热", "", "White");
                    break;
                case "35.0":// 自动拆炉
                    Record.WriteIn("自动拆炉", "", "White");
                    break;
            }
        }
        static bool MainPump_Enable = false, HtrEnable = false, MainPumpFirstLoad = false, HtrFirstLoad = false;
        static bool SLEnable = false, SLFlag = false, CLEnable = false, CLFlag = false;
        static int SLCnt = 30, CLCnt = 30;
        private static void ExpGrowthRecord()
        {
            //seed fast lift record seed position
            if (SLCnt < 30)
            {
                SLCnt++;
            }
            else
            {
                if (SLEnable == false)
                {
                    if (PLC.ReadStatus[14] == 1)
                    {
                        FrmMain.Single.Timer4.Enabled = true;
                        if (PLC.ReadStatusIn[26] == 1 || PLC.ReadStatusIn[28] == 1)
                        {
                            SLFlag = true;
                            Record.WriteIn("   引晶器-晶体位置", Math.Round(PLC.ReadAnalogValue[35], 1).ToString("f1"), "White");
                        }
                        else
                        {
                            SLFlag = false;
                            Record.WriteIn("   晶体位置", Math.Round(PLC.ReadAnalogValue[35], 1).ToString("f1"), "White");
                        }
                        SLEnable = true;
                    }
                }
                else
                {
                    if (PLC.ReadStatus[14] == 0)
                    {
                        FrmMain.Single.Timer4.Enabled = false;
                        UpStatusFlag = false;
                        DownStatusFlag = false;
                        if (SLFlag)
                        {
                            Record.WriteIn("   引晶器-晶体位置", Math.Round(PLC.ReadAnalogValue[35], 1).ToString("f1"), "White");
                        }
                        else
                        {
                            Record.WriteIn("   晶体位置", Math.Round(PLC.ReadAnalogValue[35], 1).ToString("f1"), "White");
                        }
                        SLEnable = false;
                        SLCnt = 0;
                    }
                }
            }
            //crucible fast lift record seed position
            if (CLCnt < 30)
            {
                CLCnt++;
            }
            else
            {
                if (CLEnable == false)
                {
                    if (PLC.ReadStatus[20] == 1)
                    {
                        if (PLC.ReadStatusIn[26] == 1 || PLC.ReadStatusIn[28] == 1)
                        {
                            CLFlag = true;
                            Record.WriteIn("   引晶器-坩埚位置", Math.Round(PLC.ReadAnalogValue[36], 1).ToString("f1"), "White");
                        }
                        else
                        {
                            CLFlag = false;
                            Record.WriteIn("   坩埚位置", Math.Round(PLC.ReadAnalogValue[36], 1).ToString("f1"), "White");
                        }
                        CLEnable = true;
                    }
                }
                else
                {
                    if (PLC.ReadStatus[20] == 0)
                    {
                        if (CLFlag)
                        {
                            Record.WriteIn("   引晶器-坩埚位置", Math.Round(PLC.ReadAnalogValue[36], 1).ToString("f1"), "White");
                        }
                        else
                        {
                            Record.WriteIn("   坩埚位置", Math.Round(PLC.ReadAnalogValue[36], 1).ToString("f1"), "White");
                        }
                        CLEnable = false;
                        CLCnt = 0;
                    }
                }
            }
            //main pump ON/OFF record
            if (MainPump_Enable == false)
            {
                if (PLC.ReadStatusIn[15] == 1)
                {
                    if (MainPumpFirstLoad)
                    {
                        Record.WriteIn("   主真空泵", "ON", "White");
                    }
                    MainPump_Enable = true;
                }
                MainPumpFirstLoad = true;
            }
            else
            {
                if (PLC.ReadStatusIn[15] == 0)
                {
                    Record.WriteIn("   主真空泵", "OFF", "White");
                    MainPump_Enable = false;
                }
            }
            //heater supply ON/OFF record
            if (HtrEnable == false)
            {
                if (PLC.ReadStatusIn[13] == 1)
                {
                    if (HtrFirstLoad)
                    {
                        Record.WriteIn("   加热电源", "ON", "White");
                    }
                    HtrEnable = true;
                }
                HtrFirstLoad = true;
            }
            else
            {
                if (PLC.ReadStatusIn[13] == 0)
                {
                    Record.WriteIn("   加热电源", "OFF", "White");
                    HtrEnable = false;
                }
            }
            if (MeltGapSafeStatusFlag == false)
            {
                if (PLC.ReadStatus[66] == 0)
                {
                    Record.WriteIn("   重量液口距保护", "OFF", "White");
                }
                else
                {
                    Record.WriteIn("   重量液口距保护", "ON", "White");
                }
                if (PLC.ReadStatus[69] == 0)
                {
                    Record.WriteIn("   视觉液口距保护", "OFF", "White");
                }
                else
                {
                    Record.WriteIn("   视觉液口距保护", "ON", "White");
                }
                MeltGapSafeStatusFlag = true;
            }
        }
        public static void TubeInOut()
        {
            if (PLC.ReadStatus[92] == 1)
            {   //TubeIn
                Record.WriteIn("   料筒提入重量", PLC.ReadOthersValue[21].ToString(), "White");
                PLC.SendBit(32, 91, 0);
            }
            if (PLC.ReadStatus[93] == 1)
            {   //TubeOut
                Record.WriteIn("   料筒提出重量", PLC.ReadOthersValue[25].ToString(), "White");
                Record.WriteIn("   净加料量", PLC.ReadOthersValue[26].ToString(), "White");
                FeedCur feedCur = new FeedCur();
                feedCur.ReadOut();
                feedCur.Time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                feedCur.Value = Math.Round(PLC.ReadOthersValue[26], 2).ToString("f2");
                feedCur.WriteIn();
                PLC.SendBit(32, 92, 0);
            }
            if (PLC.ReadStatus[113] == 1)
            {   //TubeOut
                Record.WriteIn("   晶体重量(kg)", PLC.ReadCalcValue[8].ToString("f1"), "White");
                PLC.SendBit(32, 112, 0);
                PLC.ReadStatus[113] = 0;
            }
        }

        private static void MeltPixelRecord()
        {
            if (PLC.ReadValue[1]==11)
            {
                MeltPixelFlag = true;
            }
            float BodyLenght = PLC.ReadCalcValue[14];
            if (PLC.ReadValue[1] == 13 && MeltPixelFlag)
            {
                if(BodyLenght>500)
                {
                    FrmMeltTemp.BodyMeltPixel = IgAlgo1.PixelMiddleMeltGap.ToString("f1");
                    MeltPixelFlag = false;
                }
            }
        }
    }
}