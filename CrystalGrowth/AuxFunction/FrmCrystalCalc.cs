using CrystalGrowth.CrystalCtl;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction
{
    internal partial class FrmCrystalCalc : Form
    {
        private string CrysDia = "0.0";
        private string CrysLen = "0";
        private string CrysWeig = "0.00";
        public FrmCrystalCalc()
        {
            InitializeComponent();
        }
        private void FrmCrystalCalc_Load(object sender, EventArgs e)
        {
            LabDiameter.Text = CrysDia;
            LabLength.Text = CrysLen;
            LabWeight.Text = CrysWeig;
        }
        private void BtnDiameter_Click(object sender, EventArgs e)
        {
            BtnDiameter.BackColor = Color.Red;
            BtnLength.BackColor = Color.Blue;
            BtnWeight.BackColor = Color.Blue;
            LabDiameter.BackColor = Color.Black;
            LabDiameter.ForeColor = Color.White;
            LabLength.BackColor = Color.White;
            LabLength.ForeColor = Color.Black;
            LabWeight.BackColor = Color.White;
            LabWeight.ForeColor = Color.Black;
        }
        private void BtnLength_Click(object sender, EventArgs e)
        {
            BtnDiameter.BackColor = Color.Blue;
            BtnLength.BackColor = Color.Red;
            BtnWeight.BackColor = Color.Blue;
            LabDiameter.BackColor = Color.White;
            LabDiameter.ForeColor = Color.Black;
            LabLength.BackColor = Color.Black;
            LabLength.ForeColor = Color.White;
            LabWeight.BackColor = Color.White;
            LabWeight.ForeColor = Color.Black;
        }
        private void BtnWeight_Click(object sender, EventArgs e)
        {
            BtnDiameter.BackColor = Color.Blue;
            BtnLength.BackColor = Color.Blue;
            BtnWeight.BackColor = Color.Red;
            LabDiameter.BackColor = Color.White;
            LabDiameter.ForeColor = Color.Black;
            LabLength.BackColor = Color.White;
            LabLength.ForeColor = Color.Black;
            LabWeight.BackColor = Color.Black;
            LabWeight.ForeColor = Color.White;
        }
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            double Diameter, Length, Weight;
            if (BtnDiameter.BackColor == Color.Red)
            {
                Length = double.Parse(LabLength.Text);
                Weight = double.Parse(LabWeight.Text);
                LabDiameter.Text = Math.Round(Math.Sqrt((Weight * 1000000) / (Length * 2.33 * Math.PI)) * 2, 1).ToString("f1");
                CrysDia = LabDiameter.Text;
            }
            if (BtnLength.BackColor == Color.Red)
            {
                Diameter = double.Parse(LabDiameter.Text);
                Weight = double.Parse(LabWeight.Text);
                LabLength.Text = Math.Round((Weight * 1000000) / (2.33 * Math.PI * (Diameter * Diameter / 4)), 0).ToString();
                CrysLen = LabLength.Text;
            }
            if (BtnWeight.BackColor == Color.Red)
            {
                Diameter = double.Parse(LabDiameter.Text);
                Length = double.Parse(LabLength.Text);
                LabWeight.Text = Math.Round((Math.PI * Diameter * Diameter * Length * 2.33) / (4 * 1000000), 2).ToString("f2");
                CrysWeig = LabWeight.Text;
            }
        }
        private void LabDiameter_Click(object sender, EventArgs e)
        {
            if (LabDiameter.BackColor == Color.White)
            {
                KeyForm kf = new KeyForm();
                kf.ImportData(ref LabDiameter, 0, 1000);
                kf.ShowDialog();
            }
        }
        private void LabLength_Click(object sender, EventArgs e)
        {
            if (LabLength.BackColor == Color.White)
            {
                KeyForm kf = new KeyForm();
                kf.ImportData(ref LabLength, 0, 10000);
                kf.ShowDialog();
            }
        }
        private void LabWeight_Click(object sender, EventArgs e)
        {
            if (LabWeight.BackColor == Color.White)
            {
                KeyForm kf = new KeyForm();
                kf.ImportData(ref LabWeight, 0, 2000);
                kf.ShowDialog();
            }
        }
    }
}
