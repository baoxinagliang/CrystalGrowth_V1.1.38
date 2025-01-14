using System;
using System.Runtime.InteropServices;

namespace CrystalGrowth.Unities
{
    internal static class ExternDll
    {
        [DllImport("LintonKayexCVDLL.dll", EntryPoint = "MeasureExtremum")]
        public extern static short MeasureExtremum(IntPtr pDataIn, int width, int height,
            long CenterX, long CenterY, long LongEdge, long ShortEdge, double angle, double threshold, long ROI, long sigma, long Transition,
            long StartEdge, long gap, ref double ResultNearestX, ref double ResultNearestY, ref double ResultFarthestX, ref double ResultFarthestY);
        [DllImport("LintonKayexCVDLL.dll", EntryPoint = "MeasureMeltGap")]
        public extern static short MeasureMeltGap(IntPtr pDataIn, int width, int height, long StartX, long StartY,
            long EndX, long EndY, long threshold, double sigma, long ROI, long Transition,
            ref double ResultX1, ref double ResultX2, ref double ResultY, ref double ResultDistance);
        [DllImport("LintonKayexCVDLL.dll", EntryPoint = "MeasureMeltGapLong")]
        public extern static int MeasureMeltGapLong(IntPtr pDataIn, int width, int height, long StartX, long StartY,
            long EndX, long EndY, long threshold, double sigma, long ROI, long Transition,
            ref double ResultX1, ref double ResultX2, ref double ResultY, ref double ResultDistance);
        [DllImport("LintonKayexCVDLL.dll", EntryPoint = "GetPointPixel")]
        public extern static short GetPointPixel(IntPtr pDataIn, int width, int height, long PointX, long PointY);
        [DllImport("LintonKayexCVDLL.dll", EntryPoint = "DetectShieldDia")]
        public static extern int DetectShieldDia(IntPtr DataIn, int width, int height, int lx, int ly, int lw, int lh, int rx, int ry, int rw, int rh,
            ref double leftX, ref double leftY, ref double rightX, ref double rightY, ref double shieldDia, int leftThr = 20, int rightThr = 20);
        [DllImport("LintonKayexCVDLL.dll", EntryPoint = "GetDiaPoints")]
        public static extern IntPtr GetDiaPoints();
        [DllImport("LintonKayexCVDLL.dll", EntryPoint = "DiaFitMeasure")]
        public extern static short DiaFitMeasure(IntPtr pDataIn, int width, int height, long CenterX, long CenterY, long LongEdge, long ShortEdge, double threshold,
            long ROI, long sigma, double angle, long Transition, long gap, int scanLine, ref double circleX, ref double circleY, ref double circleR);
        [DllImport("LintonKayexCVDLL.dll", EntryPoint = "DiaFitMeasureWhitCL")]
        public extern static short DiaFitMeasureWhitCL(IntPtr pDataIn, int width, int height, long CenterX, long CenterY, long LongEdge, long ShortEdge,
            double threshold, long ROI, long sigma, double angle, long Transition, long gap, int scanLine, double cutLineThroshold, ref double circleX,
           ref double circleY, ref double circleR, ref double cutLineX, ref double cutLineY, ref short CatchFlag);
        [DllImport("LintonKayexCVDLL.dll", EntryPoint = "SetMeasuredShield")]
        public extern static short SetMeasuredShield(int ss);
        [DllImport("CPredictor.dll", EntryPoint = "OpenCVDataBuffer")]
        public static extern void OpenCVDataBuffer(IntPtr DataIn, float[] DataOut, int width, int height);
        [DllImport("CPredictor.dll", EntryPoint = "getPredictIm")]
        public static extern void getPredictIm(string modelDir, int numThread, bool mkldnnEnable, bool memoryEnable,
            int queueSize, float[] inputTensor, float[] return_im, int height, int width);
        [DllImport("CPredictor.dll", EntryPoint = "getPercent")]
        public static extern void getPercent(ref double res);
        [DllImport("CPredictor.dll", EntryPoint = "compute")]
        public static extern void compute(ref double avg);
        [DllImport("CPredictor.dll", EntryPoint = "ReleasePredictor")]
        public static extern void ReleasePredictor();
        [DllImport("user32.dll")]// 获取上次输入操作的时间
        public static extern bool GetLastInputInfo(ref LastInputInfo plii);
        [DllImport("LintonKayexCVDLL.dll", EntryPoint = "GetDiaPoints2")]
        public static extern IntPtr GetDiaPoints2();
        [DllImport("LintonKayexCVDLL.dll", EntryPoint = "DiaFitMeasure2")]
        public extern static short DiaFitMeasure2(IntPtr pDataIn, int width, int height,
            long CenterX, long CenterY, long LongEdge, long ShortEdge, double threshold, long ROI,
            long sigma, double angle, long Transition, long gap, int scanLine, ref double circleX, ref double circleY, ref double circleR);
        [DllImport("LintonKayexCVDLL.dll", EntryPoint = "DiaFitMeasureWhitCL2")]
        public extern static short DiaFitMeasureWhitCL2(IntPtr pDataIn, int width, int height, long CenterX, long CenterY, long LongEdge, long ShortEdge,
            double threshold, long ROI, long sigma, double angle, long Transition, long gap, int scanLine, double cutLineThroshold, ref double circleX,
           ref double circleY, ref double circleR, ref double cutLineX, ref double cutLineY, ref short CatchFlag);
        [DllImport("LintonKayexCVDLL.dll", EntryPoint = "GetShieldDiaPoints")]
        public static extern IntPtr GetShieldDiaPoints();
        [DllImport("LintonKayexCVDLL.dll", EntryPoint = "ShieldDiaFitMeasure")]
        public extern static short ShieldDiaFitMeasure(IntPtr pDataIn, int width, int height,
            int lx, int ly, int lw, int lh, int rx, int ry, int rw, int rh, short thresholdLeft, short thresholdRight, long ROI, long sigma,
            double angle, long Transition, long gap, int scanLine, ref double circleX, ref double circleY, ref double circleR);
        //引晶拟合圆
        [DllImport("LintonKayexCVDLL.dll", EntryPoint = "NeckDiaFitMeasure")]
        public extern static short NeckDiaFitMeasure(IntPtr pDataIn, int width, int height, long CenterX, long CenterY, 
            long LongEdge, long ShortEdge, double threshold, long ROI, long sigma, double angle, long Transition, 
            long gap, int scanLine, ref double circleX, ref double circleY, ref double circleR);

        //引晶拟合圆测量点
        [DllImport("LintonKayexCVDLL.dll", EntryPoint = "GetNeckDiaPoints")]
        public static extern IntPtr GetNeckDiaPoints();

        /// <summary> 
        /// 绝对液口距计算（返回两个椭圆信息）
        /// </summary>
        /// <param name="pDataIn">图片指针</param>
        /// <param name="width">图片像素宽度</param>
        /// <param name="height">图片像素高度</param>
        /// <param name="h">CCD到导流筒底垂直距离</param>
        /// <param name="r">导流筒下口半径</param>
        /// <param name="t">CCD到设备中心距</param>
        /// <param name="buf">液口距信息结构体</param>
        [DllImport("LintonKayexCVDLL.dll", EntryPoint = "Calc_Fitting_Ellips_YKJ")]
        public static extern IntPtr Calc_Fitting_Ellips_YKJ(IntPtr pDataIn, int width, int height, double h, double r, double t, int five_value, ref YKJ_Info buf);

    }
}
