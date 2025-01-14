using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.CrystalCtl
{
    internal partial class FrmSeedRotAcc : Form
    {
        public FrmSeedRotAcc()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (PLC.Count == 2)
            {
                LabSP.Text = Math.Round(PLC.ReadValue[50], 1).ToString("f1");
                LabPV.Text = Math.Round(PLC.ReadValue[51], 1).ToString("f1");
                LabAccSP.Text = Math.Round(PLC.ReadValue[52], 1).ToString("f1");
                if (PLC.ReadStatus[1] == 1)
                {
                    BtnManu.Visible = true;
                    BtnAuto.Visible = true;
                    if (PLC.ReadStatus[38] == 1)
                    {
                        LabSP.BackColor = Color.White;
                        LabAccSP.BackColor = Color.White;
                    }
                    else
                    {
                        LabSP.BackColor = Color.Gray;
                        LabAccSP.BackColor = Color.Gray;
                    }
                }
                else
                {
                    BtnManu.Visible = false;
                    BtnAuto.Visible = false;
                }
                if (PLC.ReadStatus[38] == 1)
                {
                    BtnManu.BackColor = Color.Red;
                    BtnAuto.BackColor = Color.Blue;
                }
                else
                {
                    BtnManu.BackColor = Color.Blue;
                    BtnAuto.BackColor = Color.Red;
                }
            }
        }
        private void BtnQuit_Click(object sender, EventArgs e)
        {
            FrmSwitch.LastForm.Close();
            FrmSeedRot fsr = new FrmSeedRot();
            FrmSwitch.Open(fsr, 12, new Point(0, 200), new Size(394, 380));
            fsr.Show();
            FrmSwitch.LastForm = fsr;
        }
        private void LabSP_Click(object sender, EventArgs e)
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
        private void LabAccSP_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm();
            kf.ImportData(ref LabAccSP, 5, 3600);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                PLC.SendFloat(33, 204, Convert.ToSingle(LabAccSP.Text));
                if (PLC.ReadStatus[15] == 1 || PLC.ReadStatus[16] == 1)
                {
                    Record.WriteIn("晶转加速度设定", LabAccSP.Text, "Yellow"); ;
                }
            }
        }
        private void BtnManu_Click(object sender, EventArgs e)
        {
            PLC.SendBit(30, 65, 1);
            Record.WriteIn("晶转速率手动", "ON", "Yellow");
            BtnManu.BackColor = Color.Red;
            BtnAuto.BackColor = Color.Blue;
            if (PLC.ReadStatus[1] == 1)
            {
                LabSP.BackColor = Color.White;
                LabAccSP.BackColor = Color.White;
            }
        }
        private void BtnAuto_Click(object sender, EventArgs e)
        {
            PLC.SendBit(30, 66, 1);
            Record.WriteIn("晶转速率自动", "ON", "Yellow");
            BtnManu.BackColor = Color.Blue;
            BtnAuto.BackColor = Color.Red;
            if (PLC.ReadStatus[1] == 1)
            {
                LabSP.BackColor = Color.Gray;
                LabAccSP.BackColor = Color.Gray;
            }
        }
    }
}
