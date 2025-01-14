namespace CrystalGrowth.AuxFunction.Calibration
{
    partial class FrmSeedTrv
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
            this.BtnSetSpan = new System.Windows.Forms.Button();
            this.BtnSetZero = new System.Windows.Forms.Button();
            this.LabDateTime = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.LabTrvSP = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.LabTrvPV = new System.Windows.Forms.Label();
            this.LabRawPV = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.LabName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 500;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // BtnSetSpan
            // 
            this.BtnSetSpan.BackColor = System.Drawing.Color.Blue;
            this.BtnSetSpan.FlatAppearance.BorderSize = 0;
            this.BtnSetSpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSetSpan.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnSetSpan.ForeColor = System.Drawing.Color.White;
            this.BtnSetSpan.Location = new System.Drawing.Point(156, 285);
            this.BtnSetSpan.Name = "BtnSetSpan";
            this.BtnSetSpan.Size = new System.Drawing.Size(100, 50);
            this.BtnSetSpan.TabIndex = 142;
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
            this.BtnSetZero.Location = new System.Drawing.Point(156, 165);
            this.BtnSetZero.Name = "BtnSetZero";
            this.BtnSetZero.Size = new System.Drawing.Size(100, 50);
            this.BtnSetZero.TabIndex = 141;
            this.BtnSetZero.Text = "设零位";
            this.BtnSetZero.UseVisualStyleBackColor = false;
            this.BtnSetZero.Click += new System.EventHandler(this.BtnSetZero_Click);
            // 
            // LabDateTime
            // 
            this.LabDateTime.BackColor = System.Drawing.Color.Transparent;
            this.LabDateTime.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabDateTime.ForeColor = System.Drawing.Color.White;
            this.LabDateTime.Location = new System.Drawing.Point(152, 347);
            this.LabDateTime.Name = "LabDateTime";
            this.LabDateTime.Size = new System.Drawing.Size(221, 20);
            this.LabDateTime.TabIndex = 140;
            this.LabDateTime.Text = "2000-01-01 00:00:00";
            this.LabDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label13
            // 
            this.Label13.BackColor = System.Drawing.Color.Transparent;
            this.Label13.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label13.ForeColor = System.Drawing.Color.White;
            this.Label13.Location = new System.Drawing.Point(76, 347);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(70, 20);
            this.Label13.TabIndex = 139;
            this.Label13.Text = "已校准";
            this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label11
            // 
            this.Label11.BackColor = System.Drawing.Color.Transparent;
            this.Label11.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label11.ForeColor = System.Drawing.Color.White;
            this.Label11.Location = new System.Drawing.Point(262, 240);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(47, 20);
            this.Label11.TabIndex = 138;
            this.Label11.Text = "mm";
            this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabTrvSP
            // 
            this.LabTrvSP.BackColor = System.Drawing.Color.White;
            this.LabTrvSP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabTrvSP.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabTrvSP.ForeColor = System.Drawing.Color.Black;
            this.LabTrvSP.Location = new System.Drawing.Point(156, 225);
            this.LabTrvSP.Name = "LabTrvSP";
            this.LabTrvSP.Size = new System.Drawing.Size(100, 50);
            this.LabTrvSP.TabIndex = 137;
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
            this.Label9.Location = new System.Drawing.Point(21, 240);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(131, 20);
            this.Label9.TabIndex = 136;
            this.Label9.Text = "标定位置";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabTrvPV
            // 
            this.LabTrvPV.BackColor = System.Drawing.Color.Black;
            this.LabTrvPV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabTrvPV.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabTrvPV.ForeColor = System.Drawing.Color.White;
            this.LabTrvPV.Location = new System.Drawing.Point(157, 105);
            this.LabTrvPV.Name = "LabTrvPV";
            this.LabTrvPV.Size = new System.Drawing.Size(100, 50);
            this.LabTrvPV.TabIndex = 135;
            this.LabTrvPV.Text = "0.0";
            this.LabTrvPV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabRawPV
            // 
            this.LabRawPV.BackColor = System.Drawing.Color.Black;
            this.LabRawPV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabRawPV.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabRawPV.ForeColor = System.Drawing.Color.White;
            this.LabRawPV.Location = new System.Drawing.Point(157, 45);
            this.LabRawPV.Name = "LabRawPV";
            this.LabRawPV.Size = new System.Drawing.Size(100, 50);
            this.LabRawPV.TabIndex = 134;
            this.LabRawPV.Text = "0.0";
            this.LabRawPV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(262, 60);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(47, 20);
            this.Label5.TabIndex = 133;
            this.Label5.Text = "mm";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(262, 120);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(47, 20);
            this.Label4.TabIndex = 132;
            this.Label4.Text = "mm";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(21, 120);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(131, 20);
            this.Label2.TabIndex = 131;
            this.Label2.Text = "籽晶位置";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(21, 60);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(131, 20);
            this.Label1.TabIndex = 130;
            this.Label1.Text = "籽晶原始位置";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabName
            // 
            this.LabName.BackColor = System.Drawing.Color.Transparent;
            this.LabName.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabName.ForeColor = System.Drawing.Color.White;
            this.LabName.Location = new System.Drawing.Point(64, 6);
            this.LabName.Name = "LabName";
            this.LabName.Size = new System.Drawing.Size(245, 31);
            this.LabName.TabIndex = 129;
            this.LabName.Text = "籽晶位置校准";
            this.LabName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmSeedTrv
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(394, 380);
            this.Controls.Add(this.BtnSetSpan);
            this.Controls.Add(this.BtnSetZero);
            this.Controls.Add(this.LabDateTime);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.LabTrvSP);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.LabTrvPV);
            this.Controls.Add(this.LabRawPV);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.LabName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSeedTrv";
            this.Text = "FrmSeedTrv";
            this.Load += new System.EventHandler(this.FrmSeedTrv_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer Timer1;
        internal System.Windows.Forms.Button BtnSetSpan;
        internal System.Windows.Forms.Button BtnSetZero;
        internal System.Windows.Forms.Label LabDateTime;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label LabTrvSP;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label LabTrvPV;
        internal System.Windows.Forms.Label LabRawPV;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label LabName;
    }
}