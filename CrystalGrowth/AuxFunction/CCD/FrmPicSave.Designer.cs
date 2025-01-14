namespace CrystalGrowth.AuxFunction.CCD
{
    partial class FrmPicSave
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
            this.BtnSTrigger = new System.Windows.Forms.Button();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.BtnCTrigger = new System.Windows.Forms.Button();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.LabInfo = new System.Windows.Forms.Label();
            this.BtnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSTrigger
            // 
            this.BtnSTrigger.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnSTrigger.FlatAppearance.BorderSize = 0;
            this.BtnSTrigger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSTrigger.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnSTrigger.ForeColor = System.Drawing.Color.White;
            this.BtnSTrigger.Location = new System.Drawing.Point(12, 99);
            this.BtnSTrigger.Name = "BtnSTrigger";
            this.BtnSTrigger.Size = new System.Drawing.Size(117, 60);
            this.BtnSTrigger.TabIndex = 180;
            this.BtnSTrigger.Text = "单次触发";
            this.BtnSTrigger.UseVisualStyleBackColor = false;
            this.BtnSTrigger.Click += new System.EventHandler(this.BtnSTrigger_Click);
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
            this.BtnQuit.TabIndex = 179;
            this.BtnQuit.Text = "返回";
            this.BtnQuit.UseVisualStyleBackColor = false;
            this.BtnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // BtnCTrigger
            // 
            this.BtnCTrigger.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnCTrigger.FlatAppearance.BorderSize = 0;
            this.BtnCTrigger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCTrigger.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCTrigger.ForeColor = System.Drawing.Color.White;
            this.BtnCTrigger.Location = new System.Drawing.Point(251, 99);
            this.BtnCTrigger.Name = "BtnCTrigger";
            this.BtnCTrigger.Size = new System.Drawing.Size(117, 60);
            this.BtnCTrigger.TabIndex = 181;
            this.BtnCTrigger.Text = "连续触发";
            this.BtnCTrigger.UseVisualStyleBackColor = false;
            this.BtnCTrigger.Click += new System.EventHandler(this.BtnCTrigger_Click);
            // 
            // CheckBox1
            // 
            this.CheckBox1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBox1.Location = new System.Drawing.Point(12, 31);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(144, 38);
            this.CheckBox1.TabIndex = 182;
            this.CheckBox1.Text = "主相机";
            this.CheckBox1.UseVisualStyleBackColor = true;
            this.CheckBox1.Click += new System.EventHandler(this.CheckBox1_Click);
            // 
            // LabInfo
            // 
            this.LabInfo.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabInfo.ForeColor = System.Drawing.Color.Red;
            this.LabInfo.Location = new System.Drawing.Point(12, 485);
            this.LabInfo.Name = "LabInfo";
            this.LabInfo.Size = new System.Drawing.Size(356, 80);
            this.LabInfo.TabIndex = 183;
            this.LabInfo.Text = "特别提示：\r\n连续触发，仅限测试抓取连续图片，禁止生产一直开启！\r\n";
            this.LabInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabInfo.Visible = false;
            // 
            // BtnStart
            // 
            this.BtnStart.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnStart.FlatAppearance.BorderSize = 0;
            this.BtnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStart.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnStart.ForeColor = System.Drawing.Color.White;
            this.BtnStart.Location = new System.Drawing.Point(12, 568);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(117, 60);
            this.BtnStart.TabIndex = 200;
            this.BtnStart.Text = "启动";
            this.BtnStart.UseVisualStyleBackColor = false;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // FrmPicSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(380, 638);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.LabInfo);
            this.Controls.Add(this.CheckBox1);
            this.Controls.Add(this.BtnCTrigger);
            this.Controls.Add(this.BtnSTrigger);
            this.Controls.Add(this.BtnQuit);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPicSave";
            this.Text = "FrmCam2Adjust";
            this.Load += new System.EventHandler(this.FrmPicSave_Load);
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Button BtnSTrigger;
        internal System.Windows.Forms.Button BtnQuit;
        internal System.Windows.Forms.Button BtnCTrigger;
        private System.Windows.Forms.CheckBox CheckBox1;
        private System.Windows.Forms.Label LabInfo;
        internal System.Windows.Forms.Button BtnStart;
    }
}