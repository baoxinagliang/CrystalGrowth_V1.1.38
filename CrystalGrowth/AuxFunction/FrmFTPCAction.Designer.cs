namespace CrystalGrowth.AuxFunction
{
    partial class FrmFTPCAction
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
            this.LabPCFTStatus = new System.Windows.Forms.Label();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.BtnPCDown = new System.Windows.Forms.Button();
            this.BtnPCLift = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.BtnFTDown = new System.Windows.Forms.Button();
            this.BtnFTLift = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.BtnFTRight = new System.Windows.Forms.Button();
            this.BtnFTLeft = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.BtnPCRight = new System.Windows.Forms.Button();
            this.BtnPCLeft = new System.Windows.Forms.Button();
            this.LabName = new System.Windows.Forms.Label();
            this.BtnFTPCForce = new System.Windows.Forms.Button();
            this.Panel4.SuspendLayout();
            this.Panel3.SuspendLayout();
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
            // LabPCFTStatus
            // 
            this.LabPCFTStatus.BackColor = System.Drawing.Color.Transparent;
            this.LabPCFTStatus.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabPCFTStatus.ForeColor = System.Drawing.Color.White;
            this.LabPCFTStatus.Location = new System.Drawing.Point(498, 17);
            this.LabPCFTStatus.Name = "LabPCFTStatus";
            this.LabPCFTStatus.Size = new System.Drawing.Size(413, 65);
            this.LabPCFTStatus.TabIndex = 43;
            this.LabPCFTStatus.Text = "主副室升降旋转限位状态";
            this.LabPCFTStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabPCFTStatus.Visible = false;
            // 
            // Panel4
            // 
            this.Panel4.BackColor = System.Drawing.Color.DarkGray;
            this.Panel4.Controls.Add(this.BtnPCDown);
            this.Panel4.Controls.Add(this.BtnPCLift);
            this.Panel4.Controls.Add(this.Label3);
            this.Panel4.Location = new System.Drawing.Point(799, 124);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(490, 215);
            this.Panel4.TabIndex = 42;
            // 
            // BtnPCDown
            // 
            this.BtnPCDown.BackColor = System.Drawing.Color.Blue;
            this.BtnPCDown.FlatAppearance.BorderSize = 0;
            this.BtnPCDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPCDown.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnPCDown.ForeColor = System.Drawing.Color.White;
            this.BtnPCDown.Location = new System.Drawing.Point(291, 70);
            this.BtnPCDown.Name = "BtnPCDown";
            this.BtnPCDown.Size = new System.Drawing.Size(150, 109);
            this.BtnPCDown.TabIndex = 34;
            this.BtnPCDown.Text = "下降";
            this.BtnPCDown.UseVisualStyleBackColor = false;
            this.BtnPCDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnPCDown_MouseDown);
            this.BtnPCDown.MouseLeave += new System.EventHandler(this.BtnPCDown_MouseLeave);
            this.BtnPCDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnPCDown_MouseUp);
            // 
            // BtnPCLift
            // 
            this.BtnPCLift.BackColor = System.Drawing.Color.Blue;
            this.BtnPCLift.FlatAppearance.BorderSize = 0;
            this.BtnPCLift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPCLift.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnPCLift.ForeColor = System.Drawing.Color.White;
            this.BtnPCLift.Location = new System.Drawing.Point(49, 70);
            this.BtnPCLift.Name = "BtnPCLift";
            this.BtnPCLift.Size = new System.Drawing.Size(150, 109);
            this.BtnPCLift.TabIndex = 34;
            this.BtnPCLift.Text = "上升";
            this.BtnPCLift.UseVisualStyleBackColor = false;
            this.BtnPCLift.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnPCLift_MouseDown);
            this.BtnPCLift.MouseLeave += new System.EventHandler(this.BtnPCLift_MouseLeave);
            this.BtnPCLift.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnPCLift_MouseUp);
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(175, 22);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(164, 41);
            this.Label3.TabIndex = 33;
            this.Label3.Text = "副室升降";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.DarkGray;
            this.Panel3.Controls.Add(this.BtnFTDown);
            this.Panel3.Controls.Add(this.BtnFTLift);
            this.Panel3.Controls.Add(this.Label2);
            this.Panel3.Location = new System.Drawing.Point(59, 124);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(490, 215);
            this.Panel3.TabIndex = 41;
            // 
            // BtnFTDown
            // 
            this.BtnFTDown.BackColor = System.Drawing.Color.Blue;
            this.BtnFTDown.FlatAppearance.BorderSize = 0;
            this.BtnFTDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFTDown.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnFTDown.ForeColor = System.Drawing.Color.White;
            this.BtnFTDown.Location = new System.Drawing.Point(291, 78);
            this.BtnFTDown.Name = "BtnFTDown";
            this.BtnFTDown.Size = new System.Drawing.Size(150, 109);
            this.BtnFTDown.TabIndex = 34;
            this.BtnFTDown.Text = "下降";
            this.BtnFTDown.UseVisualStyleBackColor = false;
            this.BtnFTDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnFTDown_MouseDown);
            this.BtnFTDown.MouseLeave += new System.EventHandler(this.BtnFTDown_MouseLeave);
            this.BtnFTDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnFTDown_MouseUp);
            // 
            // BtnFTLift
            // 
            this.BtnFTLift.BackColor = System.Drawing.Color.Blue;
            this.BtnFTLift.FlatAppearance.BorderSize = 0;
            this.BtnFTLift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFTLift.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnFTLift.ForeColor = System.Drawing.Color.White;
            this.BtnFTLift.Location = new System.Drawing.Point(49, 78);
            this.BtnFTLift.Name = "BtnFTLift";
            this.BtnFTLift.Size = new System.Drawing.Size(150, 109);
            this.BtnFTLift.TabIndex = 34;
            this.BtnFTLift.Text = "上升";
            this.BtnFTLift.UseVisualStyleBackColor = false;
            this.BtnFTLift.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnFTLift_MouseDown);
            this.BtnFTLift.MouseLeave += new System.EventHandler(this.BtnFTLift_MouseLeave);
            this.BtnFTLift.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnFTLift_MouseUp);
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(169, 10);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(168, 65);
            this.Label2.TabIndex = 33;
            this.Label2.Text = "主室升降";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Panel2.Controls.Add(this.BtnFTRight);
            this.Panel2.Controls.Add(this.BtnFTLeft);
            this.Panel2.Controls.Add(this.Label1);
            this.Panel2.Location = new System.Drawing.Point(59, 389);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(490, 215);
            this.Panel2.TabIndex = 40;
            // 
            // BtnFTRight
            // 
            this.BtnFTRight.BackColor = System.Drawing.Color.Blue;
            this.BtnFTRight.FlatAppearance.BorderSize = 0;
            this.BtnFTRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFTRight.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnFTRight.ForeColor = System.Drawing.Color.White;
            this.BtnFTRight.Location = new System.Drawing.Point(291, 78);
            this.BtnFTRight.Name = "BtnFTRight";
            this.BtnFTRight.Size = new System.Drawing.Size(150, 109);
            this.BtnFTRight.TabIndex = 34;
            this.BtnFTRight.Text = "右旋";
            this.BtnFTRight.UseVisualStyleBackColor = false;
            this.BtnFTRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnFTRight_MouseDown);
            this.BtnFTRight.MouseLeave += new System.EventHandler(this.BtnFTRight_MouseLeave);
            this.BtnFTRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnFTRight_MouseUp);
            // 
            // BtnFTLeft
            // 
            this.BtnFTLeft.BackColor = System.Drawing.Color.Blue;
            this.BtnFTLeft.FlatAppearance.BorderSize = 0;
            this.BtnFTLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFTLeft.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnFTLeft.ForeColor = System.Drawing.Color.White;
            this.BtnFTLeft.Location = new System.Drawing.Point(49, 78);
            this.BtnFTLeft.Name = "BtnFTLeft";
            this.BtnFTLeft.Size = new System.Drawing.Size(150, 109);
            this.BtnFTLeft.TabIndex = 34;
            this.BtnFTLeft.Text = "左旋";
            this.BtnFTLeft.UseVisualStyleBackColor = false;
            this.BtnFTLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnFTLeft_MouseDown);
            this.BtnFTLeft.MouseLeave += new System.EventHandler(this.BtnFTLeft_MouseLeave);
            this.BtnFTLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnFTLeft_MouseUp);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(169, 22);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(161, 42);
            this.Label1.TabIndex = 33;
            this.Label1.Text = "主室旋转";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Panel1.Controls.Add(this.BtnPCRight);
            this.Panel1.Controls.Add(this.BtnPCLeft);
            this.Panel1.Controls.Add(this.LabName);
            this.Panel1.Location = new System.Drawing.Point(799, 389);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(490, 215);
            this.Panel1.TabIndex = 39;
            // 
            // BtnPCRight
            // 
            this.BtnPCRight.BackColor = System.Drawing.Color.Blue;
            this.BtnPCRight.FlatAppearance.BorderSize = 0;
            this.BtnPCRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPCRight.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnPCRight.ForeColor = System.Drawing.Color.White;
            this.BtnPCRight.Location = new System.Drawing.Point(291, 70);
            this.BtnPCRight.Name = "BtnPCRight";
            this.BtnPCRight.Size = new System.Drawing.Size(150, 109);
            this.BtnPCRight.TabIndex = 34;
            this.BtnPCRight.Text = "右旋";
            this.BtnPCRight.UseVisualStyleBackColor = false;
            this.BtnPCRight.Click += new System.EventHandler(this.BtnPCRight_Click);
            this.BtnPCRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnPCRight_MouseDown);
            this.BtnPCRight.MouseLeave += new System.EventHandler(this.BtnPCRight_MouseLeave);
            this.BtnPCRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnPCRight_MouseUp);
            // 
            // BtnPCLeft
            // 
            this.BtnPCLeft.BackColor = System.Drawing.Color.Blue;
            this.BtnPCLeft.FlatAppearance.BorderSize = 0;
            this.BtnPCLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPCLeft.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnPCLeft.ForeColor = System.Drawing.Color.White;
            this.BtnPCLeft.Location = new System.Drawing.Point(49, 70);
            this.BtnPCLeft.Name = "BtnPCLeft";
            this.BtnPCLeft.Size = new System.Drawing.Size(150, 109);
            this.BtnPCLeft.TabIndex = 34;
            this.BtnPCLeft.Text = "左旋";
            this.BtnPCLeft.UseVisualStyleBackColor = false;
            this.BtnPCLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnPCLeft_MouseDown);
            this.BtnPCLeft.MouseLeave += new System.EventHandler(this.BtnPCLeft_MouseLeave);
            this.BtnPCLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnPCLeft_MouseUp);
            // 
            // LabName
            // 
            this.LabName.BackColor = System.Drawing.Color.Transparent;
            this.LabName.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabName.ForeColor = System.Drawing.Color.White;
            this.LabName.Location = new System.Drawing.Point(177, 22);
            this.LabName.Name = "LabName";
            this.LabName.Size = new System.Drawing.Size(162, 42);
            this.LabName.TabIndex = 33;
            this.LabName.Text = "副室旋转";
            this.LabName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnFTPCForce
            // 
            this.BtnFTPCForce.BackColor = System.Drawing.Color.Blue;
            this.BtnFTPCForce.FlatAppearance.BorderSize = 0;
            this.BtnFTPCForce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFTPCForce.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnFTPCForce.ForeColor = System.Drawing.Color.White;
            this.BtnFTPCForce.Location = new System.Drawing.Point(600, 320);
            this.BtnFTPCForce.Name = "BtnFTPCForce";
            this.BtnFTPCForce.Size = new System.Drawing.Size(150, 91);
            this.BtnFTPCForce.TabIndex = 44;
            this.BtnFTPCForce.Text = "主副室 动作强制";
            this.BtnFTPCForce.UseVisualStyleBackColor = false;
            this.BtnFTPCForce.Visible = false;
            this.BtnFTPCForce.Click += new System.EventHandler(this.BtnFTPCForce_Click);
            this.BtnFTPCForce.MouseLeave += new System.EventHandler(this.BtnFTPCForce_MouseLeave);
            // 
            // FrmFTPCAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.BtnFTPCForce);
            this.Controls.Add(this.LabPCFTStatus);
            this.Controls.Add(this.Panel4);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFTPCAction";
            this.Text = "FrmFTPCAction";
            this.Load += new System.EventHandler(this.FrmFTPCAction_Load);
            this.Panel4.ResumeLayout(false);
            this.Panel3.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Timer1;
        internal System.Windows.Forms.Label LabPCFTStatus;
        internal System.Windows.Forms.Panel Panel4;
        internal System.Windows.Forms.Button BtnPCDown;
        internal System.Windows.Forms.Button BtnPCLift;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.Button BtnFTDown;
        internal System.Windows.Forms.Button BtnFTLift;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Button BtnFTRight;
        internal System.Windows.Forms.Button BtnFTLeft;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Button BtnPCRight;
        internal System.Windows.Forms.Button BtnPCLeft;
        internal System.Windows.Forms.Label LabName;
        internal System.Windows.Forms.Button BtnFTPCForce;
    }
}