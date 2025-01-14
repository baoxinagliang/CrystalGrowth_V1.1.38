namespace CrystalGrowth.AuxFunction.Calibration
{
    partial class FrmCrownDia
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
            this.LabDiaOffs = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.LabRawPV = new System.Windows.Forms.Label();
            this.LabDiaCalib = new System.Windows.Forms.Label();
            this.LabDiaPV = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.LabName = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.BtnCalib = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabDateTime
            // 
            this.LabDateTime.BackColor = System.Drawing.Color.Transparent;
            this.LabDateTime.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabDateTime.ForeColor = System.Drawing.Color.White;
            this.LabDateTime.Location = new System.Drawing.Point(163, 353);
            this.LabDateTime.Name = "LabDateTime";
            this.LabDateTime.Size = new System.Drawing.Size(221, 20);
            this.LabDateTime.TabIndex = 191;
            this.LabDateTime.Text = "2000-01-01 00:00:00";
            this.LabDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label13
            // 
            this.Label13.BackColor = System.Drawing.Color.Transparent;
            this.Label13.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label13.ForeColor = System.Drawing.Color.White;
            this.Label13.Location = new System.Drawing.Point(87, 353);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(70, 20);
            this.Label13.TabIndex = 190;
            this.Label13.Text = "已校准";
            this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabDiaOffs
            // 
            this.LabDiaOffs.BackColor = System.Drawing.Color.White;
            this.LabDiaOffs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabDiaOffs.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabDiaOffs.ForeColor = System.Drawing.Color.Black;
            this.LabDiaOffs.Location = new System.Drawing.Point(167, 285);
            this.LabDiaOffs.Name = "LabDiaOffs";
            this.LabDiaOffs.Size = new System.Drawing.Size(100, 50);
            this.LabDiaOffs.TabIndex = 189;
            this.LabDiaOffs.Text = "0.00";
            this.LabDiaOffs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabDiaOffs.Click += new System.EventHandler(this.LabDiaOffs_Click);
            // 
            // Label11
            // 
            this.Label11.BackColor = System.Drawing.Color.Transparent;
            this.Label11.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label11.ForeColor = System.Drawing.Color.White;
            this.Label11.Location = new System.Drawing.Point(272, 300);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(48, 20);
            this.Label11.TabIndex = 188;
            this.Label11.Text = "mm";
            this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label12
            // 
            this.Label12.BackColor = System.Drawing.Color.Transparent;
            this.Label12.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label12.ForeColor = System.Drawing.Color.White;
            this.Label12.Location = new System.Drawing.Point(42, 300);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(120, 20);
            this.Label12.TabIndex = 187;
            this.Label12.Text = "直径偏移";
            this.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabRawPV
            // 
            this.LabRawPV.BackColor = System.Drawing.Color.Black;
            this.LabRawPV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabRawPV.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabRawPV.ForeColor = System.Drawing.Color.White;
            this.LabRawPV.Location = new System.Drawing.Point(167, 108);
            this.LabRawPV.Name = "LabRawPV";
            this.LabRawPV.Size = new System.Drawing.Size(100, 50);
            this.LabRawPV.TabIndex = 186;
            this.LabRawPV.Text = "0.00";
            this.LabRawPV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabDiaCalib
            // 
            this.LabDiaCalib.BackColor = System.Drawing.Color.White;
            this.LabDiaCalib.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabDiaCalib.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabDiaCalib.ForeColor = System.Drawing.Color.Black;
            this.LabDiaCalib.Location = new System.Drawing.Point(167, 167);
            this.LabDiaCalib.Name = "LabDiaCalib";
            this.LabDiaCalib.Size = new System.Drawing.Size(100, 50);
            this.LabDiaCalib.TabIndex = 185;
            this.LabDiaCalib.Text = "0.00";
            this.LabDiaCalib.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabDiaCalib.TextChanged += new System.EventHandler(this.LabDiaCalib_TextChanged);
            this.LabDiaCalib.Click += new System.EventHandler(this.LabDiaCalib_Click);
            // 
            // LabDiaPV
            // 
            this.LabDiaPV.BackColor = System.Drawing.Color.Black;
            this.LabDiaPV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabDiaPV.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabDiaPV.ForeColor = System.Drawing.Color.White;
            this.LabDiaPV.Location = new System.Drawing.Point(167, 49);
            this.LabDiaPV.Name = "LabDiaPV";
            this.LabDiaPV.Size = new System.Drawing.Size(100, 50);
            this.LabDiaPV.TabIndex = 184;
            this.LabDiaPV.Text = "0.00";
            this.LabDiaPV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label6.ForeColor = System.Drawing.Color.White;
            this.Label6.Location = new System.Drawing.Point(272, 182);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(48, 20);
            this.Label6.TabIndex = 183;
            this.Label6.Text = "mm";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(272, 64);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(48, 20);
            this.Label5.TabIndex = 182;
            this.Label5.Text = "mm";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(272, 123);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(48, 20);
            this.Label4.TabIndex = 181;
            this.Label4.Text = "mm";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(42, 182);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(120, 20);
            this.Label3.TabIndex = 180;
            this.Label3.Text = "直径校准值";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(42, 123);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(120, 20);
            this.Label2.TabIndex = 179;
            this.Label2.Text = "原始直径";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(42, 64);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(120, 20);
            this.Label1.TabIndex = 178;
            this.Label1.Text = "放肩直径";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabName
            // 
            this.LabName.BackColor = System.Drawing.Color.Transparent;
            this.LabName.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabName.ForeColor = System.Drawing.Color.White;
            this.LabName.Location = new System.Drawing.Point(75, 9);
            this.LabName.Name = "LabName";
            this.LabName.Size = new System.Drawing.Size(245, 31);
            this.LabName.TabIndex = 177;
            this.LabName.Text = "放肩直径校准";
            this.LabName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 500;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // BtnCalib
            // 
            this.BtnCalib.BackColor = System.Drawing.Color.Blue;
            this.BtnCalib.FlatAppearance.BorderSize = 0;
            this.BtnCalib.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalib.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCalib.ForeColor = System.Drawing.Color.White;
            this.BtnCalib.Location = new System.Drawing.Point(167, 226);
            this.BtnCalib.Name = "BtnCalib";
            this.BtnCalib.Size = new System.Drawing.Size(100, 50);
            this.BtnCalib.TabIndex = 192;
            this.BtnCalib.Text = "校准";
            this.BtnCalib.UseVisualStyleBackColor = false;
            this.BtnCalib.Click += new System.EventHandler(this.BtnCalib_Click);
            // 
            // FrmCrownDia
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(394, 380);
            this.Controls.Add(this.BtnCalib);
            this.Controls.Add(this.LabDateTime);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.LabDiaOffs);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.LabRawPV);
            this.Controls.Add(this.LabDiaCalib);
            this.Controls.Add(this.LabDiaPV);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.LabName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCrownDia";
            this.Text = "BtnCalib";
            this.Load += new System.EventHandler(this.BtnCalib_Load);
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Label LabDateTime;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label LabDiaOffs;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label LabRawPV;
        internal System.Windows.Forms.Label LabDiaCalib;
        internal System.Windows.Forms.Label LabDiaPV;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label LabName;
        internal System.Windows.Forms.Timer Timer1;
        internal System.Windows.Forms.Button BtnCalib;
    }
}