﻿using CrystalGrowth.CrystalCtl;
using System;
using System.Windows.Forms;

namespace CrystalGrowth.Trend
{
    internal partial class FrmChangeTime : Form
    {
        public static int SpanRealTime = 30;
        public static int SpanHistoryTime = 4000;
        public FrmChangeTime()
        {
            InitializeComponent();
        }
        private void FrmChangeTime_Load(object sender, EventArgs e)
        {
            LabRealSpan.Text = SpanRealTime.ToString();
            LabHistorySpan.Text = SpanHistoryTime.ToString();
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void LabRealSpan_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm();
            kf.ImportData(ref LabRealSpan, 5, FrmTrend.Single.MaxSpan);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                SpanRealTime = Convert.ToInt32(LabRealSpan.Text);
                DateTime timeNow = DateTime.Now;
                FrmTrend.Single.TimeChange(FrmTrend.Single.chart1, timeNow.ToOADate(), timeNow.AddMinutes(-FrmTrend.Single.MaxSpan).ToOADate());
                FrmTrend.Single.chart1.ChartAreas[0].AxisX.ScaleView.Scroll(System.Windows.Forms.DataVisualization.Charting.ScrollType.Last);
            }
        }
        private void LabHistorySpan_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm();
            kf.ImportData(ref LabHistorySpan, 10, 12000);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                SpanHistoryTime = Convert.ToInt32(LabHistorySpan.Text);
            }
        }
    }
}
