using CrystalGrowth.SOP;
using CrystalGrowth.Unities;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction.MainTain
{
    internal partial class FrmMaintainLock : Form
    {
        public static bool LockFormFlag = false;
        public FrmMaintainLock()
        {
            InitializeComponent();
        }
        private void TextBoxPwd_Click(object sender, EventArgs e)
        {
            FullKey fk = new FullKey();
            fk.ImportData(ref TextBoxPwd, new Point(561, 220), 20);
            fk.ShowDialog();
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            DataTable dt = SqliteHelper.GetDataTable("SELECT * FROM LOGIN_DATA WHERE USER_NAME ='Engineer'");
            string Pwd = dt.Rows[0][2].ToString();
            if (TextBoxPwd.Text != Pwd || TextBoxPwd.Text == "KX777777")
            {
                MessageBox.Show("密码输入错误！");
            }
            else
            {
                FrmSwitch.OpenAutoForm();
                LockFormFlag = false;
            }
        }
        private void FrmMaintainLock_Load(object sender, EventArgs e)
        {
            LockFormFlag = true;
        }
    }
}