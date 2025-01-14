using CrystalGrowth.Unities;
using System;
using System.Windows.Forms;

namespace CrystalGrowth.CrystalCtl
{
    internal partial class FrmPopUp : Form
    {
        public FrmPopUp()
        {
            InitializeComponent();
        }
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnConfirm))
            {
                PLC.SendBit(30, 115, 1);
                Record.WriteIn("确认旋转完成", "ON", "Yellow");
                Close();
            }
        }
    }
}
