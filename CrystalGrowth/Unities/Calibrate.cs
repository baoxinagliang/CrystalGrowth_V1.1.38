using System;
using System.IO;
using System.Text;

namespace CrystalGrowth.Unities
{
    /// <summary>
    /// 校准
    /// </summary>
    internal static class Calibrate
    {
        public static string DateTimeStr = "";
        private static bool ReadGainFlag = false;
        public static float[] Value = new float[51];
        private static readonly string[] Name = new string[51];
        private static readonly string[] Time = new string[51];
        public static void ReadOut()
        {
            string[] Lines = File.ReadAllLines(FileHelper.CalibrationPath, Encoding.UTF8);
            int Length = Lines.Length;
            string[] TempVar;
            int ii;
            char[] SplitChar = new char[] { '=' };
            if (Length > 0)
            {
                for (int i = 0; i < Length; i++)
                {
                    ii = i + 1;
                    TempVar = Lines[i].Split(SplitChar);
                    if (TempVar.Length == 2)
                    {
                        Name[ii] = TempVar[0];
                        Value[ii] = Convert.ToSingle(TempVar[1]);
                    }
                }
            }
        }
        public static void FileToPlc()
        {
            //Read Calibration Value
            string[] Lines = File.ReadAllLines(FileHelper.CalibrationPath, Encoding.UTF8);
            int Length = Lines.Length;
            string[] TempVar;
            char[] SplitChar = new char[] { '=' };
            if (Length > 0)
            {
                for (int i = 0; i < Length; i++)
                {
                    TempVar = Lines[i].Split(SplitChar);
                    if (i >= 0 && i <= 12)
                    {
                        PLC.SendFloat(34, i * 4, Convert.ToSingle(TempVar[1]));
                    }
                    else if (i >= 13 && i <= 26)
                    {
                        PLC.SendFloat(34, (i + 2) * 4, Convert.ToSingle(TempVar[1]));
                    }
                    else if (i >= 27 && i <= 42)
                    {
                        PLC.SendFloat(34, (i + 7) * 4, Convert.ToSingle(TempVar[1]));
                    }
                    else if (i == 44)
                    {
                        PLC.SendFloat(34, 292, Convert.ToSingle(TempVar[1]));
                    }
                }
            }
        }
        public static void GetMeltGapGain()
        {
            if (ReadGainFlag == false)
            {
                if (PLC.ReadStatus[79] == 1)
                {
                    ReadGainFlag = true;
                }
            }
            else
            {
                if (PLC.ReadStatus[79] == 0)
                {
                    ReadGainFlag = false;
                    UpdateValue();
                }
            }
        }
        private static void UpdateValue()
        {
            string[] Lines = File.ReadAllLines(FileHelper.CalibrationPath, Encoding.UTF8);
            int Length = Lines.Length;
            string[] TempVar;
            char[] SplitChar = new char[] { '=' };
            if (Length > 0)
            {
                for (int i = 0; i < Length; i++)
                {
                    TempVar = Lines[i].Split(SplitChar);
                    if (TempVar.Length == 2)
                    {
                        Name[i] = TempVar[0];
                        Value[i] = Convert.ToSingle(TempVar[1]);
                    }
                    if (i == 28)
                    {
                        Value[28] = PLC.ReadCalibValue[36];
                    }
                    if (Name[i] != "")
                    {
                        Lines[i] = string.Concat(Name[i], "=", Value[i].ToString());
                    }
                }
            }
            FileHelper.WriteIn(FileHelper.CalibrationPath, Lines);
        }
        public static void WriteValue(int FormNum, int CtlNum, string msg)
        {
            float LastValue = 0;
            ReadOut();//Read Calibration Value           
            ReadTime();//Read Calibration DateTime
            DateTimeStr = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            switch (FormNum)
            {
                case 1:     //Furnace ID
                    if (CtlNum == 1)
                    {
                        IdNum.FurnaceID = msg;
                        IdNum.WriteIn();
                        Time[1] = DateTimeStr;
                        Record.WriteIn("炉号变更", msg, "Yellow");
                    }
                    break;
                case 2:     //Neck Diameter Calibration
                    if (CtlNum == 1)
                    {
                        LastValue = Value[1];
                        Value[1] = Convert.ToSingle(msg) / PLC.ReadOthersValue[1];
                        PLC.SendFloat(34, 0, Value[1]);
                        Time[2] = DateTimeStr;
                        Record.WriteIn("引晶直径校准", string.Format("{0}->{1}", LastValue.ToString("0.00"), Value[1].ToString("0.00")), "Yellow");
                    }
                    if (CtlNum == 2)
                    {
                        LastValue = Value[2];
                        Value[2] = Convert.ToSingle(msg);
                        PLC.SendFloat(34, 4, Value[2]);
                        Time[2] = DateTimeStr;
                        Record.WriteIn("引晶直径校准偏移", string.Format("{0}->{1}", LastValue.ToString("0.00"), msg), "Yellow");
                    }
                    PLC.SendBit(30, 80, 1);
                    break;
                case 3:     //Crown Diameter Calibration
                    if (CtlNum == 1)
                    {
                        LastValue = Value[3];
                        Value[3] = Convert.ToSingle(msg) / PLC.ReadOthersValue[1];
                        PLC.SendFloat(34, 8, Value[3]);
                        Time[3] = DateTimeStr;
                        Record.WriteIn("放肩直径校准", string.Format("{0}->{1}", LastValue.ToString("0.00"), Value[3].ToString("0.00")), "Yellow");
                    }
                    if (CtlNum == 2)
                    {
                        LastValue = Value[4];
                        Value[4] = Convert.ToSingle(msg);
                        PLC.SendFloat(34, 12, Value[4]);
                        Time[3] = DateTimeStr;
                        Record.WriteIn("放肩直径校准偏移", string.Format("{0}->{1}", LastValue.ToString("0.00"), msg), "Yellow");
                    }
                    PLC.SendBit(30, 80, 1);
                    break;
                case 4:     //Body Diameter Calibration
                    if (CtlNum == 1)
                    {
                        LastValue = Value[5];
                        Value[5] = Convert.ToSingle(msg) / PLC.ReadOthersValue[1];
                        PLC.SendFloat(34, 16, Value[5]);
                        Time[4] = DateTimeStr;
                        Record.WriteIn("等径直径校准", string.Format("{0}->{1}", LastValue.ToString("0.00"), Value[5].ToString("0.00")), "Yellow");
                    }
                    if (CtlNum == 2)
                    {
                        LastValue = Value[6];
                        Value[6] = Convert.ToSingle(msg);
                        PLC.SendFloat(34, 20, Value[6]);
                        Time[4] = DateTimeStr;
                        Record.WriteIn("等径直径校准偏移", string.Format("{0}->{1}", LastValue.ToString("0.00"), msg), "Yellow");
                    }
                    PLC.SendBit(30, 80, 1);
                    break;
                case 5:     //Camera Position Calibration
                    if (CtlNum == 1)
                    {
                        LastValue = Value[7];
                        Value[7] = Convert.ToSingle(msg);
                        PLC.SendFloat(34, 24, Value[7]);
                        Time[5] = DateTimeStr;
                        Record.WriteIn("校准摄像头距软轴", string.Format("{0}->{1}", LastValue.ToString("0.0"), msg), "Yellow");
                    }
                    if (CtlNum == 2)
                    {
                        LastValue = Value[8];
                        Value[8] = Convert.ToSingle(msg);
                        PLC.SendFloat(34, 28, Value[8]);
                        Time[5] = DateTimeStr;
                        Record.WriteIn("校准摄像头距加热器", string.Format("{0}->{1}", LastValue.ToString("0.0"), msg), "Yellow");
                    }
                    break;
                case 6:     //Seed Travel Calibration
                    if (CtlNum == 1)
                    {
                        Value[9] = 0.0f;
                        PLC.SendBit(30, 106, 1);
                        Time[6] = DateTimeStr;
                        Record.WriteIn("籽晶位置校准设零位", "0.0", "Yellow");
                    }
                    if (CtlNum == 2)
                    {
                        LastValue = Value[10];
                        Value[10] = Convert.ToSingle(msg) / (PLC.ReadAnalogValue[33] - PLC.ReadCalibValue[9]);
                        PLC.SendFloat(34, 36, Value[10]);
                        Time[6] = DateTimeStr;
                        Record.WriteIn("籽晶位置校准标定", string.Format("{0}->{1}", LastValue.ToString("0.0"), Value[10].ToString("0.0")), "Yellow");
                    }
                    break;
                case 7:     //Seed Travel Limit Calibration
                    if (CtlNum == 1)
                    {
                        LastValue = Value[11];
                        Value[11] = Convert.ToSingle(msg);
                        PLC.SendFloat(34, 40, Value[11]);
                        Time[7] = DateTimeStr;
                        Record.WriteIn("籽晶上限位校准", string.Format("{0}->{1}", LastValue.ToString("0.0"), msg), "Yellow");
                    }
                    if (CtlNum == 2)
                    {
                        LastValue = Value[12];
                        Value[12] = Convert.ToSingle(msg);
                        PLC.SendFloat(34, 44, Value[12]);
                        Time[7] = DateTimeStr;
                        Record.WriteIn("籽晶下限位校准", string.Format("{0}->{1}", LastValue.ToString("0.0"), msg), "Yellow");
                    }
                    break;
                case 9:     //Crystal Weight Calibration
                    if (CtlNum == 1)
                    {
                        Value[14] = PLC.ReadAnalogValue[40];
                        PLC.SendFloat(34, 60, Value[14]);
                        Time[9] = DateTimeStr;
                        Record.WriteIn("称重校准设零位", "0.0", "Yellow");
                    }
                    if (CtlNum == 2)
                    {
                        LastValue = Value[15];
                        Value[15] = Convert.ToSingle(msg) / (PLC.ReadAnalogValue[40] - PLC.ReadCalibValue[16]);
                        PLC.SendFloat(34, 64, Value[15]);
                        Time[9] = DateTimeStr;
                        Record.WriteIn("称重校准增益标定", string.Format("{0}->{1}", LastValue.ToString("0.0"), Value[15].ToString("0.0")), "Yellow");
                    }
                    break;
                case 10:     //Weight Tune Calibration
                    if (CtlNum == 1)
                    {
                        PLC.SendFloat(35, 36, PLC.ReadCalcValue[10] + Convert.ToSingle(msg));
                        PLC.SendFloat(35, 40, PLC.ReadCalcValue[11] + Convert.ToSingle(msg));
                        Time[10] = DateTimeStr;
                        Record.WriteIn("总重量校准二次加料重量设定",  msg, "Yellow");
                    }
                    break;
                case 11:    //Cruc Travel Calibration
                    if (CtlNum == 1)
                    {
                        Value[16] = 0;
                        PLC.SendBit(30, 107, 1);
                        Time[11] = DateTimeStr;
                        Record.WriteIn("坩埚位置校准设零位", "0.0", "Yellow");
                    }
                    if (CtlNum == 2)
                    {
                        LastValue = Value[17];
                        Value[17] = Convert.ToSingle(msg) / (PLC.ReadAnalogValue[34] - PLC.ReadCalibValue[18]);
                        PLC.SendFloat(34, 72, Value[17]);
                        Time[11] = DateTimeStr;
                        Record.WriteIn("坩埚位置校准增益标定", string.Format("{0}->{1}", LastValue.ToString("0.0"), Value[17].ToString("0.0")), "Yellow");
                    }
                    break;
                case 12:    //Cruc Travel Limit Calibration
                    if (CtlNum == 1)
                    {
                        LastValue = Value[18];
                        Value[18] = Convert.ToSingle(msg);
                        PLC.SendFloat(34, 76, Value[18]);
                        Time[12] = DateTimeStr;
                        Record.WriteIn("坩埚上限位校准", string.Format("{0}->{1}", LastValue.ToString("0.0"), Value[18].ToString("0.0")), "Yellow");
                    }
                    if (CtlNum == 2)
                    {
                        LastValue = Value[19];
                        Value[19] = Convert.ToSingle(msg);
                        PLC.SendFloat(34, 80, Value[19]);
                        Time[12] = DateTimeStr;
                        Record.WriteIn("坩埚下限位校准", string.Format("{0}->{1}", LastValue.ToString("0.0"), Value[19].ToString("0.0")), "Yellow");
                    }
                    break;
                case 14:    //Shield Travel Calibration
                    if (CtlNum == 1)
                    {
                        LastValue = Value[21];
                        Value[21] = Convert.ToSingle(msg) / (PLC.ReadAnalogValue[23] - PLC.ReadCalibValue[24]);
                        PLC.SendFloat(34, 88, Value[21]);
                        Time[14] = DateTimeStr;
                        Record.WriteIn("热屏位置校准增益标定", string.Format("{0}->{1}", LastValue.ToString("0.0"), Value[21].ToString("0.0")), "Yellow");
                    }
                    if (CtlNum == 2)
                    {
                        Value[22] = 0;
                        PLC.SendFloat(34, 92, Value[22]);
                        PLC.SendBit(30, 130, 1);
                        Time[14] = DateTimeStr;
                        Record.WriteIn("热屏位置校准设零位", "0.0", "Yellow");
                    }
                    break;
                case 15:    //Shield Travel Limit Calibration
                    if (CtlNum == 1)
                    {
                        LastValue = Value[23];
                        Value[23] = Convert.ToSingle(msg);
                        PLC.SendFloat(34, 96, Value[23]);
                        Time[15] = DateTimeStr;
                        Record.WriteIn("热屏上限位校准", string.Format("{0}->{1}", LastValue.ToString("0.0"), Value[23].ToString("0.0")), "Yellow");
                    }
                    if (CtlNum == 2)
                    {
                        LastValue = Value[24];
                        Value[24] = Convert.ToSingle(msg);
                        PLC.SendFloat(34, 100, Value[24]);
                        Time[15] = DateTimeStr;
                        Record.WriteIn("热屏下限位校准", string.Format("{0}->{1}", LastValue.ToString("0.0"), Value[24].ToString("0.0")), "Yellow");
                    }
                    break;
                case 17:    //Heater Tempration Calibration
                    if (CtlNum == 1)
                    {
                        LastValue = Value[26];
                        Value[26] = 1300 / PLC.ReadAnalogValue[38];
                        PLC.SendFloat(34, 108, Value[26]);
                        Time[17] = DateTimeStr;
                        Record.WriteIn("热场温度校准增益校准", string.Format("{0}->{1}", LastValue.ToString("0.0"), Value[26].ToString("0.0")), "Yellow");
                    }
                    break;
                case 18:    //Total Power Consume Calibration
                    if (CtlNum == 1)
                    {
                        PLC.SendFloat(34, 124, 0);
                        Time[18] = DateTimeStr;
                        Record.WriteIn("当前炉次功耗复位", "", "Yellow");
                    }
                    if (CtlNum == 2)
                    {
                        PLC.SendFloat(34, 200, 0);
                        Time[31] = DateTimeStr;
                        Record.WriteIn("总加热功耗复位", "", "Yellow");
                    }
                    break;
                case 19:    //Camera Melt Tempration Calibration
                    if (CtlNum == 1)
                    {
                        LastValue = Value[27];
                        Value[27] = Convert.ToSingle(msg) / PLC.ReadAnalogValue[39];
                        PLC.SendFloat(34, 112, Value[27]);
                        Time[19] = DateTimeStr;
                        Record.WriteIn("液面温度校准增益校准", string.Format("{0}->{1}", LastValue.ToString("0.0"), Value[27].ToString("0.0")), "Yellow");
                    }
                    if (CtlNum == 2)
                    {
                        PLC.SendFloat(34, 112, 1);
                        Value[27] = 1;
                        //液温偏移量校准方法
                        Value[44] = Convert.ToSingle(msg) - PLC.ReadAnalogValue[39] + Value[44];
                        Time[19] = DateTimeStr;
                    }
                    break;
                case 20:    //Isolate Atmosphere Calibration
                    if (CtlNum == 1)
                    {
                        LastValue = Value[28];
                        Value[28] = Convert.ToSingle(msg);
                        PLC.SendFloat(34, 136, Value[28]);
                        Time[20] = DateTimeStr;
                        Record.WriteIn("大气压力设定", string.Format("{0}->{1}", LastValue.ToString("0.0"), msg), "Yellow");
                    }
                    if (CtlNum == 2)
                    {
                        PLC.SendFloat(33, 260, Convert.ToSingle(msg));
                        Time[20] = DateTimeStr;
                        Record.WriteIn("手动快充压力设定", string.Format("{0}->{1}", LastValue.ToString("0.0"), msg), "Yellow");
                    }
                    break;
                case 21:    //Total Gas Calibration
                    if (CtlNum == 1)
                    {
                        PLC.SendFloat(34, 132, 0);
                        Time[21] = DateTimeStr;
                        Record.WriteIn("总氩气消耗复位", "", "Yellow");
                    }
                    if (CtlNum == 2)
                    {
                        PLC.SendFloat(34, 204, 0);
                        Time[32] = DateTimeStr;
                        Record.WriteIn("当前炉次氩气复位", "", "Yellow");
                    }
                    break;
                case 22:    //Total Lenth Calibration
                    if (CtlNum == 1)
                    {
                        PLC.SendFloat(35, 48, 0);
                        Time[22] = DateTimeStr;
                        Record.WriteIn("等径总长复位", "", "Yellow");
                    }
                    break;
                case 23:    //Melt Gap Calibration
                    if (CtlNum == 1)
                    {
                        PLC.SendFloat(31, 72, 1);
                        PLC.SendBit(30, 96, 1);
                        Time[23] = DateTimeStr;
                        Record.WriteIn("视觉液口距自动校准", "", "Yellow");
                    }
                    if (CtlNum == 2)
                    {
                        //更新视觉液口距增益
                        LastValue = Value[29];
                        Value[29] = Convert.ToSingle(msg);
                        PLC.SendFloat(34, 140, Value[29]);
                        Record.WriteIn("视觉液口距增益", string.Format("{0}->{1}", LastValue.ToString("0.00"), Value[29].ToString("0.00")), "Yellow");
                    }
                    if (CtlNum == 3)
                    {
                        //PLC更新视觉液口距偏移量
                        LastValue = Value[45];
                        Value[45] = Convert.ToSingle(msg);
                        PLC.SendFloat(34, 292, Value[45]);
                        Record.WriteIn("视觉液口距偏移量", string.Format("{0}->{1}", LastValue.ToString("0.00"), Value[45].ToString("0.00")), "Yellow");
                    }
                    break;
                case 24:    //Seed Lift Speed Calibration
                    if (CtlNum == 1)
                    {
                        LastValue = Value[31];
                        Value[31] = (Convert.ToSingle(msg) / PLC.ReadValue[49]) * PLC.ReadCalibValue[38];
                        PLC.SendFloat(34, 148, Value[31]);
                        Time[24] = DateTimeStr;
                        Record.WriteIn("晶升速度增益校准", string.Format("{0}->{1}", LastValue.ToString("0.0"), Value[31].ToString("0.0")), "Yellow");
                    }
                    break;
                case 25:    //Seed Rotation Speed Calibration
                    if (CtlNum == 1)
                    {
                        LastValue = Value[32];
                        Value[32] = (Convert.ToSingle(msg) / PLC.ReadValue[51]) * PLC.ReadCalibValue[39];
                        PLC.SendFloat(34, 152, Value[32]);
                        Time[25] = DateTimeStr;
                        Record.WriteIn("晶转速度增益校准", string.Format("{0}->{1}", LastValue.ToString("0.0"), Value[32].ToString("0.0")), "Yellow");
                    }
                    break;
                case 26:    //Crucible Lift Speed Calibration
                    if (CtlNum == 1)
                    {
                        LastValue = Value[33];
                        Value[33] = Convert.ToSingle(msg) / PLC.ReadValue[54] * PLC.ReadCalibValue[40];
                        PLC.SendFloat(34, 156, Value[33]);
                        Time[26] = DateTimeStr;
                        Record.WriteIn("埚升速度增益校准", string.Format("{0}->{1}", LastValue.ToString("0.0"), Value[33].ToString("0.0")), "Yellow");
                    }
                    break;
                case 27:    //Crucible Rotation Speed Calibration
                    if (CtlNum == 1)
                    {
                        LastValue = Value[34];
                        Value[34] = Convert.ToSingle(msg) / PLC.ReadValue[56] * PLC.ReadCalibValue[41];
                        PLC.SendFloat(34, 160, Value[34]);
                        Time[27] = DateTimeStr;
                        Record.WriteIn("埚转速度增益校准", string.Format("{0}->{1}", LastValue.ToString("0.0"), Value[34].ToString("0.0")), "Yellow");
                    }
                    break;
                case 28:    //Body Multi Segment Calibration
                    if (CtlNum == 1)
                    {
                        PLC.SendFloat(35, 112, Convert.ToSingle(msg));
                        Time[28] = DateTimeStr;
                        Record.WriteIn("等径提段长度", msg, "Yellow");
                    }
                    break;
                case 29:    //Pull Out Weight Calibration
                    if (CtlNum == 1)
                    {
                        PLC.SendFloat(35, 20, PLC.ReadCalcValue[6] + Convert.ToSingle(msg));
                        Time[29] = DateTimeStr;
                        Record.WriteIn("二次提出重量设定", msg, "Yellow");
                    }
                    break;
                case 30:    //Weigth Melt Gap Calibration
                    if (CtlNum == 1)
                    {
                        Value[30] = PLC.ReadCalcValue[1] - PLC.ReadCalcValue[24] + PLC.ReadCalibValue[37];
                        PLC.SendFloat(34, 144, Value[30]);
                        Time[30] = DateTimeStr;
                        Record.WriteIn("重量液口距同步校准", Value[30].ToString("0.00"), "Yellow");
                    }
                    break;
                case 31:    //力矩参数校准-上升
                    if (CtlNum == 1)
                    {
                        LastValue = Value[35];
                        Value[35] = Convert.ToSingle(msg);
                        PLC.SendFloat(34, 164, Value[35]);
                        Time[35] = DateTimeStr;
                        Record.WriteIn("热屏上升力矩设定", string.Format("{0}->{1}", LastValue.ToString("0.00"), Value[35].ToString("0.00")), "Yellow");
                    }
                    break;
                case 32:    //力矩参数校准-下降
                    if (CtlNum == 1)
                    {
                        LastValue = Value[36];
                        Value[36] = Convert.ToSingle(msg);
                        PLC.SendFloat(34, 168, Value[36]);
                        Time[36] = DateTimeStr;
                        Record.WriteIn("热屏下降力矩设定", string.Format("{0}->{1}", LastValue.ToString("0.00"), Value[36].ToString("0.00")), "Yellow");
                    }
                    break;
                case 33:    //力矩参数校准-偏差
                    if (CtlNum == 1)
                    {
                        LastValue = Value[37];
                        Value[37] = Convert.ToSingle(msg);
                        PLC.SendFloat(34, 172, Value[37]);
                        Time[37] = DateTimeStr;
                        Record.WriteIn("热屏位置偏差设定", string.Format("{0}->{1}", LastValue.ToString("0.00"), Value[37].ToString("0.00")), "Yellow");
                    }
                    break;
                case 34:
                    if (CtlNum == 1)
                    {
                        LastValue = Value[38];
                        Value[38] = Convert.ToSingle(msg);
                        PLC.SendFloat(34, 176, Value[38]);
                        Time[38] = DateTimeStr;
                        Record.WriteIn("副室1000Torr真空计补偿设定", string.Format("{0}->{1}", LastValue.ToString("f1"), Value[38].ToString("f1")), "Yellow");
                    }
                    if (CtlNum == 2)
                    {
                        LastValue = Value[39];
                        Value[39] = Convert.ToSingle(msg);
                        PLC.SendFloat(34, 180, Value[39]);
                        Time[39] = DateTimeStr;
                        Record.WriteIn("副室1000Torr真空计增益设定", string.Format("{0}->{1}", LastValue.ToString("f1"), Value[39].ToString("f1")), "Yellow");
                    }
                    if (CtlNum == 3)
                    {
                        LastValue = Value[40];
                        Value[40] = Convert.ToSingle(msg);
                        PLC.SendFloat(34, 184, Value[40]);
                        Time[40] = DateTimeStr;
                        Record.WriteIn("主室100Torr真空计补偿设定", string.Format("{0}->{1}", LastValue.ToString("f1"), Value[40].ToString("f1")), "Yellow");
                    }
                    if (CtlNum == 4)
                    {
                        LastValue = Value[41];
                        Value[41] = Convert.ToSingle(msg);
                        PLC.SendFloat(34, 188, Value[41]);
                        Time[41] = DateTimeStr;
                        Record.WriteIn("主室100Torr真空计增益设定", string.Format("{0}->{1}", LastValue.ToString("f1"), Value[41].ToString("f1")), "Yellow");
                    }
                    if (CtlNum == 5)
                    {
                        LastValue = Value[42];
                        Value[42] = Convert.ToSingle(msg);
                        PLC.SendFloat(34, 192, Value[42]);
                        Time[42] = DateTimeStr;
                        Record.WriteIn("主室1Torr真空计补偿设定", string.Format("{0}->{1}", LastValue.ToString("f1"), Value[42].ToString("f1")), "Yellow");
                    }
                    if (CtlNum == 6)
                    {
                        LastValue = Value[43];
                        Value[43] = Convert.ToSingle(msg);
                        PLC.SendFloat(34, 196, Value[43]);
                        Time[43] = DateTimeStr;
                        Record.WriteIn("主室1Torr真空计增益设定", string.Format("{0}->{1}", LastValue.ToString("f1"), Value[43].ToString("f1")), "Yellow");
                        //LastValue = Value[38];
                        //Value[38] = Convert.ToSingle(msg);
                        //PLC.SendFloat(34, 172, Value[37]);
                        //Time[37] = DateTimeStr;
                        //Record.WriteIn("热屏位置偏差设定", String.Format("{0}->{1}", LastValue.ToString("0.00"), Value[37].ToString("0.00")), "Yellow");
                    }
                    if (CtlNum == 7)
                    {
                        //LastValue = Value[38];
                        //Value[38] = Convert.ToSingle(msg);
                        //PLC.SendFloat(34, 172, Value[37]);
                        //Time[37] = DateTimeStr;
                        //Record.WriteIn("热屏位置偏差设定", String.Format("{0}->{1}", LastValue.ToString("0.00"), Value[37].ToString("0.00")), "Yellow");
                    }
                    break;
            }
            WriteInValue();//Write Calibration Value
            WriteInTime();//Write Calibration DateTime
        }
        private static void WriteInValue()
        {
            using (FileStream fStream = new FileStream(FileHelper.CalibrationPath, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter SWriter = new StreamWriter(fStream, Encoding.UTF8))
                {
                    for (int i = 1; i < Name.Length; i++)
                    {
                        if (Name[i] != null)
                        {
                            SWriter.WriteLine(string.Concat(Name[i], "=", Value[i].ToString()));
                        }
                    }
                    SWriter.Flush();    //清空缓冲区
                }
            }
        }
        private static void WriteInTime()
        {
            using (FileStream fStream = new FileStream(FileHelper.CalibDateTimePath, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter SWriter = new StreamWriter(fStream, Encoding.UTF8))
                {
                    for (int i = 0; i < Time.Length; i++)
                    {
                        SWriter.WriteLine(Time[i]);
                    }
                    SWriter.Flush();    //清空缓冲区
                }
            }
        }
        /// <summary>
        /// 写入时间
        /// </summary>
        /// <param name="num"></param>
        /// <param name="Val"></param>
        /// <returns></returns>
        public static string WriteTime(int num, float Val)
        {
            ReadOut();
            Value[num] = Val;
            WriteInValue();
            Time[num] = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            WriteInTime();
            return Time[num];
        }
        /// <summary>
        /// 读取时间
        /// </summary>
        public static void ReadTime()
        {
            string[] Lines = File.ReadAllLines(FileHelper.CalibDateTimePath, Encoding.UTF8);
            int Length = Lines.Length;
            if (Length > 0)
            {
                int DTNum = Length > 50 ? 50 : Length;
                for (int i = 0; i < DTNum; i++)
                {
                    Time[i] = Lines[i];
                }
            }
        }
        public static string ReadTime(int FormNum)
        {
            return Time[FormNum] == "" ? "2000-01-01 00:00:00" : Time[FormNum];
        }
    }
}
