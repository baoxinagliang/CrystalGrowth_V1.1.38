using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CrystalGrowth.SOP
{
    internal partial class FullKey : Form
    {
        Label LabReciver;
        DataGridViewCell DgvCurrentCell;
        TextBox TxtReciver;
        int DataLen = 0;
        int Flag = 0;
        int Type = 0;
        bool IsNUm = false;
        public FullKey()
        {
            InitializeComponent();
        }
        private void FullKey_Load(object sender, EventArgs e)
        {
            ActiveControl = LabValue;
            switch (Flag)
            {
                case 0:
                    txtPwd.Visible = false;
                    LabValue.Visible = true;
                    LabValue.Text = LabReciver.Text;
                    AddUnderline(ref LabReciver);
                    break;
                case 1:
                    txtPwd.Visible = false;
                    LabValue.Visible = true;
                    LabValue.Text = DgvCurrentCell.Value.ToString();
                    break;
                case 2:
                    txtPwd.Visible = true;
                    LabValue.Visible = false;
                    txtPwd.Text = TxtReciver.Text;
                    AddUnderline(ref TxtReciver);
                    break;
            }
        }
        public void ImportData(ref Label currentLab, Point locPoint, int Length, bool isNUm = false)
        {
            Flag = 0;
            Location = locPoint;
            DataLen = Length;
            LabReciver = currentLab;
            ShowInTaskbar = false;
            IsNUm = isNUm;
        }
        public void ImportData(DataGridViewCell dgv, Point locPoint, int index = 0)
        {
            Flag = 1;
            Location = locPoint;
            DgvCurrentCell = dgv;
            Type = index;
            ShowInTaskbar = false;
        }
        public void ImportData(ref TextBox txtBox, Point locPoint, int Length)
        {
            Flag = 2;
            Location = locPoint;
            DataLen = Length;
            TxtReciver = txtBox;
            ShowInTaskbar = false;
        }
        public void AddUnderline(ref Label label)
        {
            Font LabelFont = new Font(label.Font.FontFamily, label.Font.Size, FontStyle.Bold | FontStyle.Underline);
            label.Font = LabelFont;
            label.ForeColor = Color.Red;
        }
        private void AddUnderline(ref TextBox txtBox)
        {
            Font LabelFont = new Font(txtBox.Font.FontFamily, txtBox.Font.Size, FontStyle.Bold | FontStyle.Underline);
            txtBox.Font = LabelFont;
            txtBox.ForeColor = Color.Red;
        }
        private void DelUnderline(ref Label label)
        {
            Font LabelFont = new Font(label.Font.FontFamily, label.Font.Size, FontStyle.Bold);
            label.Font = LabelFont;
            label.ForeColor = Color.Black;
        }
        private void DelUnderline(ref TextBox txtBox)
        {
            Font LabelFont = new Font(txtBox.Font.FontFamily, txtBox.Font.Size, FontStyle.Bold);
            txtBox.Font = LabelFont;
            txtBox.ForeColor = Color.Black;
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            switch (Flag)
            {
                case 0:
                    DelUnderline(ref LabReciver);
                    break;
                case 1:
                    break;
                case 2:
                    DelUnderline(ref TxtReciver);
                    break;
            }
            Close();
        }
        private void BtnEnter_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnEnter))
            {
                switch (Flag)
                {
                    case 0:
                        if (IsNUm)
                        {
                            if (CheckNumberic(LabValue.Text))
                            {
                                string TempStr = LabValue.Text;
                                LabReciver.Text = TempStr.Length > DataLen ? TempStr.Substring(0, DataLen) : TempStr;
                            }
                            else
                            {
                                MessageBox.Show("非数字！");
                            }
                        }
                        else
                        {
                            string TempStr = LabValue.Text;
                            LabReciver.Text = TempStr.Length > DataLen ? TempStr.Substring(0, DataLen) : TempStr;
                        }
                        DelUnderline(ref LabReciver);
                        break;
                    case 1:
                        if (Type == 4)
                        {
                            if (CheckTime(LabValue.Text))
                            {
                                DgvCurrentCell.Value = LabValue.Text;
                            }
                            else
                            {
                                MessageBox.Show("时间格式错误\r\n请重新输入！");
                                return;
                            }
                        }
                        else if (Type == 3)
                        {
                            DgvCurrentCell.Value = LabValue.Text;
                        }
                        else
                        {
                            if (CheckNumberic(LabValue.Text))
                            {
                                DgvCurrentCell.Value = LabValue.Text;
                            }
                            else
                            {
                                MessageBox.Show("只能输入数字\r\n请重新输入！");
                                return;
                            }
                        }
                        break;
                    case 2:
                        TxtReciver.Text = txtPwd.Text;
                        DelUnderline(ref TxtReciver);
                        break;
                }
                DialogResult = DialogResult.OK;
                Close();
            }
        }
        /// <summary>
        /// 正则表达式时间输入格式
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private bool CheckTime(string s)
        {
            if (Regex.IsMatch(s, "^((((1[6-9]|[2-9]\\d)\\d{2})-(0?[13578]|1[02])-(0?[1-9]|[12]\\d|3[01]))|(((1[6-9]|[2-9]\\d)\\d{2})-(0?[13456789]|1[012])-(0?[1-9]|[12]\\d|30))|(((1[6-9]|[2-9]\\d)\\d{2})-0?2-(0?[1-9]|1\\d|2[0-8]))|(((1[6-9]|[2-9]\\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))-0?2-29-)) (20|21|22|23|[0-1]?\\d):[0-5]?\\d:[0-5]?\\d$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool CheckNumberic(string s)
        {
            try
            {
                double var1 = Convert.ToDouble(s);
                return true;
            }
            catch
            {
                return false;
            }
        }
        private void Keyboard(string strKey)
        {
            switch (Flag)
            {
                case 0:
                case 1:
                    LabValue.Text = string.Concat(LabValue.Text, strKey);
                    break;
                case 2:
                    txtPwd.Text = string.Concat(txtPwd.Text, strKey);
                    break;
            }
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
        private void BtnA_Click(object sender, EventArgs e)
        {
            Keyboard(BtnA.Text);
        }
        private void BtnB_Click(object sender, EventArgs e)
        {
            Keyboard(BtnB.Text);
        }
        private void BtnC_Click(object sender, EventArgs e)
        {
            Keyboard(BtnC.Text);
        }
        private void BtnD_Click(object sender, EventArgs e)
        {
            Keyboard(BtnD.Text);
        }
        private void BtnE_Click(object sender, EventArgs e)
        {
            Keyboard(BtnE.Text);
        }
        private void BtnF_Click(object sender, EventArgs e)
        {
            Keyboard(BtnF.Text);
        }
        private void BtnG_Click(object sender, EventArgs e)
        {
            Keyboard(BtnG.Text);
        }
        private void BtnH_Click(object sender, EventArgs e)
        {
            Keyboard(BtnH.Text);
        }
        private void BtnI_Click(object sender, EventArgs e)
        {
            Keyboard(BtnI.Text);
        }
        private void BtnJ_Click(object sender, EventArgs e)
        {
            Keyboard(BtnJ.Text);
        }
        private void BtnK_Click(object sender, EventArgs e)
        {
            Keyboard(BtnK.Text);
        }
        private void BtnL_Click(object sender, EventArgs e)
        {
            Keyboard(BtnL.Text);
        }
        private void BtnM_Click(object sender, EventArgs e)
        {
            Keyboard(BtnM.Text);
        }
        private void BtnN_Click(object sender, EventArgs e)
        {
            Keyboard(BtnN.Text);
        }
        private void BtnO_Click(object sender, EventArgs e)
        {
            Keyboard(BtnO.Text);
        }
        private void BtnP_Click(object sender, EventArgs e)
        {
            Keyboard(BtnP.Text);
        }
        private void BtnQ_Click(object sender, EventArgs e)
        {
            Keyboard(BtnQ.Text);
        }
        private void BtnR_Click(object sender, EventArgs e)
        {
            Keyboard(BtnR.Text);
        }
        private void BtnS_Click(object sender, EventArgs e)
        {
            Keyboard(BtnS.Text);
        }
        private void BtnT_Click(object sender, EventArgs e)
        {
            Keyboard(BtnT.Text);
        }
        private void BtnU_Click(object sender, EventArgs e)
        {
            Keyboard(BtnU.Text);
        }
        private void BtnV_Click(object sender, EventArgs e)
        {
            Keyboard(BtnV.Text);
        }
        private void BtnW_Click(object sender, EventArgs e)
        {
            Keyboard(BtnW.Text);
        }
        private void BtnX_Click(object sender, EventArgs e)
        {
            Keyboard(BtnX.Text);
        }
        private void BtnY_Click(object sender, EventArgs e)
        {
            Keyboard(BtnY.Text);
        }
        private void BtnZ_Click(object sender, EventArgs e)
        {
            Keyboard(BtnZ.Text);
        }
        private void Btn__Click(object sender, EventArgs e)
        {
            Keyboard(" ");
        }
        private void BtnDot_Click(object sender, EventArgs e)
        {
            Keyboard(BtnDot.Text);
        }
        private void BtnColon_Click(object sender, EventArgs e)
        {
            Keyboard(BtnColon.Text);
        }
        private void BtnInt_Click(object sender, EventArgs e)
        {
            Keyboard(BtnInt.Text);
        }
        private void BtnZero_Click(object sender, EventArgs e)
        {
            Keyboard(BtnZero.Text);
        }
        private void BtnCaps_Click(object sender, EventArgs e)
        {
            if (BtnCaps.BackColor == Color.Blue)
            {
                BtnCaps.BackColor = Color.Red;
                BtnA.Text = "A";
                BtnB.Text = "B";
                BtnC.Text = "C";
                BtnD.Text = "D";
                BtnE.Text = "E";
                BtnF.Text = "F";
                BtnG.Text = "G";
                BtnH.Text = "H";
                BtnI.Text = "I";
                BtnJ.Text = "J";
                BtnK.Text = "K";
                BtnL.Text = "L";
                BtnM.Text = "M";
                BtnN.Text = "N";
                BtnO.Text = "O";
                BtnP.Text = "P";
                BtnQ.Text = "Q";
                BtnR.Text = "R";
                BtnS.Text = "S";
                BtnT.Text = "T";
                BtnU.Text = "U";
                BtnV.Text = "V";
                BtnW.Text = "W";
                BtnX.Text = "X";
                BtnY.Text = "Y";
                BtnZ.Text = "Z";
            }
            else if (BtnCaps.BackColor == Color.Red)
            {
                BtnCaps.BackColor = Color.Blue;
                BtnA.Text = "a";
                BtnB.Text = "b";
                BtnC.Text = "c";
                BtnD.Text = "d";
                BtnE.Text = "e";
                BtnF.Text = "f";
                BtnG.Text = "g";
                BtnH.Text = "h";
                BtnI.Text = "i";
                BtnJ.Text = "j";
                BtnK.Text = "k";
                BtnL.Text = "l";
                BtnM.Text = "m";
                BtnN.Text = "n";
                BtnO.Text = "o";
                BtnP.Text = "p";
                BtnQ.Text = "q";
                BtnR.Text = "r";
                BtnS.Text = "s";
                BtnT.Text = "t";
                BtnU.Text = "u";
                BtnV.Text = "v";
                BtnW.Text = "w";
                BtnX.Text = "x";
                BtnY.Text = "y";
                BtnZ.Text = "z";
            }
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            switch (Flag)
            {
                case 0:
                case 1:
                    LabValue.Text = "";
                    break;
                case 2:
                    txtPwd.Text = "";
                    break;
            }
        }
        private void BtnBackSpace_Click(object sender, EventArgs e)
        {
            if (LabValue.Text.Length > 0 || txtPwd.Text.Length > 0)
            {
                switch (Flag)
                {
                    case 0:
                    case 1:
                        LabValue.Text = LabValue.Text.Substring(0, LabValue.Text.Length - 1);
                        break;
                    case 2:
                        txtPwd.Text = txtPwd.Text.Substring(0, txtPwd.Text.Length - 1);
                        break;
                }
            }
        }
    }
}
