using System;
using System.Windows.Forms;

namespace CrystalGrowth.Unities
{
    internal static class DouClick
    {
        static bool TwiceFlag = false;
        static readonly System.Timers.Timer timer = new System.Timers.Timer();
        static readonly ToolTip ttp1 = new ToolTip();
        static Button btn1;
        static CheckBox cbx1;
        static PictureBox pbx1;
        public static bool ThreeSec(ref Button btn)
        {
            if (btn1 != null && !ReferenceEquals(btn, btn1))
            {
                ClearState();
                ttp1.RemoveAll();
            }
            btn1 = btn;
            timer.Elapsed += Timer_Tick;
            if (TwiceFlag)
            {
                ClearState();
                ttp1.RemoveAll();
                return true;
            }
            else
            {
                ttp1.SetToolTip(btn, "请再点击一次!");
                TimerStart();
                return false;
            }
        }
        public static bool ThreeSec(ref CheckBox cbx)
        {
            if (cbx1 != null && !ReferenceEquals(cbx, cbx1))
            {
                ClearState();
                ttp1.RemoveAll();
            }
            cbx1 = cbx;
            timer.Elapsed += Timer_Tick;
            if (TwiceFlag)
            {
                ClearState();
                ttp1.RemoveAll();
                return true;
            }
            else
            {
                ttp1.SetToolTip(cbx, "请再点击一次!");
                TimerStart();
                return false;
            }
        }
        public static bool ThreeSec(ref PictureBox pbx)
        {
            if (cbx1 != null && !ReferenceEquals(pbx, pbx1))
            {
                ClearState();
                ttp1.RemoveAll();
            }
            pbx1 = pbx;
            timer.Elapsed += Timer_Tick;
            if (TwiceFlag)
            {
                ttp1.RemoveAll();
                ClearState();
                return true;
            }
            else
            {
                ttp1.SetToolTip(pbx, "请再点击一次!");
                TimerStart();
                return false;
            }
        }
        private static void TimerStart()
        {
            TwiceFlag = true;
            timer.Enabled = false;
            timer.Interval = 3000;
            timer.Enabled = true;
        }
        private static void ClearState()
        {
            TwiceFlag = false;
            timer.Enabled = false;
            timer.Elapsed -= Timer_Tick;
        }
        private static void Timer_Tick(object sender, System.Timers.ElapsedEventArgs e)
        {
            _ = new Action(() =>
            {
                ClearState();
                ttp1.RemoveAll();
            });
        }
    }
}
