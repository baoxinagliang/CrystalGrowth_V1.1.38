namespace CrystalGrowth.CrystalCtl
{
    partial class FrmCrucPos
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
            this.LabTotalWeight = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.LabWeight = new System.Windows.Forms.Label();
            this.BtnFast = new System.Windows.Forms.Button();
            this.BtnSlow = new System.Windows.Forms.Button();
            this.LabPosSP = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.BtnLoc = new System.Windows.Forms.Button();
            this.BtnAuto = new System.Windows.Forms.Button();
            this.BtnManu = new System.Windows.Forms.Button();
            this.LabCL_SP = new System.Windows.Forms.Label();
            this.LabPosPV = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.LabName = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.BtnAddWeight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabTotalWeight
            // 
            this.LabTotalWeight.BackColor = System.Drawing.Color.OrangeRed;
            this.LabTotalWeight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabTotalWeight.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabTotalWeight.ForeColor = System.Drawing.Color.Black;
            this.LabTotalWeight.Location = new System.Drawing.Point(112, 396);
            this.LabTotalWeight.Name = "LabTotalWeight";
            this.LabTotalWeight.Size = new System.Drawing.Size(100, 50);
            this.LabTotalWeight.TabIndex = 157;
            this.LabTotalWeight.Text = "0.00";
            this.LabTotalWeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabTotalWeight.Click += new System.EventHandler(this.LabTotalWeight_Click);
            // 
            // Label8
            // 
            this.Label8.BackColor = System.Drawing.Color.Transparent;
            this.Label8.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label8.ForeColor = System.Drawing.Color.White;
            this.Label8.Location = new System.Drawing.Point(218, 411);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(38, 20);
            this.Label8.TabIndex = 156;
            this.Label8.Text = "kg";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabWeight
            // 
            this.LabWeight.BackColor = System.Drawing.Color.Transparent;
            this.LabWeight.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabWeight.ForeColor = System.Drawing.Color.White;
            this.LabWeight.Location = new System.Drawing.Point(10, 411);
            this.LabWeight.Name = "LabWeight";
            this.LabWeight.Size = new System.Drawing.Size(96, 20);
            this.LabWeight.TabIndex = 155;
            this.LabWeight.Text = "投料重量";
            this.LabWeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnFast
            // 
            this.BtnFast.BackColor = System.Drawing.Color.Blue;
            this.BtnFast.FlatAppearance.BorderSize = 0;
            this.BtnFast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFast.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnFast.ForeColor = System.Drawing.Color.White;
            this.BtnFast.Location = new System.Drawing.Point(147, 323);
            this.BtnFast.Name = "BtnFast";
            this.BtnFast.Size = new System.Drawing.Size(100, 35);
            this.BtnFast.TabIndex = 154;
            this.BtnFast.Text = "快升";
            this.BtnFast.UseVisualStyleBackColor = false;
            this.BtnFast.Click += new System.EventHandler(this.BtnFast_Click);
            // 
            // BtnSlow
            // 
            this.BtnSlow.BackColor = System.Drawing.Color.Blue;
            this.BtnSlow.FlatAppearance.BorderSize = 0;
            this.BtnSlow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSlow.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnSlow.ForeColor = System.Drawing.Color.White;
            this.BtnSlow.Location = new System.Drawing.Point(147, 278);
            this.BtnSlow.Name = "BtnSlow";
            this.BtnSlow.Size = new System.Drawing.Size(100, 35);
            this.BtnSlow.TabIndex = 153;
            this.BtnSlow.Text = "慢升";
            this.BtnSlow.UseVisualStyleBackColor = false;
            this.BtnSlow.Click += new System.EventHandler(this.BtnSlow_Click);
            // 
            // LabPosSP
            // 
            this.LabPosSP.BackColor = System.Drawing.Color.White;
            this.LabPosSP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabPosSP.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabPosSP.ForeColor = System.Drawing.Color.Black;
            this.LabPosSP.Location = new System.Drawing.Point(167, 205);
            this.LabPosSP.Name = "LabPosSP";
            this.LabPosSP.Size = new System.Drawing.Size(100, 50);
            this.LabPosSP.TabIndex = 152;
            this.LabPosSP.Text = "0.0";
            this.LabPosSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabPosSP.Click += new System.EventHandler(this.LabPosSP_Click);
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label6.ForeColor = System.Drawing.Color.White;
            this.Label6.Location = new System.Drawing.Point(272, 220);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(90, 20);
            this.Label6.TabIndex = 151;
            this.Label6.Text = "mm";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label7.ForeColor = System.Drawing.Color.White;
            this.Label7.Location = new System.Drawing.Point(42, 220);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(120, 20);
            this.Label7.TabIndex = 150;
            this.Label7.Text = "目标埚位";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnLoc
            // 
            this.BtnLoc.BackColor = System.Drawing.Color.Blue;
            this.BtnLoc.FlatAppearance.BorderSize = 0;
            this.BtnLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLoc.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnLoc.ForeColor = System.Drawing.Color.White;
            this.BtnLoc.Location = new System.Drawing.Point(262, 291);
            this.BtnLoc.Name = "BtnLoc";
            this.BtnLoc.Size = new System.Drawing.Size(100, 55);
            this.BtnLoc.TabIndex = 149;
            this.BtnLoc.Text = "定位";
            this.BtnLoc.UseVisualStyleBackColor = false;
            this.BtnLoc.Click += new System.EventHandler(this.BtnLoc_Click);
            // 
            // BtnAuto
            // 
            this.BtnAuto.BackColor = System.Drawing.Color.Blue;
            this.BtnAuto.FlatAppearance.BorderSize = 0;
            this.BtnAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAuto.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnAuto.ForeColor = System.Drawing.Color.White;
            this.BtnAuto.Location = new System.Drawing.Point(32, 323);
            this.BtnAuto.Name = "BtnAuto";
            this.BtnAuto.Size = new System.Drawing.Size(100, 35);
            this.BtnAuto.TabIndex = 148;
            this.BtnAuto.Text = "自动";
            this.BtnAuto.UseVisualStyleBackColor = false;
            this.BtnAuto.Click += new System.EventHandler(this.BtnAuto_Click);
            // 
            // BtnManu
            // 
            this.BtnManu.BackColor = System.Drawing.Color.Blue;
            this.BtnManu.FlatAppearance.BorderSize = 0;
            this.BtnManu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnManu.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnManu.ForeColor = System.Drawing.Color.White;
            this.BtnManu.Location = new System.Drawing.Point(32, 278);
            this.BtnManu.Name = "BtnManu";
            this.BtnManu.Size = new System.Drawing.Size(100, 35);
            this.BtnManu.TabIndex = 147;
            this.BtnManu.Text = "手动";
            this.BtnManu.UseVisualStyleBackColor = false;
            this.BtnManu.Click += new System.EventHandler(this.BtnManu_Click);
            // 
            // LabCL_SP
            // 
            this.LabCL_SP.BackColor = System.Drawing.Color.White;
            this.LabCL_SP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabCL_SP.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabCL_SP.ForeColor = System.Drawing.Color.Black;
            this.LabCL_SP.Location = new System.Drawing.Point(167, 135);
            this.LabCL_SP.Name = "LabCL_SP";
            this.LabCL_SP.Size = new System.Drawing.Size(100, 50);
            this.LabCL_SP.TabIndex = 146;
            this.LabCL_SP.Text = "0.0";
            this.LabCL_SP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabCL_SP.Click += new System.EventHandler(this.LabCL_SP_Click);
            // 
            // LabPosPV
            // 
            this.LabPosPV.BackColor = System.Drawing.Color.Black;
            this.LabPosPV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabPosPV.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabPosPV.ForeColor = System.Drawing.Color.White;
            this.LabPosPV.Location = new System.Drawing.Point(167, 65);
            this.LabPosPV.Name = "LabPosPV";
            this.LabPosPV.Size = new System.Drawing.Size(100, 50);
            this.LabPosPV.TabIndex = 145;
            this.LabPosPV.Text = "0.0";
            this.LabPosPV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(272, 80);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(80, 20);
            this.Label5.TabIndex = 144;
            this.Label5.Text = "mm";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(272, 150);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(80, 20);
            this.Label4.TabIndex = 143;
            this.Label4.Text = "mm/hr";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(42, 150);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(120, 20);
            this.Label2.TabIndex = 142;
            this.Label2.Text = "慢升速度";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(42, 80);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(120, 20);
            this.Label1.TabIndex = 141;
            this.Label1.Text = "当前埚位";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabName
            // 
            this.LabName.BackColor = System.Drawing.Color.Transparent;
            this.LabName.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabName.ForeColor = System.Drawing.Color.White;
            this.LabName.Location = new System.Drawing.Point(75, 13);
            this.LabName.Name = "LabName";
            this.LabName.Size = new System.Drawing.Size(245, 31);
            this.LabName.TabIndex = 140;
            this.LabName.Text = "坩埚位置";
            this.LabName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 500;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // BtnAddWeight
            // 
            this.BtnAddWeight.BackColor = System.Drawing.Color.Blue;
            this.BtnAddWeight.FlatAppearance.BorderSize = 0;
            this.BtnAddWeight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddWeight.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnAddWeight.ForeColor = System.Drawing.Color.White;
            this.BtnAddWeight.Location = new System.Drawing.Point(262, 396);
            this.BtnAddWeight.Name = "BtnAddWeight";
            this.BtnAddWeight.Size = new System.Drawing.Size(100, 50);
            this.BtnAddWeight.TabIndex = 161;
            this.BtnAddWeight.Text = "投料记录";
            this.BtnAddWeight.UseVisualStyleBackColor = false;
            this.BtnAddWeight.Click += new System.EventHandler(this.BtnAddWeight_Click);
            // 
            // FrmCrucPos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(394, 455);
            this.Controls.Add(this.BtnAddWeight);
            this.Controls.Add(this.LabTotalWeight);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.LabWeight);
            this.Controls.Add(this.BtnFast);
            this.Controls.Add(this.BtnSlow);
            this.Controls.Add(this.LabPosSP);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.BtnLoc);
            this.Controls.Add(this.BtnAuto);
            this.Controls.Add(this.BtnManu);
            this.Controls.Add(this.LabCL_SP);
            this.Controls.Add(this.LabPosPV);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.LabName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCrucPos";
            this.Text = "FrmCrucPos";
            this.Load += new System.EventHandler(this.FrmCrucPos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label LabTotalWeight;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label LabWeight;
        internal System.Windows.Forms.Button BtnFast;
        internal System.Windows.Forms.Button BtnSlow;
        internal System.Windows.Forms.Label LabPosSP;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Button BtnLoc;
        internal System.Windows.Forms.Button BtnAuto;
        internal System.Windows.Forms.Button BtnManu;
        internal System.Windows.Forms.Label LabCL_SP;
        internal System.Windows.Forms.Label LabPosPV;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label LabName;
        private System.Windows.Forms.Timer Timer1;
        internal System.Windows.Forms.Button BtnAddWeight;
    }
}