using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.CrystalCtl
{
    internal partial class FrmCLSL : Form
    {
        public FrmCLSL()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (PLC.Count == 2)
            {
                LabSL.Text = Math.Round(PLC.ReadValue[3], 1).ToString("f1");
                LabCL_SL.Text = Math.Round(PLC.ReadValue[45], 3).ToString("f3");
                LabCL.Text = Math.Round(PLC.ReadValue[37], 1).ToString("f1");
                if (PLC.ReadStatus[1] == 1)
                {
                    BtnFixed.Visible = true;
                    BtnAuto.Visible = true;
                    LabCL_SL.BackColor = PLC.ReadStatus[8] == 1 ? Color.White : Color.Gray;
                }
                else
                {
                    BtnFixed.Visible = false;
                    BtnAuto.Visible = false;
                    LabCL_SL.BackColor = PLC.ReadStatus[7] == 1 ? Color.White : Color.Gray;
                }
                if (PLC.ReadStatus[8] == 1)
                {
                    BtnFixed.BackColor = Color.Red;
                    BtnAuto.BackColor = Color.Blue;
                }
                else
                {
                    BtnFixed.BackColor = Color.Blue;
                    BtnAuto.BackColor = Color.Red;
                }
                if (PLC.ReadStatus[7] == 1)
                {
                    BtnON.BackColor = Color.Red;
                    BtnOFF.BackColor = Color.Blue;
                }
                else
                {
                    BtnON.BackColor = Color.Blue;
                    BtnOFF.BackColor = Color.Red;
                }
                LabCL.BackColor = PLC.ReadStatus[7] == 1 || PLC.ReadStatus[9] == 1 ? Color.Gray : Color.White;
            }
        }
        private void LabCL_SL_Click(object sender, EventArgs e)
        {
            if (LabCL_SL.BackColor == Color.White)
            {
                KeyForm kf = new KeyForm();
                kf.ImportData(ref LabCL_SL, 0, 1);
                kf.ShowDialog();
                if (kf.DialogResult == DialogResult.OK)
                {
                    PLC.SendFloat(33, 176, Convert.ToSingle(LabCL_SL.Text));
                    if (PLC.ReadStatus[7] == 1)
                    {
                        Record.WriteIn("埚跟比", LabCL_SL.Text, "Yellow");
                    }
                }
            }
        }
        private void LabCL_Click(object sender, EventArgs e)
        {
            if (LabCL.BackColor == Color.White)
            {
                KeyForm kf = new KeyForm();
                kf.ImportData(ref LabCL, 0, 127);
                kf.ShowDialog();
                if (kf.DialogResult == DialogResult.OK)
                {
                    PLC.SendFloat(33, 140, Convert.ToSingle(LabCL.Text));
                    if (PLC.ReadStatus[19] == 1)
                    {
                        Record.WriteIn("埚升速度设定", LabCL.Text, "Yellow");
                    }
                }
            }
        }
        private void BtnON_Click(object sender, EventArgs e)
        {
            if (PLC.ReadStatus[7] == 0)
            {
                PLC.SendBit(30, 11, 1);
                Record.WriteIn("埚跟比控制", "ON", "Yellow");
                BtnON.BackColor = Color.Red;
                BtnOFF.BackColor = Color.Blue;
                LabCL.BackColor = Color.Gray;
                if (PLC.ReadStatus[1] == 0)
                {
                    LabCL_SL.BackColor = Color.White;
                }
            }
        }
        private void BtnOFF_Click(object sender, EventArgs e)
        {
            if (PLC.ReadStatus[7] == 1)
            {
                PLC.SendBit(30, 12, 1);
                Record.WriteIn("埚跟比控制", "OFF", "Yellow");
                BtnON.BackColor = Color.Blue;
                BtnOFF.BackColor = Color.Red;
                LabCL.BackColor = Color.White;
                if (PLC.ReadStatus[1] == 0)
                {
                    LabCL_SL.BackColor = Color.Gray;
                }
            }
        }
        private void BtnAuto_Click(object sender, EventArgs e)
        {
            PLC.SendBit(30, 13, 1);
            Record.WriteIn("埚跟比控制自动", "ON", "Yellow");
            BtnAuto.BackColor = Color.Red;
            BtnFixed.BackColor = Color.Blue;
            if (PLC.ReadStatus[1] == 1)
            {
                LabCL_SL.BackColor = Color.Gray;
            }
        }
        private void BtnFixed_Click(object sender, EventArgs e)
        {
            PLC.SendBit(30, 14, 1);
            Record.WriteIn("埚跟比控制固定值", "ON", "Yellow");
            BtnAuto.BackColor = Color.Blue;
            BtnFixed.BackColor = Color.Red;
            if (PLC.ReadStatus[1] == 1)
            {
                LabCL_SL.BackColor = Color.White;
            }
        }
    }
}
