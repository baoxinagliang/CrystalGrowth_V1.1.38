using CrystalGrowth.CrystalCtl;
using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction.CCD
{
    internal partial class FrmCrystalShake : Form
    {
        public static bool StartFlag = false;
        public static bool FirstTime = false;
        public static bool AlarmFlag = false;
        public static double Value = 0;
        public static Point CurrentCenter;
        public static Point LastCenter;
        public FrmCrystalShake()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            LabNeckShake.Text = ParasCam1.ShakeNeckThreshold.ToString();
            LabCrownShake.Text = ParasCam1.ShakeCrownThreshold.ToString();
            LabBodyShake.Text = ParasCam1.ShakeBodyThreshold.ToString();
            if (StartFlag)
            {
                LabShakeVal.Text = Math.Round(Value, 2).ToString("f2");
                BtnStart.BackColor = Color.Lime;
            }
            else
            {
                BtnStart.BackColor = Color.RoyalBlue;
            }
            if (AlarmFlag)
            {
                LabShakeAlarm.Text = "有晃动";
                LabShakeAlarm.ForeColor = Color.Red;
            }
            else
            {
                LabShakeAlarm.Text = "无晃动";
                LabShakeAlarm.ForeColor = Color.Lime;
            }
        }
        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void LabNeckShake_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm
            {
                Location = new Point(400, 130)
            };
            kf.ImportData(ref LabNeckShake, 0, 100);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                ParasCam1.ShakeNeckThreshold = Convert.ToSingle(LabNeckShake.Text);
            }
        }
        private void LabCrownShake_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm
            {
                Location = new Point(400, 130)
            };
            kf.ImportData(ref LabCrownShake, 0, 100);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                ParasCam1.ShakeCrownThreshold = Convert.ToSingle(LabCrownShake.Text);
            }
        }
        private void LabBodyShake_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm
            {
                Location = new Point(400, 130)
            };
            kf.ImportData(ref LabBodyShake, 0, 100);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                ParasCam1.ShakeBodyThreshold = Convert.ToSingle(LabBodyShake.Text);
            }
        }
        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnStart))
            {
                if (StartFlag == false)
                {
                    StartFlag = true;
                    FirstTime = true;
                    BtnStart.BackColor = Color.Lime;
                }
                else
                {
                    StartFlag = false;
                    BtnStart.BackColor = Color.RoyalBlue;
                }
            }
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            Record.WriteIn("CCD引晶晃动参数报警阈值", LabNeckShake.Text, "Yellow");
            Record.WriteIn("CCD放肩晃动参数报警阈值", LabCrownShake.Text, "Yellow");
            Record.WriteIn("CCD等径晃动参数检测阈值", LabBodyShake.Text, "Yellow");
            ParasCam1.WriteIn();
        }
        private void FrmCrystalShake_Load(object sender, EventArgs e)
        {
            ParasCam1.ReadOut();
        }
        private void FrmCrystalShake_FormClosed(object sender, FormClosedEventArgs e)
        {
            ParasCam1.ReadOut();
        }
    }
}
