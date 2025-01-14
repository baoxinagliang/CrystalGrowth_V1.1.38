using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction
{
    internal partial class FrmCalculator : Form
    {
        private int StartFlag = 0;
        private int MathType = 0;
        private double LastValue = 0.0;
        private double SaveValue = 0.0;
        public FrmCalculator()
        {
            InitializeComponent();
        }
        private void Keyboard(string strKey)
        {
            if (LabValue.Text == "0" || StartFlag == 1)
            {
                LabValue.Text = "";
                StartFlag = 0;
            }
            LabValue.Text = string.Concat(LabValue.Text, strKey);
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            LabValue.Text = "";
            StartFlag = 0;
            MathType = 0;
        }
        private void BtnOne_Click(object sender, EventArgs e)
        {
            Keyboard(BtnOne.Text);
        }
        private void BtnTwo_Click(object sender, EventArgs e)
        {
            Keyboard(BtnTwo.Text);
        }
        private void BtnThree_Click(object sender, EventArgs e)
        {
            Keyboard(BtnThree.Text);
        }
        private void BtnFour_Click(object sender, EventArgs e)
        {
            Keyboard(BtnFour.Text);
        }
        private void BtnFive_Click(object sender, EventArgs e)
        {
            Keyboard(BtnFive.Text);
        }
        private void BtnSix_Click(object sender, EventArgs e)
        {
            Keyboard(BtnSix.Text);
        }
        private void BtnSeven_Click(object sender, EventArgs e)
        {
            Keyboard(BtnSeven.Text);
        }
        private void BtnEight_Click(object sender, EventArgs e)
        {
            Keyboard(BtnEight.Text);
        }
        private void BtnNine_Click(object sender, EventArgs e)
        {
            Keyboard(BtnNine.Text);
        }
        private void BtnZero_Click(object sender, EventArgs e)
        {
            if (LabValue.Text == "0" || StartFlag == 1)
            {
                LabValue.Text = "";
                StartFlag = 0;
            }
            if (LabValue.Text != "0")
            {
                LabValue.Text = string.Concat(LabValue.Text, BtnZero.Text);
            }
        }
        private void BtnDot_Click(object sender, EventArgs e)
        {
            if (StartFlag == 1)
            {
                StartFlag = 0;
                MathType = 0;
            }
            if (LabValue.Text.IndexOf('.') == -1 && LabValue.Text != "" && LabValue.Text != "-")
            {
                LabValue.Text = string.Concat(LabValue.Text, BtnDot.Text);
            }
            else if (LabValue.Text == "")
            {
                LabValue.Text = string.Concat("0", BtnDot.Text);
            }
            else if (LabValue.Text == "-")
            {
                LabValue.Text = string.Concat("-0", BtnDot.Text);
            }
        }
        private void BtnBackspace_Click(object sender, EventArgs e)
        {
            if (StartFlag == 1)
            {
                StartFlag = 0;
                MathType = 0;
            }
            if (LabValue.Text.Length > 0)
            {
                LabValue.Text = LabValue.Text.Substring(0, LabValue.Text.Length - 1);
            }
            if (LabValue.Text == "-")
            {
                LabValue.Text = "0";
            }
        }
        private void BtnNegative_Click(object sender, EventArgs e)
        {
            if (LabValue.Text == "") { return; };
            if (StartFlag == 1)
            {
                StartFlag = 0;
                MathType = 0;
            }
            if (LabValue.Text.IndexOf('-') == -1 && LabValue.Text != "" && LabValue.Text != "0")
            {
                LabValue.Text = string.Concat("-", LabValue.Text);
            }
            else if (LabValue.Text.IndexOf('-') >= 0)
            {
                string[] Temp = LabValue.Text.Split(new char[] { '-' });
                LabValue.Text = Temp[1];
            }
        }
        private void BtnDivide_Click(object sender, EventArgs e)
        {
            if (LabValue.Text == "") { return; };
            SymbolicCalc();
            MathType = 1;
        }
        private void SymbolicCalc()
        {
            if (LabValue.Text == "") { return; }
            if (StartFlag == 0)
            {
                double TempDouble = double.Parse(LabValue.Text);
                switch (MathType)
                {
                    case 1:
                        if (TempDouble != 0)
                        {
                            LabValue.Text = (LastValue / TempDouble).ToString();
                        }
                        break;
                    case 2:
                        LabValue.Text = (LastValue * TempDouble).ToString();
                        break;
                    case 3:
                        LabValue.Text = (LastValue + TempDouble).ToString();
                        break;
                    case 4:
                        LabValue.Text = (LastValue - TempDouble).ToString();
                        break;
                }
            }
            LastValue = double.Parse(LabValue.Text);
            StartFlag = 1;
        }
        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            if (LabValue.Text == "") { return; };
            SymbolicCalc();
            MathType = 2;
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (LabValue.Text == "") { return; }
            SymbolicCalc();
            MathType = 3;
        }
        private void BtnSub_Click(object sender, EventArgs e)
        {
            if (LabValue.Text == "") { return; }
            SymbolicCalc();
            MathType = 4;
        }
        private void BtnSqr_Click(object sender, EventArgs e)
        {
            if (LabValue.Text == "") { return; }
            double TempDouble = double.Parse(LabValue.Text);
            LabValue.Text = (TempDouble * TempDouble).ToString();
            MathType = 0;
            StartFlag = 1;
        }
        private void BtnSqt_Click(object sender, EventArgs e)
        {
            if (LabValue.Text == "") { return; }
            LabValue.Text = Math.Sqrt(double.Parse(LabValue.Text)).ToString();
            MathType = 0;
            StartFlag = 1;
        }
        private void BtnReciprocal_Click(object sender, EventArgs e)
        {
            if (LabValue.Text == "") { return; }
            double TempDouble = double.Parse(LabValue.Text);
            if (TempDouble != 0)
            {
                LabValue.Text = (1 / TempDouble).ToString();
            }
            MathType = 0;
            StartFlag = 1;
        }
        private void BtnEqual_Click(object sender, EventArgs e)
        {
            if (LabValue.Text == "") { return; }
            double TempDouble = double.Parse(LabValue.Text);
            switch (MathType)
            {
                case 1:
                    if (TempDouble != 0)
                    {
                        LabValue.Text = (LastValue / TempDouble).ToString();
                        StartFlag = 1;
                        MathType = 0;
                    }
                    break;
                case 2:
                    LabValue.Text = (LastValue * TempDouble).ToString();
                    StartFlag = 1;
                    MathType = 0;
                    break;
                case 3:
                    LabValue.Text = (LastValue + TempDouble).ToString();
                    StartFlag = 1;
                    MathType = 0;
                    break;
                case 4:
                    LabValue.Text = (LastValue - TempDouble).ToString();
                    StartFlag = 1;
                    MathType = 0;
                    break;
            }
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (LabValue.Text == "") { return; }
            SaveValue = double.Parse(LabValue.Text);
            BtnPullOut.BackColor = Color.Green;
        }
        private void BtnPullOut_Click(object sender, EventArgs e)
        {
            LabValue.Text = SaveValue.ToString();
            StartFlag = 0;
            MathType = 0;
        }
    }
}
