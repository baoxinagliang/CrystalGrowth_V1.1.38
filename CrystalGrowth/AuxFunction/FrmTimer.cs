using CrystalGrowth.CrystalCtl;
using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction
{
    internal partial class FrmTimer : Form
    {
        private float TimerHour = 0;
        private float TimerMinute = 0;
        public static int TimerSw = 0;
        public static float TimerValReal = 0;
        public static string TimerValStr = "00:00:00";
        public static void CountDown()
        {
            if (TimerSw == 1)
            {
                if (TimerValReal > 0)
                {
                    TimerValReal--;
                    TimerValStr = TimerValReal.TimeToStr();
                }
            }
            else
            {
                TimerValStr = "00:00:00";
            }
        }
        public FrmTimer()
        {
            InitializeComponent();
        }
        private void FrmTimer_Load(object sender, EventArgs e)
        {
            DataShow();
        }
        private void LabHour_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm();
            kf.ImportData(ref LabHour, 0, 999999);
            kf.ShowDialog();
        }
        private void LabMinute_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm();
            kf.ImportData(ref LabMinute, 0, 999999);
            kf.ShowDialog();
        }
        private void BtnON_Click(object sender, EventArgs e)
        {
            TimerSw = 1;
            DataShow();
            TimerValReal = TimerHour * 3600 + TimerMinute * 60;
            TimerValStr = TimerValReal.TimeToStr();
            LabMinute.Text = TimerValStr;
        }
        private void BtnOFF_Click(object sender, EventArgs e)
        {
            TimerSw = 0;
            PLC.SendBit(36, 181, 0);
            DataShow();
        }
        private void DataShow()
        {
            if (TimerSw == 0)
            {
                BtnON.BackColor = Color.Blue;
                BtnOFF.BackColor = Color.Red;
                LabHourTxt.Visible = true;
                LabHour.Visible = true;
                LabMinuteTxt.Visible = true;
                LabMinute.BackColor = Color.White;
                LabMinute.ForeColor = Color.Black;
                LabTimerTxt.Visible = false;
                LabHour.Text = TimerHour.ToString();
                LabMinute.Text = TimerMinute.ToString();
            }
            else
            {
                BtnON.BackColor = Color.Red;
                BtnOFF.BackColor = Color.Blue;
                LabHourTxt.Visible = false;
                LabHour.Visible = false;
                LabMinuteTxt.Visible = false;
                LabMinute.BackColor = Color.Black;
                LabMinute.ForeColor = Color.White;
                LabTimerTxt.Visible = true;
                LabMinute.Text = TimerValStr;
            }
        }
        private void LabHour_TextChanged(object sender, EventArgs e)
        {
            TimerHour = int.Parse(LabHour.Text);
        }
        private void LabMinute_TextChanged(object sender, EventArgs e)
        {
            if (TimerSw == 0)
            {
                TimerMinute = float.Parse(LabMinute.Text);
            }
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (TimerSw == 1)
            {
                LabMinute.Text = TimerValStr;
            }
        }
    }
}
