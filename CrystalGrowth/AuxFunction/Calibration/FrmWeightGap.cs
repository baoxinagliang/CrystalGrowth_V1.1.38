using CrystalGrowth.AuxFunction.CCD;
using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction.Calibration
{
    internal partial class FrmWeightGap : Form
    {
        public FrmWeightGap()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void FrmWeightGap_Load(object sender, EventArgs e)
        {
            LabDateTime.Text = Calibrate.ReadTime(30);
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (PLC.Count == 2)
            {
                LabMeltGap.Text = Math.Round(PLC.ReadCalcValue[24], 1).ToString("f1");
                LabWeigthGap.Text = Math.Round(PLC.ReadCalcValue[1], 1).ToString("f1");
                LabShieldToHtr.Text = Math.Round(PLC.ReadCalibValue[37], 1).ToString("f1");
            }
        }
        private void BtnCalib_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnCalib))
            {
                if (FrmMeltGapArea.AgreeMeltGap == 1 && PLC.ReadCalcValue[24] > 10)
                {
                    Calibrate.WriteValue(30, 1, "");
                    LabDateTime.Text = Calibrate.DateTimeStr;
                    Record.WriteIn("重量液口距校准", PLC.ReadCalcValue[24].ToString("f2"), "Yellow");
                }
                else
                {
                    LabDateTime.ForeColor = Color.Red;
                    LabDateTime.Text = "校准条件不具备";
                }
            }
        }
    }
}
