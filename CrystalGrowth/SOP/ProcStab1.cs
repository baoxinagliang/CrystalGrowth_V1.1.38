using CrystalGrowth.CrystalCtl;
using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.SOP
{
    internal partial class ProcStab1 : Form
    {
        public ProcStab1()
        {
            InitializeComponent();
            DataGridView1.Rows.Add(15);
            DataGridView1.Rows[0].HeaderCell.Value = "晶向";
            DataGridView1.Rows[1].HeaderCell.Value = "初始投料重量(kg)";
            DataGridView1.Rows[2].HeaderCell.Value = "初始液面到加热器平口距离(mm)";
            DataGridView1.Rows[3].HeaderCell.Value = "启动燃烧阀(1=是 0=否)";
            DataGridView1.Rows[3].Visible = false;
            DataGridView1.Rows[4].HeaderCell.Value = "视觉液口距补偿直径(1=是 0=否)";
            DataGridView1.Rows[5].HeaderCell.Value = "视觉液口距调节高度限值(mm)";
            DataGridView1.Rows[6].HeaderCell.Value = "液口距权重(0.00 - 1.00)";
            DataGridView1.Rows[6].Visible = false;
            DataGridView1.Rows[7].HeaderCell.Value = "埚跟比权重(0.00 - 1.00)";
            DataGridView1.Rows[7].Visible = false;
            DataGridView1.Rows[8].HeaderCell.Value = "液口距微调上限( 0 - 20)(mm/hr)";
            DataGridView1.Rows[9].HeaderCell.Value = "液口距微调下限(-20 - 0)(mm/hr)";
            DataGridView1.Rows[10].HeaderCell.Value = "最大加料警告量(kg)";
            DataGridView1.Rows[11].HeaderCell.Value = "最大加料量(kg)";
            DataGridView1.Rows[12].HeaderCell.Value = "放肩工艺选择(0=斜率表 1=角度)";
            DataGridView1.Rows[13].HeaderCell.Value = "石英坩埚内直径(mm)";
            DataGridView1.Rows[14].HeaderCell.Value = "一米钨丝绳重量(kg/m)";
            DataGridView2.Rows.Add(26);
            DataGridView2.Rows[0].HeaderCell.Value = "重量液口距保护值(mm)";
            DataGridView2.Rows[1].HeaderCell.Value = "视觉液口距保护值(mm)";
            DataGridView2.Rows[2].HeaderCell.Value = "开关隔离阀保护籽晶位置(mm)";
            DataGridView2.Rows[3].HeaderCell.Value = "晶升空载保护重量(kg)";
            DataGridView2.Rows[4].HeaderCell.Value = "晶升过载保护重量(kg)";
            DataGridView2.Rows[5].HeaderCell.Value = "停电保护延时(s)";
            DataGridView2.Rows[6].HeaderCell.Value = "停水保护最小热屏水流量(lpm)";
            DataGridView2.Rows[7].HeaderCell.Value = "停水保护延时(s)";
            DataGridView2.Rows[8].HeaderCell.Value = "主室压力异常检测值(torr)";
            DataGridView2.Rows[9].HeaderCell.Value = "主室压力异常保护值(torr)";
            DataGridView2.Rows[10].HeaderCell.Value = "停水停电紧急保护按钮状态下动作，坩埚下降距离(mm)";
            DataGridView2.Rows[11].HeaderCell.Value = "紧急处理晶体慢升速度(mm/hr)";
            DataGridView2.Rows[12].HeaderCell.Value = "紧急处理晶体慢升时间(s)";
            DataGridView2.Rows[13].HeaderCell.Value = "停水停电超压紧急保护按钮状态下动作，晶体提升高度(mm)";
            DataGridView2.Rows[14].HeaderCell.Value = "停水停电超压紧急保护按钮状态下动作，热屏提升距离(mm)";
            //change by 张健溥 
            DataGridView2.Rows[10].Visible = false;
            DataGridView2.Rows[11].Visible = false;
            DataGridView2.Rows[12].Visible = false;
            DataGridView2.Rows[13].Visible = false;
            DataGridView2.Rows[14].Visible = false;
            DataGridView2.Rows[15].HeaderCell.Value = "失重保护触发重量(kg)";
            DataGridView2.Rows[16].HeaderCell.Value = "失重保护提示时间(s)";
            DataGridView2.Rows[17].HeaderCell.Value = "低负载允许晶升速度≤36000(mm/hr)";
            DataGridView2.Rows[18].HeaderCell.Value = "高负载允许晶升速度≤30000(mm/hr)";
            DataGridView2.Rows[19].HeaderCell.Value = "高低负载限定值-建议150(kg)";
            if (Level.PermitModify == false)
            {
                DataGridView2.Rows[17].Visible = false;
                DataGridView2.Rows[18].Visible = false;
                DataGridView2.Rows[19].Visible = false;
            }
            else
            {
                DataGridView2.Rows[17].Visible = true;
                DataGridView2.Rows[18].Visible = true;
                DataGridView2.Rows[19].Visible = true;
            }
            DataGridView2.Rows[20].HeaderCell.Value = "晶升外部保护(1=开启 0=关闭)";
            DataGridView2.Rows[21].HeaderCell.Value = "埚升外部保护(1=开启 0=关闭)";
            DataGridView2.Rows[22].HeaderCell.Value = "热屏高速(拆炉)(mm/h)";
            DataGridView2.Rows[23].HeaderCell.Value = "热屏低速(合炉)(mm/h)";
            DataGridView2.Rows[24].HeaderCell.Value = "坩埚快升允许最大液面高度(mm)";
            DataGridView2.Rows[25].HeaderCell.Value = "小失重保护触发重量(kg)";
            DataGridView3.Rows.Add(20);
            DataGridView3.Rows[0].HeaderCell.Value = "重量液口距预警值(mm)";
            DataGridView3.Rows[1].HeaderCell.Value = "视觉液口距预警值(mm)";
            DataGridView3.Rows[2].HeaderCell.Value = "主室压力报警值(torr)";
            DataGridView3.Rows[3].HeaderCell.Value = "水冷屏流量报警值(lpm)";
            DataGridView3.Rows[4].HeaderCell.Value = "水冷屏温度报警值(degC)";
            DataGridView3.Rows[5].HeaderCell.Value = "主加热最小电阻报警值(mohm)";
            DataGridView3.Rows[6].HeaderCell.Value = "主加热最大电阻报警值(mohm)";
            DataGridView3.Rows[7].HeaderCell.Value = "底部加热最小电阻报警值(mohm)";
            DataGridView3.Rows[8].HeaderCell.Value = "底部加热最大电阻报警值(mohm)";
            DataGridView3.Rows[9].HeaderCell.Value = "热屏位置上限报警值(mm)";
            DataGridView3.Rows[10].HeaderCell.Value = "热屏位置下限报警值(mm)";
            DataGridView3.Rows[11].HeaderCell.Value = "液口距保护屏蔽时间(s)";
            DataGridView3.Rows[12].HeaderCell.Value = "真空管道超温报警值(degC)";
            DataGridView3.Rows[13].HeaderCell.Value = "晶升保护位置(mm)";
            DataGridView3.Rows[14].HeaderCell.Value = "晶升保护速度(mm/h)";
            for (int i = 15; i <= 19; i++)
            {
                DataGridView3.Rows[i].Visible = false;
            }
            DataGridView4.Rows.Add(10);
            for (int i = 0; i < 10; i++)
            {
                DataGridView4.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
            DataGridView5.Rows.Add(55);
            DataGridView5.Rows[0].HeaderCell.Value = "断市电紧急安全坩埚下降行程(mm)";
            DataGridView5.Rows[1].HeaderCell.Value = "断市电紧急安全晶升慢速升速度(mm/h)";
            DataGridView5.Rows[2].HeaderCell.Value = "断市电紧急安全晶升慢速升时间(s)";
            DataGridView5.Rows[3].HeaderCell.Value = "断市电紧急安全晶升提升行程(mm)";
            DataGridView5.Rows[4].HeaderCell.Value = "断市电紧急安全热屏提升行程(mm)";
            for (int i = 5; i < 10; i++)
            {
                DataGridView5.Rows[i].Visible = false;
            }
            DataGridView5.Rows[10].HeaderCell.Value = "断水紧急安全坩埚下降行程(mm)";
            DataGridView5.Rows[11].HeaderCell.Value = "断水紧急安全晶升慢速升速度(mm/h)";
            DataGridView5.Rows[12].HeaderCell.Value = "断水紧急安全晶升慢速升时间(s)";
            DataGridView5.Rows[13].HeaderCell.Value = "断水紧急安全晶升提升行程(mm)";
            DataGridView5.Rows[14].HeaderCell.Value = "断水紧急安全热屏提升行程(mm)";
            for (int i = 15; i < 20; i++)
            {
                DataGridView5.Rows[i].Visible = false;
            }
            DataGridView5.Rows[20].HeaderCell.Value = "炉压高紧急安全坩埚下降行程(mm)";
            DataGridView5.Rows[21].HeaderCell.Value = "炉压高紧急安全晶升慢速升速度(mm/h)";
            DataGridView5.Rows[22].HeaderCell.Value = "炉压高紧急安全晶升慢速升时间(s)";
            DataGridView5.Rows[23].HeaderCell.Value = "炉压高紧急安全晶升提升行程(mm)";
            DataGridView5.Rows[24].HeaderCell.Value = "炉压高紧急安全热屏提升行程(mm)";
            for (int i = 25; i < 30; i++)
            {
                DataGridView5.Rows[i].Visible = false;
            }
            DataGridView5.Rows[30].HeaderCell.Value = "失重紧急安全坩埚下降行程(mm)";
            DataGridView5.Rows[31].HeaderCell.Value = "失重紧急安全晶升慢速升速度(mm/h)";
            DataGridView5.Rows[32].HeaderCell.Value = "失重紧急安全晶升慢速升时间(s)";
            DataGridView5.Rows[33].HeaderCell.Value = "失重紧急安全晶升提升行程(mm)";
            DataGridView5.Rows[34].HeaderCell.Value = "失重紧急安全热屏提升行程(mm)";
            for (int i = 35; i < 40; i++)
            {
                DataGridView5.Rows[i].Visible = false;
            }
            DataGridView5.Rows[40].HeaderCell.Value = "小失重紧急安全坩埚下降行程(mm)";
            DataGridView5.Rows[41].HeaderCell.Value = "小失重紧急安全晶升慢速升速度(mm/h)";
            DataGridView5.Rows[42].HeaderCell.Value = "小失重紧急安全晶升慢速升时间(s)";
            DataGridView5.Rows[43].HeaderCell.Value = "小失重紧急安全晶升提升行程(mm)";
            DataGridView5.Rows[44].HeaderCell.Value = "小失重紧急安全热屏提升行程(mm)";
            for (int i = 45; i < 50; i++)
            {
                DataGridView5.Rows[i].Visible = false;
            }
            DataGridView5.Rows[50].HeaderCell.Value = "手动紧急安全坩埚下降行程(mm)";
            DataGridView5.Rows[51].HeaderCell.Value = "手动紧急安全晶升慢速升速度(mm/h)";
            DataGridView5.Rows[52].HeaderCell.Value = "手动紧急安全晶升慢速升时间(s)";
            DataGridView5.Rows[53].HeaderCell.Value = "手动紧急安全晶升提升行程(mm)";
            DataGridView5.Rows[54].HeaderCell.Value = "手动紧急安全热屏提升行程(mm)";
        }
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (ProcSel.AgreeEdit == 1)
                {
                    SmallKey fsra = new SmallKey();
                    fsra.ImportData(DataGridView1.CurrentCell, new Point(550, 232));
                    fsra.ShowDialog();
                }
            }
        }
        private void DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (ProcSel.AgreeEdit == 1)
                {
                    object LastTemp = DataGridView2.CurrentCell.Value;
                    SmallKey fsra = new SmallKey();
                    fsra.ImportData(DataGridView2.CurrentCell, new Point(550, 232));
                    fsra.ShowDialog();
                    if (e.RowIndex == 0 && DataGridView2.CurrentCell.Value.ToString() != "" && Convert.ToDouble(DataGridView2.CurrentCell.Value) < 12)
                    {
                        DataGridView2.CurrentCell.Value = LastTemp;
                        MessageBox.Show("警告：视觉液口距保护值小于12mm！");
                    }
                    if (e.RowIndex == 1 && DataGridView2.CurrentCell.Value.ToString() != "" && Convert.ToDouble(DataGridView2.CurrentCell.Value) < 12)
                    {
                        DataGridView2.CurrentCell.Value = LastTemp;
                        MessageBox.Show("警告：重量液口距保护值小于12mm！");
                    }
                }
            }
        }
        private void DataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {

                if (ProcSel.AgreeEdit == 1)
                {
                    if (e.RowIndex >= 13 && e.RowIndex <= 14 && e.ColumnIndex >= 0)
                    {
                        BeginInvoke(new Action(() =>
                        {
                            FrmLevel frmLevel = new FrmLevel("SuperUser", "SuperUser");
                            frmLevel.ShowDialog();
                            if (frmLevel.DialogResult == DialogResult.OK)
                            {
                                SmallKey fsra = new SmallKey();
                                fsra.ImportData(DataGridView3.CurrentCell, new Point(550, 232));
                                fsra.ShowDialog();
                            }
                        }));
                    }
                    else
                    {
                        SmallKey fsra = new SmallKey();
                        fsra.ImportData(DataGridView3.CurrentCell, new Point(550, 232));
                        fsra.ShowDialog();
                    }
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

        private void ProcStab1_Load(object sender, System.EventArgs e)
        {
            TabPage4.Parent = null;
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
    }
}
