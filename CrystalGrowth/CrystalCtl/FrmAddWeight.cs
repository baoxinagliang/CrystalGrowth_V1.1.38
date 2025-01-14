using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CrystalGrowth.CrystalCtl
{
    public partial class FrmAddWeight : Form
    {
        public FrmAddWeight()
        {
            InitializeComponent();
            DataGridView1.Rows.Add(9);
            ReadParams_File();
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            FrmSwitch.LastFormClose();
            FrmCrucPos fcp = new FrmCrucPos();
            FrmSwitch.Open(fcp, 18, new Point(0, 200), new Size(394, 480));
            fcp.Show();
            FrmSwitch.LastForm = fcp;
        }
        private void ReadParams_File()
        {
            string[] TempVar;
            string[] Lines = File.ReadAllLines(FileHelper.FeedPath, Encoding.UTF8);
            if (Lines != null && Lines.Length == 10)
            {
                Array.Sort(Lines, 0, 9);
                Array.Reverse(Lines, 0, 9);
                for (int i = 0; i < 9; i++)
                {
                    TempVar = Lines[i].Split(',');
                    if (TempVar.Length == 11)
                    {
                        for (int j = 0; j <= 10; j++)
                        {
                            DataGridView1.Rows[i].Cells[j].Value = j == 0 ? TempVar[j].Substring(5) : TempVar[j];
                        }
                    }
                }
            }
        }
    }
}
