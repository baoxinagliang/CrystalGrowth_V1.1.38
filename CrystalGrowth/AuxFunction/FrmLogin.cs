using CrystalGrowth.SOP;
using CrystalGrowth.Unities;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction
{
    internal partial class FrmLogin : Form
    {
        private bool SuperUserFlag = false;
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            LabFurnID.Text = IdNum.FurnaceID;
            LabCrysID.Text = IdNum.CrystalID;
            LabRunID.Text = IdNum.RunNumID;
            LabStaffID.Text = IdNum.StaffID;
        }
        private void LabStaffID_Click(object sender, EventArgs e)
        {
            FullKey fk = new FullKey();
            fk.ImportData(ref LabStaffID, new Point(550, 160), 20);
            fk.ShowDialog();
        }
        private void LabStaffID_TextChanged(object sender, EventArgs e)
        {
            IdNum.StaffID = LabStaffID.Text;
            IdNum.WriteIn();
        }
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (SuperUserFlag && LabUsrName.Text != "KayexAdmin" && LabUsrName.Text != "SuperUser")
            {
                MessageBox.Show("超级用户名输入错误!");
                return;
            }
            DataTable dt = SqliteHelper.GetDataTable(string.Format("SELECT * FROM LOGIN_DATA WHERE USER_NAME ='{0}'", LabUsrName.Text));
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("用户名输入错误!");
                return;
            }
            if (TextBoxPwd1.Text != dt.Rows[0][2].ToString())
            {
                if (SuperUserFlag == false)
                {
                    MessageBox.Show("旧密码输入错误！");
                }
                else
                {
                    MessageBox.Show("超级密码输入错误！");
                }
            }
            else
            {
                if (TextBoxPwd2.Text == "" || TextBoxPwd3.Text == "")
                {
                    MessageBox.Show("新密码不能为空！");
                }
                else
                {
                    if (TextBoxPwd2.Text != TextBoxPwd3.Text)
                    {
                        MessageBox.Show("两次输入新密码不同！");
                    }
                    else
                    {
                        int ii = SqliteHelper.ExecDataBySql(string.Format("UPDATE LOGIN_DATA Set DATE_TIME ='{0}',PASS_WORD ='{1}' WHERE USER_NAME = 'Engineer'", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), TextBoxPwd2.Text));
                        if (ii <= 0)
                        {
                            MessageBox.Show("新用户密码保存失败！");
                            return;
                        }
                        TextBoxPwd1.Text = "";
                        TextBoxPwd2.Text = "";
                        TextBoxPwd3.Text = "";
                        LabUsrName.Enabled = false;
                        LabUsrName.Text = "Engineer";
                        LabUserName.Text = "用户名";
                        LabPassWord1.Text = "旧密码";
                        BtnResetPwd.Text = "忘记密码重置";
                        MessageBox.Show("新用户密码已保存！");
                    }
                }
            }
            dt.Dispose();
        }
        private void BtnResetPwd_Click(object sender, EventArgs e)
        {
            if (BtnResetPwd.Text == "放弃修改")
            {
                LabUsrName.Enabled = false;
                LabUsrName.Text = "Engineer";
                TextBoxPwd1.Text = "";
                TextBoxPwd2.Text = "";
                TextBoxPwd3.Text = "";
                LabUserName.Text = "用户名";
                LabPassWord1.Text = "旧密码";
                BtnResetPwd.Text = "忘记密码重置";
                SuperUserFlag = false;
            }
            else
            {
                LabUsrName.Enabled = true;
                LabUsrName.Text = "";
                TextBoxPwd1.Text = "";
                TextBoxPwd2.Text = "";
                TextBoxPwd3.Text = "";
                LabUserName.Text = "超级用户";
                LabPassWord1.Text = "超级密码";
                BtnResetPwd.Text = "放弃修改";
                SuperUserFlag = true;
            }
        }
        private void LabUsrName_Click(object sender, EventArgs e)
        {
            FullKey fk = new FullKey();
            fk.ImportData(ref LabUsrName, new Point(600, 200), 20);
            fk.ShowDialog();
        }
        private void TextBoxPwd1_Click(object sender, EventArgs e)
        {
            FullKey fk = new FullKey();
            fk.ImportData(ref TextBoxPwd1, new Point(600, 200), 20);
            fk.ShowDialog();
        }
        private void TextBoxPwd2_Click(object sender, EventArgs e)
        {
            FullKey fk = new FullKey();
            fk.ImportData(ref TextBoxPwd2, new Point(600, 200), 20);
            fk.ShowDialog();
        }
        private void TextBoxPwd3_Click(object sender, EventArgs e)
        {
            FullKey fk = new FullKey();
            fk.ImportData(ref TextBoxPwd3, new Point(600, 200), 20);
            fk.ShowDialog();
        }
    }
}
