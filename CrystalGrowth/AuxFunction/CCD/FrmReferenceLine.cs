﻿using CrystalGrowth.CrystalCtl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction.CCD
{
    public partial class FrmReferenceLine : Form
    {
        public FrmReferenceLine()
        {
            InitializeComponent();
        }

        private void BtnXLine_Click(object sender, EventArgs e)
        {
             FrmCCD.DrawCrossLine = false;
             BtnCrossLine.BackColor = Color.RoyalBlue;

            if (FrmCCD.DrawX1)
            {
                FrmCCD.DrawX1 = false;
                BtnXLine.BackColor = Color.RoyalBlue;
            }
            else
            {
                FrmCCD.DrawX1 = true;
                BtnXLine.BackColor = Color.Red;
            }
        }

        private void BtnCrossLine_Click(object sender, EventArgs e)
        {
            FrmCCD.DrawX1 = false;
            BtnXLine.BackColor = Color.RoyalBlue;

            if (FrmCCD.DrawCrossLine)
            {
                FrmCCD.DrawCrossLine = false;
                BtnCrossLine.BackColor = Color.RoyalBlue;
            }
            else
            {
                FrmCCD.DrawCrossLine = true;
                BtnCrossLine.BackColor = Color.Red;
            }
        }

 

      

        private void LabXLineLong_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm
            {
                Location = new Point(400, 130)
            };
            kf.ImportData(ref LabXLineLong, 1, 50);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                FrmMain.GlobalParameter.XLineLongGap = Convert.ToInt32(LabXLineLong.Text);
             
            }
        }

        private void LabXLineShort_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm
            {
                Location = new Point(400, 130)
            };
            kf.ImportData(ref LabXLineShort, 1, 50);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                FrmMain.GlobalParameter.XLineShortGap = Convert.ToInt32(LabXLineShort.Text);
             
            }
        }

        private void LabCrossLineLong_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm
            {
                Location = new Point(400, 130)
            };
            kf.ImportData(ref LabCrossLineLong, 1, 50);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                FrmMain.GlobalParameter.CrossLineLongGap = Convert.ToInt32(LabCrossLineLong.Text);
             
            }
        }

        private void LabCrossLineShort_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm
            {
                Location = new Point(400, 130)
            };
            kf.ImportData(ref LabCrossLineShort, 1, 50);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                FrmMain.GlobalParameter.CrossLineShortGap = Convert.ToInt32(LabCrossLineShort.Text);
             
            }
        }

        private void FrmReferenceLine_Load(object sender, EventArgs e)
        {
            LabCrossLineLong.Text = FrmMain.GlobalParameter.CrossLineLongGap.ToString();
            LabCrossLineShort.Text = FrmMain.GlobalParameter.CrossLineShortGap.ToString();
            LabXLineLong.Text = FrmMain.GlobalParameter.XLineLongGap.ToString();
            LabXLineShort.Text = FrmMain.GlobalParameter.XLineShortGap.ToString();
            if (FrmCCD.DrawX1)
            {
                BtnXLine.BackColor = Color.Red;

            }
            else
            {
                BtnXLine.BackColor = Color.RoyalBlue;
            }

            if (FrmCCD.DrawCrossLine)
            {
                BtnCrossLine.BackColor = Color.Red;

            }
            else
            {
                BtnCrossLine.BackColor = Color.RoyalBlue;
            }
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
