namespace CrystalGrowth.AuxFunction.CCD
{
    partial class FrmCam2Adjust
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCam2Adjust));
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.Panel1 = new System.Windows.Forms.Panel();
            this.BtnCenterYDown = new System.Windows.Forms.Button();
            this.BtnCenterYUp = new System.Windows.Forms.Button();
            this.BtnCenterXL = new System.Windows.Forms.Button();
            this.BtnCenterXR = new System.Windows.Forms.Button();
            this.LabName = new System.Windows.Forms.Label();
            this.LabCenterY = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.LabCenterX = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Label3 = new System.Windows.Forms.Label();
            this.LabExposure = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnSave.FlatAppearance.BorderSize = 0;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Location = new System.Drawing.Point(251, 496);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(117, 60);
            this.BtnSave.TabIndex = 180;
            this.BtnSave.Text = "保存";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
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
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 250;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.DarkGray;
            this.Panel1.Controls.Add(this.BtnCenterYDown);
            this.Panel1.Controls.Add(this.BtnCenterYUp);
            this.Panel1.Controls.Add(this.BtnCenterXL);
            this.Panel1.Controls.Add(this.BtnCenterXR);
            this.Panel1.Controls.Add(this.LabName);
            this.Panel1.Controls.Add(this.LabCenterY);
            this.Panel1.Controls.Add(this.Label5);
            this.Panel1.Controls.Add(this.LabCenterX);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Location = new System.Drawing.Point(12, 12);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(355, 163);
            this.Panel1.TabIndex = 181;
            // 
            // BtnCenterYDown
            // 
            this.BtnCenterYDown.BackColor = System.Drawing.Color.White;
            this.BtnCenterYDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCenterYDown.BackgroundImage")));
            this.BtnCenterYDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCenterYDown.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnCenterYDown.FlatAppearance.BorderSize = 0;
            this.BtnCenterYDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCenterYDown.Location = new System.Drawing.Point(149, 107);
            this.BtnCenterYDown.Name = "BtnCenterYDown";
            this.BtnCenterYDown.Size = new System.Drawing.Size(40, 40);
            this.BtnCenterYDown.TabIndex = 192;
            this.BtnCenterYDown.UseVisualStyleBackColor = false;
            this.BtnCenterYDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnCenterYDown_MouseDown);
            this.BtnCenterYDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnCenterYDown_MouseUp);
            // 
            // BtnCenterYUp
            // 
            this.BtnCenterYUp.BackColor = System.Drawing.Color.White;
            this.BtnCenterYUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCenterYUp.BackgroundImage")));
            this.BtnCenterYUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCenterYUp.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnCenterYUp.FlatAppearance.BorderSize = 0;
            this.BtnCenterYUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCenterYUp.Location = new System.Drawing.Point(298, 107);
            this.BtnCenterYUp.Name = "BtnCenterYUp";
            this.BtnCenterYUp.Size = new System.Drawing.Size(40, 40);
            this.BtnCenterYUp.TabIndex = 191;
            this.BtnCenterYUp.UseVisualStyleBackColor = false;
            this.BtnCenterYUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnCenterYUp_MouseDown);
            this.BtnCenterYUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnCenterYUp_MouseUp);
            // 
            // BtnCenterXL
            // 
            this.BtnCenterXL.BackColor = System.Drawing.Color.White;
            this.BtnCenterXL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCenterXL.BackgroundImage")));
            this.BtnCenterXL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCenterXL.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnCenterXL.FlatAppearance.BorderSize = 0;
            this.BtnCenterXL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCenterXL.Location = new System.Drawing.Point(149, 51);
            this.BtnCenterXL.Name = "BtnCenterXL";
            this.BtnCenterXL.Size = new System.Drawing.Size(40, 40);
            this.BtnCenterXL.TabIndex = 190;
            this.BtnCenterXL.UseVisualStyleBackColor = false;
            this.BtnCenterXL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnCenterXL_MouseDown);
            this.BtnCenterXL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnCenterXL_MouseUp);
            // 
            // BtnCenterXR
            // 
            this.BtnCenterXR.BackColor = System.Drawing.Color.White;
            this.BtnCenterXR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCenterXR.BackgroundImage")));
            this.BtnCenterXR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCenterXR.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnCenterXR.FlatAppearance.BorderSize = 0;
            this.BtnCenterXR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCenterXR.Location = new System.Drawing.Point(298, 51);
            this.BtnCenterXR.Name = "BtnCenterXR";
            this.BtnCenterXR.Size = new System.Drawing.Size(40, 40);
            this.BtnCenterXR.TabIndex = 189;
            this.BtnCenterXR.UseVisualStyleBackColor = false;
            this.BtnCenterXR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnCenterXR_MouseDown);
            this.BtnCenterXR.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnCenterXR_MouseUp);
            // 
            // LabName
            // 
            this.LabName.BackColor = System.Drawing.Color.Transparent;
            this.LabName.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabName.ForeColor = System.Drawing.Color.Black;
            this.LabName.Location = new System.Drawing.Point(81, 3);
            this.LabName.Name = "LabName";
            this.LabName.Size = new System.Drawing.Size(198, 40);
            this.LabName.TabIndex = 173;
            this.LabName.Text = "相机2中心点";
            this.LabName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabCenterY
            // 
            this.LabCenterY.BackColor = System.Drawing.Color.White;
            this.LabCenterY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabCenterY.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabCenterY.ForeColor = System.Drawing.Color.Black;
            this.LabCenterY.Location = new System.Drawing.Point(195, 107);
            this.LabCenterY.Name = "LabCenterY";
            this.LabCenterY.Size = new System.Drawing.Size(97, 40);
            this.LabCenterY.TabIndex = 168;
            this.LabCenterY.Text = "0";
            this.LabCenterY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabCenterY.Click += new System.EventHandler(this.LabCenterY_Click);
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(13, 107);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(123, 40);
            this.Label5.TabIndex = 167;
            this.Label5.Text = "中心点Y:";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabCenterX
            // 
            this.LabCenterX.BackColor = System.Drawing.Color.White;
            this.LabCenterX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabCenterX.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabCenterX.ForeColor = System.Drawing.Color.Black;
            this.LabCenterX.Location = new System.Drawing.Point(195, 51);
            this.LabCenterX.Name = "LabCenterX";
            this.LabCenterX.Size = new System.Drawing.Size(97, 40);
            this.LabCenterX.TabIndex = 166;
            this.LabCenterX.Text = "0";
            this.LabCenterX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabCenterX.Click += new System.EventHandler(this.LabCenterX_Click);
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(13, 51);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(123, 40);
            this.Label2.TabIndex = 165;
            this.Label2.Text = "中心点X:";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.Label3);
            this.panel2.Controls.Add(this.LabExposure);
            this.panel2.Location = new System.Drawing.Point(14, 181);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(354, 65);
            this.panel2.TabIndex = 185;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(13, 14);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(123, 40);
            this.Label3.TabIndex = 163;
            this.Label3.Text = "曝光时间:";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabExposure
            // 
            this.LabExposure.BackColor = System.Drawing.Color.White;
            this.LabExposure.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabExposure.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabExposure.ForeColor = System.Drawing.Color.Black;
            this.LabExposure.Location = new System.Drawing.Point(196, 14);
            this.LabExposure.Name = "LabExposure";
            this.LabExposure.Size = new System.Drawing.Size(97, 40);
            this.LabExposure.TabIndex = 164;
            this.LabExposure.Text = "0";
            this.LabExposure.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabExposure.Click += new System.EventHandler(this.LabExposure_Click);
            // 
            // FrmCam2Adjust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(380, 638);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnQuit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCam2Adjust";
            this.Text = "FrmCam2Adjust";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCam2Adjust_FormClosed);
            this.Load += new System.EventHandler(this.FrmCam2Adjust_Load);
            this.Panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Button BtnSave;
        internal System.Windows.Forms.Button BtnQuit;
        private System.Windows.Forms.Timer Timer1;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Button BtnCenterYDown;
        internal System.Windows.Forms.Button BtnCenterYUp;
        internal System.Windows.Forms.Button BtnCenterXL;
        internal System.Windows.Forms.Button BtnCenterXR;
        internal System.Windows.Forms.Label LabName;
        internal System.Windows.Forms.Label LabCenterY;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label LabCenterX;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label LabExposure;
    }
}