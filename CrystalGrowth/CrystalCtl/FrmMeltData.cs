using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CrystalGrowth.CrystalCtl
{
    internal partial class FrmMeltData : Form
    {
        public FrmMeltData()
        {
            InitializeComponent();
        }
        private void FrmMeltData_Load(object sender, EventArgs e)
        {
            ReadParams();
            dataGridView1.ClearSelection();
        }
        public void ReadParams()
        {
            string[] TempVar;
            char[] SplitChar = new char[] { ',' };
            string[] Strs = File.ReadAllLines(FileHelper.GrowthDataPath, System.Text.Encoding.UTF8);
            Array.Sort(Strs, 0, 10);
            Array.Reverse(Strs, 0, 10);
            dataGridView1.Rows.Add(10);
            for (int i = 0; i <= 9; i++)
            {
                TempVar = Strs[i].Split(SplitChar);
                dataGridView1[0, i].Value = TempVar[0];
                dataGridView1[1, i].Value = TempVar[1];
                dataGridView1[2, i].Value = TempVar[2];
                dataGridView1[3, i].Value = TempVar[3];
                dataGridView1[4, i].Value = TempVar[4];
                dataGridView1[5, i].Value = TempVar[5];
                dataGridView1[6, i].Value = TempVar[6];
                dataGridView1[7, i].Value = TempVar[7];
                dataGridView1[8, i].Value = TempVar[8];
                dataGridView1[9, i].Value = TempVar[9];
                dataGridView1[10, i].Value = TempVar[10];
                dataGridView1[11, i].Value = TempVar[11];
                dataGridView1[12, i].Value = TempVar[12];
                dataGridView1[13, i].Value = TempVar[13];
                dataGridView1[14, i].Value = TempVar[14];
                dataGridView1[15, i].Value = TempVar[15];
                dataGridView1[16, i].Value = TempVar[16];
            }
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            FrmSwitch.LastForm.Close();
            FrmMeltTemp fmt = new FrmMeltTemp();
            FrmSwitch.Open(fmt, 4, new Point(0, 200), new Size(611, 494));
            fmt.Show();
            FrmSwitch.LastForm = fmt;
        }
    }
}
