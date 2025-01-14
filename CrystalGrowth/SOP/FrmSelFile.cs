using CrystalGrowth.SOP;
using CrystalGrowth.Unities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SOP
{
    internal partial class FrmSelFile : Form
    {
        int SelRow = 0;
        string SelFileName;
        List<FileInfo> FileList;
        public FrmSelFile()
        {
            InitializeComponent();
        }
        private void FrmSelFile_Load(object sender, EventArgs e)
        {
            DisplayFile();
            BtnSelect.Enabled = false;
            BtnDelete.Enabled = false;
            BtnExport.Enabled = false;
        }
        private void DisplayFile()
        {
            DataGridView1.Rows.Clear();
            DirectoryInfo Dir = new DirectoryInfo(string.Concat(Application.StartupPath, "\\SOP"));
            FileInfo[] Files = Dir.GetFiles("*.sop", SearchOption.TopDirectoryOnly);
            var Is = from file in Files orderby (file.CreationTime) select file;
            FileList = Is.ToList();
            int FilesLength = Files.Length - 1;
            int tempIndex = 0;
            List<FileInfo> lsRemoveDefault = new List<FileInfo>();
            for (int i = 0; i <= FilesLength; i++)
            {
                if (FileList[i].Name != "lintonkayex.sop")
                {
                    lsRemoveDefault.Add(FileList[i]);
                }
                else
                {
                    tempIndex = i;
                }
            }
            if (lsRemoveDefault.Count == 0)
            {
                lsRemoveDefault.Add(FileList[tempIndex]);
            }
            FileList = lsRemoveDefault;
            DataGridView1.Rows.Add(FileList.Count);
            int Length = FileList.Count - 1;
            for (int i = 0; i <= Length; i++)
            {
                DataGridView1.Rows[i].Cells[0].Value = FileList[i].Name;
            }
        }
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelRow = e.RowIndex;
            DataGridView1[e.ColumnIndex, SelRow].Style.SelectionBackColor = Color.Blue;
            DataGridView1[e.ColumnIndex, SelRow].Style.SelectionForeColor = Color.White;
            LabFileName.Text = FileList[SelRow].Name;
            LabCreatTime.Text = FileList[SelRow].CreationTime.ToString();
            LabModifyTIme.Text = FileList[SelRow].LastWriteTime.ToString();
            SelFileName = DataGridView1[e.ColumnIndex, SelRow].Value.ToString();
            BtnSelect.Enabled = true;
            BtnDelete.Enabled = true;
            BtnExport.Enabled = true;
        }
        private void BtnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog1.InitialDirectory = "d:\\";
            OpenFileDialog1.Filter = "sop files (*.sop)|*.sop|xls files(*.xls)|*.xls|All files (*.*)|*.*";
            OpenFileDialog1.FilterIndex = 1;
            //获取或设置文件对话框中当前选定筛选器的索引
            OpenFileDialog1.RestoreDirectory = true;
            OpenFileDialog1.Title = "导入";
            OpenFileDialog1.FileName = "";
            if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] TempName = OpenFileDialog1.FileName.Split(new char[] { '\\' });
                string FileName = TempName[TempName.Length - 1];
                //导入的是Excel文件
                if (FileName.Contains(".xls"))
                {
                    //将Excel文件转换成sop
                    string ExcelFileName = string.Concat(FileName.Split(new char[] { '.' })[0], ".sop");
                    string SopPath = string.Concat(Application.StartupPath, "\\SOP\\", ExcelFileName);
                    if (File.Exists(SopPath))
                    {
                        LabInfo.Text = "已存在同名SOP文件！";
                    }
                    else
                    {
                        LabInfo.Text = "";
                        List<SopFrm.TabCtrl> TabCtrlList = InitSopConverter();
                        SopFrm SopConverter = new SopFrm("KA22032-V1.2.20.30", TabCtrlList);
                        LabInfo.Text = SopConverter.ImportSop(OpenFileDialog1.FileName, SopPath);
                        DisplayFile();

                    }
                }
                if (FileName.Contains(".sop"))
                {
                    //导入SOP文件
                    string SopPath = string.Concat(Application.StartupPath, "\\SOP\\", FileName);
                    if (File.Exists(SopPath))
                    {
                        LabInfo.Text = "已存在同名SOP文件！";
                    }
                    else
                    {
                        LabInfo.Text = "";
                        File.Copy(OpenFileDialog1.FileName, SopPath);
                        DisplayFile();
                    }
                }
            }
        }
        private void BtnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog1.InitialDirectory = "d:\\";
            //SaveFileDialog1.Filter = "sop files (*.sop)|*.sop|All files (*.*)|*.*";
            SaveFileDialog1.Filter = "sop files (*.sop)|*.sop|xls files(*.xls)|*.xls|All files (*.*)|*.*";
            SaveFileDialog1.FileName = FileList[SelRow].Name;
            SaveFileDialog1.FilterIndex = 1;
            //获取或设置文件对话框中当前选定筛选器的索引
            SaveFileDialog1.RestoreDirectory = true;
            SaveFileDialog1.Title = "导出";
            if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string SopPath = string.Concat(Application.StartupPath, "\\SOP\\", SelFileName);
                //导出Excel文件
                if (SaveFileDialog1.FilterIndex == 2)
                {
                    List<SopFrm.TabCtrl> TabCtrlList = InitSopConverter();
                    SopFrm SopConverter = new SopFrm("KA22032-V1.2.20.33", TabCtrlList);
                    SopConverter.GenerateExcelFromDataFile(SopPath, SaveFileDialog1.FileName);
                    LabInfo.Text = "导出成功！";
                }
                else
                {
                    //导出Sop文件
                    File.Copy(SopPath, SaveFileDialog1.FileName, true);
                }
            }
        }
        public List<SopFrm.TabCtrl> InitSopConverter()
        {
            List<SopFrm.TabCtrl> TabCtrlList = new List<SopFrm.TabCtrl>();
            //初始化
            SopFrm.TabCtrl Init = new SopFrm.TabCtrl()
            {
                Name = "初始化设置",
                PageList = new List<SopFrm.Page>()
            };
            FuncFromControl(new ProcStab1(), Init.PageList);
            TabCtrlList.Add(Init);
            //抽空检漏
            SopFrm.TabCtrl PumpDownLeakBack = new SopFrm.TabCtrl()
            {
                Name = "抽空检漏",
                PageList = new List<SopFrm.Page>()
            };
            FuncFromControl(new ProcStab2(), PumpDownLeakBack.PageList);
            TabCtrlList.Add(PumpDownLeakBack);
            //压力化/熔料
            SopFrm.TabCtrl PressMelt = new SopFrm.TabCtrl()
            {
                Name = "压力化熔料",
                PageList = new List<SopFrm.Page>()
            };
            FuncFromControl(new ProcStab3(), PressMelt.PageList);
            TabCtrlList.Add(PressMelt);
            //预热/熔接
            SopFrm.TabCtrl StabDip = new SopFrm.TabCtrl()
            {
                Name = "预热熔接",
                PageList = new List<SopFrm.Page>()
            };
            FuncFromControl(new ProcStab4(), StabDip.PageList);
            TabCtrlList.Add(StabDip);
            //调温
            SopFrm.TabCtrl Dip = new SopFrm.TabCtrl()
            {
                Name = "调温",
                PageList = new List<SopFrm.Page>()
            };
            FuncFromControl(new ProcStab5(), Dip.PageList);
            TabCtrlList.Add(Dip);
         
            //引晶
            SopFrm.TabCtrl Neck = new SopFrm.TabCtrl()
            {
                Name = "引晶",
                PageList = new List<SopFrm.Page>()
            };
            FuncFromControl(new ProcStab6(), Neck.PageList);
            TabCtrlList.Add(Neck);
            //放肩
            SopFrm.TabCtrl Crown = new SopFrm.TabCtrl()
            {
                Name = "放肩",
                PageList = new List<SopFrm.Page>()
            };
            FuncFromControl(new ProcStab7(), Crown.PageList);
            TabCtrlList.Add(Crown);
            //转肩
            SopFrm.TabCtrl Shoulder = new SopFrm.TabCtrl()
            {
                Name = "转肩",
                PageList = new List<SopFrm.Page>()
            };
            FuncFromControl(new ProcStab8(), Shoulder.PageList);
            TabCtrlList.Add(Shoulder);
            //等径
            SopFrm.TabCtrl Body = new SopFrm.TabCtrl()
            {
                Name = "等径",
                PageList = new List<SopFrm.Page>()
            };
            FuncFromControl(new ProcStab9(), Body.PageList);
            TabCtrlList.Add(Body);
            //收尾
            SopFrm.TabCtrl Tail = new SopFrm.TabCtrl()
            {
                Name = "收尾",
                PageList = new List<SopFrm.Page>()
            };
            FuncFromControl(new ProcStab10(), Tail.PageList);
            TabCtrlList.Add(Tail);
            //停炉
            SopFrm.TabCtrl Shutdown = new SopFrm.TabCtrl()
            {
                Name = "停炉",
                PageList = new List<SopFrm.Page>()
            };
            FuncFromControl(new ProcStab11(), Shutdown.PageList);
            TabCtrlList.Add(Shutdown);
            //副室净化
            SopFrm.TabCtrl Purge = new SopFrm.TabCtrl()
            {
                Name = "副室净化",
                PageList = new List<SopFrm.Page>()
            };
            FuncFromControl(new ProcStab12(), Purge.PageList);
            TabCtrlList.Add(Purge);
            //煅烧
            SopFrm.TabCtrl Bakeout = new SopFrm.TabCtrl()
            {
                Name = "煅烧",
                PageList = new List<SopFrm.Page>()
            };
            FuncFromControl(new ProcStab13(), Bakeout.PageList);
            TabCtrlList.Add(Bakeout);
            //热场控制器
            SopFrm.TabCtrl Field = new SopFrm.TabCtrl()
            {
                Name = "热场控制器",
                PageList = new List<SopFrm.Page>()
            };
            FuncFromControl(new ProcStab14(), Field.PageList);
            TabCtrlList.Add(Field);
            //取段冷却
            SopFrm.TabCtrl ColdPullOut = new SopFrm.TabCtrl()
            {
                Name = "取段冷却",
                PageList = new List<SopFrm.Page>()
            };
            FuncFromControl(new ProcStab15(), ColdPullOut.PageList);
            TabCtrlList.Add(ColdPullOut);
            //渣盖提出
            SopFrm.TabCtrl CoverPullOut = new SopFrm.TabCtrl()
            {
                Name = "渣盖提出",
                PageList = new List<SopFrm.Page>()
            };
            FuncFromControl(new ProcStab16(), CoverPullOut.PageList);
            TabCtrlList.Add(CoverPullOut);
            //料筒提入-提出
            SopFrm.TabCtrl TubePull = new SopFrm.TabCtrl()
            {
                Name = "料筒提入提出",
                PageList = new List<SopFrm.Page>()
            };
            FuncFromControl(new ProcStab17(), TubePull.PageList);
            TabCtrlList.Add(TubePull);
            //籽晶提入
            SopFrm.TabCtrl SeedPullIn = new SopFrm.TabCtrl()
            {
                Name = "籽晶提入",
                PageList = new List<SopFrm.Page>()
            };
            FuncFromControl(new ProcStab18(), SeedPullIn.PageList);
            TabCtrlList.Add(SeedPullIn);
            //炉盖旋开/旋回
            SopFrm.TabCtrl FurnCover = new SopFrm.TabCtrl()
            {
                Name = "炉盖旋开旋回",
                PageList = new List<SopFrm.Page>()
            };
            FuncFromControl(new ProcStab19(), FurnCover.PageList);
            TabCtrlList.Add(FurnCover);
            //炉筒旋开/旋回
            SopFrm.TabCtrl FurnDrum = new SopFrm.TabCtrl()
            {
                Name = "炉筒旋开旋回",
                PageList = new List<SopFrm.Page>()
            };
            FuncFromControl(new ProcStab20(), FurnDrum.PageList);
            TabCtrlList.Add(FurnDrum);
            //自动装料
            SopFrm.TabCtrl AutoLoad = new SopFrm.TabCtrl()
            {
                Name = "自动装料",
                PageList = new List<SopFrm.Page>()
            };
            FuncFromControl(new ProcStab21(), AutoLoad.PageList);
            TabCtrlList.Add(AutoLoad);
            //回熔
            SopFrm.TabCtrl ReMelt = new SopFrm.TabCtrl()
            {
                Name = "回熔",
                PageList = new List<SopFrm.Page>()
            };
            FuncFromControl(new ProcStab22(), ReMelt.PageList);
            TabCtrlList.Add(ReMelt);
            //一键放埚
            SopFrm.TabCtrl OneKeySetCru = new SopFrm.TabCtrl()
            {
                Name = "一键放埚",
                PageList = new List<SopFrm.Page>()
            };
            FuncFromControl(new ProcStab23(), OneKeySetCru.PageList);
            TabCtrlList.Add(OneKeySetCru);
            //硅料预热
            SopFrm.TabCtrl SiliconPreheat = new SopFrm.TabCtrl()
            {
                Name = "硅料预热",
                PageList = new List<SopFrm.Page>()
            };
            FuncFromControl(new ProcStab24(), SiliconPreheat.PageList);
            TabCtrlList.Add(SiliconPreheat);
            return TabCtrlList;
        }
        public void FuncFromControl(Form frmProSel, List<SopFrm.Page> pageList)
        {
            foreach (Control ctrl in frmProSel.Controls)
            {
                if (ctrl is TabControl)
                {
                    foreach (Control ctrl1 in ctrl.Controls)
                    {
                        SopFrm.Page page = new SopFrm.Page();
                        if (ctrl1 is TabPage)
                        {
                            page.Name = ctrl1.Text;
                            page.DgvTable = ctrl1.Controls[0] as DataGridView;
                        }
                        pageList.Add(page);
                    }
                }
            }
        }
        private void BtnSelect_Click(object sender, EventArgs e)
        {
            LineFile FileValue = new LineFile();
            if (DouClick.ThreeSec(ref BtnSelect))
            {
                Sop.FileToParas(ref FileValue);
                if (DataGridView1.Rows[SelRow].Cells[0].Value.ToString() == FileValue.Name)
                {
                    ProcSel.Single.LabFileName.Text = FileValue.Name;
                    ProcSel.Single.LabFileStat.Text = FileValue.Stat;
                }
                else
                {
                    ProcSel.Single.LabFileName.Text = DataGridView1.Rows[SelRow].Cells[0].Value.ToString();
                    ProcSel.Single.LabFileStat.Text = "未下载";
                }
                ProcSel.Single.BtnDownLoad.Enabled = false;
                ProcSel.Single.BtnCurSop.Enabled = false;
                ProcSel.Single.LabRunAndShowStatus.Text = "用此sop,请先编辑保存下载";
                Sop.FileToForm(string.Concat(Application.StartupPath, "\\SOP\\", DataGridView1.Rows[SelRow].Cells[0].Value));
                Close();
            }
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnDelete))
            {
                if (DataGridView1.Rows[SelRow].Cells[0].Value.ToString() != "lintonkayex.sop" && DataGridView1.Rows[SelRow].Cells[0].Value.ToString() != ProcSel.Single.LabFileName.Text)
                {
                    File.Delete(string.Concat(Application.StartupPath, "\\SOP\\", DataGridView1.Rows[SelRow].Cells[0].Value.ToString()));
                    DataGridView1.Rows.Clear();
                    DisplayFile();
                    BtnSelect.Enabled = false;
                    BtnDelete.Enabled = false;
                    BtnExport.Enabled = false;
                }
            }
        }
        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
