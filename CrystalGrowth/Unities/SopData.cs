﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalGrowth.Unities
{
    internal class SopData<T>
    {
        /// <summary>
        /// Initial(初始化)-DB40,长度136
        /// </summary>
        public T[] Initial = new T[136];
        /// <summary>
        /// PumpLeak(抽空/检漏)-DB41,长度14
        /// </summary>
        public T[] PumpLeak = new T[14];
        /// <summary>
        /// PressMelt(压力化/熔料)-DB42,长度95
        /// </summary>
        public T[] PressMelt = new T[95];
        /// <summary>
        /// Dip(预热/熔接)-DB43,长度39
        /// </summary>
        public T[] Dip = new T[39];
        /// <summary>
        /// Stabilize(调温)-DB44,长度36
        /// </summary>
        public T[] Stabilize = new T[36];
        /// <summary>
        /// Neck(引晶)-DB45,长度145
        /// </summary>
        public T[] Neck = new T[115];
        /// <summary>
        /// Crown(放肩)-DB46,长度441
        /// </summary>
        public T[] Crown = new T[441];
        /// <summary>
        /// Shoulder(转肩)-DB47,长度146
        /// </summary>
        public T[] Shoulder = new T[146];
        /// <summary>
        /// Body(等径)-DB48,长度474
        /// </summary>
        public T[] Body = new T[524];
        /// <summary>
        /// Tail(收尾)-DB49,长度420
        /// </summary>
        public T[] Tail = new T[420];
        /// <summary>
        /// Shutdown(停炉)-DB50,长度16
        /// </summary>
        public T[] Shutdown = new T[16];
        /// <summary>
        /// Purge(副室净化)-DB51,长度7
        /// </summary>
        public T[] Purge = new T[7];
        /// <summary>
        /// Backout(煅烧)-DB52,长度60
        /// </summary>
        public T[] Backout = new T[60];
        /// <summary>
        /// TempCtl(热场控制)-DB53,长度5
        /// </summary>
        public T[] TempCtl = new T[5];
        /// <summary>
        /// CrystalCold(取段冷却)-DB54,长度126
        /// </summary>
        public T[] CrystalCold = new T[126];
        /// <summary>
        /// CoverOut(渣盖提出)-DB55,长度35
        /// </summary>
        public T[] CoverOut = new T[35];
        /// <summary>
        /// TubeInOut(料桶提入提出)-DB56,长度14
        /// </summary>
        public T[] TubeInOut = new T[14];
        /// <summary>
        /// seedPullIn(籽晶提入提出)-DB57,长度3
        /// </summary>
        public T[] SeedPullIn = new T[3];
        /// <summary>
        /// CoverRotInOut(炉盖旋开旋回)-B58,长度1
        /// </summary>
        public T[] CoverRotInOut = new T[1];
        /// <summary>
        /// FTRotInOut(炉筒旋开旋回)-DB59,长度5
        /// </summary>
        public T[] FTRotInOut = new T[5];
        /// <summary>
        /// AutoCharing(自动加料)-DB61,长度4
        /// </summary>
        public T[] AutoCharing = new T[4];
        /// <summary>
        /// ReMelting(回熔)-DB62,长度29
        /// </summary>
        public T[] ReMelting = new T[29];
        /// <summary>
        /// OneKeySetCru(一键放锅)-DB63,长度4
        /// </summary>
        public T[] OneKeySetCru = new T[4];
        /// <summary>
        /// SiliconPreheat(硅料预热)-DB64,长度20
        /// </summary>
        public T[] SiliconPreheat = new T[20];
    }
}
