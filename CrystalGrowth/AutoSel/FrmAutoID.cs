using CrystalGrowth.SOP;
using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.AutoSel
{
    internal partial class FrmAutoID : Form
    {
        public string LastCrystalID = "";
        public FrmAutoID()
        {
            InitializeComponent();
        }
        private void FrmAutoID_Load(object sender, EventArgs e)
        {
            LabFurnID.Text = IdNum.FurnaceID;
            LabCrysID.Text = IdNum.CrystalID;
            LabRunID.Text = IdNum.RunNumID;
            LastCrystalID = IdNum.CrystalID;
            LabStaffID.Text = IdNum.StaffID;
        }
        private void LabCrysID_Click(object sender, EventArgs e)
        {
            FullKey fk = new FullKey();
            fk.ImportData(ref LabCrysID, new Point(650, 195), 20);
            fk.ShowDialog();
        }
        private void LabCrysID_TextChanged(object sender, EventArgs e)
        {
            IdNum.CrystalID = LabCrysID.Text;
            IdNum.WriteIn();
        }
        private void LabRunID_Click(object sender, EventArgs e)
        {
            FullKey fk = new FullKey();
            fk.ImportData(ref LabRunID, new Point(650, 195), 20);
            fk.ShowDialog();
        }
        private void LabRunID_TextChanged(object sender, EventArgs e)
        {
            IdNum.RunNumID = LabRunID.Text;
            IdNum.WriteIn();
        }
        private void LabStaffID_Click(object sender, EventArgs e)
        {
            FullKey fk = new FullKey();
            fk.ImportData(ref LabStaffID, new Point(650, 195), 20);
            fk.ShowDialog();
        }
        private void LabStaffID_TextChanged(object sender, EventArgs e)
        {
            IdNum.StaffID = LabStaffID.Text;
            IdNum.WriteIn();
        }
        private void BtnGoOn_Click(object sender, EventArgs e)
        {
            if (LastCrystalID == LabCrysID.Text)
            {
                LabInfo.Visible = true;
                LabInfo.Text = "晶体编号未修改,请修改后继续!";
                return;
            }
            FrmAutoCheck fac = new FrmAutoCheck();
            FrmSwitch.Open(fac, 212, new Point(0, 60), new Size(1366, 708));
            fac.Show();
            Close();
        }
        private void BtnGiveUp_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnGiveUp))
            {
                PLC.SendFloat(33, 0, 0);
                Close();
            }
        }
    }
}
