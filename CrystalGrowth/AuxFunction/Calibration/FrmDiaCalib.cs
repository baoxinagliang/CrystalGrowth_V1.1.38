using CrystalGrowth.CrystalCtl;
using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction.Calibration
{
    internal partial class FrmDiaCalib : Form
    {
        string PixValue = "0.00";
        string DiaValue = "0.00";
        public FrmDiaCalib()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void FrmDiaCalib_Load(object sender, EventArgs e)
        {
            LabDiaCalibNeck.Enabled = false;
            BtnCalibNeck.Enabled = false;
            LabDiaCalibCrown.Enabled = false;
            BtnCalibCrown.Enabled = false;
            LabDiaCalibBody.Enabled = false;
            BtnCalibBody.Enabled = false;
            switch (Mode.Current)
            {
                case 1:
                    LabDiaCalibNeck.Enabled = true;
                    BtnCalibNeck.Enabled = true;
                    TCDiaCalib.SelectedIndex = 0;
                    LabDateTime.Text = Calibrate.ReadTime(2);
                    break;
                case 2:
                    LabDiaCalibCrown.Enabled = true;
                    BtnCalibCrown.Enabled = true;
                    TCDiaCalib.SelectedIndex = 1;
                    LabDateTime.Text = Calibrate.ReadTime(3);
                    break;
                case 3:
                    LabDiaCalibBody.Enabled = true;
                    BtnCalibBody.Enabled = true;
                    TCDiaCalib.SelectedIndex = 2;
                    LabDateTime.Text = Calibrate.ReadTime(4);
                    break;
                default:
                    TCDiaCalib.SelectedIndex = 0;
                    LabDateTime.Text = Calibrate.ReadTime(2);
                    break;
            }
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            LabDiaCoefNeck.Text = Math.Round(PLC.ReadCalibValue[1], 3).ToString("f3");
            LabDiaCoefCrown.Text = Math.Round(PLC.ReadCalibValue[3], 3).ToString("f3");
            LabDiaCoefBody.Text = Math.Round(PLC.ReadCalibValue[5], 3).ToString("f3");
            PixValue = Math.Round(IgAlgo1.PixelDiameter, 2).ToString("f2");
            LabRawPxlPVNeck.Text = PixValue;
            LabRawPxlPVCrown.Text = PixValue;
            LabRawPxlPVBody.Text = PixValue;
            DiaValue = Math.Round(PLC.ReadValue[7], 2).ToString("f2");
            LabDiaPVNeck.Text = DiaValue;
            LabDiaPVCrown.Text = DiaValue;
            LabDiaPVBody.Text = DiaValue;
            switch (Mode.Current)
            {
                case 1:
                    LabDiaCalibNeck.Enabled = true;
                    BtnCalibNeck.Enabled = true;
                    LabDiaCalibCrown.Enabled = false;
                    BtnCalibCrown.Enabled = false;
                    LabDiaCalibBody.Enabled = false;
                    BtnCalibBody.Enabled = false;
                    break;
                case 2:
                    LabDiaCalibNeck.Enabled = false;
                    BtnCalibNeck.Enabled = false;
                    LabDiaCalibCrown.Enabled = true;
                    BtnCalibCrown.Enabled = true;
                    LabDiaCalibBody.Enabled = false;
                    BtnCalibBody.Enabled = false;
                    break;
                case 3:
                    LabDiaCalibNeck.Enabled = false;
                    BtnCalibNeck.Enabled = false;
                    LabDiaCalibCrown.Enabled = false;
                    BtnCalibCrown.Enabled = false;
                    LabDiaCalibBody.Enabled = true;
                    BtnCalibBody.Enabled = true;
                    break;
            }
        }
        private void LabDiaCoefNeck_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm();
            kf.ImportData(ref LabDiaCoefNeck, 0, 2);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                PLC.SendFloat(34, 0, Convert.ToSingle(LabDiaCoefNeck.Text));
                Record.WriteIn("引晶校准系数", LabDiaCoefNeck.Text, "Yellow");
                LabDateTime.Text = Calibrate.WriteTime(1, float.Parse(LabDiaCoefNeck.Text));
                LabDateTime.Text = Calibrate.ReadTime(1);
            }
        }
        private void LabDiaCalibNeck_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm();
            kf.ImportData(ref LabDiaCalibNeck, 0, 500);
            kf.ShowDialog();
        }
        private void BtnCalibNeck_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnCalibNeck))
            {
                if (PLC.ReadOthersValue[1] > 0 && PLC.ReadStatus[1] == 1 && Mode.Current == Mode.Neck)
                {
                    Calibrate.WriteValue(2, 1, LabDiaCalibNeck.Text);
                    LabDateTime.Text = Calibrate.DateTimeStr;
                    Record.WriteIn("引晶直径校准", LabDiaCoefNeck.Text, "Yellow");
                }
                else
                {
                    LabDateTime.ForeColor = Color.Red;
                    LabDateTime.Text = "校准条件不具备";
                }
            }
        }
        private void LabDiaCoefCrown_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm();
            kf.ImportData(ref LabDiaCoefCrown, 0, 2);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                PLC.SendFloat(34, 8, Convert.ToSingle(LabDiaCoefCrown.Text));
                Record.WriteIn("放肩校准系数", LabDiaCoefCrown.Text, "Yellow");
                LabDateTime.Text = Calibrate.WriteTime(3, Convert.ToSingle(LabDiaCoefCrown.Text));
                LabDateTime.Text = Calibrate.ReadTime(3);
            }
        }
        private void LabDiaCalibCrown_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm();
            kf.ImportData(ref LabDiaCalibCrown, 0, 500);
            kf.ShowDialog();
        }
        private void BtnCalibCrown_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnCalibCrown))
            {
                if (PLC.ReadOthersValue[1] > 0 && Mode.Current == Mode.Crown)
                {
                    Calibrate.WriteValue(3, 1, LabDiaCalibCrown.Text);
                    LabDateTime.Text = Calibrate.DateTimeStr;
                    Record.WriteIn("放肩直径校准", LabDiaCalibCrown.Text, "Yellow");
                }
                else
                {
                    LabDateTime.ForeColor = Color.Red;
                    LabDateTime.Text = "校准条件不具备";
                }
            }
        }
        private void LabDiaCoefBody_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm();
            kf.ImportData(ref LabDiaCoefBody, 0, 2);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                PLC.SendFloat(34, 16, Convert.ToSingle(LabDiaCoefBody.Text));
                Record.WriteIn("等径校准系数", LabDiaCoefBody.Text, "Yellow");
                LabDateTime.Text = Calibrate.WriteTime(5, float.Parse(LabDiaCoefBody.Text));
                LabDateTime.Text = Calibrate.ReadTime(5);
            }
        }
        private void LabDiaCalibBody_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm();
            kf.ImportData(ref LabDiaCalibBody, 0, 500);
            kf.ShowDialog();
        }
        private void BtnCalibBody_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnCalibBody))
            {
                BeginInvoke(new Action(() =>
                {
                    DialogResult answer = MessageBox.Show("请确认是否需要退出直径控制，以免直径偏差过大?\r\n直径校准继续请按是，取消请按否！", "直径校准", MessageBoxButtons.YesNo);
                    if (answer == DialogResult.Yes)
                    {
                        if (PLC.ReadOthersValue[1] > 0 && Mode.Current == Mode.Body)
                        {
                            Calibrate.WriteValue(4, 1, LabDiaCalibBody.Text);
                            LabDateTime.Text = Calibrate.DateTimeStr;
                            Record.WriteIn("等径直径校准", LabDiaCalibBody.Text, "Yellow");
                        }
                        else
                        {
                            LabDateTime.ForeColor = Color.Red;
                            LabDateTime.Text = "校准条件不具备";
                        }
                    }
                }));
            }
        }
        private void TCDiaCalib_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (TCDiaCalib.SelectedTab.Name)
            {
                case "TPCrown":
                    LabDateTime.Text = Calibrate.ReadTime(3);
                    break;
                case "TPBody":
                    LabDateTime.Text = Calibrate.ReadTime(4);
                    break;
                default:
                    LabDateTime.Text = Calibrate.ReadTime(2);
                    break;
            }
        }
    }
}
