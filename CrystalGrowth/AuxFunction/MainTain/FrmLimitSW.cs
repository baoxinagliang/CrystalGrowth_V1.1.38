using CrystalGrowth.CrystalCtl;
using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction.MainTain
{
    internal partial class FrmLimitSW : Form
    {
        public FrmLimitSW()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void FrmLimitSW_Load(object sender, EventArgs e)
        {
            DataGridView1.Rows.Add(32);
            DgvAssignment(0, ref FrmVarTable.VarStr);
        }
        private void DgvAssignment(int index, ref string[] strArray)
        {
            DataGridView1.Rows[0].Cells[index].Value = strArray[82];  //主室提升爪锁紧限位
            DataGridView1.Rows[1].Cells[index].Value = strArray[83];  //主室提升爪松开限位
            DataGridView1.Rows[2].Cells[index].Value = strArray[45];  //旋片阀升限位
            DataGridView1.Rows[3].Cells[index].Value = strArray[46];  //旋片阀降限位
            DataGridView1.Rows[4].Cells[index].Value = strArray[47];  //旋片阀开限位
            DataGridView1.Rows[5].Cells[index].Value = strArray[48];  //旋片阀关限位
            DataGridView1.Rows[6].Cells[index].Value = strArray[17];  //只升副室限位
            DataGridView1.Rows[7].Cells[index].Value = strArray[18];  //副室炉盖锁紧限位
            DataGridView1.Rows[8].Cells[index].Value = strArray[80];  //安全气缸上限位
            DataGridView1.Rows[9].Cells[index].Value = strArray[81];  //安全气缸下限位
            DataGridView1.Rows[10].Cells[index].Value = strArray[36]; //接晶架上限位
            DataGridView1.Rows[11].Cells[index].Value = strArray[37]; //接晶架下限位
            DataGridView1.Rows[12].Cells[index].Value = strArray[26]; //副室左旋限位
            DataGridView1.Rows[13].Cells[index].Value = strArray[27]; //副室右旋限位
            DataGridView1.Rows[14].Cells[index].Value = strArray[32]; //副室上升限位
            DataGridView1.Rows[15].Cells[index].Value = strArray[33]; //副室下降限位
            DataGridView1.Rows[16].Cells[index].Value = strArray[76]; //副室半升限位
            DataGridView1.Rows[17].Cells[index].Value = strArray[86]; //副室变速限位
            DataGridView1.Rows[18].Cells[index].Value = strArray[30]; //主室左旋限位
            DataGridView1.Rows[19].Cells[index].Value = strArray[31]; //主室右旋限位
            DataGridView1.Rows[20].Cells[index].Value = strArray[34]; //主室上升限位
            DataGridView1.Rows[21].Cells[index].Value = strArray[35]; //主室下降限位
            DataGridView1.Rows[22].Cells[index].Value = strArray[84]; //主室半升限位
            DataGridView1.Rows[23].Cells[index].Value = strArray[19]; //炉盖加热互锁限位
            DataGridView1.Rows[24].Cells[index].Value = strArray[87]; //主室球阀开限位
            DataGridView1.Rows[25].Cells[index].Value = strArray[88]; //主室球阀关限位
            DataGridView1.Rows[26].Cells[index].Value = strArray[1];  //晶升电机硬限位上
            DataGridView1.Rows[27].Cells[index].Value = strArray[2];  //晶升电机硬限位下
            DataGridView1.Rows[28].Cells[index].Value = strArray[6];  //埚升电机硬限位上
            DataGridView1.Rows[29].Cells[index].Value = strArray[7];  //埚升电机硬限位下
            DataGridView1.Rows[30].Cells[index].Value = strArray[10]; //热屏提升硬限位上
            DataGridView1.Rows[31].Cells[index].Value = strArray[11]; //热屏提升硬限位下
        }
        private void BtnQuit_Click(object sender, EventArgs e)
        {
            FrmSwitch.LastForm.Close();
            FrmMaintain temp = new FrmMaintain();
            FrmSwitch.Open(temp, 140, new Point(0, 130), new Size(1366, 638));
            temp.Show();
            FrmSwitch.LastForm = temp;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            DgvAssignment(1, ref FrmVarTable.VarValue);
        }
    }
}