﻿using CrystalGrowth.AuxFunction.CCD;
using CrystalGrowth.CrystalCtl;
using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction.Calibration
{
    internal partial class FrmMeltGapClib : Form
    {
        /// <summary>
        /// 读取PLC校准偏移量倒计时  4秒后更新
        /// </summary>
        int UpdateMeltGapOffTime = 0;
        public FrmMeltGapClib()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void FrmMeltGapClib_Load(object sender, EventArgs e)
        {
            LabDateTime.Text = Calibrate.ReadTime(23);
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (PLC.Count == 2)
            {
                LabMeltGapCalibSP.Text = Math.Round(PLC.ReadOthersValue[22], 1).ToString("f1");
                LabPixelMeltGap.Text = Math.Round(PLC.ReadOthersValue[2], 1).ToString("f1");
                LabRealMeltGap.Text = Math.Round(PLC.ReadCalcValue[24], 1).ToString("f1");
                LabGain.Text = Math.Round(PLC.ReadCalibValue[36], 2).ToString("f2");
                LabRatio.Text = Math.Round(PLC.ReadOthersValue[19], 2).ToString("f2");
                LabMeltGapOffset.Text = Math.Round(PLC.ReadCalibValue[74], 2).ToString("f2");
                //LabTopRatio.Text = Math.Round(PLC.ReadCalibValue[75],2).ToString("f2");
                LabAbsMeltGap.Text = Math.Round(IgAlgo1.MeltGapAbsAvgValue + ParasCam1.MeltGapAbsMeasure_OffSet,2).ToString("f2");
                BtnAutoCalib.Enabled = PLC.ReadStatus[79] != 1;
                LabUpLim.Text = Math.Round(PLC.ReadCalibValue[80], 2).ToString("f2");
                LabDownLim.Text = Math.Round(PLC.ReadCalibValue[81], 2).ToString("f2");
                if (UpdateMeltGapOffTime > 0)
                {
                    UpdateMeltGapOffTime--;
                }
                if (UpdateMeltGapOffTime == 1)
                {
                    Calibrate.WriteValue(23, 3, PLC.ReadCalibValue[74].ToString());
                }
            }
        }
        private void BtnAutoCalib_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnAutoCalib))
            {
                if (FrmMeltGapArea.AgreeMeltGap == 1 && PLC.ReadStatus[1] == 0 && PLC.ReadStatus[9] == 0 && PLC.ReadOthersValue[2] > 0)
                {
                    Calibrate.WriteValue(23, 1, "");
                    LabDateTime.Text = Calibrate.DateTimeStr;
                    BtnAutoCalib.Enabled = false;
                }
                else
                {
                    LabDateTime.ForeColor = Color.Red;
                    LabDateTime.Text = "校准条件不具备";
                }
            }
            LabName.Focus();
        }
        private void LabRatio_Click(object sender, EventArgs e)
        {
            if (PLC.ReadStatus[9] == 0)
            {
                KeyForm kf = new KeyForm();
                kf.ImportData(ref LabRatio, 0.5f, 1f);
                kf.ShowDialog();
                if (kf.DialogResult == DialogResult.OK)
                {
                    PLC.SendFloat(31, 72, Convert.ToSingle(LabRatio.Text));
                    Record.WriteIn("液口距校准系数", LabRatio.Text, "Yellow");
                    DialogResult dr = MessageBox.Show("视觉液口距系数修改完成，是否同步校准重量液口距？", "提示");
                    if (dr == DialogResult.OK) //重量液口距同步校准-20211005
                    {
                        if (FrmMeltGapArea.AgreeMeltGap == 1 && PLC.ReadCalcValue[24] > 10)
                        {
                            Calibrate.WriteValue(30, 1, "");
                            LabDateTime.Text = Calibrate.DateTimeStr;
                            Record.WriteIn("重量液口距同步校准", PLC.ReadCalcValue[24].ToString(), "Yellow");
                        }
                        else
                        {
                            MessageBox.Show("重量液口距校准条件不具备，请手动确认并校准！");
                        }
                    }
                }            
            }
            else
            {
                MessageBox.Show("校准请退出液口距自动！");
            }
        }
        private void LabMeltGapCalibSP_Click(object sender, EventArgs e)
        {
            if (PLC.ReadStatus[9] == 0)
            {
                KeyForm kf = new KeyForm();
                kf.ImportData(ref LabMeltGapCalibSP, 12, 45);
                kf.ShowDialog();
                if (kf.DialogResult == DialogResult.OK)
                {
                    PLC.SendFloat(31, 84, Convert.ToSingle(LabMeltGapCalibSP.Text));
                }
            }
            else
            {
                MessageBox.Show("校准请退出液口距自动！");
            }
        }

        private void BtnMeltGapCalib_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnMeltGapCalib))
            {                 
                DialogResult dr = MessageBox.Show("请确认是否液口距校准？", "提示");
                if (dr == DialogResult.OK)
                {
                    if (PLC.ReadStatus[9] == 0)
                    {
                        // 系数方式校准液距
                        // 使用偏移液距校准方式
                         PLC.SendBit(30, 123, 1);
                        // 偏移量校准方式  ----屏蔽 
                        //PLC.SendBit(30, 241, 1);
                        Record.WriteIn("液口距校准", LabMeltGapCalibSP.Text.ToString(), "Yellow");
                        UpdateMeltGapOffTime = 8;
                        //重量液口距同步校准-20211005
                        DialogResult dt = MessageBox.Show("视觉液口距校准完成，是否同步校准重量液口距？", "提示");
                        if (dt == DialogResult.OK)
                        {
                            if (FrmMeltGapArea.AgreeMeltGap == 1 && PLC.ReadCalcValue[24] > 10)
                            {
                                Calibrate.WriteValue(30, 1, "");
                                Record.WriteIn("重量液口距同步校准", PLC.ReadCalcValue[24].ToString(), "Yellow");
                            }
                            else
                            {
                                MessageBox.Show("重量液口距校准条件不具备，请手动确认并校准！");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("校准请退出液口距自动！");
                    }
                }
            }
        }

        private void LabUpLim_Click(object sender, EventArgs e)
        {
            if (PLC.ReadStatus[9] == 0)
            {
                KeyForm kf = new KeyForm();
                kf.ImportData(ref LabUpLim, -500, 500);
                kf.Location = new Point(800, 200);
                kf.ShowDialog();
                if (kf.DialogResult == DialogResult.OK)
                {
                    PLC.SendFloat(34, 316, Convert.ToSingle(LabUpLim.Text));
                }
            }
            else
            {
                MessageBox.Show("校准请退出液口距自动！");
            }
        }

        private void LabDownLim_Click(object sender, EventArgs e)
        {
            if (PLC.ReadStatus[9] == 0)
            {
                KeyForm kf = new KeyForm();
                kf.ImportData(ref LabDownLim, -500, 500);
                kf.Location = new Point(800, 200);
                kf.ShowDialog();
                if (kf.DialogResult == DialogResult.OK)
                {
                    PLC.SendFloat(34, 320, Convert.ToSingle(LabDownLim.Text));
                }
            }
            else
            {
                MessageBox.Show("校准请退出液口距自动！");
            }
        }

        private void LabMeltGapOffset_Click(object sender, EventArgs e)
        {
            //if (PLC.ReadStatus[9] == 0)
            //{
            //    double TempMeltGapVal = Double.Parse(LabMeltGapOffset.Text);
            //    KeyForm kf = new KeyForm();
            //    kf.ImportData(ref LabMeltGapOffset, -20f, 20f);
            //    kf.ShowDialog();
            //    if (kf.DialogResult == DialogResult.OK)
            //    {
            //        PLC.SendFloat(34, 292, Convert.ToSingle(LabMeltGapOffset.Text));
            //        Record.WriteIn("液口距偏移量修改", TempMeltGapVal.ToString("f1") + "->" + LabMeltGapOffset.Text, "Yellow");

            //         DialogResult dr = MessageBox.Show("视觉液口距系数修改完成，是否同步校准重量液口距？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //        if (dr == DialogResult.Yes) //重量液口距同步校准-20211005
            //        {
            //            if (FrmMeltGapArea.AgreeMeltGap == 1 && PLC.ReadCalcValue[24] > 10)
            //            {
            //                Calibrate.WriteValue(30, 1, "");
            //                LabDateTime.Text = Calibrate.DateTimeStr;
            //                Record.WriteIn("重量液口距同步校准", PLC.ReadCalcValue[24].ToString(), "Yellow");
            //            }
            //            else
            //            {
            //                MessageBox.Show("重量液口距校准条件不具备，请手动确认并校准！");
            //            }
            //        }
            //    }
               
            //}
            //else
            //{
            //    MessageBox.Show("校准请退出液口距自动！");
            //}
        }

        private void LabGain_Click(object sender, EventArgs e)
        {
            if (PLC.ReadStatus[9] == 0)
            {
                KeyForm kf = new KeyForm();
                kf.ImportData(ref LabGain, 0.1f, 1f);
                kf.ShowDialog();
                if (kf.DialogResult == DialogResult.OK)
                {
                    Record.WriteIn("液口距增益", LabGain.Text, "Yellow");
                    Calibrate.WriteValue(23, 2, LabGain.Text);
                    DialogResult dr = MessageBox.Show("视觉液口距增益修改完成，是否同步校准重量液口距？", "提示");
                    if (dr == DialogResult.OK) //重量液口距同步校准-20211005
                    {
                        if (FrmMeltGapArea.AgreeMeltGap == 1 && PLC.ReadCalcValue[24] > 10)
                        {
                            Calibrate.WriteValue(30, 1, "");
                            LabDateTime.Text = Calibrate.DateTimeStr;
                            Record.WriteIn("重量液口距同步校准", PLC.ReadCalcValue[24].ToString(), "Yellow");
                        }
                        else
                        {
                            MessageBox.Show("重量液口距校准条件不具备，请手动确认并校准！");
                        }
                    }
                }       
            }
            else
            {
                MessageBox.Show("校准请退出液口距自动！");
            }
        }
    }
}
