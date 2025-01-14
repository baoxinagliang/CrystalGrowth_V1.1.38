using CrystalGrowth.CrystalCtl;
using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction.MainTain
{
    internal partial class FrmPerFac : Form
    {
        public FrmPerFac()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void FrmPerFac_Load(object sender, EventArgs e)
        {
            DataGridView1.Rows.Add(8);
            DgvAssignment(0, ref FrmVarTable.VarStr);
        }
        private void DgvAssignment(int index, ref string[] strArray)
        {
            DataGridView1.Rows[0].Cells[index].Value = strArray[51];
            DataGridView1.Rows[1].Cells[index].Value = strArray[89];
            DataGridView1.Rows[2].Cells[index].Value = strArray[90];
            DataGridView1.Rows[3].Cells[index].Value = strArray[171];
            DataGridView1.Rows[4].Cells[index].Value = strArray[172];
            DataGridView1.Rows[5].Cells[index].Value = strArray[177];
            DataGridView1.Rows[6].Cells[index].Value = strArray[178];
            DataGridView1.Rows[7].Cells[index].Value = strArray[179];
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
        }
    }
}
