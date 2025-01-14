namespace CrystalGrowth.AuxFunction.Calibration
{
    partial class FrmSeedTrvLim
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
            this.LabDateTime = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.LabDownLim = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.LabUpLim = new System.Windows.Forms.Label();
            this.LabTrvPV = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.LabName = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LabDateTime
            // 
            this.LabDateTime.BackColor = System.Drawing.Color.Transparent;
            this.LabDateTime.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabDateTime.ForeColor = System.Drawing.Color.White;
            this.LabDateTime.Location = new System.Drawing.Point(150, 347);
            this.LabDateTime.Name = "LabDateTime";
            this.LabDateTime.Size = new System.Drawing.Size(221, 20);
            this.LabDateTime.TabIndex = 161;
            this.LabDateTime.Text = "2000-01-01 00:00:00";
            this.LabDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label13
            // 
            this.Label13.BackColor = System.Drawing.Color.Transparent;
            this.Label13.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label13.ForeColor = System.Drawing.Color.White;
            this.Label13.Location = new System.Drawing.Point(74, 347);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(70, 20);
            this.Label13.TabIndex = 160;
            this.Label13.Text = "已校准";
            this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabDownLim
            // 
            this.LabDownLim.BackColor = System.Drawing.Color.White;
            this.LabDownLim.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabDownLim.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabDownLim.ForeColor = System.Drawing.Color.Black;
            this.LabDownLim.Location = new System.Drawing.Point(149, 206);
            this.LabDownLim.Name = "LabDownLim";
            this.LabDownLim.Size = new System.Drawing.Size(100, 50);
            this.LabDownLim.TabIndex = 159;
            this.LabDownLim.Text = "0.0";
            this.LabDownLim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabDownLim.Click += new System.EventHandler(this.LabDownLim_Click);
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label6.ForeColor = System.Drawing.Color.White;
            this.Label6.Location = new System.Drawing.Point(254, 221);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(35, 20);
            this.Label6.TabIndex = 158;
            this.Label6.Text = "mm";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label7.ForeColor = System.Drawing.Color.White;
            this.Label7.Location = new System.Drawing.Point(46, 221);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(98, 20);
            this.Label7.TabIndex = 157;
            this.Label7.Text = "下限位";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabUpLim
            // 
            this.LabUpLim.BackColor = System.Drawing.Color.White;
            this.LabUpLim.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabUpLim.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabUpLim.ForeColor = System.Drawing.Color.Black;
            this.LabUpLim.Location = new System.Drawing.Point(149, 136);
            this.LabUpLim.Name = "LabUpLim";
            this.LabUpLim.Size = new System.Drawing.Size(100, 50);
            this.LabUpLim.TabIndex = 156;
            this.LabUpLim.Text = "0.0";
            this.LabUpLim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabUpLim.Click += new System.EventHandler(this.LabUpLim_Click);
            // 
            // LabTrvPV
            // 
            this.LabTrvPV.BackColor = System.Drawing.Color.Black;
            this.LabTrvPV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabTrvPV.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabTrvPV.ForeColor = System.Drawing.Color.White;
            this.LabTrvPV.Location = new System.Drawing.Point(149, 66);
            this.LabTrvPV.Name = "LabTrvPV";
            this.LabTrvPV.Size = new System.Drawing.Size(100, 50);
            this.LabTrvPV.TabIndex = 155;
            this.LabTrvPV.Text = "0.0";
            this.LabTrvPV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(254, 81);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(35, 20);
            this.Label5.TabIndex = 154;
            this.Label5.Text = "mm";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(254, 151);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(35, 20);
            this.Label4.TabIndex = 153;
            this.Label4.Text = "mm";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(46, 151);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(98, 20);
            this.Label2.TabIndex = 152;
            this.Label2.Text = "上限位";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(46, 81);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(98, 20);
            this.Label1.TabIndex = 151;
            this.Label1.Text = "籽晶位置";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabName
            // 
            this.LabName.BackColor = System.Drawing.Color.Transparent;
            this.LabName.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabName.ForeColor = System.Drawing.Color.White;
            this.LabName.Location = new System.Drawing.Point(41, 14);
            this.LabName.Name = "LabName";
            this.LabName.Size = new System.Drawing.Size(277, 31);
            this.LabName.TabIndex = 150;
            this.LabName.Text = "籽晶限位校准";
            this.LabName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 500;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // FrmSeedTrvLim
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(394, 380);
            this.Controls.Add(this.LabDateTime);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.LabDownLim);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.LabUpLim);
            this.Controls.Add(this.LabTrvPV);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.LabName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSeedTrvLim";
            this.Text = "FrmSeedTrvLim";
            this.Load += new System.EventHandler(this.FrmSeedTrvLim_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label LabDateTime;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label LabDownLim;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label LabUpLim;
        internal System.Windows.Forms.Label LabTrvPV;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label LabName;
        private System.Windows.Forms.Timer Timer1;
    }
}