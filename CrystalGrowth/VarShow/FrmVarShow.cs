using CrystalGrowth.CrystalCtl;
using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.VarShow
{
    internal partial class FrmVarShow : Form
    {
        int SelRow = 0, SelRow1 = 0;
        public FrmVarShow()
        {
            InitializeComponent();
        }
        private void FrmVarShow_Load(object sender, EventArgs e)
        {
            DataGridView1.Rows.Add(5);
            DataGridView1.Rows[0].Cells[0].Value = "数字量输入";
            DataGridView1.Rows[1].Cells[0].Value = "数字量输出";
            DataGridView1.Rows[2].Cells[0].Value = "模拟量输入";
            DataGridView1.Rows[3].Cells[0].Value = "模拟量输出";
            DataGridView1.Rows[4].Cells[0].Value = "计算值";
            DataGridView2.Rows.Add(21);
            for (int i = 0; i < 21; i++)
            {
                DataGridView2.Rows[i].Cells[0].Value = FrmVarTable.Single.DataGridView1.Rows[i].Cells[0].Value;
            }
            BtnAddTo.Visible = false;
            LabVarFlag.Visible = false;
            DataGridView3.Visible = false;
        }
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelRow = e.RowIndex;
            BtnAddTo.Enabled = false;
            BtnAddTo.Visible = true;
            LabVarFlag.Visible = true;
            SelRow = e.RowIndex;
            DataGridView1[0, e.RowIndex].Style.SelectionBackColor = Color.Blue;
            DataGridView1[0, e.RowIndex].Style.SelectionForeColor = Color.White;
            DataGridView3.Rows.Clear();
            switch (e.RowIndex)
            {
                case 0:
                    LabVarFlag.Text = "数字量输入";
                    DataGridView3.Rows.Add(100);
                    int ii;
                    for (int i = 0; i < 100; i++)
                    {
                        ii = i + 1;
                        DataGridView3.Rows[i].Cells[0].Value = FrmVarTable.VarStr[ii];
                        DataGridView3.Rows[i].Visible = FrmVarTable.VarStr[ii] != "";
                    }
                    break;
                case 1:
                    LabVarFlag.Text = "数字量输出";
                    DataGridView3.Rows.Add(50);
                    for (int i = 0; i < 50; i++)
                    {
                        DataGridView3.Rows[i].Cells[0].Value = FrmVarTable.VarStr[101 + i];
                        DataGridView3.Rows[i].Visible = FrmVarTable.VarStr[101 + i] != "";
                    }
                    break;
                case 2:
                    LabVarFlag.Text = "模拟量输入";
                    DataGridView3.Rows.Add(50);
                    for (int i = 0; i < 50; i++)
                    {
                        DataGridView3.Rows[i].Cells[0].Value = FrmVarTable.VarStr[151 + i];
                        DataGridView3.Rows[i].Visible = FrmVarTable.VarStr[151 + i] != "";
                    }
                    break;
                case 3:
                    LabVarFlag.Text = "模拟量输出";
                    DataGridView3.Rows.Add(50);
                    for (int i = 0; i < 50; i++)
                    {
                        DataGridView3.Rows[i].Cells[0].Value = FrmVarTable.VarStr[201 + i];
                        DataGridView3.Rows[i].Visible = FrmVarTable.VarStr[201 + i] != "";
                    }
                    break;
                case 4:
                    LabVarFlag.Text = "计算值";
                    DataGridView3.Rows.Add(50);
                    for (int i = 0; i < 50; i++)
                    {
                        DataGridView3.Rows[i].Cells[0].Value = FrmVarTable.VarStr[251 + i];
                        DataGridView3.Rows[i].Visible = FrmVarTable.VarStr[251 + i] != "";
                    }
                    break;
            }
            DataGridView3.Visible = true;
        }
        private void DataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelRow1 = e.RowIndex;
            DataGridView3[0, e.RowIndex].Style.SelectionBackColor = Color.Blue;
            DataGridView3[0, e.RowIndex].Style.SelectionForeColor = Color.White;
            BtnAddTo.Enabled = true;
        }
        private void BtnAddTo_Click(object sender, EventArgs e)
        {
            switch (SelRow)
            {
                case 0:
                    VarAdd(SelRow1, 1);
                    break;
                case 1:
                    VarAdd(SelRow1, 2);
                    break;
                case 2:
                    VarAdd(SelRow1, 3);
                    break;
                case 3:
                    VarAdd(SelRow1, 4);
                    break;
                case 4:
                    VarAdd(SelRow1, 5);
                    break;
                default:
                    return;
            }
        }
        private void VarAdd(int RowNum, int VarType)
        {
            int VarExist = 0;
            for (int i = 1; i <= 21; i++)
            {
                if (DataGridView2.Rows[i - 1].Cells[0].Value == DataGridView3.Rows[RowNum].Cells[0].Value)
                {
                    VarExist = 1;
                    DataGridView2.Rows[i - 1].Cells[0].Value = "";
                    FrmVarTable.VarIndex[i] = 0;
                    break;
                }
            }
            if (VarExist == 0)
            {
                for (int i = 1; i <= 21; i++)
                {
                    if (DataGridView2.Rows[i - 1].Cells[0].Value.ToString().Length == 0)
                    {
                        switch (VarType)
                        {
                            case 1:
                                FrmVarTable.VarIndex[i] = SelRow1 + 1;
                                break;
                            case 2:
                                FrmVarTable.VarIndex[i] = SelRow1 + 101;
                                break;
                            case 3:
                                FrmVarTable.VarIndex[i] = SelRow1 + 151;
                                break;
                            case 4:
                                FrmVarTable.VarIndex[i] = SelRow1 + 201;
                                break;
                            case 5:
                                FrmVarTable.VarIndex[i] = SelRow1 + 251;
                                break;
                        }
                        DataGridView2.Rows[i - 1].Cells[0].Value = FrmVarTable.VarStr[FrmVarTable.VarIndex[i]];
                        break;
                    }
                }
            }
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnClear))
            {
                for (int i = 1; i <= 21; i++)
                {
                    DataGridView2.Rows[i - 1].Cells[0].Value = "";
                    FrmVarTable.VarIndex[i] = 0;
                }
            }
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnSave))
            {
                FrmVarTable.SaveVarFile();
                FrmVarTable.Single.SelectVarFile();
            }
        }
    }
}
