namespace CrystalGrowth.AuxFunction.License
{
    partial class FrmLicense
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
            this.LabLicenseMsg = new System.Windows.Forms.Label();
            this.LabReqMsg = new System.Windows.Forms.Label();
            this.BtnLicense = new System.Windows.Forms.Button();
            this.BtnRequestFile = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.LabExpiration = new System.Windows.Forms.Label();
            this.LabProjectNum = new System.Windows.Forms.Label();
            this.LabLicenseState = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.LabName = new System.Windows.Forms.Label();
            this.LabRegDelay = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 500;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // LabLicenseMsg
            // 
            this.LabLicenseMsg.BackColor = System.Drawing.Color.Transparent;
            this.LabLicenseMsg.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabLicenseMsg.ForeColor = System.Drawing.Color.Red;
            this.LabLicenseMsg.Location = new System.Drawing.Point(396, 346);
            this.LabLicenseMsg.Name = "LabLicenseMsg";
            this.LabLicenseMsg.Size = new System.Drawing.Size(300, 23);
            this.LabLicenseMsg.TabIndex = 49;
            this.LabLicenseMsg.Text = "XXXXXXXX";
            this.LabLicenseMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabReqMsg
            // 
            this.LabReqMsg.BackColor = System.Drawing.Color.Transparent;
            this.LabReqMsg.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabReqMsg.ForeColor = System.Drawing.Color.Red;
            this.LabReqMsg.Location = new System.Drawing.Point(8, 346);
            this.LabReqMsg.Name = "LabReqMsg";
            this.LabReqMsg.Size = new System.Drawing.Size(300, 23);
            this.LabReqMsg.TabIndex = 48;
            this.LabReqMsg.Text = "XXXXXXXX";
            this.LabReqMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnLicense
            // 
            this.BtnLicense.BackColor = System.Drawing.Color.Blue;
            this.BtnLicense.FlatAppearance.BorderSize = 0;
            this.BtnLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLicense.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLicense.ForeColor = System.Drawing.Color.White;
            this.BtnLicense.Location = new System.Drawing.Point(400, 278);
            this.BtnLicense.Name = "BtnLicense";
            this.BtnLicense.Size = new System.Drawing.Size(150, 60);
            this.BtnLicense.TabIndex = 47;
            this.BtnLicense.Text = "载入授权";
            this.BtnLicense.UseVisualStyleBackColor = false;
            this.BtnLicense.Click += new System.EventHandler(this.BtnLicense_Click);
            // 
            // BtnRequestFile
            // 
            this.BtnRequestFile.BackColor = System.Drawing.Color.Blue;
            this.BtnRequestFile.FlatAppearance.BorderSize = 0;
            this.BtnRequestFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRequestFile.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRequestFile.ForeColor = System.Drawing.Color.White;
            this.BtnRequestFile.Location = new System.Drawing.Point(12, 278);
            this.BtnRequestFile.Name = "BtnRequestFile";
            this.BtnRequestFile.Size = new System.Drawing.Size(150, 60);
            this.BtnRequestFile.TabIndex = 46;
            this.BtnRequestFile.Text = "创建请求文件";
            this.BtnRequestFile.UseVisualStyleBackColor = false;
            this.BtnRequestFile.Click += new System.EventHandler(this.BtnRequestFile_Click);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.DarkGray;
            this.Panel1.Controls.Add(this.LabRegDelay);
            this.Panel1.Controls.Add(this.label4);
            this.Panel1.Controls.Add(this.LabExpiration);
            this.Panel1.Controls.Add(this.LabProjectNum);
            this.Panel1.Controls.Add(this.LabLicenseState);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Location = new System.Drawing.Point(12, 77);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(538, 195);
            this.Panel1.TabIndex = 45;
            // 
            // LabExpiration
            // 
            this.LabExpiration.BackColor = System.Drawing.Color.Transparent;
            this.LabExpiration.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabExpiration.ForeColor = System.Drawing.Color.Black;
            this.LabExpiration.Location = new System.Drawing.Point(236, 104);
            this.LabExpiration.Name = "LabExpiration";
            this.LabExpiration.Size = new System.Drawing.Size(172, 23);
            this.LabExpiration.TabIndex = 41;
            this.LabExpiration.Text = "XXXXXXXX";
            this.LabExpiration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabProjectNum
            // 
            this.LabProjectNum.BackColor = System.Drawing.Color.Transparent;
            this.LabProjectNum.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabProjectNum.ForeColor = System.Drawing.Color.Black;
            this.LabProjectNum.Location = new System.Drawing.Point(236, 60);
            this.LabProjectNum.Name = "LabProjectNum";
            this.LabProjectNum.Size = new System.Drawing.Size(172, 23);
            this.LabProjectNum.TabIndex = 40;
            this.LabProjectNum.Text = "XXXXXXXX";
            this.LabProjectNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabLicenseState
            // 
            this.LabLicenseState.BackColor = System.Drawing.Color.Transparent;
            this.LabLicenseState.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabLicenseState.ForeColor = System.Drawing.Color.Black;
            this.LabLicenseState.Location = new System.Drawing.Point(236, 16);
            this.LabLicenseState.Name = "LabLicenseState";
            this.LabLicenseState.Size = new System.Drawing.Size(172, 23);
            this.LabLicenseState.TabIndex = 39;
            this.LabLicenseState.Text = "XXXXXXXX";
            this.LabLicenseState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label3.ForeColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(90, 104);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(140, 23);
            this.Label3.TabIndex = 37;
            this.Label3.Text = "到期日期:";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(90, 60);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(140, 23);
            this.Label2.TabIndex = 36;
            this.Label2.Text = "项目编号:";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(86, 16);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(144, 23);
            this.Label1.TabIndex = 35;
            this.Label1.Text = "授权状态:";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabName
            // 
            this.LabName.BackColor = System.Drawing.Color.Transparent;
            this.LabName.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabName.ForeColor = System.Drawing.Color.White;
            this.LabName.Location = new System.Drawing.Point(12, 40);
            this.LabName.Name = "LabName";
            this.LabName.Size = new System.Drawing.Size(93, 23);
            this.LabName.TabIndex = 44;
            this.LabName.Text = "授权管理";
            this.LabName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabRegDelay
            // 
            this.LabRegDelay.BackColor = System.Drawing.Color.Transparent;
            this.LabRegDelay.Font = new System.Drawing.Font("宋体", 15F);
            this.LabRegDelay.ForeColor = System.Drawing.Color.Black;
            this.LabRegDelay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabRegDelay.Location = new System.Drawing.Point(236, 148);
            this.LabRegDelay.Name = "LabRegDelay";
            this.LabRegDelay.Size = new System.Drawing.Size(172, 23);
            this.LabRegDelay.TabIndex = 45;
            this.LabRegDelay.Text = "XXXXXXXX";
            this.LabRegDelay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 15F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(90, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 23);
            this.label4.TabIndex = 44;
            this.label4.Text = "授权倒计时:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmLicense
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(1024, 638);
            this.Controls.Add(this.BtnLicense);
            this.Controls.Add(this.LabLicenseMsg);
            this.Controls.Add(this.LabReqMsg);
            this.Controls.Add(this.BtnRequestFile);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.LabName);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLicense";
            this.Text = "FrmLicense";
            this.Load += new System.EventHandler(this.FrmLicense_Load);
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Timer1;
        internal System.Windows.Forms.Label LabLicenseMsg;
        internal System.Windows.Forms.Label LabReqMsg;
        internal System.Windows.Forms.Button BtnLicense;
        internal System.Windows.Forms.Button BtnRequestFile;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label LabExpiration;
        internal System.Windows.Forms.Label LabProjectNum;
        internal System.Windows.Forms.Label LabLicenseState;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label LabName;
        internal System.Windows.Forms.Label LabRegDelay;
        internal System.Windows.Forms.Label label4;
    }
}