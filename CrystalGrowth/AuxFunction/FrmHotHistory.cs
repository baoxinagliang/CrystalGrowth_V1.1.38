﻿using CrystalGrowth.Unities;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction
{
    internal partial class FrmHotHistory : Form
    {
        private readonly string HotName = "";
        public FrmHotHistory(string name)
        {
            InitializeComponent();
            HotName = name;
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void FrmHotHistory_Load(object sender, EventArgs e)
        {
            BeginInvoke(new Action(() =>
            {
                dgvHistory.DataSource = null;
                dgvHistory.Columns.Clear();
                dgvHistory.DefaultCellStyle.Font = new Font("微软雅黑", 10, FontStyle.Regular);
                dgvHistory.Columns.Add("ID", "序号");
                dgvHistory.Columns["ID"].DefaultCellStyle.BackColor = Color.Black;
                dgvHistory.Columns["ID"].DefaultCellStyle.ForeColor = Color.White;
                dgvHistory.Columns["ID"].Width = 40;
                dgvHistory.Columns["ID"].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvHistory.Columns["ID"].DataPropertyName = "ID";
                dgvHistory.Columns.Add("DATE_TIME", "时间");
                dgvHistory.Columns["DATE_TIME"].Width = 120;
                dgvHistory.Columns["DATE_TIME"].DefaultCellStyle.BackColor = Color.Black;
                dgvHistory.Columns["DATE_TIME"].DefaultCellStyle.ForeColor = Color.White;
                dgvHistory.Columns["DATE_TIME"].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvHistory.Columns["DATE_TIME"].DataPropertyName = "DATE_TIME";
                dgvHistory.Columns["DATE_TIME"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
                dgvHistory.Columns.Add("NAME", "热场件名称");
                dgvHistory.Columns["NAME"].Width = 80;
                dgvHistory.Columns["NAME"].DefaultCellStyle.BackColor = Color.Black;
                dgvHistory.Columns["NAME"].DefaultCellStyle.ForeColor = Color.White;
                dgvHistory.Columns["NAME"].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvHistory.Columns["NAME"].DataPropertyName = "NAME";
                dgvHistory.Columns.Add("MATEIAL", "材料");
                dgvHistory.Columns["MATEIAL"].Width = 80;
                dgvHistory.Columns["MATEIAL"].DefaultCellStyle.BackColor = Color.Black;
                dgvHistory.Columns["MATEIAL"].DefaultCellStyle.ForeColor = Color.White;
                dgvHistory.Columns["MATEIAL"].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvHistory.Columns["MATEIAL"].DataPropertyName = "MATEIAL";
                dgvHistory.Columns.Add("CODE", "热场件编码");
                dgvHistory.Columns["CODE"].Width = 80;
                dgvHistory.Columns["CODE"].DefaultCellStyle.BackColor = Color.Black;
                dgvHistory.Columns["CODE"].DefaultCellStyle.ForeColor = Color.White;
                dgvHistory.Columns["CODE"].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvHistory.Columns["CODE"].DataPropertyName = "CODE";
                dgvHistory.Columns.Add("STARTTIME", "开始使用时间");
                dgvHistory.Columns["STARTTIME"].Width = 120;
                dgvHistory.Columns["STARTTIME"].DefaultCellStyle.BackColor = Color.Black;
                dgvHistory.Columns["STARTTIME"].DefaultCellStyle.ForeColor = Color.White;
                dgvHistory.Columns["STARTTIME"].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvHistory.Columns["STARTTIME"].DataPropertyName = "STARTTIME";
                dgvHistory.Columns["STARTTIME"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
                dgvHistory.Columns.Add("RATEDDAYS", "额定时间");
                dgvHistory.Columns["RATEDDAYS"].Width = 70;
                dgvHistory.Columns["RATEDDAYS"].DefaultCellStyle.BackColor = Color.Black;
                dgvHistory.Columns["RATEDDAYS"].DefaultCellStyle.ForeColor = Color.White;
                dgvHistory.Columns["RATEDDAYS"].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvHistory.Columns["RATEDDAYS"].DataPropertyName = "RATEDDAYS";
                dgvHistory.Columns.Add("USAGETIME", "使用时间");
                dgvHistory.Columns["USAGETIME"].Width = 70;
                dgvHistory.Columns["USAGETIME"].DefaultCellStyle.BackColor = Color.Black;
                dgvHistory.Columns["USAGETIME"].DefaultCellStyle.ForeColor = Color.White;
                dgvHistory.Columns["USAGETIME"].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvHistory.Columns["USAGETIME"].DataPropertyName = "USAGETIME";
                dgvHistory.Columns.Add("CHANGEREASON", "更换原因");
                dgvHistory.Columns["CHANGEREASON"].Width = 80;
                dgvHistory.Columns["CHANGEREASON"].DefaultCellStyle.BackColor = Color.Black;
                dgvHistory.Columns["CHANGEREASON"].DefaultCellStyle.ForeColor = Color.White;
                dgvHistory.Columns["CHANGEREASON"].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvHistory.Columns["CHANGEREASON"].DataPropertyName = "CHANGEREASON";
                dgvHistory.Columns.Add("GHANGETIME", "更换时间");
                dgvHistory.Columns["GHANGETIME"].Width = 120;
                dgvHistory.Columns["GHANGETIME"].DefaultCellStyle.BackColor = Color.Black;
                dgvHistory.Columns["GHANGETIME"].DefaultCellStyle.ForeColor = Color.White;
                dgvHistory.Columns["GHANGETIME"].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvHistory.Columns["GHANGETIME"].DataPropertyName = "GHANGETIME";
                dgvHistory.Columns["GHANGETIME"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
                string strSql = string.Format("select *from HOT_DATA where NAME='{0}' order by DATE_TIME desc limit 0,100 ", HotName);
                using (DataTable dt = SqliteHelper.GetDataTable(strSql))
                {
                    if (dt == null || dt.Rows.Count <= 0)
                    {
                        return;
                    }
                    dgvHistory.DataSource = dt;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dgvHistory.Rows[i].Cells[0].Value = i + 1;
                    }
                }
            }));
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            string strSql = string.Format("DELETE from HOT_DATA where NAME='{0}'", HotName);
            SqliteHelper.ExecDataBySql(strSql);
            FrmHotHistory_Load(sender, e);
        }
    }
}
