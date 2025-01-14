using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.CrystalCtl
{
    internal partial class FrmCrucRot : Form
    {
        public FrmCrucRot()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void FrmCrucRot_Load(object sender, EventArgs e)
        {
            BtnCW.Enabled = false;
            BtnCCW.Enabled = false;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (PLC.Count == 2)
            {
                LabSP.Text = Math.Round(PLC.ReadValue[55], 1).ToString("f1");
                LabPV.Text = Math.Round(PLC.ReadValue[56], 1).ToString("f1");
                LabTorque.Text = Math.Round(PLC.ReadValue[114], 1).ToString("f1");
                LabSP.BackColor = PLC.ReadStatus[1] == 1 ? Color.Gray : Color.White;
                BtnCW.BackColor = PLC.ReadStatus[21] == 1 ? Color.Red : Color.Blue;
                BtnCCW.BackColor = PLC.ReadStatus[22] == 1 ? Color.Red : Color.Blue;
            }
        }
        private void BtnAux_Click(object sender, EventArgs e)
        {
            FrmSwitch.LastForm.Close();
            FrmCrucRotAcc fcra = new FrmCrucRotAcc();
            FrmSwitch.Open(fcra, 15, new Point(0, 200), new Size(394, 380));
            fcra.Show();
            FrmSwitch.LastForm = fcra;
        }
        private void LabSP_Click(object sender, EventArgs e)
        {
            if (LabSP.BackColor == Color.White)
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
        }
        private void BtnCW_Click(object sender, EventArgs e)
        {
            PLC.SendBit(30, 31, 1);
            Record.WriteIn("埚转顺时针", "ON", "Yellow");
            BtnCW.BackColor = Color.Red;
            BtnCCW.BackColor = Color.Blue;
        }
        private void BtnCCW_Click(object sender, EventArgs e)
        {
            PLC.SendBit(30, 32, 1);
            Record.WriteIn("埚转逆时针", "ON", "Yellow");
            BtnCW.BackColor = Color.Blue;
            BtnCCW.BackColor = Color.Red;
        }
    }
}
