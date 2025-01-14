namespace CrystalGrowth.CrystalCtl
{
    partial class FrmMeltGapSafe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMeltGapSafe));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnON_2 = new System.Windows.Forms.Button();
            this.BtnOFF_2 = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnON_1 = new System.Windows.Forms.Button();
            this.BtnOFF_1 = new System.Windows.Forms.Button();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.LabMeltGapSafeValue = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.LabMaxLoad = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.LabMeltDepth = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.LabMeltShield = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.LabTotalHight = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.LabWallThick = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.LabAngleRadius = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.LabArcRadius = new System.Windows.Forms.Label();
            this.LabExtDia = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.Panel1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.DarkGray;
            this.Panel1.Controls.Add(this.GroupBox2);
            this.Panel1.Controls.Add(this.GroupBox1);
            this.Panel1.Controls.Add(this.BtnQuit);
            this.Panel1.Controls.Add(this.GroupBox3);
            this.Panel1.Location = new System.Drawing.Point(0, 388);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(520, 124);
            this.Panel1.TabIndex = 136;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.BtnON_2);
            this.GroupBox2.Controls.Add(this.BtnOFF_2);
            this.GroupBox2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GroupBox2.ForeColor = System.Drawing.Color.White;
            this.GroupBox2.Location = new System.Drawing.Point(145, 4);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(125, 111);
            this.GroupBox2.TabIndex = 138;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "视觉液口距";
            // 
            // BtnON_2
            // 
            this.BtnON_2.BackColor = System.Drawing.Color.Blue;
            this.BtnON_2.FlatAppearance.BorderSize = 0;
            this.BtnON_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnON_2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnON_2.ForeColor = System.Drawing.Color.White;
            this.BtnON_2.Location = new System.Drawing.Point(12, 23);
            this.BtnON_2.Name = "BtnON_2";
            this.BtnON_2.Size = new System.Drawing.Size(100, 35);
            this.BtnON_2.TabIndex = 135;
            this.BtnON_2.Text = "保护开";
            this.BtnON_2.UseVisualStyleBackColor = false;
            this.BtnON_2.Click += new System.EventHandler(this.BtnON_2_Click);
            // 
            // BtnOFF_2
            // 
            this.BtnOFF_2.BackColor = System.Drawing.Color.Blue;
            this.BtnOFF_2.FlatAppearance.BorderSize = 0;
            this.BtnOFF_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOFF_2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnOFF_2.ForeColor = System.Drawing.Color.White;
            this.BtnOFF_2.Location = new System.Drawing.Point(12, 68);
            this.BtnOFF_2.Name = "BtnOFF_2";
            this.BtnOFF_2.Size = new System.Drawing.Size(100, 35);
            this.BtnOFF_2.TabIndex = 136;
            this.BtnOFF_2.Text = "保护关";
            this.BtnOFF_2.UseVisualStyleBackColor = false;
            this.BtnOFF_2.Click += new System.EventHandler(this.BtnOFF_2_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.BtnON_1);
            this.GroupBox1.Controls.Add(this.BtnOFF_1);
            this.GroupBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GroupBox1.ForeColor = System.Drawing.Color.White;
            this.GroupBox1.Location = new System.Drawing.Point(14, 4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(125, 111);
            this.GroupBox1.TabIndex = 137;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "重量液口距";
            // 
            // BtnON_1
            // 
            this.BtnON_1.BackColor = System.Drawing.Color.Blue;
            this.BtnON_1.FlatAppearance.BorderSize = 0;
            this.BtnON_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnON_1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnON_1.ForeColor = System.Drawing.Color.White;
            this.BtnON_1.Location = new System.Drawing.Point(13, 23);
            this.BtnON_1.Name = "BtnON_1";
            this.BtnON_1.Size = new System.Drawing.Size(100, 35);
            this.BtnON_1.TabIndex = 111;
            this.BtnON_1.Text = "保护开";
            this.BtnON_1.UseVisualStyleBackColor = false;
            this.BtnON_1.Click += new System.EventHandler(this.BtnON_1_Click);
            // 
            // BtnOFF_1
            // 
            this.BtnOFF_1.BackColor = System.Drawing.Color.Blue;
            this.BtnOFF_1.FlatAppearance.BorderSize = 0;
            this.BtnOFF_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOFF_1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnOFF_1.ForeColor = System.Drawing.Color.White;
            this.BtnOFF_1.Location = new System.Drawing.Point(13, 68);
            this.BtnOFF_1.Name = "BtnOFF_1";
            this.BtnOFF_1.Size = new System.Drawing.Size(100, 35);
            this.BtnOFF_1.TabIndex = 112;
            this.BtnOFF_1.Text = "保护关";
            this.BtnOFF_1.UseVisualStyleBackColor = false;
            this.BtnOFF_1.Click += new System.EventHandler(this.BtnOFF_1_Click);
            // 
            // BtnQuit
            // 
            this.BtnQuit.BackColor = System.Drawing.Color.Blue;
            this.BtnQuit.FlatAppearance.BorderSize = 0;
            this.BtnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnQuit.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnQuit.ForeColor = System.Drawing.Color.White;
            this.BtnQuit.Location = new System.Drawing.Point(412, 39);
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.Size = new System.Drawing.Size(100, 55);
            this.BtnQuit.TabIndex = 134;
            this.BtnQuit.Text = "退出";
            this.BtnQuit.UseVisualStyleBackColor = false;
            this.BtnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.LabMeltGapSafeValue);
            this.GroupBox3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GroupBox3.ForeColor = System.Drawing.Color.White;
            this.GroupBox3.Location = new System.Drawing.Point(278, 4);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(125, 111);
            this.GroupBox3.TabIndex = 139;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "坩埚快升保护像素值";
            // 
            // LabMeltGapSafeValue
            // 
            this.LabMeltGapSafeValue.BackColor = System.Drawing.Color.DarkCyan;
            this.LabMeltGapSafeValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabMeltGapSafeValue.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabMeltGapSafeValue.ForeColor = System.Drawing.Color.Black;
            this.LabMeltGapSafeValue.Location = new System.Drawing.Point(17, 41);
            this.LabMeltGapSafeValue.Name = "LabMeltGapSafeValue";
            this.LabMeltGapSafeValue.Size = new System.Drawing.Size(92, 43);
            this.LabMeltGapSafeValue.TabIndex = 94;
            this.LabMeltGapSafeValue.Text = "0.00";
            this.LabMeltGapSafeValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabMeltGapSafeValue.Click += new System.EventHandler(this.LabMeltGapSafeValue_Click);
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(474, 38);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(33, 20);
            this.Label5.TabIndex = 157;
            this.Label5.Text = "kg";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(373, 3);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(112, 20);
            this.Label1.TabIndex = 156;
            this.Label1.Text = "最大装料量";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabMaxLoad
            // 
            this.LabMaxLoad.BackColor = System.Drawing.Color.Gray;
            this.LabMaxLoad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabMaxLoad.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabMaxLoad.ForeColor = System.Drawing.Color.White;
            this.LabMaxLoad.Location = new System.Drawing.Point(389, 33);
            this.LabMaxLoad.Name = "LabMaxLoad";
            this.LabMaxLoad.Size = new System.Drawing.Size(80, 30);
            this.LabMaxLoad.TabIndex = 155;
            this.LabMaxLoad.Text = "0.00";
            this.LabMaxLoad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label17
            // 
            this.Label17.BackColor = System.Drawing.Color.Transparent;
            this.Label17.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label17.ForeColor = System.Drawing.Color.White;
            this.Label17.Location = new System.Drawing.Point(82, 150);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(95, 20);
            this.Label17.TabIndex = 154;
            this.Label17.Text = "熔液深度";
            this.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabMeltDepth
            // 
            this.LabMeltDepth.BackColor = System.Drawing.Color.Gray;
            this.LabMeltDepth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabMeltDepth.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabMeltDepth.ForeColor = System.Drawing.Color.White;
            this.LabMeltDepth.Location = new System.Drawing.Point(97, 175);
            this.LabMeltDepth.Name = "LabMeltDepth";
            this.LabMeltDepth.Size = new System.Drawing.Size(80, 30);
            this.LabMeltDepth.TabIndex = 153;
            this.LabMeltDepth.Text = "0.0";
            this.LabMeltDepth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label15
            // 
            this.Label15.BackColor = System.Drawing.Color.Transparent;
            this.Label15.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label15.ForeColor = System.Drawing.Color.White;
            this.Label15.Location = new System.Drawing.Point(52, 81);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(125, 20);
            this.Label15.TabIndex = 152;
            this.Label15.Text = "重量液口距";
            this.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabMeltShield
            // 
            this.LabMeltShield.BackColor = System.Drawing.Color.Gray;
            this.LabMeltShield.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabMeltShield.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabMeltShield.ForeColor = System.Drawing.Color.White;
            this.LabMeltShield.Location = new System.Drawing.Point(97, 106);
            this.LabMeltShield.Name = "LabMeltShield";
            this.LabMeltShield.Size = new System.Drawing.Size(80, 30);
            this.LabMeltShield.TabIndex = 151;
            this.LabMeltShield.Text = "0.0";
            this.LabMeltShield.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label14
            // 
            this.Label14.BackColor = System.Drawing.Color.Transparent;
            this.Label14.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label14.ForeColor = System.Drawing.Color.White;
            this.Label14.Location = new System.Drawing.Point(8, 3);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(95, 20);
            this.Label14.TabIndex = 150;
            this.Label14.Text = "单位(mm)";
            this.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label10
            // 
            this.Label10.BackColor = System.Drawing.Color.Transparent;
            this.Label10.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label10.ForeColor = System.Drawing.Color.White;
            this.Label10.Location = new System.Drawing.Point(372, 175);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(113, 20);
            this.Label10.TabIndex = 149;
            this.Label10.Text = "坩埚总高度";
            this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabTotalHight
            // 
            this.LabTotalHight.BackColor = System.Drawing.Color.White;
            this.LabTotalHight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabTotalHight.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabTotalHight.ForeColor = System.Drawing.Color.Black;
            this.LabTotalHight.Location = new System.Drawing.Point(389, 200);
            this.LabTotalHight.Name = "LabTotalHight";
            this.LabTotalHight.Size = new System.Drawing.Size(80, 30);
            this.LabTotalHight.TabIndex = 148;
            this.LabTotalHight.Text = "0.00";
            this.LabTotalHight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabTotalHight.TextChanged += new System.EventHandler(this.LabTotalHight_TextChanged);
            this.LabTotalHight.Click += new System.EventHandler(this.LabTotalHight_Click);
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label6.ForeColor = System.Drawing.Color.White;
            this.Label6.Location = new System.Drawing.Point(217, 82);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(95, 20);
            this.Label6.TabIndex = 147;
            this.Label6.Text = "坩埚壁厚";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabWallThick
            // 
            this.LabWallThick.BackColor = System.Drawing.Color.White;
            this.LabWallThick.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabWallThick.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabWallThick.ForeColor = System.Drawing.Color.Black;
            this.LabWallThick.Location = new System.Drawing.Point(232, 107);
            this.LabWallThick.Name = "LabWallThick";
            this.LabWallThick.Size = new System.Drawing.Size(80, 30);
            this.LabWallThick.TabIndex = 146;
            this.LabWallThick.Text = "0.00";
            this.LabWallThick.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabWallThick.TextChanged += new System.EventHandler(this.LabWallThick_TextChanged);
            this.LabWallThick.Click += new System.EventHandler(this.LabWallThick_Click);
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(209, 202);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(95, 20);
            this.Label4.TabIndex = 145;
            this.Label4.Text = "倒角半径";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabAngleRadius
            // 
            this.LabAngleRadius.BackColor = System.Drawing.Color.White;
            this.LabAngleRadius.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabAngleRadius.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabAngleRadius.ForeColor = System.Drawing.Color.Black;
            this.LabAngleRadius.Location = new System.Drawing.Point(224, 227);
            this.LabAngleRadius.Name = "LabAngleRadius";
            this.LabAngleRadius.Size = new System.Drawing.Size(80, 30);
            this.LabAngleRadius.TabIndex = 144;
            this.LabAngleRadius.Text = "0.00";
            this.LabAngleRadius.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabAngleRadius.TextChanged += new System.EventHandler(this.LabAngleRadius_TextChanged);
            this.LabAngleRadius.Click += new System.EventHandler(this.LabAngleRadius_Click);
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(67, 221);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(110, 20);
            this.Label3.TabIndex = 143;
            this.Label3.Text = "圆弧半径";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(148, 3);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(95, 20);
            this.Label2.TabIndex = 142;
            this.Label2.Text = "坩埚外径";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabArcRadius
            // 
            this.LabArcRadius.BackColor = System.Drawing.Color.White;
            this.LabArcRadius.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabArcRadius.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabArcRadius.ForeColor = System.Drawing.Color.Black;
            this.LabArcRadius.Location = new System.Drawing.Point(97, 246);
            this.LabArcRadius.Name = "LabArcRadius";
            this.LabArcRadius.Size = new System.Drawing.Size(80, 30);
            this.LabArcRadius.TabIndex = 141;
            this.LabArcRadius.Text = "0.00";
            this.LabArcRadius.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabArcRadius.TextChanged += new System.EventHandler(this.LabArcRadius_TextChanged);
            this.LabArcRadius.Click += new System.EventHandler(this.LabArcRadius_Click);
            // 
            // LabExtDia
            // 
            this.LabExtDia.BackColor = System.Drawing.Color.White;
            this.LabExtDia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabExtDia.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabExtDia.ForeColor = System.Drawing.Color.Black;
            this.LabExtDia.Location = new System.Drawing.Point(163, 33);
            this.LabExtDia.Name = "LabExtDia";
            this.LabExtDia.Size = new System.Drawing.Size(80, 30);
            this.LabExtDia.TabIndex = 140;
            this.LabExtDia.Text = "0.00";
            this.LabExtDia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabExtDia.TextChanged += new System.EventHandler(this.LabExtDia_TextChanged);
            this.LabExtDia.Click += new System.EventHandler(this.LabExtDia_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(4, 24);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(520, 368);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 139;
            this.PictureBox1.TabStop = false;
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 500;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // FrmMeltGapSafe
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(520, 510);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.LabMaxLoad);
            this.Controls.Add(this.Label17);
            this.Controls.Add(this.LabMeltDepth);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.LabMeltShield);
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.LabTotalHight);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.LabWallThick);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.LabAngleRadius);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.LabArcRadius);
            this.Controls.Add(this.LabExtDia);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMeltGapSafe";
            this.Text = "FrmMeltGapSafe";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMeltGapSafe_FormClosed);
            this.Panel1.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button BtnON_2;
        internal System.Windows.Forms.Button BtnOFF_2;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button BtnON_1;
        internal System.Windows.Forms.Button BtnOFF_1;
        internal System.Windows.Forms.Button BtnQuit;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Label LabMeltGapSafeValue;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label LabMaxLoad;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.Label LabMeltDepth;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Label LabMeltShield;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label LabTotalHight;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label LabWallThick;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label LabAngleRadius;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label LabArcRadius;
        internal System.Windows.Forms.Label LabExtDia;
        internal System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Timer Timer1;
    }
}