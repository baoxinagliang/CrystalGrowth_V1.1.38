using CrystalGrowth.AuxFunction.CCD;
using CrystalGrowth.CrystalCtl;
using CrystalGrowth.Trend;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.Unities
{
    internal static class FrmSwitch
    {
        public static Form LastForm;
        public static Button LastMainBtn;
        public static void Open(Form form, int childIndex)
        {
            form.TopLevel = false;
            FrmMain.Single.panel1.Controls.Add(form);
            FrmMain.Single.panel1.Controls.SetChildIndex(form, childIndex);
            form.Location = new Point(260, 205);
            form.BringToFront();
            form.Show();
        }
        public static void Open(Form form, int childIndex, Size size)
        {
            form.TopLevel = false;
            FrmMain.Single.panel1.Controls.Add(form);
            FrmMain.Single.panel1.Controls.SetChildIndex(form, childIndex);
            form.Location = new Point(215, 200);
            form.Size = size;
            form.BringToFront();
            form.Show();
        }
        public static void Open(Form form, int childIndex, Point point, Size size)
        {
            form.TopLevel = false;
            FrmMain.Single.panel1.Controls.Add(form);
            FrmMain.Single.panel1.Controls.SetChildIndex(form, childIndex);
            form.Location = point;
            form.Size = size;
            form.BringToFront();
        }
        public static void LastFormClose()
        {
            if (ReferenceEquals(LastForm, FrmTrend.Single))
            {
                LastForm.Hide();
            }
            else
            {
                LastForm.Close();
                GC.Collect();
            }
        }
        public static void LastFormClose(Form form)
        {
            if (ReferenceEquals(LastForm, FrmTrend.Single))
            {
                LastForm.Hide();
                Open(form, 30, new Point(0, 200), new Size(520, 494));
                form.Show();
                return;
            }
            if (ReferenceEquals(form, LastForm))
            {
                return;
            }
            else
            {
                if (LastForm != null)
                {
                    LastForm.Close();
                }
                Open(form, 30, new Point(0, 200), new Size(520, 494));
                form.Show();
                GC.Collect();
            }
        }
        public static void OpenAutoForm()
        {
            string ss = Math.Round(PLC.ReadValue[1], 1).ToString("f1");
            switch (ss)
            {
                case "0.0":     //Manual
                case "35.0":     //自动拆炉
                    FrmManual fm = new FrmManual();
                    LastFormClose(fm);
                    LastForm = fm;
                    break;
                case "2.0":     //PumpDown
                    FrmPumpDown fpd = new FrmPumpDown();
                    LastFormClose(fpd);
                    LastForm = fpd;
                    break;
                case "3.0":     //LeakBack
                    FrmLeakBack flb = new FrmLeakBack();
                    LastFormClose(flb);
                    LastForm = flb;
                    break;
                case "4.0":     //Pressurization
                    FrmPressurization fpn = new FrmPressurization();
                    LastFormClose(fpn);
                    LastForm = fpn;
                    break;
                case "5.0":     //Melting
                    FrmMelting fmg = new FrmMelting();
                    LastFormClose(fmg);
                    LastForm = fmg;
                    break;
                case "8.0":     //StabilizationII
                    FrmStabilizationDip fsd = new FrmStabilizationDip();
                    LastFormClose(fsd);
                    LastForm = fsd;
                    break;
                case "9.0":     //Dip
                    FrmStabilizationDip fsd1 = new FrmStabilizationDip();
                    LastFormClose(fsd1);
                    LastForm = fsd1;
                    break;
                case "10.0":    //Neck Growth
                    FrmNeck fnk = new FrmNeck();
                    LastFormClose(fnk);
                    LastForm = fnk;
                    break;
                case "11.0":    //Crown Growth
                    FrmCrown fcn = new FrmCrown();
                    LastFormClose(fcn);
                    LastForm = fcn;
                    break;
                case "12.0":    //Shoulder Growth
                    FrmShoulder fsr = new FrmShoulder();
                    LastFormClose(fsr);
                    LastForm = fsr;
                    break;
                case "13.0":    //Body Growth
                    FrmBody fby = new FrmBody();
                    LastFormClose(fby);
                    LastForm = fby;
                    break;
                case "14.0":    //Tail Growth
                    FrmTail ftl = new FrmTail();
                    LastFormClose(ftl);
                    LastForm = ftl;
                    break;
                case "14.1":    //Tail Growth
                    FrmFinishedTail fftl = new FrmFinishedTail();
                    LastFormClose(fftl);
                    LastForm = fftl;
                    break;
                case "15.0":    //Fast Tail Gro wth
                    FrmFastTail fft = new FrmFastTail();
                    LastFormClose(fft);
                    LastForm = fft;
                    break;
                case "16.0":    //Shutdown
                    FrmShutDown fsd2 = new FrmShutDown();
                    LastFormClose(fsd2);
                    LastForm = fsd2;
                    break;
                case "17.0":    //Isolation
                    FrmIsolation fio = new FrmIsolation();
                    LastFormClose(fio);
                    LastForm = fio;
                    break;
                case "18.0":    //Purge
                    FrmPurge fpe = new FrmPurge();
                    LastFormClose(fpe);
                    LastForm = fpe;
                    break;
                case "19.0":    //Bakeout
                    FrmBakeout fbo = new FrmBakeout();
                    LastFormClose(fbo);
                    LastForm = fbo;
                    break;
                case "20.0":    //Crystal Cold Pull Out
                    FrmCrysCold fcc = new FrmCrysCold();
                    LastFormClose(fcc);
                    LastForm = fcc;
                    break;
                case "21.0":    //Cover Pull Out
                    FrmCoverOut fco = new FrmCoverOut();
                    LastFormClose(fco);
                    LastForm = fco;
                    break;
                case "20.1":    //Crystal Cold Pull Out
                    FrmCrysCold1 fcc1 = new FrmCrysCold1();
                    LastFormClose(fcc1);
                    LastForm = fcc1;
                    break;
                case "20.2":    //Crystal Cold Pull Out
                    FrmCrysCold2 fcc2 = new FrmCrysCold2();
                    LastFormClose(fcc2);
                    LastForm = fcc2;
                    break;
                case "22.0":    //Tube Pull In
                    FrmTubeIn fti = new FrmTubeIn();
                    LastFormClose(fti);
                    LastForm = fti;
                    break;
                case "23.0":    //Tube Pull Out
                    FrmTubeOut fto = new FrmTubeOut();
                    LastFormClose(fto);
                    LastForm = fto;
                    break;
                case "24.0":    //Charging
                    FrmCharging fcg = new FrmCharging();
                    LastFormClose(fcg);
                    LastForm = fcg;
                    break;
                case "25.0":    //Seed pull in
                    FrmSeedPullIn fspn = new FrmSeedPullIn();
                    LastFormClose(fspn);
                    LastForm = fspn;
                    break;
                case "26.0":    //Cover Rot In
                    FrmCoverRotIn fcri = new FrmCoverRotIn();
                    LastFormClose(fcri);
                    LastForm = fcri;
                    break;
                case "27.0":    //Charging
                    FrmCoverRotOut fcro = new FrmCoverRotOut();
                    LastFormClose(fcro);
                    LastForm = fcro;
                    break;
                case "28.0":    //临时-炉筒旋回
                    FrmCoverRotOut fcro1 = new FrmCoverRotOut();
                    LastFormClose(fcro1);
                    LastForm = fcro1;
                    break;
                case "29.0":    //临时-炉筒旋开
                    FrmCoverRotOut fcro2 = new FrmCoverRotOut();
                    LastFormClose(fcro2);
                    LastForm = fcro2;
                    break;
                case "30.0":    //Emergency Safe Protect
                    FrmSafeProtect fsp1 = new FrmSafeProtect();
                    LastFormClose(fsp1);
                    LastForm = fsp1;
                    break;
                case "31.0":    //临时-自动装料
                    FrmCoverRotOut fcro3 = new FrmCoverRotOut();
                    LastFormClose(fcro3);
                    LastForm = fcro3;
                    break;
                case "32.0":    //临时-自动装料
                    FrmCoverRotOut fcro4 = new FrmCoverRotOut();
                    LastFormClose(fcro4);
                    LastForm = fcro4;
                    break;
                case "33.0":    //临时-自动装料 
                    FrmCoverRotOut fcro5 = new FrmCoverRotOut();
                    LastFormClose(fcro5);
                    LastForm = fcro5;
                    break;
            }
            FrmMain.LastCtlBtn.BackColor = FrmMain.LastCtlBtn.BackColor != Color.Green ? Color.RoyalBlue : Color.Lime;
            FrmMain.LastCtlBtn = FrmMain.Single.BtnSeedLift;
            LastMainBtn.BackColor = Color.Blue;
            LastMainBtn = FrmMain.Single.BtnFurnaceCtl;
            FrmMain.Single.BtnFurnaceCtl.BackColor = Color.DarkSlateGray;
            if (Application.OpenForms["FrmVarTable"] != null && Application.OpenForms["FrmImage"] != null && FrmVarTable.Single.Visible == false)
            {
                Open(FrmImage.Single, 200, new Point(638, 225), new Size(650, 475));
                FrmImage.SizeValue1 = new Size(650, 475);
                FrmImage.SizeValue2Change();
                FrmImage.Single.Visible = true;
            }
        }
    }
}
