using CrystalGrowth.CrystalCtl;
using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction.CCD
{
    internal partial class FrmMeltCheckArea : Form
    {
        public static bool CheckFlag = false;
        public FrmMeltCheckArea()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void FrmMeltCheckArea_Load(object sender, EventArgs e)
        {
            ParasCam1.ReadOut();
            if (CheckFlag)
            {
                BtnOpen.BackColor = Color.Green;
            }
        }
        private void BtnOpen_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnOpen))
            {
                if (BtnOpen.BackColor == Color.RoyalBlue)
                {
                    CheckFlag = true;
                    BtnOpen.BackColor = Color.Lime;
                }
                else
                {
                    CheckFlag = false;
                    BtnOpen.BackColor = Color.RoyalBlue;
                    ExternDll.ReleasePredictor();
                }
            }
        }
        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            LabPecent.Text = IgAlgo1.per.ToString("f3");
            LabAverage.Text = IgAlgo1.avg.ToString("f3");
            LabSp.Text = ParasCam1.FullMelt.ToString();
        }
        private void LabSp_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm
            {
                Location = new Point(400, 130)
            };
            kf.ImportData(ref LabSp, 0, 1);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                ParasCam1.FullMelt = Convert.ToSingle(LabSp.Text);
            }
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnSave))
            {
                ParasCam1.WriteIn();
                Record.WriteIn("CCD全融检测参数更改", "", "Yellow");
                MessageBox.Show("保存成功！");
            }
        }
        private void FrmMeltCheckArea_FormClosed(object sender, FormClosedEventArgs e)
        {
            ParasCam1.ReadOut();
        }
    }
}
