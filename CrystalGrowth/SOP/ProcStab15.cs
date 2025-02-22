﻿using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.SOP
{
    internal partial class ProcStab15 : Form
    {
        public ProcStab15()
        {
            InitializeComponent();
            DataGridView1.Rows.Add(24);
            DataGridView1.Rows[0].HeaderCell.Value = "取段晶转设定(rpm)";
            DataGridView1.Rows[1].HeaderCell.Value = "取段埚位下降距离(mm)";
            DataGridView1.Rows[2].HeaderCell.Value = "取段保压压力(torr)";
            DataGridView1.Rows[3].HeaderCell.Value = "取段保压时间(min)";
            DataGridView1.Rows[4].HeaderCell.Value = "取段副室上升超时时间(s)";
            DataGridView1.Rows[5].HeaderCell.Value = "取段晶体上升距离(mm)";
            DataGridView1.Rows[6].HeaderCell.Value = "取段晶体下降距离(mm)";
            DataGridView1.Rows[7].HeaderCell.Value = "取段触发保压长度(mm)";
            for (int i = 8; i <= 11; i++)
            {
                DataGridView1.Rows[i].Visible = false;
            }
            DataGridView1.Rows[12].HeaderCell.Value = "取段加料埚转设定(rpm)";
            DataGridView1.Rows[13].HeaderCell.Value = "取段加料主加功率偏移量,基于引晶功率(kw)";
            DataGridView1.Rows[14].HeaderCell.Value = "取段加料底加功率设定(kw)";
            DataGridView1.Rows[15].HeaderCell.Value = "取段调温埚转设定(rpm)";
            DataGridView1.Rows[16].HeaderCell.Value = "取段调温主加功率偏移量,基于引晶功率(kw)";
            DataGridView1.Rows[17].HeaderCell.Value = "取段调温底加功率设定(kw)";
            DataGridView1.Rows[18].HeaderCell.Value = "取段结晶加料埚转设定(rpm)";
            DataGridView1.Rows[19].HeaderCell.Value = "取段结晶加料主加功率偏移量,基于引晶功率(kw)";
            DataGridView1.Rows[20].HeaderCell.Value = "取段结晶加料底加功率设定(kw)";
            DataGridView1.Rows[21].HeaderCell.Value = "取段结晶加料功率回调延时(s)";
            DataGridView1.Rows[22].HeaderCell.Value = "取段结晶加料主加回调功率偏移量,基于引晶功率(kw)";
            DataGridView1.Rows[23].HeaderCell.Value = "取段结晶加料底加回调功率(kw)";
            DataGridView2.Rows.Add(8);
            for (int i = 0; i < 8; i++)
            {
                DataGridView2.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
            DataGridView3.Rows.Add(10);
            for (int i = 0; i < 10; i++)
            {
                DataGridView3.Rows[i].HeaderCell.Value = (i + 1).ToString();
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
                        if (e.ColumnIndex == 1)
                        {
                            sk.ImportData(DataGridView3.CurrentCell, new Point(200, 232), 2);
                        }
                        else
                        {
                            sk.ImportData(DataGridView3.CurrentCell, new Point(200, 232));
                        }
                    }
                    else
                    {
                        if (e.ColumnIndex == 1)
                        {
                            sk.ImportData(DataGridView3.CurrentCell, new Point(768, 232), 2);
                        }
                        else
                        {
                            sk.ImportData(DataGridView3.CurrentCell, new Point(768, 232));
                        }
                    }
                    sk.ShowDialog();
                }
            }
        }
    }
}
