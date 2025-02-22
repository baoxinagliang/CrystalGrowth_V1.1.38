﻿using CrystalGrowth.CrystalCtl;
using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CrystalGrowth.Unities
{
    internal static class SqliteHelper
    {
        static readonly string[] DataStrings = new string[75];
        static readonly string LgConnStr = string.Format("Data Source={0};Pooling=true;FailIfMissing=false", FileHelper.LoginDataPath);
        public static SQLiteConnection Conn;
        static SQLiteCommand Cmd;
        static bool IsComplete = false;
        static string LastStr = "";
        static readonly object o = new object();
        public static void CreateDatabase()
        {
            string DataBaseName = IdNum.CrystalID == "" ? "ID_XXXXXXXX" : string.Concat("ID_", IdNum.CrystalID);
            string DataSource = string.Format("D:\\LICCS_DB\\{0}.db3", DataBaseName);
            //创建文件路径
            if (!Directory.Exists("D:\\LICCS_DB"))
            {
                Directory.CreateDirectory("D:\\LICCS_DB");
            }
            //创建数据库
            if (File.Exists(DataSource))
            {
                IsComplete = true;
                if (Conn == null || DataSource != LastStr)
                {
                    Conn = new SQLiteConnection(string.Format("Data Source={0};Pooling=true;FailIfMissing=false", DataSource));
                    //打开数据库
                    if (Conn.State != ConnectionState.Open)
                    {
                        Conn.Open();
                    }
                    Cmd = Conn.CreateCommand();
                }
            }
            else
            {
                IsComplete = false;
                SQLiteConnection.CreateFile(DataSource);
                Conn = new SQLiteConnection(string.Format("Data Source={0};Pooling=true;FailIfMissing=false", DataSource));
                //打开数据库
                if (Conn.State != ConnectionState.Open)
                {
                    Conn.Open();
                }
                Cmd = Conn.CreateCommand();
                Cmd.CommandText = "CREATE TABLE IF NOT EXISTS PROCESS_DATA (DATE_TIME DATETIME,CRYSTAL_NUMBER TEXT,STATE TEXT,MAIN_POWER TEXT,CRYSTAL_LENGTH TEXT,REMAIN_WEIGHT TEXT,GROWTH_RATE_PV TEXT,GROWTH_RATE_SP TEXT,DIAMETER TEXT,SEED_ROTATION TEXT,CRUC_ROTATION TEXT,SEED_LIFT TEXT,HTR_TEMP_SP TEXT,HTR_TEMP_PV TEXT,MAIN_CURRENT TEXT,BOTTOM_POWER TEXT,BOTTOM_CURRENT TEXT,TEMP_RAMP TEXT,POWER_RAMP TEXT,MELT_TEMP_SP TEXT,MELT_TEMP_PV TEXT,MELT_GAP TEXT,CL_SL_RATIO TEXT,CRUC_LIFT TEXT,PRESSURE TEXT,THROTTLE_TARG TEXT,GAS_FLOW TEXT,CRUC_POSITION TEXT,SEED_POSITION TEXT,SHIELD_POSITION TEXT,NET_WEIGHT TEXT,CRYSTAL_WEIGHT TEXT,TOTAL_WEIGHT TEXT,PULLOUT_WEIGHT TEXT,CROWN_DEGREE TEXT,SHIELD_TEMP TEXT,SHIELD_FLOW TEXT,PRESSURE_PC TEXT,MAIN_VOL TEXT,BOTTOM_VOL TEXT,MAIN_PC TEXT,HTR_H_TEMP TEXT,MAINW_INPC TEXT,MAINW_OUTPC TEXT,AUXI_INPC TEXT,AUXI_OUTPC TEXT,LPIPE_TEMP TEXT,PIPE_TEMP TEXT,RPIPE_TEMP TEXT,SEED_LIFT_SP TEXT,SEED_ROTA_SP TEXT,CRUC_LIFT_SP TEXT,CRUC_ROTA_SP TEXT,MAIN_POWER_SP TEXT,BOTTOM_POWER_SP TEXT,THROTTLE_TARG_SP TEXT,GAS_FLOW_SP TEXT,AUXI_SHIELD_SP TEXT,SEED_ROTA_AC TEXT,CRUC_ROTA_AC TEXT,MAIN_R TEXT,BOTTOM_R TEXT,SEED_MElT_POSITION TEXT,DIAMETER_SV TEXT,D_MULT_LEGHT TEXT,D_TOTAL_LEGHT TEXT,MELT_DEPTH TEXT,MELT_WEIGHT TEXT,LEAK_RATE TEXT,HEART_TIME TEXT,COUNTDN_TIME TEXT,B_MULT_SPEED TEXT,TAIL_D TEXT,ABS_MELT_GAP TEXT,CENTER_PIXEL_X TEXT)";
                Cmd.ExecuteNonQuery();
                Cmd.CommandText = "CREATE TABLE IF NOT EXISTS HistoricalAlarm (DATE_TIME DATETIME,INFO TEXT)";
                Cmd.ExecuteNonQuery();
            }
            LastStr = DataSource;
        }
        public static void CreateLoginDB()
        {
            string strPath = string.Concat(Application.StartupPath, "\\Login");
            //创建文件路径
            if (!Directory.Exists(strPath))
            {
                Directory.CreateDirectory(strPath);
            }
            //创建数据库
            if (!File.Exists(FileHelper.LoginDataPath))
            {
                SQLiteConnection.CreateFile(FileHelper.LoginDataPath);
                //连接数据库
                using (SQLiteConnection Conn1 = new SQLiteConnection(LgConnStr))
                {
                    //打开数据库
                    if (Conn1.State != ConnectionState.Open)
                    {
                        Conn1.Open();
                    }
                    using (SQLiteCommand Cmd1 = new SQLiteCommand())
                    {
                        Cmd1.Connection = Conn1;
                        Cmd1.CommandText = "CREATE TABLE IF NOT EXISTS LOGIN_DATA (DATE_TIME DATETIME,USER_NAME TEXT,PASS_WORD TEXT)";
                        Cmd1.ExecuteNonQuery();
                        Cmd1.CommandText = "CREATE TABLE IF NOT EXISTS HOT_DATA (DATE_TIME DATETIME,NAME TEXT,MATEIAL TEXT,CODE TEXT,STARTTIME DATETIME,RATEDDAYS TEXT,USAGETIME TEXT,CHANGEREASON TEXT,GHANGETIME TEXT)";
                        Cmd1.ExecuteNonQuery();
                        string Date_Time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        Cmd1.CommandText = "INSERT INTO LOGIN_DATA (DATE_TIME,USER_NAME,PASS_WORD) VALUES (@DATE_TIME,@USER_NAME,@PASS_WORD)";
                        Cmd1.Parameters.Add("@DATE_TIME", DbType.DateTime).Value = Date_Time;
                        Cmd1.Parameters.Add("@USER_NAME", DbType.String).Value = "KayexAdmin";
                        Cmd1.Parameters.Add("@PASS_WORD", DbType.String).Value = "KX777777";
                        Cmd1.ExecuteNonQuery();
                        Cmd1.CommandText = "INSERT INTO LOGIN_DATA (DATE_TIME,USER_NAME,PASS_WORD) VALUES (@DATE_TIME,@USER_NAME,@PASS_WORD)";
                        Cmd1.Parameters.Add("@DATE_TIME", DbType.DateTime).Value = Date_Time;
                        Cmd1.Parameters.Add("@USER_NAME", DbType.String).Value = "SuperUser";
                        Cmd1.Parameters.Add("@PASS_WORD", DbType.String).Value = "SU888888";
                        Cmd1.ExecuteNonQuery();
                        Cmd1.CommandText = "INSERT INTO LOGIN_DATA (DATE_TIME,USER_NAME,PASS_WORD) VALUES (@DATE_TIME,@USER_NAME,@PASS_WORD)";
                        Cmd1.Parameters.Add("@DATE_TIME", DbType.DateTime).Value = Date_Time;
                        Cmd1.Parameters.Add("@USER_NAME", DbType.String).Value = "Engineer";
                        Cmd1.Parameters.Add("@PASS_WORD", DbType.String).Value = "888888";
                        Cmd1.ExecuteNonQuery();
                        Cmd1.CommandText = "INSERT INTO LOGIN_DATA (DATE_TIME,USER_NAME,PASS_WORD) VALUES (@DATE_TIME,@USER_NAME,@PASS_WORD)";
                        Cmd1.Parameters.Add("@DATE_TIME", DbType.DateTime).Value = Date_Time;
                        Cmd1.Parameters.Add("@USER_NAME", DbType.String).Value = "Operator";
                        Cmd1.Parameters.Add("@PASS_WORD", DbType.String).Value = "999999";
                        Cmd1.ExecuteNonQuery();
                        Cmd1.CommandText = "INSERT INTO LOGIN_DATA (DATE_TIME,USER_NAME,PASS_WORD) VALUES (@DATE_TIME,@USER_NAME,@PASS_WORD)";
                        Cmd1.Parameters.Add("@DATE_TIME", DbType.DateTime).Value = Date_Time;
                        Cmd1.Parameters.Add("@USER_NAME", DbType.String).Value = "Operator01";
                        Cmd1.Parameters.Add("@PASS_WORD", DbType.String).Value = "666666";
                        Cmd1.ExecuteNonQuery();
                    }
                }
            }
        }
        public static void BeginRecord()
        {
            try
            {
                CreateDatabase();
                //插入数据
                InsertData();
                Alarm.SqliteErr1Flag = false;
            }
            catch
            {
                Alarm.SqliteErr1Flag = true;
            }
            FileHelper.WriteIn(FileHelper.DBDataPath, DataStrings);
        }
        private static void InsertData()
        {
            lock (o)
            {
            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT INTO PROCESS_DATA(DATE_TIME,CRYSTAL_NUMBER,STATE,MAIN_POWER,CRYSTAL_LENGTH,REMAIN_WEIGHT,GROWTH_RATE_PV,GROWTH_RATE_SP,DIAMETER,SEED_ROTATION,CRUC_ROTATION,SEED_LIFT,HTR_TEMP_SP,HTR_TEMP_PV,MAIN_CURRENT,BOTTOM_POWER,BOTTOM_CURRENT,TEMP_RAMP,POWER_RAMP,MELT_TEMP_SP,MELT_TEMP_PV,MELT_GAP,CL_SL_RATIO,CRUC_LIFT,PRESSURE,THROTTLE_TARG,GAS_FLOW,CRUC_POSITION,SEED_POSITION,SHIELD_POSITION,NET_WEIGHT,CRYSTAL_WEIGHT,TOTAL_WEIGHT,PULLOUT_WEIGHT,CROWN_DEGREE,SHIELD_TEMP,SHIELD_FLOW,PRESSURE_PC,");
            sb.Append("MAIN_VOL,BOTTOM_VOL,MAIN_PC,HTR_H_TEMP,MAINW_INPC,MAINW_OUTPC,AUXI_INPC,AUXI_OUTPC,LPIPE_TEMP,PIPE_TEMP,RPIPE_TEMP,SEED_LIFT_SP,SEED_ROTA_SP,CRUC_LIFT_SP,CRUC_ROTA_SP,MAIN_POWER_SP,BOTTOM_POWER_SP,THROTTLE_TARG_SP,GAS_FLOW_SP,AUXI_SHIELD_SP,SEED_ROTA_AC,CRUC_ROTA_AC,MAIN_R,BOTTOM_R,SEED_MElT_POSITION,DIAMETER_SV,D_MULT_LEGHT,D_TOTAL_LEGHT,MELT_DEPTH,MELT_WEIGHT,LEAK_RATE,HEART_TIME,COUNTDN_TIME,B_MULT_SPEED,TAIL_D,ABS_MELT_GAP,CENTER_PIXEL_X)");
            sb.Append("VALUES(@DATE_TIME,@CRYSTAL_NUMBER,@STATE,@MAIN_POWER,@CRYSTAL_LENGTH,@REMAIN_WEIGHT,@GROWTH_RATE_PV,@GROWTH_RATE_SP,@DIAMETER,@SEED_ROTATION,@CRUC_ROTATION,@SEED_LIFT,@HTR_TEMP_SP,@HTR_TEMP_PV,@MAIN_CURRENT,@BOTTOM_POWER,@BOTTOM_CURRENT,@TEMP_RAMP,@POWER_RAMP,@MELT_TEMP_SP,@MELT_TEMP_PV,@MELT_GAP,@CL_SL_RATIO,@CRUC_LIFT,@PRESSURE,@THROTTLE_TARG,@GAS_FLOW,@CRUC_POSITION,@SEED_POSITION,@SHIELD_POSITION,@NET_WEIGHT,@CRYSTAL_WEIGHT,@TOTAL_WEIGHT,@PULLOUT_WEIGHT,@CROWN_DEGREE,@SHIELD_TEMP,@SHIELD_FLOW,@PRESSURE_PC,");
            sb.Append("@MAIN_VOL,@BOTTOM_VOL,@MAIN_PC,@HTR_H_TEMP,@MAINW_INPC,@MAINW_OUTPC,@AUXI_INPC,@AUXI_OUTPC,@LPIPE_TEMP,@PIPE_TEMP,@RPIPE_TEMP,@SEED_LIFT_SP,@SEED_ROTA_SP,@CRUC_LIFT_SP,@CRUC_ROTA_SP,@MAIN_POWER_SP,@BOTTOM_POWER_SP,@THROTTLE_TARG_SP,@GAS_FLOW_SP,@AUXI_SHIELD_SP,@SEED_ROTA_AC,@CRUC_ROTA_AC,@MAIN_R,@BOTTOM_R,@SEED_MElT_POSITION,@DIAMETER_SV,@D_MULT_LEGHT,@D_TOTAL_LEGHT,@MELT_DEPTH,@MELT_WEIGHT,@LEAK_RATE,@HEART_TIME,@COUNTDN_TIME,@B_MULT_SPEED,@TAIL_D,@ABS_MELT_GAP,@CENTER_PIXEL_X)");
            Cmd.CommandText = sb.ToString();
            DataStrings[0] = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            Cmd.Parameters.Add("@DATE_TIME", DbType.DateTime).Value = DataStrings[0];
            DataStrings[1] = IdNum.CrystalID;
            Cmd.Parameters.Add("@CRYSTAL_NUMBER", DbType.String).Value = DataStrings[1];
            DataStrings[2] = ProcState.CurrentState(Math.Round(PLC.ReadValue[1], 1).ToString("f1"));
            Cmd.Parameters.Add("@STATE", DbType.String).Value = DataStrings[2];
            DataStrings[3] = FrmVarTable.VarValue[159];//主加热器功率[KW]
            Cmd.Parameters.Add("@MAIN_POWER", DbType.String).Value = DataStrings[3];
            DataStrings[4] = FrmVarTable.VarValue[262];//晶体长度[mm]
            Cmd.Parameters.Add("@CRYSTAL_LENGTH", DbType.String).Value = DataStrings[4];
            DataStrings[5] = FrmVarTable.VarValue[259];//剩余重量[kg]
            Cmd.Parameters.Add("@REMAIN_WEIGHT", DbType.String).Value = DataStrings[5];
            DataStrings[6] = FrmVarTable.VarValue[270];//生长速度[mm/hr]
            Cmd.Parameters.Add("@GROWTH_RATE_PV", DbType.String).Value = DataStrings[6];
            DataStrings[7] = FrmVarTable.VarValue[261];//设定拉速[mm/hr]
            Cmd.Parameters.Add("@GROWTH_RATE_SP", DbType.String).Value = DataStrings[7];
            DataStrings[8] = FrmVarTable.VarValue[269];//实际直径[mm]
            Cmd.Parameters.Add("@DIAMETER", DbType.String).Value = DataStrings[8];

            DataStrings[9] = FrmVarTable.VarValue[152];//晶转速度[rpm]
            Cmd.Parameters.Add("@SEED_ROTATION", DbType.String).Value = DataStrings[9];
            DataStrings[10] = FrmVarTable.VarValue[156];//埚转速度[rpm]
            Cmd.Parameters.Add("@CRUC_ROTATION", DbType.String).Value = DataStrings[10];
            DataStrings[11] = FrmVarTable.VarValue[151];//晶升速度[mm/hr]
            Cmd.Parameters.Add("@SEED_LIFT", DbType.String).Value = DataStrings[11];
            DataStrings[12] = FrmVarTable.VarValue[210];//设定热场温度[degC]
            Cmd.Parameters.Add("@HTR_TEMP_SP", DbType.String).Value = DataStrings[12];
            DataStrings[13] = FrmVarTable.VarValue[266];//热场温度[degC]
            Cmd.Parameters.Add("@HTR_TEMP_PV", DbType.String).Value = DataStrings[13];
            DataStrings[14] = FrmVarTable.VarValue[161];//主加热器电流[amps]
            Cmd.Parameters.Add("@MAIN_CURRENT", DbType.String).Value = DataStrings[14];
            DataStrings[15] = FrmVarTable.VarValue[162];//底加热器功率[KW]
            Cmd.Parameters.Add("@BOTTOM_POWER", DbType.String).Value = DataStrings[15];
            DataStrings[16] = FrmVarTable.VarValue[164];//底加热器电流[amps]
            Cmd.Parameters.Add("@BOTTOM_CURRENT", DbType.String).Value = DataStrings[16];
            DataStrings[17] = FrmVarTable.VarValue[267];//热场温度变化速率[degC/hr]
            Cmd.Parameters.Add("@TEMP_RAMP", DbType.String).Value = DataStrings[17];
            DataStrings[18] = FrmVarTable.VarValue[268]; //主功率变化速率[KW/hr]
            Cmd.Parameters.Add("@POWER_RAMP", DbType.String).Value = DataStrings[18];
            DataStrings[19] = FrmVarTable.VarValue[211]; //设定液面温度
            Cmd.Parameters.Add("@MELT_TEMP_SP", DbType.String).Value = DataStrings[19];
            DataStrings[20] = FrmVarTable.VarValue[265];//液面温度[degC]
            Cmd.Parameters.Add("@MELT_TEMP_PV", DbType.String).Value = DataStrings[20];
            DataStrings[21] = FrmVarTable.VarValue[272];//视觉液口距[mm]
            Cmd.Parameters.Add("@MELT_GAP", DbType.String).Value = DataStrings[21];
            DataStrings[22] = FrmVarTable.VarValue[271];//埚跟比[CL/SL]
            Cmd.Parameters.Add("@CL_SL_RATIO", DbType.String).Value = DataStrings[22];
            DataStrings[23] = FrmVarTable.VarValue[155];//埚升速度[mm/hr]
            Cmd.Parameters.Add("@CRUC_LIFT", DbType.String).Value = DataStrings[23];
            DataStrings[24] = FrmVarTable.VarValue[167];//主室压力[torr]
            Cmd.Parameters.Add("@PRESSURE", DbType.String).Value = DataStrings[24];
            DataStrings[25] = FrmVarTable.VarValue[169];//节流阀开度[%]
            Cmd.Parameters.Add("@THROTTLE_TARG", DbType.String).Value = DataStrings[25];
            DataStrings[26] = FrmVarTable.VarValue[165];//氩气流量[slpm]
            Cmd.Parameters.Add("@GAS_FLOW", DbType.String).Value = DataStrings[26];
            DataStrings[27] = FrmVarTable.VarValue[157];//坩埚位置
            Cmd.Parameters.Add("@CRUC_POSITION", DbType.String).Value = DataStrings[27];
            DataStrings[28] = FrmVarTable.VarValue[153];//晶体位置[mm]
            Cmd.Parameters.Add("@SEED_POSITION", DbType.String).Value = DataStrings[28];
            DataStrings[29] = FrmVarTable.VarValue[158];//热屏位置[mm]
            Cmd.Parameters.Add("@SHIELD_POSITION", DbType.String).Value = DataStrings[29];
            DataStrings[30] = FrmVarTable.VarValue[256];//净重[kg]
            Cmd.Parameters.Add("@NET_WEIGHT", DbType.String).Value = DataStrings[30];
            DataStrings[31] = FrmVarTable.VarValue[257];//晶体重量[kg]
            Cmd.Parameters.Add("@CRYSTAL_WEIGHT", DbType.String).Value = DataStrings[31];
            DataStrings[32] = FrmVarTable.VarValue[282];//总重量[kg];
            Cmd.Parameters.Add("@TOTAL_WEIGHT", DbType.String).Value = DataStrings[32];
            DataStrings[33] = FrmVarTable.VarValue[283];//提出重量
            Cmd.Parameters.Add("@PULLOUT_WEIGHT", DbType.String).Value = DataStrings[33];
            DataStrings[34] = FrmVarTable.VarValue[276];//放肩角度[degree]
            Cmd.Parameters.Add("@CROWN_DEGREE", DbType.String).Value = DataStrings[34];
            DataStrings[35] = FrmVarTable.VarValue[172];//水冷屏水温[degC]
            Cmd.Parameters.Add("@SHIELD_TEMP", DbType.String).Value = DataStrings[35];
            DataStrings[36] = FrmVarTable.VarValue[171];//水冷屏水流量[lpm]
            Cmd.Parameters.Add("@SHIELD_FLOW", DbType.String).Value = DataStrings[36];
            DataStrings[37] = FrmVarTable.VarValue[168];//副室压力
            Cmd.Parameters.Add("@PRESSURE_PC", DbType.String).Value = DataStrings[37];
            DataStrings[38] = FrmVarTable.VarValue[160];//主加热器电压
            Cmd.Parameters.Add("@MAIN_VOL", DbType.String).Value = DataStrings[38];
            DataStrings[39] = FrmVarTable.VarValue[163];//底加热器电压
            Cmd.Parameters.Add("@BOTTOM_VOL", DbType.String).Value = DataStrings[39];
            DataStrings[40] = FrmVarTable.VarValue[166];//主室低压力
            Cmd.Parameters.Add("@MAIN_PC", DbType.String).Value = DataStrings[40];
            DataStrings[41] = FrmVarTable.VarValue[170];//热场高温计温度
            Cmd.Parameters.Add("@HTR_H_TEMP", DbType.String).Value = DataStrings[41];
            DataStrings[42] = FrmVarTable.VarValue[173];//主进水压力
            Cmd.Parameters.Add("@MAINW_INPC", DbType.String).Value = DataStrings[42];
            DataStrings[43] = FrmVarTable.VarValue[174];//主出水压力
            Cmd.Parameters.Add("@MAINW_OUTPC", DbType.String).Value = DataStrings[43];
            DataStrings[44] = FrmVarTable.VarValue[175];//副进水压力
            Cmd.Parameters.Add("@AUXI_INPC", DbType.String).Value = DataStrings[44];
            DataStrings[45] = FrmVarTable.VarValue[176];//副出水压力
            Cmd.Parameters.Add("@AUXI_OUTPC", DbType.String).Value = DataStrings[45];
            DataStrings[46] = FrmVarTable.VarValue[177];//左真空管道温度
            Cmd.Parameters.Add("@LPIPE_TEMP", DbType.String).Value = DataStrings[46];
            DataStrings[47] = FrmVarTable.VarValue[178];//波纹管温度
            Cmd.Parameters.Add("@PIPE_TEMP", DbType.String).Value = DataStrings[47];
            DataStrings[48] = FrmVarTable.VarValue[179];//右真空管道温度
            Cmd.Parameters.Add("@RPIPE_TEMP", DbType.String).Value = DataStrings[48];
            DataStrings[49] = FrmVarTable.VarValue[201];//晶升速度设定值
            Cmd.Parameters.Add("@SEED_LIFT_SP", DbType.String).Value = DataStrings[49];
            DataStrings[50] = FrmVarTable.VarValue[202];//晶转速度设定值
            Cmd.Parameters.Add("@SEED_ROTA_SP", DbType.String).Value = DataStrings[50];
            DataStrings[51] = FrmVarTable.VarValue[203];//埚升速度设定值
            Cmd.Parameters.Add("@CRUC_LIFT_SP", DbType.String).Value = DataStrings[51];
            DataStrings[52] = FrmVarTable.VarValue[204];//埚转速度设定值
            Cmd.Parameters.Add("@CRUC_ROTA_SP", DbType.String).Value = DataStrings[52];
            DataStrings[53] = FrmVarTable.VarValue[205];//主加热功率设定值
            Cmd.Parameters.Add("@MAIN_POWER_SP", DbType.String).Value = DataStrings[53];
            DataStrings[54] = FrmVarTable.VarValue[206];//底加热功率设定值
            Cmd.Parameters.Add("@BOTTOM_POWER_SP", DbType.String).Value = DataStrings[54];
            DataStrings[55] = FrmVarTable.VarValue[207];//节流阀开度设定值[%]
            Cmd.Parameters.Add("@THROTTLE_TARG_SP", DbType.String).Value = DataStrings[55];
            DataStrings[56] = FrmVarTable.VarValue[208];//氩气流量设定值
            Cmd.Parameters.Add("@GAS_FLOW_SP", DbType.String).Value = DataStrings[56];
            DataStrings[57] = FrmVarTable.VarValue[209];//副室热屏设定值
            Cmd.Parameters.Add("@AUXI_SHIELD_SP", DbType.String).Value = DataStrings[57];
            DataStrings[58] = FrmVarTable.VarValue[251];//晶转加速度
            Cmd.Parameters.Add("@SEED_ROTA_AC", DbType.String).Value = DataStrings[58];
            DataStrings[59] = FrmVarTable.VarValue[252];//埚转加速度
            Cmd.Parameters.Add("@CRUC_ROTA_AC", DbType.String).Value = DataStrings[59];
            DataStrings[60] = FrmVarTable.VarValue[253];//主加热器电阻
            Cmd.Parameters.Add("@MAIN_R", DbType.String).Value = DataStrings[60];
            DataStrings[61] = FrmVarTable.VarValue[254];//底加热器电阻
            Cmd.Parameters.Add("@BOTTOM_R", DbType.String).Value = DataStrings[61];
            DataStrings[62] = FrmVarTable.VarValue[255];//籽晶熔接位置
            Cmd.Parameters.Add("@SEED_MElT_POSITION", DbType.String).Value = DataStrings[62];
            DataStrings[63] = FrmVarTable.VarValue[260];//设置直径
            Cmd.Parameters.Add("@DIAMETER_SV", DbType.String).Value = DataStrings[63];
            DataStrings[64] = FrmVarTable.VarValue[263];//等径多段长度
            Cmd.Parameters.Add("@D_MULT_LEGHT", DbType.String).Value = DataStrings[64];
            DataStrings[65] = FrmVarTable.VarValue[264];//等径总长度
            Cmd.Parameters.Add("@D_TOTAL_LEGHT", DbType.String).Value = DataStrings[65];
            DataStrings[66] = FrmVarTable.VarValue[273];//熔液深度
            Cmd.Parameters.Add("@MELT_DEPTH", DbType.String).Value = DataStrings[66];
            DataStrings[67] = FrmVarTable.VarValue[274];//重量液口距
            Cmd.Parameters.Add("@MELT_WEIGHT", DbType.String).Value = DataStrings[67];
            DataStrings[68] = FrmVarTable.VarValue[275];//泄漏率
            Cmd.Parameters.Add("@LEAK_RATE", DbType.String).Value = DataStrings[68];
            DataStrings[69] = FrmVarTable.VarValue[277];//加热时间
            Cmd.Parameters.Add("@HEART_TIME", DbType.String).Value = DataStrings[69];
            DataStrings[70] = FrmVarTable.VarValue[278];//倒计时器
            Cmd.Parameters.Add("@COUNTDN_TIME", DbType.String).Value = DataStrings[70];
            DataStrings[71] = FrmVarTable.VarValue[279];//等径整段拉速
            Cmd.Parameters.Add("@B_MULT_SPEED", DbType.String).Value = DataStrings[71];
            DataStrings[72] = FrmVarTable.VarValue[280];//收尾直径
            Cmd.Parameters.Add("@TAIL_D", DbType.String).Value = DataStrings[72];
            DataStrings[73] = FrmVarTable.VarValue[281];//绝对液口距
            Cmd.Parameters.Add("@ABS_MELT_GAP", DbType.String).Value = DataStrings[73];
                DataStrings[74] = FrmVarTable.VarValue[258];//绝对液口距
                Cmd.Parameters.Add("@CENTER_PIXEL_X", DbType.String).Value = DataStrings[74];
                Cmd.ExecuteNonQuery();
            Cmd.CommandText = "DELETE FROM PROCESS_DATA WHERE DATE('NOW', '-30 DAY') >= DATE(DATE_TIME)";
            Cmd.ExecuteNonQuery();
        }
        }
        public static int InsertData(string strSql)
        {
            lock (o)
            {
            string DataSource = string.Format("D:\\LICCS_DB\\{0}.db3", string.Concat("ID_", IdNum.CrystalID));
            if (!File.Exists(DataSource) || !IsComplete) { return -1; }
            Cmd.CommandText = strSql;
            return Cmd.ExecuteNonQuery();
        }
        }
        public static DataTable GetDataTable1(string QueryStr)
        {
            lock (o)
            {
                Cmd.CommandText = QueryStr;
                DataTable dt = new DataTable();
                using (SQLiteDataAdapter sda = new SQLiteDataAdapter(Cmd))
                {
                    sda.Fill(dt);
                }
                return dt;
            }
        }
        public static DataSet GetDataSet(string sql, string strTable)
        {
            lock (o)
            {
            using (SQLiteDataAdapter DataAdapter = new SQLiteDataAdapter(sql, Conn))
            {
                DataSet ds = new DataSet();
                DataAdapter.Fill(ds, strTable);
                return ds;
                }
            }
        }
        public static DataTable GetDataTable(string QueryStr)
        {
            using (SQLiteConnection Conn1 = new SQLiteConnection(LgConnStr))
            {
                if (Conn1.State != ConnectionState.Open)
                {
                    Conn1.Open();
                }
                using (SQLiteCommand Cmd1 = new SQLiteCommand())
                {
                    Cmd1.Connection = Conn1;
                    Cmd1.CommandText = QueryStr;
                    SQLiteDataAdapter sda = new SQLiteDataAdapter(Cmd1);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    return dt;
                }
            }
        }
        public static DataTable GetDataTable(string strConn, string QueryStr)
        {
            using (SQLiteConnection Conn1 = new SQLiteConnection(strConn))
            {
                if (Conn1.State != ConnectionState.Open)
                {
                    Conn1.Open();
                }
                using (SQLiteCommand Cmd1 = new SQLiteCommand())
                {
                    Cmd1.Connection = Conn1;
                    Cmd1.CommandText = QueryStr;
                    SQLiteDataAdapter sda = new SQLiteDataAdapter(Cmd1);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    return dt;
                }
            }
        }
        public static int ExecDataBySql(string strSql)
        {
            using (SQLiteConnection Conn1 = new SQLiteConnection(LgConnStr))
            {
                if (Conn1.State != ConnectionState.Open)
                {
                    Conn1.Open();
                }
                using (SQLiteCommand Cmd1 = new SQLiteCommand())
                {
                    Cmd1.Connection = Conn1;
                    Cmd1.CommandText = strSql;
                    return Cmd1.ExecuteNonQuery();
                }
            }
        }
    }
}
