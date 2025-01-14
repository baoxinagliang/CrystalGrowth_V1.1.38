namespace CrystalGrowth.AuxFunction.CCD
{
    partial class FrmCrystalShake
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
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.LabShakeAlarm = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.LabShakeVal = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.LabBodyShake = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.LabCrownShake = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.LabNeckShake = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.LabName = new System.Windows.Forms.Label();
            this.Panel4.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 250;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // BtnStart
            // 
            this.BtnStart.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnStart.FlatAppearance.BorderSize = 0;
            this.BtnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStart.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnStart.ForeColor = System.Drawing.Color.White;
            this.BtnStart.Location = new System.Drawing.Point(14, 496);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(117, 60);
            this.BtnStart.TabIndex = 199;
            this.BtnStart.Text = "启动";
            this.BtnStart.UseVisualStyleBackColor = false;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnQuit
            // 
            this.BtnQuit.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnQuit.FlatAppearance.BorderSize = 0;
            this.BtnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnQuit.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnQuit.ForeColor = System.Drawing.Color.White;
            this.BtnQuit.Location = new System.Drawing.Point(251, 568);
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.Size = new System.Drawing.Size(117, 60);
            this.BtnQuit.TabIndex = 197;
            this.BtnQuit.Text = "返回";
            this.BtnQuit.UseVisualStyleBackColor = false;
            this.BtnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnSave.FlatAppearance.BorderSize = 0;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Location = new System.Drawing.Point(250, 496);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(117, 60);
            this.BtnSave.TabIndex = 198;
            this.BtnSave.Text = "保存";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // Panel4
            // 
            this.Panel4.BackColor = System.Drawing.Color.DarkGray;
            this.Panel4.Controls.Add(this.LabShakeAlarm);
            this.Panel4.Controls.Add(this.Label3);
            this.Panel4.Controls.Add(this.LabShakeVal);
            this.Panel4.Controls.Add(this.Label6);
            this.Panel4.Controls.Add(this.Label8);
            this.Panel4.Location = new System.Drawing.Point(14, 332);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(354, 141);
            this.Panel4.TabIndex = 203;
            // 
            // LabShakeAlarm
            // 
            this.LabShakeAlarm.BackColor = System.Drawing.Color.Transparent;
            this.LabShakeAlarm.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabShakeAlarm.ForeColor = System.Drawing.Color.White;
            this.LabShakeAlarm.Location = new System.Drawing.Point(216, 93);
            this.LabShakeAlarm.Name = "LabShakeAlarm";
            this.LabShakeAlarm.Size = new System.Drawing.Size(94, 40);
            this.LabShakeAlarm.TabIndex = 191;
            this.LabShakeAlarm.Text = "无晃动";
            this.LabShakeAlarm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(38, 93);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(150, 40);
            this.Label3.TabIndex = 190;
            this.Label3.Text = "晃动报警:";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabShakeVal
            // 
            this.LabShakeVal.BackColor = System.Drawing.Color.Black;
            this.LabShakeVal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabShakeVal.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabShakeVal.ForeColor = System.Drawing.Color.White;
            this.LabShakeVal.Location = new System.Drawing.Point(216, 47);
            this.LabShakeVal.Name = "LabShakeVal";
            this.LabShakeVal.Size = new System.Drawing.Size(97, 40);
            this.LabShakeVal.TabIndex = 188;
            this.LabShakeVal.Text = "0.0";
            this.LabShakeVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label6.ForeColor = System.Drawing.Color.White;
            this.Label6.Location = new System.Drawing.Point(38, 47);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(150, 40);
            this.Label6.TabIndex = 189;
            this.Label6.Text = "晃动值(mm):";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label8
            // 
            this.Label8.BackColor = System.Drawing.Color.Transparent;
            this.Label8.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label8.ForeColor = System.Drawing.Color.Black;
            this.Label8.Location = new System.Drawing.Point(68, 5);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(198, 40);
            this.Label8.TabIndex = 186;
            this.Label8.Text = "晃动测量";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.DarkGray;
            this.Panel3.Controls.Add(this.LabBodyShake);
            this.Panel3.Controls.Add(this.Label7);
            this.Panel3.Controls.Add(this.Label2);
            this.Panel3.Location = new System.Drawing.Point(14, 225);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(354, 101);
            this.Panel3.TabIndex = 202;
            // 
            // LabBodyShake
            // 
            this.LabBodyShake.BackColor = System.Drawing.Color.White;
            this.LabBodyShake.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabBodyShake.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabBodyShake.ForeColor = System.Drawing.Color.Black;
            this.LabBodyShake.Location = new System.Drawing.Point(216, 49);
            this.LabBodyShake.Name = "LabBodyShake";
            this.LabBodyShake.Size = new System.Drawing.Size(97, 40);
            this.LabBodyShake.TabIndex = 188;
            this.LabBodyShake.Text = "0.0";
            this.LabBodyShake.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabBodyShake.Click += new System.EventHandler(this.LabBodyShake_Click);
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label7.ForeColor = System.Drawing.Color.White;
            this.Label7.Location = new System.Drawing.Point(28, 49);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(160, 40);
            this.Label7.TabIndex = 189;
            this.Label7.Text = "报警阈值(mm):";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(68, 4);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(198, 40);
            this.Label2.TabIndex = 186;
            this.Label2.Text = "等径晃动参数";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.DarkGray;
            this.Panel1.Controls.Add(this.LabCrownShake);
            this.Panel1.Controls.Add(this.Label4);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Location = new System.Drawing.Point(14, 118);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(354, 101);
            this.Panel1.TabIndex = 201;
            // 
            // LabCrownShake
            // 
            this.LabCrownShake.BackColor = System.Drawing.Color.White;
            this.LabCrownShake.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabCrownShake.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabCrownShake.ForeColor = System.Drawing.Color.Black;
            this.LabCrownShake.Location = new System.Drawing.Point(216, 54);
            this.LabCrownShake.Name = "LabCrownShake";
            this.LabCrownShake.Size = new System.Drawing.Size(97, 40);
            this.LabCrownShake.TabIndex = 188;
            this.LabCrownShake.Text = "0.0";
            this.LabCrownShake.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabCrownShake.Click += new System.EventHandler(this.LabCrownShake_Click);
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(28, 54);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(160, 40);
            this.Label4.TabIndex = 189;
            this.Label4.Text = "报警阈值(mm):";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(68, 5);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(198, 40);
            this.Label1.TabIndex = 186;
            this.Label1.Text = "放肩晃动参数";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.DarkGray;
            this.Panel2.Controls.Add(this.LabNeckShake);
            this.Panel2.Controls.Add(this.Label5);
            this.Panel2.Controls.Add(this.LabName);
            this.Panel2.Location = new System.Drawing.Point(14, 11);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(354, 101);
            this.Panel2.TabIndex = 200;
            // 
            // LabNeckShake
            // 
            this.LabNeckShake.BackColor = System.Drawing.Color.White;
            this.LabNeckShake.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabNeckShake.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabNeckShake.ForeColor = System.Drawing.Color.Black;
            this.LabNeckShake.Location = new System.Drawing.Point(216, 50);
            this.LabNeckShake.Name = "LabNeckShake";
            this.LabNeckShake.Size = new System.Drawing.Size(97, 40);
            this.LabNeckShake.TabIndex = 186;
            this.LabNeckShake.Text = "0.0";
            this.LabNeckShake.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabNeckShake.Click += new System.EventHandler(this.LabNeckShake_Click);
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(28, 50);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(160, 40);
            this.Label5.TabIndex = 187;
            this.Label5.Text = "报警阈值(mm):";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabName
            // 
            this.LabName.BackColor = System.Drawing.Color.Transparent;
            this.LabName.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabName.ForeColor = System.Drawing.Color.Black;
            this.LabName.Location = new System.Drawing.Point(68, 4);
            this.LabName.Name = "LabName";
            this.LabName.Size = new System.Drawing.Size(198, 40);
            this.LabName.TabIndex = 185;
            this.LabName.Text = "引晶晃动参数";
            this.LabName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmCrystalShake
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(380, 638);
            this.Controls.Add(this.Panel4);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.BtnQuit);
            this.Controls.Add(this.BtnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCrystalShake";
            this.Text = "FrmCrystalShakeArea";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCrystalShake_FormClosed);
            this.Load += new System.EventHandler(this.FrmCrystalShake_Load);
            this.Panel4.ResumeLayout(false);
            this.Panel3.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer Timer1;
        internal System.Windows.Forms.Button BtnStart;
        internal System.Windows.Forms.Button BtnQuit;
        internal System.Windows.Forms.Button BtnSave;
        internal System.Windows.Forms.Panel Panel4;
        internal System.Windows.Forms.Label LabShakeAlarm;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label LabShakeVal;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.Label LabBodyShake;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label LabCrownShake;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Label LabNeckShake;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label LabName;
    }
}