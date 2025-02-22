﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.Unities
{
    internal class LockPic : IDisposable
    {
        public Image Off, On;
        public LockPic()
        {
            Off = Image.FromFile(string.Concat(Application.StartupPath, "\\Picture\\InterlockOff.png"));
            On = Image.FromFile(string.Concat(Application.StartupPath, "\\Picture\\InterlockOn.png"));
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected void Dispose(bool disposing)
        {
            if (disposing)
            {
                Off.Dispose();
                On.Dispose();
            }
        }
        ~LockPic()
        {
            Dispose(false);
        }
    }
    internal class ValvePic : IDisposable
    {
        public Image AutoOpen, AutoClose, Open, Close, PumpOn, PumpOff;
        public ValvePic()
        {
            AutoOpen = Image.FromFile(string.Concat(Application.StartupPath, "\\Picture\\AutomaticValveOpen.png"));
            AutoClose = Image.FromFile(string.Concat(Application.StartupPath, "\\Picture\\AutomaticValveClose.png"));
            Open = Image.FromFile(string.Concat(Application.StartupPath, "\\Picture\\ValveOn.png"));
            Close = Image.FromFile(string.Concat(Application.StartupPath, "\\Picture\\ValveOff.png"));
            PumpOn = Image.FromFile(string.Concat(Application.StartupPath, "\\Picture\\PumpOn.png"));
            PumpOff = Image.FromFile(string.Concat(Application.StartupPath, "\\Picture\\PumpOff.png"));
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected void Dispose(bool disposing)
        {
            if (disposing)
            {
                AutoOpen.Dispose();
                AutoClose.Dispose();
                Open.Dispose();
                Close.Dispose();
                PumpOn.Dispose();
                PumpOff.Dispose();
            }
        }
        ~ValvePic()
        {
            Dispose(false);
        }
    }
    internal class FurnacePic : IDisposable
    {
        public Image Body;
        public Image Change(int i)
        {
            switch (i)
            {
                case 2:
                    Body = Image.FromFile(string.Concat(Application.StartupPath, "\\Picture\\2.png"));
                    break;
                case 3:
                    Body = Image.FromFile(string.Concat(Application.StartupPath, "\\Picture\\3.png"));
                    break;
                case 4:
                    Body = Image.FromFile(string.Concat(Application.StartupPath, "\\Picture\\4.png"));
                    break;
                case 5:
                    Body = Image.FromFile(string.Concat(Application.StartupPath, "\\Picture\\5.png"));
                    break;
            }
            return Body;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected void Dispose(bool disposing)
        {
            if (disposing)
            {
                Body.Dispose();
            }
        }
        ~FurnacePic()
        {
            Dispose(false);
        }
    }
}
