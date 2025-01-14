using System.Collections.Generic;
using System.Management;
using System.Net.NetworkInformation;

namespace CrystalGrowth.AuxFunction.License
{
    internal static class ComputerInfo
    {
        public static string GetComputerInfo()
        {
            string CPU = GetCPUInfo();
            string BaseBoard = GetBaseBoardInfo();
            string Bios = GetBIOSInfo();
            string MAC = GetMacAddress();
            return string.Concat(CPU, BaseBoard, Bios, MAC);
        }
        public static string Get()
        {
            string CPU = string.Concat(" CPU:", GetCPUInfo());
            string BaseBoard = string.Concat(" BaseBoard:", GetBaseBoardInfo());
            string Bios = string.Concat(" Bios:", GetBIOSInfo());
            string MAC = string.Concat(" MAC:", GetMacAddress());
            return string.Concat(CPU, BaseBoard, Bios, MAC);
        }
        private static string GetCPUInfo()
        {
            return GetHardWareInfo("Win32_Processor", "ProcessorId");
        }
        private static string GetBIOSInfo()
        {
            return GetHardWareInfo("Win32_BIOS", "SerialNumber"); 
        }
        private static string GetBaseBoardInfo()
        {
            return GetHardWareInfo("Win32_BaseBoard", "SerialNumber");
        }
        private static string GetMacAddress()
        {
            NetworkInterface[] NetInterface = NetworkInterface.GetAllNetworkInterfaces();
            int Length = NetInterface.Length;
            List<string> TempStr = new List<string>();
            string ConStr = "";
            int Cnt = 0;
            if (Length > 0)
            {
                for (int i = 0; i < Length; i++)
                {
                    if (NetInterface[i].Description.Contains("USB"))
                    {
                        continue;
                    }
                    if (NetInterface[i].GetPhysicalAddress() != null)
                    {
                        TempStr.Add(NetInterface[i].GetPhysicalAddress().ToString());
                        Cnt++;
                    }
                    if (Cnt >= 4)
                    {
                        break;
                    }
                }
                TempStr.Sort();
                foreach (string str in TempStr)
                {
                    ConStr += str;
                }
                return ConStr;
            }
            else
            {
                return "linton-kayex";
            }
        }
        private static string GetHardWareInfo(string TypePath, string Key)
        {
            ManagementClass MC = new ManagementClass(TypePath);
            ManagementObjectCollection MOC = MC.GetInstances();
            PropertyDataCollection PDC = MC.Properties;
            foreach (PropertyData PD in PDC)
            {
                if (PD.Name == Key)
                {
                    foreach (ManagementObject MO in MOC)
                    {
                        return MO.Properties[PD.Name].Value.ToString();
                    }
                }
            }
            return string.Empty;
        }
    }
}


