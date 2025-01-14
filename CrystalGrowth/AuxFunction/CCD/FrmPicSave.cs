using CamLibrary;
using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction.CCD
{
    public partial class FrmPicSave : Form
    {
        public static bool MSlaveFlag = false;
        public static bool ContTrigger = false;
        public FrmPicSave()
        {
            InitializeComponent();
        }
        private void FrmPicSave_Load(object sender, EventArgs e)
        {
            if (ContTrigger)
            {
                BtnCTrigger.BackColor = Color.Lime;
                LabInfo.Visible = true;
            }
            else
            {
                BtnCTrigger.BackColor = Color.RoyalBlue;
                LabInfo.Visible = false;
            }
            if (MSlaveFlag)
            {
                CheckBox1.Text = "从相机";
                CheckBox1.Checked = true;
            }
            else
            {
                CheckBox1.Text = "主相机";
                CheckBox1.Checked = false;
            }
            BtnStart.BackColor = CamUnity.CtrlNum != 0 ? Color.Lime : Color.RoyalBlue;
        }
        private void BtnSTrigger_Click(object sender, EventArgs e)
        {
            if (DouClick.ThreeSec(ref BtnSTrigger))
            {
                if (CamUnity.CtrlNum == 0) { return; }
                if (BtnStart.BackColor == Color.Lime)
                {
                if (!Directory.Exists("D:\\LICCS_PIC"))
                {
                    Directory.CreateDirectory("D:\\LICCS_PIC");
                }
                if (CamUnity.btmpPic != null)
                {
                    CamUnity.btmpPic.Save($"D:\\LICCS_PIC\\{DateTime.Now:MMddHHmmssfff}.bmp");
                }
            }
        }
        }
        private void BtnCTrigger_Click(object sender, EventArgs e)
        {
            if (CamUnity.CtrlNum == 0) { return; }
            if (BtnStart.BackColor == Color.Lime)
            {
            if (!Directory.Exists("D:\\LICCS_PIC"))
            {
                Directory.CreateDirectory("D:\\LICCS_PIC");
            }
            ContTrigger = !ContTrigger;
            if (ContTrigger)
            {
                Start();
                BtnCTrigger.BackColor = Color.Lime;
                LabInfo.Visible = true;
            }
            else
            {
                BtnCTrigger.BackColor = Color.RoyalBlue;
                LabInfo.Visible = false;
            }
        }
        }
        private void CheckBox1_Click(object sender, EventArgs e)
        {
            MSlaveFlag = !MSlaveFlag;
            if (MSlaveFlag)
            {
                CheckBox1.Text = "从相机";
                CamUnity.CtrlNum = 2;
            }
            else
            {
                CheckBox1.Text = "主相机";
                CamUnity.CtrlNum = 1;
            }
        }
        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private async void BtnStart_Click(object sender, EventArgs e)
        {
            if (CamUnity.CtrlNum == 0)
            {
                BtnStart.BackColor = Color.Lime;
                CamUnity.CtrlNum = 1;
            }
            else
            {
                CamUnity.CtrlNum = 0;
                BtnStart.BackColor = Color.RoyalBlue;
            }
            if (BtnCTrigger.BackColor == Color.Lime)
            {
                BtnCTrigger.BackColor = Color.RoyalBlue;
                LabInfo.Visible = false;
                ContTrigger = false;
                if (CancelTokenSource != null)
                {
                    CancelTokenSource.Cancel();
                }
                await Task.Delay(1000);
                if (t != null)
                {
                    t.Dispose();
                    t = null;
                }
                if (CamUnity.btmpPic != null)
                {
                    CamUnity.btmpPic.Dispose();
                    CamUnity.btmpPic = null;
                }
                GC.Collect();
            }
        }
        static CancellationTokenSource CancelTokenSource;
        static Task t = null;
        private static void Start()
        {
            CancelTokenSource = new CancellationTokenSource();
            Task.Factory.StartNew(ContTriggerPic, CancelTokenSource.Token);
        }
        private static void ContTriggerPic()
        {
            t = new Task(() =>
             {
                 while (!CancelTokenSource.IsCancellationRequested)
                 {
                     if (CamUnity.btmpPic != null && ContTrigger)
                     {
                         CamUnity.btmpPic.Save($"D:\\LICCS_PIC\\{DateTime.Now:MMddHHmmssfff}.bmp");
                     }
                     Thread.Sleep(500);
                 }
             });
            t.Start();
        }
    }
}
