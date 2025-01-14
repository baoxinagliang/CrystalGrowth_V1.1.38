using CrystalGrowth.Unities;
using System;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction
{
    public partial class FrmDiaByWeight : Form
    {
        internal FrmDiaByWeight()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            LabBodyWeight.Text = Math.Round(PLC.ReadCalcValue[19], 1).ToString("f1");
            LabCalcDia.Text = Math.Round(PLC.ReadValue[108], 2).ToString("f2");
            LabRealDia.Text = Math.Round(PLC.ReadValue[7], 2).ToString("f2");
        }
    }
}
