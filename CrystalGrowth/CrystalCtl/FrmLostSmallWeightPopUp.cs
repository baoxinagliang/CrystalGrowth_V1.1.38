using CrystalGrowth.Unities;
using System;
using System.Windows.Forms;

namespace CrystalGrowth.CrystalCtl
{
    internal partial class FrmLostSmallWeightPopUp : Form
    {
        public FrmLostSmallWeightPopUp()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnConfirm))
            {
                PLC.SendBit(30, 133, 1);
                Record.WriteIn("小失重保护确认", "ON", "Yellow");
                Close();
                Alarm.LostSmallWeightFlag = true; //报警取消
            }
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnCancel))
            {
                if (BtnCancel.Text == "关  闭")
                {
                    Close();
                }
                else
                {
                    PLC.SendBit(30, 134, 1);
                    Record.WriteIn("小失重保护关闭", "ON", "Yellow");
                    Close();
                }
                //报警取消
                Alarm.LostSmallWeightFlag = true;
            }
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            LabTextTime.Text = PLC.ReadOthersValue[31].TimeToStr();
            if (PLC.ReadOthersValue[31] == 0)//倒计时结束，提示自动失重保护
            {
                LabTextMsg.Text = "倒计时结束，已开始自动小失重保护！";
                BtnCancel.Text = "关  闭";
                BtnConfirm.Visible = false;
            }
        }

        private void FrmLostSmallWeightPopUp_Load(object sender, EventArgs e)
        {
            LabTextMsg.Text = "小失重保护是否开启？";
            LabTextTime.Text = "00:00:00";
        }
    }
}
