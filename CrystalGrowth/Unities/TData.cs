using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CrystalGrowth.Unities
{
    internal class PointD
    {
        public List<double> X = new List<double>();
        public List<double> Y = new List<double>();
    }
    internal struct SelValue
    {
        public int Index;
        public string Name;
        public string Value;
        public string Min;
        public string Max;
    }
    internal class LimitPara
    {
        public string Min;
        public string Max;
    }
    internal class Para
    {
        public string Num;
        public string Name;
    }
    internal class TData
    {
        public static PointD[] CurvePt = { new PointD(), new PointD(), new PointD(), new PointD(), new PointD() };
        public static Dictionary<string, Para> Paras = new Dictionary<string, Para>();
        public static Dictionary<string, LimitPara> LimitValue = new Dictionary<string, LimitPara>();
        public static SelValue[] SelValue = new SelValue[5];
        public TData()
        {
            Paras.Add("日期时间", new Para() { Num = "", Name = "DATE_TIME" });
            Paras.Add("晶体编号", new Para() { Num = "", Name = "CRYSTAL_NUMBER" });
            Paras.Add("状态", new Para() { Num = "", Name = "STATE" });
            Paras.Add("主加热器功率(KW)", new Para() { Num = "159", Name = "MAIN_POWER" });
            Paras.Add("晶体长度(mm)", new Para() { Num = "262", Name = "CRYSTAL_LENGTH" });
            Paras.Add("剩料重量(kg)", new Para() { Num = "259", Name = "REMAIN_WEIGHT" });
            Paras.Add("生长速度(mm/hr)", new Para() { Num = "270", Name = "GROWTH_RATE_PV" });
            Paras.Add("设定拉速(mm/hr)", new Para() { Num = "261", Name = "GROWTH_RATE_SP" });
            Paras.Add("实际直径(mm)", new Para() { Num = "269", Name = "DIAMETER" });
            Paras.Add("晶转速度(rpm)", new Para() { Num = "152", Name = "SEED_ROTATION" });
            Paras.Add("埚转速度(rpm)", new Para() { Num = "156", Name = "CRUC_ROTATION" });
            Paras.Add("晶升速度(mm/hr)", new Para() { Num = "151", Name = "SEED_LIFT" });
            Paras.Add("设定热场温度(degC)", new Para() { Num = "210", Name = "HTR_TEMP_SP" });
            Paras.Add("热场温度(degC)", new Para() { Num = "266", Name = "HTR_TEMP_PV" });
            Paras.Add("主加热器电流(amps)", new Para() { Num = "161", Name = "MAIN_CURRENT" });
            Paras.Add("底加热器功率(KW)", new Para() { Num = "162", Name = "BOTTOM_POWER" });
            Paras.Add("底加热器电流(amps)", new Para() { Num = "164", Name = "BOTTOM_CURRENT" });
            Paras.Add("热场温度变化率(degC/hr)", new Para() { Num = "267", Name = "TEMP_RAMP" });
            Paras.Add("主功率变化率(kw/hr)", new Para() { Num = "268", Name = "POWER_RAMP" });
            Paras.Add("设定液面温度(degC)", new Para() { Num = "211", Name = "MELT_TEMP_SP" });
            Paras.Add("液面温度(degC)", new Para() { Num = "265", Name = "MELT_TEMP_PV" });
            Paras.Add("视觉液口距(mm)", new Para() { Num = "272", Name = "MELT_GAP" });
            Paras.Add("埚跟比(CL/SL)", new Para() { Num = "271", Name = "CL_SL_RATIO" });
            Paras.Add("埚升速度(mm/hr)", new Para() { Num = "155", Name = "CRUC_LIFT" });
            Paras.Add("主室压力(torr)", new Para() { Num = "167", Name = "PRESSURE" });
            if (PLC.ReadStatus[60] == 0)
            {
                Paras.Add("节流阀开度(%)", new Para() { Num = "169", Name = "THROTTLE_TARG" });
            }
            else
            {
                Paras.Add("干泵频率(%)", new Para() { Num = "169", Name = "THROTTLE_TARG" });
            }
            Paras.Add("氩气流量(slpm)", new Para() { Num = "165", Name = "GAS_FLOW" });
            Paras.Add("坩埚位置(mm)", new Para() { Num = "157", Name = "CRUC_POSITION" });
            Paras.Add("晶体位置(mm)", new Para() { Num = "153", Name = "SEED_POSITION" });
            Paras.Add("热屏位置(mm)", new Para() { Num = "158", Name = "SHIELD_POSITION" });
            Paras.Add("净重(kg)", new Para() { Num = "256", Name = "NET_WEIGHT" });
            Paras.Add("晶体重量(kg)", new Para() { Num = "257", Name = "CRYSTAL_WEIGHT" });
            Paras.Add("总重量(kg)", new Para() { Num = "282", Name = "TOTAL_WEIGHT" });
            Paras.Add("提出重量(kg)", new Para() { Num = "283", Name = "PULLOUT_WEIGHT" });
            Paras.Add("放肩角度(degree)", new Para() { Num = "276", Name = "CROWN_DEGREE" });
            Paras.Add("水冷屏水温(degC)", new Para() { Num = "172", Name = "SHIELD_TEMP" });
            Paras.Add("水冷屏水流量(lpm)", new Para() { Num = "171", Name = "SHIELD_FLOW" });
            Paras.Add("副室压力(torr)", new Para() { Num = "168", Name = "PRESSURE_PC" });
            Paras.Add("主加热器电压(volts)", new Para() { Num = "160", Name = "MAIN_VOL" });
            Paras.Add("底加热器电压(volts)", new Para() { Num = "163", Name = "BOTTOM_VOL" });
            Paras.Add("主室低压力(mtorr)", new Para() { Num = "166", Name = "MAIN_PC" });
            Paras.Add("热场高温计温度(degC)", new Para() { Num = "170", Name = "HTR_H_TEMP" });
            Paras.Add("主进水压力(kPa)", new Para() { Num = "173", Name = "MAINW_INPC" });
            Paras.Add("主出水压力(kPa)", new Para() { Num = "174", Name = "MAINW_OUTPC" });
            Paras.Add("副进水压力(kPa)", new Para() { Num = "175", Name = "AUXI_INPC" });
            Paras.Add("副出水压力(kPa)", new Para() { Num = "176", Name = "AUXI_OUTPC" });
            Paras.Add("左真空管道温度(degC)", new Para() { Num = "177", Name = "LPIPE_TEMP" });
            Paras.Add("波纹管温度(degC)", new Para() { Num = "178", Name = "PIPE_TEMP" });
            Paras.Add("右真空管道温度(degC)", new Para() { Num = "179", Name = "RPIPE_TEMP" });
            Paras.Add("晶升速度输出值(mm/hr)", new Para() { Num = "201", Name = "SEED_LIFT_SP" });
            Paras.Add("晶转速度输出值(rpm)", new Para() { Num = "202", Name = "SEED_ROTA_SP" });
            Paras.Add("埚升速度输出值(mm/hr)", new Para() { Num = "203", Name = "CRUC_LIFT_SP" });
            Paras.Add("埚转速度输出值(rpm)", new Para() { Num = "204", Name = "CRUC_ROTA_SP" });
            Paras.Add("主加热功率输出值(KW)", new Para() { Num = "205", Name = "MAIN_POWER_SP" });
            Paras.Add("底加热功率输出值(KW)", new Para() { Num = "206", Name = "BOTTOM_POWER_SP" });
            if (PLC.ReadStatus[60] == 0)
            {
                Paras.Add("节流阀开度输出值(%)", new Para() { Num = "207", Name = "THROTTLE_TARG_SP" });
            }
            else
            {
                Paras.Add("干泵频率输出值(%)", new Para() { Num = "207", Name = "THROTTLE_TARG_SP" });
            }
            Paras.Add("氩气流量输出值(slpm)", new Para() { Num = "208", Name = "GAS_FLOW_SP" });
            Paras.Add("副室&热屏输出值(volts)", new Para() { Num = "209", Name = "AUXI_SHIELD_SP" });
            Paras.Add("晶转加速度(rpm/min)", new Para() { Num = "251", Name = "SEED_ROTA_AC" });
            Paras.Add("埚转加速度(rpm/min)", new Para() { Num = "252", Name = "CRUC_ROTA_AC" });
            Paras.Add("主加热器电阻(mohm)", new Para() { Num = "253", Name = "MAIN_R" });
            Paras.Add("底加热器电阻(mohm)", new Para() { Num = "254", Name = "BOTTOM_R" });
            Paras.Add("籽晶熔接位置(mm)", new Para() { Num = "255", Name = "SEED_MElT_POSITION" });
            Paras.Add("设定直径(mm)", new Para() { Num = "260", Name = "DIAMETER_SV" });
            Paras.Add("等径多段长度(mm)", new Para() { Num = "263", Name = "D_MULT_LEGHT" });
            Paras.Add("等径总长度(mm)", new Para() { Num = "264", Name = "D_TOTAL_LEGHT" });
            Paras.Add("熔液深度(mm)", new Para() { Num = "273", Name = "MELT_DEPTH" });
            Paras.Add("重量液口距(mm)", new Para() { Num = "274", Name = "MELT_WEIGHT" });
            Paras.Add("泄漏率(mtorr/min)", new Para() { Num = "275", Name = "LEAK_RATE" });
            Paras.Add("加热时间(hr)", new Para() { Num = "277", Name = "HEART_TIME" });
            Paras.Add("倒计时器(s)", new Para() { Num = "278", Name = "COUNTDN_TIME" });
            Paras.Add("等径整段拉速(mm/hr)", new Para() { Num = "279", Name = "B_MULT_SPEED" });
            Paras.Add("收尾直径(mm)", new Para() { Num = "280", Name = "TAIL_D" });
            Paras.Add("绝对液口距(mm)", new Para() { Num = "281", Name = "ABS_MELT_GAP" });
            Paras.Add("圆心像素X", new Para() { Num = "258", Name = "CENTER_PIXEL_X" });

            ReadLimitValue();
        }
        public static void ReadLimitValue()
        {
            string[] Lines = File.ReadAllLines(FileHelper.LimitValPath, Encoding.UTF8);
            int Length = Lines.Length;
            string[] StrArray;
            char[] SplitChar1 = new char[] { ',' };
            if (Length > 0)
            {
                for (int i = 0; i < Length; i++)
                {
                    StrArray = Lines[i].Split(SplitChar1);
                    LimitValue.Add(StrArray[0], new LimitPara() { Min = StrArray[1], Max = StrArray[2] });
                }
            }
        }
        public static void WriteLimitValue(string Value, int RowNum, int ColumnNum)
        {
            if (string.IsNullOrEmpty(Value) || RowNum < 0) return;
            switch (ColumnNum)
            {
                case 2:
                    LimitValue[SelValue[RowNum].Name].Min = Value;
                    SelValue[RowNum].Min = Value;
                    break;
                case 3:
                    LimitValue[SelValue[RowNum].Name].Max = Value;
                    SelValue[RowNum].Max = Value;
                    break;
            }
        }
        public static void SaveLimitValue()
        {
            string[] Lines = File.ReadAllLines(FileHelper.LimitValPath, Encoding.UTF8);
            int Length = Lines.Length;
            string[] TempVar;
            char[] SplitChar = new char[] { ',' };
            for (int i = 0; i < Length; i++)
            {
                TempVar = Lines[i].Split(SplitChar);
                Lines[i] = string.Format("{0},{1},{2}", TempVar[0], LimitValue[TempVar[0]].Min, LimitValue[TempVar[0]].Max);
            }
            File.WriteAllLines(FileHelper.LimitValPath, Lines, Encoding.UTF8);
        }
        public static void SaveVarFile()
        {
            string[] Lines = new string[1];
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 5; i++)
            {
                sb.Append(string.Concat(Paras[SelValue[i].Name].Num, " "));
            }
            Lines[0] = sb.ToString().TrimEnd(' ');
            File.WriteAllLines(FileHelper.HisSelPath, Lines);
        }
    }
}
