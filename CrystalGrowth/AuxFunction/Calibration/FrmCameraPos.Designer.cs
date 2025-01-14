namespace CrystalGrowth.AuxFunction.Calibration
{
    partial class FrmCameraPos
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
            this.Label5 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.LabCCDCable = new System.Windows.Forms.Label();
            this.LabCCDHtr = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.LabName = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.Lbl_R = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Lbl_H = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Lbl_T = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabDateTime
            // 
            this.LabDateTime.BackColor = System.Drawing.Color.Transparent;
            this.LabDateTime.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabDateTime.ForeColor = System.Drawing.Color.White;
            this.LabDateTime.Location = new System.Drawing.Point(168, 351);
            this.LabDateTime.Name = "LabDateTime";
            this.LabDateTime.Size = new System.Drawing.Size(221, 20);
            this.LabDateTime.TabIndex = 118;
            this.LabDateTime.Text = "2000-01-01 00:00:00";
            this.LabDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(92, 351);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(70, 20);
            this.Label5.TabIndex = 117;
            this.Label5.Text = "已校准";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(272, 74);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(34, 20);
            this.Label1.TabIndex = 116;
            this.Label1.Text = "mm";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabCCDCable
            // 
            this.LabCCDCable.BackColor = System.Drawing.Color.White;
            this.LabCCDCable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabCCDCable.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabCCDCable.ForeColor = System.Drawing.Color.Black;
            this.LabCCDCable.Location = new System.Drawing.Point(167, 59);
            this.LabCCDCable.Name = "LabCCDCable";
            this.LabCCDCable.Size = new System.Drawing.Size(100, 50);
            this.LabCCDCable.TabIndex = 115;
            this.LabCCDCable.Text = "0.0";
            this.LabCCDCable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabCCDCable.Click += new System.EventHandler(this.LabCCDCable_Click);
            // 
            // LabCCDHtr
            // 
            this.LabCCDHtr.BackColor = System.Drawing.Color.White;
            this.LabCCDHtr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabCCDHtr.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabCCDHtr.ForeColor = System.Drawing.Color.Black;
            this.LabCCDHtr.Location = new System.Drawing.Point(167, 111);
            this.LabCCDHtr.Name = "LabCCDHtr";
            this.LabCCDHtr.Size = new System.Drawing.Size(100, 50);
            this.LabCCDHtr.TabIndex = 114;
            this.LabCCDHtr.Text = "0.0";
            this.LabCCDHtr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabCCDHtr.Click += new System.EventHandler(this.LabCCDHtr_Click);
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label6.ForeColor = System.Drawing.Color.White;
            this.Label6.Location = new System.Drawing.Point(272, 126);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(34, 20);
            this.Label6.TabIndex = 113;
            this.Label6.Text = "mm";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(12, 126);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(150, 20);
            this.Label3.TabIndex = 112;
            this.Label3.Text = "摄像头距加热器";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(12, 74);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(150, 20);
            this.Label2.TabIndex = 111;
            this.Label2.Text = "摄像头距软轴";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabName
            // 
            this.LabName.BackColor = System.Drawing.Color.Transparent;
            this.LabName.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabName.ForeColor = System.Drawing.Color.White;
            this.LabName.Location = new System.Drawing.Point(75, 18);
            this.LabName.Name = "LabName";
            this.LabName.Size = new System.Drawing.Size(245, 31);
            this.LabName.TabIndex = 110;
            this.LabName.Text = "摄像头位置";
            this.LabName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 500;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Lbl_R
            // 
            this.Lbl_R.BackColor = System.Drawing.Color.White;
            this.Lbl_R.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_R.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_R.ForeColor = System.Drawing.Color.Black;
            this.Lbl_R.Location = new System.Drawing.Point(167, 276);
            this.Lbl_R.Name = "Lbl_R";
            this.Lbl_R.Size = new System.Drawing.Size(100, 40);
            this.Lbl_R.TabIndex = 188;
            this.Lbl_R.Text = "0";
            this.Lbl_R.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Lbl_R.Click += new System.EventHandler(this.Lbl_R_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(24, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 40);
            this.label8.TabIndex = 187;
            this.label8.Text = "R:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lbl_H
            // 
            this.Lbl_H.BackColor = System.Drawing.Color.White;
            this.Lbl_H.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_H.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_H.ForeColor = System.Drawing.Color.Black;
            this.Lbl_H.Location = new System.Drawing.Point(167, 234);
            this.Lbl_H.Name = "Lbl_H";
            this.Lbl_H.Size = new System.Drawing.Size(100, 40);
            this.Lbl_H.TabIndex = 186;
            this.Lbl_H.Text = "0";
            this.Lbl_H.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Lbl_H.Click += new System.EventHandler(this.Lbl_H_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(20, 233);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 40);
            this.label10.TabIndex = 185;
            this.label10.Text = "H:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lbl_T
            // 
            this.Lbl_T.BackColor = System.Drawing.Color.White;
            this.Lbl_T.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_T.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_T.ForeColor = System.Drawing.Color.Black;
            this.Lbl_T.Location = new System.Drawing.Point(167, 192);
            this.Lbl_T.Name = "Lbl_T";
            this.Lbl_T.Size = new System.Drawing.Size(100, 40);
            this.Lbl_T.TabIndex = 184;
            this.Lbl_T.Text = "0";
            this.Lbl_T.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Lbl_T.Click += new System.EventHandler(this.Lbl_T_Click);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(16, 191);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 40);
            this.label12.TabIndex = 183;
            this.label12.Text = "T:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(273, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 20);
            this.label9.TabIndex = 194;
            this.label9.Text = "mm";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(272, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 20);
            this.label7.TabIndex = 193;
            this.label7.Text = "mm";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(272, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 192;
            this.label4.Text = "mm";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmCameraPos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(394, 380);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Lbl_R);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Lbl_H);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Lbl_T);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.LabDateTime);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.LabCCDCable);
            this.Controls.Add(this.LabCCDHtr);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.LabName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCameraPos";
            this.Text = "FrmCameraPos";
            this.Load += new System.EventHandler(this.FrmCameraPos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label LabDateTime;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label LabCCDCable;
        internal System.Windows.Forms.Label LabCCDHtr;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label LabName;
        internal System.Windows.Forms.Timer Timer1;
        internal System.Windows.Forms.Label Lbl_R;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label Lbl_H;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Label Lbl_T;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label4;
    }
}