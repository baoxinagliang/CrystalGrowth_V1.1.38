using CrystalGrowth.CrystalCtl;
using CrystalGrowth.Unities;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction.CCD
{
    internal partial class FrmCutLineCheck : Form
    {
        public static bool IsStart = false;
        public static short CatchFlag = 0;
        public static double Probability = 0;
        public static double Count = 0; //棱线计数器  
        public static double LastCount = 0;  //上一个周期棱线计数器
        public static Stopwatch Timer = new Stopwatch();
        public static void InitParas()
        {
            Count = 0;
            LastCount = 0;
            Probability = 0;
            IsStart = false;
            Timer.Stop();
        }
        public FrmCutLineCheck()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (IsStart)
            {
                LabIsCutLineStart.Text = "打开";
                LabIsCutLineStart.ForeColor = Color.Lime;
            }
            else
            {
                LabIsCutLineStart.Text = "关闭";
                LabIsCutLineStart.ForeColor = Color.Red;
            }
            LabStartLine.Text = ParasCam1.CutLineStartLine.ToString("f1");
            LabCheckPeriod.Text = ParasCam1.CutLineCheckPeriod.ToString("f1");
            LabThroshold.Text = ParasCam1.CutLineThroshold.ToString("f1");
            LabCountAlarm.Text = ParasCam1.CutLineCountAlarmThroshold.ToString();
            LabCurrentLineCount.Text = Count.ToString();
            LabLastCount.Text = LastCount.ToString();
            LabCutLineProb.Text = string.Concat((Probability * 100).ToString("f2"), "%");
        }
        private void LabStartLine_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm
            {
                Location = new Point(400, 130)
            };
            kf.ImportData(ref LabStartLine, 0, 5000);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                ParasCam1.CutLineStartLine = Convert.ToSingle(LabStartLine.Text);
            }
        }
        private void LabCheckPeriod_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm
            {
                Location = new Point(400, 130)
            };
            kf.ImportData(ref LabCheckPeriod, 0, 100);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                ParasCam1.CutLineCheckPeriod = Convert.ToSingle(LabCheckPeriod.Text);
            }
        }
        private void LabThroshold_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm
            {
                Location = new Point(400, 130)
            };
            kf.ImportData(ref LabThroshold, 0, 100);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                ParasCam1.CutLineThroshold = Convert.ToSingle(LabThroshold.Text);
            }
        }
        private void LabCountAlarm_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm
            {
                Location = new Point(400, 130)
            };
            kf.ImportData(ref LabCountAlarm, 0, 10000);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                ParasCam1.CutLineCountAlarmThroshold = Convert.ToInt32(LabCountAlarm.Text);
            }
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            Record.WriteIn("CCD断线检测参数开启长度", LabStartLine.Text, "Yellow");
            Record.WriteIn("CCD断线检测参数检测周期", LabCheckPeriod.Text, "Yellow");
            Record.WriteIn("CCD断线检测参数检测阈值", LabThroshold.Text, "Yellow");
            Record.WriteIn("CCD断线检测参数计数报警阈值", LabCountAlarm.Text, "Yellow");
            ParasCam1.WriteIn();
        }
        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void FrmCutLineCheck_Load(object sender, EventArgs e)
        {
            ParasCam1.ReadOut();
        }
        private void FrmCutLineCheck_FormClosed(object sender, FormClosedEventArgs e)
        {
            ParasCam1.ReadOut();
        }
    }
}