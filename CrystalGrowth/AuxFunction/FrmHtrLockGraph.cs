using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction
{
    internal partial class FrmHtrLockGraph : Form
    {
        public FrmHtrLockGraph()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            LabHtr.ForeColor = LabHtr.ForeColor == Color.Red ? Color.Green : Color.Red;
        }
    }
}
