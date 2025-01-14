using CrystalGrowth.SOP;
using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction.Calibration
{
    internal partial class FrmFurnaceNum : Form
    {
        public FrmFurnaceNum()
        {
            InitializeComponent();
        }
        private void FrmFurnaceNum_Load(object sender, EventArgs e)
        {
            LabSP.Text = IdNum.FurnaceID;
            LabDateTime.Text = Calibrate.ReadTime(1);
        }
        private void LabSP_Click(object sender, EventArgs e)
        {
            FullKey fk = new FullKey();
            fk.ImportData(ref LabSP, new Point(691, 200), 20);
            fk.ShowDialog();
            if (fk.DialogResult == DialogResult.OK)
            {
                Calibrate.WriteValue(1, 1, LabSP.Text);
                LabDateTime.Text = Calibrate.DateTimeStr;
            }
        }
    }
}
