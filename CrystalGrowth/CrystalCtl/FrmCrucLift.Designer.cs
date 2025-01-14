namespace CrystalGrowth.CrystalCtl
{
    partial class FrmCrucLift
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
            this.BtnDown = new System.Windows.Forms.Button();
            this.BtnUp = new System.Windows.Forms.Button();
            this.LabCrucPos = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.BtnMeltGapBlock = new System.Windows.Forms.Button();
            this.BtnBoxCtl = new System.Windows.Forms.Button();
            this.BtnForce = new System.Windows.Forms.Button();
            this.BtnSlow = new System.Windows.Forms.Button();
            this.BtnFastCrucPos = new System.Windows.Forms.Button();
            this.LabSP = new System.Windows.Forms.Label();
            this.LabPV = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.LabName = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Panel2.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 500;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
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
            this.BtnDown.TabIndex = 145;
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
            this.BtnUp.TabIndex = 144;
            this.BtnUp.Text = "上升";
            this.BtnUp.UseVisualStyleBackColor = false;
            this.BtnUp.Click += new System.EventHandler(this.BtnUp_Click);
            // 
            // LabCrucPos
            // 
            this.LabCrucPos.BackColor = System.Drawing.Color.Black;
            this.LabCrucPos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabCrucPos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabCrucPos.ForeColor = System.Drawing.Color.White;
            this.LabCrucPos.Location = new System.Drawing.Point(167, 210);
            this.LabCrucPos.Name = "LabCrucPos";
            this.LabCrucPos.Size = new System.Drawing.Size(100, 50);
            this.LabCrucPos.TabIndex = 143;
            this.LabCrucPos.Text = "0.0";
            this.LabCrucPos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label6.ForeColor = System.Drawing.Color.White;
            this.Label6.Location = new System.Drawing.Point(272, 225);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(80, 20);
            this.Label6.TabIndex = 142;
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
            this.Label7.TabIndex = 141;
            this.Label7.Text = "坩埚位置";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnMeltGapBlock
            // 
            this.BtnMeltGapBlock.BackColor = System.Drawing.Color.Blue;
            this.BtnMeltGapBlock.FlatAppearance.BorderSize = 0;
            this.BtnMeltGapBlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMeltGapBlock.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnMeltGapBlock.ForeColor = System.Drawing.Color.White;
            this.BtnMeltGapBlock.Location = new System.Drawing.Point(8, 85);
            this.BtnMeltGapBlock.Name = "BtnMeltGapBlock";
            this.BtnMeltGapBlock.Size = new System.Drawing.Size(117, 65);
            this.BtnMeltGapBlock.TabIndex = 115;
            this.BtnMeltGapBlock.Text = "视觉液口距保护屏蔽";
            this.BtnMeltGapBlock.UseVisualStyleBackColor = false;
            this.BtnMeltGapBlock.Click += new System.EventHandler(this.BtnMeltGapBlock_Click);
            // 
            // BtnBoxCtl
            // 
            this.BtnBoxCtl.BackColor = System.Drawing.Color.Blue;
            this.BtnBoxCtl.FlatAppearance.BorderSize = 0;
            this.BtnBoxCtl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBoxCtl.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnBoxCtl.ForeColor = System.Drawing.Color.White;
            this.BtnBoxCtl.Location = new System.Drawing.Point(10, 280);
            this.BtnBoxCtl.Name = "BtnBoxCtl";
            this.BtnBoxCtl.Size = new System.Drawing.Size(117, 55);
            this.BtnBoxCtl.TabIndex = 110;
            this.BtnBoxCtl.Text = "按钮控制";
            this.BtnBoxCtl.UseVisualStyleBackColor = false;
            this.BtnBoxCtl.Visible = false;
            this.BtnBoxCtl.Click += new System.EventHandler(this.BtnBoxCtl_Click);
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
            this.BtnForce.TabIndex = 122;
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
            this.BtnSlow.TabIndex = 138;
            this.BtnSlow.Text = "慢速升降";
            this.BtnSlow.UseVisualStyleBackColor = false;
            this.BtnSlow.Click += new System.EventHandler(this.BtnSlow_Click);
            // 
            // BtnFastCrucPos
            // 
            this.BtnFastCrucPos.BackColor = System.Drawing.Color.Blue;
            this.BtnFastCrucPos.FlatAppearance.BorderSize = 0;
            this.BtnFastCrucPos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFastCrucPos.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnFastCrucPos.ForeColor = System.Drawing.Color.White;
            this.BtnFastCrucPos.Location = new System.Drawing.Point(262, 280);
            this.BtnFastCrucPos.Name = "BtnFastCrucPos";
            this.BtnFastCrucPos.Size = new System.Drawing.Size(100, 55);
            this.BtnFastCrucPos.TabIndex = 137;
            this.BtnFastCrucPos.Text = "快速控制";
            this.BtnFastCrucPos.UseVisualStyleBackColor = false;
            this.BtnFastCrucPos.Click += new System.EventHandler(this.BtnFastCrucPos_Click);
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
            this.LabSP.TabIndex = 136;
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
            this.LabPV.TabIndex = 135;
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
            this.Label5.TabIndex = 134;
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
            this.Label4.TabIndex = 133;
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
            this.Label2.TabIndex = 132;
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
            this.Label1.TabIndex = 131;
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
            this.LabName.TabIndex = 130;
            this.LabName.Text = "埚升";
            this.LabName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.Panel2.Controls.Add(this.BtnMeltGapBlock);
            this.Panel2.Controls.Add(this.BtnBoxCtl);
            this.Panel2.Location = new System.Drawing.Point(394, 0);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(137, 494);
            this.Panel2.TabIndex = 140;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.Panel1.Controls.Add(this.BtnForce);
            this.Panel1.Location = new System.Drawing.Point(1, 421);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(394, 73);
            this.Panel1.TabIndex = 139;
            // 
            // FrmCrucLift
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(531, 494);
            this.Controls.Add(this.BtnDown);
            this.Controls.Add(this.BtnUp);
            this.Controls.Add(this.LabCrucPos);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.BtnSlow);
            this.Controls.Add(this.BtnFastCrucPos);
            this.Controls.Add(this.LabSP);
            this.Controls.Add(this.LabPV);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.LabName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCrucLift";
            this.Text = "FrmCrucLift";
            this.MouseHover += new System.EventHandler(this.FrmCrucLift_MouseHover);
            this.Panel2.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button BtnDown;
        internal System.Windows.Forms.Button BtnUp;
        internal System.Windows.Forms.Label LabCrucPos;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Button BtnBoxCtl;
        internal System.Windows.Forms.Button BtnForce;
        internal System.Windows.Forms.Button BtnSlow;
        internal System.Windows.Forms.Button BtnFastCrucPos;
        internal System.Windows.Forms.Label LabSP;
        internal System.Windows.Forms.Label LabPV;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label LabName;
        internal System.Windows.Forms.Button BtnMeltGapBlock;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer Timer1;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Panel Panel1;
    }
}