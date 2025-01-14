namespace CrystalGrowth.AutoSel
{
    partial class FrmAutoID
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
            this.BtnGiveUp = new System.Windows.Forms.Button();
            this.BtnGoOn = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.LabName = new System.Windows.Forms.Label();
            this.LabStaffID = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.LabCrysID = new System.Windows.Forms.Label();
            this.LabRunID = new System.Windows.Forms.Label();
            this.LabFurnID = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.LabInfo = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnGiveUp
            // 
            this.BtnGiveUp.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnGiveUp.FlatAppearance.BorderSize = 0;
            this.BtnGiveUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGiveUp.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnGiveUp.ForeColor = System.Drawing.Color.White;
            this.BtnGiveUp.Location = new System.Drawing.Point(1200, 611);
            this.BtnGiveUp.Name = "BtnGiveUp";
            this.BtnGiveUp.Size = new System.Drawing.Size(117, 60);
            this.BtnGiveUp.TabIndex = 29;
            this.BtnGiveUp.Text = "放弃";
            this.BtnGiveUp.UseVisualStyleBackColor = false;
            this.BtnGiveUp.Click += new System.EventHandler(this.BtnGiveUp_Click);
            // 
            // BtnGoOn
            // 
            this.BtnGoOn.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnGoOn.FlatAppearance.BorderSize = 0;
            this.BtnGoOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGoOn.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnGoOn.ForeColor = System.Drawing.Color.White;
            this.BtnGoOn.Location = new System.Drawing.Point(1045, 611);
            this.BtnGoOn.Name = "BtnGoOn";
            this.BtnGoOn.Size = new System.Drawing.Size(117, 60);
            this.BtnGoOn.TabIndex = 28;
            this.BtnGoOn.Text = "继续";
            this.BtnGoOn.UseVisualStyleBackColor = false;
            this.BtnGoOn.Click += new System.EventHandler(this.BtnGoOn_Click);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.DarkGray;
            this.Panel1.Controls.Add(this.LabName);
            this.Panel1.Controls.Add(this.LabStaffID);
            this.Panel1.Controls.Add(this.Label15);
            this.Panel1.Controls.Add(this.LabCrysID);
            this.Panel1.Controls.Add(this.LabRunID);
            this.Panel1.Controls.Add(this.LabFurnID);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Location = new System.Drawing.Point(0, 140);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(520, 380);
            this.Panel1.TabIndex = 30;
            // 
            // LabName
            // 
            this.LabName.BackColor = System.Drawing.Color.DarkGray;
            this.LabName.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabName.ForeColor = System.Drawing.Color.White;
            this.LabName.Location = new System.Drawing.Point(163, 17);
            this.LabName.Name = "LabName";
            this.LabName.Size = new System.Drawing.Size(166, 31);
            this.LabName.TabIndex = 112;
            this.LabName.Text = "身份认证页";
            this.LabName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabStaffID
            // 
            this.LabStaffID.BackColor = System.Drawing.Color.White;
            this.LabStaffID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabStaffID.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabStaffID.ForeColor = System.Drawing.Color.Black;
            this.LabStaffID.Location = new System.Drawing.Point(220, 290);
            this.LabStaffID.Name = "LabStaffID";
            this.LabStaffID.Size = new System.Drawing.Size(232, 40);
            this.LabStaffID.TabIndex = 63;
            this.LabStaffID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabStaffID.TextChanged += new System.EventHandler(this.LabStaffID_TextChanged);
            this.LabStaffID.Click += new System.EventHandler(this.LabStaffID_Click);
            // 
            // Label15
            // 
            this.Label15.BackColor = System.Drawing.Color.DarkGray;
            this.Label15.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label15.ForeColor = System.Drawing.Color.White;
            this.Label15.Location = new System.Drawing.Point(94, 300);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(120, 20);
            this.Label15.TabIndex = 61;
            this.Label15.Text = "员工编号";
            this.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabCrysID
            // 
            this.LabCrysID.BackColor = System.Drawing.Color.White;
            this.LabCrysID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabCrysID.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabCrysID.ForeColor = System.Drawing.Color.Black;
            this.LabCrysID.Location = new System.Drawing.Point(220, 150);
            this.LabCrysID.Name = "LabCrysID";
            this.LabCrysID.Size = new System.Drawing.Size(232, 40);
            this.LabCrysID.TabIndex = 60;
            this.LabCrysID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabCrysID.TextChanged += new System.EventHandler(this.LabCrysID_TextChanged);
            this.LabCrysID.Click += new System.EventHandler(this.LabCrysID_Click);
            // 
            // LabRunID
            // 
            this.LabRunID.BackColor = System.Drawing.Color.White;
            this.LabRunID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabRunID.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabRunID.ForeColor = System.Drawing.Color.Black;
            this.LabRunID.Location = new System.Drawing.Point(220, 220);
            this.LabRunID.Name = "LabRunID";
            this.LabRunID.Size = new System.Drawing.Size(232, 40);
            this.LabRunID.TabIndex = 59;
            this.LabRunID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabRunID.TextChanged += new System.EventHandler(this.LabRunID_TextChanged);
            this.LabRunID.Click += new System.EventHandler(this.LabRunID_Click);
            // 
            // LabFurnID
            // 
            this.LabFurnID.BackColor = System.Drawing.Color.Black;
            this.LabFurnID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabFurnID.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabFurnID.ForeColor = System.Drawing.Color.White;
            this.LabFurnID.Location = new System.Drawing.Point(220, 80);
            this.LabFurnID.Name = "LabFurnID";
            this.LabFurnID.Size = new System.Drawing.Size(232, 40);
            this.LabFurnID.TabIndex = 58;
            this.LabFurnID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.DarkGray;
            this.Label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(94, 230);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(120, 20);
            this.Label3.TabIndex = 54;
            this.Label3.Text = "运行炉数编号";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.DarkGray;
            this.Label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(94, 160);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(120, 20);
            this.Label2.TabIndex = 53;
            this.Label2.Text = "晶体编号";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.DarkGray;
            this.Label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(94, 90);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(120, 20);
            this.Label1.TabIndex = 52;
            this.Label1.Text = "炉号";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabInfo
            // 
            this.LabInfo.Font = new System.Drawing.Font("宋体", 24F);
            this.LabInfo.ForeColor = System.Drawing.Color.Red;
            this.LabInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabInfo.Location = new System.Drawing.Point(545, 487);
            this.LabInfo.Name = "LabInfo";
            this.LabInfo.Size = new System.Drawing.Size(464, 33);
            this.LabInfo.TabIndex = 33;
            this.LabInfo.Text = "info";
            this.LabInfo.Visible = false;
            // 
            // FrmAutoID
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(1366, 708);
            this.Controls.Add(this.LabInfo);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.BtnGiveUp);
            this.Controls.Add(this.BtnGoOn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAutoID";
            this.Text = "FrmAutoID";
            this.Load += new System.EventHandler(this.FrmAutoID_Load);
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button BtnGiveUp;
        internal System.Windows.Forms.Button BtnGoOn;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label LabName;
        internal System.Windows.Forms.Label LabStaffID;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Label LabCrysID;
        internal System.Windows.Forms.Label LabRunID;
        internal System.Windows.Forms.Label LabFurnID;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label LabInfo;
    }
}