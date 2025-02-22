﻿using CrystalGrowth.CrystalCtl;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.Trend
{
    internal partial class FrmVarSel : Form
    {
        int SelRow = 0;
        int SelFlag = 0;
        public FrmVarSel()
        {
            InitializeComponent();
        }
        private void FrmVarSel_Load(object sender, EventArgs e)
        {
            BtnSelect.Enabled = false;
            DataGridView1.Rows.Add(3);
            DataGridView1.Rows[0].Cells[0].Value = "模拟量输入";
            DataGridView1.Rows[1].Cells[0].Value = "模拟量输出";
            DataGridView1.Rows[2].Cells[0].Value = "计算值";
        }
        private void FrmVarSel_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmTrend.Single.BtnReset();
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (SelFlag == 0)
            {
                FrmTrend.Single.BtnVarSel.Enabled = true;
                Close();
            }
            else if (SelFlag > 0)
            {
                SelFlag = 0;
                BtnSelect.Enabled = false;
                DataGridView1.Rows.Clear();
                DataGridView1.Rows.Add(3);
                DataGridView1.Rows[0].Cells[0].Value = "模拟量输入";
                DataGridView1.Rows[1].Cells[0].Value = "模拟量输出";
                DataGridView1.Rows[2].Cells[0].Value = "计算值";
            }
        }
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelRow = e.RowIndex;
            DataGridView1[0, SelRow].Style.SelectionBackColor = Color.Blue;
            DataGridView1[0, SelRow].Style.SelectionForeColor = Color.White;
            BtnSelect.Enabled = true;
        }
        private void BtnSelect_Click(object sender, EventArgs e)
        {
            switch (SelFlag)
            {
                case 0:
                    BtnSelect.Enabled = false;
                    DataGridView1.Rows.Clear();
                    DataGridView1.Rows.Add(50);
                    switch (SelRow)
                    {
                        case 0:
                            SelFlag = 1;
                            LabVarFlag.Text = "模拟量输入";
                            for (int i = 0; i < 50; i++)
                            {
                                DataGridView1.Rows[i].Cells[0].Value = FrmVarTable.VarStr[151 + i];
                                DataGridView1.Rows[i].Visible = FrmVarTable.VarStr[151 + i] != "";
                            }
                            break;
                        case 1:
                            SelFlag = 2;
                            LabVarFlag.Text = "模拟量输出";
                            for (int i = 0; i < 50; i++)
                            {
                                DataGridView1.Rows[i].Cells[0].Value = FrmVarTable.VarStr[201 + i];
                                DataGridView1.Rows[i].Visible = FrmVarTable.VarStr[201 + i] != "";
                            }
                            break;
                        case 2:
                            SelFlag = 3;
                            LabVarFlag.Text = "计算值";
                            for (int i = 0; i < 50; i++)
                            {
                                DataGridView1.Rows[i].Cells[0].Value = FrmVarTable.VarStr[251 + i];
                                DataGridView1.Rows[i].Visible = FrmVarTable.VarStr[251 + i] != "";
                            }
                            break;
                    }
                    DataGridView1.Visible = true;
                    break;
                case 1:
                    FrmTrend.Single.VarAdd(DataGridView1.Rows[SelRow].Cells[0].Value);
                    break;
                case 2:
                    FrmTrend.Single.VarAdd(DataGridView1.Rows[SelRow].Cells[0].Value);
                    break;
                case 3:
                    FrmTrend.Single.VarAdd(DataGridView1.Rows[SelRow].Cells[0].Value);
                    break;
            }
        }
    }
}
