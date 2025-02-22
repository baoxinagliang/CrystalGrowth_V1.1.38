﻿using System;
using System.IO;
using System.Text;

namespace CrystalGrowth.Unities
{
    internal class HotEquipmentParts
    {
        public string Fit;
        public string Flag;//是否更新开始时间
        public string Name;//热场件名称
        public string Material;//材质
        public string Code;//热场件编码
        public string StartTime;//开始使用日期
        public string RatedDays;//额定使用寿命
        public string UsageTime;//使用时间
        public string ChangeReason;//更换原因
        public string GhangeTime;//更换日期
    }
    internal static class HotHandle
    {
        static string isStart = "false";
        public static string IsStart
        {
            set
            {
                if (isStart == "false" && value == "true")
                {
                    HotEquipmentParts[] hepList = ReadOut();
                    for (int i = 0; i < 17; i++)
                    {
                        if (hepList[i].Flag == "false")
                        {
                            hepList[i].Flag = "true";
                            hepList[i].StartTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        }
                    }
                    WriteIn(hepList);
                }
                isStart = value;
            }
        }
        public static HotEquipmentParts[] ReadOut()
        {
            HotEquipmentParts[] hepList = new HotEquipmentParts[17];
            using (FileStream fStream = new FileStream(FileHelper.HotZonePath, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader SReader = new StreamReader(FileHelper.HotZonePath, Encoding.UTF8))
                {
                    char[] SplitChar = new char[] { ',' };
                    string LineStr;
                    string[] LineStrArray;
                    for (int i = 0; i < 17; i++)
                    {
                        LineStr = SReader.ReadLine();
                        LineStrArray = LineStr.Split(SplitChar);
                        HotEquipmentParts hot = new HotEquipmentParts
                        {
                            Fit = LineStrArray[0],
                            Flag = LineStrArray[1],
                            Name = LineStrArray[2],
                            Material = LineStrArray[3],
                            Code = LineStrArray[4],
                            StartTime = LineStrArray[5],
                            RatedDays = LineStrArray[6],
                            UsageTime = LineStrArray[7],
                            ChangeReason = LineStrArray[8],
                            GhangeTime = LineStrArray[9]
                        };
                        hepList[i] = hot;
                    }
                }
            }
            return hepList;
        }
        public static void WriteIn(HotEquipmentParts[] hepList)
        {
            StringBuilder sb = new StringBuilder();
            using (FileStream fStream = new FileStream(FileHelper.HotZonePath, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter SWriter = new StreamWriter(fStream, Encoding.UTF8))
                {
                    for (int i = 0; i < 17; i++)
                    {
                        sb.Append(string.Concat(hepList[i].Fit, ","));
                        sb.Append(string.Concat(hepList[i].Flag, ","));
                        sb.Append(string.Concat(hepList[i].Name, ","));
                        sb.Append(string.Concat(hepList[i].Material, ","));
                        sb.Append(string.Concat(hepList[i].Code, ","));
                        sb.Append(string.Concat(hepList[i].StartTime, ","));
                        sb.Append(string.Concat(hepList[i].RatedDays, ","));
                        sb.Append(string.Concat(hepList[i].UsageTime, ","));
                        sb.Append(string.Concat(hepList[i].ChangeReason, ","));
                        sb.Append(hepList[i].GhangeTime);
                        SWriter.WriteLine(sb.ToString());
                        sb.Clear();
                    }
                    SWriter.Flush();
                }
            }
        }
    }
}
