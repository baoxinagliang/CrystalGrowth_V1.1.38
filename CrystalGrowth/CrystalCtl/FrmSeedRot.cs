using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.CrystalCtl
{
    internal partial class FrmSeedRot : Form
    {
        public FrmSeedRot()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void FrmSeedRot_Load(object sender, EventArgs e)
        {
            BtnCW.Enabled = false;
            BtnCCW.Enabled = false;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (PLC.Count == 2)
            {
                LabSP.Text = Math.Round(PLC.ReadValue[50], 1).ToString("f1");
                LabPV.Text = Math.Round(PLC.ReadValue[51], 1).ToString("f1");
                LabTorque.Text = Math.Round(PLC.ReadValue[113], 1).ToString("f1");
                LabSP.BackColor = PLC.ReadStatus[1] == 1 ? Color.Gray : Color.White;
                BtnCW.BackColor = PLC.ReadStatus[15] == 1 ? Color.Red : Color.Blue;
                BtnCCW.BackColor = PLC.ReadStatus[16] == 1 ? Color.Red : Color.Blue;
            }
        }
        private void BtnAux_Click(object sender, EventArgs e)
        {
            FrmSwitch.LastForm.Close();
            FrmSeedRotAcc fsra = new FrmSeedRotAcc();
            FrmSwitch.Open(fsra, 13, new Point(0, 200), new Size(394, 380));
            fsra.Show();
            FrmSwitch.LastForm = fsra;
        }
        private void LabSP_Click(object sender, EventArgs e)
        {
            if (LabSP.BackColor == Color.White)
            {
                KeyForm kf = new KeyForm();
                kf.ImportData(ref LabSP, 0, 30);
                kf.ShowDialog();
                if (kf.DialogResult == DialogResult.OK)
                {
                    PLC.SendFloat(33, 196, Convert.ToSingle(LabSP.Text));
                    if (PLC.ReadStatus[15] == 1 || PLC.ReadStatus[16] == 1)
                    {
                        Record.WriteIn("籽晶转速设定", LabSP.Text, "Yellow"); ;
                    }
                }
            }
        }
        private void BtnCW_Click(object sender, EventArgs e)
        {
            PLC.SendBit(30, 24, 1);
            Record.WriteIn("晶转顺时针", "ON", "Yellow");
            BtnCW.BackColor = Color.Red;
            BtnCCW.BackColor = Color.Blue;
        }
        private void BtnCCW_Click(object sender, EventArgs e)
        {
            PLC.SendBit(30, 25, 1);
            Record.WriteIn("晶转逆时针", "ON", "Yellow");
            BtnCW.BackColor = Color.Blue;
            BtnCCW.BackColor = Color.Red;
        }
    }
}
