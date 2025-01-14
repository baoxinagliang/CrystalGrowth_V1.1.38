namespace CrystalGrowth.AuxFunction.Calibration
{
    partial class FrmTotalPower
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
            this.BtnCurReset = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.LabDateTime = new System.Windows.Forms.Label();
            this.LabCurDateTime = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.LabCurPV = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.LabTotalPV = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.LabName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 500;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // BtnCurReset
            // 
            this.BtnCurReset.BackColor = System.Drawing.Color.Blue;
            this.BtnCurReset.FlatAppearance.BorderSize = 0;
            this.BtnCurReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCurReset.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCurReset.ForeColor = System.Drawing.Color.White;
            this.BtnCurReset.Location = new System.Drawing.Point(154, 120);
            this.BtnCurReset.Name = "BtnCurReset";
            this.BtnCurReset.Size = new System.Drawing.Size(100, 50);
            this.BtnCurReset.TabIndex = 210;
            this.BtnCurReset.Text = "复位";
            this.BtnCurReset.UseVisualStyleBackColor = false;
            this.BtnCurReset.Click += new System.EventHandler(this.BtnCurReset_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.Blue;
            this.BtnReset.FlatAppearance.BorderSize = 0;
            this.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReset.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnReset.ForeColor = System.Drawing.Color.White;
            this.BtnReset.Location = new System.Drawing.Point(154, 256);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(100, 50);
            this.BtnReset.TabIndex = 211;
            this.BtnReset.Text = "复位";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // LabDateTime
            // 
            this.LabDateTime.BackColor = System.Drawing.Color.Transparent;
            this.LabDateTime.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabDateTime.ForeColor = System.Drawing.Color.White;
            this.LabDateTime.Location = new System.Drawing.Point(137, 347);
            this.LabDateTime.Name = "LabDateTime";
            this.LabDateTime.Size = new System.Drawing.Size(239, 20);
            this.LabDateTime.TabIndex = 208;
            this.LabDateTime.Text = "2000-01-01 00:00:00";
            this.LabDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabCurDateTime
            // 
            this.LabCurDateTime.BackColor = System.Drawing.Color.Transparent;
            this.LabCurDateTime.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabCurDateTime.ForeColor = System.Drawing.Color.White;
            this.LabCurDateTime.Location = new System.Drawing.Point(138, 325);
            this.LabCurDateTime.Name = "LabCurDateTime";
            this.LabCurDateTime.Size = new System.Drawing.Size(238, 20);
            this.LabCurDateTime.TabIndex = 209;
            this.LabCurDateTime.Text = "2000-01-01 00:00:00";
            this.LabCurDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(80, 347);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(56, 20);
            this.Label5.TabIndex = 205;
            this.Label5.Text = "总耗";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(80, 325);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(56, 20);
            this.Label3.TabIndex = 206;
            this.Label3.Text = "当前";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label13
            // 
            this.Label13.BackColor = System.Drawing.Color.Transparent;
            this.Label13.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label13.ForeColor = System.Drawing.Color.White;
            this.Label13.Location = new System.Drawing.Point(18, 337);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(70, 20);
            this.Label13.TabIndex = 207;
            this.Label13.Text = "已校准";
            this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(260, 67);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(48, 20);
            this.Label4.TabIndex = 203;
            this.Label4.Text = "MWh";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label11
            // 
            this.Label11.BackColor = System.Drawing.Color.Transparent;
            this.Label11.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label11.ForeColor = System.Drawing.Color.White;
            this.Label11.Location = new System.Drawing.Point(260, 203);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(48, 20);
            this.Label11.TabIndex = 204;
            this.Label11.Text = "MWh";
            this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabCurPV
            // 
            this.LabCurPV.BackColor = System.Drawing.Color.Black;
            this.LabCurPV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabCurPV.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabCurPV.ForeColor = System.Drawing.Color.White;
            this.LabCurPV.Location = new System.Drawing.Point(154, 52);
            this.LabCurPV.Name = "LabCurPV";
            this.LabCurPV.Size = new System.Drawing.Size(100, 50);
            this.LabCurPV.TabIndex = 201;
            this.LabCurPV.Text = "0.000";
            this.LabCurPV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(19, 67);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(131, 20);
            this.Label1.TabIndex = 199;
            this.Label1.Text = "当前炉次功耗当前炉次功耗";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabTotalPV
            // 
            this.LabTotalPV.BackColor = System.Drawing.Color.Black;
            this.LabTotalPV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabTotalPV.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabTotalPV.ForeColor = System.Drawing.Color.White;
            this.LabTotalPV.Location = new System.Drawing.Point(154, 188);
            this.LabTotalPV.Name = "LabTotalPV";
            this.LabTotalPV.Size = new System.Drawing.Size(100, 50);
            this.LabTotalPV.TabIndex = 202;
            this.LabTotalPV.Text = "0.000";
            this.LabTotalPV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(19, 203);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(131, 20);
            this.Label2.TabIndex = 200;
            this.Label2.Text = "总加热功耗";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabName
            // 
            this.LabName.BackColor = System.Drawing.Color.Transparent;
            this.LabName.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabName.ForeColor = System.Drawing.Color.White;
            this.LabName.Location = new System.Drawing.Point(63, 10);
            this.LabName.Name = "LabName";
            this.LabName.Size = new System.Drawing.Size(245, 31);
            this.LabName.TabIndex = 198;
            this.LabName.Text = "加热功耗校准";
            this.LabName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmTotalPower
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(394, 380);
            this.Controls.Add(this.BtnCurReset);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.LabDateTime);
            this.Controls.Add(this.LabCurDateTime);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.LabCurPV);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.LabTotalPV);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.LabName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTotalPower";
            this.Text = "FrmTotalPower";
            this.Load += new System.EventHandler(this.FrmTotalPower_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer Timer1;
        internal System.Windows.Forms.Button BtnCurReset;
        internal System.Windows.Forms.Button BtnReset;
        internal System.Windows.Forms.Label LabDateTime;
        internal System.Windows.Forms.Label LabCurDateTime;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label LabCurPV;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label LabTotalPV;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label LabName;
    }
}