using CrystalGrowth.SOP;
using CrystalGrowth.Unities;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction.Calibration
{
    internal partial class FrmCalib : Form
    {
        Form LastForm;
        public FrmCalib()
        {
            InitializeComponent();
            LastForm = new FrmFurnaceNum();
            Load += Timer1_Tick;
        }
        private void FrmCalib_Load(object sender, EventArgs e)
        {
            AddDgv1();
            AddDgv2();
            DataGridView1.Rows[2].Visible = true;
            DataGridView1.Rows[16].Visible = true;
            Calibrate.ReadTime();
        }
        private void AddDgv1()
        {
            DataGridView1.Rows.Add(25);
            DataGridView1.Rows[0].Cells[0].Value = "炉号";
            DataGridView1.Rows[1].Cells[0].Value = "直径";
            DataGridView1.Rows[2].Cells[0].Value = "视觉液口距";
            DataGridView1.Rows[3].Cells[0].Value = "重量液口距";
            DataGridView1.Rows[4].Cells[0].Value = "摄像头位置";
            DataGridView1.Rows[5].Cells[0].Value = "籽晶位置";
            DataGridView1.Rows[6].Cells[0].Value = "籽晶限位";
            DataGridView1.Rows[7].Cells[0].Value = "称重校准";
            DataGridView1.Rows[8].Cells[0].Value = "总重量";
            DataGridView1.Rows[8].Visible = false;
            DataGridView1.Rows[9].Cells[0].Value = "提出重量";
            DataGridView1.Rows[9].Visible = false;
            DataGridView1.Rows[10].Cells[0].Value = "坩埚位置";
            DataGridView1.Rows[11].Cells[0].Value = "坩埚限位";
            DataGridView1.Rows[12].Cells[0].Value = "热屏位置";
            DataGridView1.Rows[13].Cells[0].Value = "热屏限位";
            DataGridView1.Rows[14].Cells[0].Value = "热场温度";
            //隐藏热场温度校准
            DataGridView1.Rows[14].Visible = false;
            DataGridView1.Rows[15].Cells[0].Value = "加热功耗";
            DataGridView1.Rows[16].Cells[0].Value = "液面温度";
            DataGridView1.Rows[17].Cells[0].Value = "隔离大气压阈值";
            DataGridView1.Rows[18].Cells[0].Value = "氩气消耗";
            DataGridView1.Rows[19].Cells[0].Value = "等径总长";
            DataGridView1.Rows[20].Cells[0].Value = "等径多段长度";
            DataGridView1.Rows[21].Cells[0].Value = "晶升速度";
            DataGridView1.Rows[22].Cells[0].Value = "晶转速度";
            DataGridView1.Rows[23].Cells[0].Value = "埚升速度";
            DataGridView1.Rows[24].Cells[0].Value = "埚转速度";
            //部分加密不可见 
            NoVisible(false);
        }
        private void AddDgv2()
        {
            DataGridView2.Rows.Add(52);
            DataGridView2.Rows[0].Cells[0].Value = "引晶直径增益";
            DataGridView2.Rows[1].Cells[0].Value = "引晶直径偏移(mm)";
            DataGridView2.Rows[2].Cells[0].Value = "放肩直径增益";
            DataGridView2.Rows[3].Cells[0].Value = "放肩直径偏移(mm)";
            DataGridView2.Rows[4].Cells[0].Value = "等径直径增益";
            DataGridView2.Rows[5].Cells[0].Value = "等径直径偏移(mm)";
            DataGridView2.Rows[6].Cells[0].Value = "CCD-软轴距离(mm)";
            DataGridView2.Rows[7].Cells[0].Value = "CCD-加热器距离(mm)";
            DataGridView2.Rows[8].Cells[0].Value = "籽晶位置偏移(mm)";
            DataGridView2.Rows[9].Cells[0].Value = "籽晶位置增益";
            DataGridView2.Rows[10].Cells[0].Value = "籽晶位置上限位(mm)";
            DataGridView2.Rows[11].Cells[0].Value = "籽晶位置下限位(mm)";
            DataGridView2.Rows[12].Cells[0].Value = "视觉液口距调整系数";
            DataGridView2.Rows[13].Cells[0].Value = "备用";
            DataGridView2.Rows[14].Cells[0].Value = "备用";
            DataGridView2.Rows[15].Cells[0].Value = "晶体重量偏移(kg)";
            DataGridView2.Rows[16].Cells[0].Value = "晶体重量增益";
            DataGridView2.Rows[17].Cells[0].Value = "坩埚位置偏移(mm)";
            DataGridView2.Rows[18].Cells[0].Value = "坩埚位置增益";
            DataGridView2.Rows[19].Cells[0].Value = "坩埚上限位(mm)";
            DataGridView2.Rows[20].Cells[0].Value = "坩埚下限位(mm)";
            DataGridView2.Rows[21].Cells[0].Value = "备用";
            DataGridView2.Rows[22].Cells[0].Value = "热屏位置增益";
            DataGridView2.Rows[23].Cells[0].Value = "热屏位置偏移(mm)";
            DataGridView2.Rows[24].Cells[0].Value = "热屏上限位(mm)";
            DataGridView2.Rows[25].Cells[0].Value = "热屏下限位(mm)";
            DataGridView2.Rows[26].Cells[0].Value = "备用";
            DataGridView2.Rows[27].Cells[0].Value = "热场温度增益";
            DataGridView2.Rows[28].Cells[0].Value = "液面温度增益";
            DataGridView2.Rows[29].Cells[0].Value = "主加热功率限值(KW)";
            DataGridView2.Rows[30].Cells[0].Value = "底部加热功率限值(KW)";
            DataGridView2.Rows[31].Cells[0].Value = "总消耗功率(MWh)";
            DataGridView2.Rows[32].Cells[0].Value = "总运行时间(hr)";
            DataGridView2.Rows[33].Cells[0].Value = "总消耗氩气(立方米)";
            DataGridView2.Rows[34].Cells[0].Value = "隔离大气压阈值(torr)";
            DataGridView2.Rows[35].Cells[0].Value = "视觉液口距增益";
            DataGridView2.Rows[36].Cells[0].Value = "导流筒插入加热器深度(mm)";
            DataGridView2.Rows[37].Cells[0].Value = "晶升速度增益";
            DataGridView2.Rows[38].Cells[0].Value = "晶转速度增益";
            DataGridView2.Rows[39].Cells[0].Value = "埚升速度增益";
            DataGridView2.Rows[40].Cells[0].Value = "埚转速度增益";
            DataGridView2.Rows[41].Cells[0].Value = "上升力矩(%)";
            DataGridView2.Rows[42].Cells[0].Value = "下降力矩(%)";
            DataGridView2.Rows[43].Cells[0].Value = "位置偏差值(mm)";
            DataGridView2.Rows[44].Cells[0].Value = "1000TorrOffset";
            DataGridView2.Rows[45].Cells[0].Value = "1000TorrGain";
            DataGridView2.Rows[46].Cells[0].Value = "100TorrOffset";
            DataGridView2.Rows[47].Cells[0].Value = "100TorrGain";
            DataGridView2.Rows[48].Cells[0].Value = "1TorrOffset";
            DataGridView2.Rows[49].Cells[0].Value = "1TorrGain";
            DataGridView2.Rows[50].Cells[0].Value = "液温偏移";
            DataGridView2.Rows[51].Cells[0].Value = "视觉液口距偏移量";
            DataGridView2.Rows[12].Visible = false;
            DataGridView2.Rows[13].Visible = false;
            DataGridView2.Rows[14].Visible = false;
            DataGridView2.Rows[21].Visible = false;
            DataGridView2.Rows[26].Visible = false;
        }
        private void NoVisible(bool isVisible)
        {
            DataGridView1.Rows[0].Visible = isVisible;
            DataGridView1.Rows[1].Visible = isVisible;
            DataGridView1.Rows[2].Visible = isVisible;
            DataGridView1.Rows[3].Visible = isVisible;
            DataGridView1.Rows[4].Visible = isVisible;
            DataGridView1.Rows[5].Visible = isVisible;
            DataGridView1.Rows[6].Visible = isVisible;
            DataGridView1.Rows[7].Visible = isVisible;
            DataGridView1.Rows[10].Visible = isVisible;
            DataGridView1.Rows[11].Visible = isVisible;
            DataGridView1.Rows[12].Visible = isVisible;
            DataGridView1.Rows[13].Visible = isVisible;
            DataGridView1.Rows[15].Visible = isVisible;
            DataGridView1.Rows[16].Visible = isVisible;
            DataGridView1.Rows[17].Visible = isVisible;
            DataGridView1.Rows[18].Visible = isVisible;
            DataGridView1.Rows[19].Visible = isVisible;
            DataGridView1.Rows[20].Visible = isVisible;
            DataGridView1.Rows[21].Visible = isVisible;
            DataGridView1.Rows[22].Visible = isVisible;
            DataGridView1.Rows[23].Visible = isVisible;
            DataGridView1.Rows[24].Visible = isVisible;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 1; i <= 52; i++)
            {
                if (i == 2 || i == 4 || i == 6 || i == 10 || i == 13 || i == 16 ||
                    i == 19 || i == 23 || i == 28 || i == 29 || i == 36 || (i >= 38 && i <= 44))
                {
                    DataGridView2.Rows[i - 1].Cells[1].Value = Math.Round(PLC.ReadCalibValue[i], 2).ToString("f2");
                }
                else if (i == 1 || i == 3 || i == 5 || i == 17 || i == 32 || i == 33 || i == 34)
                {
                    DataGridView2.Rows[i - 1].Cells[1].Value = Math.Round(PLC.ReadCalibValue[i], 3).ToString("f3");
                }
                else if (i == 51)
                {
                    DataGridView2.Rows[i - 1].Cells[1].Value = Calibrate.Value[44];
                }
                else if (i == 52)
                {
                    DataGridView2.Rows[i - 1].Cells[1].Value = Math.Round(PLC.ReadCalibValue[74], 1).ToString("f1");
                }
                else
                {
                    DataGridView2.Rows[i - 1].Cells[1].Value = Math.Round(PLC.ReadCalibValue[i], 1).ToString("f1");
                }
            }
        }
        private void FrmCalib_FormClosed(object sender, FormClosedEventArgs e)
        {
            LastForm.Close();
        }
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView1.CurrentCell.Selected = true;
            DataGridView1[0, e.RowIndex].Style.SelectionBackColor = Color.Blue;
            DataGridView1[0, e.RowIndex].Style.SelectionForeColor = Color.White;
            LastForm.Close();
            GC.Collect();
            switch (e.RowIndex)
            {
                case 0:
                    FrmFurnaceNum furnaceNum = new FrmFurnaceNum();
                    FrmSwitch.Open(furnaceNum, 131, new Size(394, 380));
                    LastForm = furnaceNum;
                    break;
                case 1:
                    FrmDiaCalib diaCalib = new FrmDiaCalib();
                    FrmSwitch.Open(diaCalib, 134, new Size(394, 380));
                    LastForm = diaCalib;
                    break;
                case 2:
                    FrmMeltGapClib meltGapClib = new FrmMeltGapClib();
                    FrmSwitch.Open(meltGapClib, 135, new Size(627, 380));
                    LastForm = meltGapClib;
                    break;
                case 3:
                    FrmWeightGap weightGap = new FrmWeightGap();
                    FrmSwitch.Open(weightGap, 136, new Size(394, 380));
                    LastForm = weightGap;
                    break;
                case 4:
                    FrmCameraPos cameraPos = new FrmCameraPos();
                    FrmSwitch.Open(cameraPos, 137, new Size(394, 380));
                    LastForm = cameraPos;
                    break;
                case 5:
                    FrmSeedTrv seedTrv = new FrmSeedTrv();
                    FrmSwitch.Open(seedTrv, 138, new Size(394, 380));
                    LastForm = seedTrv;
                    break;
                case 6:
                    FrmSeedTrvLim seedTrvLim = new FrmSeedTrvLim();
                    FrmSwitch.Open(seedTrvLim, 139, new Size(394, 380));
                    LastForm = seedTrvLim;
                    break;
                case 7:
                    FrmWeightCalib weightCalib = new FrmWeightCalib();
                    FrmSwitch.Open(weightCalib, 140, new Size(494, 380));
                    LastForm = weightCalib;
                    break;
                case 8:
                    FrmWeightTune weightTune = new FrmWeightTune();
                    FrmSwitch.Open(weightTune, 141, new Size(394, 380));
                    LastForm = weightTune;
                    break;
                case 9:
                    FrmPulloutWeig pulloutWeig = new FrmPulloutWeig();
                    FrmSwitch.Open(pulloutWeig, 142, new Size(394, 380));
                    LastForm = pulloutWeig;
                    break;
                case 10:
                    FrmCrucTrv crucTrv = new FrmCrucTrv();
                    FrmSwitch.Open(crucTrv, 143, new Size(394, 380));
                    LastForm = crucTrv;
                    break;
                case 11:
                    FrmCrucTrvLim crucTrvLim = new FrmCrucTrvLim();
                    FrmSwitch.Open(crucTrvLim, 144, new Size(394, 380));
                    LastForm = crucTrvLim;
                    break;
                case 12:
                    FrmShieldTrv shieldTrv = new FrmShieldTrv();
                    FrmSwitch.Open(shieldTrv, 145, new Size(594, 380));
                    LastForm = shieldTrv;
                    break;
                case 13:
                    FrmShieldTrvLim shieldTrvLim = new FrmShieldTrvLim();
                    FrmSwitch.Open(shieldTrvLim, 146, new Size(394, 380));
                    LastForm = shieldTrvLim;
                    break;
                case 14:
                    FrmHtrTempClib htrTempClib = new FrmHtrTempClib();
                    FrmSwitch.Open(htrTempClib, 147, new Size(394, 380));
                    LastForm = htrTempClib;
                    break;
                case 15:
                    FrmTotalPower totalPower = new FrmTotalPower();
                    FrmSwitch.Open(totalPower, 148, new Size(394, 380));
                    LastForm = totalPower;
                    break;
                case 16:
                    FrmCameraTemp cameraTemp = new FrmCameraTemp();
                    FrmSwitch.Open(cameraTemp, 149, new Size(580, 380));
                    LastForm = cameraTemp;
                    break;
                case 17:
                    FrmIsoAtm isoAtm = new FrmIsoAtm();
                    FrmSwitch.Open(isoAtm, 150, new Size(394, 380));
                    LastForm = isoAtm;
                    break;
                case 18:
                    FrmTotalGas totalGas = new FrmTotalGas();
                    FrmSwitch.Open(totalGas, 151, new Size(394, 380));
                    LastForm = totalGas;
                    break;
                case 19:
                    FrmTotalLen totalLen = new FrmTotalLen();
                    FrmSwitch.Open(totalLen, 152, new Size(394, 380));
                    LastForm = totalLen;
                    break;
                case 20:
                    FrmMultiSegment multiSegment = new FrmMultiSegment();
                    FrmSwitch.Open(multiSegment, 153, new Size(394, 380));
                    LastForm = multiSegment;
                    break;
                case 21:
                    FrmSL_Speed sLSpeed = new FrmSL_Speed();
                    FrmSwitch.Open(sLSpeed, 154, new Size(394, 380));
                    LastForm = sLSpeed;
                    break;
                case 22:
                    FrmSR_Speed sRSpeed = new FrmSR_Speed();
                    FrmSwitch.Open(sRSpeed, 155, new Size(394, 380));
                    LastForm = sRSpeed;
                    break;
                case 23:
                    FrmCL_Speed cLSpeed = new FrmCL_Speed();
                    FrmSwitch.Open(cLSpeed, 156, new Size(394, 380));
                    LastForm = cLSpeed;
                    break;
                case 24:
                    FrmCR_Speed cRSpeed = new FrmCR_Speed();
                    FrmSwitch.Open(cRSpeed, 157, new Size(394, 380));
                    LastForm = cRSpeed;
                    break;
                default:
                    return;
            }
        }
        private void BtnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog1.InitialDirectory = "d:\\";
            OpenFileDialog1.Filter = "cal files (*.cal)|*.cal|All files (*.*)|*.*";
            OpenFileDialog1.FilterIndex = 1;
            //获取或设置文件对话框中当前选定筛选器的索引
            OpenFileDialog1.RestoreDirectory = true;
            OpenFileDialog1.Title = "导入";
            OpenFileDialog1.FileName = "";
            if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] TempName = OpenFileDialog1.FileName.Split(new char[] { '\\' });
                string FileName = TempName[TempName.Length - 1];
                string CalibPath = string.Concat(Application.StartupPath, "\\Calibration\\", FileName);
                try
                {
                    if (FileName == "CalibValue.cal")
                    {
                        File.Copy(OpenFileDialog1.FileName, CalibPath, true);
                    }
                    else
                    {
                        File.Delete(FileHelper.CalibrationPath);
                        File.Copy(OpenFileDialog1.FileName, CalibPath, true);
                        File.Move(CalibPath, FileHelper.CalibrationPath);
                    }
                    Calibrate.FileToPlc();
                }
                catch (Exception ex)
                {
                    Log.Record("导入文件正在使用中，或校准参数加载错误！", ex);
                    MessageBox.Show("导入文件正在使用中，或校准参数加载错误！");
                }
            }
        }
        private void BtnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog1.InitialDirectory = "d:\\";
            SaveFileDialog1.Filter = "cal files (*.cal)|*.cal|All files (*.*)|*.*";
            SaveFileDialog1.FilterIndex = 1;
            //获取或设置文件对话框中当前选定筛选器的索引
            SaveFileDialog1.RestoreDirectory = true;
            SaveFileDialog1.Title = "导出";
            if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.Copy(FileHelper.CalibrationPath, SaveFileDialog1.FileName, true);
            }
        }
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            string Pwd;
            if (LabUsrName.Text == "") { return; }
            DataTable dt = SqliteHelper.GetDataTable(string.Format("SELECT * FROM LOGIN_DATA WHERE USER_NAME ='{0}'", LabUsrName.Text));
            if (dt.Rows.Count >= 1)
            {
                Pwd = dt.Rows[0][2].ToString();
            }
            else
            {
                MessageBox.Show("用户名输入错误！");
                return;
            }
            if (TextBoxPwd.Text != Pwd)
            {
                MessageBox.Show("密码输入错误！");
                return;
            }
            else
            {
                Level.MeltGapSafe = true;
                Level.MeltGapLArea = true;
                Level.PermitModify = true;
                Level.UserName = LabUsrName.Text;
                NoVisible(true);
            }
            if (LabUsrName.Text == "KayexAdmin" && TextBoxPwd.Text == Pwd)
            {
                Level.KayexAdmin = true;
                Level.UserName = LabUsrName.Text;
            }
            dt.Dispose();
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            LabUsrName.Text = "Operator01";
            TextBoxPwd.Clear();
            LastForm.Close();
            NoVisible(false);
            DataGridView1.Rows[2].Visible = true;
            DataGridView1.Rows[16].Visible = true;
            Level.UserName = "";
        }
        private void TextBoxPwd_Click(object sender, EventArgs e)
        {
            FullKey fk = new FullKey();
            fk.ImportData(ref TextBoxPwd, new Point(561, 220), 20);
            fk.ShowDialog();
        }

        private void LabUsrName_Click(object sender, EventArgs e)
        {
            FullKey fk = new FullKey();
            fk.ImportData(ref LabUsrName, new Point(561, 220), 20);
            fk.ShowDialog();
        }
    }
}
