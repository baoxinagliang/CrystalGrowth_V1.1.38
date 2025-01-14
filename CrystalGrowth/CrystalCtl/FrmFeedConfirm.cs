using CrystalGrowth.Unities;
using System;
using System.Windows.Forms;

namespace CrystalGrowth.CrystalCtl
{
    internal partial class FrmFeedConfirm : Form
    {
        public FrmFeedConfirm()
        {
            InitializeComponent();
        }
        private void FrmFeedConfirm_Load(object sender, EventArgs e)
        {
            LabTotalWeight.Text = Math.Round(PLC.ReadCalcValue[7], 2).ToString("f2");
        }
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            PLC.SendBit(30, 167, 1);
            Record.WriteIn("预热/熔接", "ON", "Yellow");
            Close();
        }
        private void BtnModify_Click(object sender, EventArgs e)
        {
            FrmLevel frmLevel = new FrmLevel("Engineer", "Engineer");
            frmLevel.ShowDialog();
            if (frmLevel.DialogResult == DialogResult.OK)
            {
                string LastValue = LabTotalWeight.Text;
                KeyForm kf = new KeyForm() { LocPoint = new System.Drawing.Point(883, 234) };
                kf.ImportData(ref LabTotalWeight, 0, 1000);
                kf.ShowDialog();
                if (kf.DialogResult == DialogResult.OK)
                {
                    PLC.SendFloat(35, 24, Convert.ToSingle(LabTotalWeight.Text));
                    Record.WriteIn("投料重量设定", String.Format("{0}->{1}", LastValue, LabTotalWeight.Text), "Yellow");
                    PLC.SendBit(30, 167, 1);
                    Record.WriteIn("预热/熔接", "ON", "Yellow");
                    Close();
                }
            }
        }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0xA3) { return; }
            base.WndProc(ref m);
        }
    }
}
