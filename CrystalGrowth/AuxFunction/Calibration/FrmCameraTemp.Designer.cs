namespace CrystalGrowth.AuxFunction.Calibration
{
    partial class FrmCameraTemp
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
            this.BtnCalib = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.LabDateTime = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.LabRealTemp = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.LabCalib = new System.Windows.Forms.Label();
            this.LabRawPV = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.LabName = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.BtnOffsetCalib = new System.Windows.Forms.Button();
            this.LabMeltTempCoef = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.LabMeltTempOffset = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCalib
            // 
            this.BtnCalib.BackColor = System.Drawing.Color.Blue;
            this.BtnCalib.FlatAppearance.BorderSize = 0;
            this.BtnCalib.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalib.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCalib.ForeColor = System.Drawing.Color.White;
            this.BtnCalib.Location = new System.Drawing.Point(265, 280);
            this.BtnCalib.Name = "BtnCalib";
            this.BtnCalib.Size = new System.Drawing.Size(100, 50);
            this.BtnCalib.TabIndex = 191;
            this.BtnCalib.Text = "系数校准";
            this.BtnCalib.UseVisualStyleBackColor = false;
            this.BtnCalib.Click += new System.EventHandler(this.BtnCalib_Click);
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(272, 155);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(64, 20);
            this.Label3.TabIndex = 190;
            this.Label3.Text = "degC";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabDateTime
            // 
            this.LabDateTime.BackColor = System.Drawing.Color.Transparent;
            this.LabDateTime.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabDateTime.ForeColor = System.Drawing.Color.White;
            this.LabDateTime.Location = new System.Drawing.Point(168, 351);
            this.LabDateTime.Name = "LabDateTime";
            this.LabDateTime.Size = new System.Drawing.Size(221, 20);
            this.LabDateTime.TabIndex = 189;
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
            this.Label13.TabIndex = 188;
            this.Label13.Text = "已校准";
            this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabRealTemp
            // 
            this.LabRealTemp.BackColor = System.Drawing.Color.Black;
            this.LabRealTemp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabRealTemp.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabRealTemp.ForeColor = System.Drawing.Color.White;
            this.LabRealTemp.Location = new System.Drawing.Point(167, 140);
            this.LabRealTemp.Name = "LabRealTemp";
            this.LabRealTemp.Size = new System.Drawing.Size(100, 50);
            this.LabRealTemp.TabIndex = 187;
            this.LabRealTemp.Text = "0.0";
            this.LabRealTemp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label7.ForeColor = System.Drawing.Color.White;
            this.Label7.Location = new System.Drawing.Point(46, 155);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(116, 20);
            this.Label7.TabIndex = 186;
            this.Label7.Text = "实际温度";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabCalib
            // 
            this.LabCalib.BackColor = System.Drawing.Color.White;
            this.LabCalib.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabCalib.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabCalib.ForeColor = System.Drawing.Color.Black;
            this.LabCalib.Location = new System.Drawing.Point(167, 210);
            this.LabCalib.Name = "LabCalib";
            this.LabCalib.Size = new System.Drawing.Size(100, 50);
            this.LabCalib.TabIndex = 185;
            this.LabCalib.Text = "0.0";
            this.LabCalib.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabCalib.TextChanged += new System.EventHandler(this.LabCalib_TextChanged);
            this.LabCalib.Click += new System.EventHandler(this.LabCalib_Click);
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
            this.LabRawPV.TabIndex = 184;
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
            this.Label5.Size = new System.Drawing.Size(64, 20);
            this.Label5.TabIndex = 183;
            this.Label5.Text = "degC";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(272, 225);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(64, 20);
            this.Label4.TabIndex = 182;
            this.Label4.Text = "degC";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(46, 225);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(116, 20);
            this.Label2.TabIndex = 181;
            this.Label2.Text = "温度校准值";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(46, 85);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(116, 20);
            this.Label1.TabIndex = 180;
            this.Label1.Text = "视觉测量值";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabName
            // 
            this.LabName.BackColor = System.Drawing.Color.Transparent;
            this.LabName.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabName.ForeColor = System.Drawing.Color.White;
            this.LabName.Location = new System.Drawing.Point(59, 18);
            this.LabName.Name = "LabName";
            this.LabName.Size = new System.Drawing.Size(277, 31);
            this.LabName.TabIndex = 179;
            this.LabName.Text = "液面温度校准";
            this.LabName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 500;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // BtnOffsetCalib
            // 
            this.BtnOffsetCalib.BackColor = System.Drawing.Color.Blue;
            this.BtnOffsetCalib.FlatAppearance.BorderSize = 0;
            this.BtnOffsetCalib.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOffsetCalib.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnOffsetCalib.ForeColor = System.Drawing.Color.White;
            this.BtnOffsetCalib.Location = new System.Drawing.Point(62, 280);
            this.BtnOffsetCalib.Name = "BtnOffsetCalib";
            this.BtnOffsetCalib.Size = new System.Drawing.Size(100, 50);
            this.BtnOffsetCalib.TabIndex = 192;
            this.BtnOffsetCalib.Text = "偏移校准";
            this.BtnOffsetCalib.UseVisualStyleBackColor = false;
            this.BtnOffsetCalib.Click += new System.EventHandler(this.BtnOffsetCalib_Click);
            // 
            // LabMeltTempCoef
            // 
            this.LabMeltTempCoef.BackColor = System.Drawing.Color.Black;
            this.LabMeltTempCoef.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabMeltTempCoef.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabMeltTempCoef.ForeColor = System.Drawing.Color.White;
            this.LabMeltTempCoef.Location = new System.Drawing.Point(454, 70);
            this.LabMeltTempCoef.Name = "LabMeltTempCoef";
            this.LabMeltTempCoef.Size = new System.Drawing.Size(100, 50);
            this.LabMeltTempCoef.TabIndex = 196;
            this.LabMeltTempCoef.Text = "0.0000";
            this.LabMeltTempCoef.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label12
            // 
            this.Label12.BackColor = System.Drawing.Color.Transparent;
            this.Label12.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label12.ForeColor = System.Drawing.Color.White;
            this.Label12.Location = new System.Drawing.Point(359, 85);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(90, 20);
            this.Label12.TabIndex = 195;
            this.Label12.Text = "校准系数";
            this.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabMeltTempOffset
            // 
            this.LabMeltTempOffset.BackColor = System.Drawing.Color.Black;
            this.LabMeltTempOffset.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabMeltTempOffset.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabMeltTempOffset.ForeColor = System.Drawing.Color.White;
            this.LabMeltTempOffset.Location = new System.Drawing.Point(454, 140);
            this.LabMeltTempOffset.Name = "LabMeltTempOffset";
            this.LabMeltTempOffset.Size = new System.Drawing.Size(100, 50);
            this.LabMeltTempOffset.TabIndex = 194;
            this.LabMeltTempOffset.Text = "0.00";
            this.LabMeltTempOffset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label9
            // 
            this.Label9.BackColor = System.Drawing.Color.Transparent;
            this.Label9.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label9.ForeColor = System.Drawing.Color.White;
            this.Label9.Location = new System.Drawing.Point(359, 155);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(90, 20);
            this.Label9.TabIndex = 193;
            this.Label9.Text = "校准偏移值";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmCameraTemp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(580, 380);
            this.Controls.Add(this.LabMeltTempCoef);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.LabMeltTempOffset);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.BtnOffsetCalib);
            this.Controls.Add(this.BtnCalib);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.LabDateTime);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.LabRealTemp);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.LabCalib);
            this.Controls.Add(this.LabRawPV);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.LabName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCameraTemp";
            this.Text = "FrmCameraTemp";
            this.Load += new System.EventHandler(this.FrmCameraTemp_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button BtnCalib;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label LabDateTime;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label LabRealTemp;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label LabCalib;
        internal System.Windows.Forms.Label LabRawPV;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label LabName;
        internal System.Windows.Forms.Timer Timer1;
        internal System.Windows.Forms.Button BtnOffsetCalib;
        internal System.Windows.Forms.Label LabMeltTempCoef;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label LabMeltTempOffset;
        internal System.Windows.Forms.Label Label9;
    }
}