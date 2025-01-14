using CrystalGrowth.CrystalCtl;
using CrystalGrowth.Unities;
using System;
using System.Collections;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction.CCD
{
    public partial class FrmShieldMeasure : Form
    {
        public static bool StartFlag = false;
        public static event Action<string> ShieldAlarmEvent;
        public static void CheckPos()
        {
            Task StatisticTask = Task.Run(() =>
            {
                StartFlag = true;
                double Avg = 0;
                double CurrentShieldDia = 0;
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(300);
                    if (IgAlgo1.ShieldR > 0)
                    {
                        Avg += IgAlgo1.ShieldR;
                    }
                }
                Avg /= 10;
                CurrentShieldDia = Avg * 2;
                StartFlag = false;
                double LastShieldDia = ParasCam1.ShieldDiafac * ParasCam1.ShieldRealDia;
                double TempValue = CurrentShieldDia - LastShieldDia;
                if (TempValue >= 0 && TempValue >= ParasCam1.ShieldUpAlarm)
                {
                    //超上限报警
                    ShieldAlarmEvent($"计算直径像素值{Math.Round(CurrentShieldDia, 2)}超出校准直径像素值{Math.Round(LastShieldDia, 2)}的正限值{ParasCam1.ShieldUpAlarm}请检查导流筒标定");//细
                }
                if (TempValue < 0 && TempValue <= ParasCam1.ShieldDownAlarm)
                {
                    //超下线限报警
                    ShieldAlarmEvent($"计算直径像素值{Math.Round(CurrentShieldDia, 2)}超出校准直径像素值{Math.Round(LastShieldDia, 2)}的负限值{ParasCam1.ShieldDownAlarm}请检查导流筒标定");//粗
                }
            });
        }
        readonly Queue AverageFilter;
        public FrmShieldMeasure()
        {
            InitializeComponent();
            AverageFilter = new Queue();
            Load += Timer1_Tick;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            LabLeftX.Text = ParasCam1.Shieldlx.ToString();
            LabLeftY.Text = ParasCam1.Shieldly.ToString();
            LabLeftW.Text = ParasCam1.Shieldlw.ToString();
            LabLeftH.Text = ParasCam1.Shieldlh.ToString();
            LabRightX.Text = ParasCam1.Shieldrx.ToString();
            LabRightY.Text = ParasCam1.Shieldry.ToString();
            LabRightW.Text = ParasCam1.Shieldrw.ToString();
            LabRightH.Text = ParasCam1.Shieldrh.ToString();
            LabThreshholdLeft.Text = ParasCam1.ShieldThresholdLeft.ToString();
            LabThreshholdRight.Text = ParasCam1.ShieldThresholdRight.ToString();
            LabShieldRealDia.Text = ParasCam1.ShieldRealDia.ToString();
            LabShieldCenterX.Text = ParasCam1.ShieldCenterX.ToString();
            LabShieldCenterY.Text = ParasCam1.ShieldCenterY.ToString();
            LabShieldPixelDia.Text = ParasCam1.ShieldRealPixD.ToString();
            LabDiaCoef.Text = Math.Round(ParasCam1.ShieldDiafac, 3).ToString("f3");
            LabShieldTargetDia.Text = Math.Round(ParasCam1.ShieldTargetDia, 2).ToString("f2");
            LabShieldCorrectCoef.Text = Math.Round(ParasCam1.ShieldCorrectCoef, 3).ToString("f3");
            LabDownAlarmValue.Text = ParasCam1.ShieldDownAlarm.ToString();
            LabUpAlarmValue.Text = ParasCam1.ShieldUpAlarm.ToString();
            if (StartFlag)
            {
                BtnCalib.BackColor = Color.Lime;
                double AveragePixel = PixelDiaAverage(IgAlgo1.ShieldR * 2);
                LabShieldPixelDia.Text = Math.Round(AveragePixel, 2).ToString("f2");
                LabShieldCenterX.Text = ((int)IgAlgo1.ShieldX).ToString();
                LabShieldCenterY.Text = ((int)IgAlgo1.ShieldY).ToString();
                ParasCam1.ShieldRealPixD = Convert.ToSingle(LabShieldPixelDia.Text);
                if (Convert.ToDouble(LabShieldPixelDia.Text) != 0)
                {
                    ParasCam1.ShieldDiafac = Convert.ToSingle(LabShieldPixelDia.Text) / Convert.ToSingle(LabShieldRealDia.Text);
                }
                if (Convert.ToDouble(LabShieldRealDia.Text) != 0)
                {
                    ParasCam1.ShieldCorrectCoef = (float)Math.Round(ParasCam1.ShieldTargetDia / Convert.ToDouble(LabShieldPixelDia.Text), 5);
                }
                LabShieldCenterX.Text = ParasCam1.ShieldCenterX.ToString();
                LabShieldCenterY.Text = ParasCam1.ShieldCenterY.ToString();
            }
        }
        public double PixelDiaAverage(double PixelDia)
        {
            if (AverageFilter.Count <= 20)
            {
                AverageFilter.Enqueue(PixelDia);
            }
            else
            {
                AverageFilter.Dequeue();
                AverageFilter.Enqueue(PixelDia);
            }
            double Average = 0.0;
            foreach (double ss in AverageFilter)
            {
                Average += ss;
            }
            return Average /= AverageFilter.Count; ;
        }
        private void LabLeftX_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm
            {
                Location = new Point(400, 130)
            };
            kf.ImportData(ref LabLeftX, 0, ParasCam1.Width - Convert.ToInt32(LabLeftW.Text) - 10);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                ParasCam1.Shieldlx = Convert.ToInt32(LabLeftX.Text);
            }
        }
        private void LabLeftY_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm
            {
                Location = new Point(400, 130)
            };
            kf.ImportData(ref LabLeftY, 0, ParasCam1.Height - Convert.ToInt32(LabLeftH.Text) - 10);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                ParasCam1.Shieldly = Convert.ToInt32(LabLeftY.Text);
            }
        }
        private void LabLeftW_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm
            {
                Location = new Point(400, 130)
            };
            kf.ImportData(ref LabLeftW, 0, ParasCam1.Width - 10);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                ParasCam1.Shieldlw = Convert.ToInt32(LabLeftW.Text);
            }
        }
        private void LabLeftH_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm
            {
                Location = new Point(400, 130)
            };
            kf.ImportData(ref LabLeftH, 0, ParasCam1.Height - 10);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                ParasCam1.Shieldlh = Convert.ToInt32(LabLeftH.Text);
            }
        }
        private void LabRightX_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm
            {
                Location = new Point(400, 130)
            };
            kf.ImportData(ref LabRightX, 0, ParasCam1.Width - Convert.ToInt32(LabRightW.Text) - 10);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                ParasCam1.Shieldrx = Convert.ToInt32(LabRightX.Text);
            }
        }
        private void LabRightY_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm
            {
                Location = new Point(400, 130)
            };
            kf.ImportData(ref LabRightY, 0, ParasCam1.Height - Convert.ToInt32(LabRightH.Text) - 10);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                ParasCam1.Shieldry = Convert.ToInt32(LabRightY.Text);
            }
        }
        private void LabRightW_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm
            {
                Location = new Point(400, 130)
            };
            kf.ImportData(ref LabRightW, 0, ParasCam1.Width - 10);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                ParasCam1.Shieldrw = Convert.ToInt32(LabRightW.Text);
            }
        }
        private void LabRightH_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm
            {
                Location = new Point(400, 130)
            };
            kf.ImportData(ref LabRightH, 0, ParasCam1.Height - 10);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                ParasCam1.Shieldrh = Convert.ToInt32(LabRightH.Text);
            }
        }
        private void LabThreshholdLeft_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm
            {
                Location = new Point(400, 130)
            };
            kf.ImportData(ref LabThreshholdLeft, 0, 255);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                ParasCam1.ShieldThresholdLeft = Convert.ToInt32(LabThreshholdLeft.Text);
            }
        }
        private void LabThreshholdRight_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm
            {
                Location = new Point(400, 130)
            };
            kf.ImportData(ref LabThreshholdRight, 0, 255);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                ParasCam1.ShieldThresholdRight = Convert.ToInt32(LabThreshholdRight.Text);
            }
        }
        private void LabShieldRealDia_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm
            {
                Location = new Point(400, 130)
            };
            kf.ImportData(ref LabShieldRealDia, 10, 500);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                ParasCam1.ShieldRealDia = Convert.ToInt32(LabShieldRealDia.Text);
            }
        }
        private void LabShieldTargetDia_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm
            {
                Location = new Point(400, 130)
            };
            kf.ImportData(ref LabShieldTargetDia, 10, 5000);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                ParasCam1.ShieldTargetDia = Convert.ToSingle(LabShieldTargetDia.Text);
            }
        }
        private void LabShieldTargetDia_TextChanged(object sender, EventArgs e)
        {
            ParasCam1.ShieldTargetDia = Convert.ToSingle(LabShieldTargetDia.Text);
            if (!string.IsNullOrEmpty(LabShieldPixelDia.Text))
            {
                if (Convert.ToDouble(LabShieldPixelDia.Text) != 0)
                {
                    ParasCam1.ShieldCorrectCoef = (float)Math.Round(ParasCam1.ShieldTargetDia / Convert.ToDouble(LabShieldPixelDia.Text), 5);
                }
            }
        }
        private void LabShieldCenterX_Click(object sender, EventArgs e)
        {
            if (LabShieldCenterX.BackColor == Color.White)
            {
                KeyForm kf = new KeyForm
                {
                    Location = new Point(400, 130)
                };
                kf.ImportData(ref LabShieldCenterX, 10, ParasCam1.Width - 10);
                kf.ShowDialog();
                if (kf.DialogResult == DialogResult.OK)
                {
                    ParasCam1.ShieldCenterX = Convert.ToInt32(LabShieldCenterX.Text);
                }
            }
        }
        private void LabShieldCenterX_TextChanged(object sender, EventArgs e)
        {
            ParasCam1.ShieldCenterX = Convert.ToInt32(LabShieldCenterX.Text);
        }
        private void LabShieldCenterY_Click(object sender, EventArgs e)
        {
            if (LabShieldCenterY.BackColor == Color.White)
            {
                KeyForm kf = new KeyForm
                {
                    Location = new Point(400, 130)
                };
                kf.ImportData(ref LabShieldCenterY, 10, ParasCam1.Height - 10);
                kf.ShowDialog();
                if (kf.DialogResult == DialogResult.OK)
                {
                    ParasCam1.ShieldCenterY = Convert.ToInt32(LabShieldCenterY.Text);
                }
            }
        }
        private void LabShieldCenterY_TextChanged(object sender, EventArgs e)
        {
            ParasCam1.ShieldCenterY = Convert.ToInt32(LabShieldCenterY.Text);
        }
        private void LabDownAlarmValue_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm
            {
                Location = new Point(400, 130)
            };
            kf.ImportData(ref LabDownAlarmValue, -50, 0);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                ParasCam1.ShieldDownAlarm = Convert.ToSingle(LabDownAlarmValue.Text);
            }
        }
        private void LabUpAlarmValue_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm
            {
                Location = new Point(400, 130)
            };
            kf.ImportData(ref LabUpAlarmValue, 0, 50);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                ParasCam1.ShieldUpAlarm = Convert.ToSingle(LabUpAlarmValue.Text);
            }
        }
        private void BtnCalib_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnCalib))
            {
                if (BtnCalib.BackColor == Color.RoyalBlue)
                {
                    StartFlag = true;
                    BtnCalib.BackColor = Color.Lime;
                    AverageFilter.Clear();
                    BtnManualCalib.BackColor = Color.RoyalBlue;
                    LabShieldPixelDia.BackColor = Color.Black;
                    LabShieldPixelDia.ForeColor = Color.White;
                    LabShieldCenterX.BackColor = Color.Black;
                    LabShieldCenterX.ForeColor = Color.White;
                    LabShieldCenterY.BackColor = Color.Black;
                    LabShieldCenterY.ForeColor = Color.White;
                }
                else
                {
                    StartFlag = false;
                    BtnCalib.BackColor = Color.RoyalBlue;
                }
            }
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnSave))
            {
                BtnCalib.BackColor = Color.RoyalBlue;
                BtnManualCalib.BackColor = Color.RoyalBlue;
                StartFlag = false;
                ParasCam1.WriteIn();
                IgAlgo1.MeltGapReset();
                Record.WriteIn("修正系数", LabShieldCorrectCoef.Text, "Yellsow");
                Record.WriteIn("比例系数", LabDiaCoef.Text, "Yellow");
                Record.WriteIn("导流筒检测区域参数更改", "", "Yellow");
            }
        }
        private void BtnManualCalib_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnManualCalib))
            {
                if (BtnManualCalib.BackColor == Color.RoyalBlue)
                {
                    StartFlag = false;
                    BtnCalib.BackColor = Color.RoyalBlue;
                    BtnManualCalib.BackColor = Color.RoyalBlue;
                    BtnManualCalib.BackColor = Color.Lime;
                    LabShieldPixelDia.BackColor = Color.White;
                    LabShieldPixelDia.ForeColor = Color.Black;
                    LabShieldCenterX.BackColor = Color.White;
                    LabShieldCenterX.ForeColor = Color.Black;
                    LabShieldCenterY.BackColor = Color.White;
                    LabShieldCenterY.ForeColor = Color.Black;
                }
                else
                {
                    BtnManualCalib.BackColor = Color.RoyalBlue;
                    LabShieldPixelDia.BackColor = Color.Black;
                    LabShieldPixelDia.ForeColor = Color.White;
                    LabShieldCenterX.BackColor = Color.Black;
                    LabShieldCenterX.ForeColor = Color.White;
                    LabShieldCenterY.BackColor = Color.Black;
                    LabShieldCenterY.ForeColor = Color.White;
                }
            }
        }
        private void BtnQuit_Click(object sender, EventArgs e)
        {
            StartFlag = false;
            BtnCalib.BackColor = Color.RoyalBlue;
            BtnManualCalib.BackColor = Color.RoyalBlue;
            Close();
        }
        private void LabShieldPixelDia_Click(object sender, EventArgs e)
        {
            if (LabShieldPixelDia.BackColor == Color.White)
            {
                KeyForm kf = new KeyForm
                {
                    Location = new Point(400, 130)
                };
                kf.ImportData(ref LabShieldPixelDia, 10, 50000);
                kf.ShowDialog();
                if (kf.DialogResult == DialogResult.OK)
                {
                    if (Convert.ToDouble(LabShieldPixelDia.Text) != 0)
                    {
                        ParasCam1.ShieldDiafac = Convert.ToSingle(LabShieldPixelDia.Text) / Convert.ToSingle(LabShieldRealDia.Text);
                    }
                    if (Convert.ToDouble(LabShieldRealDia.Text) != 0)
                    {
                        ParasCam1.ShieldCorrectCoef = (float)Math.Round(ParasCam1.ShieldTargetDia / Convert.ToDouble(LabShieldPixelDia.Text), 5);
                    }
                    ParasCam1.ShieldRealPixD = Convert.ToSingle(LabShieldPixelDia.Text);
                }
            }
        }
        private void FrmShieldMeasure_Load(object sender, EventArgs e)
        {
            ParasCam1.ReadOut();
        }
        private void FrmShieldMeasure_FormClosed(object sender, FormClosedEventArgs e)
        {
            ParasCam1.ReadOut();
        }
    }
}
