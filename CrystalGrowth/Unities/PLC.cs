using S7.Net;
using System;
using System.Collections;
using System.Threading;

namespace CrystalGrowth.Unities
{
    internal static class PLC
    {
        static Plc S71500;
        public static bool IsConn = false;
        /// <summary>
        ///  ReadStatusIn读取数字量DB10块
        /// </summary>
        public static byte[] ReadStatusIn = new byte[105];
        /// <summary>
        /// ReadStatusOut读取数字量DB11块
        /// </summary>
        public static byte[] ReadStatusOut = new byte[57];
        /// <summary>
        ///  ReadComm读取数字量DB13块
        /// </summary>
        public static byte[] ReadComm = new byte[37];
        /// <summary>
        /// PowerStatus读取数字量DB16块
        /// </summary>
        public static byte[] PowerStatus = new byte[37];
        /// <summary>
        /// ReadStatus读取数字量DB32块
        /// </summary>
        public static byte[] ReadStatus = new byte[153];
        /// <summary>
        ///StatusAlarm读取数字量DB36块
        /// </summary>
        public static byte[] StatusAlarm = new byte[585];

        /// <summary>
        /// ReadPLCVersion读取PLC版本号
        /// </summary>
        public static short[] ReadPLCVersion = new short[25];
        /// <summary>
        /// ReadAnalogOut读取整数DB11块
        /// </summary>
        public static short[] ReadAnalogOut = new short[51];
        /// <summary>
        ///ReadAnalogIn读取整数DB10块
        /// </summary>
        public static short[] ReadAnalogIn = new short[51];
        /// <summary>
        /// SystemErrCnt读取整数DB13块
        /// </summary>
        public static short[] SystemErrCnt = new short[51];

        /// <summary>
        /// ReadAnalogValue读取浮点数DB15块
        /// </summary>
        public static float[] ReadAnalogValue = new float[66];
        /// <summary>
        /// PowerValue读取浮点数DB16块
        /// </summary>
        public static float[] PowerValue = new float[22];
        /// <summary>
        ///ReadOthersValue读取浮点数DB31块
        /// </summary>
        public static float[] ReadOthersValue = new float[102];
        /// <summary>
        /// ReadValue读取浮点数DB33块
        /// </summary>
        public static float[] ReadValue = new float[202];
        /// <summary>
        /// ReadCalibValue读取浮点数DB34块
        /// </summary>
        public static float[] ReadCalibValue = new float[90];
        /// <summary>
        /// ReadCalcValue读取浮点数DB35块
        /// </summary>
        public static float[] ReadCalcValue = new float[102];
        /// <summary>
        /// InitSetValue读取浮点数DB40块
        /// </summary>
        public static float[] InitSetValue = new float[102];
        public static int Count = 0;
        public static void HeartBeatMonitor()
        {
            S71500 = new Plc(CpuType.S71500, "192.168.0.1", 0, 1);
            Thread thread = new Thread(() =>
            {
                while (true)
                {
                    try
                    {
                        //调用S7.NET中的方法连接PLC
                        if (IsConn == false) { S71500.OpenAsync().Wait(500); }
                        if (S71500.IsConnected)
                        {
                            IsConn = true;
                            S71500.ReadTimeout = 500;
                        }
                        else
                        {
                            IsConn = false;
                            if (S71500 != null) { S71500.Close(); }
                        }
                    }
                    catch
                    {
                        IsConn = false;
                        if (S71500 != null) { S71500.Close(); }
                    }
                    finally
                    {
                        Thread.Sleep(1000);
                    }
                }
            })
            {
                IsBackground = true
            };
            thread.Start();
        }
        public static void ReadFromPlc()
        {
            if (IsConn)
            {
                RecvBits(10, 0, 103, ref ReadStatusIn);
                RecvBits(11, 0, 53, ref ReadStatusOut);
                RecvBits(13, 124, 32, ref ReadComm);
                RecvBits(16, 0, 32, ref PowerStatus);
                RecvBits(32, 0, 152, ref ReadStatus);
                RecvBits(36, 0, 545, ref StatusAlarm);

                RecvInt(11, 8, 6, ref ReadAnalogOut);
                RecvInt(10, 14, 40, ref ReadAnalogIn);
                RecvInt(13, 128, 25, ref SystemErrCnt);
                RecvInt(29, 0, 24, ref ReadPLCVersion);

                RecvFloat(15, 0, 65, ref ReadAnalogValue);
                RecvFloat(16, 4, 14, ref PowerValue);
                RecvFloat(31, 0, 75, ref ReadOthersValue);
                RecvFloat(33, 0, 133, ref ReadValue);
                RecvFloat(34, 0, 81, ref ReadCalibValue);
                RecvFloat(35, 0, 33, ref ReadCalcValue);
                RecvFloat(40, 0, 55, ref InitSetValue);
                //写入数据时防止写入数据和接收数据显示冲突
                if (Count < 2) { Count++; }
            }
            
        }
        static byte[] bytes;
        static BitArray bitArray;
        static int lastBytesNum, BytesNum, ReadTimes, tempValue;
        public static void RecvBits(int DBNum, int Addr, int Total, ref byte[] Table)
        {
            int j;
            BytesNum = Total / 8;
            tempValue = Total % 8 == 0 ? 0 : 1;
            ReadTimes = BytesNum / 200;
            try
            {
                for (int i = 0; i <= ReadTimes; i++)
                {
                    if (i == ReadTimes)
                    {
                        lastBytesNum = BytesNum - i * 200 + tempValue;
                        bytes = S71500.ReadBytes(DataType.DataBlock, DBNum, Addr + i * 200, lastBytesNum);
                    }
                    else
                    {
                        bytes = S71500.ReadBytes(DataType.DataBlock, DBNum, Addr + i * 200, 200);
                    }
                    if (bytes != null)
                    {
                        bitArray = S7.Net.Types.Bit.ToBitArray(bytes);
                        j = 0;
                        while (j < bitArray.Length)
                        {
                            Table[j + 1] = Convert.ToByte(bitArray[j]);
                            j++;
                        }
                    }
                }
            }
            //catch (PlcException ex)
            catch
            {
                IsConn = false;
                if (S71500 != null) { S71500.Close(); }
                //Log.Record(string.Format("接收DB{0} 字节位置:{1} 总数量{2}", DBNum.ToString(), Addr.ToString(), Total.ToString()), ex);
                return;
            }
        }
        static short[] shortArray;
        static object obj;
        public static void RecvInt(int DBNum, int Addr, int Total, ref short[] Table)
        {
            int j;
            ReadTimes = Total * 2 / 200;
            try
            {
                for (int i = 0; i <= ReadTimes; i++)
                {
                    if (i == ReadTimes)
                    {
                        lastBytesNum = (Total * 2 - i * 200) % 200 / 2;
                        obj = S71500.Read(DataType.DataBlock, DBNum, Addr + i * 200, VarType.Int, lastBytesNum);
                    }
                    else
                    {
                        obj = S71500.Read(DataType.DataBlock, DBNum, Addr + i * 200, VarType.Int, 100);
                    }
                    if (obj != null)
                    {
                        shortArray = (short[])obj;
                        j = 0;
                        while (j < shortArray.Length)
                        {
                            Table[i * 100 + j + 1] = shortArray[j];
                            j++;
                        }
                    }
                }
            }
            //catch (PlcException ex)
            catch
            {
                IsConn = false;
                if (S71500 != null) { S71500.Close(); }
                //Log.Record(string.Format("接收DB{0} 字节位置:{1} 总数量{2}", DBNum.ToString(), Addr.ToString(), Total.ToString()), ex);
                return;
            }
        }
        static float[] floatArray;
        public static void RecvFloat(int DBNum, int Addr, int Total, ref float[] Table)
        {
            int j;
            ReadTimes = Total * 4 / 200;
            try
            {
                for (int i = 0; i <= ReadTimes; i++)
                {
                    if (i == ReadTimes)
                    {
                        lastBytesNum = (Total * 4 - i * 200) % 200 / 4;
                        obj = S71500.Read(DataType.DataBlock, DBNum, Addr + i * 200, VarType.Real, lastBytesNum);
                    }
                    else
                    {
                        obj = S71500.Read(DataType.DataBlock, DBNum, Addr + i * 200, VarType.Real, 50);
                    }
                    if (obj != null)
                    {
                        floatArray = (float[])obj;
                        j = 0;
                        while (j < floatArray.Length)
                        {
                            Table[i * 50 + j + 1] = floatArray[j];
                            j++;
                        }
                    }
                }
            }
            //catch (PlcException ex)
            catch(PlcException ex)
            {
                IsConn = false;
                if (S71500 != null) { S71500.Close(); }
                //Log.Record(string.Format("接收DB{0} 字节位置:{1} 总数量{2}", DBNum.ToString(), Addr.ToString(), Total.ToString()), ex);
                return;
            }
        }
        public static float RecvFloat(int DBNum, int Addr, int Total)
        {
            return (float)S71500.Read(DataType.DataBlock, DBNum, 0, VarType.Real, 1);
        }
        static float[] floatArray1;
        public static void RecvFloat(int DBNum, int Addr, ref float[] Table)
        {
            int j, Total = Table.Length;
            ReadTimes = Total * 4 / 200;
            try
            {
                for (int i = 0; i <= ReadTimes; i++)
                {
                    if (i == ReadTimes)
                    {
                        lastBytesNum = (Total * 4 - i * 200) % 200 / 4;
                        obj = S71500.Read(DataType.DataBlock, DBNum, Addr + i * 200, VarType.Real, lastBytesNum);
                    }
                    else
                    {
                        obj = S71500.Read(DataType.DataBlock, DBNum, Addr + i * 200, VarType.Real, 50);
                    }
                    if (obj != null)
                    {
                        floatArray1 = (float[])obj;
                        j = 0;
                        while (j < floatArray1.Length)
                        {
                            Table[i * 50 + j] = floatArray1[j];
                            j++;
                        }
                    }
                }
            }
            //catch (PlcException ex)
            catch
            {
                IsConn = false;
                if (S71500 != null) { S71500.Close(); }
                //Log.Record(string.Format("接收DB{0} 字节位置:{1} 总数量{2}", DBNum.ToString(), Addr.ToString(), Total.ToString()), ex);
                return;
            }
        }
        /// <summary>
        /// bool发送差两位
        /// </summary>
        static bool AutoValue;
        static int AutoAddr;
        public static void SendBit(int DBNum, int Addr, byte Value)
        {
            if (IsConn)
            {
                AutoAddr = Addr % 8 == 0 ? 0 : Addr % 8;
                AutoValue = Value == 1;
                try
                {
                    S71500.WriteBit(DataType.DataBlock, DBNum, Addr / 8, AutoAddr, AutoValue);

                }
                //catch (PlcException ex)
                catch
                {
                    //Log.Record(string.Format("发送BitDB{0} 字节位置:{1}", DBNum.ToString(), (Addr / 8).ToString()), ex);
                    return;
                }
            }
        }
        /// <summary>
        /// 偏移地址
        /// </summary>
        /// <param name="DBNum"></param>
        /// <param name="Addr"></param>
        /// <param name="Value"></param>
        public static void SendFloat(int DBNum, int Addr, float Value)
        {
            if (IsConn)
            {
                try
                {
                    S71500.Write(DataType.DataBlock, DBNum, Addr, Value);
                }
                //catch (PlcException ex)
                catch
                {
                    //Log.Record(string.Format("发送浮点数DB{0} 字节位置:{1}", DBNum.ToString(), Addr.ToString()), ex);
                    return;
                }
            }
        }
        public static void SendMultiFloat(int DBNum, float[] Table)
        {
            if (IsConn)
            {
                try
                {
                    S71500.Write(DataType.DataBlock, DBNum, 0, Table);
                }
                //catch (PlcException ex)
                catch
                {
                    //Log.Record(string.Format("发送数组DB{0} 数组长度:{1}", DBNum.ToString(), Table.Length.ToString()), ex);
                    return;
                }
            }
        }
    }
}
