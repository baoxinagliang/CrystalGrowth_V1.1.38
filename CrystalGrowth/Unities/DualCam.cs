﻿using CamLibrary;
using CrystalGrowth.AuxFunction.CCD;
using System;
using System.IO;
using System.Text;

namespace CrystalGrowth.Unities
{
    internal static class DualCam
    {
        public static string SelectCam = "3";
        public static string DoubleCam = "1";
        public static string Ip1 = "192.168.0.50";
        public static string Ip2 = "192.168.0.51";
        public static void ReadOut()
        {
            string[] Lines = File.ReadAllLines(FileHelper.DualCamPath, Encoding.UTF8);
            int Length = Lines.Length;
            string[] FileValue = new string[Length];
            string[] TempVar;
            char[] SplitChar = new char[] { '=' };
            if (Length > 0)
            {
                for (int i = 0; i < Length; i++)
                {
                    TempVar = Lines[i].Split(SplitChar);
                    if (TempVar.Length == 2)
                    {
                        FileValue[i] = TempVar[1];
                    }
                }
            }
            SelectCam = FileValue[0];
            DoubleCam = FileValue[1];
            Ip1 = FileValue[2];
            Ip2 = FileValue[3];
        }
        public static void Load()
        {
            switch (SelectCam)
            {
                case "0":
                    VirtualCamera.VirtualAction += FrmImage.RefreshPic1;
                    VirtualCamera.LoadVirtualCamera(FileHelper.VirtualCameraPath, 5);
                    break;
                case "1":
                    if (DoubleCam == "2")
                    {
                        //待开发............
                    }
                    else
                    {
                        Avt.ExpoTime1 = ParasCam1.ExpoTime;
                        Avt.AvtAction += FrmImage.RefreshPic1;
                        Avt.XInit();
                    }
                    break;
                case "2":
                    if (DoubleCam == "2")
                    {
                        //待开发............
                    }
                    else
                    {
                        Basler.ExpoTime1 = ParasCam1.ExpoTime;
                        Basler.BaslerAction += FrmImage.RefreshPic1;
                        Basler.Camera1Start();
                    }
                    break;
                case "3":
                    if (DoubleCam == "2")
                    {
                        Hik.ExpoTime1 = ParasCam1.ExpoTime;
                        Hik.ExpoTime2 = ParasCam2.ExpoTime;
                        Hik.IsDouble = true;
                        Hik.Ip1 = Ip1;
                        Hik.Ip2 = Ip2;
                        Hik.HikAction1 += FrmImage.RefreshPic1;
                        Hik.HikAction2 += FrmImage.RefreshPic2;
                        Hik.HeartBeatMonitor();
                    }
                    else
                    {
                        Hik.ExpoTime1 = ParasCam1.ExpoTime;
                        Hik.IsDouble = false;
                        Hik.HikAction1 += FrmImage.RefreshPic1;
                        Hik.HeartBeatMonitor();
                    }
                    break;
                case "4":
                    if (DoubleCam == "4")
                    {
                        //待开发............
                    }
                    else
                    {
                        Huaray.ExpoTime1 = ParasCam1.ExpoTime;
                        Huaray.HuarayAction += FrmImage.RefreshPic1;
                        Huaray.Camera1Start();
                    }
                    break;
            }
        }
        public static void SetExpoTime1(string SelCam, int ExpoTime)
        {
            if (SelCam == "1" && Avt.IsConn1)
            {
                Avt.Camera1.ExpoTime = ExpoTime;
            }
            else if (SelCam == "2" && Basler.IsConn1)
            {
                Basler.Camera1.ExpoValue = ExpoTime;
            }
            else if (SelCam == "3" && Hik.IsConn1)
            {
                Hik.Camera1.ExpoTime = ExpoTime;
            }
            else if (SelCam == "4" && Huaray.IsConn1)
            {
                Huaray.Camera1.ExpoValue = ExpoTime;
            }
        }
        public static void SetExpoTime2(string SelCam, int ExpoTime)
        {
            if (SelCam == "1" && Avt.IsConn2)
            {
                //AvtLoad.Camera2.ExpoTime = ExpoTime;
            }
            else if (SelCam == "2" && Basler.IsConn2)
            {
                //BaslerLoad.Camera2.ExpoValue = ExpoTime;
            }
            else if (SelCam == "3" && Hik.IsConn2)
            {
                Hik.Camera2.ExpoTime = ExpoTime;
            }
        }
        public static void CloseCameras()
        {
            try
            {
                switch (SelectCam)
                {
                    case "1":
                        if (Avt.IsDouble)
                        {
                            //待开发.......
                        }
                        else
                        {
                            Avt.XUnInit();
                        }
                        break;
                    case "2":
                        if (Basler.IsDouble)
                        {
                            //待开发.......
                        }
                        else
                        {
                            Basler.Camera1.StopGrabbing();
                            Basler.Camera1.CloseCam();
                            Basler.Cal1Thread.Abort();
                        }
                        break;
                    case "3":
                        if (Hik.IsDouble)
                        {
                            Hik.Camera1.StopGrab();
                            Hik.Camera2.StopGrab();
                            Hik.Camera1.CloseCam();
                            Hik.Camera2.CloseCam();
                            Hik.UnLoad();
                        }
                        else
                        {
                            Hik.Camera1.StopGrab();
                            Hik.Camera1.CloseCam();
                            Hik.UnLoad();
                        }
                        break;
                    case "4":
                        if (Huaray.IsDouble)
                        {
                            //待开发.......
                        }
                        else
                        {
                            if (Huaray.Camera1 != null)
                            {
                                Huaray.Camera1.CloseCam();
                                Huaray.Cal1Thread.Abort();
                            }
                            
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                Log.Record("Camera off exception!", ex);
                return;
            }
        }
    }
}
