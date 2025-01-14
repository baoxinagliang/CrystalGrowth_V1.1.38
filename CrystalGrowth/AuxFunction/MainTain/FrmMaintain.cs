using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction.MainTain
{
    internal partial class FrmMaintain : Form
    {
        private Label LastLabel; // 记录当前选定的Label
        private int DataType = 0;// 用于指示表格刷新时应该刷新哪部分数据
        private readonly int[] DataAddr;  // 属性地址列表
        private readonly int[] AnalogType;// 指示模拟量类型
        private int DataNum = 0;
        private readonly bool[] DataValid;// 表示某位置是否为bool量属性，false代表该位置是bool量
        private readonly string[] DataStr;// 属性名列表
        public FrmMaintain()
        {
            InitializeComponent();
            DataStr = new string[33];
            DataAddr = new int[33];
            DataValid = new bool[33];
            AnalogType = new int[33];
            DataGridView1.Rows.Add(32);
            LastLabel = CPU1_0;
            Load += Timer1_Tick;
        }
        private void FrmMaintain_Load(object sender, EventArgs e)
        {
            CPU1_0.BackColor = Color.Black;
            CPU1_0.ForeColor = Color.White;
            CPU_Set();
        }
        /// <summary>
        /// 刷新页面数据
        /// </summary>
        private void Timer1_Tick(object sender, EventArgs e)
        {
            Comm_CPU.BackColor = PLC.IsConn ? Color.Lime : Color.Red;       // PLC通讯状态          
            Comm_mod.BackColor = PLC.ReadComm[17] == 1 ? Color.Lime : Color.Red;// 加热电源通讯状态
            Comm_SL.BackColor = PLC.ReadComm[18] == 1 ? Color.Lime : Color.Red;// 晶升电机通讯状态
            Comm_CL.BackColor = PLC.ReadComm[19] == 1 ? Color.Lime : Color.Red;// 锅升电机通讯状态          
            Comm_SR.BackColor = PLC.ReadComm[20] == 1 ? Color.Lime : Color.Red;// 晶转电机通讯状态
            Comm_CR.BackColor = PLC.ReadComm[21] == 1 ? Color.Lime : Color.Red;// 锅转电机通讯状态
            Comm_SM.BackColor = PLC.ReadComm[22] == 1 ? Color.Lime : Color.Red; // 热屏电机通讯状态
            Comm_Htr.BackColor = PLC.ReadComm[23] == 1 ? Color.Lime : Color.Red; // 刷新各站点属性状态
            Comm_Smart200.BackColor = PLC.ReadComm[28] == 1 ? Color.Lime : Color.Red;
            Comm_SlaveShld.BackColor = PLC.ReadComm[29] == 1 ? Color.Lime : Color.Red;
            ViewDisplay();
            LabSLMotorStatus.Text = PLC.ReadOthersValue[23].ToString();
            LabCLMotorStatus.Text = PLC.ReadOthersValue[24].ToString();
            LabSLMotorStatus2.Text = string.Concat("0x", Convert.ToString(PLC.ReadAnalogIn[33], 16));
            LabCLMotorStatus2.Text = string.Concat("0x", Convert.ToString(PLC.ReadAnalogIn[34], 16));
            LabCRMotorStatus2.Text = string.Concat("0x", Convert.ToString(PLC.ReadAnalogIn[38], 16));
            LabSRMotorStatus2.Text = string.Concat("0x", Convert.ToString(PLC.ReadAnalogIn[39], 16));
            LabSMMotorStatus.Text = string.Concat("0x", Convert.ToString(PLC.ReadAnalogIn[40], 16));
            LabSSMotorStatus.Text = string.Concat("0x", Convert.ToString(PLC.ReadAnalogIn[41], 16));
        }
        /// <summary>
        /// 切换站点时清空表格
        /// </summary>
        /// <param name="label"></param>
        private void ViewSet(Label label)
        {
            LastLabel.BackColor = Color.White;
            LastLabel.ForeColor = Color.Black;
            label.BackColor = Color.Black;
            label.ForeColor = Color.White;
            // 清空显示列表
            for (int i = 0; i < 32; i++)
            {
                DataGridView1.Rows[i].Cells[0].Value = "";
                DataGridView1.Rows[i].Cells[1].Value = "";
                DataStr[i] = "";
            }
            BtnClearZero.Visible = false;
        }
        /// <summary>
        /// 刷新各站点的属性和状态到表格中
        /// </summary>
        private void ViewDisplay()
        {
            for (int i = 1; i <= DataNum; i++)
            {
                DataGridView1.Rows[i - 1].Cells[0].Value = DataStr[i];
            }
            switch (DataType)
            {
                case 0:     //CPU
                    for (int i = 1; i <= DataNum; i++)
                    {
                        DataGridView1.Rows[i - 1].Cells[1].Value = PLC.ReadComm[DataAddr[i]] == 1 ? "ON" : "OFF";
                    }
                    break;
                case 1:     //数字量输入
                    for (int i = 1; i <= DataNum; i++)
                    {
                        if (DataValid[i])
                        {
                            DataGridView1.Rows[i - 1].Cells[1].Value = "----";
                        }
                        else
                        {
                            DataGridView1.Rows[i - 1].Cells[1].Value = PLC.ReadStatusIn[DataAddr[i]] == 1 ? "ON" : "OFF";
                        }
                    }
                    break;
                case 2:     //数字量输出
                    for (int i = 1; i <= DataNum; i++)
                    {
                        if (DataValid[i])
                        {
                            DataGridView1.Rows[i - 1].Cells[1].Value = "----";
                        }
                        else
                        {
                            DataGridView1.Rows[i - 1].Cells[1].Value = PLC.ReadStatusOut[DataAddr[i]] == 1 ? "ON" : "OFF";
                        }
                    }
                    break;
                case 3:     //模拟量输入
                    for (int i = 1; i <= DataNum; i++)
                    {
                        if (DataValid[i])
                        {
                            DataGridView1.Rows[i - 1].Cells[1].Value = "----";
                        }
                        else
                        {
                            DataGridView1.Rows[i - 1].Cells[1].Value = DataCovert.Analog(PLC.ReadAnalogIn[DataAddr[i]], AnalogType[i]);
                        }
                    }
                    break;
                case 4:     //模拟量输出
                    for (int i = 1; i <= DataNum; i++)
                    {
                        DataGridView1.Rows[i - 1].Cells[1].Value = DataValid[i] == false ? DataCovert.Analog(PLC.ReadAnalogOut[DataAddr[i]], AnalogType[i]) : "----";
                    }
                    break;
                case 5:     
                    DataGridView1.Rows[0].Cells[1].Value = Math.Round(PLC.ReadOthersValue[6], 0);//晶升电机                                                                                             
                    DataGridView1.Rows[1].Cells[1].Value = Math.Round(PLC.ReadOthersValue[5], 0);//埚升电机
                    DataGridView1.Rows[2].Cells[1].Value = Math.Round(PLC.ReadOthersValue[32], 0); //主热屏 
                    DataGridView1.Rows[3].Cells[1].Value = Math.Round(PLC.ReadOthersValue[30], 0); //从热屏
                    break;
            }
        }
        private void CleanValid()
        {
            for (int i = 1; i <= 32; i++)
            {
                DataValid[i] = false;
            }
        }
        private void BtnTempSW_Click(object sender, EventArgs e)
        {
            FrmSwitch.LastForm.Close();
            FrmTempSW temp = new FrmTempSW();
            FrmSwitch.Open(temp, 141, new Point(0, 130), new Size(1366, 638));
            temp.Show();
            FrmSwitch.LastForm = temp;
        }
        private void BtnPerFac_Click(object sender, EventArgs e)
        {
            FrmSwitch.LastForm.Close();
            FrmPerFac temp = new FrmPerFac();
            FrmSwitch.Open(temp, 142, new Point(0, 130), new Size(1366, 638));
            temp.Show();
            FrmSwitch.LastForm = temp;
        }
        private void BtnLimSW_Click(object sender, EventArgs e)
        {
            FrmSwitch.LastForm.Close();
            FrmLimitSW temp = new FrmLimitSW();
            FrmSwitch.Open(temp, 143, new Point(0, 130), new Size(1366, 638));
            temp.Show();
            FrmSwitch.LastForm = temp;
        }
        private void BtnClearZero_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnClearZero))
            {
                PLC.SendBit(30, 114, 1);
            }
        }
        private void BtnSLReset_Click(object sender, EventArgs e)
        {
            PLC.SendBit(30, 89, 1);
        }
        private void BtnCRReset_Click(object sender, EventArgs e)
        {
            PLC.SendBit(30, 88, 1);
        }
        private void BtnSRReset_Click(object sender, EventArgs e)
        {
            PLC.SendBit(30, 116, 1);
        }
        private void CPU1_0_Click(object sender, EventArgs e)
        {
            if (CPU1_0 != LastLabel)
            {
                ViewSet(CPU1_0);
                LastLabel = CPU1_0;
                CPU_Set();
            }
        }
        private void CPU_Set()
        {
            DataType = 0;
            DataNum = 8;
            DataStr[1] = "PROFINET晶升电机通讯状态";
            DataStr[2] = "PROFINET埚升电机通讯状态";
            DataStr[3] = "PROFINET晶转电机通讯状态";
            DataStr[4] = "PROFINET埚转电机通讯状态";
            DataStr[5] = "PROFINET热屏主电机通讯状态";
            DataStr[6] = "PROFINET加热电源通讯状态";
            DataStr[7] = "ROFINET Smart通讯状态";
            DataStr[8] = "PROFINET热屏从电机通讯状态";
            DataAddr[1] = 18;
            DataAddr[2] = 19;
            DataAddr[3] = 20;
            DataAddr[4] = 21;
            DataAddr[5] = 22;
            DataAddr[6] = 23;
            DataAddr[7] = 28;
            DataAddr[8] = 29;
            BtnClearZero.Visible = false;
        }
        private void AI1_0_Click(object sender, EventArgs e)
        {
            if (LastLabel != AI1_0)
            {
                CleanValid();
                ViewSet(AI1_0);
                LastLabel = AI1_0;
                DataType = 3;
                DataNum = 8;
                DataStr[1] = "主室真空计100Torr(AI1/0-10V)";
                DataStr[2] = "干泵频率反馈(AI2/0-10V)";
                DataStr[3] = "副室真空计1000Torr(AI3/0-10V)";
                DataStr[4] = "称重信号(AI4/0-10V)";
                DataStr[5] = "主室真空计1Torr(AI5/0-10V)";
                DataStr[6] = "备用1(AI6)";
                DataStr[7] = "备用2(AI7)";
                DataStr[8] = "备用3(AI8)";
                DataAddr[1] = 4;
                DataAddr[2] = 5;
                DataAddr[3] = 26;
                DataAddr[4] = 32;
                DataAddr[5] = 3;
                DataValid[6] = true;
                DataValid[7] = true;
                DataValid[8] = true;
                AnalogType[1] = 1;
                AnalogType[2] = 1;
                AnalogType[3] = 1;
                AnalogType[4] = 1;
                AnalogType[5] = 1;
            }
        }
        private void DI1_0_Click(object sender, EventArgs e)
        {
            if (LastLabel != DI1_0)
            {
                CleanValid();
                ViewSet(DI1_0);
                LastLabel = DI1_0;
                DataType = 1;
                DataNum = 16;
                DataStr[1] = "主加热正电极超温开关(I0.0)";
                DataStr[2] = "主加热负电极超温开关(I0.1)";
                DataStr[3] = "底加热正电极超温开关(I0.2)";
                DataStr[4] = "底加热负电极超温开关(I0.3)";              
                DataStr[5] = "炉底盘超温开关(I0.4)";
                DataStr[6] = "坩埚轴超温开关(I0.5)";
                DataStr[7] = "下炉室超温开关(I0.6)";
                DataStr[8] = "上炉室超温开关(I0.7)";
                DataStr[9] = "副室超温开关(I1.0)";
                DataStr[10] = "UPS电池异常(I1.1)";
                DataStr[11] = "UPS市电故障(I1.2)";
                DataStr[12] = "主室提升爪左锁紧限位(I1.3)";
                DataStr[13] = "主室提升爪左松开限位(I1.4)";
                DataStr[14] = "液压站超压异常(I1.5)";
                DataStr[15] = "主室提升爪右锁紧限位(I1.6)";
                DataStr[16] = "主室提升爪右松开限位(I1.7)";
                DataAddr[1] = 6;
                DataAddr[2] = 10;
                DataAddr[3] = 9;
                DataAddr[4] = 5;
                DataAddr[5] = 12;
                DataAddr[6] = 24;
                DataAddr[7] = 75;
                DataAddr[8] = 79;
                DataAddr[9] = 37;
                DataAddr[10] = 62;
                DataAddr[11] = 63;
                DataAddr[12] = 84;
                DataAddr[13] = 87;
                DataAddr[14] = 98;
                DataAddr[15] = 85;
                DataAddr[16] = 88;
            }
        }
        private void DI1_1_Click(object sender, EventArgs e)
        {
            if (LastLabel != DI1_1)
            {
                CleanValid();
                ViewSet(DI1_1);
                LastLabel = DI1_1;
                DataType = 1;
                DataNum = 16;
                DataStr[1] = "旋片阀升限位(I2.0)";
                DataStr[2] = "旋片阀降限位(I2.1)";
                DataStr[3] = "旋片阀开限位(I2.2)";
                DataStr[4] = "旋片阀关限位(I2.3)";
                DataStr[5] = "隔离阀腔超温开关(I2.4)";
                DataStr[6] = "隔离阀板超温开关(I2.5)";
                DataStr[7] = "炉盖超温开关(I2.6)";
                DataStr[8] = "水冷屏超温开关(I2.7)";
                DataStr[9] = "籽晶位置传感器接收(I3.0)";
                DataStr[10] = "籽晶熔接检测(I3.1)";
                DataStr[11] = "只升副室限位(I3.2)";
                DataStr[12] = "副室炉盖锁限位(I3.3)";
                DataStr[13] = "安全气缸上限位(I3.4)";
                DataStr[14] = "安全气缸下限位(I3.5)";
                DataStr[15] = "接晶架上限位(I3.6)";
                DataStr[16] = "接晶架下限位(I3.7)";
                DataAddr[1] = 47;
                DataAddr[2] = 48;
                DataAddr[3] = 36;
                DataAddr[4] = 34;
                DataAddr[5] = 43;
                DataAddr[6] = 44;
                DataAddr[7] = 41;
                DataAddr[8] = 70;
                DataAddr[9] = 42;
                DataAddr[10] = 20;
                DataAddr[11] = 39;
                DataAddr[12] = 38;
                DataAddr[13] = 81;
                DataAddr[14] = 82;
                DataAddr[15] = 45;
                DataAddr[16] = 46;
            }
        }
        private void DI1_2_Click(object sender, EventArgs e)
        {
            if (LastLabel != DI1_2)
            {
                CleanValid();
                ViewSet(DI1_2);
                LastLabel = DI1_2;
                DataType = 1;
                DataNum = 16;
                DataStr[1] = "副室左旋限位(I4.0)";
                DataStr[2] = "副室右旋限位(I4.1)";
                DataStr[3] = "副室上升限位(I4.2)";
                DataStr[4] = "副室下降限位(I4.3)";
                DataStr[5] = "副室半升限位(I4.4)";
                DataStr[6] = "副室变速限位(I4.5)";
                DataStr[7] = "副室左旋中限位(I4.6)";
                DataStr[8] = "备用(I4.7)";
                DataStr[9] = "主室左旋限位(I5.0)";
                DataStr[10] = "主室右旋限位(I5.1)";
                DataStr[11] = "主室上升限位(I5.2)";
                DataStr[12] = "主室下降限位(I5.3)";
                DataStr[13] = "主室半升限位(I5.4)";
                DataStr[14] = "备用(I5.5)";
                DataStr[15] = "备用(I5.6)";
                DataStr[16] = "备用(I5.7)";
               // DataStr[15] = "热屏升限位(I5.6)";
              //  DataStr[16] = "热屏降限位(I5.7)";
                DataAddr[1] = 33;
                DataAddr[2] = 19;
                DataAddr[3] = 40;
                DataAddr[4] = 77;
                DataAddr[5] = 93;
                DataAddr[6] = 95;
                DataValid[7] = true; ;
                DataValid[8] = true;
                DataAddr[9] = 55;
                DataAddr[10] = 56;
                DataAddr[11] = 35;
                DataAddr[12] = 76;
                DataAddr[13] = 92;
                DataValid[14] = true;
                DataValid[15] = true;
                DataValid[16] = true;
                // DataAddr[15] = 31;
                //  DataAddr[16] = 32;
            }
        }
        private void DI1_3_Click(object sender, EventArgs e)
        {
            if (LastLabel != DI1_3)
            {
                CleanValid();
                ViewSet(DI1_3);
                LastLabel = DI1_3;
                DataType = 1;
                DataNum = 16;
                DataStr[1] = "加热电源运行(I6.0)";
                DataStr[2] = "主电源开反馈(I6.1)";
                DataStr[3] = "底电源开反馈(I6.2)";
                DataStr[4] = "干泵警告(I6.3)";
                DataStr[5] = "干泵报警(I6.4)";
                DataStr[6] = "干泵远程/本地(I6.5)";
                DataStr[7] = "主真空泵运行反馈(I6.6)";
                DataStr[8] = "过滤罐运行反馈(I6.7)";
                DataStr[9] = "炉盖加热互锁限位反馈(I7.0)";
                DataStr[10] = "主水流量开关(I7.1)";
                DataStr[11] = "应急开关输入(I7.2)";
                DataStr[12] = "副泵运行反馈(I7.3)";
                DataStr[13] = "主室球阀开限位(I7.4)";
                DataStr[14] = "主室球阀关限位(I7.5)";
                DataStr[15] = "过滤罐报警(I7.6)";
                DataStr[16] = "压缩空气开关反馈(I7.7)";
                DataAddr[1] = 13;
                DataAddr[2] = 99;
                DataAddr[3] = 100;
                DataAddr[4] = 68;
                DataAddr[5] = 66;
                DataAddr[6] = 67;
                DataAddr[7] = 15;
                DataAddr[8] = 94;
                DataAddr[9] = 59;
                DataAddr[10] = 73;
                DataAddr[11] = 101;
                DataAddr[12] = 16;
                DataAddr[13] = 96;
                DataAddr[14] = 97;
                DataAddr[15] = 102;
                DataAddr[16] = 17;
                //  DataValid[16] = true;
            }
        }
        private void DI1_4_Click(object sender, EventArgs e)
        {
            if (LastLabel != DI1_4)
            {
                CleanValid();
                ViewSet(DI1_4);
                LastLabel = DI1_4;
                DataType = 1;
                DataNum = 16;
                DataStr[1] = "引晶器点动(I8.0)";
                DataStr[2] = "引晶器快升(I8.1)";
                DataStr[3] = "引晶器快降(I8.2)";
                DataStr[4] = "副室升按钮(I8.3)";
                DataStr[5] = "副室降按钮(I8.4)";
                DataStr[6] = "副室左旋按钮(I8.5)";
                DataStr[7] = "副室右旋按钮(I8.6)";
                DataStr[8] = "主室升按钮(I8.7)";
                DataStr[9] = "主室降按钮(I9.0)";
                DataStr[10] = "主室左旋按钮(I9.1)";
                DataStr[11] = "主室右旋按钮(I9.2)";
                DataStr[12] = "主室提升爪中锁紧限位(I9.3)";
                DataStr[13] = "主室提升爪中松开限位(I9.4)";
                DataStr[14] = "热屏升限位(I9.5)";
                DataStr[15] = "热屏降限位(I9.6)";
                DataStr[16] = "备用(I9.7)";
                DataAddr[1] = 27;
                DataAddr[2] = 26;
                DataAddr[3] = 28;
                DataAddr[4] = 49;
                DataAddr[5] = 50;
                DataAddr[6] = 57;
                DataAddr[7] = 58;
                DataAddr[8] = 53;
                DataAddr[9] = 54;
                DataAddr[10] = 51;
                DataAddr[11] = 52;
                DataAddr[12] = 86;
                DataAddr[13] = 89;
                DataAddr[14] = 31;//
                DataAddr[15] = 32;//
                DataValid[16] = true;
            }
        }
        private void DQ1_5_Click(object sender, EventArgs e)
        {
            if (LastLabel != DQ1_5)
            {
                CleanValid();
                ViewSet(DQ1_5);
                LastLabel = DQ1_5;
                DataType = 2;
                DataNum = 16;
                DataStr[1] = "接晶架打开(Q0.0)";
                DataStr[2] = "接晶架关闭(Q0.1)";
                DataStr[3] = "安全气缸上升(Q0.2)";
                DataStr[4] = "安全气缸下降(Q0.3)";
                DataStr[5] = "锁紧气缸左旋(Q0.4)";
                DataStr[6] = "锁紧气缸右旋(Q0.5)";
                DataStr[7] = "主室提升夹抓锁紧(Q0.6)";
                DataStr[8] = "主室提升夹抓松开(Q0.7)";
                DataStr[9] = "旋片阀升(Q1.0)";
                DataStr[10] = "旋片阀降(Q1.1)";
                DataStr[11] = "旋片阀开(Q1.2)";
                DataStr[12] = "旋片阀关(Q1.3)";
                DataStr[13] = "主室球阀(Q1.4)";
                DataStr[14] = "副室挡板阀(Q1.5)";
                DataStr[15] = "PLC开应急球阀(Q1.6)";
                DataStr[16] = "PLC开副泵(Q1.7)";
                DataAddr[1] = 43;
                DataAddr[2] = 44;
                DataAddr[3] = 15;
                DataAddr[4] = 16;
                DataAddr[5] = 45;
                DataAddr[6] = 46;
                DataAddr[7] = 23;
                DataAddr[8] = 24;
                DataAddr[9] = 39;
                DataAddr[10] = 40;
                DataAddr[11] = 41;
                DataAddr[12] = 42;
                DataAddr[13] = 9;
                DataAddr[14] = 10;
                DataAddr[15] = 51;
                DataAddr[16] = 28;
            }
        }
        private void DQ1_6_Click(object sender, EventArgs e)
        {
            if (LastLabel != DQ1_6)
            {
                CleanValid();
                ViewSet(DQ1_6);
                LastLabel = DQ1_6;
                DataType = 2;
                DataNum = 16;
                DataStr[1] = "上氩气阀(Q2.0)";
                DataStr[2] = "下氩气阀(Q2.1)";
                DataStr[3] = "快充氩气阀(Q2.2)";
                DataStr[4] = "燃烧阀(Q2.3)";
                DataStr[5] = "PLC加热器开(Q2.4)";
                DataStr[6] = "PLC关主泵(Q2.5)";
                DataStr[7] = "PLC关副泵(Q2.6)";
                DataStr[8] = "双腔过滤罐切副罐(Q2.7)";
                DataStr[9] = "风螺报警(Q3.0)";
                DataStr[10] = "PLC停热屏电机(Q3.1)";
                DataStr[11] = "备用(Q3.2)";
                DataStr[12] = "备用(Q3.3)";
                DataStr[13] = "备用(Q3.4)";
                DataStr[14] = "备用(Q3.5)";
                DataStr[15] = "备用(Q3.6)";
                DataStr[16] = "大手柄指示灯(Q3.7)";
                DataAddr[1] = 14;
                DataAddr[2] = 13;
                DataAddr[3] = 19;
                DataAddr[4] = 18;
                DataAddr[5] = 37;
                DataAddr[6] = 12;
                DataAddr[7] = 32;
                DataAddr[8] = 38;
                DataAddr[9] = 26;
                DataAddr[10] = 33;
                DataValid[11] = true;
                DataValid[12] = true;
                DataValid[13] = true;
                DataValid[14] = true;
                DataValid[15] = true;
                DataAddr[16] = 34;
            }
        }
        private void DQ1_7_Click(object sender, EventArgs e)
        {
            if (LastLabel != DQ1_7)
            {
                CleanValid();
                ViewSet(DQ1_7);
                LastLabel = DQ1_7;
                DataType = 2;
                DataNum = 16;
                DataStr[1] = "红色指示灯(Q4.0)";
                DataStr[2] = "黄色指示灯(Q4.1)";
                DataStr[3] = "绿色指示灯(Q4.2)";
                DataStr[4] = "报警蜂鸣器(Q4.3)";
                DataStr[5] = "副室电机左旋(Q4.4)";
                DataStr[6] = "副室电机右旋(Q4.5)";
                DataStr[7] = "主室电机左旋(Q4.6)";
                DataStr[8] = "主室电机右旋(Q4.7)";
                DataStr[9] = "副室升(Q5.0)";
                DataStr[10] = "副室降(Q5.1)";
                DataStr[11] = "副室快升(Q5.2)";
                DataStr[12] = "副室快降(Q5.3)";
                DataStr[13] = "主室升(Q5.4)";
                DataStr[14] = "主室降(Q5.5)";
                DataStr[15] = "液压泵启动(Q5.6)";
                DataStr[16] = "氩气回收阀(Q5.7)";
                DataAddr[1] = 29;
                DataAddr[2] = 30;
                DataAddr[3] = 31;
                DataAddr[4] = 25;
                DataAddr[5] = 47;
                DataAddr[6] = 48;
                DataAddr[7] = 49;
                DataAddr[8] = 50;
                DataAddr[9] = 5;
                DataAddr[10] = 6;
                DataAddr[11] = 52;
                DataAddr[12] = 53;
                DataAddr[13] = 7;
                DataAddr[14] = 8;
                DataAddr[15] = 3;
                DataAddr[16] = 27;
            }
        }
        private void AI1_8_Click(object sender, EventArgs e)
        {
            if (LastLabel != AI1_8)
            {
                CleanValid();
                ViewSet(AI1_8);
                LastLabel = AI1_8;
                DataType = 3;
                DataNum = 8;
                DataStr[1] = "左抽气管道热电偶(AI1/0-10V)";
                DataStr[2] = "波纹管热电偶(AI2/0-10V)";
                DataStr[3] = "右抽气管道热电偶(AI3/0-10V)";
                DataStr[4] = "备用1(AI3)";
                DataStr[5] = "备用2(AI4)";
                DataStr[6] = "备用3(AI5)";
                DataStr[7] = "备用4(AI6)";
                DataStr[8] = "备用5(AI7)";
                DataAddr[1] = 35;
                DataAddr[2] = 37;
                DataAddr[3] = 36;
                DataValid[4] = true;
                DataValid[5] = true;
                DataValid[6] = true;
                DataValid[7] = true;
                DataValid[8] = true;
                AnalogType[1] = 1;
                AnalogType[2] = 1;
                AnalogType[3] = 1;
            }
        }
        private void AI1_9_Click(object sender, EventArgs e)
        {
            if (LastLabel != AI1_9)
            {
                CleanValid();
                ViewSet(AI1_9);
                LastLabel = AI1_9;
                DataType = 3;
                DataNum = 8;
                DataStr[1] = "氩气流量计反馈(AI1/4-20mA)";
                DataStr[2] = "水冷屏流量(AI2/4-20mA)";
                DataStr[3] = "水冷屏测温(AI3/4-20mA)";
                DataStr[4] = "备用1(AI4)";
                DataStr[5] = "备用2(AI5)";
                DataStr[6] = "备用3(AI6)";
                DataStr[7] = "备用4(AI7)";
                DataStr[8] = "备用5(AI8)";
                DataAddr[1] = 25;
                DataAddr[2] = 20;
                DataAddr[3] = 21;
                DataValid[4] = true;
                DataValid[5] = true;
                DataValid[6] = true;
                DataValid[7] = true;
                DataValid[8] = true;
                AnalogType[1] = 3;
                AnalogType[2] = 3;
                AnalogType[3] = 3;
            }
        }
        private void AQ1_11_Click(object sender, EventArgs e)
        {
            if (LastLabel != AQ1_11)
            {
                CleanValid();
                ViewSet(AQ1_11);
                LastLabel = AQ1_11;
                DataType = 4;
                DataNum = 4;
                DataStr[1] = "质量流量计给定";
                DataStr[2] = "干泵频率给定";
                //DataStr[1] = "氩气流量输出";
                //DataStr[2] = "主真空泵输出";
                DataStr[3] = "备用1";
                DataStr[4] = "备用2";
                DataAddr[1] = 3;
                DataAddr[2] = 1;
                DataValid[3] = true;
                DataValid[4] = true;
                AnalogType[1] = 3;
                AnalogType[2] = 3;
            }
        }

        private void LabSmart_Click(object sender, EventArgs e)
        {
            if (LastLabel != LabSmart)
            {
                CleanValid();
                ViewSet(LabSmart);
                LastLabel = LabSmart;
                DataType = 5;
                DataNum = 4;
                DataStr[1] = "晶升编码器";
                DataStr[2] = "埚升编码器";
                DataStr[3] = "主热屏编码器";
                DataStr[4] = "从热屏编码器";
                DataAddr[1] = 6;
                DataAddr[2] = 5;
                DataAddr[3] = 32;
                DataAddr[4] = 30;
            }
        }
    }
}
