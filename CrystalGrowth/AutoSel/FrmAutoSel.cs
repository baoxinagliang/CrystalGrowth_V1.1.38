using CrystalGrowth.AuxFunction.License;
using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.AutoSel
{
    internal partial class FrmAutoSel : Form
    {
        bool OnceEnable = false;
        float ProcessSel = 0;
        float LastProcess = 0;
        Button LastButton;
        public FrmAutoSel()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void FrmAutoSel_Load(object sender, EventArgs e)
        {
            BtnSelect.Visible = false;
            BtnCancel.Visible = false;
            LastButton = BtnInit;
            LastProcess = PLC.ReadValue[1];
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (PLC.Count == 2)
            {
                if (LastProcess != PLC.ReadValue[1])
                {
                    LastProcess = PLC.ReadValue[1];
                    OnceEnable = false;
                    LastButton.BackColor = Color.Blue;
                    BtnSelect.Visible = false;
                    BtnCancel.Visible = false;
                }
                if (OnceEnable == false)
                {
                    OnceEnable = true;
                    ButtonShow(PLC.ReadValue[1]);
                }
                //auto jump status display
                CBLeakBack.Checked = PLC.ReadStatus[43] == 1;
                CBPress.Checked = PLC.ReadStatus[44] == 1;
                CBMelt.Checked = PLC.ReadStatus[45] == 1;
                CBStabII.Checked = PLC.ReadStatus[48] == 1;
                CBDip.Checked = PLC.ReadStatus[49] == 1;
                CBNeck.Checked = PLC.ReadStatus[50] == 1;
                CBCrown.Checked = PLC.ReadStatus[51] == 1;
                CBShoulder.Checked = PLC.ReadStatus[52] == 1;
                CBBody.Checked = PLC.ReadStatus[53] == 1;
                CBSegmentTail.Checked = PLC.ReadStatus[54] == 1;
                CBFastTail.Checked = PLC.ReadStatus[55] == 1;
                CBFinishiedTail.Checked = PLC.ReadStatus[46] == 1;
                CBCrysCharing.Checked = PLC.ReadStatus[47] == 1;
                CBCalToShutdown.Checked = PLC.ReadStatus[146] == 1;
            }
        }
        private void ButtonShow(float CurrentProcess)
        {
            InitVisible();
            switch (Math.Round(CurrentProcess, 1).ToString("f1"))
            {
                case "0.0":     //Manual
                    ManualBtn();
                    break;
                case "1.0":     //Init
                    ButtonPositon(ref BtnExitManual, new Point(10, 30));
                    break;
                case "2.0":     //PumpDown
                    ButtonPositon(ref BtnLeakBack, new Point(10, 30));
                    ButtonPositon(ref BtnBackOut, new Point(10, 110));
                    ButtonPositon(ref BtnExitManual, new Point(10, 190));
                    break;
                case "3.0":     //LeakBack
                    ButtonPositon(ref BtnPumpDown, new Point(10, 30));
                    ButtonPositon(ref BtnPressurization, new Point(10, 110));
                    ButtonPositon(ref BtnMelt, new Point(10, 190));
                    ButtonPositon(ref BtnBackOut, new Point(10, 270));
                    ButtonPositon(ref BtnExitManual, new Point(10, 350));
                    break;
                case "4.0":     //Pressurization
                    ButtonPositon(ref BtnMelt, new Point(10, 30));
                    ButtonPositon(ref BtnBackOut, new Point(10, 110));
                    ButtonPositon(ref BtnExitManual, new Point(10, 190));
                    break;
                case "5.0":     //Melting
                    ButtonPositon(ref BtnStabilize, new Point(10, 30));
                    ButtonPositon(ref BtnExitManual, new Point(10, 110));
                    break;
                case "8.0":     //Stabilization
                    ButtonPositon(ref BtnDip, new Point(10, 30));
                    ButtonPositon(ref BtnExitManual, new Point(10, 110));
                    break;
                case "9.0":     //Dip
                    ButtonPositon(ref BtnNeck, new Point(10, 30));
                    ButtonPositon(ref BtnExitManual, new Point(10, 110));
                    break;
                case "10.0":    //Neck
                    ButtonPositon(ref BtnCrown, new Point(10, 30));
                    ButtonPositon(ref BtnExitManual, new Point(10, 110));
                    break;
                case "11.0":    //Crown
                    ButtonPositon(ref BtnShoulder, new Point(10, 30));
                    ButtonPositon(ref BtnExitManual, new Point(10, 110));
                    break;
                case "12.0":    //Shoulder
                    ButtonPositon(ref BtnBody, new Point(10, 30));
                    ButtonPositon(ref BtnExitManual, new Point(10, 110));
                    break;
                case "13.0":    //Body
                    ButtonPositon(ref BtnSegmentTail, new Point(10, 30));
                    ButtonPositon(ref BtnCrystalCold, new Point(10, 110));
                    ButtonPositon(ref BtnSegmentTemp, new Point(10, 190));
                    ButtonPositon(ref BtnExitManual, new Point(10, 270));
                    //ButtonPositon(ref BtnSegmentCrystal, 10, 430);
                    //ButtonPositon(ref BtnExitManual, 150, 30);
                    break;
                case "14.0":    //Tail
                    ButtonPositon(ref BtnShutDown, new Point(10, 30));
                    ButtonPositon(ref BtnCrystalCold, new Point(10, 110));
                    ButtonPositon(ref BtnSegmentTemp, new Point(10, 190));
                    ButtonPositon(ref BtnExitManual, new Point(10, 270));
                    break;
                case "14.1":    //Tail
                    ButtonPositon(ref BtnShutDown, new Point(10, 30));
                    ButtonPositon(ref BtnCrystalCold, new Point(10, 110));
                    ButtonPositon(ref BtnSegmentTemp, new Point(10, 190));
                    ButtonPositon(ref BtnExitManual, new Point(10, 270));
                    break;
                case "15.0":    //FastTail
                    ButtonPositon(ref BtnShutDown, new Point(10, 30));
                    ButtonPositon(ref BtnCrystalCold, new Point(10, 110));
                    ButtonPositon(ref BtnSegmentTemp, new Point(10, 190));
                    ButtonPositon(ref BtnExitManual, new Point(10, 270));
                    break;
                case "16.0":    //Shutdown
                    ButtonPositon(ref BtnExitManual, new Point(10, 30));
                    break;
                case "17.0":    //Isolation
                    ButtonPositon(ref BtnExitManual, new Point(10, 30));
                    break;
                case "18.0":    //Purge
                    ButtonPositon(ref BtnStabilize, new Point(10, 30));
                    ButtonPositon(ref BtnExitManual, new Point(10, 110));
                    break;
                case "19.0":    //BackOut
                    ButtonPositon(ref BtnShutDown, new Point(10, 30));
                    ButtonPositon(ref BtnExitManual, new Point(10, 110));
                    break;
                case "20.0":    //取段加料
                    ButtonPositon(ref BtnExitManual, new Point(10, 30));
                    break;
                case "20.1":    //取段调温
                    ButtonPositon(ref BtnExitManual, new Point(10, 30));
                    break;
                case "20.2":    //取段结晶
                    ButtonPositon(ref BtnShutDown, new Point(10, 30));
                    ButtonPositon(ref BtnExitManual, new Point(10, 110));
                    break;
                case "21.0":    //CoverOut
                    ButtonPositon(ref BtnExitManual, new Point(10, 30));
                    break;
                case "22.0":    //TubeIn
                    ButtonPositon(ref BtnPurge, new Point(10, 30));
                    ButtonPositon(ref BtnExitManual, new Point(10, 110));
                    break;
                case "23.0":    //TubeOut
                    ButtonPositon(ref BtnExitManual, new Point(10, 30));
                    break;
                case "24.0":    //charging
                    ButtonPositon(ref BtnExitManual, new Point(10, 30));
                    break;
                case "25.0":    //seed pull in
                    //ButtonPositon(BtnSeedPullIn, 10, 15)
                    ButtonPositon(ref BtnExitManual, new Point(10, 30));
                    break;
                case "26.0":    //cover rot in
                    //ButtonPositon(BtnCoverRotIn, 10, 15)
                    ButtonPositon(ref BtnExitManual, new Point(10, 30));
                    break;
                case "27.0":   //cover rot out
                    //ButtonPositon(BtnCoverRotOut, 10, 15)
                    ButtonPositon(ref BtnExitManual, new Point(10, 30));
                    break;
                case "28.0":    //炉筒旋回
                    //ButtonPositon(BtnFTRotIn, 10, 15)
                    ButtonPositon(ref BtnExitManual, new Point(10, 30));
                    break;
                case "29.0":    //炉筒旋开
                    //ButtonPositon(BtnFTRotIn, 10, 15)
                    ButtonPositon(ref BtnExitManual, new Point(10, 30));
                    break;
                case "30.0":    //SafeProtect
                    ButtonPositon(ref BtnExitManual, new Point(10, 30));
                    break;
                case "31.0":    //自动装料
                    //ButtonPositon(BtnAutoCharing, 10, 15)
                    ButtonPositon(ref BtnExitManual, new Point(10, 30));
                    break;
                case "32.0":    //回熔
                    //ButtonPositon(BtnReMelting, 10, 15)
                    ButtonPositon(ref BtnExitManual, new Point(10, 30));
                    break;
                case "33.0":    //一键放埚
                    //ButtonPositon(BtnOneKeySetCru, 10, 15)
                    ButtonPositon(ref BtnExitManual, new Point(10, 30));
                    break;
                case "34.0":  //硅料预热
                    ButtonPositon(ref BtnTubeIn, new Point(10, 30));
                    ButtonPositon(ref BtnExitManual, new Point(10, 110));
                    break;
                case "35.0":  //自动拆炉
                    ButtonPositon(ref BtnExitManual, new Point(10, 30));
                    break;
            }
            BtnPumpDown.Enabled = CurrentProcess != 0.0;
            Panel2.Enabled = PLC.ReadStatus[79] != 1;
        }
        private void ManualBtn()
        {
            ButtonPositon(ref BtnInit, new Point(10, 30));
            ButtonPositon(ref BtnPumpDown, new Point(10, 110));
            ButtonPositon(ref BtnLeakBack, new Point(10, 190));
            ButtonPositon(ref BtnPressurization, new Point(10, 270));
            ButtonPositon(ref BtnMelt, new Point(10, 350));
            ButtonPositon(ref BtnStabilize, new Point(10, 430));

            ButtonPositon(ref BtnDip, new Point(150, 30));
            ButtonPositon(ref BtnNeck, new Point(150, 110));
            ButtonPositon(ref BtnCrown, new Point(150, 190));
            ButtonPositon(ref BtnShoulder, new Point(150, 270));
            ButtonPositon(ref BtnBody, new Point(150, 350));
            ButtonPositon(ref BtnShutDown, new Point(150, 430));

            ButtonPositon(ref BtnSegmentTail, new Point(290, 29));
            //ButtonPositon(ref BtnFinishedTail, 290, 109);
            //ButtonPositon(ref BtnFastTail, 290, 189);
            ButtonPositon(ref BtnIsolation, new Point(290, 270));
            ButtonPositon(ref BtnPurge, new Point(290, 350));
            ButtonPositon(ref BtnBackOut, new Point(290, 430));

            ButtonPositon(ref BtnCrystalCold, new Point(430, 30));
            ButtonPositon(ref BtnSegmentTemp, new Point(430, 110));
            ButtonPositon(ref BtnSegmentCrystal, new Point(430, 189));
            ButtonPositon(ref BtnCoverOut, new Point(430, 270));
            ButtonPositon(ref BtnSeedPullIn, new Point(430, 350));
            //ButtonPositon(ref BtnAutoCharing, 430, 430);
            ButtonPositon(ref BtnPullOut, new Point(583, 189));
            ButtonPositon(ref BtnSiliconPreheat, new Point(583, 270));
            //ButtonPositon(ref BtnReMelting, 584, 350);
            //ButtonPositon(ref BtnOneKeySetCru, 583, 430);

            ButtonPositon(ref BtnFTRotOut, new Point(583, 30));
            ButtonPositon(ref BtnFTRotIn, new Point(583, 110));

            ButtonPositon(ref BtnCoverRotOut, new Point(725, 30));
            ButtonPositon(ref BtnCoverRotIn, new Point(725, 110));

            ButtonPositon(ref BtnTubeIn, new Point(725, 190));
            //ButtonPositon(ref BtnCharging, 725, 268);
            ButtonPositon(ref BtnTubeOut, new Point(725, 347));           
        }
        private void InitVisible()
        {
            BtnInit.Visible = false;
            BtnPumpDown.Visible = false;
            BtnLeakBack.Visible = false;
            BtnPressurization.Visible = false;
            BtnMelt.Visible = false;
            BtnStabilize.Visible = false;
            BtnDip.Visible = false;
            BtnNeck.Visible = false;
            BtnCrown.Visible = false;
            BtnShoulder.Visible = false;
            BtnBody.Visible = false;
            BtnSegmentTail.Visible = false;
            BtnFinishedTail.Visible = false;
            BtnFastTail.Visible = false;
            BtnShutDown.Visible = false;
            BtnIsolation.Visible = false;
            BtnPurge.Visible = false;
            BtnBackOut.Visible = false;
            BtnCrystalCold.Visible = false;
            BtnSegmentTemp.Visible = false;
            BtnSegmentCrystal.Visible = false;
            BtnCoverOut.Visible = false;
            BtnTubeIn.Visible = false;
            BtnTubeOut.Visible = false;
            BtnSeedPullIn.Visible = false;
            BtnCoverRotIn.Visible = false;
            BtnCoverRotOut.Visible = false;
            BtnCharging.Visible = false;
            BtnFTRotIn.Visible = false;
            BtnFTRotOut.Visible = false;
            BtnPullOut.Visible = false;
            BtnAutoCharing.Visible = false;
            BtnReMelting.Visible = false;
            BtnOneKeySetCru.Visible = false;
            BtnSiliconPreheat.Visible = false;
            BtnExitManual.Visible = false;
        }
        private void ButtonPositon(ref Button CurrentBtn, Point pointLoc)
        {
            CurrentBtn.Location = pointLoc;
            CurrentBtn.Visible = true;
        }
        private void ButtonColor(ref Button CurrentBtn, float CurrentSel)
        {
            if (LastButton.BackColor == Color.Blue)
            {
                CurrentBtn.BackColor = Color.Red;
                LastButton = CurrentBtn;
                ProcessSel = CurrentSel;
                BtnSelect.Visible = true;
                BtnCancel.Visible = true;
            }
        }
        private void BtnInit_Click(object sender, EventArgs e)
        {
            ButtonColor(ref BtnInit, 1);
        }
        private void BtnPumpDown_Click(object sender, EventArgs e)
        {
            ButtonColor(ref BtnPumpDown, 2);
        }
        private void BtnLeakBack_Click(object sender, EventArgs e)
        {
            ButtonColor(ref BtnLeakBack, 3);
        }
        private void BtnPressurization_Click(object sender, EventArgs e)
        {
            ButtonColor(ref BtnPressurization, 4);
        }
        private void BtnMelt_Click(object sender, EventArgs e)
        {
            ButtonColor(ref BtnMelt, 5);
        }
        private void BtnStabilize_Click(object sender, EventArgs e)
        {
            ButtonColor(ref BtnStabilize, 8);
        }
        private void BtnDip_Click(object sender, EventArgs e)
        {
            ButtonColor(ref BtnDip, 9);
        }
        private void BtnNeck_Click(object sender, EventArgs e)
        {
            ButtonColor(ref BtnNeck, 10);
        }
        private void BtnCrown_Click(object sender, EventArgs e)
        {
            ButtonColor(ref BtnCrown, 11);
        }
        private void BtnShoulder_Click(object sender, EventArgs e)
        {
            ButtonColor(ref BtnShoulder, 12);
        }
        private void BtnBody_Click(object sender, EventArgs e)
        {
            ButtonColor(ref BtnBody, 13);
        }
        private void BtnSegmentTail_Click(object sender, EventArgs e)
        {
            ButtonColor(ref BtnSegmentTail, 14);
        }
        private void BtnFinishedTail_Click(object sender, EventArgs e)
        {
            ButtonColor(ref BtnFinishedTail, 14.1f);
        }
        private void BtnFastTail_Click(object sender, EventArgs e)
        {
            ButtonColor(ref BtnFastTail, 15);
        }
        private void BtnShutDown_Click(object sender, EventArgs e)
        {
            ButtonColor(ref BtnShutDown, 16);
        }
        private void BtnIsolation_Click(object sender, EventArgs e)
        {
            ButtonColor(ref BtnIsolation, 17);
        }
        private void BtnPurge_Click(object sender, EventArgs e)
        {
            ButtonColor(ref BtnPurge, 18);
        }
        private void BtnBackOut_Click(object sender, EventArgs e)
        {
            ButtonColor(ref BtnBackOut, 19);
        }
        private void BtnSegmentTemp_Click(object sender, EventArgs e)
        {
            ButtonColor(ref BtnSegmentTemp, 20.1f);
        }
        private void BtnSegmentCrystal_Click(object sender, EventArgs e)
        {
            ButtonColor(ref BtnSegmentCrystal, 20.2f);
        }
        private void BtnCoverOut_Click(object sender, EventArgs e)
        {
            ButtonColor(ref BtnCoverOut, 21);
        }
        private void BtnCrystalCold_Click(object sender, EventArgs e)
        {
            ButtonColor(ref BtnCrystalCold, 20);
        }
        private void BtnTubeIn_Click(object sender, EventArgs e)
        {
            ButtonColor(ref BtnTubeIn, 22);
        }
        private void BtnTubeOut_Click(object sender, EventArgs e)
        {
            ButtonColor(ref BtnTubeOut, 23);
        }
        private void BtnCharging_Click(object sender, EventArgs e)
        {
            ButtonColor(ref BtnCharging, 24);
        }
        private void BtnSeedPullIn_Click(object sender, EventArgs e)
        {
            ButtonColor(ref BtnSeedPullIn, 25);
        }
        private void BtnCoverRotIn_Click(object sender, EventArgs e)
        {
            ButtonColor(ref BtnCoverRotIn, 26);
        }
        private void BtnCoverRotOut_Click(object sender, EventArgs e)
        {
            ButtonColor(ref BtnCoverRotOut, 27);
        }
        private void BtnFTRotIn_Click(object sender, EventArgs e)
        {
            ButtonColor(ref BtnFTRotIn, 28);
        }
        private void BtnFTRotOut_Click(object sender, EventArgs e)
        {
            ButtonColor(ref BtnFTRotOut, 29);
        }
        private void BtnAutoCharing_Click(object sender, EventArgs e)
        {
            ButtonColor(ref BtnAutoCharing, 31);
        }
        private void BtnReMelting_Click(object sender, EventArgs e)
        {
            ButtonColor(ref BtnReMelting, 32);
        }
        private void BtnOneKeySetCru_Click(object sender, EventArgs e)
        {
            ButtonColor(ref BtnOneKeySetCru, 33);
        }
        private void BtnSiliconPreheat_Click(object sender, EventArgs e)
        {
            ButtonColor(ref BtnSiliconPreheat, 34);
        }
        private void BtnPullOut_Click(object sender, EventArgs e)
        {
            ButtonColor(ref BtnPullOut, 35);
        }
        private void BtnExitManual_Click(object sender, EventArgs e)
        {
            ButtonColor(ref BtnExitManual, 0);
        }
        private void BtnSelect_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnSelect))
            {
                LastButton.BackColor = Color.Blue;
                BtnSelect.Visible = false;
                BtnCancel.Visible = false;
                if (License.IsSystemCanRun() || ProcessSel == 0)
                {
                    Record.WriteIn("手动进入", string.Concat(ProcState.CurrentState(Math.Round(ProcessSel, 1).ToString("f1")), "工序"), "Yellow");
                    PLC.SendFloat(33, 0, ProcessSel);
                    FrmSwitch.OpenAutoForm();
                }
            }
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            LastButton.BackColor = Color.Blue;
            BtnSelect.Visible = false;
            BtnCancel.Visible = false;
        }
        private void CBLeakBack_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref CBLeakBack))
            {
                if (CBLeakBack.Checked)
                {
                    CBLeakBack.Checked = false;
                    PLC.SendBit(32, 42, 0);
                    Record.WriteIn("抽空->检漏", "OFF", "Yellow");
                }
                else
                {
                    CBLeakBack.Checked = true;
                    PLC.SendBit(32, 42, 1);
                    Record.WriteIn("抽空->检漏", "ON", "Yellow");
                }
            }
        }
        private void CBPress_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref CBPress))
            {
                if (CBPress.Checked)
                {
                    CBPress.Checked = false;
                    PLC.SendBit(32, 43, 0);
                    Record.WriteIn("检漏->压力化", "OFF", "Yellow");
                }
                else
                {
                    CBPress.Checked = true;
                    PLC.SendBit(32, 43, 1);
                    Record.WriteIn("检漏->压力化", "ON", "Yellow");
                }
            }
        }
        private void CBMelt_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref CBMelt))
            {
                if (CBMelt.Checked)
                {
                    CBMelt.Checked = false;
                    PLC.SendBit(32, 44, 0);
                    Record.WriteIn("压力化->熔料", "OFF", "Yellow");
                }
                else
                {
                    CBMelt.Checked = true;
                    PLC.SendBit(32, 44, 1);
                    Record.WriteIn("压力化->熔料", "ON", "Yellow");
                }
            }
        }
        private void CBStabII_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref CBStabII))
            {
                if (CBStabII.Checked)
                {
                    CBStabII.Checked = false;
                    PLC.SendBit(32, 47, 0);
                    Record.WriteIn("熔料->预热/熔接", "OFF", "Yellow");
                }
                else
                {
                    CBStabII.Checked = true;
                    PLC.SendBit(32, 47, 1);
                    Record.WriteIn("熔料->预热/熔接", "ON", "Yellow");
                }
            }
        }
        private void CBDip_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref CBDip))
            {
                if (CBDip.Checked)
                {
                    CBDip.Checked = false;
                    PLC.SendBit(32, 48, 0);
                    Record.WriteIn("熔接->调温", "OFF", "Yellow");
                }
                else
                {
                    CBDip.Checked = true;
                    PLC.SendBit(32, 48, 1);
                    Record.WriteIn("熔接->调温", "ON", "Yellow");
                }
            }
        }
        private void CBNeck_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref CBNeck))
            {
                if (CBNeck.Checked)
                {
                    CBNeck.Checked = false;
                    PLC.SendBit(32, 49, 0);
                    Record.WriteIn("调温->引晶", "OFF", "Yellow");
                }
                else
                {
                    CBNeck.Checked = true;
                    PLC.SendBit(32, 49, 1);
                    Record.WriteIn("调温->引晶", "ON", "Yellow");
                }
            }
        }
        private void CBCrown_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref CBCrown))
            {
                if (CBCrown.Checked)
                {
                    CBCrown.Checked = false;
                    PLC.SendBit(32, 50, 0);
                    Record.WriteIn("引晶->放肩", "OFF", "Yellow");
                }
                else
                {
                    CBCrown.Checked = true;
                    PLC.SendBit(32, 50, 1);
                    Record.WriteIn("引晶->放肩", "ON", "Yellow");
                }
            }
        }
        private void CBShoulder_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref CBShoulder))
            {
                if (CBShoulder.Checked)
                {
                    CBShoulder.Checked = false;
                    PLC.SendBit(32, 51, 0);
                    Record.WriteIn("放肩->转肩", "OFF", "Yellow");
                }
                else
                {
                    CBShoulder.Checked = true;
                    PLC.SendBit(32, 51, 1);
                    Record.WriteIn("放肩->转肩", "ON", "Yellow");
                }
            }
        }
        private void CBBody_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref CBBody))
            {
                if (CBBody.Checked)
                {
                    CBBody.Checked = false;
                    PLC.SendBit(32, 52, 0);
                    Record.WriteIn("转肩->等径", "OFF", "Yellow");
                }
                else
                {
                    CBBody.Checked = true;
                    PLC.SendBit(32, 52, 1);
                    Record.WriteIn("转肩->等径", "ON", "Yellow");
                }
            }
        }
        private void CBSegmentTail_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref CBSegmentTail))
            {
                if (CBSegmentTail.Checked)
                {
                    PLC.SendBit(32, 53, 0);
                    CBSegmentTail.Checked = false;
                    Record.WriteIn("等径->取段收尾", "OFF", "Yellow");
                }
                else
                {
                    if (CBFinishiedTail.Checked == false && CBFastTail.Checked == false)
                    {
                        PLC.SendBit(32, 53, 1);
                        CBSegmentTail.Checked = true;
                        Record.WriteIn("等径->取段收尾", "ON", "Yellow");
                    }
                }
            }
        }
        private void CBFinishiedTail_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref CBFinishiedTail))
            {
                if (CBFinishiedTail.Checked)
                {
                    PLC.SendBit(32, 45, 0);
                    CBFinishiedTail.Checked = false;
                    Record.WriteIn("等径->完结段收尾", "OFF", "Yellow");
                }
                else
                {
                    if (CBSegmentTail.Checked == false && CBFastTail.Checked == false)
                    {
                        PLC.SendBit(32, 45, 1);
                        CBFinishiedTail.Checked = true;
                        Record.WriteIn("等径->完结段收尾", "ON", "Yellow");
                    }
                }
            }
        }
        private void CBFastTail_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref CBFastTail))
            {
                if (CBFastTail.Checked)
                {
                    PLC.SendBit(32, 54, 0);
                    CBFastTail.Checked = false;
                    Record.WriteIn("等径->快速收尾", "OFF", "Yellow");
                }
                else
                {
                    if (CBSegmentTail.Checked == false && CBFinishiedTail.Checked == false)
                    {
                        PLC.SendBit(32, 54, 1);
                        CBFastTail.Checked = true;
                        Record.WriteIn("等径->快速收尾", "ON", "Yellow");
                    }
                }
            }
        }
        private void CBCrysCharing_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref CBCrysCharing))
            {
                if (CBCrysCharing.Checked)
                {
                    CBCrysCharing.Checked = false;
                    PLC.SendBit(32, 46, 0);
                    Record.WriteIn("取段收尾->取段结晶加料", "OFF", "Yellow");
                }
                else
                {
                    CBCrysCharing.Checked = true;
                    PLC.SendBit(32, 46, 1);
                    Record.WriteIn("取段收尾->取段结晶加料", "ON", "Yellow");
                }
            }
        }
        private void CBCalToShutdown_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref CBCalToShutdown))
            {
                if (CBCalToShutdown.Checked)
                {
                    CBCalToShutdown.Checked = false;
                    PLC.SendBit(32, 145, 0);
                    Record.WriteIn("煅烧->停炉", "OFF", "Yellow");
                }
                else
                {
                    CBCalToShutdown.Checked = true;
                    PLC.SendBit(32, 145, 1);
                    Record.WriteIn("煅烧->停炉", "ON", "Yellow");
                }
            }
        }
    }
}
