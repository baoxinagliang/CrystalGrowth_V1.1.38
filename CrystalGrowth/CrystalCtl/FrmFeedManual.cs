using CrystalGrowth.Unities;
using System;
using System.Windows.Forms;

namespace CrystalGrowth.CrystalCtl
{
    internal partial class FrmFeedManual : Form
    {
        public FrmFeedManual()
        {
            InitializeComponent();
        }
        private void FrmFeedConfirm_Load(object sender, EventArgs e)
        {
            LabTotalWeight.Text = Math.Round(PLC.ReadOthersValue[26], 2).ToString("f2");
        }
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            PLC.SendBit(30, 176, 1);
            Record.WriteIn("手动加料确认", "ON", "Yellow");
            Close();
        }
        private void BtnCannel_Click(object sender, EventArgs e)
        {
            PLC.SendBit(32, 103, 0);
            Record.WriteIn("手动加料取消", "OFF", "Yellow");
            Close();
        }
        private void LabTotalWeight_Click(object sender, EventArgs e)
        {
            string LastValue = LabTotalWeight.Text;
            KeyForm kf = new KeyForm() { LocPoint = new System.Drawing.Point(883, 234) };
            kf.ImportData(ref LabTotalWeight, 0, 1000);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                PLC.SendFloat(31, 100, Convert.ToSingle(LabTotalWeight.Text));
                Record.WriteIn("手动加料量", String.Format("{0}->{1}", LastValue, LabTotalWeight.Text), "Yellow");
            }
        }
    }
}
