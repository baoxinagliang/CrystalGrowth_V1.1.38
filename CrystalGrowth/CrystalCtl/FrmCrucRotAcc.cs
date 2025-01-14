using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.CrystalCtl
{
    internal partial class FrmCrucRotAcc : Form
    {
        public FrmCrucRotAcc()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (PLC.Count == 2)
            {
                LabSP.Text = Math.Round(PLC.ReadValue[55], 1).ToString("f1");
                LabPV.Text = Math.Round(PLC.ReadValue[56], 1).ToString("f1");
                LabAccSP.Text = Math.Round(PLC.ReadValue[57], 1).ToString("f1");
                if (PLC.ReadStatus[1] == 1)
                {
                    BtnManu.Visible = true;
                    BtnAuto.Visible = true;
                    if (PLC.ReadStatus[39] == 1)
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
                if (PLC.ReadStatus[39] == 1)
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
            FrmCrucRot fcr = new FrmCrucRot();
            FrmSwitch.Open(fcr, 14, new Point(0, 200), new Size(394, 380));
            fcr.Show();
            FrmSwitch.LastForm = fcr;
        }
        private void LabSP_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm();
            kf.ImportData(ref LabSP, 0, 18);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                PLC.SendFloat(33, 216, Convert.ToSingle(LabSP.Text));
                if (PLC.ReadStatus[21] == 1 || PLC.ReadStatus[22] == 1)
                {
                    Record.WriteIn("坩埚转速设定", LabSP.Text, "Yellow");
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
                PLC.SendFloat(33, 224, Convert.ToSingle(LabAccSP.Text));
                if (PLC.ReadStatus[21] == 1 || PLC.ReadStatus[22] == 1)
                {
                    Record.WriteIn("埚转加速度设定", LabAccSP.Text, "Yellow");
                }
            }
        }
        private void BtnManu_Click(object sender, EventArgs e)
        {
            PLC.SendBit(30, 67, 1);
            Record.WriteIn("埚转速率手动", "ON", "Yellow");
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
            PLC.SendBit(30, 68, 1);
            Record.WriteIn("埚转速率自动", "ON", "Yellow");
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
