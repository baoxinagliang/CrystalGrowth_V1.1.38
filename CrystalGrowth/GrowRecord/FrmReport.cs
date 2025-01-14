using CrystalGrowth.Trend;
using CrystalGrowth.Unities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CrystalGrowth.GrowRecord
{
    internal partial class FrmReport : Form
    {
        public static DataTable dt1;
        public static DataTable dt2;
        private readonly DateT dateT1;
        private readonly DateT dateT2;
        public FrmReport()
        {
            InitializeComponent();
            DataGridViewInit();
            dt1 = new DataTable();
            dt2 = new DataTable();
            dateT1 = new DateT();
            dateT2 = new DateT();
        }
        private void FrmReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (FrmHistTrend.Single != null)
            {
                FrmHistTrend.Single.Close();
                FrmHistTrend.Single = null;
            }
            DataGridView1 = null;
            DataGridView2 = null;
            dt1 = null;
            dt2 = null;
        }
        private void FrmReport_Load(object sender, EventArgs e)
        {
            //设置日期选项
            LabTIme1.Text = dateT1.Value.ToString("yyyy-MM-dd HH:mm:ss");
            LabTIme2.Text = dateT2.Value.ToString("yyyy-MM-dd HH:mm:ss");
            CBSelTime1.Checked = false;
            CBSelTime2.Checked = false;
        }
        private void BtnQuit_Click(object sender, EventArgs e)
        {
            FrmSwitch.LastFormClose();
            FrmGrowRecord fgr = new FrmGrowRecord();
            FrmSwitch.Open(fgr, 100, new Point(0, 130), new Size(1366, 638));
            fgr.Show();
            FrmSwitch.LastForm = fgr;
        }
        private void BtnHistTrend_Click(object sender, EventArgs e)
        {
            Hide();
            FrmHistTrend fht = FrmHistTrend.CreateInstrance();
            FrmSwitch.Open(fht, 102, new Point(0, 130), new Size(1366, 638));
            fht.Show();
        }
        private void CBDataFile1_DropDown(object sender, EventArgs e)
        {
            DirectoryInfo Dir = new DirectoryInfo("D:\\LICCS_DB");
            FileInfo[] Files = Dir.GetFiles("*.db3", SearchOption.TopDirectoryOnly);
            int Length = Files.Length;
            CBDataFile1.Items.Clear();
            if (Length > 0)
            {
                for (int i = 0; i < Length; i++)
                {
                    CBDataFile1.Items.Add(Path.GetFileNameWithoutExtension(Files[i].FullName));
                    if (CBDataFile1.Items[i] == CBDataFile1.SelectedItem)
                    {
                        CBDataFile1.SelectedItem = CBDataFile1.Items[i];
                    }
                }
            }
        }
        private void CBDataFile1_DropDownClosed(object sender, EventArgs e)
        {
            if (CBDataFile1.SelectedItem != CBDataFile1.SelectedItem)
            {
                CBSelTime1.Checked = false;
            }
        }
        private void CBSelTime1_Click(object sender, EventArgs e)
        {
            CBSelTime1.Checked = CBSelTime1.Checked == false;
        }
        private void CBSelTime1_CheckedChanged(object sender, EventArgs e)
        {
            CbbSelect1.Enabled = CBSelTime1.Checked ? true : false;
        }
        private void BtnQuery1_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnQuery1))
            {
                LabInfo.Text = "数据加载中，请等待完成！";
                LabInfo.Refresh();
                BtnHistTrend.Enabled = false;
                if (CBDataFile1.SelectedItem == null)
                {
                    MessageBox.Show("请选择要查询的数据文件！");
                    return;
                }
                string DataSource = string.Format("D:\\LICCS_DB\\{0}.db3", CBDataFile1.SelectedItem.ToString());
                //数据库是否存在
                if (File.Exists(DataSource))
                {
                    //连接数据库                    
                    DataQuery(1, string.Format("Data Source={0};Pooling=true;FailIfMissing=false", DataSource));
                }
                BtnHistTrend.Enabled = true;
                LabInfo.Text = "";
            }
        }
        
        private void CBDataFile2_DropDown(object sender, EventArgs e)
        {
            DirectoryInfo Dir = new DirectoryInfo("D:\\LICCS_DB");
            FileInfo[] Files = Dir.GetFiles("*.db3", SearchOption.TopDirectoryOnly);
            int Length = Files.Length;
            CBDataFile2.Items.Clear();
            if (Length > 0)
            {
                for (int i = 0; i < Length; i++)
                {
                    CBDataFile2.Items.Add(Path.GetFileNameWithoutExtension(Files[i].FullName));
                    if (CBDataFile2.Items[i] == CBDataFile2.SelectedItem)
                    {
                        CBDataFile2.SelectedItem = CBDataFile2.Items[i];
                    }
                }
            }
        }
        private void CBDataFile2_DropDownClosed(object sender, EventArgs e)
        {
            if (CBDataFile2.SelectedItem != CBDataFile2.SelectedItem)
            {
                CBSelTime2.Checked = false;
            }
        }
        private void CBSelTime2_Click(object sender, EventArgs e)
        {
            CBSelTime2.Checked = CBSelTime2.Checked == false;
        }
        private void CBSelTime2_CheckedChanged(object sender, EventArgs e)
        {
            CbbSelect2.Enabled = CBSelTime2.Checked ? true : false;
        }
        private void BtnQuery2_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnQuery2))
            {
                LabInfo.Text = "数据加载中，请等待完成！";
                LabInfo.Refresh();
                BtnHistTrend.Enabled = false;
                if (CBDataFile2.SelectedItem == null)
                {
                    MessageBox.Show("请选择要查询的数据文件！");
                    return;
                }
                string DataSource = string.Format("D:\\LICCS_DB\\{0}.db3", CBDataFile2.SelectedItem.ToString());
                //数据库是否存在
                if (File.Exists(DataSource))
                {
                    //数据库查询
                    DataQuery(2, string.Format("Data Source={0};Pooling=true;FailIfMissing=false", DataSource));
                }
                BtnHistTrend.Enabled = true;
                LabInfo.Text = "";
            }
        }
        private void DataQuery(int TabNum, string strConn)
        {
            string StartTime, EndTime, CmdStr;
            switch (TabNum)
            {
                case 1:
                    if (CBSelTime1.Checked)
                    {
                        StartTime = dateT1.Value.AddMinutes(-FrmChangeTime.SpanHistoryTime).ToString("yyyy-MM-dd HH:mm:ss");
                        EndTime = dateT1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        CmdStr = string.Format("SELECT * FROM PROCESS_DATA WHERE DATE_TIME BETWEEN DATETIME('{0}') AND DATETIME('{1}')", StartTime, EndTime);
                    }
                    else
                    {
                        CmdStr = "SELECT * FROM PROCESS_DATA LIMIT 0,43200";
                    }
                    DataGridView1.Rows.Clear();
                    dt1 = SqliteHelper.GetDataTable(strConn, CmdStr);
                    if (dt1.Rows.Count <= 0) { return; }
                    DataGridView1.RowCount = dt1.Rows.Count;
                    break;
                case 2:
                    if (CBSelTime2.Checked)
                    {
                        StartTime = dateT2.Value.AddMinutes(-FrmChangeTime.SpanHistoryTime).ToString("yyyy-MM-dd HH:mm:ss");
                        EndTime = dateT2.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        CmdStr = string.Format("SELECT * FROM PROCESS_DATA WHERE DATE_TIME BETWEEN DATETIME('{0}') AND DATETIME('{1}')", StartTime, EndTime);
                    }
                    else
                    {
                        CmdStr = "SELECT * FROM PROCESS_DATA LIMIT 0,43200";
                    }
                    DataGridView2.Rows.Clear();
                    dt2 = SqliteHelper.GetDataTable(strConn, CmdStr);
                    if (dt2.Rows.Count <= 0) { return; }
                    DataGridView2.RowCount = dt2.Rows.Count;
                    break;
            }
        }
        private void DataGridViewInit()
        {
            foreach (KeyValuePair<string, Para> kvp in TData.Paras)
            {
                DataGridView1.Columns.Add(kvp.Value.Name, kvp.Key);
                DataGridView2.Columns.Add(kvp.Value.Name, kvp.Key);
            }
            DataGridView1.Columns["DATE_TIME"].DataPropertyName = "DATE_TIME";
            DataGridView1.Columns["DATE_TIME"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
            DataGridView1.Columns["DATE_TIME"].Width = 120;
            DataGridView2.Columns["DATE_TIME"].DataPropertyName = "DATE_TIME";
            DataGridView2.Columns["DATE_TIME"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
            DataGridView2.Columns["DATE_TIME"].Width = 120;
        }
        private void DataGridView1_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if (dt1.Rows.Count > 0)
            {
                e.Value = dt1.Rows[e.RowIndex][e.ColumnIndex];
            }
        }
        private void DataGridView2_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if (dt2.Rows.Count > 0)
            {
                e.Value = dt2.Rows[e.RowIndex][e.ColumnIndex];
            }
        }

        private void BtnAdd1_Click(object sender, EventArgs e)
        {
            if (CbbSelect1.SelectedItem != null)
            {
                LabTIme1.Text = dateT1.Add(CbbSelect1.SelectedItem.ToString());
            }
        }

        private void BtnRed1_Click(object sender, EventArgs e)
        {
            if (CbbSelect1.SelectedItem != null)
            {
                LabTIme1.Text = dateT1.Reduce(CbbSelect1.SelectedItem.ToString());
            }
        }

        private void BtnAdd2_Click(object sender, EventArgs e)
        {
            if (CbbSelect2.SelectedItem != null)
            {
                LabTIme2.Text = dateT2.Add(CbbSelect2.SelectedItem.ToString());
            }
        }

        private void BtnRed2_Click(object sender, EventArgs e)
        {
            if (CbbSelect2.SelectedItem != null)
            {
                LabTIme2.Text = dateT2.Reduce(CbbSelect2.SelectedItem.ToString());
            }
        }
    }
}
