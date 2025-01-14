using CrystalGrowth.AutoSel;
using CrystalGrowth.AuxFunction;
using CrystalGrowth.AuxFunction.CCD;
using CrystalGrowth.AuxFunction.License;
using CrystalGrowth.AuxFunction.MainTain;
using CrystalGrowth.GasVacuum;
using CrystalGrowth.GrowRecord;
using CrystalGrowth.SOP;
using CrystalGrowth.Trend;
using CrystalGrowth.Unities;
using CrystalGrowth.VarShow;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CrystalGrowth.CrystalCtl
{
    internal partial class FrmMain : Form
    {
        public static string StateTime = "00:00:00";
        public static string RunTime = "00:00:00";
        public static float LastValue = 0;
        public static Button LastCtlBtn;

        LastInputInfo lastInputInf;
        DateTime LastTime;
        TimeSpan ts;
        /// <summary>
        /// 全局参数
        /// </summary>
        public static Parameter GlobalParameter = new Parameter();
        public FrmMain()
        {
            InitializeComponent();
            // 加载全局参数
            if (!Parameter.DeSerialize(FileHelper.ParameterPath, ref GlobalParameter) || GlobalParameter == null)
            {
                MessageBox.Show("全局参数加载失败，请检查配置文件是否存在!");
            }
            ParasCam1.MeltGapAbsMeasure_T = FrmMain.GlobalParameter.MeltGapAbsMeasure_T;
            ParasCam1.MeltGapAbsMeasure_H = FrmMain.GlobalParameter.MeltGapAbsMeasure_H;
            ParasCam1.MeltGapAbsMeasure_R = FrmMain.GlobalParameter.MeltGapAbsMeasure_R;
            ParasCam1.MeltGapAbsMeasure_OffSet = FrmMain.GlobalParameter.MeltGapAbsMeasure_OffSet;
            ParasCam1.MeltGapAbsFilterNum = FrmMain.GlobalParameter.MeltGapAbsFilterNum;

            lastInputInf = new LastInputInfo();
            LabAlarm.Click += Panel3_Click;
            LabAlarm.Click += BtnRecord_Click;
            LabAutoStat.Click += Panel3_Click;
            LabCameraStatus.Click += Panel3_Click;
            Panel2.Click += Panel3_Click;
            LabStatus.Click += Panel3_Click;
            Load += Timer1_Tick;
            Load += Timer2_Tick;
            ProcState.LoadWeightEvent += LoadWeight;
            FrmShieldMeasure.ShieldAlarmEvent += ShieldCheckForm;
            FrmSwitch.LastMainBtn = BtnFurnaceCtl;
            Panel3.BackColor = Panel2.BackColor;
            ActiveControl = LabStatus;
            LastCtlBtn = BtnSeedLift;
        }
        public static FrmMain Single;
        public static FrmMain CreateInstrance()
        {
            if (Single == null)
            {
                Single = new FrmMain();
                Single.FormClosed += Single_FormClosed;
            }
            return Single;
        }
        static void Single_FormClosed(object sender, FormClosedEventArgs e)
        {
            Single = null;
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            Log.Record(ComputerInfo.Get());
            License.ExpirationDelayTime = License.GetDelayTime();
            License.Read();
            License.Check();
            Calibrate.ReadOut();
            FrmMeltTemp.InitGrowthData();
            Alarm.LoadInfo();
            IdNum.ReadOut();
            DualCam.ReadOut();
            ParasCam1.ReadOut();
            ParasCam2.ReadOut();
            new TData();
            FrmVarTable fvr = FrmVarTable.CreateInstrance();
            FrmSwitch.Open(fvr, 0, new Point(638, 200), new Size(636, 485));
            FrmTrend ft = FrmTrend.CreateInstrance();
            FrmSwitch.Open(ft, 65, new Point(0, 130), new Size(1366, 638));
            FrmMeltGapPopUp fmgp = FrmMeltGapPopUp.CreateInstrance();
            FrmSwitch.Open(fmgp, 201, new Point(638, 195), new Size(650, 30));
            FrmImage fig = FrmImage.CreateInstance();
            FrmSwitch.Open(fig, 200, new Point(638, 225), new Size(650, 475));
            FrmSwitch.OpenAutoForm();
            CrucPara.ReadOut();
            CrystalCalc.Weight();
            SqliteHelper.CreateLoginDB();
            SqliteHelper.CreateDatabase();
            Timer1.Enabled = true;
            Timer2.Enabled = true;
            Timer3.Enabled = true;
            fvr.Show();
            DualCam.Load();
            PLC.HeartBeatMonitor();
        }
        private void BtnDiaCtl_Click(object sender, EventArgs e)
        {
            if (Timer5.Enabled == false) { Timer5.Enabled = true; }
            FrmSwitch.LastForm.Close();
            FrmDiaCtl fdc = new FrmDiaCtl();
            FrmSwitch.Open(fdc, 1, new Point(0, 200), new Size(500, 494));
            fdc.Show();
            FrmSwitch.LastForm = fdc;
            LastCtlBtn.BackColor = LastCtlBtn.BackColor != Color.Green ? Color.RoyalBlue : Color.Lime;
            LastCtlBtn = BtnDiaCtl;
            BtnDiaCtl.BackColor = PLC.ReadStatus[2] == 1 ? Color.Green : Color.DarkSlateGray;
        }
        private void BtnDiaRateCtl_Click(object sender, EventArgs e)
        {
            if (Timer5.Enabled == false) { Timer5.Enabled = true; }
            FrmSwitch.LastForm.Close();
            FrmDiaRateCtl fdrc = new FrmDiaRateCtl();
            FrmSwitch.Open(fdrc, 1, new Point(0, 200), new Size(500, 494));
            fdrc.Show();
            FrmSwitch.LastForm = fdrc;
            LastCtlBtn.BackColor = LastCtlBtn.BackColor != Color.Green ? Color.RoyalBlue : Color.Lime;
            LastCtlBtn = BtnDiaRateCtl;
            BtnDiaRateCtl.BackColor = PLC.ReadStatus[100] == 1 ? Color.Green : Color.DarkSlateGray;
        }
        private void BtnHtrCtl_Click(object sender, EventArgs e)
        {
            if (Timer5.Enabled == false) { Timer5.Enabled = true; }
            FrmSwitch.LastForm.Close();
            FrmHtrTemp fht = new FrmHtrTemp();
            FrmSwitch.Open(fht, 2, new Point(0, 200), new Size(394, 494));
            fht.Show();
            FrmSwitch.LastForm = fht;
            LastCtlBtn.BackColor = LastCtlBtn.BackColor != Color.Green ? Color.RoyalBlue : Color.Lime;
            LastCtlBtn = BtnHtrCtl;
            BtnHtrCtl.BackColor = PLC.ReadStatus[5] == 1 ? Color.Green : Color.DarkSlateGray;
        }
        private void BtnPowerRate_Click(object sender, EventArgs e)
        {
            if (Timer5.Enabled == false) { Timer5.Enabled = true; }
            if (PLC.ReadStatus[57] == 1)
            {
                FrmSwitch.LastForm.Close();
                FrmPowerRate fpr = new FrmPowerRate();
                FrmSwitch.Open(fpr, 3, new Point(0, 200), new Size(394, 380));
                fpr.Show();
                FrmSwitch.LastForm = fpr;
            }
            else
            {
                FrmSwitch.LastForm.Close();
                FrmTempRate ftr = new FrmTempRate();
                FrmSwitch.Open(ftr, 3, new Point(0, 200), new Size(394, 380));
                ftr.Show();
                FrmSwitch.LastForm = ftr;
            }
            LastCtlBtn.BackColor = LastCtlBtn.BackColor != Color.Green ? Color.RoyalBlue : Color.Lime;
            LastCtlBtn = BtnPowerRate;
            BtnPowerRate.BackColor = PLC.ReadStatus[4] == 1 || PLC.ReadStatus[28] == 1 ? Color.Green : Color.DarkSlateGray;
        }
        private void BtnMeltTemp_Click(object sender, EventArgs e)
        {
            if (Timer5.Enabled == false) { Timer5.Enabled = true; }
            FrmSwitch.LastForm.Close();
            FrmMeltTemp fmt = new FrmMeltTemp();
            FrmSwitch.Open(fmt, 4, new Point(0, 200), new Size(611, 494));
            fmt.Show();
            FrmSwitch.LastForm = fmt;
            LastCtlBtn.BackColor = LastCtlBtn.BackColor != Color.Green ? Color.RoyalBlue : Color.Lime;
            LastCtlBtn = BtnMeltTemp;
            BtnMeltTemp.BackColor = PLC.ReadStatus[6] == 1 ? Color.Green : Color.DarkSlateGray;
        }
        private void BtnGrowCtl_Click(object sender, EventArgs e)
        {
            if (Timer5.Enabled == false) { Timer5.Enabled = true; }
            if (PLC.ReadStatus[57] == 1)
            {
                FrmSwitch.LastForm.Close();
                FrmGrowCtl fgc = new FrmGrowCtl();
                FrmSwitch.Open(fgc, 5, new Point(0, 200), new Size(394, 494));
                fgc.Show();
                FrmSwitch.LastForm = fgc;
            }
            else
            {
                FrmSwitch.LastForm.Close();
                FrmGrowCtlTemp fgct = new FrmGrowCtlTemp();
                FrmSwitch.Open(fgct, 5, new Point(0, 200), new Size(394, 494));
                fgct.Show();
                FrmSwitch.LastForm = fgct;
            }
            LastCtlBtn.BackColor = LastCtlBtn.BackColor != Color.Green ? Color.RoyalBlue : Color.Lime;
            LastCtlBtn = BtnGrowCtl;
            BtnGrowCtl.BackColor = PLC.ReadStatus[3] == 1 ? Color.Green : Color.DarkSlateGray;
        }
        private void BtnMeltPos_Click(object sender, EventArgs e)
        {
            if (Timer5.Enabled == false) { Timer5.Enabled = true; }
            FrmSwitch.LastForm.Close();
            FrmCLSL fccl = new FrmCLSL();
            FrmSwitch.Open(fccl, 6, new Point(0, 200), new Size(394, 380));
            fccl.Show();
            FrmSwitch.LastForm = fccl;
            LastCtlBtn.BackColor = LastCtlBtn.BackColor != Color.Green ? Color.RoyalBlue : Color.Lime;
            LastCtlBtn = BtnMeltPos;
            BtnMeltPos.BackColor = PLC.ReadStatus[7] == 1 ? Color.Green : Color.DarkSlateGray;
        }
        private void BtnMeltGap_Click(object sender, EventArgs e)
        {
            if (Timer5.Enabled == false) { Timer5.Enabled = true; }
            FrmSwitch.LastForm.Close();
            FrmMeltGap fmg = new FrmMeltGap();
            FrmSwitch.Open(fmg, 7, new Point(0, 200), new Size(531, 494));
            fmg.Show();
            FrmSwitch.LastForm = fmg;
            LastCtlBtn.BackColor = LastCtlBtn.BackColor != Color.Green ? Color.RoyalBlue : Color.Lime;
            LastCtlBtn = BtnMeltGap;
            BtnMeltGap.BackColor = PLC.ReadStatus[9] == 1 ? Color.Green : Color.DarkSlateGray;
        }
        private void BtnPressCtl_Click(object sender, EventArgs e)
        {
            if (Timer5.Enabled == false) { Timer5.Enabled = true; }
            FrmSwitch.LastForm.Close();
            FrmPressCtl fpc = new FrmPressCtl();
            FrmSwitch.Open(fpc, 8, new Point(0, 200), new Size(394, 380));
            fpc.Show();
            FrmSwitch.LastForm = fpc;
            LastCtlBtn.BackColor = LastCtlBtn.BackColor != Color.Green ? Color.RoyalBlue : Color.Lime;
            LastCtlBtn = BtnPressCtl;
            BtnPressCtl.BackColor = PLC.ReadStatus[10] == 1 ? Color.Green : Color.DarkSlateGray;
        }
        private void BtnSeedLift_Click(object sender, EventArgs e)
        {
            if (Timer5.Enabled == false) { Timer5.Enabled = true; }
            FrmSwitch.LastForm.Close();
            FrmSeedLift fsl = new FrmSeedLift();
            FrmSwitch.Open(fsl, 9, new Point(0, 200), new Size(531, 494));
            fsl.Show();
            FrmSwitch.LastForm = fsl;
            LastCtlBtn.BackColor = LastCtlBtn.BackColor != Color.Green ? Color.RoyalBlue : Color.Lime;
            LastCtlBtn = BtnSeedLift;
            BtnSeedLift.BackColor = Color.Red;
        }
        private void BtnCrucLift_Click(object sender, EventArgs e)
        {
            if (Timer5.Enabled == false) { Timer5.Enabled = true; }
            BeginInvoke(new Action(() =>
            {
                DialogResult dr = MessageBox.Show("请确认是否要打开埚升界面？", "埚升提示", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    FrmSwitch.LastForm.Close();
                    FrmCrucLift fcl = new FrmCrucLift();
                    FrmSwitch.Open(fcl, 11, new Point(0, 200), new Size(531, 494));
                    fcl.Show();
                    FrmSwitch.LastForm = fcl;
                    LastCtlBtn.BackColor = LastCtlBtn.BackColor != Color.Green ? Color.RoyalBlue : Color.Lime;
                    LastCtlBtn = BtnCrucLift;
                    BtnCrucLift.BackColor = Color.Red;
                }
            }));
        }
        private void BtnSeedRot_Click(object sender, EventArgs e)
        {
            if (Timer5.Enabled == false) { Timer5.Enabled = true; }
            FrmSwitch.LastForm.Close();
            FrmSeedRot fsr = new FrmSeedRot();
            FrmSwitch.Open(fsr, 12, new Point(0, 200), new Size(394, 380));
            fsr.Show();
            FrmSwitch.LastForm = fsr;
            LastCtlBtn.BackColor = LastCtlBtn.BackColor != Color.Green ? Color.RoyalBlue : Color.Lime;
            LastCtlBtn = BtnSeedRot;
            BtnSeedRot.BackColor = Color.Red;
        }
        private void BtnCrucRot_Click(object sender, EventArgs e)
        {
            if (Timer5.Enabled == false) { Timer5.Enabled = true; }
            FrmSwitch.LastForm.Close();
            FrmCrucRot fcr = new FrmCrucRot();
            FrmSwitch.Open(fcr, 14, new Point(0, 200), new Size(394, 380));
            fcr.Show();
            FrmSwitch.LastForm = fcr;
            LastCtlBtn.BackColor = LastCtlBtn.BackColor != Color.Green ? Color.RoyalBlue : Color.Lime;
            LastCtlBtn = BtnCrucRot;
            BtnCrucRot.BackColor = Color.Red;
        }
        private void BtnHtrPower_Click(object sender, EventArgs e)
        {
            if (Timer5.Enabled == false) { Timer5.Enabled = true; }
            FrmSwitch.LastForm.Close();
            FrmPowerCtl fpc = new FrmPowerCtl();
            FrmSwitch.Open(fpc, 16, new Point(0, 200), new Size(394, 494));
            fpc.Show();
            FrmSwitch.LastForm = fpc;
            LastCtlBtn.BackColor = LastCtlBtn.BackColor != Color.Green ? Color.RoyalBlue : Color.Lime;
            LastCtlBtn = BtnHtrPower;
            BtnHtrPower.BackColor = Color.DarkSlateGray;
        }
        private void BtnCrucPos_Click(object sender, EventArgs e)
        {
            if (Timer5.Enabled == false) { Timer5.Enabled = true; }
            FrmSwitch.LastForm.Close();
            FrmCrucPos fcp = new FrmCrucPos();
            FrmSwitch.Open(fcp, 18, new Point(0, 200), new Size(394, 480));
            fcp.Show();
            FrmSwitch.LastForm = fcp;
            LastCtlBtn.BackColor = LastCtlBtn.BackColor != Color.Green ? Color.RoyalBlue : Color.Lime;
            LastCtlBtn = BtnCrucPos;
            BtnCrucPos.BackColor = Color.DarkSlateGray;
        }
        private void BtnShieldPos_Click(object sender, EventArgs e)
        {
            if (Timer5.Enabled == false) { Timer5.Enabled = true; }
            FrmSwitch.LastForm.Close();
            FrmShieldPos fsp = new FrmShieldPos();
            FrmSwitch.Open(fsp, 19, new Point(0, 200), new Size(586, 494));
            fsp.Show();
            FrmSwitch.LastForm = fsp;
            LastCtlBtn.BackColor = LastCtlBtn.BackColor != Color.Green ? Color.RoyalBlue : Color.Lime;
            LastCtlBtn = BtnShieldPos;
            BtnShieldPos.BackColor = Color.DarkSlateGray;
        }
        private void BtnFurnaceCtl_Click(object sender, EventArgs e)
        {
            FrmSwitch.LastFormClose();
            FrmSwitch.OpenAutoForm();
            if (Timer5.Enabled) { Timer5.Enabled = false; }
        }
        private void BtnMagnetic_Click(object sender, EventArgs e)
        {
            FrmSwitch.LastForm.Close();
            FrmCCD fccd = new FrmCCD();
            FrmSwitch.Open(fccd, 150, new Point(0, 50), new Size(1366, 718));
            fccd.Show();
            FrmSwitch.LastForm = fccd;
            LastCtlBtn.BackColor = LastCtlBtn.BackColor != Color.Green ? Color.RoyalBlue : Color.Lime;
            LastCtlBtn = BtnMagnetic;
            BtnMagnetic.BackColor = Color.Red;
        }
        private void BtnGasVaccum_Click(object sender, EventArgs e)
        {
            if (Timer5.Enabled == false) { Timer5.Enabled = true; }
            FrmGasVacuum fgvm = new FrmGasVacuum();
            if (!ReferenceEquals(FrmSwitch.LastForm, fgvm))
            {
                FrmSwitch.LastFormClose();
                FrmSwitch.Open(fgvm, 60, new Point(0, 130), new Size(1366, 638));
                fgvm.Show();
                FrmSwitch.LastForm = fgvm;
                FrmSwitch.LastMainBtn.BackColor = Color.Blue;
                FrmSwitch.LastMainBtn = BtnGasVaccum;
                BtnGasVaccum.BackColor = Color.DarkSlateGray;
            }
        }
        private void BtnTrend_Click(object sender, EventArgs e)
        {
            if (Timer5.Enabled == false) { Timer5.Enabled = true; }
            if (!ReferenceEquals(FrmSwitch.LastForm, FrmTrend.Single))
            {
                FrmSwitch.LastFormClose();
                if (FrmTrend.Single.Visible == false)
                {
                    FrmTrend.Single.BringToFront();
                    FrmTrend.Single.Visible = true;
                }
                FrmSwitch.LastForm = FrmTrend.Single;
                FrmSwitch.LastMainBtn.BackColor = Color.Blue;
                FrmSwitch.LastMainBtn = BtnTrend;
                BtnTrend.BackColor = Color.DarkSlateGray;
            }
        }
        private void BtnSOP_Click(object sender, EventArgs e)
        {
            if (Timer5.Enabled == false) { Timer5.Enabled = true; }
            ProcSel psl = ProcSel.CreateInstrance();
            if (!ReferenceEquals(FrmSwitch.LastForm, psl))
            {
                FrmSwitch.LastFormClose();
                FrmSwitch.Open(psl, 70, new Point(0, 130), new Size(1366, 638));
                psl.Show();
                FrmSwitch.LastForm = psl;
                FrmSwitch.LastMainBtn.BackColor = Color.Blue;
                FrmSwitch.LastMainBtn = BtnSOP;
                BtnSOP.BackColor = Color.DarkSlateGray;
            }
        }
        private void BtnRecord_Click(object sender, EventArgs e)
        {
            if (Timer5.Enabled == false) { Timer5.Enabled = true; }
            if (Application.OpenForms["FrmAutoID"] != null || Application.OpenForms["FrmAutoCheck"] != null) { return; }
            FrmGrowRecord fgrd = new FrmGrowRecord();
            if (!ReferenceEquals(FrmSwitch.LastForm, fgrd))
            {
                FrmSwitch.LastFormClose();
                FrmSwitch.Open(fgrd, 100, new Point(0, 130), new Size(1366, 638));
                fgrd.Show();
                FrmSwitch.LastForm = fgrd;
                FrmSwitch.LastMainBtn.BackColor = Color.Blue;
                FrmSwitch.LastMainBtn = BtnRecord;
                BtnRecord.BackColor = Color.DarkSlateGray;
            }
        }
        private void BtnAux_Click(object sender, EventArgs e)
        {
            if (Timer5.Enabled == false) { Timer5.Enabled = true; }
            FrmAuxFunc faf = new FrmAuxFunc();
            if (!ReferenceEquals(FrmSwitch.LastForm, faf))
            {
                FrmSwitch.LastFormClose();
                FrmSwitch.Open(faf, 110, new Point(0, 130), new Size(1366, 638));
                FrmSwitch.LastForm = faf;
                FrmSwitch.LastMainBtn.BackColor = Color.Blue;
                FrmSwitch.LastMainBtn = BtnAux;
                BtnAux.BackColor = Color.DarkSlateGray;
                faf.Show();
            }
        }
        private void BtnVarShow_Click(object sender, EventArgs e)
        {
            if (Timer5.Enabled == false) { Timer5.Enabled = true; }
            FrmVarShow fvsw1 = new FrmVarShow();
            if (!ReferenceEquals(FrmSwitch.LastForm, fvsw1))
            {
                FrmSwitch.LastFormClose();
                FrmSwitch.Open(fvsw1, 200, new Point(0, 130), new Size(1366, 638));
                fvsw1.Show();
                FrmSwitch.LastForm = fvsw1;
                FrmSwitch.LastMainBtn.BackColor = Color.Blue;
                FrmSwitch.LastMainBtn = BtnVarShow;
                BtnVarShow.BackColor = Color.DarkSlateGray;
            }
        }
        private void BtnAutoSel_Click(object sender, EventArgs e)
        {
            if (Timer5.Enabled == false) { Timer5.Enabled = true; }
            FrmAutoSel fas = new FrmAutoSel();
            if (!ReferenceEquals(FrmSwitch.LastForm, fas))
            {
                FrmSwitch.LastFormClose();
                FrmSwitch.Open(fas, 210, new Point(0, 130), new Size(1366, 638));
                fas.Show();
                FrmSwitch.LastForm = fas;
                FrmSwitch.LastMainBtn.BackColor = Color.Blue;
                FrmSwitch.LastMainBtn = BtnAutoSel;
                BtnAutoSel.BackColor = Color.DarkSlateGray;
            }
        }
        private void BtnManuConfirm_Click(object sender, EventArgs e)
        {
            if (Timer5.Enabled == false) { Timer5.Enabled = true; }
            FrmSwitch.LastForm.Close();
            FrmHUIConfirmPopUp fhcpu = new FrmHUIConfirmPopUp();
            FrmSwitch.Open(fhcpu, 160, new Point(0, 200), new Size(600, 494));
            fhcpu.Show();
            FrmSwitch.LastForm = fhcpu;
            LastCtlBtn.BackColor = LastCtlBtn.BackColor != Color.Green ? Color.RoyalBlue : Color.Lime;
            LastCtlBtn = BtnManuConfirm;
            BtnManuConfirm.BackColor = Color.DarkSlateGray;
        }
        private void BtnSafeProtect_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnSafeProtect))
            {
                BeginInvoke(new Action(() =>
                {
                    if (MessageBox.Show("请确认是否启动紧急安全保护程序？", "紧急安全保护", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Record.WriteIn("紧急保护按钮被触发，已确认启动！", "", "Red");
                        PLC.SendBit(30, 177, 1);
                        FrmSwitch.OpenAutoForm();
                    }
                    else
                    {
                        Record.WriteIn("紧急保护按钮被触发，已确认取消！", "", "Red");
                    }
                }));
            }
        }
        private void Panel3_Click(object sender, EventArgs e)
        {
            PLC.SendBit(30, 79, 0);//send alarm audible off
            PLC.SendBit(30, 95, 0);//send status show audible off
            PLC.SendBit(30, 124, 1);//关闭液口距自动校准报警
            License.IsExpire = false;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            PLC.ReadFromPlc();
        }
        private void Timer2_Tick(object sender, EventArgs e)
        {
            StateTime = PLC.ReadValue[63].TimeToStr();
            RunTime = PLC.ReadValue[71].TimeToStr();
            LabTime.Text = DateTime.Now.ToString("HH:mm:ss");
            ts = DateTime.Now.Subtract(LastTime);
            if (ts.Days != 0 || ts.Hours < 0)
            {
                if (ts.Hours < 0)
                {
                    License.WriteDate(LastTime.ToString("yyyy-MM-dd HH:mm:ss"));
                }
                License.Read();
                License.Check();
                LastTime = DateTime.Now;
            }
            License.RegDelayCheck();
            Sop.WriteData(); //Write Calibration Value and SOP
            ProcState.ChangeRecord();//Status Change Record          
            MainStatusDisPlay(); //Main Form Status Display              
            CrystalCalc.GrowSpeed();//calculate Grow Speed          
            CrystalCalc.CrownDegree();//calculate Crown Degree
            Alarm.Output();//Alarm 
            if (PLC.ReadStatus[63] == 1) { PLC.SendBit(30, 87, 1); }//Comm check
            FrmTimer.CountDown();//Timer
            CrystalCalc.WeightSafe();//Weight Protect
            Calibrate.GetMeltGapGain();    //Get Melt Gap Auto Calibration Gain Then Save To File      
            ProcState.TubeInOut();//料筒提入提出
            FrmCrownTrack.RecordCrownTrack();
            if (PLC.ReadStatus[104] == 1)
            {
                if (ProcState.FeedManualFlag == false)
                {
                    BeginInvoke(new Action(() =>
                    {
                        FrmFeedManual ffm = new FrmFeedManual();
                        ffm.ShowDialog();
                    }));
                }
                ProcState.FeedManualFlag = true;
            }
            else
            {
                ProcState.FeedManualFlag = false;
            }
        }
        private void Timer3_Tick(object sender, EventArgs e)
        {
            SqliteHelper.BeginRecord();//写入数据
            HotHandle.IsStart = FrmVarTable.VarValue[16] == "OFF" ? "false" : "true";//加热器是否打开
        }
        private void Timer4_Tick(object sender, EventArgs e)
        {
            if (PLC.ReadStatusIn[26] == 1)
            {
                ProcState.DownStatusFlag = false;
                if (ProcState.UpStatusFlag == false)
                {
                    Record.WriteIn("   ->引晶器-晶体上升", "ON", "Yellow");
                    Record.WriteIn("   ->当前开始上升位置", Math.Round(PLC.ReadAnalogValue[35], 1).ToString("f1"), "Yellow");
                    ProcState.UpStatusFlag = true;
                }
            }
            else
            {
                ProcState.UpStatusFlag = false;
                if (PLC.ReadStatusIn[28] == 1 && ProcState.DownStatusFlag == false)
                {
                    Record.WriteIn("   ->引晶器-晶体下降", "ON", "Yellow");
                    Record.WriteIn("   ->当前开始下降位置", Math.Round(PLC.ReadAnalogValue[35], 1).ToString("f1"), "Yellow");
                    ProcState.DownStatusFlag = true;
                }
            }
        }
        private void Timer5_Tick(object sender, EventArgs e)
        {
            lastInputInf.cbSize = Marshal.SizeOf(lastInputInf);
            lastInputInf.dwTime = 0;
            if (ExternDll.GetLastInputInfo(ref lastInputInf) && FrmMaintainLock.LockFormFlag == false)
            {
                if ((Environment.TickCount - lastInputInf.dwTime) / 1000 > 120)
                {
                    if (Application.OpenForms["FullKey"] != null) { Application.OpenForms["FullKey"].Close(); }
                    if (Application.OpenForms["SmallKey"] != null) { Application.OpenForms["SmallKey"].Close(); }
                    if (Application.OpenForms["KeyForm"] != null) { Application.OpenForms["KeyForm"].Close(); }
                    FrmSwitch.OpenAutoForm();
                    Level.MeltGapSafe = false;
                    Level.MeltGapLArea = false;
                    Timer5.Enabled = false;
                }
            }
        }
        private void LoadWeight()
        {
            BeginInvoke(new Action(() =>
            {
                FrmFeedConfirm ffcm = new FrmFeedConfirm();
                ffcm.ShowDialog();
            }));
        }
        private void ShieldCheckForm(string strInfo)
        {
            BeginInvoke(new Action<string>((strMsg) =>
            {
                FrmMsgBox fmb = new FrmMsgBox(strMsg)
                {
                    Location = new Point(100, 233)
                };
                fmb.ShowDialog();
                if (fmb.DialogResult == DialogResult.OK)
                {
                    Record.WriteIn("导流筒校准参数按钮", "OK", "Yellow");
                }
                if (fmb.DialogResult == DialogResult.Cancel)
                {
                    Record.WriteIn("导流筒校准参数按钮取消", "Cannel", "Yellow");
                }
            }), strInfo);
        }

        private void MainStatusDisPlay()
        {
            if (PLC.ReadStatus[57] == 1)
            {
                BtnHtrCtl.Visible = false;
                BtnPowerRate.Text = "主功率\r\n变化速率";
            }
            else
            {
                BtnHtrCtl.Visible = true;
                BtnPowerRate.Text = "热场温度\r\n变化速率";
            }
            if (ReferenceEquals(FrmSwitch.LastMainBtn, BtnFurnaceCtl))
            {
                if (PLC.ReadStatus[2] == 1)
                {
                    BtnDiaCtl.BackColor = ReferenceEquals(LastCtlBtn, BtnDiaCtl) ? Color.Green : Color.Lime;
                }
                else
                {
                    BtnDiaCtl.BackColor = ReferenceEquals(LastCtlBtn, BtnDiaCtl) ? Color.DarkSlateGray : Color.RoyalBlue;
                }
                if (PLC.ReadStatus[100] == 1)
                {
                    BtnDiaRateCtl.BackColor = ReferenceEquals(LastCtlBtn, BtnDiaRateCtl) ? Color.Green : Color.Lime;
                }
                else
                {
                    BtnDiaRateCtl.BackColor = ReferenceEquals(LastCtlBtn, BtnDiaRateCtl) ? Color.DarkSlateGray : Color.RoyalBlue;
                }
                if (PLC.ReadStatus[5] == 1)
                {
                    BtnHtrCtl.BackColor = ReferenceEquals(LastCtlBtn, BtnHtrCtl) ? Color.Green : Color.Lime;
                }
                else
                {
                    BtnHtrCtl.BackColor = ReferenceEquals(LastCtlBtn, BtnHtrCtl) ? Color.DarkSlateGray : Color.RoyalBlue;
                }
                if (PLC.ReadStatus[4] == 1 || PLC.ReadStatus[28] == 1)
                {
                    BtnPowerRate.BackColor = ReferenceEquals(LastCtlBtn, BtnPowerRate) ? Color.Green : Color.Lime;
                }
                else
                {
                    BtnPowerRate.BackColor = ReferenceEquals(LastCtlBtn, BtnPowerRate) ? Color.DarkSlateGray : Color.RoyalBlue;
                }
                if (PLC.ReadStatus[6] == 1)
                {
                    BtnMeltTemp.BackColor = ReferenceEquals(LastCtlBtn, BtnMeltTemp) ? Color.Green : Color.Lime;
                }
                else
                {
                    BtnMeltTemp.BackColor = ReferenceEquals(LastCtlBtn, BtnMeltTemp) ? Color.DarkSlateGray : Color.RoyalBlue;
                }
                if (PLC.ReadStatus[3] == 1)
                {
                    BtnGrowCtl.BackColor = ReferenceEquals(LastCtlBtn, BtnGrowCtl) ? Color.Green : Color.Lime;
                }
                else
                {
                    BtnGrowCtl.BackColor = ReferenceEquals(LastCtlBtn, BtnGrowCtl) ? Color.DarkSlateGray : Color.RoyalBlue;
                }
                if (PLC.ReadStatus[7] == 1)
                {
                    BtnMeltPos.BackColor = ReferenceEquals(LastCtlBtn, BtnMeltPos) ? Color.Green : Color.Lime;
                }
                else
                {
                    BtnMeltPos.BackColor = ReferenceEquals(LastCtlBtn, BtnMeltPos) ? Color.DarkSlateGray : Color.RoyalBlue;
                }
                if (PLC.ReadStatus[9] == 1)
                {
                    BtnMeltGap.BackColor = ReferenceEquals(LastCtlBtn, BtnMeltGap) ? Color.Green : Color.Lime;
                }
                else
                {
                    BtnMeltGap.BackColor = ReferenceEquals(LastCtlBtn, BtnMeltGap) ? Color.DarkSlateGray : Color.RoyalBlue;
                }
                if (PLC.ReadStatus[10] == 1)
                {
                    BtnPressCtl.BackColor = ReferenceEquals(LastCtlBtn, BtnPressCtl) ? Color.Green : Color.Lime;
                }
                else
                {
                    BtnPressCtl.BackColor = ReferenceEquals(LastCtlBtn, BtnPressCtl) ? Color.DarkSlateGray : Color.RoyalBlue;
                }
            }
            if (LastValue != PLC.ReadValue[1])
            {
                LastValue = PLC.ReadValue[1];
                if (PLC.ReadValue[1] == 1)
                {
                    FrmAutoID fai = new FrmAutoID();
                    FrmSwitch.Open(fai, 211, new Point(0, 60), new Size(1366, 708));
                    fai.Show();
                }
                else
                {
                    FrmSwitch.OpenAutoForm();
                }
                Panel2.BackColor = PLC.ReadValue[1] == 0 ? Color.Yellow : Color.Green;
                LabStatus.Text = ProcState.CurrentState(Math.Round(PLC.ReadValue[1], 1).ToString("f1"));
            }
        }
        public void MinForm()
        {
            WindowState = FormWindowState.Minimized;
            Record.WriteIn("软件最小化", "", "Yellow");
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Level.UserName))
            {
                LastInputInfo buf = new LastInputInfo();
                buf.cbSize = Marshal.SizeOf(buf);
                buf.dwTime = 0;
                if (ExternDll.GetLastInputInfo(ref buf))
                {
                    if ((Environment.TickCount - buf.dwTime) / 1000 > 60)
                    {
                        //登录信息签退
                        Level.UserName = "";
                    }
                }
            }
        }
    }
}
