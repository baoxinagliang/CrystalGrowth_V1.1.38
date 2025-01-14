using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.CrystalCtl
{
    public partial class FrmSaveProtected : Form
    {
        public FrmSaveProtected()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        static bool PowerCut = false;
        static bool WaterCut = false;
        static bool PressAbnormal = false;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (PLC.ReadStatus[81] == 1)
            {
                LabName.Text = "停水保护";
                Record.WriteIn("停水保护", "", "Red");
                LabCountDownTxt.Visible = true;
                LabCountDown.Visible = true;
                LabCountDownUnit.Visible = true;
                LabCountDown.Text = PLC.ReadOthersValue[13].ToString();
                if (WaterCut == false)
                {
                    WaterCut = true;
                    PressAbnormal = false;
                    PowerCut = false;
                    BtnErrHandle.BackColor = Color.Blue;
                    BtnAckSafe.BackColor = Color.Blue;
                    BtnAck.Visible = false;
                    BtnCancel.Visible = false;
                }
            }
            else if (PLC.ReadStatus[82] == 1)
            {
                LabName.Text = "炉压异常";
                Record.WriteIn("炉压异常", "", "Red");
                LabCountDownTxt.Visible = false;
                LabCountDown.Visible = false;
                LabCountDownUnit.Visible = false;
                LabCountDown.Text = PLC.ReadOthersValue[13].ToString();
                if (PressAbnormal == false)
                {
                    PressAbnormal = true;
                    WaterCut = false;
                    PowerCut = false;
                    BtnErrHandle.BackColor = Color.Blue;
                    BtnAckSafe.BackColor = Color.Blue;
                    BtnAck.Visible = false;
                    BtnCancel.Visible = false;
                }
            }
            else if (PLC.ReadStatus[80] == 1)
            {
                LabName.Text = "停电保护";
                Record.WriteIn("停电保护", "", "Red");
                LabCountDownTxt.Visible = true;
                LabCountDown.Visible = true;
                LabCountDownUnit.Visible = true;
                LabCountDown.Text = PLC.ReadOthersValue[7].ToString();
                if (PowerCut == false)
                {
                    PowerCut = true;
                    WaterCut = false;
                    PressAbnormal = false;
                    BtnErrHandle.BackColor = Color.Blue;
                    BtnAckSafe.BackColor = Color.Blue;
                    BtnAck.Visible = false;
                    BtnCancel.Visible = false;
                }
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
        private void BtnErrHandle_Click(object sender, EventArgs e)
        {
            if (BtnAckSafe.BackColor == Color.Blue)
            {
                BtnErrHandle.BackColor = Color.Red;
                BtnAck.Visible = true;
                BtnCancel.Visible = true;
            }
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

        private void BtnAck_Click(object sender, EventArgs e)
        {
            //停水保护
            if (PLC.ReadStatus[81] == 1)
            {
                if (BtnErrHandle.BackColor == Color.Red)
                {
                    PLC.SendBit(30, 110, 1);
                }
                if (BtnAckSafe.BackColor == Color.Red)
                {
                    PLC.SendBit(30, 111, 1);
                }
                //炉压异常
            }
            else if (PLC.ReadStatus[82] == 1)
            {
                if (BtnErrHandle.BackColor == Color.Red)
                {
                    PLC.SendBit(30, 112, 1);
                }
                if (BtnAckSafe.BackColor == Color.Red)
                {
                    PLC.SendBit(30, 113, 1);
                }
                //停电保护
            }
            else if (PLC.ReadStatus[80] == 1)
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
            Close();
        }
    }
}
