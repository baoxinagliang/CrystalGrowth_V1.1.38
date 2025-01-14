using CrystalGrowth.SOP;
using CrystalGrowth.Unities;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.CrystalCtl
{
    internal partial class FrmLevel : Form
    {
        string UserName = "";
        public FrmLevel(string dbName, string strName)
        {
            InitializeComponent();
            TxtName.Text = strName;
            UserName = dbName;
        }
        private void TxtPassWord_Click(object sender, EventArgs e)
        {
            FullKey fk = new FullKey();
            fk.ImportData(ref TxtPassWord, new Point(Location.X + Width - 10, Location.Y), 20);
            fk.ShowDialog();
        }
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnConfirm))
            {
                DataTable dt = SqliteHelper.GetDataTable(string.Format("SELECT * FROM LOGIN_DATA WHERE USER_NAME='{0}'", UserName));
                if (dt.Rows.Count >= 1 && TxtPassWord.Text == dt.Rows[0][2].ToString())
                {
                    DialogResult = DialogResult.OK;
                    Level.UserName = UserName;
                    Close();
                }
                else
                {
                    LabInfo.Text = "密码输入错误！";
                }
            }
        }
        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmLevel_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Level.UserName) && Level.UserName== UserName)
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
