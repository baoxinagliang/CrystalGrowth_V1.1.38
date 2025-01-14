using CrystalGrowth.Unities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CrystalGrowth.SOP
{
    internal partial class FrmSaveFile : Form
    {
        List<FileInfo> FileList;
        public bool CreateFileFlag = false;
        public FrmSaveFile()
        {
            InitializeComponent();
        }
        private void FrmSaveFile_Load(object sender, EventArgs e)
        {
            DisplayFile();
        }
        public void DisplayFile()
        {
            DirectoryInfo Dir = new DirectoryInfo(string.Concat(Application.StartupPath, "\\SOP"));
            FileInfo[] Files = Dir.GetFiles("*.sop", SearchOption.TopDirectoryOnly);
            var Is = from file in Files orderby (file.CreationTime) select file;
            FileList = Is.ToList();
            int FilesLength = Files.Length;
            DataGridView1.Rows.Add(FilesLength);
            for (int i = 0; i < FilesLength; i++)
            {
                DataGridView1.Rows[i].Cells[0].Value = FileList[i].Name;
            }
        }
        private void BtnAck_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnAck))
            {
                if (LabTxtName.Text == "")
                {
                    MessageBox.Show("文件名不能为空");
                    return;
                }
                else
                {
                    string SopPath = string.Format("{0}\\SOP\\{1}.sop", Application.StartupPath, LabTxtName.Text);
                    if (File.Exists(SopPath))
                    {
                        MessageBox.Show("不能另存为同名文件");
                    }
                    else
                    {
                        CreateFileFlag = true;
                        string[] strFile = Sop.FileJudge(SopPath);
                        File.WriteAllLines(SopPath, strFile);
                        DisplayFile();
                    }
                }
            }
        }
        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void LabTxtName_Click(object sender, EventArgs e)
        {
            FullKey fk = new FullKey();
            fk.ImportData(ref LabTxtName, new Point(1000, 209), 38);
            fk.ShowDialog();
        }
    }
}
