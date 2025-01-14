using CrystalGrowth.Unities;
using System;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction.Calibration
{
    internal partial class FrmTotalLen : Form
    {
        public FrmTotalLen()
        {
            InitializeComponent();
        }
        private void FrmTotalLen_Load(object sender, EventArgs e)
        {
            LabDateTime.Text = Calibrate.ReadTime(22);
        }
        private void BtnReset_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnReset))
            {
                Calibrate.WriteValue(22, 1, "");
                LabDateTime.Text = Calibrate.DateTimeStr;
            }
        }
    }
}
