using CrystalGrowth.CrystalCtl;
using CrystalGrowth.Unities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CrystalGrowth.GrowRecord
{
    internal partial class FrmGrowRecord : Form
    {
        public static int PageNum = 1;
        Action historyAction;
        int recordCount = 0;
        public int RecordCount
        {
            set
            {
                if (recordCount != value)
                {
                    recordCount = value;
                    BeginInvoke(new Action(() => { ReadPage(); }));
                }
            }
        }
        public FrmGrowRecord()
        {
            InitializeComponent();
            Load += Timer1_Tick;
            historyAction += dgvAlarm_Data;
        }
        private void FrmGrowRecord_Load(object sender, EventArgs e)
        {
            Record.RecQueue = new Queue<RecordInfo>();
            Record.ReadOut();
            Alarm.LastRealList.Clear();
            if (Record.RecQueue.Count > 0)
            {
                LabDate.Text = Record.RecQueue.ToArray()[0].Time;
            }
            if (Alarm.RealList.Count == 0)
            {
                BeginInvoke(new Action(() => { historyAction(); }));
            }
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            AlarmDisplay();
            LabSOP.Text = Sop.SOPFileName;
            LabFurnaceID.Text = IdNum.FurnaceID;
            LabCrystalID.Text = IdNum.CrystalID;
            LabRunNum.Text = IdNum.RunNumID;
            LabEmployeeID.Text = IdNum.StaffID;
            LblJumpPage.Text = PageNum.ToString();
            if (Record.RecQueue != null)
            {
                int Quotient = Record.RecQueue.Count / 22;
                int Remainder = Record.RecQueue.Count % 22;
                if (Quotient > 0)
                {
                    LabPage.Text = Remainder > 0 ? string.Concat(PageNum.ToString(), "/", (Quotient + 1).ToString()) : string.Concat(PageNum.ToString(), "/", Quotient.ToString());
                }
                else
                {
                    LabPage.Text = string.Concat(PageNum.ToString(), "/", (Quotient + 1).ToString());
                }
                RecordCount = Record.RecQueue.Count;
            }
        }
        private void AlarmDisplay()
        {
            if (!Alarm.RealList.SequenceEqual(Alarm.LastRealList))
            {
                LBCurAlarm.Items.Clear();
                Alarm.LastRealList.Clear();
                foreach (string str in Alarm.RealList)
                {
                    LBCurAlarm.Items.Add(str);
                    Alarm.LastRealList.Add(str);
                }
                BeginInvoke(new Action(() => { historyAction(); }));
            }
        }
        public void ReadPage()
        {
            string TempStr;
            int Length = Record.RecQueue.Count;
            int PageTopRow = (PageNum - 1) * 22;
            int CurrentRow = Length - PageTopRow;
            if (CurrentRow > 22)
            {
                CurrentRow = 22;
            }
            DataGridView1.Rows.Clear();
            if (Length > 0)
            {
                DataGridView1.Rows.Add(CurrentRow);
                int Page_TopRow;
                int Curren_tRow = CurrentRow - 1;
                for (int i = 0; i <= Curren_tRow; i++)
                {
                    Page_TopRow = PageTopRow + i;
                    TempStr = Record.RecQueue.ToArray()[Page_TopRow].Color;
                    switch (TempStr)
                    {
                        case "Red":
                            DataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                            break;
                        case "Green":
                            DataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Green;
                            break;
                        case "Blue":
                            DataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Blue;
                            break;
                        case "Yellow":
                            DataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Yellow;
                            break;
                        case "White":
                            DataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                            break;
                    }
                    DataGridView1.Rows[i].DefaultCellStyle.SelectionForeColor = DataGridView1.Rows[i].DefaultCellStyle.ForeColor;
                    DataGridView1.Rows[i].Cells[0].Value = Record.RecQueue.ToArray()[Page_TopRow].Time;
                    DataGridView1.Rows[i].Cells[1].Value = Record.RecQueue.ToArray()[Page_TopRow].Name;
                    DataGridView1.Rows[i].Cells[2].Value = Record.RecQueue.ToArray()[Page_TopRow].Value;
                }
            }
        }
        private void BtnHomePage_Click(object sender, EventArgs e)
        {
            if (PageNum > 1)
            {
                PageNum = 1;
                ReadPage();
            }
        }
        private void BtnPrePage_Click(object sender, EventArgs e)
        {
            if (PageNum > 1)
            {
                PageNum--;
                ReadPage();
            }
        }
        private void BtnNextPage_Click(object sender, EventArgs e)
        {
            if (PageNum * 22 < Record.RecQueue.Count)
            {
                PageNum++;
                ReadPage();
            }
        }
        private void BtnEndPage_Click(object sender, EventArgs e)
        {
            EndPage();
        }
        private void EndPage()
        {
            int TempPage;
            int Length = Record.RecQueue.Count;
            int Quotient = Length / 22;
            int Remainder = Length % 22;
            if (Quotient > 0)
            {
                TempPage = Remainder > 0 ? Quotient + 1 : Quotient;
            }
            else
            {
                TempPage = Quotient + 1;
            }
            if (PageNum != TempPage)
            {
                PageNum = TempPage;
                ReadPage();
            }
        }
        private void BtnReport_Click(object sender, EventArgs e)
        {
            FrmSwitch.LastFormClose();
            FrmReport fr = new FrmReport();
            FrmSwitch.Open(fr, 101, new Point(0, 130), new Size(1366, 638));
            fr.Show();
            FrmSwitch.LastForm = fr;
        }
        private void BtnSaveRecord_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = "c:\\LICCS\\Record";
            //SaveRecordFileDialog1.Filter = "dat files (*.dat)|*.dat|All files (*.*)|*.*"
            saveFileDialog1.Filter = "csv files (*.csv)|*.csv";
            saveFileDialog1.FilterIndex = 1;
            //获取或设置文件对话框中当前选定筛选器的索引
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.Title = "保存";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.Copy(FileHelper.RecordPath, saveFileDialog1.FileName);
            }
        }
        private void LblJumpPage_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm()
            {
                Location = new Point(483, 140)
            };
            kf.ImportData(ref LblJumpPage, 1, 250);
            kf.ShowDialog();
            if (kf.DialogResult == DialogResult.OK)
            {
                PageNum = Convert.ToInt32(LblJumpPage.Text);
                ReadPage();
            }
        }
        private void dgvAlarm_Data()
        {
            dgvAlarm.DataSource = null;
            dgvAlarm.Columns.Clear();
            dgvAlarm.DefaultCellStyle.Font = new Font("微软雅黑", 10, FontStyle.Regular);
            dgvAlarm.Columns.Add("ID", "序号");
            dgvAlarm.Columns["ID"].DefaultCellStyle.BackColor = Color.Black;
            dgvAlarm.Columns["ID"].DefaultCellStyle.ForeColor = Color.White;
            dgvAlarm.Columns["ID"].Width = 40;
            dgvAlarm.Columns["ID"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvAlarm.Columns["ID"].DataPropertyName = "ID";
            dgvAlarm.Columns.Add("DATE_TIME", "时间");
            dgvAlarm.Columns["DATE_TIME"].Width = 160;
            dgvAlarm.Columns["DATE_TIME"].DefaultCellStyle.BackColor = Color.Black;
            dgvAlarm.Columns["DATE_TIME"].DefaultCellStyle.ForeColor = Color.White;
            dgvAlarm.Columns["DATE_TIME"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvAlarm.Columns["DATE_TIME"].DataPropertyName = "DATE_TIME";
            dgvAlarm.Columns["DATE_TIME"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
            dgvAlarm.Columns.Add("INFO", "告警内容");
            dgvAlarm.Columns["INFO"].Width = 395;
            dgvAlarm.Columns["INFO"].DefaultCellStyle.BackColor = Color.Black;
            dgvAlarm.Columns["INFO"].DefaultCellStyle.ForeColor = Color.White;
            dgvAlarm.Columns["INFO"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvAlarm.Columns["INFO"].DataPropertyName = "INFO";
            string strSql = string.Format("select *from HistoricalAlarm order by DATE_TIME desc limit 0,800");
            using (DataSet ds = SqliteHelper.GetDataSet(strSql, "HistoricalAlarm"))
            {
                if (ds == null || ds.Tables["HistoricalAlarm"].Rows.Count <= 0)
                {
                    return;
                }
                dgvAlarm.DataSource = ds.Tables["HistoricalAlarm"];
                for (int i = 0; i < ds.Tables["HistoricalAlarm"].Rows.Count; i++)
                {
                    dgvAlarm.Rows[i].Cells[0].Value = i + 1;
                }
            }
        }
        private void FrmGrowRecord_FormClosed(object sender, FormClosedEventArgs e)
        {
            Record.RecQueue.Clear();
            Record.RecQueue = null;
            dgvAlarm.Dispose();
            DataGridView1.Dispose();
        }
    }
}
