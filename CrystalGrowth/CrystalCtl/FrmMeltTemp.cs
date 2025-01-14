using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CrystalGrowth.CrystalCtl
{
    internal partial class FrmMeltTemp : Form
    {
        public static bool PreTempRunningFlag = false;
        public static DateTime datetime;
        public static string SeedPower = "0";
        public static string SeedTemp = "0";
        public static string SeedCrucPos = "0";
        public static string SeedPixel = "0";
        public static string SeedAvgSpeed = "0";
        public static string Seed60Speed = "0";
        public static string BodyLength = "0";
        public static string ResidualWeight = "0";
        public static string SeedMeltGap = "0";
        public static string BodyMeltGap = "0";
        public static string SeedMeltPixel = "0";
        public static string BodyMeltPixel = "0";
        public static string BodyPowerStart = "0";
        public static string BodyPower500 = "0";
        public static string BodyPower1000 = "0";
        public static string BodyPower1500 = "0";
        public static int CurrentCount = 0;
        public FrmMeltTemp()
        {
            InitializeComponent();
            DataGridView1.Rows.Add(17);
            DataGridView1[0, 0].Value = "时间";
            DataGridView1[0, 1].Value = "引晶功率";
            DataGridView1[0, 2].Value = "引晶温度";
            DataGridView1[0, 3].Value = "引晶埚位";
            DataGridView1[0, 4].Value = "引晶灰度";
            DataGridView1[0, 5].Value = "平均拉速";
            DataGridView1[0, 6].Value = "等径长度";
            DataGridView1[0, 7].Value = "剩料量";
            DataGridView1[0, 8].Value = "引晶液口距";
            DataGridView1[0, 9].Value = "等径液口距";
            DataGridView1[0, 10].Value = "引晶液口距像素值";
            DataGridView1[0, 11].Value = "等径液口距像素值";
            DataGridView1[0, 12].Value = ">60平均拉速";
            DataGridView1[0, 13].Value = "等径开始功率";
            DataGridView1[0, 14].Value = "等径500功率";
            DataGridView1[0, 15].Value = "等径1000功率";
            DataGridView1[0, 16].Value = "等径1500功率";
            Load += Timer1_Tick;
        }
        public static void CalcParas()
        {
            datetime = DateTime.Now;
            SeedPower = Math.Round(PLC.ReadValue[72], 2).ToString("f2");
            SeedTemp = Math.Round(PLC.ReadValue[32], 1).ToString("f1");
            SeedCrucPos = Math.Round(PLC.ReadValue[59], 1).ToString("f1");
            SeedPixel = Math.Round(IgAlgo1.BrightValue, 1).ToString("f1");
            SeedAvgSpeed = Math.Round(PLC.ReadValue[107], 1).ToString("f1");
            ResidualWeight = Math.Round(PLC.ReadCalcValue[10], 2).ToString("f2");
            SeedMeltGap = Math.Round(PLC.ReadValue[41], 1).ToString("f1");
            Seed60Speed = Math.Round(PLC.ReadAnalogValue[45], 1).ToString("f1");
            SeedMeltPixel = IgAlgo1.PixelMiddleMeltGap.ToString("f1");
            WriteGrowthData1();
        }
        public static void Dispaly()
        {
            WriteGrowthData1();
            WriteGrowthData();
        }
        private void FrmMeltTemp_Load(object sender, EventArgs e)
        {
            BtnTune.BackColor = Color.Fuchsia;
            ReadGrowthData();
        }
        //第12条，显示上一条成功数据
        public void ReadGrowthData()
        {
            string[] Strs = File.ReadAllLines(FileHelper.GrowthDataPath, System.Text.Encoding.UTF8);
            string[] TempVar = Strs[11].Split(new char[] { ',' });
            DataGridView1[1, 0].Value = TempVar[0];
            DataGridView1[1, 1].Value = TempVar[1];
            DataGridView1[1, 2].Value = TempVar[2];
            DataGridView1[1, 3].Value = TempVar[3];
            DataGridView1[1, 4].Value = TempVar[4];
            DataGridView1[1, 5].Value = TempVar[5];
            DataGridView1[1, 6].Value = TempVar[6];
            DataGridView1[1, 7].Value = TempVar[7];
            DataGridView1[1, 8].Value = TempVar[8];
            DataGridView1[1, 9].Value = TempVar[9];
            DataGridView1[1, 10].Value = TempVar[10];
            DataGridView1[1, 11].Value = TempVar[11];
            DataGridView1[1, 12].Value = TempVar[12];
            DataGridView1[1, 13].Value = TempVar[13];
            DataGridView1[1, 14].Value = TempVar[14];
            DataGridView1[1, 15].Value = TempVar[15];
            DataGridView1[1, 16].Value = TempVar[16];
            File.WriteAllLines(FileHelper.GrowthDataPath, Strs);
        }
        public static void InitGrowthData()
        {
            string[] Strs = File.ReadAllLines(string.Format("{0}\\Record\\GrowthData.dat", Application.StartupPath), System.Text.Encoding.UTF8);
            //读取上一次存储的数据显示
            string[] TempVar = Strs[10].Split(new char[] { ',' });
            datetime = Convert.ToDateTime(TempVar[0]);
            SeedPower = TempVar[1];
            SeedTemp = TempVar[2];
            SeedCrucPos = TempVar[3];
            SeedPixel = TempVar[4];
            SeedAvgSpeed = TempVar[5];
            BodyLength = TempVar[6];
            ResidualWeight = TempVar[7];
            SeedMeltGap = TempVar[8];
            BodyMeltGap = TempVar[9];
            SeedMeltPixel = TempVar[10];
            BodyMeltPixel = TempVar[11];
            Seed60Speed = TempVar[12];
            BodyPowerStart = TempVar[13];
            BodyPower500 = TempVar[14];
            BodyPower1000 = TempVar[15];
            BodyPower1500 = TempVar[16];
        }
        public static void WriteGrowthData()
        {
            if (PLC.ReadCalcValue[14] >= 500)
            {
                string[] Strs = File.ReadAllLines(FileHelper.GrowthDataPath, System.Text.Encoding.UTF8);
                CurrentCount = Convert.ToInt16(Strs[12]);
                for (int i = 0; i <= 9; i++)
                {
                    if (CurrentCount == i)
                    {
                        //在头10条数据中按顺序写入第十一条（引晶临时数据）
                        Strs[i] = Strs[10];
                    }
                }
                CurrentCount = CurrentCount <= 8 ? CurrentCount + 1 : 0;
                //读取引晶临时存储数据，等径大于500，存放在第12条（上一次成功数据）
                Strs[11] = Strs[10];
                Strs[12] = CurrentCount.ToString();
                File.WriteAllLines(FileHelper.GrowthDataPath, Strs);
            }
        }
        public static void WriteGrowthData1()
        {
            string[] Strs = File.ReadAllLines(FileHelper.GrowthDataPath, System.Text.Encoding.UTF8);
            //引晶临时数据
            Strs[10] = string.Format($"{ DateTime.Now:yyyy-MM-dd HH:mm:ss},{SeedPower},{SeedTemp},{SeedCrucPos},{SeedPixel},{SeedAvgSpeed},{BodyLength},{ResidualWeight},{SeedMeltGap},{BodyMeltGap},{SeedMeltPixel},{BodyMeltPixel},{Seed60Speed},{BodyPowerStart},{BodyPower500},{BodyPower1000},{BodyPower1500}");
            File.WriteAllLines(FileHelper.GrowthDataPath, Strs);
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            LabSP.Text = Math.Round(PLC.ReadValue[31], 1).ToString("f1");
            LabPV.Text = Math.Round(PLC.ReadValue[32], 1).ToString("f1");
            LabPVPxl.Text = Math.Round(IgAlgo1.BrightValue, 1).ToString("f1");
            LabPVPxlRealtime.Text = Math.Round(IgAlgo1.BrightRTimeValue, 1).ToString("f1");
            LabOut.Text = Math.Round(PLC.ReadValue[23], 2).ToString("f2");
            if (PLC.Count == 2)
            {
                if (BtnTune.BackColor == Color.Fuchsia)
                {
                    LabGainVal.Text = Math.Round(PLC.ReadValue[33], 4).ToString("f4");
                    LabIntegVal.Text = Math.Round(PLC.ReadValue[34], 4).ToString("f4");
                    LabDifferVal.Text = Math.Round(PLC.ReadValue[35], 4).ToString("f4");
                }
                if (BtnLimit.BackColor == Color.Fuchsia)
                {
                    LabIntegVal.Text = Math.Round(PLC.ReadValue[29], 2).ToString("f2");
                    LabDifferVal.Text = Math.Round(PLC.ReadValue[30], 2).ToString("f2");
                }
                if (PLC.ReadStatus[1] == 1)
                {
                    BtnManual.Visible = true;
                    BtnAuto.Visible = true;
                    LabSP.BackColor = PLC.ReadStatus[31] == 1 ? Color.White : Color.Gray;
                }
                else
                {
                    BtnManual.Visible = false;
                    BtnAuto.Visible = false;
                    LabSP.BackColor = PLC.ReadStatus[6] == 1 ? Color.White : Color.Gray;
                }
                if (PLC.ReadStatus[31] == 1)
                {
                    BtnManual.BackColor = Color.Red;
                    BtnAuto.BackColor = Color.Blue;
                }
                else
                {
                    BtnManual.BackColor = Color.Blue;
                    BtnAuto.BackColor = Color.Red;
                }
                if (PLC.ReadStatus[6] == 1)
                {
                    BtnON.BackColor = Color.Red;
                    BtnOFF.BackColor = Color.Blue;
                }
                else
                {
                    BtnON.BackColor = Color.Blue;
                    BtnOFF.BackColor = Color.Red;
                }
                //预调温
                if (PLC.ReadStatus[86] == 1)
                {
                    BtnPreAjustTempOn.BackColor = Color.Red;
                    BtnPreAjustTempOff.BackColor = Color.Blue;
                    if (PreTempRunningFlag == false)
                    {
                        PreTempRunningFlag = true;
                    }
                }
                else
                {
                    BtnPreAjustTempOn.BackColor = Color.Blue;
                    BtnPreAjustTempOff.BackColor = Color.Red;
                    if (PreTempRunningFlag)
                    {
                        PreTempRunningFlag = false;
                    }
                }
                if (PLC.ReadStatus[98] == 1)
                {
                    BtnCoverPre.Text = "开启";
                    BtnCoverPre.BackColor = Color.Red;
                }
                else
                {
                    BtnCoverPre.Text = "关闭";
                    BtnCoverPre.BackColor = Color.Blue;
                }
                //控制选择-功率控制
                LabOut.BackColor = PLC.ReadStatus[57] == 1 && (PLC.ReadStatus[3] == 1 || PLC.ReadStatus[6] == 1) ? Color.Gray : Color.White;
                //控制选择-温度控制
                LabOut.BackColor = PLC.ReadStatus[57] == 0 && (PLC.ReadStatus[5] == 1 || PLC.ReadStatus[6] == 1) ? Color.Gray : Color.White;
            }
        }
        private void BtnTune_Click(object sender, EventArgs e)
        {
            BtnTune.BackColor = Color.Fuchsia;
            BtnLimit.BackColor = Color.Blue;
            LabGainTxt.Visible = true;
            LabGainVal.Visible = true;
            LabDifferTxt.Text = "微分";
            LabIntegTxt.Text = "积分";
            LabGainVal.Text = Math.Round(PLC.ReadValue[33], 4).ToString("f4");
            LabIntegVal.Text = Math.Round(PLC.ReadValue[34], 4).ToString("f4");
            LabDifferVal.Text = Math.Round(PLC.ReadValue[35], 4).ToString("f4");
        }
        private void BtnLimit_Click(object sender, EventArgs e)
        {
            BtnTune.BackColor = Color.Blue;
            BtnLimit.BackColor = Color.Fuchsia;
            LabGainTxt.Visible = false;
            LabGainVal.Visible = false;
            LabDifferTxt.Text = "下限";
            LabIntegTxt.Text = "上限";
            LabIntegVal.Text = Math.Round(PLC.ReadValue[29], 2).ToString("f2");
            LabDifferVal.Text = Math.Round(PLC.ReadValue[30], 2).ToString("f2");
        }
        private void LabSP_Click(object sender, EventArgs e)
        {
            if (LabSP.BackColor == Color.White)
            {
                KeyForm kf = new KeyForm();
                kf.ImportData(ref LabSP, 0, 2000);
                kf.ShowDialog();
                if (kf.DialogResult == DialogResult.OK)
                {
                    PLC.SendFloat(33, 120, Convert.ToSingle(LabSP.Text));
                    if (PLC.ReadStatus[6] == 1)
                    {
                        Record.WriteIn("液面温度设定", LabSP.Text, "Yellow");
                    }
                }
            }
        }
        private void LabOut_Click(object sender, EventArgs e)
        {
            if (LabOut.BackColor == Color.White)
            {
                KeyForm kf = new KeyForm();
                kf.ImportData(ref LabOut, 0, 150);
                kf.ShowDialog();
                if (kf.DialogResult == DialogResult.OK)
                {
                    PLC.SendFloat(33, 84, Convert.ToSingle(LabOut.Text));
                    if (PLC.ReadStatusIn[13] == 1)
                    {
                        Record.WriteIn("主功率设定", LabOut.Text, "Yellow");
                    }
                }
            }
        }
        private void LabGainVal_Click(object sender, EventArgs e)
        {
            if (LabGainVal.BackColor == Color.White)
            {
                KeyForm kf = new KeyForm();
                kf.ImportData(ref LabGainVal, 0, 200);
                kf.ShowDialog();
                if (kf.DialogResult == DialogResult.OK)
                {
                    PLC.SendFloat(33, 128, Convert.ToSingle(LabGainVal.Text));
                    Record.WriteIn("液面温度控制增益", LabGainVal.Text, "Yellow");
                }
            }
        }
        private void LabDifferVal_Click(object sender, EventArgs e)
        {
            if (LabDifferVal.BackColor == Color.White)
            {
                KeyForm kf = new KeyForm();
                if (BtnTune.BackColor == Color.Fuchsia)
                {
                    kf.ImportData(ref LabDifferVal, 0, 100);
                }
                if (BtnLimit.BackColor == Color.Fuchsia)
                {
                    kf.ImportData(ref LabDifferVal, 0, 150);
                }
                kf.ShowDialog();
                if (kf.DialogResult == DialogResult.OK)
                {
                    if (BtnTune.BackColor == Color.Fuchsia)
                    {
                        PLC.SendFloat(33, 136, Convert.ToSingle(LabDifferVal.Text));
                        Record.WriteIn("液面温度控制微分", LabDifferVal.Text, "Yellow");
                    }
                    if (BtnLimit.BackColor == Color.Fuchsia)
                    {
                        PLC.SendFloat(33, 116, Convert.ToSingle(LabDifferVal.Text));
                        Record.WriteIn("液面温度控制下限", LabDifferVal.Text, "Yellow");
                    }
                }
            }
        }
        private void LabIntegVal_Click(object sender, EventArgs e)
        {
            if (LabIntegVal.BackColor == Color.White)
            {
                KeyForm kf = new KeyForm();
                if (BtnTune.BackColor == Color.Fuchsia)
                {
                    kf.ImportData(ref LabIntegVal, 0, 100);
                }
                if (BtnLimit.BackColor == Color.Fuchsia)
                {
                    kf.ImportData(ref LabIntegVal, 0, 150);
                }
                kf.ShowDialog();
                if (kf.DialogResult == DialogResult.OK)
                {
                    if (BtnTune.BackColor == Color.Fuchsia)
                    {
                        PLC.SendFloat(33, 132, Convert.ToSingle(LabIntegVal.Text));
                        Record.WriteIn("液面温度控制积分", LabIntegVal.Text, "Yellow");
                    }
                    if (BtnLimit.BackColor == Color.Fuchsia)
                    {
                        PLC.SendFloat(33, 112, Convert.ToSingle(LabIntegVal.Text));
                        Record.WriteIn("液面温度控制上限", LabIntegVal.Text, "Yellow");
                    }
                }
            }
        }
        private void BtnON_Click(object sender, EventArgs e)
        {
            if (PLC.ReadStatus[6] == 0)
            {
                PLC.SendBit(30, 9, 1);
                Record.WriteIn("液面温度控制", "ON", "Yellow");
                BtnON.BackColor = Color.Red;
                BtnOFF.BackColor = Color.Blue;
                LabOut.BackColor = Color.Gray;
                if (PLC.ReadStatus[1] == 0)
                {
                    LabSP.BackColor = Color.White;
                }
            }
        }
        private void BtnOFF_Click(object sender, EventArgs e)
        {
            if (PLC.ReadStatus[6] == 1)
            {
                PLC.SendBit(30, 10, 1);
                Record.WriteIn("液面温度控制", "OFF", "Yellow");
                BtnON.BackColor = Color.Blue;
                BtnOFF.BackColor = Color.Red;
                LabOut.BackColor = Color.White;
                if (PLC.ReadStatus[1] == 0)
                {
                    LabSP.BackColor = Color.Gray;
                }
            }
        }
        private void BtnPreAjustTempOn_Click(object sender, EventArgs e)
        {
            PLC.SendBit(30, 125, 1);
            Record.WriteIn("预调温", "ON", "Yellow");
            BtnPreAjustTempOn.BackColor = Color.Red;
            BtnPreAjustTempOff.BackColor = Color.Blue;
            PreTempRunningFlag = true;
        }
        private void BtnPreAjustTempOff_Click(object sender, EventArgs e)
        {
            PLC.SendBit(30, 126, 1);
            Record.WriteIn("预调温", "OFF", "Yellow");
            BtnPreAjustTempOn.BackColor = Color.Blue;
            BtnPreAjustTempOff.BackColor = Color.Red;
            PreTempRunningFlag = false;
        }
        private void BtnManual_Click(object sender, EventArgs e)
        {
            PLC.SendBit(30, 56, 1);
            Record.WriteIn("液面温度控制手动", "ON", "Yellow");
            BtnManual.BackColor = Color.Red;
            BtnAuto.BackColor = Color.Blue;
            if (PLC.ReadStatus[1] == 1)
            {
                LabSP.BackColor = Color.White;
            }
        }
        private void BtnAuto_Click(object sender, EventArgs e)
        {
            PLC.SendBit(30, 57, 1);
            Record.WriteIn("液面温度控制自动", "ON", "Yellow");
            BtnManual.BackColor = Color.Blue;
            BtnAuto.BackColor = Color.Red;
            if (PLC.ReadStatus[1] == 1)
            {
                LabSP.BackColor = Color.Gray;
            }
        }
        private void BtnCheckData_Click(object sender, EventArgs e)
        {
            FrmSwitch.LastForm.Close();
            FrmMeltData fmd = new FrmMeltData();
            FrmSwitch.Open(fmd, 4, new Point(0, 200), new Size(611, 494));
            fmd.Show();
            FrmSwitch.LastForm = fmd;
        }
        private void BtnCoverPre_Click(object sender, EventArgs e)
        {
            if (PLC.ReadStatus[98] == 1)
            {
                PLC.SendBit(30, 141, 0);
                Record.WriteIn("提渣预调温", "ON", "Yellow");
                BtnCoverPre.Text = "开启";
                BtnCoverPre.BackColor = Color.Red;
            }
            else
            {
                PLC.SendBit(30, 141, 1);
                Record.WriteIn("提渣预调温", "OFF", "Yellow");
                BtnCoverPre.Text = "关闭";
                BtnCoverPre.BackColor = Color.Blue;
            }
        }
    }
}
