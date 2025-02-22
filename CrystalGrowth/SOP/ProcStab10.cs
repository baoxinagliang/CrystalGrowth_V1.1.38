﻿using CrystalGrowth.Unities;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.SOP
{
    internal partial class ProcStab10 : Form
    {
        public ProcStab10()
        {
            InitializeComponent();
            DataGridView1.Rows.Add(15);
            DataGridView1.Rows[0].HeaderCell.Value = "收尾晶升速度选择(0=比例,1=偏移量)";
            DataGridView1.Rows[1].HeaderCell.Value = "起始晶升速度(0=实际生长速度 ；1=设定生长速度 2=设定起始晶升)";
            DataGridView1.Rows[2].HeaderCell.Value = "设定起始晶升(mm/hr)";
            DataGridView1.Rows[3].HeaderCell.Value = "重量变化率采样周期(设定范围：2-30min)";
            DataGridView1.Rows[4].HeaderCell.Value = "提示取段收尾完成时间(min)";
            DataGridView1.Rows[5].HeaderCell.Value = "提示取段收尾完成长度(mm)";
            DataGridView1.Rows[6].HeaderCell.Value = "提示完结段收尾完成时间(min)";
            DataGridView1.Rows[7].HeaderCell.Value = "提示完结段收尾完成长度(mm)";
            for (int i = 8; i <= 14; i++)
            {
                DataGridView1.Rows[i].Visible = false;
            }
            DataGridView2.Rows.Add(20);
            for (int i = 1; i <= 20; i++)
            {
                DataGridView2.Rows[i - 1].HeaderCell.Value = i.ToString();
            }
            if (PLC.ReadStatus[57] == 1)
            {
                DataGridView2.Columns[3].Visible = false;
                DataGridView2.Columns[4].Visible = true;
            }
            else
            {
                DataGridView2.Columns[3].Visible = true;
                DataGridView2.Columns[4].Visible = false;
            }
            DataGridView3.Rows.Add(5);
            DataGridView3.Rows[0].HeaderCell.Value = "直径设定变化率(mm/min)";
            DataGridView3.Rows[1].HeaderCell.Value = "生长速度阈值(mm/hr)";
            DataGridView3.Rows[2].HeaderCell.Value = "主加热功率变化量(kw)";
            DataGridView3.Rows[3].Visible = false;
            DataGridView3.Rows[4].Visible = false;
            DataGridView4.Rows.Add(10);
            for (int i = 1; i <= 10; i++)
            {
                DataGridView4.Rows[i - 1].HeaderCell.Value = i.ToString();
            }
            DataGridView5.Rows.Add(10);
            DataGridView5.Rows[0].HeaderCell.Value = "直径控制-增益";
            DataGridView5.Rows[1].HeaderCell.Value = "直径控制-微分(min)";
            DataGridView5.Rows[2].HeaderCell.Value = "直径控制-积分(1/min)";
            DataGridView5.Rows[3].HeaderCell.Value = "直径控制-晶升上限(mm/hr)";
            DataGridView5.Rows[4].HeaderCell.Value = "直径控制-晶升下限(mm/hr)";
            for (int i = 5; i < 10; i++)
            {
                DataGridView5.Rows[i].Visible = false;
            }
            DataGridView6.Rows.Add(20);
            for (int i = 1; i <= 20; i++)
            {
                DataGridView6.Rows[i - 1].HeaderCell.Value = i.ToString();
            }
            if (PLC.ReadStatus[57] == 1)
            {
                DataGridView6.Columns[3].Visible = false;
                DataGridView6.Columns[4].Visible = true;
            }
            else
            {
                DataGridView6.Columns[3].Visible = true;
                DataGridView6.Columns[4].Visible = false;
            }
        }
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (ProcSel.AgreeEdit == 1)
                {
                    SmallKey sk = new SmallKey();
                    sk.ImportData(DataGridView1.CurrentCell, new Point(550, 232));
                    sk.ShowDialog();
                }
            }
        }
        private void DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (ProcSel.AgreeEdit == 1)
                {
                    SmallKey sk = new SmallKey();
                    if (Cursor.Position.X >= 658)
                    {
                        sk.ImportData(DataGridView2.CurrentCell, new Point(200, 232));
                    }
                    else
                    {
                        sk.ImportData(DataGridView2.CurrentCell, new Point(768, 232));
                    }
                    sk.ShowDialog();
                }
            }
        }
        private void DataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (ProcSel.AgreeEdit == 1)
                {
                    SmallKey sk = new SmallKey();
                    sk.ImportData(DataGridView3.CurrentCell, new Point(550, 232));
                    sk.ShowDialog();
                }
            }
        }
        private void DataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (ProcSel.AgreeEdit == 1)
                {
                    SmallKey sk = new SmallKey();
                    if (Cursor.Position.X >= 658)
                    {
                        sk.ImportData(DataGridView4.CurrentCell, new Point(200, 232));
                    }
                    else
                    {
                        sk.ImportData(DataGridView4.CurrentCell, new Point(768, 232));
                    }
                    sk.ShowDialog();
                }
            }
        }
        private void DataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (ProcSel.AgreeEdit == 1)
                {
                    SmallKey sk = new SmallKey();
                    sk.ImportData(DataGridView5.CurrentCell, new Point(550, 232));
                    sk.ShowDialog();
                }
            }
        }
        private void DataGridView6_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                SmallKey sk = new SmallKey();
                if (ProcSel.AgreeEdit == 1)
                {
                    if (Cursor.Position.X >= 658)
                    {
                        sk.ImportData(DataGridView6.CurrentCell, new Point(200, 232));
                    }
                    else
                    {
                        sk.ImportData(DataGridView6.CurrentCell, new Point(768, 232));
                    }
                    sk.ShowDialog();
                }
            }
        }
    }
}
