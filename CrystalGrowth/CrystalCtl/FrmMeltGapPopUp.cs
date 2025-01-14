using CrystalGrowth.AuxFunction.CCD;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.CrystalCtl
{
    internal partial class FrmMeltGapPopUp : Form
    {
        private static bool visible = false;
        private FrmMeltGapPopUp()
        {
            InitializeComponent();
        }
        static FrmMeltGapPopUp Single;
        public static bool Visible1
        {
            get
            {
                return visible;
            }
            set
            {
                visible = value;
                if (visible && !FrmCCD.IsOpen && FrmImage.Single.Visible)
                {
                    Single.Show();
                    Single.Timer1.Enabled = true;
                }
                else
                {
                    Single.Timer1.Enabled = false;
                    Single.Hide();
                }
            }
        }
        public static FrmMeltGapPopUp CreateInstrance()
        {
            if (Single == null)
            {
                Single = new FrmMeltGapPopUp();
                Single.FormClosed += Single_FormClosed;
            }
            return Single;
        }
        static void Single_FormClosed(object sender, FormClosedEventArgs e)
        {
            Single = null;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            BackColor = BackColor == Color.LimeGreen ? Color.IndianRed : Color.LimeGreen;
        }
    }
}
