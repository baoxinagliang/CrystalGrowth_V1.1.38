using CrystalGrowth.AuxFunction;
using CrystalGrowth.AuxFunction.CCD;
using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CrystalGrowth.CrystalCtl
{
    internal partial class FrmVarTable : Form
    {
        public static string[] VarStr;
        public static string[] VarValue;
        public static int[] VarIndex;
        static byte[] StatusIn;
        static byte[] StatusOut;
        public bool SafeProtectOn = false;
        public bool SafeProtectOnFlag = false;
        private FrmVarTable()
        {
            InitializeComponent();
            VarStr = new string[301];
            VarValue = new string[301];
            VarIndex = new int[22];
            StatusIn = new byte[101];
            StatusOut = new byte[51];
        }
        public static FrmVarTable Single;
        public static FrmVarTable CreateInstrance()
        {
            if (Single == null)
            {
                Single = new FrmVarTable();
                Single.FormClosed += Single_FormClosed;
            }
            return Single;
        }
        static void Single_FormClosed(object sender, FormClosedEventArgs e)
        {
            Single = null;
        }
        private void FrmVarTable_Load(object sender, EventArgs e)
        {
            VarValueLoad();//变量值读取
            DataGridView1.Rows.Add(21);
            VarTxtLoad();//读取每列值 
            SelectVarFile();//读取文件参数
            Panel1.Visible = false;
        }
        public void SelectVarFile()
        {
            string[] Lines = File.ReadAllLines(FileHelper.VarTabPath, Encoding.UTF8);
            if (Lines.Length > 0)
            {
                string[] TempVar = Lines[0].Split(new char[] { ' ' });
                int Length = TempVar.Length;
                int ii;
                for (int i = 1; i <= 21; i++)
                {
                    ii = i - 1;
                    if (i <= Length)
                    {
                        VarIndex[i] = Convert.ToInt32(TempVar[ii]);
                        DataGridView1.Rows[ii].Cells[0].Value = VarIndex[i] > 0 ? VarStr[VarIndex[i]] : "";
                        DataGridView1.Rows[ii].Cells[1].Value = VarIndex[i] > 0 ? VarValue[VarIndex[i]] : "";
                    }
                    else
                    {
                        VarIndex[i] = 0;
                        DataGridView1.Rows[ii].Cells[0].Value = "";
                        DataGridView1.Rows[ii].Cells[1].Value = "";
                    }
                }
            }
        }
        public static void SaveVarFile()
        {
            string[] Lines = new string[1];
            StringBuilder sb = new StringBuilder();
            sb.Append(VarIndex[1].ToString());
            for (int i = 2; i <= 21; i++)
            {
                sb.Append(string.Concat(" ", VarIndex[i]));
            }
            Lines[0] = sb.ToString();
            File.WriteAllLines(FileHelper.VarTabPath, Lines);
        }
        private void VarTxtLoad()
        {
            VarStr[1] = "晶升硬限位上";
            VarStr[2] = "晶升硬限位下";
            VarStr[3] = "引晶器点动";
            VarStr[4] = "引晶器快升";
            VarStr[5] = "引晶器快降";
            VarStr[6] = "埚升硬限位上";
            VarStr[7] = "埚升硬限位下";
            VarStr[8] = "埚转驱动器激活";
            VarStr[9] = "晶转驱动器激活";
            VarStr[10] = "热屏提升上限位";
            VarStr[11] = "热屏提升下限位";
            VarStr[12] = "主加热器过流";
            VarStr[13] = "主加热器接地故障(+)";
            VarStr[14] = "主加热器接地故障(-)";
            VarStr[15] = "加热器交流供电";
            VarStr[16] = "加热器开";
            VarStr[17] = "只升副室";
            VarStr[18] = "锁紧环状态";
            VarStr[19] = "炉盖关闭";
            VarStr[20] = "副室升";
            VarStr[21] = "副室降";
            VarStr[22] = "主室升";
            VarStr[23] = "主室降";
            VarStr[24] = "副室左旋转";
            VarStr[25] = "副室右旋转";
            VarStr[26] = "副室左旋转限位";
            VarStr[27] = "副室右旋转限位";
            VarStr[28] = "主室左旋转";
            VarStr[29] = "主室右旋转";
            VarStr[30] = "主室左旋转限位";
            VarStr[31] = "主室右旋转限位";
            VarStr[32] = "副室升限位";
            VarStr[33] = "副室降限位";
            VarStr[34] = "主室升限位";
            VarStr[35] = "主室降限位";
            VarStr[36] = "接晶架升";
            VarStr[37] = "接晶架降";
            VarStr[38] = "紧急备用";
            VarStr[39] = "主真空泵连锁";
            VarStr[40] = "主真空泵开";
            VarStr[41] = "主真空泵报警";
            VarStr[42] = "主真空泵本地/远程";
            VarStr[43] = "主真空泵告警";
            VarStr[44] = "副真空泵开";
            VarStr[45] = "隔离阀板升";
            VarStr[46] = "隔离阀板降";
            VarStr[47] = "隔离阀关";
            VarStr[48] = "隔离阀开";
            VarStr[49] = "籽晶位置传感器";
            VarStr[50] = "籽晶熔接";
            VarStr[51] = "主出水状态";
            VarStr[52] = "水冷屏出水状态";
            VarStr[53] = "备用";
            VarStr[54] = "24V电源状态";
            VarStr[55] = "UPS逆变器工作";
            VarStr[56] = "UPS电池低压";
            VarStr[57] = "UPS市电故障";
            VarStr[58] = "UPS市电稳压输出";
            VarStr[59] = "左真空管道超温";
            VarStr[60] = "右真空管道超温";
            VarStr[61] = "副室超温";
            VarStr[62] = "炉盖超温";
            VarStr[63] = "隔离阀超温";
            VarStr[64] = "隔离阀板超温";
            VarStr[65] = "坩埚轴超温";
            VarStr[66] = "主加热正电极超温";
            VarStr[67] = "主加热负电极超温";
            VarStr[68] = "底加热正电极超温";
            VarStr[69] = "底加热负电极超温";
            VarStr[70] = "上炉室超温";
            VarStr[71] = "下炉室超温";
            VarStr[72] = "炉底盘超温";
            VarStr[73] = "波纹管超温";
            VarStr[74] = "水冷屏超温";
            VarStr[75] = "副室变速限位";
            VarStr[76] = "半升限位";
            VarStr[77] = "提升爪限位夹紧";
            VarStr[78] = "提升爪限位松开";
            VarStr[79] = "液压站压力开关";
            VarStr[80] = "安全气缸上限位";
            VarStr[81] = "安全气缸下限位";
            VarStr[82] = "主室提升爪锁紧限位";
            VarStr[83] = "主室提升爪松开限位";
            VarStr[84] = "主室半升限位";
            VarStr[85] = "副室半升限位";
            VarStr[86] = "副室变速限位";
            VarStr[87] = "主室球阀开限位";
            VarStr[88] = "主室球阀关限位";
            VarStr[89] = "压缩空气开关";
            VarStr[90] = "氩气压力开关";
            VarStr[101] = "PLC状态";
            VarStr[102] = "液压泵使能";
            VarStr[103] = "加热灯闪烁";
            VarStr[104] = "副室升输出";
            VarStr[105] = "副室降输出";
            VarStr[106] = "主室升输出";
            VarStr[107] = "主室降输出";
            VarStr[108] = "主真空阀输出";
            VarStr[109] = "副真空阀输出";
            VarStr[110] = "上氩气阀输出";
            VarStr[111] = "下氩气阀输出";
            VarStr[112] = "副室上快充阀输出";
            VarStr[113] = "副室下快充阀输出";
            VarStr[114] = "燃烧阀输出";
            VarStr[115] = "报警声音";
            VarStr[116] = "红色指示灯";
            VarStr[117] = "黄色指示灯";
            VarStr[118] = "绿色指示灯";
            VarStr[119] = "热屏/副室旋转使能";
            VarStr[120] = "手柄指示灯";
            VarStr[121] = "热屏/副室旋转选择";
            VarStr[122] = "副室/主室旋转选择";
            VarStr[123] = "隔离阀板升输出";
            VarStr[124] = "隔离阀板降输出";
            VarStr[125] = "隔离阀开输出";
            VarStr[126] = "隔离阀关输出";
            VarStr[127] = "接晶架升输出";
            VarStr[128] = "接晶架降输出";
            VarStr[129] = "主真空泵输出";
            VarStr[130] = "液压站副室快升";
            VarStr[131] = "液压站副室快降";
            VarStr[132] = "提升爪限位夹紧输出";
            VarStr[133] = "提升爪限位松开输出";
            VarStr[151] = "晶升速度(mm/hr)";
            VarStr[152] = "晶转速度(rpm)";
            VarStr[153] = "晶体位置(mm)";
            VarStr[154] = "备用4";
            VarStr[155] = "埚升速度(mm/hr)";
            VarStr[156] = "埚转速度(rpm)";
            VarStr[157] = "坩埚位置(mm)";
            VarStr[158] = "热屏位置(mm)";
            VarStr[159] = "主加热器功率(KW)";
            VarStr[160] = "主加热器电压(volts)";
            VarStr[161] = "主加热器电流(amps)";
            VarStr[162] = "底加热器功率(KW)";
            VarStr[163] = "底加热器电压(volts)";
            VarStr[164] = "底加热器电流(amps)";
            VarStr[165] = "氩气流量(slpm)";
            VarStr[166] = "主室低压力(mtorr)";
            VarStr[167] = "主室压力(torr)";
            VarStr[168] = "副室压力(torr)";
            VarStr[169] = PLC.ReadStatus[60] == 0 ? "节流阀开度(%)" : "干泵频率(%)";
            VarStr[170] = "热场高温计温度(degC)";
            VarStr[171] = "水冷屏水流量(lpm)";
            VarStr[172] = "水冷屏水温(degC)";
            VarStr[173] = "主进水压力(kPa)";
            VarStr[174] = "主出水压力(kPa)";
            VarStr[175] = "副进水压力(kPa)";
            VarStr[176] = "副出水压力(kPa)";
            VarStr[177] = "左真空管道温度(degC)";
            VarStr[178] = "波纹管温度(degC)";
            VarStr[179] = "右真空管道温度(degC)";
            VarStr[201] = "晶升速度输出值(mm/hr)";
            VarStr[202] = "晶转速度输出值(rpm)";
            VarStr[203] = "埚升速度输出值(mm/hr)";
            VarStr[204] = "埚转速度输出值(rpm)";
            VarStr[205] = "主加热功率输出值(KW)";
            VarStr[206] = "底加热功率输出值(KW)";
            VarStr[207] = PLC.ReadStatus[60] == 0 ? "节流阀开度输出值(%)" : "干泵频率输出值(%)";
            VarStr[208] = "氩气流量输出值(slpm)";
            VarStr[209] = "副室&热屏输出值(volts)";
            VarStr[210] = "设定热场温度(degC)";
            VarStr[211] = "设定液面温度(degC)";
            VarStr[251] = "晶转加速度(rpm/min)";
            VarStr[252] = "埚转加速度(rpm/min)";
            VarStr[253] = "主加热器电阻(mohm)";
            VarStr[254] = "底加热器电阻(mohm)";
            VarStr[255] = "籽晶熔接位置(mm)";
            VarStr[256] = "净重(kg)";
            VarStr[257] = "晶体重量(kg)";
            VarStr[258] = "圆心像素X";
            VarStr[259] = "剩料重量(kg)";
            VarStr[260] = "设定直径(mm)";
            VarStr[261] = "设定拉速(mm/hr)";
            VarStr[262] = "晶体长度(mm)";
            VarStr[263] = "等径多段长度(mm)";
            VarStr[264] = "等径总长度(mm)";
            VarStr[265] = "液面温度(degC)";
            VarStr[266] = "热场温度(degC)";
            VarStr[267] = "热场温度变化率(degC/hr)";
            VarStr[268] = "主功率变化率(kw/hr)";
            VarStr[269] = "实际直径(mm)";
            VarStr[270] = "生长速度(mm/hr)";
            VarStr[271] = "埚跟比(CL/SL)";
            VarStr[272] = "视觉液口距(mm)";
            VarStr[273] = "熔液深度(mm)";
            VarStr[274] = "重量液口距(mm)";
            VarStr[275] = "泄漏率(mtorr/min)";
            VarStr[276] = "放肩角度(degree)";
            VarStr[277] = "加热时间(hr)";
            VarStr[278] = "倒计时器(s)";
            VarStr[279] = "等径整段拉速(mm/hr)";
            VarStr[280] = "收尾直径(mm)";
            VarStr[281] = "绝对液口距(mm)";
            VarStr[282] = "总重量(kg)";
            VarStr[283] = "提出重量(kg)";
        }
        private static void VarValueLoad()
        {
            StatusIn[1] = PLC.ReadStatusIn[3];      //晶升硬限位上
            StatusIn[2] = PLC.ReadStatusIn[4];      //晶升硬限位下
            StatusIn[3] = PLC.ReadStatusIn[27];     //引晶器点动
            StatusIn[4] = PLC.ReadStatusIn[26];     //引晶器快升
            StatusIn[5] = PLC.ReadStatusIn[28];     //引晶器快降
            StatusIn[6] = PLC.ReadStatusIn[1];      //埚升硬限位上
            StatusIn[7] = PLC.ReadStatusIn[2];      //埚升硬限位下
            StatusIn[8] = PLC.ReadStatusIn[29];     //埚转驱动器激活
            StatusIn[9] = PLC.ReadStatusIn[30];     //晶转驱动器激活
            StatusIn[10] = PLC.ReadStatusIn[31];    //热屏提升上限位
            StatusIn[11] = PLC.ReadStatusIn[32];    //热屏提升下限位
            StatusIn[12] = PLC.PowerStatus[7];      //主加热器过流
            StatusIn[13] = PLC.PowerStatus[8];      //主加热器接地故障[+]
            StatusIn[14] = PLC.PowerStatus[9];      //主加热器接地故障[-]
            StatusIn[15] = PLC.ReadStatusIn[14];    //加热器交流供电
            StatusIn[16] = PLC.ReadStatusIn[13];    //加热器开
            StatusIn[17] = PLC.ReadStatusIn[39];    //只升副室
            StatusIn[18] = PLC.ReadStatusIn[38];    //锁紧环状态
            StatusIn[19] = PLC.ReadStatusIn[59];    //炉盖关闭
            StatusIn[20] = PLC.ReadStatusIn[49];    //副室升
            StatusIn[21] = PLC.ReadStatusIn[50];    //副室降
            StatusIn[22] = PLC.ReadStatusIn[53];    //主室升
            StatusIn[23] = PLC.ReadStatusIn[54];    //主室降
            StatusIn[24] = PLC.ReadStatusIn[57];    //副室左旋转
            StatusIn[25] = PLC.ReadStatusIn[58];    //副室右旋转
            StatusIn[26] = PLC.ReadStatusIn[33];    //副室左旋转限位
            StatusIn[27] = PLC.ReadStatusIn[19];    //副室右旋转限位
            StatusIn[28] = PLC.ReadStatusIn[51];    //主室左旋转
            StatusIn[29] = PLC.ReadStatusIn[52];    //主室右旋转
            StatusIn[30] = PLC.ReadStatusIn[55];    //主室左旋转限位
            StatusIn[31] = PLC.ReadStatusIn[56];    //主室右旋转限位
            StatusIn[32] = PLC.ReadStatusIn[40];    //副室升限位
            StatusIn[33] = PLC.ReadStatusIn[77];    //副室降限位
            StatusIn[34] = PLC.ReadStatusIn[35];    //主室升限位
            StatusIn[35] = PLC.ReadStatusIn[76];    //主室降限位
            StatusIn[36] = PLC.ReadStatusIn[45];    //接晶架升
            StatusIn[37] = PLC.ReadStatusIn[46];    //接晶架降
            StatusIn[38] = PLC.ReadStatusIn[25];    //紧急备用
            StatusIn[39] = PLC.ReadStatusIn[22];    //主真空泵连锁
            StatusIn[40] = PLC.ReadStatusIn[15];    //主真空泵开
            StatusIn[41] = PLC.ReadStatusIn[66];    //主真空泵报警
            StatusIn[42] = PLC.ReadStatusIn[67];    //主真空泵本地/远程
            StatusIn[43] = PLC.ReadStatusIn[68];    //主真空泵告警
            StatusIn[44] = PLC.ReadStatusIn[16];    //副真空泵开
            StatusIn[45] = PLC.ReadStatusIn[47];    //隔离阀板升
            StatusIn[46] = PLC.ReadStatusIn[48];    //隔离阀板降
            StatusIn[47] = PLC.ReadStatusIn[34];    //隔离阀关
            StatusIn[48] = PLC.ReadStatusIn[36];    //隔离阀开
            StatusIn[49] = PLC.ReadStatusIn[42];    //籽晶位置传感器
            StatusIn[50] = PLC.ReadStatusIn[20];    //籽晶熔接
            StatusIn[51] = PLC.ReadStatusIn[73];    //主出水状态
            StatusIn[52] = PLC.ReadStatusIn[74];    //水冷屏出水状态
            StatusIn[53] = 0; //压缩空气压力低
            StatusIn[54] = PLC.ReadStatusIn[21];    //24V电源状态
            StatusIn[55] = PLC.ReadStatusIn[61];    //UPS逆变器工作
            StatusIn[56] = PLC.ReadStatusIn[62];    //UPS电池低压
            StatusIn[57] = PLC.ReadStatusIn[63];    //UPS市电故障
            StatusIn[58] = PLC.ReadStatusIn[64];    //UPS市电稳压输出   
            StatusIn[59] = PLC.ReadStatusIn[71];    //左真空管道超温
            StatusIn[60] = PLC.ReadStatusIn[72];    //右真空管道超温
            StatusIn[61] = PLC.ReadStatusIn[37];    //副室超温
            StatusIn[62] = PLC.ReadStatusIn[41];    //炉盖超温
            StatusIn[63] = PLC.ReadStatusIn[43];    //隔离阀超温
            StatusIn[64] = PLC.ReadStatusIn[44];    //隔离阀板超温
            StatusIn[65] = PLC.ReadStatusIn[24];    //坩埚轴超温
            StatusIn[66] = PLC.ReadStatusIn[6];     //主加热正电极超温
            StatusIn[67] = PLC.ReadStatusIn[10];    //主加热负电极超温
            StatusIn[68] = PLC.ReadStatusIn[9];     //底加热正电极超温
            StatusIn[69] = PLC.ReadStatusIn[5];     //底加热负电极超温
            StatusIn[70] = PLC.ReadStatusIn[79];    //上炉室超温
            StatusIn[71] = PLC.ReadStatusIn[75];    //下炉室超温
            StatusIn[72] = PLC.ReadStatusIn[12];    //炉底盘超温
            StatusIn[73] = PLC.ReadStatusIn[80];    //波纹管超温
            StatusIn[74] = PLC.ReadStatusIn[70];    //水冷屏超温
            StatusIn[75] = PLC.ReadStatusIn[95];    //副室变速限位
            StatusIn[76] = PLC.ReadStatusIn[93];    //半升限位
            StatusIn[77] = PLC.ReadStatusIn[84];    //提升爪限位夹紧
            StatusIn[78] = PLC.ReadStatusIn[87];    //提升爪限位松开
            StatusIn[79] = PLC.ReadStatusIn[98];    //液压站压力开关
            StatusIn[80] = PLC.ReadStatusIn[81];    //安全气缸上限位
            StatusIn[81] = PLC.ReadStatusIn[82];    //安全气缸下限位
            StatusIn[82] = PLC.ReadStatusIn[84];    //主室提升爪锁紧限位
            StatusIn[83] = PLC.ReadStatusIn[87];    //主室提升爪松开限位
            StatusIn[84] = PLC.ReadStatusIn[92];    //主室半升限位
            StatusIn[85] = PLC.ReadStatusIn[93];    //副室半升限位
            StatusIn[86] = PLC.ReadStatusIn[95];    //副室变速限位
            StatusIn[87] = PLC.ReadStatusIn[96];    //主室球阀开限位
            StatusIn[88] = PLC.ReadStatusIn[97];    //主室球阀关限位
            StatusIn[89] = PLC.ReadStatusIn[17];    //压缩空气开关
            StatusIn[90] = PLC.ReadStatusIn[103];   //氩气压力开关
            for (int i = 1; i <= 100; i++)
            {
                VarValue[i] = StatusIn[i] == 1 ? "ON" : "OFF";
            }
            StatusOut[1] = PLC.ReadStatusOut[2];    //PLC状态
            StatusOut[2] = PLC.ReadStatusOut[3];    //液压泵使能
            StatusOut[3] = PLC.ReadStatusOut[4];    //加热灯闪烁
            StatusOut[4] = PLC.ReadStatusOut[5];    //副室升输出
            StatusOut[5] = PLC.ReadStatusOut[6];    //副室降输出
            StatusOut[6] = PLC.ReadStatusOut[7];    //主室升输出
            StatusOut[7] = PLC.ReadStatusOut[8];    //主室降输出
            StatusOut[8] = PLC.ReadStatusOut[9];    //主真空阀输出
            StatusOut[9] = PLC.ReadStatusOut[10];   //副真空阀输出
            StatusOut[10] = PLC.ReadStatusOut[14];  //上氩气阀输出
            StatusOut[11] = PLC.ReadStatusOut[13];  //下氩气阀输出
            StatusOut[12] = PLC.ReadStatusOut[17];  //副室上快充阀输出
            StatusOut[13] = PLC.ReadStatusOut[19];  //副室下快充阀输出
            StatusOut[14] = PLC.ReadStatusOut[18];  //燃烧阀输出
            StatusOut[15] = PLC.ReadStatusOut[25];  //报警声音
            StatusOut[16] = PLC.ReadStatusOut[28];  //红色指示灯
            StatusOut[17] = PLC.ReadStatusOut[29];  //黄色指示灯
            StatusOut[18] = PLC.ReadStatusOut[30];  //绿色指示灯
            StatusOut[19] = PLC.ReadStatusOut[33];  //热屏/副室旋转使能
            StatusOut[20] = PLC.ReadStatusOut[34];  //手柄指示灯
            StatusOut[21] = PLC.ReadStatusOut[35];  //热屏/副室旋转选择
            StatusOut[22] = PLC.ReadStatusOut[36];  //副室/主室旋转选择
            StatusOut[23] = PLC.ReadStatusOut[39];  //隔离阀板升输出
            StatusOut[24] = PLC.ReadStatusOut[40];  //隔离阀板降输出
            StatusOut[25] = PLC.ReadStatusOut[41];  //隔离阀开输出
            StatusOut[26] = PLC.ReadStatusOut[42];  //隔离阀关输出
            StatusOut[27] = PLC.ReadStatusOut[43];  //接晶架升输出
            StatusOut[28] = PLC.ReadStatusOut[44];  //接晶架降输出
            StatusOut[29] = PLC.ReadStatusOut[11];  //主真空泵输出
            StatusOut[30] = PLC.ReadStatusOut[52];  //液压站副室快升
            StatusOut[31] = PLC.ReadStatusOut[53];  //液压站副室快降
            StatusOut[32] = PLC.ReadStatusOut[23];  //提升爪限位夹紧输出
            StatusOut[33] = PLC.ReadStatusOut[24];  //提升爪限位松开输出
            for (int i = 1; i <= 50; i++)
            {
                VarValue[100 + i] = StatusOut[i] == 1 ? "ON" : "OFF";
            }
            VarValue[151] = Math.Round(PLC.ReadValue[49], 1).ToString("f1");            //晶升速度[mm/hr]
            VarValue[152] = Math.Round(PLC.ReadValue[51], 1).ToString("f1");            //晶转速度[rpm]
            VarValue[153] = Math.Round(PLC.ReadAnalogValue[35], 1).ToString("f1");      //晶体位置[mm]
            //VarValue[154] = FrmMain.RealToTxt2[Math.Round[FrmMain.ReadAnalogValue[40], 2]]//原始重量[kg]
            VarValue[154] = "0";
            VarValue[155] = Math.Round(PLC.ReadValue[54], 1).ToString("f1");            //埚升速度[mm/hr]
            VarValue[156] = Math.Round(PLC.ReadValue[56], 1).ToString("f1");            //埚转速度[rpm]
            VarValue[157] = Math.Round(PLC.ReadAnalogValue[36], 1).ToString("f1");      //坩埚位置[mm]
            VarValue[158] = Math.Round(PLC.ReadAnalogValue[37], 1).ToString("f1");      //热屏位置[mm]
            VarValue[159] = Math.Round(PLC.PowerValue[3], 2).ToString("f2");            //主加热器功率[KW]
            VarValue[160] = Math.Round(PLC.PowerValue[4], 1).ToString("f1");            //主加热器电压[volts]
            VarValue[161] = Math.Round(PLC.PowerValue[5], 1).ToString("f1");            //主加热器电流[amps]
            VarValue[162] = Math.Round(PLC.PowerValue[7], 2).ToString("f2");            //底加热器功率[KW]
            VarValue[163] = Math.Round(PLC.PowerValue[8], 1).ToString("f1");            //底加热器电压[volts]
            VarValue[164] = Math.Round(PLC.PowerValue[9], 1).ToString("f1");            //底加热器电流[amps]
            VarValue[165] = Math.Round(PLC.ReadAnalogValue[1], 1).ToString("f1");       //氩气流量[slpm]
            VarValue[166] = Math.Round(PLC.ReadAnalogValue[4], 1).ToString("f1");       //主室低压力[mtorr]
            VarValue[167] = Math.Round(PLC.ReadAnalogValue[5], 1).ToString("f1");       //主室压力[torr]
            VarValue[168] = Math.Round(PLC.ReadAnalogValue[7], 1).ToString("f1");       //副室压力[torr]
            VarValue[169] = Math.Round(PLC.ReadAnalogValue[6], 1).ToString("f1");       //节流阀开度[%]
            VarValue[170] = Math.Round(PLC.ReadAnalogValue[38], 1).ToString("f1");      //热场高温计温度[degC]
            VarValue[171] = Math.Round(PLC.ReadAnalogValue[43], 1).ToString("f1");      //水冷屏水流量[lpm]
            VarValue[172] = Math.Round(PLC.ReadAnalogValue[44], 1).ToString("f1");      //水冷屏水温[degC]
            VarValue[173] = Math.Round(PLC.ReadAnalogValue[27], 1).ToString("f1");      //主进水压力[kPa]
            VarValue[174] = Math.Round(PLC.ReadAnalogValue[28], 1).ToString("f1");      //主出水压力[kPa]
            VarValue[175] = Math.Round(PLC.ReadAnalogValue[41], 1).ToString("f1");      //副进水压力[kPa]
            VarValue[176] = Math.Round(PLC.ReadAnalogValue[42], 1).ToString("f1");      //副出水压力[kPa] 
            VarValue[177] = Math.Round(PLC.ReadAnalogValue[47], 1).ToString("f1");      //左真空管道温度(degC)
            VarValue[178] = Math.Round(PLC.ReadAnalogValue[48], 1).ToString("f1");      //波纹管温度 (degC)
            VarValue[179] = Math.Round(PLC.ReadAnalogValue[49], 1).ToString("f1");      //右真空管道温度(degC
            VarValue[201] = Math.Round(PLC.ReadValue[3], 1).ToString("f1");             //晶升速度输出值[mm/hr]
            VarValue[202] = Math.Round(PLC.ReadValue[50], 1).ToString("f1");            //晶转速度输出值[rpm]
            VarValue[203] = Math.Round(PLC.ReadValue[37], 1).ToString("f1");            //埚升速度输出值[mm/hr]
            VarValue[204] = Math.Round(PLC.ReadValue[55], 1).ToString("f1");            //埚转速度输出值[rpm]
            VarValue[205] = Math.Round(PLC.ReadValue[23], 1).ToString("f1");            //主加热功率输出值[KW]
            VarValue[206] = Math.Round(PLC.ReadValue[53], 1).ToString("f1");            //底加热功率输出值[KW]
            VarValue[207] = Math.Round(PLC.ReadAnalogValue[24], 1).ToString("f1");      //节流阀开度输出值[%]
            VarValue[208] = Math.Round(PLC.ReadAnalogValue[25], 1).ToString("f1");      //氩气流量输出值[slpm]
            VarValue[209] = Math.Round(PLC.ReadAnalogValue[26], 1).ToString("f1");      //副室热屏输出值[Volts]
            VarValue[210] = Math.Round(PLC.ReadValue[11], 1).ToString("f1");           //设定热场温度[degC]
            VarValue[211] = Math.Round(PLC.ReadValue[31], 1).ToString("f1");             //液面温度设定值[degC]
            VarValue[251] = Math.Round(PLC.ReadValue[52], 1).ToString("f1");            //晶转加速度[rpm/min]
            VarValue[252] = Math.Round(PLC.ReadValue[57], 1).ToString("f1");            //埚转加速度[rpm/min]
            VarValue[253] = Math.Round(PLC.ReadCalcValue[15], 1).ToString("f1");        //主加热器电阻[mohm]
            VarValue[254] = Math.Round(PLC.ReadCalcValue[16], 1).ToString("f1");        //底加热器电阻[mohm]
            VarValue[255] = Math.Round(PLC.ReadCalcValue[2], 1).ToString("f1");         //籽晶熔接位置[mm]
            VarValue[256] = Math.Round(PLC.ReadValue[70], 2).ToString("f2");            //净重[kg]
            VarValue[257] = Math.Round(PLC.ReadCalcValue[8], 2).ToString("f2");         //晶体重量[kg]
            CLSLParas.CrystalQuality = Convert.ToSingle(VarValue[257]);
            VarValue[258] = Math.Round(PLC.ReadOthersValue[74], 2).ToString("f2");             //圆心像素X;
            VarValue[259] = Math.Round(PLC.ReadCalcValue[10], 2).ToString("f2");        //剩余重量[kg]
            VarValue[260] = Math.Round(PLC.ReadValue[6], 2).ToString("f2");             //设定直径[mm]
            VarValue[261] = Math.Round(PLC.ReadValue[15], 1).ToString("f1");            //设定拉速[mm/hr]
            VarValue[262] = Math.Round(PLC.ReadCalcValue[14], 1).ToString("f1");        //晶体长度[mm]
            CLSLParas.CrystalLength = Convert.ToSingle(VarValue[262]);
            VarValue[263] = Math.Round(PLC.ReadCalcValue[22], 1).ToString("f1");        //等径多段长度[mm]
            VarValue[264] = Math.Round(PLC.ReadCalcValue[13], 1).ToString("f1");        //等径总长度[mm]
            VarValue[265] = Math.Round(PLC.ReadValue[32], 1).ToString("f1");            //液面温度[degC]
            VarValue[266] = Math.Round(PLC.ReadValue[12], 1).ToString("f1");            //热场温度[degC]
            VarValue[267] = Math.Round(PLC.ReadValue[21], 1).ToString("f1");            //热场温度变化速率[degC/hr]
            VarValue[268] = Math.Round(PLC.ReadValue[20], 2).ToString("f2");            //主功率变化速率[KW/hr]
            VarValue[269] = Math.Round(PLC.ReadValue[7], 2).ToString("f2");             //实际直径[mm]
            VarValue[270] = Math.Round(PLC.ReadValue[16], 1).ToString("f1");            //生长速度[mm/hr]
            VarValue[271] = Math.Round(PLC.ReadValue[45], 3).ToString("f3");            //埚跟比[CL/SL]
            VarValue[272] = Math.Round(PLC.ReadCalcValue[24], 1).ToString("f1");        //视觉液口距[mm]
            VarValue[273] = Math.Round(PLC.ReadCalcValue[4], 1).ToString("f1");         //熔液深度[mm]
            VarValue[274] = Math.Round(PLC.ReadCalcValue[1], 1).ToString("f1");         //重量液口距[mm]
            VarValue[275] = Math.Round(PLC.ReadCalcValue[17], 1).ToString("f1");        //泄漏率[mtorr/min]
            VarValue[276] = Math.Round(PLC.ReadCalcValue[21], 1).ToString("f1");        //放肩角度[degree]
            VarValue[277] = Math.Round(PLC.PowerValue[10], 1).ToString("f1");           //加热时间[hr]
            VarValue[278] = Math.Round(FrmTimer.TimerValReal, 1).ToString("f1");        //倒计时时间[s]
            VarValue[279] = Math.Round(PLC.ReadCalcValue[23], 1).ToString("f1");        //等径整段拉速[mm/hr]"
            VarValue[280] = CLSLParas.TailDiameter.ToString("f1");                      //收尾直径
            VarValue[281] = (FrmImage.AbsMeltGapAvg).ToString("f1");  // FrmImage.AbsMeltDist.ToString("f1");                        //绝对液口距
            VarValue[282] = Math.Round(PLC.ReadCalcValue[11], 2).ToString("f2");        //总重量
            VarValue[283] = Math.Round(PLC.ReadCalcValue[9], 2).ToString("f2");         //提出重量
        }
        private void DataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (SafeProtectOn == false)
            {
                Hide();
                FrmSwitch.Open(FrmImage.Single, 200, new Point(638, 225), new Size(650, 475));
                FrmImage.SizeValue1 = new Size(650, 475);
                FrmImage.SizeValue2Change();
                FrmImage.Single.Visible = true;
            }
        }
        private void SafeProtect()
        {
            if (SafeProtectOn == false)
            {
                if (PLC.ReadStatus[80] == 1 || PLC.ReadStatus[81] == 1 || PLC.ReadStatus[82] == 1)
                {
                    SafeProtectOn = true;
                    //Panel1.Visible = true;
                    if (FrmMain.Single.BtnFurnaceCtl.BackColor != Color.DarkSlateGray || FrmMain.Single.BtnMagnetic.BackColor == Color.Red)
                    {
                        FrmSwitch.OpenAutoForm();
                    }
                    if (Visible == false)
                    {
                        FrmImage.Single.Hide();
                        FrmMeltGapPopUp.Visible1 = false;
                        FrmSwitch.Open(this, 0, new Point(638, 200), new Size(636, 485));
                        Show();
                    }
                }
            }
            else
            {
                if (PLC.ReadStatus[80] == 0 && PLC.ReadStatus[81] == 0 && PLC.ReadStatus[82] == 0)
                {
                    SafeProtectOn = false;
                    // Panel1.Visible = false;
                }
            }
            if (SafeProtectOn)
            {
                if (SafeProtectOnFlag == false)
                {
                    SafeProtectOnFlag = true;
                    FrmSaveProtected fsp = new FrmSaveProtected();
                    fsp.ShowDialog();
                }
            }
            else
            {
                SafeProtectOnFlag = false;
            }

        }
        private void BtnErrHandle_Click(object sender, EventArgs e)
        {
            if (BtnAckSafe.BackColor == Color.Blue)
            {
                BtnErrHandle.BackColor = Color.Red;
                BtnAck.Visible = true;
                BtnCancel.Visible = true;
            }
        }
        private void BtnAckSafe_Click(object sender, EventArgs e)
        {
            if (BtnErrHandle.BackColor == Color.Blue)
            {
                BtnAckSafe.BackColor = Color.Red;
                BtnAck.Visible = true;
                BtnCancel.Visible = true;
            }
        }
        private void BtnAck_Click(object sender, EventArgs e)
        {
            if (PLC.ReadStatus[81] == 1)//停水保护
            {
                if (BtnErrHandle.BackColor == Color.Red)
                {
                    PLC.SendBit(30, 110, 1);
                }
                if (BtnAckSafe.BackColor == Color.Red)
                {
                    PLC.SendBit(30, 111, 1);
                }
            }
            else if (PLC.ReadStatus[82] == 1)  //炉压异常
            {
                if (BtnErrHandle.BackColor == Color.Red)
                {
                    PLC.SendBit(30, 112, 1);
                }
                if (BtnAckSafe.BackColor == Color.Red)
                {
                    PLC.SendBit(30, 113, 1);
                }
            }
            else if (PLC.ReadStatus[80] == 1) //停电保护
            {
                if (BtnErrHandle.BackColor == Color.Red)
                {
                    PLC.SendBit(30, 108, 1);
                }
                if (BtnAckSafe.BackColor == Color.Red)
                {
                    PLC.SendBit(30, 109, 1);
                }
            }
            if (BtnErrHandle.BackColor == Color.Red)
            {
                BtnErrHandle.BackColor = Color.Blue;
            }
            if (BtnAckSafe.BackColor == Color.Red)
            {
                BtnAckSafe.BackColor = Color.Blue;
            }
            BtnAck.Visible = false;
            BtnCancel.Visible = false;
            SafeProtectOn = false;
            Panel1.Visible = false;
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (BtnErrHandle.BackColor == Color.Red)
            {
                BtnErrHandle.BackColor = Color.Blue;
            }
            if (BtnAckSafe.BackColor == Color.Red)
            {
                BtnAckSafe.BackColor = Color.Blue;
            }
            BtnAck.Visible = false;
            BtnCancel.Visible = false;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            VarValueLoad();//变量值读取
            VarVal();
            SafeProtect();
        }
        private void VarVal()
        {
            int ii;
            for (int i = 1; i <= 21; i++)
            {
                ii = i - 1;
                DataGridView1.Rows[ii].Cells[0].Value = VarIndex[i] > 0 ? VarStr[VarIndex[i]] : "";
                DataGridView1.Rows[ii].Cells[1].Value = VarIndex[i] > 0 ? VarValue[VarIndex[i]] : "";
            }
        }
    }
}
