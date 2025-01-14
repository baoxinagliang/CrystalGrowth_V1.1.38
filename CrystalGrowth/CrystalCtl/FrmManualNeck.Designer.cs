namespace CrystalGrowth.CrystalCtl
{
    partial class FrmManualNeck
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
            this.Panel2 = new System.Windows.Forms.Panel();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.BtnOFF = new System.Windows.Forms.Button();
            this.BtnON = new System.Windows.Forms.Button();
            this.LabMaxSP = new System.Windows.Forms.Label();
            this.LabMinSP = new System.Windows.Forms.Label();
            this.LabPV = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.LabName = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.Panel2.Controls.Add(this.BtnQuit);
            this.Panel2.Location = new System.Drawing.Point(394, 0);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(137, 380);
            this.Panel2.TabIndex = 147;
            // 
            // BtnQuit
            // 
            this.BtnQuit.BackColor = System.Drawing.Color.Blue;
            this.BtnQuit.FlatAppearance.BorderSize = 0;
            this.BtnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnQuit.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnQuit.ForeColor = System.Drawing.Color.White;
            this.BtnQuit.Location = new System.Drawing.Point(10, 4);
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.Size = new System.Drawing.Size(117, 60);
            this.BtnQuit.TabIndex = 132;
            this.BtnQuit.Text = "退出";
            this.BtnQuit.UseVisualStyleBackColor = false;
            this.BtnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // BtnOFF
            // 
            this.BtnOFF.BackColor = System.Drawing.Color.Blue;
            this.BtnOFF.FlatAppearance.BorderSize = 0;
            this.BtnOFF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOFF.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnOFF.ForeColor = System.Drawing.Color.White;
            this.BtnOFF.Location = new System.Drawing.Point(147, 330);
            this.BtnOFF.Name = "BtnOFF";
            this.BtnOFF.Size = new System.Drawing.Size(100, 35);
            this.BtnOFF.TabIndex = 146;
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
            this.BtnON.Location = new System.Drawing.Point(147, 285);
            this.BtnON.Name = "BtnON";
            this.BtnON.Size = new System.Drawing.Size(100, 35);
            this.BtnON.TabIndex = 145;
            this.BtnON.Text = "ON";
            this.BtnON.UseVisualStyleBackColor = false;
            this.BtnON.Click += new System.EventHandler(this.BtnON_Click);
            // 
            // LabMaxSP
            // 
            this.LabMaxSP.BackColor = System.Drawing.Color.White;
            this.LabMaxSP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabMaxSP.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabMaxSP.ForeColor = System.Drawing.Color.Black;
            this.LabMaxSP.Location = new System.Drawing.Point(167, 140);
            this.LabMaxSP.Name = "LabMaxSP";
            this.LabMaxSP.Size = new System.Drawing.Size(100, 50);
            this.LabMaxSP.TabIndex = 144;
            this.LabMaxSP.Text = "0.0";
            this.LabMaxSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabMaxSP.Click += new System.EventHandler(this.LabMaxSP_Click);
            // 
            // LabMinSP
            // 
            this.LabMinSP.BackColor = System.Drawing.Color.White;
            this.LabMinSP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabMinSP.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabMinSP.ForeColor = System.Drawing.Color.Black;
            this.LabMinSP.Location = new System.Drawing.Point(167, 210);
            this.LabMinSP.Name = "LabMinSP";
            this.LabMinSP.Size = new System.Drawing.Size(100, 50);
            this.LabMinSP.TabIndex = 143;
            this.LabMinSP.Text = "0.0";
            this.LabMinSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabMinSP.Click += new System.EventHandler(this.LabMinSP_Click);
            // 
            // LabPV
            // 
            this.LabPV.BackColor = System.Drawing.Color.Black;
            this.LabPV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabPV.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabPV.ForeColor = System.Drawing.Color.White;
            this.LabPV.Location = new System.Drawing.Point(167, 70);
            this.LabPV.Name = "LabPV";
            this.LabPV.Size = new System.Drawing.Size(100, 50);
            this.LabPV.TabIndex = 142;
            this.LabPV.Text = "0.0";
            this.LabPV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label6.ForeColor = System.Drawing.Color.White;
            this.Label6.Location = new System.Drawing.Point(272, 225);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(80, 20);
            this.Label6.TabIndex = 141;
            this.Label6.Text = "mm/hr";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(272, 85);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(80, 20);
            this.Label5.TabIndex = 140;
            this.Label5.Text = "mm/hr";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(272, 155);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(80, 20);
            this.Label4.TabIndex = 139;
            this.Label4.Text = "mm/hr";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(42, 225);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(120, 20);
            this.Label3.TabIndex = 138;
            this.Label3.Text = "设定低速";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(42, 155);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(120, 20);
            this.Label2.TabIndex = 137;
            this.Label2.Text = "设定高速";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(42, 85);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(120, 20);
            this.Label1.TabIndex = 136;
            this.Label1.Text = "实际速度";
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
            this.LabName.TabIndex = 135;
            this.LabName.Text = "手动引晶";
            this.LabName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 500;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // FrmManualNeck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(531, 380);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.BtnOFF);
            this.Controls.Add(this.BtnON);
            this.Controls.Add(this.LabMaxSP);
            this.Controls.Add(this.LabMinSP);
            this.Controls.Add(this.LabPV);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.LabName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmManualNeck";
            this.Text = "FrmManualNeck";
            this.Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Button BtnQuit;
        internal System.Windows.Forms.Button BtnOFF;
        internal System.Windows.Forms.Button BtnON;
        internal System.Windows.Forms.Label LabMaxSP;
        internal System.Windows.Forms.Label LabMinSP;
        internal System.Windows.Forms.Label LabPV;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label LabName;
        private System.Windows.Forms.Timer Timer1;
    }
}