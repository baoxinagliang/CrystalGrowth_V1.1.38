using System.Drawing;

namespace CrystalGrowth.Unities
{
    internal class MGpBasic
    {
        public static int xoff = 0;
        public static int yoff = 0;
        public static Size RangeSize;
        public static void MoveArea(ref Rectangle rect)
        {
            rect.X += xoff;
            rect.Y += yoff;
            if (rect.X < 0) { rect.X = 0; }
            if (rect.Y < 0) { rect.Y = 0; }
            if (rect.X > RangeSize.Width - rect.Width)
            { rect.X = RangeSize.Width - rect.Width; }
            if (rect.Y > RangeSize.Height - rect.Height)
            { rect.Y = RangeSize.Height - rect.Height; }
        }
    }
}
