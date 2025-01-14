namespace CrystalGrowth.AuxFunction.Calibration
{
    partial class FrmHtrTempClib
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
            this.BtnCalib = new System.Windows.Forms.Button();
            this.LabDateTime = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.LabTempPV = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.LabGain = new System.Windows.Forms.Label();
            this.LabRawPV = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
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
            // BtnCalib
            // 
            this.BtnCalib.BackColor = System.Drawing.Color.Blue;
            this.BtnCalib.FlatAppearance.BorderSize = 0;
            this.BtnCalib.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalib.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCalib.ForeColor = System.Drawing.Color.White;
            this.BtnCalib.Location = new System.Drawing.Point(167, 210);
            this.BtnCalib.Name = "BtnCalib";
            this.BtnCalib.Size = new System.Drawing.Size(100, 50);
            this.BtnCalib.TabIndex = 197;
            this.BtnCalib.Text = "校准";
            this.BtnCalib.UseVisualStyleBackColor = false;
            this.BtnCalib.Click += new System.EventHandler(this.BtnCalib_Click);
            // 
            // LabDateTime
            // 
            this.LabDateTime.BackColor = System.Drawing.Color.Transparent;
            this.LabDateTime.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabDateTime.ForeColor = System.Drawing.Color.White;
            this.LabDateTime.Location = new System.Drawing.Point(168, 351);
            this.LabDateTime.Name = "LabDateTime";
            this.LabDateTime.Size = new System.Drawing.Size(221, 20);
            this.LabDateTime.TabIndex = 196;
            this.LabDateTime.Text = "2000-01-01 00:00:00";
            this.LabDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label13
            // 
            this.Label13.BackColor = System.Drawing.Color.Transparent;
            this.Label13.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label13.ForeColor = System.Drawing.Color.White;
            this.Label13.Location = new System.Drawing.Point(92, 351);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(70, 20);
            this.Label13.TabIndex = 195;
            this.Label13.Text = "已校准";
            this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label11
            // 
            this.Label11.BackColor = System.Drawing.Color.Transparent;
            this.Label11.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label11.ForeColor = System.Drawing.Color.White;
            this.Label11.Location = new System.Drawing.Point(272, 295);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(67, 20);
            this.Label11.TabIndex = 194;
            this.Label11.Text = "units";
            this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabTempPV
            // 
            this.LabTempPV.BackColor = System.Drawing.Color.Black;
            this.LabTempPV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabTempPV.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabTempPV.ForeColor = System.Drawing.Color.White;
            this.LabTempPV.Location = new System.Drawing.Point(167, 280);
            this.LabTempPV.Name = "LabTempPV";
            this.LabTempPV.Size = new System.Drawing.Size(100, 50);
            this.LabTempPV.TabIndex = 193;
            this.LabTempPV.Text = "0.0";
            this.LabTempPV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label9
            // 
            this.Label9.BackColor = System.Drawing.Color.Transparent;
            this.Label9.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label9.ForeColor = System.Drawing.Color.White;
            this.Label9.Location = new System.Drawing.Point(31, 295);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(131, 20);
            this.Label9.TabIndex = 192;
            this.Label9.Text = "热场温度";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabGain
            // 
            this.LabGain.BackColor = System.Drawing.Color.Black;
            this.LabGain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabGain.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabGain.ForeColor = System.Drawing.Color.White;
            this.LabGain.Location = new System.Drawing.Point(167, 140);
            this.LabGain.Name = "LabGain";
            this.LabGain.Size = new System.Drawing.Size(100, 50);
            this.LabGain.TabIndex = 191;
            this.LabGain.Text = "0.00";
            this.LabGain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabRawPV
            // 
            this.LabRawPV.BackColor = System.Drawing.Color.Black;
            this.LabRawPV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabRawPV.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabRawPV.ForeColor = System.Drawing.Color.White;
            this.LabRawPV.Location = new System.Drawing.Point(167, 70);
            this.LabRawPV.Name = "LabRawPV";
            this.LabRawPV.Size = new System.Drawing.Size(100, 50);
            this.LabRawPV.TabIndex = 190;
            this.LabRawPV.Text = "0.0";
            this.LabRawPV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(272, 85);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(67, 20);
            this.Label5.TabIndex = 189;
            this.Label5.Text = "units";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(31, 155);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(131, 20);
            this.Label2.TabIndex = 188;
            this.Label2.Text = "增益系数";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(31, 85);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(131, 20);
            this.Label1.TabIndex = 187;
            this.Label1.Text = "高温计测量值";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabName
            // 
            this.LabName.BackColor = System.Drawing.Color.Transparent;
            this.LabName.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabName.ForeColor = System.Drawing.Color.White;
            this.LabName.Location = new System.Drawing.Point(75, 18);
            this.LabName.Name = "LabName";
            this.LabName.Size = new System.Drawing.Size(245, 31);
            this.LabName.TabIndex = 186;
            this.LabName.Text = "热场温度校准";
            this.LabName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmHtrTempClib
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(394, 380);
            this.Controls.Add(this.BtnCalib);
            this.Controls.Add(this.LabDateTime);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.LabTempPV);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.LabGain);
            this.Controls.Add(this.LabRawPV);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.LabName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHtrTempClib";
            this.Text = "FrmHtrTempClib";
            this.Load += new System.EventHandler(this.FrmHtrTempClib_Load);
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Button BtnCalib;
        internal System.Windows.Forms.Label LabDateTime;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label LabTempPV;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label LabGain;
        internal System.Windows.Forms.Label LabRawPV;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label LabName;
        internal System.Windows.Forms.Timer Timer1;
    }
}