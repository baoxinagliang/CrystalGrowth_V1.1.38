using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.SOP
{
    internal partial class SmallKey : Form
    {
        DataGridViewCell DgvCurrentCell;
        int DotNum = 0;
        int StartFlag = 0;
        int FormNum = 0;
        public SmallKey()
        {
            InitializeComponent();
        }
        public void ImportData(DataGridViewCell dgvc, Point locPoint, int index = 0)
        {
            DgvCurrentCell = dgvc;
            Location = locPoint;
            ShowInTaskbar = false;
            FormNum = index;
        }
        private void SmallKey_Load(object sender, EventArgs e)
        {
            ActiveControl = LabValue;
            if (DgvCurrentCell.Value != null)
            {
                LabValue.Text = DgvCurrentCell.Value.ToString();
            }
            string[] TempStr = LabValue.Text.Split(new char[] { '.' });
            DotNum = TempStr.Length > 1 ? TempStr[1].Length : 0;
            StartFlag = 1;
        }
        private void SmallKey_FormClosed(object sender, FormClosedEventArgs e)
        {
            DgvCurrentCell.Selected = false;
        }
        private void BtnAck_Click(object sender, EventArgs e)
        {
            if (LabValue.Text == "")
            {
                DgvCurrentCell.Value = "";
                Close();
                return;
            }
            switch (FormNum)
            {
                case 0:
                    DgvCurrentCell.Value = LabValue.Text;
                    break;
                case 1:
                    DgvCurrentCell.Value = DataCovert.RealToStr(DotNum, LabValue.Text);
                    break;
                case 2:
                    DgvCurrentCell.Value = DataCovert.RealToStr(FormNum, LabValue.Text);
                    break;
            }
            DialogResult = DialogResult.OK;
            Close();
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            LabValue.Text = "";
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
            if (StartFlag == 1)
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
                LabValue.Text = "";
                StartFlag = 0;
            }
            if (LabValue.Text != "" && LabValue.Text != "-" && LabValue.Text.IndexOf(".") == -1)
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
            if (LabValue.Text.Length > 0)
            {
                LabValue.Text = LabValue.Text.Substring(0, LabValue.Text.Length - 1);
            }
            if (LabValue.Text == "-")
            {
                LabValue.Text = "0";
            }
            if (StartFlag == 1)
            {
                StartFlag = 0;
            }
        }
        private void BtnNegative_Click(object sender, EventArgs e)
        {
            if (LabValue.Text != "" && LabValue.Text != "0" && LabValue.Text.IndexOf("-") == -1)
            {
                LabValue.Text = string.Concat("-", LabValue.Text);
            }
            else if (LabValue.Text.IndexOf("-") >= 0)
            {
                LabValue.Text = LabValue.Text.Split(new char[] { '-' })[1];
            }
            StartFlag = 0;
        }
    }
}
