﻿using CrystalGrowth.CrystalCtl;
using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction
{
    internal partial class FrmHotZone : Form
    {
        HotEquipmentParts[] hep;
        Action<HotEquipmentParts[], int> hotAction;
        public FrmHotZone()
        {
            InitializeComponent();
            hotAction += FrmHotEditeShow;
            DataGridView1.Rows.Add(17);
            hep = HotHandle.ReadOut();
        }
        private void FrmThermalField_Load(object sender, EventArgs e)
        {
            ReadThermalField();
            HotHandle.WriteIn(hep);
        }
        private void BtnOk_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 17; i++)
            {
                hep[i].Fit = LblFieldSize.Text.Trim();
            }
            HotHandle.WriteIn(hep);
            MessageBox.Show("修改成功！");
        }
        private void ReadThermalField()
        {
            TimeSpan ts;
            for (int i = 0; i < 17; i++)
            {
                DataGridView1.Rows[i].Cells[2].Value = false;
                LblFieldSize.Text = hep[i].Fit;
                DataGridView1.Rows[i].Cells[0].Value = i + 1;//序号
                DataGridView1.Rows[i].Cells[1].Value = hep[i].Name;//热场件名称
                DataGridView1.Rows[i].Cells[3].Value = hep[i].Material;//材质
                DataGridView1.Rows[i].Cells[4].Value = hep[i].Code;//热场件编码
                DataGridView1.Rows[i].Cells[5].Value = hep[i].StartTime;//开始使用日期
                DataGridView1.Rows[i].Cells[6].Value = hep[i].RatedDays;//额定使用寿命(天)
                if (hep[i].Flag == "true")
                {
                    ts = DateTime.Now.Subtract(Convert.ToDateTime(hep[i].StartTime));
                    hep[i].UsageTime = ts.Days.ToString();
                    DataGridView1.Rows[i].Cells[7].Value = ts.Days.ToString();//使用时间(天)
                }
                else
                {
                    DataGridView1.Rows[i].Cells[7].Value = hep[i].UsageTime;//使用时间(天)
                }
                DataGridView1.Rows[i].Cells[8].Value = hep[i].ChangeReason;//更换原因
                DataGridView1.Rows[i].Cells[9].Value = hep[i].GhangeTime;//更换日期
                if (Convert.ToInt32(hep[i].UsageTime) >= Convert.ToInt32(hep[i].RatedDays))
                {
                    DataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    DataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                }
            }
        }
        private void LblFieldSize_DoubleClick(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm
            {
                Location = new Point(400, 130)
            };
            kf.ImportData(ref LblFieldSize, 0, 50);
            kf.ShowDialog();
        }
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                if (DataGridView1.CurrentCell.EditedFormattedValue.ToString() == "False")
                {
                    DataGridView1.EndEdit();
                    DataGridView1.CurrentCell.Value = true;
                    BeginInvoke(hotAction, hep, e.RowIndex);
                }
            }
        }
        private void FrmHotEditeShow(HotEquipmentParts[] hep, int index)
        {
            FrmHotEdite fhe = new FrmHotEdite(hep, index);
            fhe.ShowDialog();
            if (fhe.DialogResult == DialogResult.OK)
            {
                HotHandle.ReadOut();
                ReadThermalField();
            }
            else
            {
                if (DataGridView1.CurrentCell != null)
                {
                    DataGridView1.CurrentCell.Value = "False";
                }
            }
        }
        private void FrmHotZone_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["FrmHotEdite"] != null) { Application.OpenForms["FrmHotEdite"].Close(); }
            if (Application.OpenForms["FrmHotHistory"] != null) { Application.OpenForms["FrmHotHistory"].Close(); }
            hep = null;
        }
        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 2 && e.RowIndex >= 0 && e.RowIndex <= 16)
            {
                FrmHotHistory fhe = new FrmHotHistory(hep[e.RowIndex].Name);
                fhe.ShowDialog();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            HotHandle.IsStart = "true";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            HotHandle.IsStart = "false";
        }
    }
}
