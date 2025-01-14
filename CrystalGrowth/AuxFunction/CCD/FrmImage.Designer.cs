namespace CrystalGrowth.AuxFunction.CCD
{
    partial class FrmImage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.LabFinalDia = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.LabFinalMeltGap = new System.Windows.Forms.Label();
            this.LabShortMeltGapPxl = new System.Windows.Forms.Label();
            this.LabYPos = new System.Windows.Forms.Label();
            this.LabRealDiaPixel = new System.Windows.Forms.Label();
            this.LabLongMeltGapPxl = new System.Windows.Forms.Label();
            this.LabMiddleMeltGapPxl = new System.Windows.Forms.Label();
            this.LabLaser = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LabSL = new System.Windows.Forms.Label();
            this.LabGrowthSpeed = new System.Windows.Forms.Label();
            this.LabCutLineProp = new System.Windows.Forms.Label();
            this.LabCrystalShake = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LabGeneral6 = new System.Windows.Forms.Label();
            this.LabGeneral5 = new System.Windows.Forms.Label();
            this.LabGeneral4 = new System.Windows.Forms.Label();
            this.LabGeneral3 = new System.Windows.Forms.Label();
            this.LabGeneral2 = new System.Windows.Forms.Label();
            this.LabGeneral1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LabPixlRt = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.LabPixlAvg = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LabMeltTemp = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblDraw2 = new System.Windows.Forms.Label();
            this.LblDraw1 = new System.Windows.Forms.Label();
            this.Timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 250;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // LabFinalDia
            // 
            this.LabFinalDia.BackColor = System.Drawing.Color.Black;
            this.LabFinalDia.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabFinalDia.ForeColor = System.Drawing.Color.White;
            this.LabFinalDia.Location = new System.Drawing.Point(83, 0);
            this.LabFinalDia.Name = "LabFinalDia";
            this.LabFinalDia.Size = new System.Drawing.Size(84, 20);
            this.LabFinalDia.TabIndex = 128;
            this.LabFinalDia.Text = "0.00";
            this.LabFinalDia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Black;
            this.Label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(167, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(68, 20);
            this.Label2.TabIndex = 129;
            this.Label2.Text = "液口距:";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.Black;
            this.Label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label3.ForeColor = System.Drawing.Color.IndianRed;
            this.Label3.Location = new System.Drawing.Point(0, 60);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(51, 20);
            this.Label3.TabIndex = 129;
            this.Label3.Text = "Y轴:";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabFinalMeltGap
            // 
            this.LabFinalMeltGap.BackColor = System.Drawing.Color.Black;
            this.LabFinalMeltGap.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabFinalMeltGap.ForeColor = System.Drawing.Color.White;
            this.LabFinalMeltGap.Location = new System.Drawing.Point(235, 0);
            this.LabFinalMeltGap.Name = "LabFinalMeltGap";
            this.LabFinalMeltGap.Size = new System.Drawing.Size(65, 20);
            this.LabFinalMeltGap.TabIndex = 130;
            this.LabFinalMeltGap.Text = "0.0";
            this.LabFinalMeltGap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabShortMeltGapPxl
            // 
            this.LabShortMeltGapPxl.BackColor = System.Drawing.Color.Black;
            this.LabShortMeltGapPxl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabShortMeltGapPxl.ForeColor = System.Drawing.Color.Red;
            this.LabShortMeltGapPxl.Location = new System.Drawing.Point(167, 20);
            this.LabShortMeltGapPxl.Name = "LabShortMeltGapPxl";
            this.LabShortMeltGapPxl.Size = new System.Drawing.Size(68, 20);
            this.LabShortMeltGapPxl.TabIndex = 130;
            this.LabShortMeltGapPxl.Text = "0.0";
            this.LabShortMeltGapPxl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabYPos
            // 
            this.LabYPos.BackColor = System.Drawing.Color.Black;
            this.LabYPos.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabYPos.ForeColor = System.Drawing.Color.IndianRed;
            this.LabYPos.Location = new System.Drawing.Point(51, 60);
            this.LabYPos.Name = "LabYPos";
            this.LabYPos.Size = new System.Drawing.Size(71, 20);
            this.LabYPos.TabIndex = 130;
            this.LabYPos.Text = "0.0";
            this.LabYPos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabRealDiaPixel
            // 
            this.LabRealDiaPixel.BackColor = System.Drawing.Color.Black;
            this.LabRealDiaPixel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabRealDiaPixel.ForeColor = System.Drawing.Color.White;
            this.LabRealDiaPixel.Location = new System.Drawing.Point(83, 20);
            this.LabRealDiaPixel.Name = "LabRealDiaPixel";
            this.LabRealDiaPixel.Size = new System.Drawing.Size(84, 20);
            this.LabRealDiaPixel.TabIndex = 134;
            this.LabRealDiaPixel.Text = "0.0";
            this.LabRealDiaPixel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabLongMeltGapPxl
            // 
            this.LabLongMeltGapPxl.BackColor = System.Drawing.Color.Black;
            this.LabLongMeltGapPxl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabLongMeltGapPxl.ForeColor = System.Drawing.Color.White;
            this.LabLongMeltGapPxl.Location = new System.Drawing.Point(300, 20);
            this.LabLongMeltGapPxl.Name = "LabLongMeltGapPxl";
            this.LabLongMeltGapPxl.Size = new System.Drawing.Size(65, 20);
            this.LabLongMeltGapPxl.TabIndex = 135;
            this.LabLongMeltGapPxl.Text = "0.0";
            this.LabLongMeltGapPxl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabMiddleMeltGapPxl
            // 
            this.LabMiddleMeltGapPxl.BackColor = System.Drawing.Color.Black;
            this.LabMiddleMeltGapPxl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabMiddleMeltGapPxl.ForeColor = System.Drawing.Color.YellowGreen;
            this.LabMiddleMeltGapPxl.Location = new System.Drawing.Point(233, 20);
            this.LabMiddleMeltGapPxl.Name = "LabMiddleMeltGapPxl";
            this.LabMiddleMeltGapPxl.Size = new System.Drawing.Size(67, 20);
            this.LabMiddleMeltGapPxl.TabIndex = 135;
            this.LabMiddleMeltGapPxl.Text = "0.0";
            this.LabMiddleMeltGapPxl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabLaser
            // 
            this.LabLaser.BackColor = System.Drawing.Color.Black;
            this.LabLaser.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabLaser.ForeColor = System.Drawing.Color.White;
            this.LabLaser.Location = new System.Drawing.Point(300, 0);
            this.LabLaser.Name = "LabLaser";
            this.LabLaser.Size = new System.Drawing.Size(65, 20);
            this.LabLaser.TabIndex = 138;
            this.LabLaser.Text = "0.0";
            this.LabLaser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.LabPixlRt);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.LabPixlAvg);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.LabMeltTemp);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LabLongMeltGapPxl);
            this.panel1.Controls.Add(this.LabLaser);
            this.panel1.Controls.Add(this.LabMiddleMeltGapPxl);
            this.panel1.Controls.Add(this.LabFinalMeltGap);
            this.panel1.Controls.Add(this.LabShortMeltGapPxl);
            this.panel1.Controls.Add(this.Label2);
            this.panel1.Controls.Add(this.LabRealDiaPixel);
            this.panel1.Controls.Add(this.LabYPos);
            this.panel1.Controls.Add(this.LabFinalDia);
            this.panel1.Controls.Add(this.Label3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.LblDraw1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 475);
            this.panel1.TabIndex = 139;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Controls.Add(this.Label7);
            this.panel5.Controls.Add(this.Label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.LabSL);
            this.panel5.Controls.Add(this.LabGrowthSpeed);
            this.panel5.Controls.Add(this.LabCutLineProp);
            this.panel5.Controls.Add(this.LabCrystalShake);
            this.panel5.Location = new System.Drawing.Point(533, 406);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(115, 68);
            this.panel5.TabIndex = 155;
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.Color.Black;
            this.Label7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label7.ForeColor = System.Drawing.Color.White;
            this.Label7.Location = new System.Drawing.Point(-2, 17);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(65, 15);
            this.Label7.TabIndex = 137;
            this.Label7.Text = "生长速度:";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.Black;
            this.Label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label6.ForeColor = System.Drawing.Color.White;
            this.Label6.Location = new System.Drawing.Point(-2, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(65, 15);
            this.Label6.TabIndex = 130;
            this.Label6.Text = "晶升速度:";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(-2, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 139;
            this.label5.Text = "断线概率:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(-2, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 15);
            this.label8.TabIndex = 140;
            this.label8.Text = "晶体晃动:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabSL
            // 
            this.LabSL.BackColor = System.Drawing.Color.Black;
            this.LabSL.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabSL.ForeColor = System.Drawing.Color.White;
            this.LabSL.Location = new System.Drawing.Point(62, 0);
            this.LabSL.Name = "LabSL";
            this.LabSL.Size = new System.Drawing.Size(60, 15);
            this.LabSL.TabIndex = 136;
            this.LabSL.Text = "0.0";
            this.LabSL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabGrowthSpeed
            // 
            this.LabGrowthSpeed.BackColor = System.Drawing.Color.Black;
            this.LabGrowthSpeed.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabGrowthSpeed.ForeColor = System.Drawing.Color.White;
            this.LabGrowthSpeed.Location = new System.Drawing.Point(62, 17);
            this.LabGrowthSpeed.Name = "LabGrowthSpeed";
            this.LabGrowthSpeed.Size = new System.Drawing.Size(60, 15);
            this.LabGrowthSpeed.TabIndex = 138;
            this.LabGrowthSpeed.Text = "0.0";
            this.LabGrowthSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabCutLineProp
            // 
            this.LabCutLineProp.BackColor = System.Drawing.Color.Black;
            this.LabCutLineProp.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabCutLineProp.ForeColor = System.Drawing.Color.White;
            this.LabCutLineProp.Location = new System.Drawing.Point(62, 34);
            this.LabCutLineProp.Name = "LabCutLineProp";
            this.LabCutLineProp.Size = new System.Drawing.Size(60, 15);
            this.LabCutLineProp.TabIndex = 141;
            this.LabCutLineProp.Text = "0.0";
            this.LabCutLineProp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabCrystalShake
            // 
            this.LabCrystalShake.BackColor = System.Drawing.Color.Black;
            this.LabCrystalShake.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabCrystalShake.ForeColor = System.Drawing.Color.White;
            this.LabCrystalShake.Location = new System.Drawing.Point(62, 51);
            this.LabCrystalShake.Name = "LabCrystalShake";
            this.LabCrystalShake.Size = new System.Drawing.Size(60, 15);
            this.LabCrystalShake.TabIndex = 142;
            this.LabCrystalShake.Text = "0.0";
            this.LabCrystalShake.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.LabGeneral6);
            this.panel3.Controls.Add(this.LabGeneral5);
            this.panel3.Controls.Add(this.LabGeneral4);
            this.panel3.Controls.Add(this.LabGeneral3);
            this.panel3.Controls.Add(this.LabGeneral2);
            this.panel3.Controls.Add(this.LabGeneral1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(507, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(141, 112);
            this.panel3.TabIndex = 154;
            // 
            // LabGeneral6
            // 
            this.LabGeneral6.AutoSize = true;
            this.LabGeneral6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabGeneral6.ForeColor = System.Drawing.Color.White;
            this.LabGeneral6.Location = new System.Drawing.Point(3, 96);
            this.LabGeneral6.Name = "LabGeneral6";
            this.LabGeneral6.Size = new System.Drawing.Size(72, 12);
            this.LabGeneral6.TabIndex = 167;
            this.LabGeneral6.Text = "参数6：0.0";
            // 
            // LabGeneral5
            // 
            this.LabGeneral5.AutoSize = true;
            this.LabGeneral5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabGeneral5.ForeColor = System.Drawing.Color.White;
            this.LabGeneral5.Location = new System.Drawing.Point(3, 79);
            this.LabGeneral5.Name = "LabGeneral5";
            this.LabGeneral5.Size = new System.Drawing.Size(72, 12);
            this.LabGeneral5.TabIndex = 166;
            this.LabGeneral5.Text = "参数5：0.0";
            // 
            // LabGeneral4
            // 
            this.LabGeneral4.AutoSize = true;
            this.LabGeneral4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabGeneral4.ForeColor = System.Drawing.Color.White;
            this.LabGeneral4.Location = new System.Drawing.Point(3, 60);
            this.LabGeneral4.Name = "LabGeneral4";
            this.LabGeneral4.Size = new System.Drawing.Size(72, 12);
            this.LabGeneral4.TabIndex = 165;
            this.LabGeneral4.Text = "参数4：0.0";
            // 
            // LabGeneral3
            // 
            this.LabGeneral3.AutoSize = true;
            this.LabGeneral3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabGeneral3.ForeColor = System.Drawing.Color.White;
            this.LabGeneral3.Location = new System.Drawing.Point(3, 42);
            this.LabGeneral3.Name = "LabGeneral3";
            this.LabGeneral3.Size = new System.Drawing.Size(72, 12);
            this.LabGeneral3.TabIndex = 164;
            this.LabGeneral3.Text = "参数3：0.0";
            // 
            // LabGeneral2
            // 
            this.LabGeneral2.AutoSize = true;
            this.LabGeneral2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabGeneral2.ForeColor = System.Drawing.Color.White;
            this.LabGeneral2.Location = new System.Drawing.Point(3, 23);
            this.LabGeneral2.Name = "LabGeneral2";
            this.LabGeneral2.Size = new System.Drawing.Size(72, 12);
            this.LabGeneral2.TabIndex = 163;
            this.LabGeneral2.Text = "参数2：0.0";
            // 
            // LabGeneral1
            // 
            this.LabGeneral1.AutoSize = true;
            this.LabGeneral1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabGeneral1.ForeColor = System.Drawing.Color.White;
            this.LabGeneral1.Location = new System.Drawing.Point(3, 5);
            this.LabGeneral1.Name = "LabGeneral1";
            this.LabGeneral1.Size = new System.Drawing.Size(72, 12);
            this.LabGeneral1.TabIndex = 162;
            this.LabGeneral1.Text = "参数1：0.0";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Location = new System.Drawing.Point(-364, 412);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(123, 104);
            this.panel4.TabIndex = 161;
            // 
            // LabPixlRt
            // 
            this.LabPixlRt.BackColor = System.Drawing.Color.Black;
            this.LabPixlRt.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabPixlRt.ForeColor = System.Drawing.Color.YellowGreen;
            this.LabPixlRt.Location = new System.Drawing.Point(296, 40);
            this.LabPixlRt.Name = "LabPixlRt";
            this.LabPixlRt.Size = new System.Drawing.Size(69, 20);
            this.LabPixlRt.TabIndex = 151;
            this.LabPixlRt.Text = "0.0";
            this.LabPixlRt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Black;
            this.label12.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(262, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 20);
            this.label12.TabIndex = 150;
            this.label12.Text = "RT:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabPixlAvg
            // 
            this.LabPixlAvg.BackColor = System.Drawing.Color.Black;
            this.LabPixlAvg.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabPixlAvg.ForeColor = System.Drawing.Color.YellowGreen;
            this.LabPixlAvg.Location = new System.Drawing.Point(195, 40);
            this.LabPixlAvg.Name = "LabPixlAvg";
            this.LabPixlAvg.Size = new System.Drawing.Size(67, 20);
            this.LabPixlAvg.TabIndex = 149;
            this.LabPixlAvg.Text = "0.0";
            this.LabPixlAvg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(152, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 20);
            this.label10.TabIndex = 148;
            this.label10.Text = "AVG:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabMeltTemp
            // 
            this.LabMeltTemp.BackColor = System.Drawing.Color.Black;
            this.LabMeltTemp.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabMeltTemp.ForeColor = System.Drawing.Color.White;
            this.LabMeltTemp.Location = new System.Drawing.Point(85, 40);
            this.LabMeltTemp.Name = "LabMeltTemp";
            this.LabMeltTemp.Size = new System.Drawing.Size(68, 20);
            this.LabMeltTemp.TabIndex = 147;
            this.LabMeltTemp.Text = "0.0";
            this.LabMeltTemp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(0, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 20);
            this.label9.TabIndex = 146;
            this.label9.Text = "液面温度:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 145;
            this.label4.Text = "直径像素:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 144;
            this.label1.Text = "实际直径:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.LblDraw2);
            this.panel2.Location = new System.Drawing.Point(491, 115);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(158, 115);
            this.panel2.TabIndex = 143;
            // 
            // LblDraw2
            // 
            this.LblDraw2.BackColor = System.Drawing.Color.Transparent;
            this.LblDraw2.Location = new System.Drawing.Point(95, 0);
            this.LblDraw2.Margin = new System.Windows.Forms.Padding(0);
            this.LblDraw2.Name = "LblDraw2";
            this.LblDraw2.Size = new System.Drawing.Size(59, 43);
            this.LblDraw2.TabIndex = 144;
            this.LblDraw2.Paint += new System.Windows.Forms.PaintEventHandler(this.LblDraw2_Paint);
            this.LblDraw2.DoubleClick += new System.EventHandler(this.LblDraw2_DoubleClick);
            this.LblDraw2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LblDraw2_MouseDoubleClick);
            this.LblDraw2.MouseLeave += new System.EventHandler(this.LblDraw2_MouseLeave);
            this.LblDraw2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LblDraw2_MouseMove);
            // 
            // LblDraw1
            // 
            this.LblDraw1.BackColor = System.Drawing.Color.Transparent;
            this.LblDraw1.Location = new System.Drawing.Point(545, 370);
            this.LblDraw1.Margin = new System.Windows.Forms.Padding(0);
            this.LblDraw1.Name = "LblDraw1";
            this.LblDraw1.Size = new System.Drawing.Size(100, 100);
            this.LblDraw1.TabIndex = 2;
            this.LblDraw1.Paint += new System.Windows.Forms.PaintEventHandler(this.LblDraw1_Paint);
            this.LblDraw1.DoubleClick += new System.EventHandler(this.LblDraw1_DoubleClick);
            this.LblDraw1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LblDraw1_MouseDoubleClick);
            this.LblDraw1.MouseLeave += new System.EventHandler(this.LblDraw1_MouseLeave);
            this.LblDraw1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LblDraw1_MouseMove);
            // 
            // Timer2
            // 
            this.Timer2.Enabled = true;
            this.Timer2.Interval = 250;
            this.Timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // FrmImage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(650, 475);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmImage";
            this.Text = "FrmImage";
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer Timer1;
        internal System.Windows.Forms.Label LabFinalDia;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label LabFinalMeltGap;
        internal System.Windows.Forms.Label LabShortMeltGapPxl;
        internal System.Windows.Forms.Label LabYPos;
        internal System.Windows.Forms.Label LabRealDiaPixel;
        internal System.Windows.Forms.Label LabLongMeltGapPxl;
        internal System.Windows.Forms.Label LabMiddleMeltGapPxl;
        internal System.Windows.Forms.Label LabLaser;
        private System.Windows.Forms.Label LblDraw1;
        internal System.Windows.Forms.Label LabGrowthSpeed;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label LabSL;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Label LabCrystalShake;
        internal System.Windows.Forms.Label LabCutLineProp;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer Timer2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblDraw2;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label LabMeltTemp;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label LabPixlRt;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.Label LabPixlAvg;
        internal System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LabGeneral6;
        private System.Windows.Forms.Label LabGeneral5;
        private System.Windows.Forms.Label LabGeneral4;
        private System.Windows.Forms.Label LabGeneral3;
        private System.Windows.Forms.Label LabGeneral2;
        private System.Windows.Forms.Label LabGeneral1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}