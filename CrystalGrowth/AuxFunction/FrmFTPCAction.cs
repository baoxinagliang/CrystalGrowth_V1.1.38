using CrystalGrowth.CrystalCtl;
using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction
{
    internal partial class FrmFTPCAction : Form
    {
        public FrmFTPCAction()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void BtnFTLift_MouseDown(object sender, MouseEventArgs e)
        {
            PLC.SendBit(30, 156, 1);
            BtnFTLift.BackColor = Color.Red;
            BtnFTDown.BackColor = Color.Blue;
            BtnFTDown.Enabled = false;
        }
        private void BtnFTLift_MouseLeave(object sender, EventArgs e)
        {
            PLC.SendBit(30, 156, 0);
            BtnFTLift.BackColor = Color.Blue;
            BtnFTDown.BackColor = Color.Blue;
            BtnFTDown.Enabled = true;
        }
        private void BtnFTLift_MouseUp(object sender, MouseEventArgs e)
        {
            PLC.SendBit(30, 156, 0);
            BtnFTLift.BackColor = Color.Blue;
            BtnFTDown.BackColor = Color.Blue;
            BtnFTDown.Enabled = true;
        }
        private void BtnFTDown_MouseDown(object sender, MouseEventArgs e)
        {
            PLC.SendBit(30, 157, 1);
            BtnFTLift.Enabled = false;
            BtnFTLift.BackColor = Color.Blue;
            BtnFTDown.BackColor = Color.Red;
        }
        private void BtnFTDown_MouseLeave(object sender, EventArgs e)
        {
            PLC.SendBit(30, 157, 0);
            BtnFTLift.Enabled = true;
            BtnFTLift.BackColor = Color.Blue;
            BtnFTDown.BackColor = Color.Blue;
        }
        private void BtnFTDown_MouseUp(object sender, MouseEventArgs e)
        {
            PLC.SendBit(30, 157, 0);
            BtnFTLift.Enabled = true;
            BtnFTLift.BackColor = Color.Blue;
            BtnFTDown.BackColor = Color.Blue;
        }
        private void BtnPCLift_MouseDown(object sender, MouseEventArgs e)
        {
            PLC.SendBit(30, 152, 1);
            BtnPCDown.Enabled = false;
            BtnPCDown.BackColor = Color.Blue;
            BtnPCLift.BackColor = Color.Red;
        }
        private void BtnPCLift_MouseLeave(object sender, EventArgs e)
        {
            PLC.SendBit(30, 152, 0);
            BtnPCDown.Enabled = true;
            BtnPCDown.BackColor = Color.Blue;
            BtnPCLift.BackColor = Color.Blue;
        }
        private void BtnPCLift_MouseUp(object sender, MouseEventArgs e)
        {
            PLC.SendBit(30, 152, 0);
            BtnPCDown.Enabled = true;
            BtnPCDown.BackColor = Color.Blue;
            BtnPCLift.BackColor = Color.Blue;
        }
        private void BtnPCDown_MouseDown(object sender, MouseEventArgs e)
        {
            PLC.SendBit(30, 153, 1);
            BtnPCLift.Enabled = false;
            BtnPCLift.BackColor = Color.Blue;
            BtnPCDown.BackColor = Color.Red;
        }
        private void BtnPCDown_MouseLeave(object sender, EventArgs e)
        {
            PLC.SendBit(30, 153, 0);
            BtnPCLift.Enabled = true;
            BtnPCLift.BackColor = Color.Blue;
            BtnPCDown.BackColor = Color.Blue;
        }
        private void BtnPCDown_MouseUp(object sender, MouseEventArgs e)
        {
            PLC.SendBit(30, 153, 0);
            BtnPCLift.Enabled = true;
            BtnPCLift.BackColor = Color.Blue;
            BtnPCDown.BackColor = Color.Blue;
        }
        private void BtnFTLeft_MouseDown(object sender, MouseEventArgs e)
        {
            PLC.SendBit(30, 158, 1);
            BtnFTRight.Enabled = false;
            BtnFTRight.BackColor = Color.Blue;
            BtnFTLeft.BackColor = Color.Red;
        }
        private void BtnFTLeft_MouseLeave(object sender, EventArgs e)
        {
            PLC.SendBit(30, 158, 0);
            BtnFTRight.Enabled = true;
            BtnFTRight.BackColor = Color.Blue;
            BtnFTLeft.BackColor = Color.Blue;
        }
        private void BtnFTLeft_MouseUp(object sender, MouseEventArgs e)
        {
            PLC.SendBit(30, 158, 0);
            BtnFTRight.Enabled = true;
            BtnFTRight.BackColor = Color.Blue;
            BtnFTLeft.BackColor = Color.Blue;
        }
        private void BtnFTRight_MouseDown(object sender, MouseEventArgs e)
        {
            PLC.SendBit(30, 159, 1);
            BtnFTLeft.Enabled = false;
            BtnFTLeft.BackColor = Color.Blue;
            BtnFTRight.BackColor = Color.Red;
        }
        private void BtnFTRight_MouseLeave(object sender, EventArgs e)
        {
            PLC.SendBit(30, 159, 0);
            BtnFTLeft.Enabled = true;
            BtnFTLeft.BackColor = Color.Blue;
            BtnFTRight.BackColor = Color.Blue;
        }
        private void BtnFTRight_MouseUp(object sender, MouseEventArgs e)
        {
            PLC.SendBit(30, 159, 0);
            BtnFTLeft.Enabled = true;
            BtnFTLeft.BackColor = Color.Blue;
            BtnFTRight.BackColor = Color.Blue;
        }
        private void BtnPCLeft_MouseDown(object sender, MouseEventArgs e)
        {
            PLC.SendBit(30, 154, 1);
            BtnPCRight.Enabled = false;
            BtnPCRight.BackColor = Color.Blue;
            BtnPCLeft.BackColor = Color.Red;
        }
        private void BtnPCLeft_MouseLeave(object sender, EventArgs e)
        {
            PLC.SendBit(30, 154, 0);
            BtnPCRight.Enabled = true;
            BtnPCRight.BackColor = Color.Blue;
            BtnPCLeft.BackColor = Color.Blue;
        }
        private void BtnPCLeft_MouseUp(object sender, MouseEventArgs e)
        {
            PLC.SendBit(30, 154, 0);
            BtnPCRight.Enabled = true;
            BtnPCRight.BackColor = Color.Blue;
            BtnPCLeft.BackColor = Color.Blue;
        }
        private void BtnPCRight_Click(object sender, EventArgs e)
        {
            PLC.SendBit(30, 155, 1);
            BtnPCLeft.BackColor = Color.Blue;
            BtnPCRight.BackColor = Color.Red;
        }
        private void BtnPCRight_MouseDown(object sender, MouseEventArgs e)
        {
            PLC.SendBit(30, 155, 1);
            BtnPCLeft.Enabled = false;
            BtnPCLeft.BackColor = Color.Blue;
            BtnPCRight.BackColor = Color.Red;
        }
        private void BtnPCRight_MouseLeave(object sender, EventArgs e)
        {
            PLC.SendBit(30, 155, 0);
            BtnPCLeft.Enabled = true;
            BtnPCLeft.BackColor = Color.Blue;
            BtnPCRight.BackColor = Color.Blue;
        }
        private void BtnPCRight_MouseUp(object sender, MouseEventArgs e)
        {
            PLC.SendBit(30, 155, 0);
            BtnPCLeft.Enabled = true;
            BtnPCLeft.BackColor = Color.Blue;
            BtnPCRight.BackColor = Color.Blue;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            LabPCFTStatus.Visible = false;
            //主室升限位
            if (PLC.ReadStatusIn[35] == 1)
            {
                LabPCFTStatus.Visible = true;
                LabPCFTStatus.ForeColor = Color.Red;
                LabPCFTStatus.Text = "主室上升限位";
            }
            //主室降限位
            if (PLC.ReadStatusIn[76] == 1)
            {
                LabPCFTStatus.Visible = true;
                LabPCFTStatus.ForeColor = Color.Red;
                LabPCFTStatus.Text = "主室下降限位";
            }
            //主室左旋限位
            if (PLC.ReadStatusIn[55] == 1)
            {
                LabPCFTStatus.Visible = true;
                LabPCFTStatus.ForeColor = Color.Red;
                LabPCFTStatus.Text = "主室左旋限位";
            }
            //主室右旋限位
            if (PLC.ReadStatusIn[56] == 1)
            {
                LabPCFTStatus.Visible = true;
                LabPCFTStatus.ForeColor = Color.Red;
                LabPCFTStatus.Text = "主室右旋限位";
            }
            //副室升限位
            if (PLC.ReadStatusIn[40] == 1)
            {
                LabPCFTStatus.Visible = true;
                LabPCFTStatus.ForeColor = Color.Red;
                LabPCFTStatus.Text = "副室上升限位";
            }
            //副室降限位
            if (PLC.ReadStatusIn[77] == 1)
            {
                LabPCFTStatus.Visible = true;
                LabPCFTStatus.ForeColor = Color.Red;
                LabPCFTStatus.Text = "副室下降限位";
            }
            //副室左旋限位
            if (PLC.ReadStatusIn[33] == 1)
            {
                LabPCFTStatus.Visible = true;
                LabPCFTStatus.ForeColor = Color.Red;
                LabPCFTStatus.Text = "副室左旋限位";
            }
            //副室右旋限位
            if (PLC.ReadStatusIn[19] == 1)
            {
                LabPCFTStatus.Visible = true;
                LabPCFTStatus.ForeColor = Color.Red;
                LabPCFTStatus.Text = "副室右旋限位";
            }
            //主副室强制
            if (PLC.ReadStatus[95] == 1)
            {
                BtnFTPCForce.BackColor = Color.Red;
            }
            else
            {
                BtnFTPCForce.BackColor = Color.Blue;
            }
        }
        private void BtnFTPCForce_Click(object sender, EventArgs e)
        {
            if (BtnFTPCForce.BackColor == Color.Red)
            {
                PLC.SendBit(30, 162, 1);
                Record.WriteIn("主副室动作强制", "OFF", "Yellow");
                if (BtnFTPCForce.BackColor == Color.Red)
                {
                    BtnFTPCForce.BackColor = Color.Blue;

                    Level.FTPCForce = true;
                }
            }
            else
            {
                if (Level.FTPCForce == true)
                {
                    PLC.SendBit(30, 162, 1);
                    Record.WriteIn("主副室动作强制", "ON", "Yellow");

                    if (BtnFTPCForce.BackColor == Color.Blue)
                    {
                        BtnFTPCForce.BackColor = Color.Red;
                    }
                }
            }
        }

        private void BtnFTPCForce_MouseLeave(object sender, EventArgs e)
        {
            Level.FTPCForce = false;
        }

        private void FrmFTPCAction_Load(object sender, EventArgs e)
        {
            Level.FTPCForce = false;
        }
    }
}
