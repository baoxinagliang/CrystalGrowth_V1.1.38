namespace CrystalGrowth.AuxFunction.Calibration
{
    partial class FrmFurnaceNum
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
            this.LabDateTime = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.LabSP = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.LabName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabDateTime
            // 
            this.LabDateTime.BackColor = System.Drawing.Color.Transparent;
            this.LabDateTime.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabDateTime.ForeColor = System.Drawing.Color.White;
            this.LabDateTime.Location = new System.Drawing.Point(168, 351);
            this.LabDateTime.Name = "LabDateTime";
            this.LabDateTime.Size = new System.Drawing.Size(221, 20);
            this.LabDateTime.TabIndex = 112;
            this.LabDateTime.Text = "2000-01-01 00:00:00";
            this.LabDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(92, 351);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(70, 20);
            this.Label1.TabIndex = 111;
            this.Label1.Text = "已校准";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabSP
            // 
            this.LabSP.BackColor = System.Drawing.Color.White;
            this.LabSP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabSP.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabSP.ForeColor = System.Drawing.Color.Black;
            this.LabSP.Location = new System.Drawing.Point(102, 140);
            this.LabSP.Name = "LabSP";
            this.LabSP.Size = new System.Drawing.Size(232, 50);
            this.LabSP.TabIndex = 110;
            this.LabSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabSP.Click += new System.EventHandler(this.LabSP_Click);
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(6, 155);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(91, 20);
            this.Label2.TabIndex = 109;
            this.Label2.Text = "炉号";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabName
            // 
            this.LabName.BackColor = System.Drawing.Color.Transparent;
            this.LabName.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabName.ForeColor = System.Drawing.Color.White;
            this.LabName.Location = new System.Drawing.Point(75, 18);
            this.LabName.Name = "LabName";
            this.LabName.Size = new System.Drawing.Size(245, 31);
            this.LabName.TabIndex = 108;
            this.LabName.Text = "炉号";
            this.LabName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmFurnaceNum
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(394, 380);
            this.Controls.Add(this.LabDateTime);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.LabSP);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.LabName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFurnaceNum";
            this.Text = "FrmFurnaceNum";
            this.Load += new System.EventHandler(this.FrmFurnaceNum_Load);
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label LabName;
        public System.Windows.Forms.Label LabSP;
        public System.Windows.Forms.Label LabDateTime;
    }
}