using CrystalGrowth.CrystalCtl;
using CrystalGrowth.Unities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction.CCD
{
    internal partial class FrmCam1SavePic : Form
    {
        public static Dictionary<float, bool> JumpSaveDic = new Dictionary<float, bool>() {
            {0.0f,false},
            {1.0f,false},
            {2.0f,false},
            {3.0f,false},
            {4.0f,false},
            {5.0f,false},
            {8.0f,false},
            {9.0f,false},
            {10.0f,true},
            {11.0f,false},
            {12.0f,false},
            {13.0f,false},
            {14.0f,false},
            {15.0f,false},
            {16.0f,false},
            {17.0f,false},
            {18.0f,false},
            {19.0f,false},
            {20.0f,false},
            {20.1f,false},
            {20.2f,false},
            {21.0f,false},
            {22.0f,false},
            {23.0f,false},
            {24.0f,false},
            {25.0f,false},
            {26.0f,false},
            {27.0f,false},
            {28.0f,false},
            {29.0f,false},
            {30.0f,false},
            {31.0f,false},
            {32.0f,false},
            {33.0f,false},
            {34.0f,false},
            {35.0f,false}
            };
        public static Dictionary<float, bool> FullSaveDic = new Dictionary<float, bool>() {
            {0.0f,false},
            {1.0f,false},
            {2.0f,false},
            {3.0f,false},
            {4.0f,false},
            {5.0f,false},
            {8.0f,false},
            {9.0f,false},
            {10.0f,false},
            {11.0f,false},
            {12.0f,false},
            {13.0f,false},
            {14.0f,false},
            {15.0f,false},
            {16.0f,false},
            {17.0f,false},
            {18.0f,false},
            {19.0f,false},
            {20.0f,false},
            {20.1f,false},
            {20.2f,false},
            {21.0f,false},
            {22.0f,false},
            {23.0f,false},
            {24.0f,false},
            {25.0f,false},
            {26.0f,false},
            {27.0f,false},
            {28.0f,false},
            {29.0f,false},
            {30.0f,false},
            {31.0f,false},
            {32.0f,false},
            {33.0f,false},
            {34.0f,false},
            {35.0f,false}
            };
        public static bool IsSaveFullImg = false;
        public static bool IsSaveJumpImg = true;
        public FrmCam1SavePic()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            LabSaveInterval.Text = ParasCam1.SaveInterval.ToString();
            LabFilePath.Text = "存图地址:" + ParasCam1.SavePicPath;
            if (FrmImage.IsNeedSaveImg == true)
            {
                BtnSaveImg.BackColor = Color.Lime;
            }
            else
            {
                BtnSaveImg.BackColor = Color.RoyalBlue;
            }
        }
        /// <summary>
        /// 加载界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCam1Adjust_Load(object sender, EventArgs e)
        {
            ParasCam1.SaveInterval = FrmMain.GlobalParameter.SaveInterval;
            ParasCam1.SavePicPath = FrmMain.GlobalParameter.SavePicPath;
            ClbJumpSave.Items.Clear();
            foreach (var temp in JumpSaveDic)
            {
                ClbJumpSave.Items.Add(ProcState.CurrentState(Math.Round(temp.Key, 1).ToString("f1")), temp.Value);
            }
            ClbFullSave.Items.Clear();
            foreach (var temp in FullSaveDic)
            {
                ClbFullSave.Items.Add(ProcState.CurrentState(Math.Round(temp.Key, 1).ToString("f1")), temp.Value);
            }
            CbxSaveAll.Checked = IsSaveFullImg;
            CbxSaveJump.Checked = IsSaveJumpImg;
        }
        private void BtnSaveImg_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnSelectPath))
            {
                if (FrmImage.IsNeedSaveImg == false)
                {
                    FrmImage.IsNeedSaveImg = true;
                }
                else
                {
                    FrmImage.IsNeedSaveImg = false;
                }
            }
        }
        private void BtnSelectPath_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnSelectPath))
            {
                FolderBrowserDialog dilog = new FolderBrowserDialog();
                dilog.Description = "请选择文件夹";
                var res = dilog.ShowDialog();
                if (res == DialogResult.OK)
                {
                    var path = dilog.SelectedPath;
                    int selectIndex = -1;
                    DriveInfo[] driveInfos = DriveInfo.GetDrives();
                    for (int i = 0; i < driveInfos.Length; i++)
                    {
                        if (path.Contains(driveInfos[i].Name))
                        {
                            selectIndex = i;
                        }
                    }
                    if (selectIndex >= 0 && driveInfos[selectIndex].VolumeLabel != "Windows"
                        && !driveInfos[selectIndex].Name.Contains("C:")
                        && !driveInfos[selectIndex].Name.Contains("D:")
                        && driveInfos[selectIndex].AvailableFreeSpace > 107374182.400)
                    {//磁盘符合要求
                        ParasCam1.SavePicPath = path;
                        FrmMain.GlobalParameter.SavePicPath = path;
                    }
                    else
                    {//磁盘不符合要求 

                        MessageBox.Show("请选择固定磁盘(非系统盘)，并且可用空间大于100M");
                    }
                }
            }
        }

        private void LabSaveInterval_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm
            {
                Location = new Point(400, 130)
            };
            kf.ImportData(ref LabSaveInterval, 1, 10000);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                ParasCam1.SaveInterval = Convert.ToInt32(LabSaveInterval.Text);
                FrmMain.GlobalParameter.SaveInterval = ParasCam1.SaveInterval;
            }
        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < ClbJumpSave.Items.Count; i++)
            {
                JumpSaveDic[ProcState.CurrentStateNum(ClbJumpSave.Items[i].ToString())] = ClbJumpSave.GetItemChecked(i);
            }
        }

        private void CbxSaveAll_CheckedChanged(object sender, EventArgs e)
        {
            IsSaveFullImg = CbxSaveAll.Checked;
        }
        private void CbxSaveJump_CheckedChanged(object sender, EventArgs e)
        {
            IsSaveJumpImg = CbxSaveJump.Checked;
        }
        private void CbxFullSelect_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxFullSelect.Checked)
            {
                for (int i = 0; i < ClbFullSave.Items.Count; i++)
                {

                    FullSaveDic[ProcState.CurrentStateNum(ClbFullSave.Items[i].ToString())] = true;
                    ClbFullSave.SetItemChecked(i, true);
                }
            }
            else
            {
                for (int i = 0; i < ClbFullSave.Items.Count; i++)
                {

                    FullSaveDic[ProcState.CurrentStateNum(ClbFullSave.Items[i].ToString())] = false;
                    ClbFullSave.SetItemChecked(i, false);
                }
            }
        }

        private void ClbFullSave_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < ClbFullSave.Items.Count; i++)
            {
                FullSaveDic[ProcState.CurrentStateNum(ClbFullSave.Items[i].ToString())] = ClbFullSave.GetItemChecked(i);
            }
        }
    }
}
