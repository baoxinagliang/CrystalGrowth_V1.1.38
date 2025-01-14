using CrystalGrowth.Trend;
using CrystalGrowth.Unities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CrystalGrowth.GrowRecord
{
    internal partial class FrmHistTrend : Form
    {
        int Count = 0;
        FrmColorSel fcs;
        private FrmHistTrend()
        {
            InitializeComponent();
            FrmTrend.Single.ChartAddSeries(Chart1);
            FrmTrend.Single.ChartAddSeries(Chart2);
            fcs = new FrmColorSel();
        }
        public static FrmHistTrend Single;
        public static FrmHistTrend CreateInstrance()
        {
            if (Single == null)
            {
                Single = new FrmHistTrend();
                Single.FormClosed += Single_FormClosed;
            }
            return Single;
        }
        static void Single_FormClosed(object sender, FormClosedEventArgs e)
        {
            Single = null;
        }
        private void FrmHistTrend_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (fcs != null) { fcs.Close(); }
        }
        private void FrmHistTrend_Load(object sender, EventArgs e)
        {
            ChartSet(Chart1, true, ref FrmReport.dt1);
            ChartSet(Chart2, false, ref FrmReport.dt2);
        }
        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Close();
            if (Application.OpenForms["FrmReport"] != null)
            {
                Application.OpenForms["FrmReport"].Show();
            }
            FrmSwitch.LastForm = Application.OpenForms["FrmReport"];
        }
        public void ShowTrend(int IndexNum, bool flag, DataPointCollection Dpc)
        {
            DataTable dt = flag ? FrmReport.dt1 : FrmReport.dt2;
            if (dt.Rows.Count <= 2) { return; }
            List<double> doubY = new List<double>(), doubX = new List<double>();
            string nameStr = TData.SelValue[IndexNum].Name;
            string keyStr = TData.Paras[nameStr].Name;
            foreach (DataRow dataRow in dt.Rows)
            {
                var str = dataRow[keyStr];
                if (DataCovert.Juage(str))
                {
                    doubX.Add(Convert.ToDateTime(dataRow[0]).ToOADate());
                    doubY.Add(DataCovert.NumVar(str, TData.SelValue[IndexNum].Min, TData.SelValue[IndexNum].Max));
                }
            }
            Dpc.DataBindXY(doubX, doubY);
        }
        private void CBGrid_Click(object sender, EventArgs e)
        {
            if (CBGrid.Checked)
            {
                CBGrid.Checked = false;
                Chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                Chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                Chart2.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                Chart2.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            }
            else
            {
                CBGrid.Checked = true;
                Chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
                Chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
                Chart2.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
                Chart2.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
            }
        }
        private void BtnVarSel_Click(object sender, EventArgs e)
        {
            FrmSwitch.Open(fcs, 103, new Point(0, 130), new Size(1366, 255));
            fcs.Show();
        }
        private void ChartSet(Chart chart, bool flag, ref DataTable dt)
        {
            if (dt.Rows.Count > 1)
            {
                DateTime StartDate = Convert.ToDateTime(dt.Rows[0][0]);
                DateTime EndDate = Convert.ToDateTime(dt.Rows[dt.Rows.Count - 1][0]);
                FrmTrend.Single.TimeChange(chart, EndDate.ToOADate(), StartDate.ToOADate());
                chart.BeginInvoke(new Action(() => { ShowTrend(0, flag, chart.Series[0].Points); }));
                chart.BeginInvoke(new Action(() => { ShowTrend(1, flag, chart.Series[1].Points); }));
                chart.BeginInvoke(new Action(() => { ShowTrend(2, flag, chart.Series[2].Points); }));
                chart.BeginInvoke(new Action(() => { ShowTrend(3, flag, chart.Series[3].Points); }));
                chart.BeginInvoke(new Action(() => { ShowTrend(4, flag, chart.Series[4].Points); }));
            }
        }
        public void RefreshCurve(int index)
        {
            Chart1.BeginInvoke(new Action(() => { ShowTrend(index, true, Chart1.Series[index].Points); }));
            Chart2.BeginInvoke(new Action(() => { ShowTrend(index, false, Chart2.Series[index].Points); }));
        }
        public void ClearCurve(int index)
        {
            Chart1.BeginInvoke(new Action(() => { Chart1.Series[index].Points.Clear(); }));
            Chart2.BeginInvoke(new Action(() => { Chart2.Series[index].Points.Clear(); }));
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (Count >= 1)
            {
                Timer1.Enabled = false;
                return;
            }
            Count = 2;
            ChartSet(Chart1, true, ref FrmReport.dt1);
            ChartSet(Chart2, false, ref FrmReport.dt2);
        }
    }
}
