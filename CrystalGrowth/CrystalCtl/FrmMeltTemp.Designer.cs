namespace CrystalGrowth.CrystalCtl
{
    partial class FrmMeltTemp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnLimit = new System.Windows.Forms.Button();
            this.BtnTune = new System.Windows.Forms.Button();
            this.BtnAuto = new System.Windows.Forms.Button();
            this.BtnManual = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.LabIntegTxt = new System.Windows.Forms.Label();
            this.LabDifferTxt = new System.Windows.Forms.Label();
            this.LabGainVal = new System.Windows.Forms.Label();
            this.LabGainTxt = new System.Windows.Forms.Label();
            this.LabDifferVal = new System.Windows.Forms.Label();
            this.LabIntegVal = new System.Windows.Forms.Label();
            this.BtnOFF = new System.Windows.Forms.Button();
            this.BtnON = new System.Windows.Forms.Button();
            this.LabSP = new System.Windows.Forms.Label();
            this.LabOut = new System.Windows.Forms.Label();
            this.LabPVPxlRealtime = new System.Windows.Forms.Label();
            this.LabPVPxl = new System.Windows.Forms.Label();
            this.LabPV = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.LabName = new System.Windows.Forms.Label();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnCheckData = new System.Windows.Forms.Button();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.BtnCoverPre = new System.Windows.Forms.Button();
            this.BtnPreAjustTempOff = new System.Windows.Forms.Button();
            this.BtnPreAjustTempOn = new System.Windows.Forms.Button();
            this.Label13 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Value1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnLimit
            // 
            this.BtnLimit.BackColor = System.Drawing.Color.Blue;
            this.BtnLimit.FlatAppearance.BorderSize = 0;
            this.BtnLimit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimit.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnLimit.ForeColor = System.Drawing.Color.White;
            this.BtnLimit.Location = new System.Drawing.Point(10, 331);
            this.BtnLimit.Name = "BtnLimit";
            this.BtnLimit.Size = new System.Drawing.Size(100, 35);
            this.BtnLimit.TabIndex = 105;
            this.BtnLimit.Text = "极限值";
            this.BtnLimit.UseVisualStyleBackColor = false;
            this.BtnLimit.Click += new System.EventHandler(this.BtnLimit_Click);
            // 
            // BtnTune
            // 
            this.BtnTune.BackColor = System.Drawing.Color.Blue;
            this.BtnTune.FlatAppearance.BorderSize = 0;
            this.BtnTune.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTune.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnTune.ForeColor = System.Drawing.Color.White;
            this.BtnTune.Location = new System.Drawing.Point(10, 286);
            this.BtnTune.Name = "BtnTune";
            this.BtnTune.Size = new System.Drawing.Size(100, 35);
            this.BtnTune.TabIndex = 104;
            this.BtnTune.Text = "调节";
            this.BtnTune.UseVisualStyleBackColor = false;
            this.BtnTune.Click += new System.EventHandler(this.BtnTune_Click);
            // 
            // BtnAuto
            // 
            this.BtnAuto.BackColor = System.Drawing.Color.Blue;
            this.BtnAuto.FlatAppearance.BorderSize = 0;
            this.BtnAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAuto.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnAuto.ForeColor = System.Drawing.Color.White;
            this.BtnAuto.Location = new System.Drawing.Point(240, 285);
            this.BtnAuto.Name = "BtnAuto";
            this.BtnAuto.Size = new System.Drawing.Size(100, 35);
            this.BtnAuto.TabIndex = 103;
            this.BtnAuto.Text = "自动";
            this.BtnAuto.UseVisualStyleBackColor = false;
            this.BtnAuto.Visible = false;
            this.BtnAuto.Click += new System.EventHandler(this.BtnAuto_Click);
            // 
            // BtnManual
            // 
            this.BtnManual.BackColor = System.Drawing.Color.Blue;
            this.BtnManual.FlatAppearance.BorderSize = 0;
            this.BtnManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnManual.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnManual.ForeColor = System.Drawing.Color.White;
            this.BtnManual.Location = new System.Drawing.Point(240, 330);
            this.BtnManual.Name = "BtnManual";
            this.BtnManual.Size = new System.Drawing.Size(100, 35);
            this.BtnManual.TabIndex = 102;
            this.BtnManual.Text = "手动";
            this.BtnManual.UseVisualStyleBackColor = false;
            this.BtnManual.Visible = false;
            this.BtnManual.Click += new System.EventHandler(this.BtnManual_Click);
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.LabIntegTxt);
            this.Panel1.Controls.Add(this.LabDifferTxt);
            this.Panel1.Controls.Add(this.LabGainVal);
            this.Panel1.Controls.Add(this.LabGainTxt);
            this.Panel1.Controls.Add(this.LabDifferVal);
            this.Panel1.Controls.Add(this.LabIntegVal);
            this.Panel1.Location = new System.Drawing.Point(-1, 379);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(373, 114);
            this.Panel1.TabIndex = 101;
            // 
            // LabIntegTxt
            // 
            this.LabIntegTxt.BackColor = System.Drawing.Color.Transparent;
            this.LabIntegTxt.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabIntegTxt.ForeColor = System.Drawing.Color.White;
            this.LabIntegTxt.Location = new System.Drawing.Point(258, 14);
            this.LabIntegTxt.Name = "LabIntegTxt";
            this.LabIntegTxt.Size = new System.Drawing.Size(100, 20);
            this.LabIntegTxt.TabIndex = 47;
            this.LabIntegTxt.Text = "积分";
            this.LabIntegTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabDifferTxt
            // 
            this.LabDifferTxt.BackColor = System.Drawing.Color.Transparent;
            this.LabDifferTxt.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabDifferTxt.ForeColor = System.Drawing.Color.White;
            this.LabDifferTxt.Location = new System.Drawing.Point(133, 14);
            this.LabDifferTxt.Name = "LabDifferTxt";
            this.LabDifferTxt.Size = new System.Drawing.Size(100, 20);
            this.LabDifferTxt.TabIndex = 46;
            this.LabDifferTxt.Text = "微分";
            this.LabDifferTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabGainVal
            // 
            this.LabGainVal.BackColor = System.Drawing.Color.White;
            this.LabGainVal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabGainVal.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabGainVal.ForeColor = System.Drawing.Color.Black;
            this.LabGainVal.Location = new System.Drawing.Point(7, 43);
            this.LabGainVal.Name = "LabGainVal";
            this.LabGainVal.Size = new System.Drawing.Size(100, 50);
            this.LabGainVal.TabIndex = 42;
            this.LabGainVal.Text = "0.0000";
            this.LabGainVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabGainVal.Click += new System.EventHandler(this.LabGainVal_Click);
            // 
            // LabGainTxt
            // 
            this.LabGainTxt.BackColor = System.Drawing.Color.Transparent;
            this.LabGainTxt.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabGainTxt.ForeColor = System.Drawing.Color.White;
            this.LabGainTxt.Location = new System.Drawing.Point(7, 14);
            this.LabGainTxt.Name = "LabGainTxt";
            this.LabGainTxt.Size = new System.Drawing.Size(100, 20);
            this.LabGainTxt.TabIndex = 45;
            this.LabGainTxt.Text = "增益";
            this.LabGainTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabDifferVal
            // 
            this.LabDifferVal.BackColor = System.Drawing.Color.White;
            this.LabDifferVal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabDifferVal.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabDifferVal.ForeColor = System.Drawing.Color.Black;
            this.LabDifferVal.Location = new System.Drawing.Point(129, 43);
            this.LabDifferVal.Name = "LabDifferVal";
            this.LabDifferVal.Size = new System.Drawing.Size(100, 50);
            this.LabDifferVal.TabIndex = 43;
            this.LabDifferVal.Text = "0.0000";
            this.LabDifferVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabDifferVal.Click += new System.EventHandler(this.LabDifferVal_Click);
            // 
            // LabIntegVal
            // 
            this.LabIntegVal.BackColor = System.Drawing.Color.White;
            this.LabIntegVal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabIntegVal.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabIntegVal.ForeColor = System.Drawing.Color.Black;
            this.LabIntegVal.Location = new System.Drawing.Point(256, 43);
            this.LabIntegVal.Name = "LabIntegVal";
            this.LabIntegVal.Size = new System.Drawing.Size(100, 50);
            this.LabIntegVal.TabIndex = 44;
            this.LabIntegVal.Text = "0.0000";
            this.LabIntegVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabIntegVal.Click += new System.EventHandler(this.LabIntegVal_Click);
            // 
            // BtnOFF
            // 
            this.BtnOFF.BackColor = System.Drawing.Color.Blue;
            this.BtnOFF.FlatAppearance.BorderSize = 0;
            this.BtnOFF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOFF.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnOFF.ForeColor = System.Drawing.Color.White;
            this.BtnOFF.Location = new System.Drawing.Point(125, 330);
            this.BtnOFF.Name = "BtnOFF";
            this.BtnOFF.Size = new System.Drawing.Size(100, 35);
            this.BtnOFF.TabIndex = 100;
            this.BtnOFF.Text = "OFF";
            this.BtnOFF.UseVisualStyleBackColor = false;
            this.BtnOFF.Click += new System.EventHandler(this.BtnOFF_Click);
            // 
            // BtnON
            // 
            this.BtnON.BackColor = System.Drawing.Color.Blue;
            this.BtnON.FlatAppearance.BorderSize = 0;
            this.BtnON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnON.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnON.ForeColor = System.Drawing.Color.White;
            this.BtnON.Location = new System.Drawing.Point(125, 285);
            this.BtnON.Name = "BtnON";
            this.BtnON.Size = new System.Drawing.Size(100, 35);
            this.BtnON.TabIndex = 99;
            this.BtnON.Text = "ON";
            this.BtnON.UseVisualStyleBackColor = false;
            this.BtnON.Click += new System.EventHandler(this.BtnON_Click);
            // 
            // LabSP
            // 
            this.LabSP.BackColor = System.Drawing.Color.Gray;
            this.LabSP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabSP.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabSP.ForeColor = System.Drawing.Color.Black;
            this.LabSP.Location = new System.Drawing.Point(96, 155);
            this.LabSP.Name = "LabSP";
            this.LabSP.Size = new System.Drawing.Size(100, 50);
            this.LabSP.TabIndex = 98;
            this.LabSP.Text = "0.0";
            this.LabSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabSP.Click += new System.EventHandler(this.LabSP_Click);
            // 
            // LabOut
            // 
            this.LabOut.BackColor = System.Drawing.Color.White;
            this.LabOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabOut.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabOut.ForeColor = System.Drawing.Color.Black;
            this.LabOut.Location = new System.Drawing.Point(95, 218);
            this.LabOut.Name = "LabOut";
            this.LabOut.Size = new System.Drawing.Size(100, 50);
            this.LabOut.TabIndex = 97;
            this.LabOut.Text = "0.00";
            this.LabOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabOut.Click += new System.EventHandler(this.LabOut_Click);
            // 
            // LabPVPxlRealtime
            // 
            this.LabPVPxlRealtime.BackColor = System.Drawing.Color.Black;
            this.LabPVPxlRealtime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabPVPxlRealtime.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabPVPxlRealtime.ForeColor = System.Drawing.Color.White;
            this.LabPVPxlRealtime.Location = new System.Drawing.Point(96, 122);
            this.LabPVPxlRealtime.Name = "LabPVPxlRealtime";
            this.LabPVPxlRealtime.Size = new System.Drawing.Size(100, 28);
            this.LabPVPxlRealtime.TabIndex = 95;
            this.LabPVPxlRealtime.Text = "0.0";
            this.LabPVPxlRealtime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabPVPxl
            // 
            this.LabPVPxl.BackColor = System.Drawing.Color.Black;
            this.LabPVPxl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabPVPxl.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabPVPxl.ForeColor = System.Drawing.Color.White;
            this.LabPVPxl.Location = new System.Drawing.Point(96, 95);
            this.LabPVPxl.Name = "LabPVPxl";
            this.LabPVPxl.Size = new System.Drawing.Size(100, 28);
            this.LabPVPxl.TabIndex = 94;
            this.LabPVPxl.Text = "0.0";
            this.LabPVPxl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabPV
            // 
            this.LabPV.BackColor = System.Drawing.Color.Black;
            this.LabPV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabPV.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabPV.ForeColor = System.Drawing.Color.White;
            this.LabPV.Location = new System.Drawing.Point(96, 40);
            this.LabPV.Name = "LabPV";
            this.LabPV.Size = new System.Drawing.Size(100, 50);
            this.LabPV.TabIndex = 96;
            this.LabPV.Text = "0.0";
            this.LabPV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label6.ForeColor = System.Drawing.Color.White;
            this.Label6.Location = new System.Drawing.Point(200, 235);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(52, 20);
            this.Label6.TabIndex = 93;
            this.Label6.Text = "KW";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(201, 55);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(58, 20);
            this.Label5.TabIndex = 92;
            this.Label5.Text = "degC";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(201, 170);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(58, 20);
            this.Label4.TabIndex = 91;
            this.Label4.Text = "degC";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label8
            // 
            this.Label8.BackColor = System.Drawing.Color.Transparent;
            this.Label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label8.ForeColor = System.Drawing.Color.White;
            this.Label8.Location = new System.Drawing.Point(202, 125);
            this.Label8.Name = "Label8";
            this.Label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label8.Size = new System.Drawing.Size(54, 20);
            this.Label8.TabIndex = 88;
            this.Label8.Text = "RT";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(18, 235);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(72, 20);
            this.Label3.TabIndex = 90;
            this.Label3.Text = "主功率";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label10
            // 
            this.Label10.BackColor = System.Drawing.Color.Transparent;
            this.Label10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label10.ForeColor = System.Drawing.Color.White;
            this.Label10.Location = new System.Drawing.Point(202, 95);
            this.Label10.Name = "Label10";
            this.Label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label10.Size = new System.Drawing.Size(57, 20);
            this.Label10.TabIndex = 87;
            this.Label10.Text = "AVG";
            this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label7.ForeColor = System.Drawing.Color.White;
            this.Label7.Location = new System.Drawing.Point(14, 110);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(77, 20);
            this.Label7.TabIndex = 86;
            this.Label7.Text = "灰度值";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(-1, 170);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(92, 20);
            this.Label2.TabIndex = 89;
            this.Label2.Text = "设定温度";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(0, 55);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(91, 20);
            this.Label1.TabIndex = 85;
            this.Label1.Text = "液面温度";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabName
            // 
            this.LabName.BackColor = System.Drawing.Color.Transparent;
            this.LabName.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabName.ForeColor = System.Drawing.Color.White;
            this.LabName.Location = new System.Drawing.Point(48, 4);
            this.LabName.Name = "LabName";
            this.LabName.Size = new System.Drawing.Size(196, 31);
            this.LabName.TabIndex = 84;
            this.LabName.Text = "液面温度控制";
            this.LabName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AllowUserToResizeColumns = false;
            this.DataGridView1.AllowUserToResizeRows = false;
            this.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView1.ColumnHeadersHeight = 25;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Value1,
            this.Column1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView1.EnableHeadersVisualStyles = false;
            this.DataGridView1.GridColor = System.Drawing.Color.Black;
            this.DataGridView1.Location = new System.Drawing.Point(374, 1);
            this.DataGridView1.MultiSelect = false;
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.RowHeadersWidth = 100;
            this.DataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.DataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            this.DataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DataGridView1.RowTemplate.Height = 25;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DataGridView1.Size = new System.Drawing.Size(237, 492);
            this.DataGridView1.TabIndex = 102;
            // 
            // BtnCheckData
            // 
            this.BtnCheckData.BackColor = System.Drawing.Color.Blue;
            this.BtnCheckData.FlatAppearance.BorderSize = 0;
            this.BtnCheckData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCheckData.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCheckData.ForeColor = System.Drawing.Color.White;
            this.BtnCheckData.Location = new System.Drawing.Point(450, 422);
            this.BtnCheckData.Name = "BtnCheckData";
            this.BtnCheckData.Size = new System.Drawing.Size(100, 50);
            this.BtnCheckData.TabIndex = 100;
            this.BtnCheckData.Text = "查看数据";
            this.BtnCheckData.UseVisualStyleBackColor = false;
            this.BtnCheckData.Click += new System.EventHandler(this.BtnCheckData_Click);
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 500;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // BtnCoverPre
            // 
            this.BtnCoverPre.BackColor = System.Drawing.Color.Blue;
            this.BtnCoverPre.FlatAppearance.BorderSize = 0;
            this.BtnCoverPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCoverPre.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCoverPre.ForeColor = System.Drawing.Color.White;
            this.BtnCoverPre.Location = new System.Drawing.Point(9, 161);
            this.BtnCoverPre.Name = "BtnCoverPre";
            this.BtnCoverPre.Size = new System.Drawing.Size(100, 35);
            this.BtnCoverPre.TabIndex = 77;
            this.BtnCoverPre.Text = "关闭";
            this.BtnCoverPre.UseVisualStyleBackColor = false;
            this.BtnCoverPre.Click += new System.EventHandler(this.BtnCoverPre_Click);
            // 
            // BtnPreAjustTempOff
            // 
            this.BtnPreAjustTempOff.BackColor = System.Drawing.Color.Blue;
            this.BtnPreAjustTempOff.FlatAppearance.BorderSize = 0;
            this.BtnPreAjustTempOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPreAjustTempOff.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnPreAjustTempOff.ForeColor = System.Drawing.Color.White;
            this.BtnPreAjustTempOff.Location = new System.Drawing.Point(9, 86);
            this.BtnPreAjustTempOff.Name = "BtnPreAjustTempOff";
            this.BtnPreAjustTempOff.Size = new System.Drawing.Size(100, 35);
            this.BtnPreAjustTempOff.TabIndex = 108;
            this.BtnPreAjustTempOff.Text = "OFF";
            this.BtnPreAjustTempOff.UseVisualStyleBackColor = false;
            this.BtnPreAjustTempOff.Click += new System.EventHandler(this.BtnPreAjustTempOff_Click);
            // 
            // BtnPreAjustTempOn
            // 
            this.BtnPreAjustTempOn.BackColor = System.Drawing.Color.Blue;
            this.BtnPreAjustTempOn.FlatAppearance.BorderSize = 0;
            this.BtnPreAjustTempOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPreAjustTempOn.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnPreAjustTempOn.ForeColor = System.Drawing.Color.White;
            this.BtnPreAjustTempOn.Location = new System.Drawing.Point(9, 38);
            this.BtnPreAjustTempOn.Name = "BtnPreAjustTempOn";
            this.BtnPreAjustTempOn.Size = new System.Drawing.Size(100, 35);
            this.BtnPreAjustTempOn.TabIndex = 107;
            this.BtnPreAjustTempOn.Text = "ON";
            this.BtnPreAjustTempOn.UseVisualStyleBackColor = false;
            this.BtnPreAjustTempOn.Click += new System.EventHandler(this.BtnPreAjustTempOn_Click);
            // 
            // Label13
            // 
            this.Label13.BackColor = System.Drawing.Color.Transparent;
            this.Label13.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label13.ForeColor = System.Drawing.Color.White;
            this.Label13.Location = new System.Drawing.Point(13, 129);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(98, 29);
            this.Label13.TabIndex = 70;
            this.Label13.Text = "提渣预调";
            this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.BtnCoverPre);
            this.GroupBox1.Controls.Add(this.Label13);
            this.GroupBox1.Controls.Add(this.BtnPreAjustTempOff);
            this.GroupBox1.Controls.Add(this.BtnPreAjustTempOn);
            this.GroupBox1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GroupBox1.ForeColor = System.Drawing.Color.White;
            this.GroupBox1.Location = new System.Drawing.Point(256, 2);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(116, 206);
            this.GroupBox1.TabIndex = 109;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "预调温";
            // 
            // Value1
            // 
            this.Value1.HeaderText = "名称";
            this.Value1.Name = "Value1";
            this.Value1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Value1.Width = 115;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "上一次值";
            this.Column1.Name = "Column1";
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 120;
            // 
            // FrmMeltTemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(611, 494);
            this.Controls.Add(this.BtnCheckData);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.BtnLimit);
            this.Controls.Add(this.BtnTune);
            this.Controls.Add(this.BtnAuto);
            this.Controls.Add(this.BtnManual);
            this.Controls.Add(this.BtnOFF);
            this.Controls.Add(this.BtnON);
            this.Controls.Add(this.LabSP);
            this.Controls.Add(this.LabOut);
            this.Controls.Add(this.LabPVPxlRealtime);
            this.Controls.Add(this.LabPVPxl);
            this.Controls.Add(this.LabPV);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.LabName);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMeltTemp";
            this.Text = "FrmMeltTemp";
            this.Load += new System.EventHandler(this.FrmMeltTemp_Load);
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button BtnLimit;
        internal System.Windows.Forms.Button BtnTune;
        internal System.Windows.Forms.Button BtnAuto;
        internal System.Windows.Forms.Button BtnManual;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label LabIntegTxt;
        internal System.Windows.Forms.Label LabDifferTxt;
        internal System.Windows.Forms.Label LabGainVal;
        internal System.Windows.Forms.Label LabGainTxt;
        internal System.Windows.Forms.Label LabDifferVal;
        internal System.Windows.Forms.Label LabIntegVal;
        internal System.Windows.Forms.Button BtnOFF;
        internal System.Windows.Forms.Button BtnON;
        internal System.Windows.Forms.Label LabSP;
        internal System.Windows.Forms.Label LabOut;
        internal System.Windows.Forms.Label LabPVPxlRealtime;
        internal System.Windows.Forms.Label LabPVPxl;
        internal System.Windows.Forms.Label LabPV;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label LabName;
        private System.Windows.Forms.Timer Timer1;
        internal System.Windows.Forms.Button BtnCheckData;
        internal System.Windows.Forms.Button BtnCoverPre;
        internal System.Windows.Forms.Button BtnPreAjustTempOff;
        internal System.Windows.Forms.Button BtnPreAjustTempOn;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}