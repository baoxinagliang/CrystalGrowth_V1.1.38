namespace CrystalGrowth.CrystalCtl
{
    partial class FrmSeedLift
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
            this.LabSeedTrv = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.GBDiaCalib = new System.Windows.Forms.GroupBox();
            this.LabSLFastSet = new System.Windows.Forms.Label();
            this.BtnBoxCtl = new System.Windows.Forms.Button();
            this.BtnManualNeck = new System.Windows.Forms.Button();
            this.BtnForce = new System.Windows.Forms.Button();
            this.BtnSlow = new System.Windows.Forms.Button();
            this.BtnFast = new System.Windows.Forms.Button();
            this.BtnDown = new System.Windows.Forms.Button();
            this.BtnUp = new System.Windows.Forms.Button();
            this.LabSP = new System.Windows.Forms.Label();
            this.LabPV = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.LabName = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.GBDiaCalib.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabSeedTrv
            // 
            this.LabSeedTrv.BackColor = System.Drawing.Color.Black;
            this.LabSeedTrv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabSeedTrv.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabSeedTrv.ForeColor = System.Drawing.Color.White;
            this.LabSeedTrv.Location = new System.Drawing.Point(167, 210);
            this.LabSeedTrv.Name = "LabSeedTrv";
            this.LabSeedTrv.Size = new System.Drawing.Size(100, 50);
            this.LabSeedTrv.TabIndex = 131;
            this.LabSeedTrv.Text = "0.0";
            this.LabSeedTrv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label6.ForeColor = System.Drawing.Color.White;
            this.Label6.Location = new System.Drawing.Point(272, 225);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(80, 20);
            this.Label6.TabIndex = 130;
            this.Label6.Text = "mm";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label7.ForeColor = System.Drawing.Color.White;
            this.Label7.Location = new System.Drawing.Point(42, 225);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(120, 20);
            this.Label7.TabIndex = 129;
            this.Label7.Text = "晶体位置";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GBDiaCalib
            // 
            this.GBDiaCalib.Controls.Add(this.LabSLFastSet);
            this.GBDiaCalib.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GBDiaCalib.ForeColor = System.Drawing.Color.White;
            this.GBDiaCalib.Location = new System.Drawing.Point(10, 120);
            this.GBDiaCalib.Name = "GBDiaCalib";
            this.GBDiaCalib.Size = new System.Drawing.Size(124, 87);
            this.GBDiaCalib.TabIndex = 114;
            this.GBDiaCalib.TabStop = false;
            this.GBDiaCalib.Text = "手动快速设置";
            // 
            // LabSLFastSet
            // 
            this.LabSLFastSet.BackColor = System.Drawing.Color.White;
            this.LabSLFastSet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabSLFastSet.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabSLFastSet.ForeColor = System.Drawing.Color.Black;
            this.LabSLFastSet.Location = new System.Drawing.Point(12, 26);
            this.LabSLFastSet.Name = "LabSLFastSet";
            this.LabSLFastSet.Size = new System.Drawing.Size(100, 50);
            this.LabSLFastSet.TabIndex = 104;
            this.LabSLFastSet.Text = "0.0";
            this.LabSLFastSet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabSLFastSet.Click += new System.EventHandler(this.LabSLFastSet_Click);
            // 
            // BtnBoxCtl
            // 
            this.BtnBoxCtl.BackColor = System.Drawing.Color.Blue;
            this.BtnBoxCtl.FlatAppearance.BorderSize = 0;
            this.BtnBoxCtl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBoxCtl.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnBoxCtl.ForeColor = System.Drawing.Color.White;
            this.BtnBoxCtl.Location = new System.Drawing.Point(10, 356);
            this.BtnBoxCtl.Name = "BtnBoxCtl";
            this.BtnBoxCtl.Size = new System.Drawing.Size(117, 55);
            this.BtnBoxCtl.TabIndex = 110;
            this.BtnBoxCtl.Text = "手柄控制";
            this.BtnBoxCtl.UseVisualStyleBackColor = false;
            this.BtnBoxCtl.Click += new System.EventHandler(this.BtnBoxCtl_Click);
            // 
            // BtnManualNeck
            // 
            this.BtnManualNeck.BackColor = System.Drawing.Color.Blue;
            this.BtnManualNeck.FlatAppearance.BorderSize = 0;
            this.BtnManualNeck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnManualNeck.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnManualNeck.ForeColor = System.Drawing.Color.White;
            this.BtnManualNeck.Location = new System.Drawing.Point(10, 10);
            this.BtnManualNeck.Name = "BtnManualNeck";
            this.BtnManualNeck.Size = new System.Drawing.Size(117, 60);
            this.BtnManualNeck.TabIndex = 112;
            this.BtnManualNeck.Text = "手动引晶器";
            this.BtnManualNeck.UseVisualStyleBackColor = false;
            this.BtnManualNeck.Click += new System.EventHandler(this.BtnManualNeck_Click);
            // 
            // BtnForce
            // 
            this.BtnForce.BackColor = System.Drawing.Color.Blue;
            this.BtnForce.FlatAppearance.BorderSize = 0;
            this.BtnForce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnForce.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnForce.ForeColor = System.Drawing.Color.White;
            this.BtnForce.Location = new System.Drawing.Point(32, 9);
            this.BtnForce.Name = "BtnForce";
            this.BtnForce.Size = new System.Drawing.Size(330, 55);
            this.BtnForce.TabIndex = 109;
            this.BtnForce.Text = "强制升降";
            this.BtnForce.UseVisualStyleBackColor = false;
            this.BtnForce.Click += new System.EventHandler(this.BtnForce_Click);
            // 
            // BtnSlow
            // 
            this.BtnSlow.BackColor = System.Drawing.Color.Blue;
            this.BtnSlow.FlatAppearance.BorderSize = 0;
            this.BtnSlow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSlow.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnSlow.ForeColor = System.Drawing.Color.White;
            this.BtnSlow.Location = new System.Drawing.Point(32, 356);
            this.BtnSlow.Name = "BtnSlow";
            this.BtnSlow.Size = new System.Drawing.Size(330, 55);
            this.BtnSlow.TabIndex = 126;
            this.BtnSlow.Text = "慢速升降";
            this.BtnSlow.UseVisualStyleBackColor = false;
            this.BtnSlow.Click += new System.EventHandler(this.BtnSlow_Click);
            // 
            // BtnFast
            // 
            this.BtnFast.BackColor = System.Drawing.Color.Blue;
            this.BtnFast.FlatAppearance.BorderSize = 0;
            this.BtnFast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFast.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnFast.ForeColor = System.Drawing.Color.White;
            this.BtnFast.Location = new System.Drawing.Point(262, 280);
            this.BtnFast.Name = "BtnFast";
            this.BtnFast.Size = new System.Drawing.Size(100, 55);
            this.BtnFast.TabIndex = 125;
            this.BtnFast.Text = "快速升降";
            this.BtnFast.UseVisualStyleBackColor = false;
            this.BtnFast.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnFast_MouseDown);
            this.BtnFast.MouseLeave += new System.EventHandler(this.BtnFast_MouseLeave);
            this.BtnFast.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnFast_MouseUp);
            // 
            // BtnDown
            // 
            this.BtnDown.BackColor = System.Drawing.Color.Blue;
            this.BtnDown.FlatAppearance.BorderSize = 0;
            this.BtnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDown.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnDown.ForeColor = System.Drawing.Color.White;
            this.BtnDown.Location = new System.Drawing.Point(32, 311);
            this.BtnDown.Name = "BtnDown";
            this.BtnDown.Size = new System.Drawing.Size(100, 35);
            this.BtnDown.TabIndex = 124;
            this.BtnDown.Text = "下降";
            this.BtnDown.UseVisualStyleBackColor = false;
            this.BtnDown.Click += new System.EventHandler(this.BtnDown_Click);
            // 
            // BtnUp
            // 
            this.BtnUp.BackColor = System.Drawing.Color.Blue;
            this.BtnUp.FlatAppearance.BorderSize = 0;
            this.BtnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUp.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnUp.ForeColor = System.Drawing.Color.White;
            this.BtnUp.Location = new System.Drawing.Point(32, 266);
            this.BtnUp.Name = "BtnUp";
            this.BtnUp.Size = new System.Drawing.Size(100, 35);
            this.BtnUp.TabIndex = 123;
            this.BtnUp.Text = "上升";
            this.BtnUp.UseVisualStyleBackColor = false;
            this.BtnUp.Click += new System.EventHandler(this.BtnUp_Click);
            // 
            // LabSP
            // 
            this.LabSP.BackColor = System.Drawing.Color.White;
            this.LabSP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabSP.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabSP.ForeColor = System.Drawing.Color.Black;
            this.LabSP.Location = new System.Drawing.Point(167, 140);
            this.LabSP.Name = "LabSP";
            this.LabSP.Size = new System.Drawing.Size(100, 50);
            this.LabSP.TabIndex = 122;
            this.LabSP.Text = "0.0";
            this.LabSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabSP.Click += new System.EventHandler(this.LabSP_Click);
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
            this.LabPV.TabIndex = 121;
            this.LabPV.Text = "0.0";
            this.LabPV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(272, 85);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(80, 20);
            this.Label5.TabIndex = 120;
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
            this.Label4.TabIndex = 119;
            this.Label4.Text = "mm/hr";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(42, 155);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(120, 20);
            this.Label2.TabIndex = 118;
            this.Label2.Text = "设定速度";
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
            this.Label1.TabIndex = 117;
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
            this.LabName.TabIndex = 116;
            this.LabName.Text = "晶升";
            this.LabName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 500;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.Panel2.Controls.Add(this.GBDiaCalib);
            this.Panel2.Controls.Add(this.BtnBoxCtl);
            this.Panel2.Controls.Add(this.BtnManualNeck);
            this.Panel2.Location = new System.Drawing.Point(394, 0);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(137, 494);
            this.Panel2.TabIndex = 128;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.Panel1.Controls.Add(this.BtnForce);
            this.Panel1.Location = new System.Drawing.Point(0, 421);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(394, 73);
            this.Panel1.TabIndex = 127;
            // 
            // FrmSeedLift
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(531, 494);
            this.Controls.Add(this.LabSeedTrv);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.BtnSlow);
            this.Controls.Add(this.BtnFast);
            this.Controls.Add(this.BtnDown);
            this.Controls.Add(this.BtnUp);
            this.Controls.Add(this.LabSP);
            this.Controls.Add(this.LabPV);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.LabName);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSeedLift";
            this.Text = "FrmSeedLift";
            this.GBDiaCalib.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label LabSeedTrv;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Button BtnBoxCtl;
        internal System.Windows.Forms.Button BtnManualNeck;
        internal System.Windows.Forms.Button BtnForce;
        internal System.Windows.Forms.Button BtnSlow;
        internal System.Windows.Forms.Button BtnFast;
        internal System.Windows.Forms.Button BtnDown;
        internal System.Windows.Forms.Button BtnUp;
        internal System.Windows.Forms.Label LabSP;
        internal System.Windows.Forms.Label LabPV;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label LabName;
        private System.Windows.Forms.Timer Timer1;
        internal System.Windows.Forms.GroupBox GBDiaCalib;
        internal System.Windows.Forms.Label LabSLFastSet;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Panel Panel1;
    }
}