using CrystalGrowth.CrystalCtl;
using CrystalGrowth.Unities;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace CrystalGrowth
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
            {
                return;
            }
            //设置应用程序处理异常方式：ThreadException处理
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            //处理UI线程异常
            Application.ThreadException += Log.ThreadException;
            //处理非UI线程异常
            AppDomain.CurrentDomain.UnhandledException += Log.UnhandledException;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(FrmMain.CreateInstrance());
        }
    }
}
