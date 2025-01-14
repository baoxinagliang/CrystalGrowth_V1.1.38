namespace CrystalGrowth.AuxFunction.Calibration
{
    partial class FrmShieldTrv
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
            this.LabDateTime = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.LabName = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.LabShieldPosDev = new System.Windows.Forms.Label();
            this.LabShieldDownTorque = new System.Windows.Forms.Label();
            this.LabShieldUpTorque = new System.Windows.Forms.Label();
            this.LabShieldActTorque = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label18 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.BtnShieldConfirm = new System.Windows.Forms.Button();
            this.BtnShieldCoderSyn = new System.Windows.Forms.Button();
            this.BtnSetSpan = new System.Windows.Forms.Button();
            this.BtnSetZero = new System.Windows.Forms.Button();
            this.Label11 = new System.Windows.Forms.Label();
            this.LabTrvSP = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.LabTrvPV = new System.Windows.Forms.Label();
            this.LabRawMainPV = new System.Windows.Forms.Label();
            this.LabRawSlavePV = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // LabDateTime
            // 
            this.LabDateTime.BackColor = System.Drawing.Color.Transparent;
            this.LabDateTime.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabDateTime.ForeColor = System.Drawing.Color.White;
            this.LabDateTime.Location = new System.Drawing.Point(153, 347);
            this.LabDateTime.Name = "LabDateTime";
            this.LabDateTime.Size = new System.Drawing.Size(221, 20);
            this.LabDateTime.TabIndex = 154;
            this.LabDateTime.Text = "2000-01-01 00:00:00";
            this.LabDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label13
            // 
            this.Label13.BackColor = System.Drawing.Color.Transparent;
            this.Label13.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label13.ForeColor = System.Drawing.Color.White;
            this.Label13.Location = new System.Drawing.Point(77, 347);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(70, 20);
            this.Label13.TabIndex = 153;
            this.Label13.Text = "已校准";
            this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabName
            // 
            this.LabName.BackColor = System.Drawing.Color.Transparent;
            this.LabName.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabName.ForeColor = System.Drawing.Color.White;
            this.LabName.Location = new System.Drawing.Point(65, 6);
            this.LabName.Name = "LabName";
            this.LabName.Size = new System.Drawing.Size(245, 31);
            this.LabName.TabIndex = 143;
            this.LabName.Text = "热屏位置校准";
            this.LabName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 500;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // LabShieldPosDev
            // 
            this.LabShieldPosDev.BackColor = System.Drawing.Color.White;
            this.LabShieldPosDev.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabShieldPosDev.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabShieldPosDev.ForeColor = System.Drawing.Color.Black;
            this.LabShieldPosDev.Location = new System.Drawing.Point(411, 194);
            this.LabShieldPosDev.Name = "LabShieldPosDev";
            this.LabShieldPosDev.Size = new System.Drawing.Size(100, 50);
            this.LabShieldPosDev.TabIndex = 166;
            this.LabShieldPosDev.Text = "0.00";
            this.LabShieldPosDev.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabShieldPosDev.TextChanged += new System.EventHandler(this.LabTrvSP_TextChanged);
            this.LabShieldPosDev.Click += new System.EventHandler(this.LabShieldPosDev_Click);
            // 
            // LabShieldDownTorque
            // 
            this.LabShieldDownTorque.BackColor = System.Drawing.Color.White;
            this.LabShieldDownTorque.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabShieldDownTorque.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabShieldDownTorque.ForeColor = System.Drawing.Color.Black;
            this.LabShieldDownTorque.Location = new System.Drawing.Point(411, 136);
            this.LabShieldDownTorque.Name = "LabShieldDownTorque";
            this.LabShieldDownTorque.Size = new System.Drawing.Size(100, 50);
            this.LabShieldDownTorque.TabIndex = 167;
            this.LabShieldDownTorque.Text = "0.00";
            this.LabShieldDownTorque.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabShieldDownTorque.TextAlignChanged += new System.EventHandler(this.LabTrvSP_TextChanged);
            this.LabShieldDownTorque.Click += new System.EventHandler(this.LabShieldDownTorque_Click);
            // 
            // LabShieldUpTorque
            // 
            this.LabShieldUpTorque.BackColor = System.Drawing.Color.White;
            this.LabShieldUpTorque.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabShieldUpTorque.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabShieldUpTorque.ForeColor = System.Drawing.Color.Black;
            this.LabShieldUpTorque.Location = new System.Drawing.Point(411, 78);
            this.LabShieldUpTorque.Name = "LabShieldUpTorque";
            this.LabShieldUpTorque.Size = new System.Drawing.Size(100, 50);
            this.LabShieldUpTorque.TabIndex = 168;
            this.LabShieldUpTorque.Text = "0.00";
            this.LabShieldUpTorque.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabShieldUpTorque.TextAlignChanged += new System.EventHandler(this.LabTrvSP_TextChanged);
            this.LabShieldUpTorque.Click += new System.EventHandler(this.LabShieldUpTorque_Click);
            // 
            // LabShieldActTorque
            // 
            this.LabShieldActTorque.BackColor = System.Drawing.Color.Black;
            this.LabShieldActTorque.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabShieldActTorque.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabShieldActTorque.ForeColor = System.Drawing.Color.White;
            this.LabShieldActTorque.Location = new System.Drawing.Point(411, 20);
            this.LabShieldActTorque.Name = "LabShieldActTorque";
            this.LabShieldActTorque.Size = new System.Drawing.Size(100, 50);
            this.LabShieldActTorque.TabIndex = 165;
            this.LabShieldActTorque.Text = "0.0";
            this.LabShieldActTorque.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label12
            // 
            this.Label12.BackColor = System.Drawing.Color.Transparent;
            this.Label12.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label12.ForeColor = System.Drawing.Color.White;
            this.Label12.Location = new System.Drawing.Point(517, 209);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(41, 20);
            this.Label12.TabIndex = 161;
            this.Label12.Text = "mm";
            this.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label10
            // 
            this.Label10.BackColor = System.Drawing.Color.Transparent;
            this.Label10.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label10.ForeColor = System.Drawing.Color.White;
            this.Label10.Location = new System.Drawing.Point(517, 151);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(30, 20);
            this.Label10.TabIndex = 162;
            this.Label10.Text = "%";
            this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label7.ForeColor = System.Drawing.Color.White;
            this.Label7.Location = new System.Drawing.Point(517, 35);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(30, 20);
            this.Label7.TabIndex = 163;
            this.Label7.Text = "%";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label8
            // 
            this.Label8.BackColor = System.Drawing.Color.Transparent;
            this.Label8.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label8.ForeColor = System.Drawing.Color.White;
            this.Label8.Location = new System.Drawing.Point(517, 93);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(30, 20);
            this.Label8.TabIndex = 164;
            this.Label8.Text = "%";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label16
            // 
            this.Label16.BackColor = System.Drawing.Color.Transparent;
            this.Label16.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label16.ForeColor = System.Drawing.Color.White;
            this.Label16.Location = new System.Drawing.Point(319, 209);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(93, 20);
            this.Label16.TabIndex = 157;
            this.Label16.Text = "位置偏差";
            this.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label15
            // 
            this.Label15.BackColor = System.Drawing.Color.Transparent;
            this.Label15.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label15.ForeColor = System.Drawing.Color.White;
            this.Label15.Location = new System.Drawing.Point(319, 151);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(93, 20);
            this.Label15.TabIndex = 158;
            this.Label15.Text = "下降力矩";
            this.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label18
            // 
            this.Label18.BackColor = System.Drawing.Color.Transparent;
            this.Label18.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label18.ForeColor = System.Drawing.Color.White;
            this.Label18.Location = new System.Drawing.Point(319, 20);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(93, 50);
            this.Label18.TabIndex = 159;
            this.Label18.Text = "热屏电机扭矩反馈";
            this.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label14
            // 
            this.Label14.BackColor = System.Drawing.Color.Transparent;
            this.Label14.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label14.ForeColor = System.Drawing.Color.White;
            this.Label14.Location = new System.Drawing.Point(319, 93);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(93, 20);
            this.Label14.TabIndex = 160;
            this.Label14.Text = "上升力矩";
            this.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnShieldConfirm
            // 
            this.BtnShieldConfirm.BackColor = System.Drawing.Color.Blue;
            this.BtnShieldConfirm.FlatAppearance.BorderSize = 0;
            this.BtnShieldConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShieldConfirm.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnShieldConfirm.ForeColor = System.Drawing.Color.White;
            this.BtnShieldConfirm.Location = new System.Drawing.Point(411, 252);
            this.BtnShieldConfirm.Name = "BtnShieldConfirm";
            this.BtnShieldConfirm.Size = new System.Drawing.Size(100, 50);
            this.BtnShieldConfirm.TabIndex = 169;
            this.BtnShieldConfirm.Text = "确认";
            this.BtnShieldConfirm.UseVisualStyleBackColor = false;
            this.BtnShieldConfirm.Click += new System.EventHandler(this.BtnShieldConfirm_Click);
            // 
            // BtnShieldCoderSyn
            // 
            this.BtnShieldCoderSyn.BackColor = System.Drawing.Color.Blue;
            this.BtnShieldCoderSyn.FlatAppearance.BorderSize = 0;
            this.BtnShieldCoderSyn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShieldCoderSyn.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnShieldCoderSyn.ForeColor = System.Drawing.Color.White;
            this.BtnShieldCoderSyn.Location = new System.Drawing.Point(411, 324);
            this.BtnShieldCoderSyn.Name = "BtnShieldCoderSyn";
            this.BtnShieldCoderSyn.Size = new System.Drawing.Size(100, 50);
            this.BtnShieldCoderSyn.TabIndex = 170;
            this.BtnShieldCoderSyn.Text = "热屏电机编码器同步";
            this.BtnShieldCoderSyn.UseVisualStyleBackColor = false;
            this.BtnShieldCoderSyn.Click += new System.EventHandler(this.BtnShieldCoderSyn_Click);
            // 
            // BtnSetSpan
            // 
            this.BtnSetSpan.BackColor = System.Drawing.Color.Blue;
            this.BtnSetSpan.FlatAppearance.BorderSize = 0;
            this.BtnSetSpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSetSpan.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnSetSpan.ForeColor = System.Drawing.Color.White;
            this.BtnSetSpan.Location = new System.Drawing.Point(170, 291);
            this.BtnSetSpan.Name = "BtnSetSpan";
            this.BtnSetSpan.Size = new System.Drawing.Size(100, 50);
            this.BtnSetSpan.TabIndex = 184;
            this.BtnSetSpan.Text = "标定";
            this.BtnSetSpan.UseVisualStyleBackColor = false;
            this.BtnSetSpan.Click += new System.EventHandler(this.BtnSetSpan_Click);
            // 
            // BtnSetZero
            // 
            this.BtnSetZero.BackColor = System.Drawing.Color.Blue;
            this.BtnSetZero.FlatAppearance.BorderSize = 0;
            this.BtnSetZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSetZero.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnSetZero.ForeColor = System.Drawing.Color.White;
            this.BtnSetZero.Location = new System.Drawing.Point(170, 183);
            this.BtnSetZero.Name = "BtnSetZero";
            this.BtnSetZero.Size = new System.Drawing.Size(100, 50);
            this.BtnSetZero.TabIndex = 183;
            this.BtnSetZero.Text = "设零位";
            this.BtnSetZero.UseVisualStyleBackColor = false;
            this.BtnSetZero.Click += new System.EventHandler(this.BtnSetZero_Click);
            // 
            // Label11
            // 
            this.Label11.BackColor = System.Drawing.Color.Transparent;
            this.Label11.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label11.ForeColor = System.Drawing.Color.White;
            this.Label11.Location = new System.Drawing.Point(275, 252);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(33, 20);
            this.Label11.TabIndex = 182;
            this.Label11.Text = "mm";
            this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabTrvSP
            // 
            this.LabTrvSP.BackColor = System.Drawing.Color.White;
            this.LabTrvSP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabTrvSP.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabTrvSP.ForeColor = System.Drawing.Color.Black;
            this.LabTrvSP.Location = new System.Drawing.Point(170, 237);
            this.LabTrvSP.Name = "LabTrvSP";
            this.LabTrvSP.Size = new System.Drawing.Size(100, 50);
            this.LabTrvSP.TabIndex = 181;
            this.LabTrvSP.Text = "0.0";
            this.LabTrvSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabTrvSP.TextChanged += new System.EventHandler(this.LabTrvSP_TextChanged);
            this.LabTrvSP.Click += new System.EventHandler(this.LabTrvSP_Click);
            // 
            // Label9
            // 
            this.Label9.BackColor = System.Drawing.Color.Transparent;
            this.Label9.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label9.ForeColor = System.Drawing.Color.White;
            this.Label9.Location = new System.Drawing.Point(70, 252);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(95, 20);
            this.Label9.TabIndex = 180;
            this.Label9.Text = "标定位置";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabTrvPV
            // 
            this.LabTrvPV.BackColor = System.Drawing.Color.Black;
            this.LabTrvPV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabTrvPV.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabTrvPV.ForeColor = System.Drawing.Color.White;
            this.LabTrvPV.Location = new System.Drawing.Point(170, 137);
            this.LabTrvPV.Name = "LabTrvPV";
            this.LabTrvPV.Size = new System.Drawing.Size(100, 42);
            this.LabTrvPV.TabIndex = 179;
            this.LabTrvPV.Text = "0.0";
            this.LabTrvPV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabRawMainPV
            // 
            this.LabRawMainPV.BackColor = System.Drawing.Color.Black;
            this.LabRawMainPV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabRawMainPV.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabRawMainPV.ForeColor = System.Drawing.Color.White;
            this.LabRawMainPV.Location = new System.Drawing.Point(170, 91);
            this.LabRawMainPV.Name = "LabRawMainPV";
            this.LabRawMainPV.Size = new System.Drawing.Size(100, 42);
            this.LabRawMainPV.TabIndex = 177;
            this.LabRawMainPV.Text = "0.0";
            this.LabRawMainPV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabRawSlavePV
            // 
            this.LabRawSlavePV.BackColor = System.Drawing.Color.Black;
            this.LabRawSlavePV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabRawSlavePV.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabRawSlavePV.ForeColor = System.Drawing.Color.White;
            this.LabRawSlavePV.Location = new System.Drawing.Point(170, 45);
            this.LabRawSlavePV.Name = "LabRawSlavePV";
            this.LabRawSlavePV.Size = new System.Drawing.Size(100, 42);
            this.LabRawSlavePV.TabIndex = 178;
            this.LabRawSlavePV.Text = "0.0";
            this.LabRawSlavePV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label6.ForeColor = System.Drawing.Color.White;
            this.Label6.Location = new System.Drawing.Point(275, 102);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(33, 20);
            this.Label6.TabIndex = 175;
            this.Label6.Text = "mm";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(275, 56);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(33, 20);
            this.Label5.TabIndex = 176;
            this.Label5.Text = "mm";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(275, 148);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(33, 20);
            this.Label4.TabIndex = 174;
            this.Label4.Text = "mm";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(6, 102);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(159, 20);
            this.Label3.TabIndex = 171;
            this.Label3.Text = "热屏主动侧位置";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(70, 148);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(95, 20);
            this.Label2.TabIndex = 173;
            this.Label2.Text = "热屏位置";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(6, 56);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(159, 20);
            this.Label1.TabIndex = 172;
            this.Label1.Text = "热屏从动侧位置";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(308, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(5, 340);
            this.groupBox1.TabIndex = 185;
            this.groupBox1.TabStop = false;
            // 
            // GroupBox2
            // 
            this.GroupBox2.BackColor = System.Drawing.Color.Black;
            this.GroupBox2.Location = new System.Drawing.Point(312, 312);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(270, 5);
            this.GroupBox2.TabIndex = 186;
            this.GroupBox2.TabStop = false;
            // 
            // FrmShieldTrv
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(594, 380);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnSetSpan);
            this.Controls.Add(this.BtnSetZero);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.LabTrvSP);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.LabTrvPV);
            this.Controls.Add(this.LabRawMainPV);
            this.Controls.Add(this.LabRawSlavePV);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.BtnShieldCoderSyn);
            this.Controls.Add(this.BtnShieldConfirm);
            this.Controls.Add(this.LabShieldPosDev);
            this.Controls.Add(this.LabShieldDownTorque);
            this.Controls.Add(this.LabShieldUpTorque);
            this.Controls.Add(this.LabShieldActTorque);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label16);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.Label18);
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.LabDateTime);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.LabName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmShieldTrv";
            this.Text = "FrmShieldTrv";
            this.Load += new System.EventHandler(this.FrmShieldTrv_Load);
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Label LabDateTime;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label LabName;
        private System.Windows.Forms.Timer Timer1;
        internal System.Windows.Forms.Label LabShieldPosDev;
        internal System.Windows.Forms.Label LabShieldDownTorque;
        internal System.Windows.Forms.Label LabShieldUpTorque;
        internal System.Windows.Forms.Label LabShieldActTorque;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Label Label18;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Button BtnShieldConfirm;
        internal System.Windows.Forms.Button BtnShieldCoderSyn;
        internal System.Windows.Forms.Button BtnSetSpan;
        internal System.Windows.Forms.Button BtnSetZero;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label LabTrvSP;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label LabTrvPV;
        internal System.Windows.Forms.Label LabRawMainPV;
        internal System.Windows.Forms.Label LabRawSlavePV;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.GroupBox GroupBox2;
    }
}