using CrystalGrowth.CrystalCtl;
using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction.Calibration
{
    internal partial class FrmCameraPos : Form
    {
        public FrmCameraPos()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void FrmCameraPos_Load(object sender, EventArgs e)
        {
            LabDateTime.Text = Calibrate.ReadTime(5);

            ParasCam1.MeltGapAbsMeasure_T = FrmMain.GlobalParameter.MeltGapAbsMeasure_T;
            ParasCam1.MeltGapAbsMeasure_H = FrmMain.GlobalParameter.MeltGapAbsMeasure_H;
            ParasCam1.MeltGapAbsMeasure_R = FrmMain.GlobalParameter.MeltGapAbsMeasure_R;

            Lbl_T.Text = ParasCam1.MeltGapAbsMeasure_T.ToString("f0");
            Lbl_H.Text = ParasCam1.MeltGapAbsMeasure_H.ToString("f0");
            Lbl_R.Text = ParasCam1.MeltGapAbsMeasure_R.ToString("f0");
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            LabCCDCable.Text = PLC.ReadCalibValue[7].ToString("F1");
            LabCCDHtr.Text = PLC.ReadCalibValue[8].ToString();


            Lbl_T.Text = ParasCam1.MeltGapAbsMeasure_T.ToString("f0");
            Lbl_H.Text = ParasCam1.MeltGapAbsMeasure_H.ToString("f0");
            Lbl_R.Text = ParasCam1.MeltGapAbsMeasure_R.ToString("f0");
        }
        private void LabCCDCable_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm();
            kf.ImportData(ref LabCCDCable, 1, 2000);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                Calibrate.WriteValue(5, 1, LabCCDCable.Text);
            }
        }
        private void LabCCDHtr_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm();
            kf.ImportData(ref LabCCDHtr, 1, 5000);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                Calibrate.WriteValue(5, 2, LabCCDHtr.Text);
            }
        }

        private void Lbl_T_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm
            {
                Location = new Point(400, 130)
            };
            kf.ImportData(ref Lbl_T, 10, 800);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                ParasCam1.MeltGapAbsMeasure_T = Convert.ToSingle(Lbl_T.Text);
                FrmMain.GlobalParameter.MeltGapAbsMeasure_T = ParasCam1.MeltGapAbsMeasure_T;
                Record.WriteIn("CCD到设备中心距", Lbl_T.Text, "Yellow");
            }
        }

        private void Lbl_H_Click(object sender, EventArgs e)
        { 

            KeyForm kf = new KeyForm
            {
                Location = new Point(400, 130)
            };
            kf.ImportData(ref Lbl_H, 10, 2000);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                ParasCam1.MeltGapAbsMeasure_H = Convert.ToSingle(Lbl_H.Text);
                FrmMain.GlobalParameter.MeltGapAbsMeasure_H = ParasCam1.MeltGapAbsMeasure_H;
                Record.WriteIn("CCD到导流筒筒底垂直距离", Lbl_H.Text, "Yellow");
            }

        }

        private void Lbl_R_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm
            {
                Location = new Point(400, 130)
            };
            kf.ImportData(ref Lbl_R, 10, 500);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                ParasCam1.MeltGapAbsMeasure_R = Convert.ToSingle(Lbl_R.Text);
                FrmMain.GlobalParameter.MeltGapAbsMeasure_R = ParasCam1.MeltGapAbsMeasure_R;
                Record.WriteIn("导流筒下口半径", Lbl_R.Text, "Yellow");
            }
        }
    }
}
