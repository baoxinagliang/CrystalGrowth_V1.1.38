using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.CrystalCtl
{
    internal partial class FrmHUIConfirmPopUp : Form
    {
        public FrmHUIConfirmPopUp()
        {
            InitializeComponent();
        }
        private void FrmHUIConfirmPopUp_Load(object sender, EventArgs e)
        {
            LabCruPlaceOK.Visible = false;
            BtnCruPlaceOK.Visible = false;
            LabClampGrasp.Visible = false;
            BtnClampGrasp.Visible = false;
            LabClampLoosen.Visible = false;
            BtnClampLoosen.Visible = false;
            LabDownShield.Visible = false;
            BtnDownShield.Visible = false;
            LabDownCru.Visible = false;
            BtnDownCru.Visible = false;
            LabReMeltCalc.Visible = false;
            LabReMeltCalcVal.Visible = false;
            LabReMeltFeedback.Visible = false;
            LabReMeltFeedbackVal.Visible = false;
            BtnReMeltConfirm.Visible = false;
        }
        private void BtnCruPlaceOK_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnCruPlaceOK))
            {
                PLC.SendBit(30, 135, 1);
                Record.WriteIn("坩埚到位确认", "ON", "Yellow");
            }
        }

        private void BtnClampGrasp_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnClampGrasp))
            {
                PLC.SendBit(30, 136, 1);
                Record.WriteIn("夹爪夹紧到位，可以提升悬臂确认", "ON", "Yellow");
            }
        }
        private void BtnClampLoosen_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnClampLoosen))
            {
                PLC.SendBit(30, 137, 1);
                Record.WriteIn("夹爪松开到位，可以提升悬臂确认", "ON", "Yellow");
            }
        }
        private void LabReMeltFeedbackVal_Click(object sender, EventArgs e)
        {
            if (LabReMeltFeedbackVal.BackColor == Color.White)
            {
                KeyForm kf = new KeyForm();
                kf.ImportData(ref LabReMeltFeedbackVal, 0, 2000);
                kf.ShowDialog();
                if (kf.DialogResult == DialogResult.OK)
                {
                    PLC.SendFloat(33, 360, Convert.ToSingle(LabReMeltFeedbackVal.Text));
                }
            }
        }
        private void BtnReMeltConfirm_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnReMeltConfirm))
            {
                PLC.SendBit(30, 138, 1);
                Record.WriteIn("回熔长度反馈值确认", "ON", "Yellow");
            }
        }
        private void BtnDownShield_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnDownShield))
            {
                PLC.SendBit(30, 139, 1);
                Record.WriteIn("已确认坩埚处于下限位置，可以降热屏确认", "ON", "Yellow");
            }
        }
        private void BtnDownCru_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnDownCru))
            {
                PLC.SendBit(30, 140, 1);
                Record.WriteIn("已确认液口距测量线正确位置，可以自动降埚确认", "ON", "Yellow");
            }
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (PLC.Count == 2)
            {
                LabReMeltCalcVal.Text = Math.Round(PLC.ReadValue[90], 2).ToString("f2");
                LabReMeltFeedbackVal.Text = Math.Round(PLC.ReadValue[91], 2).ToString("f2");
                if (PLC.StatusAlarm[176] == 1)
                {
                    LabCruPlaceOK.Visible = true;
                    BtnCruPlaceOK.Visible = true;
                }
                else
                {
                    LabCruPlaceOK.Visible = false;
                    BtnCruPlaceOK.Visible = false;
                }
                if (PLC.StatusAlarm[175] == 1)
                {
                    LabClampGrasp.Visible = true;
                    BtnClampGrasp.Visible = true;
                }
                else
                {
                    LabClampGrasp.Visible = false;
                    BtnClampGrasp.Visible = false;
                }
                if (PLC.StatusAlarm[174] == 1)
                {
                    LabClampLoosen.Visible = true;
                    BtnClampLoosen.Visible = true;
                }
                else
                {
                    LabClampLoosen.Visible = false;
                    BtnClampLoosen.Visible = false;
                }
                if (PLC.StatusAlarm[178] == 1)
                {
                    LabReMeltCalc.Visible = true;
                    LabReMeltCalcVal.Visible = true;
                    LabReMeltFeedback.Visible = true;
                    LabReMeltFeedbackVal.Visible = true;
                    BtnReMeltConfirm.Visible = true;
                }
                else
                {
                    LabReMeltCalc.Visible = false;
                    LabReMeltCalcVal.Visible = false;
                    LabReMeltFeedback.Visible = false;
                    LabReMeltFeedbackVal.Visible = false;
                    BtnReMeltConfirm.Visible = false;
                }
                if (PLC.StatusAlarm[180] == 1)
                {
                    LabDownShield.Visible = true;
                    BtnDownShield.Visible = true;
                }
                else
                {
                    LabDownShield.Visible = false;
                    BtnDownShield.Visible = false;
                }
                if (PLC.StatusAlarm[181] == 1)
                {
                    LabDownCru.Visible = true;
                    BtnDownCru.Visible = true;
                }
                else
                {
                    LabDownCru.Visible = false;
                    BtnDownCru.Visible = false;
                }
            }
        }
    }
}
