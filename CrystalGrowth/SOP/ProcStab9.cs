﻿using CrystalGrowth.Unities;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.SOP
{
    internal partial class ProcStab9 : Form
    {
        public ProcStab9()
        {
            InitializeComponent();
            DataGridView1.Rows.Add(20);
            DataGridView1.Rows[0].HeaderCell.Value = "起始晶升速度(mm/hr)";
            DataGridView1.Rows[1].HeaderCell.Value = "直径控制启动延时(s)";
            DataGridView1.Rows[2].HeaderCell.Value = "生长控制启动长度(mm)";
            DataGridView1.Rows[3].HeaderCell.Value = "直径设定变化率(mm/min)";
            DataGridView1.Rows[4].HeaderCell.Value = "取段收尾剩余最小重量(kg)";
            DataGridView1.Rows[5].HeaderCell.Value = "取段收尾触发长度(mm)";
            DataGridView1.Rows[6].HeaderCell.Value = "完结段收尾触发剩余重量(kg)";
            DataGridView1.Rows[7].HeaderCell.Value = "直径偏差报警(mm)";
            DataGridView1.Rows[8].HeaderCell.Value = "断棱检测开始长度(mm)";
            DataGridView1.Rows[9].HeaderCell.Value = "直径控制选择(0=传统 1=智能)";
            DataGridView1.Rows[10].HeaderCell.Value = "生长速度设定变化率(units/min)";
            DataGridView1.Rows[11].HeaderCell.Value = "等径埚升控制选择(0=埚跟比 1=液口距 2=埚跟比+液口距)";
            DataGridView1.Rows[12].HeaderCell.Value = "生长速度偏差范围(mm/h)";
            DataGridView1.Rows[13].HeaderCell.Value = "触发生长速度偏差报警延时(s)";
            DataGridView1.Rows[14].HeaderCell.Value = "生长速度偏差报警后动作(0=不动作 1=退出自动生长控制)";
            DataGridView1.Rows[15].HeaderCell.Value = "取段收尾触发剩余重量百分比(%)";
            DataGridView1.Rows[16].HeaderCell.Value = "生长控制最大调节范围(kw/h)";
            DataGridView1.Rows[17].HeaderCell.Value = "液位补偿系数";
            DataGridView1.Rows[18].HeaderCell.Value = "生长控制只降不升结束长度(mm)";
            DataGridView1.Rows[19].HeaderCell.Value = "防摇功能控制选择(0=关闭 1=开启)";
            DataGridView2.Rows.Add(25);
            for (int i = 1; i <= 25; i++)
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
            DataGridView3.Rows.Add(16);
            for (int i = 1; i <= 16; i++)
            {
                DataGridView3.Rows[i - 1].HeaderCell.Value = i.ToString();
            }
            if (PLC.ReadStatus[57] == 1)
            {
                DataGridView3.Columns[7].Visible = false;
                DataGridView3.Columns[8].Visible = false;
                DataGridView3.Columns[9].Visible = true;
                DataGridView3.Columns[10].Visible = true;
            }
            else
            {
                DataGridView3.Columns[7].Visible = true;
                DataGridView3.Columns[8].Visible = true;
                DataGridView3.Columns[9].Visible = false;
                DataGridView3.Columns[10].Visible = false;
            }
            DataGridView4.Rows.Add(3);
            DataGridView4.Rows[0].HeaderCell.Value = "液口距自动控制长度(mm)";
            DataGridView4.Rows[1].HeaderCell.Value = "液口距保护打开长度(mm)";
            DataGridView4.Rows[2].HeaderCell.Value = "等径头部固定埚升(mm/hr)";
            DataGridView5.Rows.Add(25);
            for (int i = 1; i <= 25; i++)
            {
                DataGridView5.Rows[i - 1].HeaderCell.Value = i.ToString();
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
                    if (Cursor.Position.X >= 658)
                    {
                        sk.ImportData(DataGridView3.CurrentCell, new Point(200, 232));
                    }
                    else
                    {
                        sk.ImportData(DataGridView3.CurrentCell, new Point(768, 232));
                    }
                    sk.ShowDialog();
                }
            }
        }
        private void DataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (Level.PermitModify == false)
                {
                    MessageBox.Show("无设定值修改权限，或已过期需要再次获取权限！");
                    return;
                }
                if (ProcSel.AgreeEdit == 1)
                {
                    SmallKey sk = new SmallKey();
                    sk.ImportData(DataGridView4.CurrentCell, new Point(550, 232));
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
                    if (Cursor.Position.X >= 658)
                    {
                        sk.ImportData(DataGridView5.CurrentCell, new Point(200, 232));
                    }
                    else
                    {
                        sk.ImportData(DataGridView5.CurrentCell, new Point(768, 232));
                    }
                    sk.ShowDialog();
                }
            }
        }
    }
}
