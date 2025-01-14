namespace CrystalGrowth.AuxFunction.MainTain
{
    partial class FrmMaintainLock
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
            this.Label10 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.TextBoxPwd = new System.Windows.Forms.TextBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label10
            // 
            this.Label10.BackColor = System.Drawing.Color.DarkGray;
            this.Label10.Font = new System.Drawing.Font("Arial", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(299, 84);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(780, 129);
            this.Label10.TabIndex = 57;
            this.Label10.Text = "设备维修锁屏中......";
            this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.DarkGray;
            this.Label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(1126, 525);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(127, 30);
            this.Label1.TabIndex = 127;
            this.Label1.Text = "输入密码：";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxPwd
            // 
            this.TextBoxPwd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBoxPwd.Location = new System.Drawing.Point(1126, 563);
            this.TextBoxPwd.Multiline = true;
            this.TextBoxPwd.Name = "TextBoxPwd";
            this.TextBoxPwd.PasswordChar = '*';
            this.TextBoxPwd.Size = new System.Drawing.Size(127, 30);
            this.TextBoxPwd.TabIndex = 126;
            this.TextBoxPwd.Click += new System.EventHandler(this.TextBoxPwd_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Blue;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Location = new System.Drawing.Point(1126, 617);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(127, 55);
            this.BtnClose.TabIndex = 125;
            this.BtnClose.Text = "退  出";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FrmMaintainLock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.TextBoxPwd);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.Label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMaintainLock";
            this.Text = "FrmMaintainLock";
            this.Load += new System.EventHandler(this.FrmMaintainLock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox TextBoxPwd;
        internal System.Windows.Forms.Button BtnClose;
    }
}