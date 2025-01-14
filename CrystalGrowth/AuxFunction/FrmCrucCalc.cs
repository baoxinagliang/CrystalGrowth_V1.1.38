using CrystalGrowth.CrystalCtl;
using CrystalGrowth.Unities;
using System;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction
{
    internal partial class FrmCrucCalc : Form
    {
        // 倒角部分从上往下累计体积,倒角部分从上往下累计高度,内圆弧部分从上往下累计体积,内圆弧部分从上往下累计高度, 倒角部分半径,内圆弧部分半径
        double[] Wa, Ha, Wc, Hc, Ra, Rc;
        double MaxLoad, MeltDepth, CylinderWeig, DiacusWeig, SegmentWeig;
        // 圆柱部分重量,倒角部分重量,圆弧部分重量,,内圆弧部分体积,内圆弧部分半径,圆弧部分体积分割数量,..
        double ColumnWeig, DegreeWeig, ArcWeig, CL_SL, Vb, Rb, ArcNum, ColumnHeight, DegreeHeight;
        int DegreeNum, DegIndex, ArcIndex;          // 倒角部分体积分割数量
        public FrmCrucCalc()
        {
            InitializeComponent();
            Load += Timer1_Tick;
        }
        private void FrmCrucCalc_Load(object sender, EventArgs e)
        {
            CLSLParas.ReadOut();
            WeightCalc();
            CL_SL_Calc();
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            LabExtDia.Text = Math.Round(CLSLParas.ExtDia, 2).ToString("f2");
            LabWallThick.Text = Math.Round(CLSLParas.WallThick, 2).ToString("f2");
            LabTotalHight.Text = Math.Round(CLSLParas.TotalHeight, 2).ToString("f2");
            LabAngleRadius.Text = Math.Round(CLSLParas.DegreeRadius, 2).ToString("f2");
            LabArcRadius.Text = Math.Round(CLSLParas.ArcRadius, 2).ToString("f2");
            LabLoadWeig.Text = Math.Round(CLSLParas.LoadWeight, 2).ToString("f2");
            LabDiameter.Text = Math.Round(CLSLParas.Diameter, 2).ToString("f2");
            LabMaxLoad.Text = Math.Round(MaxLoad, 2).ToString("f2");
            LabMeltDepth.Text = Math.Round(MeltDepth, 1).ToString("f1");
            LabCL_SL.Text = Math.Round(CL_SL, 3).ToString("f3");
            LabCylinderWeig.Text = Math.Round(CylinderWeig, 2).ToString("f2");
            LabDiacusWeig.Text = Math.Round(DiacusWeig, 2).ToString("f2");
            LabSegmentWeig.Text = Math.Round(SegmentWeig, 2).ToString("f2");
        }
        private void LabExtDia_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm();
            kf.ImportData(ref LabExtDia, 100, 2000);
            kf.ShowDialog();
        }
        private void LabWallThick_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm();
            kf.ImportData(ref LabWallThick, 1, 50);
            kf.ShowDialog();
        }
        private void LabTotalHight_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm();
            kf.ImportData(ref LabTotalHight, 100, 2000);
            kf.ShowDialog();
        }
        private void LabAngleRadius_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm();
            kf.ImportData(ref LabAngleRadius, 10, 360);
            kf.ShowDialog();
        }
        private void LabArcRadius_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm();
            kf.ImportData(ref LabArcRadius, 200, 2000);
            kf.ShowDialog();
        }
        private void LabLoadWeig_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm();
            kf.ImportData(ref LabLoadWeig, 0, 2000);
            kf.ShowDialog();
        }
        private void LabDiameter_Click(object sender, EventArgs e)
        {
            KeyForm kf = new KeyForm();
            kf.ImportData(ref LabDiameter, 1, 1000);
            kf.ShowDialog();
        }
        private void LabExtDia_TextChanged(object sender, EventArgs e)
        {
            CLSLParas.ExtDia = double.Parse(LabExtDia.Text);
            CLSLParas.WriteIn(LabExtDia.Text, 1);
            WeightCalc();
        }
        private void LabWallThick_TextChanged(object sender, EventArgs e)
        {
            CLSLParas.WallThick = double.Parse(LabWallThick.Text);
            CLSLParas.WriteIn(LabWallThick.Text, 2);
            WeightCalc();
        }
        private void LabTotalHight_TextChanged(object sender, EventArgs e)
        {
            CLSLParas.TotalHeight = double.Parse(LabTotalHight.Text);
            CLSLParas.WriteIn(LabTotalHight.Text, 3);
            WeightCalc();
        }
        private void LabAngleRadius_TextChanged(object sender, EventArgs e)
        {
            CLSLParas.DegreeRadius = double.Parse(LabAngleRadius.Text);
            CLSLParas.WriteIn(LabAngleRadius.Text, 4);
            WeightCalc();
        }
        private void LabArcRadius_TextChanged(object sender, EventArgs e)
        {
            CLSLParas.ArcRadius = double.Parse(LabArcRadius.Text);
            CLSLParas.WriteIn(LabArcRadius.Text, 5);
            WeightCalc();
        }
        private void LabLoadWeig_TextChanged(object sender, EventArgs e)
        {
            CLSLParas.LoadWeight = double.Parse(LabLoadWeig.Text);
            CLSLParas.WriteIn(LabLoadWeig.Text, 6);
            WeightCalc();
        }
        private void LabDiameter_TextChanged(object sender, EventArgs e)
        {
            CLSLParas.Diameter = double.Parse(LabDiameter.Text);
            CLSLParas.WriteIn(LabDiameter.Text, 7);
            WeightCalc();
        }
        private void WeightCalc()
        {
            // 硅固体密度为2.33g/cm3, 硅液体密度为2.56g/cm3
            // 圆柱体积V=πr²h
            // 圆台体积V=1/3πh(r²+R²+rR)
            // 球冠体积V=1/6πh(3r²+h²)
            double Density = 2.56;
            // 坩埚内半径      
            // 倒角高度计算
            double InterRadius = (CLSLParas.ExtDia - CLSLParas.WallThick * 2) / 2;    // 坩埚内半径
            DegreeHeight = (CLSLParas.DegreeRadius / (CLSLParas.ArcRadius - CLSLParas.DegreeRadius)) * Math.Sqrt(Math.Pow(CLSLParas.ArcRadius - CLSLParas.DegreeRadius, 2) - Math.Pow(InterRadius - CLSLParas.DegreeRadius, 2));
            // 圆弧高度计算
            CLSLParas.ArcHeight = CLSLParas.ArcRadius - ((CLSLParas.ArcRadius / (CLSLParas.ArcRadius - CLSLParas.DegreeRadius)) * Math.Sqrt(Math.Pow(CLSLParas.ArcRadius - CLSLParas.DegreeRadius, 2) - Math.Pow(InterRadius - CLSLParas.DegreeRadius, 2)));
            // 圆柱高度计算
            ColumnHeight = CLSLParas.TotalHeight - CLSLParas.WallThick - DegreeHeight - CLSLParas.ArcHeight;
            // 倒角部分重量计算
            DegreeNum = (int)(DegreeHeight / 0.01);
            Ra = new double[DegreeNum + 1];
            Ra[0] = InterRadius;
            for (int i = 1; i <= DegreeNum; i++)
            {
                Ra[i] = InterRadius - CLSLParas.DegreeRadius + Math.Sqrt(Math.Pow(CLSLParas.DegreeRadius, 2) - Math.Pow(0.01 * i, 2));
            }
            Wa = new double[DegreeNum];
            Ha = new double[DegreeNum];
            Ha[0] = 0.01;
            Wa[0] = ((1f / 3) * Math.PI * 0.01 * (Math.Pow(Ra[DegreeNum], 2) + Math.Pow(Ra[DegreeNum - 1], 2) + Ra[DegreeNum] * Ra[DegreeNum - 1])) * Density / Math.Pow(10, 6);
            for (int i = 1; i <= DegreeNum - 1; i++)
            {
                Ha[i] = Ha[i - 1] + 0.01;
                Wa[i] = Wa[i - 1] + ((1f / 3) * Math.PI * 0.01 * (Math.Pow(Ra[DegreeNum - i], 2) + Math.Pow(Ra[DegreeNum - 1 - i], 2) + Ra[DegreeNum - i] * Ra[DegreeNum - 1 - i])) * Density / Math.Pow(10, 6);
            }
            DegreeWeig = Wa[DegreeNum - 1];
            // 圆弧部分重量计算
            Rb = Math.Sqrt(Math.Pow(CLSLParas.ArcRadius, 2) - Math.Pow(CLSLParas.ArcRadius - CLSLParas.ArcHeight, 2));
            Vb = (1f / 6) * Math.PI * CLSLParas.ArcHeight * (3 * Math.Pow(Rb, 2) + Math.Pow(CLSLParas.ArcHeight, 2));
            ArcWeig = Vb * Density / Math.Pow(10, 6);
            ArcNum = (int)(CLSLParas.ArcHeight / 0.01);
            Rc = new double[(int)(ArcNum + 1)];
            Rc[0] = Rb;
            for (int i = 1; i <= ArcNum; i++)
            {
                Rc[i] = Math.Sqrt(Math.Pow(CLSLParas.ArcRadius, 2) - Math.Pow(CLSLParas.ArcRadius - CLSLParas.ArcHeight + 0.01 * i, 2));
            }
            Wc = new double[(int)ArcNum];
            Hc = new double[(int)ArcNum];
            for (int i = 1; i <= ArcNum; i++)
            {
                Hc[i - 1] = 0.01 * i;
                Wc[i - 1] = ((1f / 6) * Math.PI * (CLSLParas.ArcHeight - 0.01 * (ArcNum - i)) * (3 * Math.Pow(Rc[(int)ArcNum - i], 2) + Math.Pow(CLSLParas.ArcHeight - 0.01 * (ArcNum - i), 2))) * Density / Math.Pow(10, 6);
            }
            // 圆柱部分及总重量计算
            ColumnWeig = Math.PI * Math.Pow(Ra[0], 2) * (ColumnHeight) * Density / Math.Pow(10, 6);
            MaxLoad = ColumnWeig + DegreeWeig + ArcWeig;
            MeltDepthCalc();
            CL_SL_Calc();
        }
        private void MeltDepthCalc()
        {
            // 硅固体密度为2.33g/cm3, 硅液体密度为2.56g/cm3
            // 圆柱体积V=πr²h
            double InterRadius = (CLSLParas.ExtDia - CLSLParas.WallThick * 2) / 2;
            //坩埚内半径
            double RealColumnWeig = CLSLParas.LoadWeight - (DegreeWeig + ArcWeig);
            if (RealColumnWeig >= 0)
            {
                CylinderWeig = RealColumnWeig;
                DiacusWeig = DegreeWeig;
                SegmentWeig = ArcWeig;
                double MeltColumnHeight = (RealColumnWeig * Math.Pow(10, 6) / 2.56) / (Math.PI * Math.Pow(InterRadius, 2));
                MeltDepth = MeltColumnHeight + DegreeHeight + CLSLParas.ArcHeight;
                DegIndex = 0;
                ArcIndex = 0;
            }
            else
            {
                if (CLSLParas.LoadWeight >= ArcWeig)
                {
                    double RealDegreeWeig = CLSLParas.LoadWeight - ArcWeig;
                    int Head = 0;
                    int Tail = Wa.Length - 1;
                    int Mid;
                    CylinderWeig = 0;
                    DiacusWeig = RealDegreeWeig;
                    SegmentWeig = ArcWeig;
                    while ((Tail - Head) > 256)
                    {
                        Mid = (Tail - Head) / 2 + Head;
                        if (RealDegreeWeig == Wa[Mid])
                        {
                            Head = Mid;
                            Tail = Mid;
                            break;
                        }
                        else if (RealDegreeWeig < Wa[Mid])
                        {
                            Tail = Mid;
                        }
                        else
                        {
                            Head = Mid;
                        }
                    }
                    for (int i = Head; i <= Tail; i++)
                    {
                        if (RealDegreeWeig < Wa[i])
                        {
                            MeltDepth = Ha[i] + CLSLParas.ArcHeight;
                            DegIndex = i;
                            ArcIndex = 0;
                            break;
                        }
                    }
                }
                else if (CLSLParas.LoadWeight > 0)
                {
                    int Head = 0;
                    int Tail = Wc.Length - 1;
                    int Mid;
                    CylinderWeig = 0;
                    DiacusWeig = 0;
                    SegmentWeig = CLSLParas.LoadWeight;
                    while (Tail - Head > 256)
                    {
                        Mid = (Tail - Head) / 2 + Head;
                        if (CLSLParas.LoadWeight == Wc[Mid])
                        {
                            Head = Mid;
                            Tail = Mid;
                            break;
                        }
                        else if (CLSLParas.LoadWeight < Wc[Mid])
                        {
                            Tail = Mid;
                        }
                        else
                        {
                            Head = Mid;
                        }
                    }
                    for (int i = Head; i <= Tail; i++)
                    {
                        if (CLSLParas.LoadWeight < Wc[i])
                        {
                            MeltDepth = Hc[i];
                            DegIndex = 0;
                            ArcIndex = i;
                            break;
                        }
                    }
                }
                else
                {
                    CylinderWeig = 0;
                    DiacusWeig = 0;
                    SegmentWeig = 0;
                    MeltDepth = 0;
                    DegIndex = 0;
                    ArcIndex = 0;
                }
            }
        }
        private void CL_SL_Calc()
        {
            double InterRadius = 0, DiaRadius;
            if (DegIndex == 0 && ArcIndex == 0)
            {
                //坩埚内半径
                InterRadius = (CLSLParas.ExtDia - CLSLParas.WallThick * 2) / 2;
            }
            else
            {
                if (DegIndex > 0)
                {
                    //坩埚内半径
                    InterRadius = Ra[DegreeNum - DegIndex];
                }
                if (ArcIndex > 0)
                {
                    //坩埚内半径
                    InterRadius = Rc[(int)(ArcNum - ArcIndex)];
                }
            }
            DiaRadius = CLSLParas.Diameter / 2;
            CL_SL = Math.Pow(DiaRadius, 2) * 2.33 / (Math.Pow(InterRadius, 2) * 2.56);
        }
    }
}