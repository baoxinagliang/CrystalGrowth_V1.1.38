using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.CrystalCtl
{
    internal partial class KeyForm : Form
    {
        public Point LocPoint;
        Label LabReciver;
        float MinVal = 0;
        float MaxVal = 0;
        int StartFlag = 0;
        int AddFlag = 0;
        int SubFlag = 0;
        int DotNum = 0;
        double AddNum = 0;
        public KeyForm()
        {
            InitializeComponent();
            LocPoint = new Point(619, 200);
        }
        //数据校准
        public void ImportData(ref Label label, float minVal, float maxVal)
        {
            ShowInTaskbar = false;
            Location = LocPoint;
            LabReciver = label;
            MinVal = minVal;
            MaxVal = maxVal;
        }
        private void KeyForm_Load(object sender, EventArgs e)
        {
            ActiveControl = LabValue;
            LabValue.Text = LabReciver.Text;
            string[] TempStr = LabValue.Text.Split(new char[] { '.' });
            DotNum = TempStr.Length > 1 ? TempStr[1].Length : 0;
            if (DotNum < 2)
            {
                AddNum = 1;
            }
            else if (DotNum < 3)
            {
                AddNum = 0.1;
            }
            else
            {
                AddNum = 0.01;
            }
            if (DotNum == 0)
            {
                LabMin.Text = Convert.ToInt32(MinVal).ToString();
                LabMax.Text = Convert.ToInt32(MaxVal).ToString();
            }
            else
            {
                LabMin.Text = MinVal.ToString().IndexOf('.') == -1 ? string.Concat(MinVal.ToString(), ".0") : MinVal.ToString();
                LabMax.Text = MaxVal.ToString().IndexOf('.') == -1 ? string.Concat(MaxVal.ToString(), ".0") : MaxVal.ToString();
            }
            StartFlag = 1;
            AddUnderline(ref LabReciver);
        }
        private void AddUnderline(ref Label label)
        {
            Font LabelFont = new Font(label.Font.FontFamily, label.Font.Size, FontStyle.Bold | FontStyle.Underline);
            label.Font = LabelFont;
            label.ForeColor = Color.Red;
        }
        private void DelUnderline(ref Label label)
        {
            Font LabelFont = new Font(label.Font.FontFamily, label.Font.Size, FontStyle.Bold);
            label.Font = LabelFont;
            label.ForeColor = Color.Black;
        }
        private void BtnEnter_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnEnter))
            {
                string ValueStr = LabValue.Text;
                if (ValueStr != "")
                {
                    if (Convert.ToSingle(ValueStr) < MinVal)
                    {
                        LabLimit.Visible = true;
                        return;
                    }
                    else if (Convert.ToSingle(ValueStr) > MaxVal)
                    {
                        LabLimit.Visible = true;
                        return;
                    }
                    ValueStr = DataCovert.RealToStr(DotNum, ValueStr);
                    LabReciver.Text = ValueStr;
                }
                DialogResult = DialogResult.OK;
                LabLimit.Visible = false;
                DelUnderline(ref LabReciver);
                Close();
            }
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DelUnderline(ref LabReciver);
            LabLimit.Visible = false;
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            LabValue.Text = "";
            LabLimit.Visible = false;
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
            if (LabValue.Text != "" && LabValue.Text != "-" && LabValue.Text.IndexOf('.') == -1)
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
            int d = LabValue.Text.IndexOf('-');
            if (LabValue.Text != "" && LabValue.Text != "0" && d == -1)
            {
                LabValue.Text = string.Concat("-", LabValue.Text);
            }
            else if (d >= 0)
            {
                string[] Temp = LabValue.Text.Split(new char[] { '-' });
                LabValue.Text = Temp[1];
            }
            StartFlag = 0;
        }
        private void BtnAdd_MouseDown(object sender, MouseEventArgs e)
        {
            if (LabValue.Text == "") { return; }
            if (AddFlag == 0)
            {
                LabValue.Text = (Convert.ToDouble(LabValue.Text) + AddNum).ToString();
                StartFlag = 0;
                Timer1.Interval = 1000;
                Timer1.Enabled = true;
                AddFlag = 1;
            }
        }
        private void BtnAdd_MouseUp(object sender, MouseEventArgs e)
        {
            if (LabValue.Text == "") { return; }
            if (AddFlag == 1)
            {
                Timer1.Enabled = false;
                AddFlag = 0;
            }
        }
        private void BtnSub_MouseDown(object sender, MouseEventArgs e)
        {
            if (LabValue.Text == "") { return; }
            if (SubFlag == 0)
            {
                LabValue.Text = (Convert.ToDouble(LabValue.Text) - AddNum).ToString();
                StartFlag = 0;
                Timer1.Interval = 1000;
                Timer1.Enabled = true;
                SubFlag = 1;
            }
        }
        private void BtnSub_MouseUp(object sender, MouseEventArgs e)
        {
            if (LabValue.Text == "") { return; }
            if (SubFlag == 1)
            {
                Timer1.Enabled = false;
                SubFlag = 0;
            }
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (AddFlag == 1)
            {
                LabValue.Text = (Convert.ToDouble(LabValue.Text) + AddNum).ToString();
            }
            if (SubFlag == 1)
            {
                LabValue.Text = (Convert.ToDouble(LabValue.Text) - AddNum).ToString();
            }
        }
    }
}
