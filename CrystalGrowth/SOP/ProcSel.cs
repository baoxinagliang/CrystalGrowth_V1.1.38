﻿using CrystalGrowth.CrystalCtl;
using CrystalGrowth.Unities;
using SOP;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CrystalGrowth.SOP
{
    internal partial class ProcSel : Form
    {
        Form LastForm;
        bool ShowRunningSopFlag = false;
        LineFile LastFileValue = new LineFile();
        public static int AgreeEdit = 0;
        public FrmSaveFile saveForm;
        public FrmSelFile selForm;
        public ProcStab1 frmStab1;
        public ProcStab2 frmStab2;
        public ProcStab3 frmStab3;
        public ProcStab4 frmStab4;
        public ProcStab5 frmStab5;
        public ProcStab6 frmStab6;
        public ProcStab7 frmStab7;
        public ProcStab8 frmStab8;
        public ProcStab9 frmStab9;
        public ProcStab10 frmStab10;
        public ProcStab11 frmStab11;
        public ProcStab12 frmStab12;
        public ProcStab13 frmStab13;
        public ProcStab14 frmStab14;
        public ProcStab15 frmStab15;
        public ProcStab16 frmStab16;
        public ProcStab17 frmStab17;
        public ProcStab18 frmStab18;
        public ProcStab19 frmStab19;
        public ProcStab20 frmStab20;
        public ProcStab21 frmStab21;
        public ProcStab22 frmStab22;
        public ProcStab23 frmStab23;
        public ProcStab24 frmStab24;
        private ProcSel()
        {
            InitializeComponent();
            DataGridView1.Rows.Add(24);
            DataGridView1.Rows[0].Cells[0].Value = "初始设置";
            DataGridView1.Rows[1].Cells[0].Value = "抽空/检漏";
            DataGridView1.Rows[2].Cells[0].Value = "压力化/熔料";
            DataGridView1.Rows[3].Cells[0].Value = "预热/熔接";
            DataGridView1.Rows[4].Cells[0].Value = "调温";
            DataGridView1.Rows[5].Cells[0].Value = "引晶";
            DataGridView1.Rows[6].Cells[0].Value = "放肩";
            DataGridView1.Rows[7].Cells[0].Value = "转肩";
            DataGridView1.Rows[8].Cells[0].Value = "等径";
            DataGridView1.Rows[9].Cells[0].Value = "收尾";
            DataGridView1.Rows[10].Cells[0].Value = "停炉";
            DataGridView1.Rows[11].Cells[0].Value = "副室净化";
            DataGridView1.Rows[12].Cells[0].Value = "煅烧";
            DataGridView1.Rows[13].Cells[0].Value = "取段冷却";
            DataGridView1.Rows[14].Cells[0].Value = "渣盖提出";
            DataGridView1.Rows[15].Cells[0].Value = "料筒提入/提出";
            DataGridView1.Rows[16].Cells[0].Value = "热场控制器";
            DataGridView1.Rows[17].Cells[0].Value = "籽晶提入/提出";
            DataGridView1.Rows[18].Cells[0].Value = "炉盖旋开/旋回";
            DataGridView1.Rows[19].Cells[0].Value = "炉筒旋开/旋回";
            DataGridView1.Rows[20].Cells[0].Value = "自动装料";
            DataGridView1.Rows[21].Cells[0].Value = "回熔";
            DataGridView1.Rows[22].Cells[0].Value = "一键放埚";
            DataGridView1.Rows[23].Cells[0].Value = "硅料预热";
            DataGridView1.Rows[16].Visible = PLC.ReadStatus[57] != 1;
            DataGridView1[0, 0].Style.SelectionBackColor = Color.Blue;
            DataGridView1[0, 0].Style.SelectionForeColor = Color.White;
            frmStab1 = new ProcStab1();
            frmStab2 = new ProcStab2();
            frmStab3 = new ProcStab3();
            frmStab4 = new ProcStab4();
            frmStab5 = new ProcStab5();
            frmStab6 = new ProcStab6();
            frmStab7 = new ProcStab7();
            frmStab8 = new ProcStab8();
            frmStab9 = new ProcStab9();
            frmStab10 = new ProcStab10();
            frmStab11 = new ProcStab11();
            frmStab12 = new ProcStab12();
            frmStab13 = new ProcStab13();
            frmStab14 = new ProcStab14();
            frmStab15 = new ProcStab15();
            frmStab16 = new ProcStab16();
            frmStab17 = new ProcStab17();
            frmStab18 = new ProcStab18();
            frmStab19 = new ProcStab19();
            frmStab20 = new ProcStab20();
            frmStab21 = new ProcStab21();
            frmStab22 = new ProcStab22();
            frmStab23 = new ProcStab23();
            frmStab24 = new ProcStab24();
        }
        public static ProcSel Single;
        public static ProcSel CreateInstrance()
        {
            if (Single == null)
            {
                Single = new ProcSel();
                Single.FormClosed += Single_FormClosed;
            }
            return Single;
        }
        static void Single_FormClosed(object sender, FormClosedEventArgs e)
        {
            Single = null;
        }
        private void ProcSel_Load(object sender, EventArgs e)
        {
            FrmSwitch.Open(frmStab1, 71);
            LastForm = frmStab1;
            BtnSaveSop.Enabled = false;
            BtnDownLoad.Enabled = true;
            BeginInvoke(new Action(() =>
            {
                using (StreamReader SReader = new StreamReader(FileHelper.ConfigPath, Encoding.UTF8))
                {
                    string LineStr = SReader.ReadLine();
                    if (LineStr == null)
                    {
                        using (FileStream fStream = new FileStream(FileHelper.ConfigPath, FileMode.Create, FileAccess.Write))
                        {
                            using (StreamWriter SWriter = new StreamWriter(fStream, Encoding.UTF8))
                            {
                                LineStr = "lintonkayex.sop";
                                SWriter.WriteLine(LineStr);
                                LabFileName.Text = LineStr;
                                LineStr = string.Concat("已下载:", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                                SWriter.WriteLine(LineStr);
                                LabFileStat.Text = LineStr;
                                SWriter.Flush();
                            }
                        }
                        Sop.FileToPlc(string.Concat(Application.StartupPath, "\\SOP\\lintonkayex.sop"));
                    }
                    else
                    {
                        LabFileName.Text = LineStr;
                        LabFileStat.Text = SReader.ReadLine();
                    }
                }
                Sop.FileToForm(string.Concat(Application.StartupPath, "\\SOP\\", LabFileName.Text));
            }));
        }
        private void ProcSel_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["FrmLevel"] != null) { Application.OpenForms["FrmLevel"].Close(); }
            frmStab1.Close();
            frmStab2.Close();
            frmStab3.Close();
            frmStab4.Close();
            frmStab5.Close();
            frmStab6.Close();
            frmStab7.Close();
            frmStab8.Close();
            frmStab9.Close();
            frmStab10.Close();
            frmStab11.Close();
            frmStab12.Close();
            frmStab13.Close();
            frmStab14.Close();
            frmStab15.Close();
            frmStab16.Close();
            frmStab17.Close();
            frmStab18.Close();
            frmStab19.Close();
            frmStab20.Close();
            frmStab21.Close();
            frmStab22.Close();
            frmStab23.Close();
            frmStab24.Close();
            if (selForm != null) { selForm.Close(); }
            if (saveForm != null) { saveForm.Close(); }
            Level.Operator = false;
            Level.PermitModify = false;
            AgreeEdit = 0;
        }
        /// <summary>
        /// 打开各个页面表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LastForm.Hide();
            DataGridView1[0, e.RowIndex].Style.SelectionBackColor = Color.Blue;
            DataGridView1[0, e.RowIndex].Style.SelectionForeColor = Color.White;
            switch (e.RowIndex)
            {
                case 0:     //初始设置
                    FrmSwitch.Open(frmStab1, 71);
                    LastForm = frmStab1;
                    break;
                case 1:     //抽空/检漏
                    FrmSwitch.Open(frmStab2, 72);
                    LastForm = frmStab2;
                    break;
                case 2:     //压力化/熔料
                    FrmSwitch.Open(frmStab3, 73);
                    LastForm = frmStab3;
                    break;
                case 3:     //预热/熔接
                    FrmSwitch.Open(frmStab4, 74);
                    LastForm = frmStab4;
                    break;
                case 4:     //调温
                    FrmSwitch.Open(frmStab5, 74);
                    LastForm = frmStab5;
                    break;
                case 5:     //引晶
                    FrmSwitch.Open(frmStab6, 75);
                    LastForm = frmStab6;
                    break;
                case 6:     //放肩
                    frmStab7.TabpagesChanged();
                    FrmSwitch.Open(frmStab7, 76);
                    LastForm = frmStab7;
                    break;
                case 7:     //转肩
                    FrmSwitch.Open(frmStab8, 77);
                    LastForm = frmStab8;
                    break;
                case 8:     //等径
                    FrmSwitch.Open(frmStab9, 78);
                    LastForm = frmStab9;
                    break;
                case 9:     //收尾
                    FrmSwitch.Open(frmStab10, 79);
                    LastForm = frmStab10;
                    break;
                case 10:    //停炉
                    FrmSwitch.Open(frmStab11, 80);
                    LastForm = frmStab11;
                    break;
                case 11:    //副室净化
                    FrmSwitch.Open(frmStab12, 81);
                    LastForm = frmStab12;
                    break;
                case 12:    //煅烧
                    FrmSwitch.Open(frmStab13, 82);
                    LastForm = frmStab13;
                    break;
                case 13:    //冷却提出
                    FrmSwitch.Open(frmStab15, 83);
                    LastForm = frmStab15;
                    break;
                case 14:    //渣盖提出
                    FrmSwitch.Open(frmStab16, 84);
                    LastForm = frmStab16;
                    break;
                case 15:    //料筒提入/提出
                    FrmSwitch.Open(frmStab17, 85);
                    LastForm = frmStab17;
                    break;
                case 16:    //热场控制器
                    FrmSwitch.Open(frmStab14, 86);
                    LastForm = frmStab14;
                    break;
                case 17:    //籽晶提入
                    FrmSwitch.Open(frmStab18, 87);
                    LastForm = frmStab18;
                    break;
                case 18:    //炉盖旋出旋回
                    FrmSwitch.Open(frmStab19, 88);
                    LastForm = frmStab19;
                    break;
                case 19:    //炉筒旋开旋回
                    FrmSwitch.Open(frmStab20, 89);
                    LastForm = frmStab20;
                    break;
                case 20:    //自动装料
                    FrmSwitch.Open(frmStab21, 90);
                    LastForm = frmStab21;
                    break;
                case 21:    //回熔
                    FrmSwitch.Open(frmStab22, 91);
                    LastForm = frmStab22;
                    break;
                case 22:    //回熔
                    FrmSwitch.Open(frmStab23, 91);
                    LastForm = frmStab23;
                    break;
                case 23: //硅料预热
                    FrmSwitch.Open(frmStab24, 92);
                    LastForm = frmStab24;
                    break;
            }
        }
        private void BtnOpenFile_Click(object sender, EventArgs e)
        {
            selForm = new FrmSelFile();
            FrmSwitch.Open(selForm, 90, new Point(0, 130), new Size(1366, 638));
            selForm.Show();
        }
        private void BtnEditFile_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnEditFile))
            {
                if (Level.Operator)
                {
                    if (ShowRunningSopFlag == false)
                    {
                        if (BtnEditFile.BackColor == Color.RoyalBlue)
                        {
                            AgreeEdit = 1;
                            BtnEditFile.BackColor = Color.Red;
                            BtnSaveSop.Enabled = true;
                            LabRunAndShowStatus.Text = "允许编辑";
                            EditDataViewColor(false);        
                        }
                        else if (BtnEditFile.BackColor == Color.Red)
                        {
                            AgreeEdit = 0;
                            BtnEditFile.BackColor = Color.RoyalBlue;
                            BtnSaveSop.Enabled = false;
                            BtnDownLoad.Enabled = true;
                            LabRunAndShowStatus.Text = "取消编辑";
                            EditDataViewColor(true);
                            //加载当前SOP
                            Sop.FileToForm(string.Concat(Application.StartupPath, "\\SOP\\", LabFileName.Text));
                        }
                        BtnCurSop.Enabled = false;
                    }
                    else
                    {
                        if (BtnEditFile.BackColor == Color.RoyalBlue)
                        {
                            AgreeEdit = 1;
                            BtnEditFile.BackColor = Color.Red;
                            EditDataViewColor(false);
                            BtnCurSop.Enabled = false;
                        }
                        else if (BtnEditFile.BackColor == Color.Red)
                        {
                            AgreeEdit = 0;
                            BtnEditFile.BackColor = Color.RoyalBlue;
                            EditDataViewColor(true);
                            BtnCurSop.Enabled = true;
                        }
                    }
                }
                else
                {
                    BeginInvoke(new Action(() =>
                    {
                        FrmLevel frmLevel = new FrmLevel("Operator", "Technology");
                        frmLevel.ShowDialog();
                        if (frmLevel.DialogResult == DialogResult.OK)
                        {
                            Level.Operator = true;
                        }
                    }));
                }
            }
        }
        private void EditColor(DataGridViewCellStyle Dgvcs, bool flag)
        {
            if (flag)
            {
                Dgvcs.BackColor = Color.Black;
                Dgvcs.ForeColor = Color.White;
                Dgvcs.SelectionBackColor = Color.Black;
                Dgvcs.SelectionForeColor = Color.White;
            }
            else
            {
                Dgvcs.BackColor = Color.White;
                Dgvcs.ForeColor = Color.Black;
                Dgvcs.SelectionBackColor = Color.White;
                Dgvcs.SelectionForeColor = Color.Black;
            }
        }
        private void EditDataViewColor(bool flag)
        {
            EditColor(frmStab1.DataGridView1.Columns[0].DefaultCellStyle, flag);
            EditColor(frmStab1.DataGridView2.Columns[0].DefaultCellStyle, flag);
            EditColor(frmStab1.DataGridView3.Columns[0].DefaultCellStyle, flag);
            for (int i = 0; i < 2; i++)
            {
                EditColor(frmStab1.DataGridView4.Columns[i].DefaultCellStyle, flag);
            }
            EditColor(frmStab1.DataGridView5.Columns[0].DefaultCellStyle, flag);
            EditColor(frmStab2.DataGridView1.Columns[0].DefaultCellStyle, flag);
            EditColor(frmStab3.DataGridView1.Columns[0].DefaultCellStyle, flag);
            EditColor(frmStab3.DataGridView2.Columns[0].DefaultCellStyle, flag);
            for (int i = 0; i < 8; i++)
            {
                EditColor(frmStab3.DataGridView3.Columns[i].DefaultCellStyle, flag);
            }
            EditColor(frmStab4.DataGridView1.Columns[0].DefaultCellStyle, flag);
            EditColor(frmStab4.DataGridView2.Columns[0].DefaultCellStyle, flag);
            EditColor(frmStab4.DataGridView3.Columns[0].DefaultCellStyle, flag);
            EditColor(frmStab5.DataGridView1.Columns[0].DefaultCellStyle, flag);
            EditColor(frmStab5.DataGridView2.Columns[0].DefaultCellStyle, flag);
            for (int i = 0; i <= 1; i++)
            {
                EditColor(frmStab5.DataGridView3.Columns[i].DefaultCellStyle, flag);
            }
            EditColor(frmStab6.DataGridView1.Columns[0].DefaultCellStyle, flag);
            EditColor(frmStab6.DataGridView2.Columns[0].DefaultCellStyle, flag);
            EditColor(frmStab6.DataGridView3.Columns[0].DefaultCellStyle, flag);
            for (int i = 0; i < 9; i++)
            {
                EditColor(frmStab6.DataGridView4.Columns[i].DefaultCellStyle, flag);
            }
            EditColor(frmStab7.DataGridView1.Columns[0].DefaultCellStyle, flag);
            for (int i = 0; i <= 7; i++)
            {
                EditColor(frmStab7.DataGridView2.Columns[i].DefaultCellStyle, flag);
            }
            EditColor(frmStab7.DataGridView3.Columns[0].DefaultCellStyle, flag);
            for (int i = 0; i <= 9; i++)
            {
                EditColor(frmStab7.DataGridView4.Columns[i].DefaultCellStyle, flag);
            }
            EditColor(frmStab7.DataGridView5.Columns[0].DefaultCellStyle, flag);
            for (int i = 0; i <= 1; i++)
            {
                EditColor(frmStab7.DataGridView6.Columns[i].DefaultCellStyle, flag);
            }
            EditColor(frmStab7.DataGridView7.Columns[0].DefaultCellStyle, flag);
            for (int i = 0; i <= 9; i++)
            {
                EditColor(frmStab7.DataGridView8.Columns[i].DefaultCellStyle, flag);
            }
            EditColor(frmStab8.DataGridView1.Columns[0].DefaultCellStyle, flag);
            for (int i = 0; i <= 1; i++)
            {
                EditColor(frmStab8.DataGridView3.Columns[i].DefaultCellStyle, flag);
            }
            EditColor(frmStab8.DataGridView4.Columns[0].DefaultCellStyle, flag);
            EditColor(frmStab8.DataGridView5.Columns[0].DefaultCellStyle, flag);
            for (int i = 0; i <= 5; i++)
            {
                EditColor(frmStab8.DataGridView6.Columns[i].DefaultCellStyle, flag);
            }
            for (int i = 0; i <= 1; i++)
            {
                EditColor(frmStab8.DataGridView7.Columns[i].DefaultCellStyle, flag);
            }
            EditColor(frmStab8.DataGridView2.Columns[0].DefaultCellStyle, flag);
            EditColor(frmStab9.DataGridView1.Columns[0].DefaultCellStyle, flag);
            for (int i = 0; i <= 10; i++)
            {
                EditColor(frmStab9.DataGridView2.Columns[i].DefaultCellStyle, flag);
            }
            for (int i = 0; i <= 10; i++)
            {
                EditColor(frmStab9.DataGridView3.Columns[i].DefaultCellStyle, flag);
            }
            if (Level.PermitModify)
            {
                EditColor(frmStab9.DataGridView4.Columns[0].DefaultCellStyle, flag);
            }
            for (int i = 0; i <= 1; i++)
            {
                EditColor(frmStab9.DataGridView5.Columns[i].DefaultCellStyle, flag);
            }
            EditColor(frmStab10.DataGridView1.Columns[0].DefaultCellStyle, flag);
            for (int i = 0; i <= 8; i++)
            {
                EditColor(frmStab10.DataGridView2.Columns[i].DefaultCellStyle, flag);
            }
            EditColor(frmStab10.DataGridView3.Columns[0].DefaultCellStyle, flag);
            for (int i = 0; i <= 2; i++)
            {
                EditColor(frmStab10.DataGridView4.Columns[i].DefaultCellStyle, flag);
            }
            EditColor(frmStab10.DataGridView5.Columns[0].DefaultCellStyle, flag);
            for (int i = 0; i <= 8; i++)
            {
                EditColor(frmStab10.DataGridView6.Columns[i].DefaultCellStyle, flag);
            }
            EditColor(frmStab11.DataGridView1.Columns[0].DefaultCellStyle, flag);
            EditColor(frmStab12.DataGridView1.Columns[0].DefaultCellStyle, flag);
            for (int i = 0; i <= 5; i++)
            {
                EditColor(frmStab13.DataGridView1.Columns[i].DefaultCellStyle, flag);
            }
            EditColor(frmStab14.DataGridView1.Columns[0].DefaultCellStyle, flag);
            EditColor(frmStab15.DataGridView1.Columns[0].DefaultCellStyle, flag);
            for (int i = 0; i <= 8; i++)
            {
                EditColor(frmStab15.DataGridView2.Columns[i].DefaultCellStyle, flag);
            }
            for (int i = 0; i < 3; i++)
            {
                EditColor(frmStab15.DataGridView3.Columns[i].DefaultCellStyle, flag);
            }
            EditColor(frmStab16.DataGridView1.Columns[0].DefaultCellStyle, flag);
            for (int i = 0; i <= 3; i++)
            {
                EditColor(frmStab16.DataGridView2.Columns[i].DefaultCellStyle, flag);
            }
            EditColor(frmStab17.DataGridView1.Columns[0].DefaultCellStyle, flag);
            EditColor(frmStab18.DataGridView1.Columns[0].DefaultCellStyle, flag);
            EditColor(frmStab19.DataGridView1.Columns[0].DefaultCellStyle, flag);
            EditColor(frmStab20.DataGridView1.Columns[0].DefaultCellStyle, flag);
            EditColor(frmStab21.DataGridView1.Columns[0].DefaultCellStyle, flag);
            EditColor(frmStab22.DataGridView1.Columns[0].DefaultCellStyle, flag);
            EditColor(frmStab22.DataGridView2.Columns[0].DefaultCellStyle, flag);
            EditColor(frmStab23.DataGridView1.Columns[0].DefaultCellStyle, flag);
            for (int i = 0; i <= 3; i++)
            {
                EditColor(frmStab24.DataGridView1.Columns[i].DefaultCellStyle, flag);
            }
        }
        private void BtnSaveFile_Click(object sender, EventArgs e)
        {
            saveForm = new FrmSaveFile();
            FrmSwitch.Open(saveForm, 90, new Point(0, 130), new Size(1366, 638));
            saveForm.Show();
        }
        private void BtnSaveSop_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnSaveSop))
            {
                string sopPath = string.Concat(Application.StartupPath, "\\SOP\\", LabFileName.Text);
                string[] strFile = Sop.FileJudge(sopPath);
                File.WriteAllLines(sopPath, strFile);
                BtnEditFile.BackColor = Color.RoyalBlue;
                AgreeEdit = 0;
                BtnSaveSop.Enabled = false;
                BtnDownLoad.Enabled = true;
                EditDataViewColor(true);
                Sop.FileToForm(sopPath);
                LabFileStat.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                LabRunAndShowStatus.Text = "数据修改保存到文件，未下载";
                Record.WriteIn(LabFileName.Text, "修改保存到文件，未下载", "Yellow");
            }
        }
        private void BtnDownLoad_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnDownLoad))
            {
                if (ShowRunningSopFlag == false)
                {
                    string[] str = Sop.FormToArray();
                    if (BtnEditFile.BackColor == Color.Red)
                    {
                        Sop.SDataToPLC(Sop.StrToFloat(Sop.ArrayToSData(str)));
                        Record.WriteIn(LabFileName.Text, "未保存到文件，下载完成", "Yellow");
                        LabRunAndShowStatus.Text = "数据未保存到文件，下载完成";
                    }
                    else
                    {
                        LineFile FileValue = new LineFile
                        {
                            Name = LabFileName.Text,
                            Stat = LabFileStat.Text
                        };
                        Sop.ParasToFile(ref FileValue);
                        Sop.SData = Sop.StrToFloat(Sop.ArrayToSData(str));
                        Sop.SDataToPLC(Sop.SData);
                        Record.WriteIn(LabFileName.Text, "已保存，下载完成", "Yellow");
                        LabRunAndShowStatus.Text = "已保存，下载完成";
                    }
                    LabRunAndShowStatus.ForeColor = Color.LimeGreen;
                    AgreeEdit = 0;
                }
                else
                {
                    string[] str = Sop.FormToArray();
                    var STData = Sop.StrToFloat(Sop.ArrayToSData(str));
                    Sop.SDataToPLC(STData);
                    Sop.SDataB = Sop.RPlcToData();
                    LabFileStat.Text = string.Concat("已下载", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    LabRunAndShowStatus.Text = "修改运行SOP参数";
                    Record.WriteIn("修改运行SOP参数", "", "Yellow");
                }
                BtnCurSop.Enabled = true;
                EditDataViewColor(true);
                BtnEditFile.BackColor = Color.RoyalBlue;
            }
        }

        private void BtnCurSop_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnCurSop))
            {
                if (BtnCurSop.BackColor == Color.RoyalBlue)
                {
                    BtnCurSop.BackColor = Color.Lime;
                    Sop.SDataB = Sop.RPlcToData();
                    Sop.FormDisPlay(Sop.FloatToStr(Sop.SDataB));
                    BtnEditFile.Enabled = true;
                    BtnSaveSop.Enabled = false;
                    BtnDownLoad.Enabled = true;
                    BtnOpenFile.Enabled = false;
                    BtnSaveFile.Enabled = true;
                    LastFileValue.Name = LabFileName.Text;
                    LastFileValue.Stat = LabFileStat.Text;
                    LabRunAndShowStatus.Text = "PLC使用参数";
                    LabRunAndShowStatus.ForeColor = Color.LimeGreen;
                    ShowRunningSopFlag = true;
                }
                else
                {
                    BtnCurSop.BackColor = Color.RoyalBlue;
                    BtnEditFile.Enabled = true;
                    BtnSaveSop.Enabled = false;
                    BtnDownLoad.Enabled = true;
                    BtnOpenFile.Enabled = true;
                    BtnSaveFile.Enabled = true;
                    LabFileName.Text = LastFileValue.Name;
                    LabFileStat.Text = LastFileValue.Stat;
                    Sop.FileToForm(string.Concat(Application.StartupPath, "\\SOP\\", LabFileName.Text));
                    CheckSameSop();
                    ShowRunningSopFlag = false;
                    Sop.SDataB = null;
                }
            }
        }
        private bool NotSame(ref string tepStr)
        {
            Dictionary<string, bool> dict = new Dictionary<string, bool>();
            if (Sop.SDataB != null && PLC.IsConn)
            {
                dict.Add("初始化", Sop.SDataB.Initial.SequenceEqual(Sop.SData.Initial));
                dict.Add("抽空/检漏", Sop.SDataB.PumpLeak.SequenceEqual(Sop.SData.PumpLeak));
                dict.Add("压力化/熔料", Sop.SDataB.PressMelt.SequenceEqual(Sop.SData.PressMelt));
                dict.Add("调温", Sop.SDataB.Dip.SequenceEqual(Sop.SData.Dip));
                dict.Add("预热/熔接", Sop.SDataB.Stabilize.SequenceEqual(Sop.SData.Stabilize));
                dict.Add("引晶", Sop.SDataB.Neck.SequenceEqual(Sop.SData.Neck));
                dict.Add("放肩", Sop.SDataB.Crown.SequenceEqual(Sop.SData.Crown));
                dict.Add("转肩", Sop.SDataB.Shoulder.SequenceEqual(Sop.SData.Shoulder));
                
                
                dict.Add("等径", Sop.SDataB.Body.SequenceEqual(Sop.SData.Body));
                dict.Add("收尾", Sop.SDataB.Tail.SequenceEqual(Sop.SData.Tail));
                dict.Add("停炉", Sop.SDataB.Shutdown.SequenceEqual(Sop.SData.Shutdown));
                dict.Add("副室净化", Sop.SDataB.Purge.SequenceEqual(Sop.SData.Purge));
                dict.Add("煅烧", Sop.SDataB.Backout.SequenceEqual(Sop.SData.Backout));
                dict.Add("热场控制", Sop.SDataB.TempCtl.SequenceEqual(Sop.SData.TempCtl));
                dict.Add("取段冷却", Sop.SDataB.CrystalCold.SequenceEqual(Sop.SData.CrystalCold));
                dict.Add("渣盖提出", Sop.SDataB.CoverOut.SequenceEqual(Sop.SData.CoverOut));
                dict.Add("料桶提入提出", Sop.SDataB.TubeInOut.SequenceEqual(Sop.SData.TubeInOut));
                dict.Add("籽晶提入提出", Sop.SDataB.SeedPullIn.SequenceEqual(Sop.SData.SeedPullIn));
                dict.Add("炉盖旋开旋回", Sop.SDataB.CoverRotInOut.SequenceEqual(Sop.SData.CoverRotInOut));
                dict.Add("炉筒旋开旋回", Sop.SDataB.FTRotInOut.SequenceEqual(Sop.SData.FTRotInOut));
                dict.Add("自动加料", Sop.SDataB.AutoCharing.SequenceEqual(Sop.SData.AutoCharing));
                dict.Add("回熔", Sop.SDataB.ReMelting.SequenceEqual(Sop.SData.ReMelting));
                dict.Add("一键放锅", Sop.SDataB.OneKeySetCru.SequenceEqual(Sop.SData.OneKeySetCru));
                dict.Add("硅料预热", Sop.SDataB.SiliconPreheat.SequenceEqual(Sop.SData.SiliconPreheat));
                foreach (KeyValuePair<string, bool> var in dict)
                {
                    if (var.Value == false)
                    {
                        tepStr = var.Key;
                        return true;
                    }
                }
                return false;
            }
            else
            {
                tepStr = "未通信连接";
                return true;
            }
        }
        private void CheckSameSop()
        {
            if (!File.Exists(string.Concat(Application.StartupPath, "\\SOP\\", LabFileName.Text)))
            {
                LabRunAndShowStatus.Text = "当前文件不存在";
            }
            string DiffProcStr = "";
            if (NotSame(ref DiffProcStr))
            {
                LabRunAndShowStatus.Text = String.Concat($"不相同({DiffProcStr})!");
            }
            else
            {
                LabRunAndShowStatus.Text = "相同";
            }
        }
    }
}
