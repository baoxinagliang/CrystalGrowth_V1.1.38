using CrystalGrowth.CrystalCtl;
using CrystalGrowth.Unities;
using System;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction
{
    internal partial class FrmCrownT : Form
    {
        readonly FrmCrownTrack fct;
        public FrmCrownT()
        {
            InitializeComponent();
            fct = new FrmCrownTrack(true)
            {
                TopLevel = false
            };
        }
        private void FrmCrownT_Load(object sender, EventArgs e)
        {
            LabInfo.Text = PLC.IsConn ? "" : "温馨提示：PLC通信连接成功显示！";
            Panel1.Controls.Add(fct);
            fct.Show();
        }
        private void FrmCrownT_FormClosed(object sender, FormClosedEventArgs e)
        {
            fct.Close();
        }
    }
}
