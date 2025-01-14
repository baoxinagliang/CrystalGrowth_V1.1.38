using System;
using System.Windows.Forms;

namespace CrystalGrowth.CrystalCtl
{
    internal partial class FrmMsgBox : Form
    {
        public FrmMsgBox(string strInfo)
        {
            InitializeComponent();
            LabInfo.Text = strInfo;
        }
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
        private void BtnCannel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0xA3) { return; }
            base.WndProc(ref m);
        }
    }
}
