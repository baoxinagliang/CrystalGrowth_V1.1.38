using CrystalGrowth.CrystalCtl;
using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction.MainTain
{
    internal partial class FrmTempSW : Form
    {
        public FrmTempSW()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void FrmTempSW_Load(object sender, EventArgs e)
        {
            DataGridView1.Rows.Add(16);
            DgvAssignment(0, ref FrmVarTable.VarStr);
            DataGridView1.Rows[0].Visible = false;
            DataGridView1.Rows[1].Visible = false;
            DataGridView1.Rows[14].Visible = false;
        }
        private void DgvAssignment(int index, ref string[] strArray)
        {
            for (int i = 0; i < 16; i++)
            {
                DataGridView1.Rows[i].Cells[index].Value = strArray[59 + i];
            }
        }
        private void BtnQuit_Click(object sender, EventArgs e)
        {
            FrmSwitch.LastForm.Close();
            FrmMaintain temp = new FrmMaintain();
            FrmSwitch.Open(temp, 140, new Point(0, 130), new Size(1366, 638));
            temp.Show();
            FrmSwitch.LastForm = temp;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            DgvAssignment(1, ref FrmVarTable.VarValue);
            DataGridView1.Rows[0].Visible = false;
            DataGridView1.Rows[1].Visible = false;
            DataGridView1.Rows[14].Visible = false;
        }
    }
}
