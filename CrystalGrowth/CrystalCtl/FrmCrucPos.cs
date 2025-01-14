using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.CrystalCtl
{
    internal partial class FrmCrucPos : Form
    {
        public FrmCrucPos()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void FrmCrucPos_Load(object sender, EventArgs e)
        {
            if (PLC.ReadStatus[25] == 0)
            {
                PLC.SendFloat(33, 228, PLC.ReadValue[59]);
            }
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (PLC.Count == 2)
            {
                LabTotalWeight.Text = Math.Round(PLC.ReadCalcValue[7], 2).ToString("f2");
                LabPosSP.Text = Math.Round(PLC.ReadValue[58], 1).ToString("f1");
                LabPosPV.Text = Math.Round(PLC.ReadValue[59], 1).ToString("f1");
                LabCL_SP.Text = Math.Round(PLC.ReadValue[36], 1).ToString("f1");
                //工艺手自动状态标志
                if (PLC.ReadStatus[1] == 1 || PLC.ReadStatus[79] == 1)
                {
                    BtnManu.Enabled = false;
                    BtnAuto.Enabled = false;
                    BtnLoc.Enabled = false;
                    BtnSlow.Enabled = false;
                    BtnFast.Enabled = false;
                    LabPosSP.BackColor = Color.Gray;
                }
                else
                {
                    BtnManu.Enabled = true;
                    BtnAuto.Enabled = true;
                    if (PLC.ReadStatus[42] == 1)//手自动选择标志
                    {
                        BtnLoc.Enabled = true;
                        if (PLC.ReadStatus[25] == 1)//定位标志
                        {
                            BtnSlow.Enabled = false;
                            BtnFast.Enabled = false;
                            LabPosSP.BackColor = Color.Gray;
                        }
                        else
                        {
                            BtnSlow.Enabled = true;
                            BtnFast.Enabled = true;
                            LabPosSP.BackColor = Color.White;
                        }
                    }
                    else
                    {
                        BtnLoc.Enabled = false;
                        BtnSlow.Enabled = false;
                        BtnFast.Enabled = false;
                        LabPosSP.BackColor = Color.Gray;
                    }
                }
                if (PLC.ReadStatus[42] == 1)
                {
                    BtnManu.BackColor = Color.Red;
                    BtnAuto.BackColor = Color.Blue;
                }
                else
                {
                    BtnManu.BackColor = Color.Blue;
                    BtnAuto.BackColor = Color.Red;
                }
                BtnSlow.BackColor = PLC.ReadStatus[23] == 1 ? Color.Red : Color.Blue;
                BtnFast.BackColor = PLC.ReadStatus[24] == 1 ? Color.Red : Color.Blue;
                BtnLoc.BackColor = PLC.ReadStatus[25] == 1 ? Color.Red : Color.Blue;
                if (PLC.ReadValue[1] != 0.0f)
                {
                    BtnLoc.Enabled = false;
                }
            }
        }
        private void LabCL_SP_Click(object sender, EventArgs e)
        {
            if (LabCL_SP.BackColor == Color.White)
            {
                KeyForm kf = new KeyForm();
                kf.ImportData(ref LabCL_SP, 0, 127);
                kf.ShowDialog();
                if (kf.DialogResult == DialogResult.OK)
                {
                    PLC.SendFloat(33, 140, Convert.ToSingle(LabCL_SP.Text));
                    if (PLC.ReadStatus[19] == 1)
                    {
                        Record.WriteIn("埚升速度设定", LabCL_SP.Text, "Yellow");
                    }
                }
            }
        }
        private void LabPosSP_Click(object sender, EventArgs e)
        {
            if (LabPosSP.BackColor == Color.White)
            {
                KeyForm kf = new KeyForm();
                kf.ImportData(ref LabPosSP, -1000, 1000);
                kf.ShowDialog();
                if (kf.DialogResult == DialogResult.OK)
                {
                    PLC.SendFloat(33, 228, Convert.ToSingle(LabPosSP.Text));
                }
            }
        }
        private void BtnManu_Click(object sender, EventArgs e)
        {
            PLC.SendBit(30, 73, 1);
            Record.WriteIn("坩埚位置手动", "ON", "Yellow");
            BtnManu.BackColor = Color.Red;
            BtnAuto.BackColor = Color.Blue;
            BtnLoc.Enabled = true;
            //定位标志
            if (PLC.ReadStatus[25] == 0)
            {
                BtnSlow.Enabled = true;
                BtnFast.Enabled = true;
                LabPosSP.BackColor = Color.White;
            }
        }
        private void BtnAuto_Click(object sender, EventArgs e)
        {
            PLC.SendBit(30, 74, 1);
            Record.WriteIn("坩埚位置自动", "ON", "Yellow");
            BtnManu.BackColor = Color.Blue;
            BtnAuto.BackColor = Color.Red;
            BtnLoc.Enabled = false;
            BtnSlow.Enabled = false;
            BtnFast.Enabled = false;
            LabPosSP.BackColor = Color.Gray;
        }
        private void BtnSlow_Click(object sender, EventArgs e)
        {
            PLC.SendBit(30, 33, 1);
            Record.WriteIn("坩埚位置慢升", "ON", "Yellow");
            BtnSlow.BackColor = Color.Red;
            BtnFast.BackColor = Color.Blue;
        }
        private void BtnFast_Click(object sender, EventArgs e)
        {
            PLC.SendBit(30, 34, 1);
            Record.WriteIn("坩埚位置快升", "ON", "Yellow");
            BtnSlow.BackColor = Color.Blue;
            BtnFast.BackColor = Color.Red;
        }
        private void BtnLoc_Click(object sender, EventArgs e)
        {
            if (PLC.ReadStatus[25] == 1)
            {
                PLC.SendBit(30, 35, 1);
                Record.WriteIn("坩埚位置定位", "OFF", "Yellow");
            }
            else
            {
                PLC.SendBit(30, 35, 1);
                Record.WriteIn("坩埚位置定位", "ON", "Yellow");
            }
            if (BtnLoc.BackColor == Color.Red)
            {
                BtnLoc.BackColor = Color.Blue;
                LabPosSP.BackColor = Color.White;
            }
            else
            {
                BtnLoc.BackColor = Color.Red;
                LabPosSP.BackColor = Color.Gray;
            }
        }
        private void LabTotalWeight_Click(object sender, EventArgs e)
        {
            FrmLevel frmLevel = new FrmLevel("Engineer", "Engineer");
            frmLevel.ShowDialog();
            if (frmLevel.DialogResult == DialogResult.OK)
            {
                KeyForm kf = new KeyForm();
                kf.ImportData(ref LabTotalWeight, 0, 1000);
                kf.ShowDialog();
                if (kf.DialogResult == DialogResult.OK)
                {
                    PLC.SendFloat(35, 24, Convert.ToSingle(LabTotalWeight.Text));
                    Record.WriteIn("投料重量设定", LabTotalWeight.Text, "Yellow");
                }
            }
        }

        private void BtnAddWeight_Click(object sender, EventArgs e)
        {
            FrmSwitch.LastFormClose();
            FrmAddWeight faw = new FrmAddWeight();
            FrmSwitch.Open(faw, 18, new Point(0, 200), new Size(611, 474));
            faw.Show();
            FrmSwitch.LastForm = faw;
        }
    }
}
