namespace CrystalGrowth.AuxFunction.Calibration
{
    partial class FrmMultiSegment
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
            this.Label5 = new System.Windows.Forms.Label();
            this.LabPullOutLen = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.LabMultiSegment = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.LabCrystalLen = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.LabDateTime = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.LabName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 500;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(269, 221);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(38, 20);
            this.Label5.TabIndex = 189;
            this.Label5.Text = "mm";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabPullOutLen
            // 
            this.LabPullOutLen.BackColor = System.Drawing.Color.White;
            this.LabPullOutLen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabPullOutLen.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabPullOutLen.ForeColor = System.Drawing.Color.Black;
            this.LabPullOutLen.Location = new System.Drawing.Point(164, 206);
            this.LabPullOutLen.Name = "LabPullOutLen";
            this.LabPullOutLen.Size = new System.Drawing.Size(100, 50);
            this.LabPullOutLen.TabIndex = 188;
            this.LabPullOutLen.Text = "0.0";
            this.LabPullOutLen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabPullOutLen.Click += new System.EventHandler(this.LabPullOutLen_Click);
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label7.ForeColor = System.Drawing.Color.White;
            this.Label7.Location = new System.Drawing.Point(56, 221);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(103, 20);
            this.Label7.TabIndex = 187;
            this.Label7.Text = "提段长度";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(269, 81);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(38, 20);
            this.Label1.TabIndex = 186;
            this.Label1.Text = "mm";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabMultiSegment
            // 
            this.LabMultiSegment.BackColor = System.Drawing.Color.Black;
            this.LabMultiSegment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabMultiSegment.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabMultiSegment.ForeColor = System.Drawing.Color.White;
            this.LabMultiSegment.Location = new System.Drawing.Point(164, 66);
            this.LabMultiSegment.Name = "LabMultiSegment";
            this.LabMultiSegment.Size = new System.Drawing.Size(100, 50);
            this.LabMultiSegment.TabIndex = 185;
            this.LabMultiSegment.Text = "0.0";
            this.LabMultiSegment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(56, 81);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(103, 20);
            this.Label3.TabIndex = 184;
            this.Label3.Text = "多段长度";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(269, 151);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(38, 20);
            this.Label4.TabIndex = 183;
            this.Label4.Text = "mm";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabCrystalLen
            // 
            this.LabCrystalLen.BackColor = System.Drawing.Color.Black;
            this.LabCrystalLen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabCrystalLen.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabCrystalLen.ForeColor = System.Drawing.Color.White;
            this.LabCrystalLen.Location = new System.Drawing.Point(164, 136);
            this.LabCrystalLen.Name = "LabCrystalLen";
            this.LabCrystalLen.Size = new System.Drawing.Size(100, 50);
            this.LabCrystalLen.TabIndex = 182;
            this.LabCrystalLen.Text = "0.0";
            this.LabCrystalLen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label10
            // 
            this.Label10.BackColor = System.Drawing.Color.Transparent;
            this.Label10.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label10.ForeColor = System.Drawing.Color.White;
            this.Label10.Location = new System.Drawing.Point(56, 151);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(103, 20);
            this.Label10.TabIndex = 181;
            this.Label10.Text = "晶体长度";
            this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabDateTime
            // 
            this.LabDateTime.BackColor = System.Drawing.Color.Transparent;
            this.LabDateTime.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabDateTime.ForeColor = System.Drawing.Color.White;
            this.LabDateTime.Location = new System.Drawing.Point(165, 347);
            this.LabDateTime.Name = "LabDateTime";
            this.LabDateTime.Size = new System.Drawing.Size(221, 20);
            this.LabDateTime.TabIndex = 180;
            this.LabDateTime.Text = "2000-01-01 00:00:00";
            this.LabDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label13
            // 
            this.Label13.BackColor = System.Drawing.Color.Transparent;
            this.Label13.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label13.ForeColor = System.Drawing.Color.White;
            this.Label13.Location = new System.Drawing.Point(89, 347);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(70, 20);
            this.Label13.TabIndex = 179;
            this.Label13.Text = "已校准";
            this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabName
            // 
            this.LabName.BackColor = System.Drawing.Color.Transparent;
            this.LabName.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabName.ForeColor = System.Drawing.Color.White;
            this.LabName.Location = new System.Drawing.Point(51, 14);
            this.LabName.Name = "LabName";
            this.LabName.Size = new System.Drawing.Size(286, 31);
            this.LabName.TabIndex = 178;
            this.LabName.Text = "等径多段长度校准";
            this.LabName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMultiSegment
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(394, 380);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.LabPullOutLen);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.LabMultiSegment);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.LabCrystalLen);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.LabDateTime);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.LabName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMultiSegment";
            this.Text = "FrmMultiSegment";
            this.Load += new System.EventHandler(this.FrmMultiSegment_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer Timer1;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label LabPullOutLen;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label LabMultiSegment;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label LabCrystalLen;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label LabDateTime;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label LabName;
    }
}