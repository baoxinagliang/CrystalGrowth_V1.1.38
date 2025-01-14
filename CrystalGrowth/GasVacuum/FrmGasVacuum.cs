using CrystalGrowth.CrystalCtl;
using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.GasVacuum
{
    internal partial class FrmGasVacuum : Form
    {
        double tempFTPress = 0;
        double tempPCPress = 0;
        ValvePic Valve;
        public FrmGasVacuum()
        {
            InitializeComponent();
            Valve = new ValvePic();
            Load += Timer1_Tick;
        }
        private void FrmGasVacuum_FormClosed(object sender, FormClosedEventArgs e)
        {
            Valve.Dispose();
            Valve = null;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (PLC.Count == 2)
            {
                LabGasFlowPV.Text = Math.Round(PLC.ReadAnalogValue[1], 1).ToString("f1");
                LabThrotPV.Text = Math.Round(PLC.ReadAnalogValue[6], 1).ToString("f1");
                LabFTLowPress.Text = PLC.ReadAnalogValue[4] < 1000 ? Math.Round(PLC.ReadAnalogValue[4], 1).ToString("f1") : "---";
                //气体倒计时报警
                LabTime1.Text = PLC.ReadValue[97].ToString();
                LabTime2.Text = PLC.ReadValue[98].ToString();
                //对射开关
                LabTime3.Text = PLC.ReadValue[102].ToString();
                //主室百托真空计       
                if (PLC.ReadCalibValue[48] != 0)
                {
                    if (PLC.ReadCalibValue[47] > 0)
                    {
                        tempFTPress = Math.Round(PLC.ReadAnalogValue[5] / PLC.ReadCalibValue[48], 1);
                    }
                    else
                    {
                        tempFTPress = Math.Round(PLC.ReadAnalogValue[5] / PLC.ReadCalibValue[48] - PLC.ReadCalibValue[47], 1);
                    }
                    LabFTPress.Text = tempFTPress < 100.0 ? Math.Round(PLC.ReadAnalogValue[5], 1).ToString("f1") : "---";
                }
                //副室千托真空计      
                if (Math.Round(PLC.ReadCalibValue[46], 1) != 0)
                {
                    if (Math.Round(PLC.ReadCalibValue[45], 1) > 0)
                    {
                        tempPCPress = Math.Round(PLC.ReadAnalogValue[7] / PLC.ReadCalibValue[46], 1);
                    }
                    else
                    {
                        tempPCPress = Math.Round(PLC.ReadAnalogValue[7] / PLC.ReadCalibValue[46] - PLC.ReadCalibValue[45], 1);
                    }
                    LabPCPress.Text = tempPCPress < 1000 ? Math.Round(PLC.ReadAnalogValue[7], 1).ToString("f1") : "---";
                }
                LabPCPress.Text = Math.Round(PLC.ReadAnalogValue[7], 1).ToString("f1");
                LabGasFlowSP.Text = Math.Round(PLC.ReadValue[62], 1).ToString("f1");
                LabThrotSP.Text = Math.Round(PLC.ReadValue[46], 1).ToString("f1");
                LabFastPress.Text = Math.Round(PLC.ReadValue[66], 1).ToString("f1");
                LabAtmosThr.Text = Math.Round(PLC.ReadCalibValue[35], 1).ToString("f1");
                if (PLC.ReadStatus[88] == 1)
                {
                    //开
                    LabLockingStatus.BackColor = Color.Red;
                    LabLockingStatus.Text = "锁紧";
                }
                else if (PLC.ReadStatus[89] == 1)
                {
                    //关
                    LabLockingStatus.BackColor = Color.Lime;
                    LabLockingStatus.Text = "松开";
                }
                else
                {
                    LabLockingStatus.BackColor = Color.Yellow;
                    LabLockingStatus.Text = "";
                }
                if (PLC.ReadStatusIn[90] == 1)
                {
                    //开
                    LabClampingStatus.BackColor = Color.Red;
                    LabClampingStatus.Text = "夹爪锁紧";
                }
                else if (PLC.ReadStatusIn[91] == 1)
                {
                    //关
                    LabClampingStatus.BackColor = Color.Lime;
                    LabClampingStatus.Text = "夹爪松开";
                }
                else
                {
                    //其他
                    LabClampingStatus.BackColor = Color.Yellow;
                    LabClampingStatus.Text = "";
                }
                BtnLockingClose.BackColor = PLC.ReadStatus[88] == 1 ? Color.Red : Color.Blue;
                BtnLockingOpen.BackColor = PLC.ReadStatus[89] == 1 ? Color.Red : Color.Blue;
                //LabFastPress.BackColor = PLCConn.ReadStatus[1] == 0 ? Color.White : Color.Gray;
                LabThrotPVTxt.Text = PLC.ReadStatus[60] == 0 ? "节流阀开度(%)" : "干泵频率(%)";
                LabThrotSPTxt.Text = PLC.ReadStatus[60] == 0 ? "节流阀开度设定" : "干泵频率设定";
                BtnIsoOpen.BackColor = PLC.ReadStatusIn[36] == 1 ? Color.Lime : Color.Blue;
                BtnIsoClose.BackColor = PLC.ReadStatusIn[34] == 0 && PLC.ReadStatusIn[48] == 1 ? Color.Lime : Color.Red;
                if (PLC.ReadStatusIn[34] == 1 && PLC.ReadStatusIn[48] == 1)
                {
                    BtnIsoValve.BackColor = Color.Red;
                }
                else if (PLC.ReadStatusIn[36] == 1)
                {
                    BtnIsoValve.BackColor = Color.Lime;
                }
                else
                {
                    BtnIsoValve.BackColor = Color.Yellow;
                }
                LabPCUp.BackColor = PLC.ReadStatusIn[47] == 0 ? Color.Red : Color.Lime;
                LabIsoOpen.BackColor = PLC.ReadStatusIn[36] == 0 ? Color.Red : Color.Lime;
                LabPCDown.BackColor = PLC.ReadStatusIn[48] == 0 ? Color.Red : Color.Lime;
                LabIsoClose.BackColor = PLC.ReadStatusIn[34] == 0 ? Color.Red : Color.Lime;
                BtnSuppUp.BackColor = PLC.ReadStatusIn[45] == 1 ? Color.Red : Color.Blue;
                BtnSuppDown.BackColor = PLC.ReadStatusIn[46] == 1 ? Color.Red : Color.Blue;
                if (PLC.ReadStatusOut[9] == 1)
                {
                    PicBurnVal.Image = PLC.ReadStatusOut[18] == 1 ? Valve.Open : Valve.Close;
                }
                else
                {
                    PicBurnVal.Image = PLC.ReadStatusOut[18] == 1 ? Valve.AutoOpen : Valve.AutoClose;
                }
                PicEmergencyVal.Image = PLC.ReadStatusOut[51] == 1 ? Valve.Open : Valve.Close;
                if (PLC.ReadStatus[1] == 1)
                {

                    PicUpGas.Image = PLC.ReadStatusOut[14] == 1 ? Valve.AutoOpen : Valve.AutoClose;
                    PicDownGas.Image = PLC.ReadStatusOut[13] == 1 ? Valve.AutoOpen : Valve.AutoClose;
                    PicDownGasBak.Image = PLC.ReadStatusOut[17] == 1 ? Valve.AutoOpen : Valve.AutoClose;
                    PicUpFast.Image = PLC.ReadStatusOut[19] == 1 ? Valve.AutoOpen : Valve.AutoClose;
                    PicPCVal.Image = PLC.ReadStatusOut[10] == 1 ? Valve.AutoOpen : Valve.AutoClose;
                    PicFTVal.Image = PLC.ReadStatusOut[9] == 1 ? Valve.AutoOpen : Valve.AutoClose;
                }
                else
                {
                    PicUpGas.Image = PLC.ReadStatusOut[14] == 1 ? Valve.Open : Valve.Close;
                    PicDownGas.Image = PLC.ReadStatusOut[13] == 1 ? Valve.Open : Valve.Close;
                    PicDownGasBak.Image = PLC.ReadStatusOut[17] == 1 ? Valve.Open : Valve.Close;
                    PicUpFast.Image = PLC.ReadStatusOut[19] == 1 ? Valve.Open : Valve.Close;
                    PicPCVal.Image = PLC.ReadStatusOut[10] == 1 ? Valve.Open : Valve.Close;
                    PicFTVal.Image = PLC.ReadStatusOut[9] == 1 ? Valve.Open : Valve.Close;
                    PicFilterGas.Image = PLC.ReadStatusOut[38] == 1 ? Valve.Open : Valve.Close;
                }
                PicPumpMain.Image = PLC.ReadStatusIn[15] == 1 ? Valve.PumpOn : Valve.PumpOff;
                PicPumpAuxiliary.Image = PLC.ReadStatusIn[16] == 1 ? Valve.PumpOn : Valve.PumpOff;
            }
            if (PLC.ReadStatusIn[97] == 1)
            {
                //关0
                LabFTSwitch.BackColor = Color.Red;
                LabFTSwitch.Text = "关";
            }
            else if (PLC.ReadStatusIn[96] == 1)
            {
                //开1
                LabFTSwitch.BackColor = Color.Lime;
                LabFTSwitch.Text = "开";
            }
            else
            {
                //其他
                LabFTSwitch.BackColor = Color.Yellow;
                LabFTSwitch.Text = "";
            }
            if (PLC.ReadStatusIn[42] == 1)
            {
                //关0
                LabShootingSwitch.BackColor = Color.Red;
                LabShootingSwitch.Text = "OFF";
            }
            else
            {
                //开1
                LabShootingSwitch.BackColor = Color.Lime;
                LabShootingSwitch.Text = "ON";
            }
        }
        private void LabGasFlowSP_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm();
            kf.ImportData(ref LabGasFlowSP, 0, 200);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                PLC.SendFloat(33, 244, Convert.ToSingle(LabGasFlowSP.Text));
                Record.WriteIn("氩气流量设定", LabGasFlowSP.Text, "Yellow");
            }
        }
        private void LabThrotSP_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm();
            kf.ImportData(ref LabThrotSP, 0, 100);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                PLC.SendFloat(33, 180, Convert.ToSingle(LabThrotSP.Text));
                if (PLC.ReadStatus[60] == 0)
                {
                    Record.WriteIn("节流阀开度设定", LabThrotSP.Text, "Yellow");
                }
                else
                {
                    Record.WriteIn("主泵频率设定", LabThrotSP.Text, "Yellow");
                }
            }
        }
        private void LabFastPress_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm();
            kf.ImportData(ref LabFastPress, 0, 1000);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                PLC.SendFloat(33, 260, Convert.ToSingle(LabFastPress.Text));
                Record.WriteIn("快充压力设定", LabFastPress.Text, "Yellow");
            }
        }
        private void PicUpGas_Click(object sender, EventArgs e)
        {
            if (PLC.ReadStatus[1] == 0)
            {
                if (PLC.ReadStatusOut[14] == 1)
                {
                    PLC.SendBit(30, 40, 1);
                    Record.WriteIn("上氩气阀", "OFF", "Yellow");
                    PicUpGas.Image = Valve.Close;
                }
                else
                {
                    PLC.SendBit(30, 39, 1);
                    Record.WriteIn("上氩气阀", "ON", "Yellow");
                    PicUpGas.Image = Valve.Open;
                }
            }
        }
        private void PicUpFast_Click(object sender, EventArgs e)
        {
            if (PLC.ReadStatus[1] == 0)
            {
                if (PLC.ReadStatusOut[19] == 1)
                {
                    PicUpFast.Image = Valve.Close;
                    PLC.SendBit(30, 98, 1);
                    Record.WriteIn("快充阀", "OFF", "Yellow");
                }
                else
                {
                    PicUpFast.Image = Valve.Open;
                    PLC.SendBit(30, 97, 1);
                    Record.WriteIn("快充阀", "ON", "Yellow");
                }
            }
        }
        private void PicDownGas_Click(object sender, EventArgs e)
        {
            if (PLC.ReadStatus[1] == 0)
            {
                if (PLC.ReadStatusOut[13] == 1)
                {
                    PicDownGas.Image = Valve.Close;
                    PLC.SendBit(30, 44, 1);
                    Record.WriteIn("下氩气阀", "OFF", "Yellow");
                }
                else
                {
                    PicDownGas.Image = Valve.Open;
                    PLC.SendBit(30, 43, 1);
                    Record.WriteIn("下氩气阀", "ON", "Yellow");
                }
            }
        }
        private void PicDownGasBak_Click(object sender, EventArgs e)
        {
            if (PLC.ReadStatus[1] == 0)
            {
                if (PLC.ReadStatusOut[17] == 1)
                {
                    PicDownGasBak.Image = Valve.Close;
                    PLC.SendBit(30, 42, 1);
                    Record.WriteIn("下氩气备用阀", "OFF", "Yellow");
                }
                else
                {
                    PicDownGasBak.Image = Valve.Open;
                    PLC.SendBit(30, 41, 1);
                    Record.WriteIn("下氩气备用阀", "ON", "Yellow");
                }
            }
        }
        private void PicPCVal_Click(object sender, EventArgs e)
        {
            if (PLC.ReadStatus[1] == 0)
            {
                if (PLC.ReadStatusOut[10] == 1)
                {
                    PicPCVal.Image = Valve.Close;
                    PLC.SendBit(30, 46, 1);
                    Record.WriteIn("副真空阀", "OFF", "Yellow");
                }
                else
                {
                    PicPCVal.Image = Valve.Open;
                    PLC.SendBit(30, 45, 1);
                    Record.WriteIn("副真空阀", "ON", "Yellow");
                }
            }
        }
        private void PicFTVal_Click(object sender, EventArgs e)
        {
            if (PLC.ReadStatus[1] == 0)
            {
                if (PLC.ReadStatusOut[9] == 1)
                {
                    PicFTVal.Image = Valve.Close;
                    PLC.SendBit(30, 48, 1);
                    Record.WriteIn("主真空阀", "OFF", "Yellow");
                }
                else
                {
                    PicFTVal.Image = Valve.Open;
                    PLC.SendBit(30, 47, 1);
                    Record.WriteIn("主真空阀", "ON", "Yellow");
                }
            }
        }
        private void PicBurnVal_Click(object sender, EventArgs e)
        {
            if (PLC.ReadStatusOut[9] == 1)
            {
                if (DouClick.ThreeSec(ref PicBurnVal))
                {
                    if (PLC.ReadStatusOut[18] == 1)
                    {
                        PicBurnVal.Image = Valve.Close;
                        PLC.SendBit(30, 76, 1);
                        Record.WriteIn("燃烧阀", "OFF", "Yellow");
                    }
                    else
                    {
                        PicBurnVal.Image = Valve.Open;
                        PLC.SendBit(30, 75, 1);
                        Record.WriteIn("燃烧阀", "ON", "Yellow");
                    }
                }
            }
        }
        private void BtnIsoOpen_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnIsoOpen))
            {
                PLC.SendBit(30, 49, 1);
                Record.WriteIn("隔离阀", "ON", "Yellow");
                Record.WriteIn("   晶体位置", Math.Round(PLC.ReadAnalogValue[35], 1).ToString("f1"), "Yellow");
            }
        }
        private void BtnIsoClose_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnIsoClose))
            {
                PLC.SendBit(30, 60, 1);
                Record.WriteIn("隔离阀", "OFF", "Yellow");
                Record.WriteIn("   晶体位置", Math.Round(PLC.ReadAnalogValue[35], 1).ToString("f1"), "Yellow");
            }
        }
        private void BtnSuppUp_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnSuppUp))
            {
                PLC.SendBit(30, 77, 1);
                Record.WriteIn("晶体支架", "ON", "Yellow");
            }
        }
        private void BtnSuppDown_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnSuppDown))
            {
                PLC.SendBit(30, 78, 1);
                Record.WriteIn("晶体支架", "OFF", "Yellow");
            }
        }
        private void BtnLockingClose_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnLockingClose))
            {
                PLC.SendBit(30, 128, 1);
                Record.WriteIn("锁紧环锁紧", "ON", "Yellow");
            }
        }
        private void BtnLockingOpen_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnLockingOpen))
            {
                PLC.SendBit(30, 129, 1);
                Record.WriteIn("锁紧环松开", "ON", "Yellow");
            }
        }
        private void PicFilterGas_Click(object sender, EventArgs e)
        {
            if (PLC.ReadStatus[1] == 0)
            {
                if (PLC.ReadStatusOut[38] == 1)
                {
                    PicFilterGas.Image = Valve.Close;
                    PLC.SendBit(30, 146, 1);
                    Record.WriteIn("过滤罐排气阀", "OFF", "Yellow");
                }
                else
                {
                    PicFilterGas.Image = Valve.Open;
                    PLC.SendBit(30, 145, 1);
                    Record.WriteIn("过滤罐排气阀", "ON", "Yellow");
                }
            }
        }
        private void BtnClampingGrasp_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnClampingGrasp))
            {
                PLC.SendBit(30, 149, 1);
                Record.WriteIn("夹爪锁紧", "ON", "Yellow");
            }
        }
        private void BtnClampingLoosen_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnClampingLoosen))
            {
                PLC.SendBit(30, 150, 1);
                Record.WriteIn("夹爪松开", "ON", "Yellow");
            }
        }
        private void PicEmergencyVal_Click(object sender, EventArgs e)
        {
            if (PLC.ReadStatus[1] == 0)
            {
                if (PLC.ReadStatusOut[51] == 1)
                {
                    PicEmergencyVal.Image = Valve.Close;
                    PLC.SendBit(30, 148, 1);
                    Record.WriteIn("应急阀", "OFF", "Yellow");
                }
                else
                {
                    if (MessageBox.Show("请确认是否打开应急阀?", "应急阀", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        PicEmergencyVal.Image = Valve.Open;
                        PLC.SendBit(30, 147, 1);
                        Record.WriteIn("应急阀", "ON", "Yellow");
                    }
                }
            }
        }
    }
}
