using CrystalGrowth.Unities;
using System;
using System.Windows.Forms;

namespace CrystalGrowth.AutoSel
{
    internal partial class FrmAutoCheck : Form
    {
        int PressCnt = 0;
        readonly FurnacePic Furnace;
        public FrmAutoCheck()
        {
            InitializeComponent();
            Furnace = new FurnacePic();
        }
        private void FrmAutoCheck_FormClosed(object sender, FormClosedEventArgs e)
        {
            Furnace.Body = null;
        }
        private void FrmAutoCheck_Load(object sender, EventArgs e)
        {
            LabTwo.Visible = false;
            LabThree.Visible = false;
            LabFour.Visible = false;
            LabFive.Visible = false;
        }
        private void BtnGoOn_Click(object sender, EventArgs e)
        {
            PressCnt++;
            switch (PressCnt)
            {
                case 1:
                    PicCheck.Image = Furnace.Change(2);
                    LabTwo.Visible = true;
                    break;
                case 2:
                    PicCheck.Image = Furnace.Change(3);
                    LabThree.Visible = true;
                    break;
                case 3:
                    PicCheck.Image = Furnace.Change(4);
                    LabFour.Visible = true;
                    break;
                case 4:
                    PicCheck.Image = Furnace.Change(5);
                    LabFive.Visible = true;
                    break;
                case 5:
                    Close();
                    PLC.SendFloat(33, 0, 2);//start pumpdown
                    FrmSwitch.OpenAutoForm();
                    break;
            }
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
