namespace CrystalGrowth.AuxFunction.Calibration
{
    partial class FrmSL_Speed
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
            this.Label3 = new System.Windows.Forms.Label();
            this.LabSLCalib = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.LabDateTime = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.LabGain = new System.Windows.Forms.Label();
            this.LabSLPV = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.LabName = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(269, 150);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(80, 20);
            this.Label3.TabIndex = 170;
            this.Label3.Text = "mm/min";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabSLCalib
            // 
            this.LabSLCalib.BackColor = System.Drawing.Color.White;
            this.LabSLCalib.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabSLCalib.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabSLCalib.ForeColor = System.Drawing.Color.Black;
            this.LabSLCalib.Location = new System.Drawing.Point(164, 135);
            this.LabSLCalib.Name = "LabSLCalib";
            this.LabSLCalib.Size = new System.Drawing.Size(100, 50);
            this.LabSLCalib.TabIndex = 169;
            this.LabSLCalib.Text = "0.0";
            this.LabSLCalib.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabSLCalib.Click += new System.EventHandler(this.LabSLCalib_Click);
            // 
            // Label10
            // 
            this.Label10.BackColor = System.Drawing.Color.Transparent;
            this.Label10.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label10.ForeColor = System.Drawing.Color.White;
            this.Label10.Location = new System.Drawing.Point(28, 150);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(131, 20);
            this.Label10.TabIndex = 168;
            this.Label10.Text = "速度校准值";
            this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabDateTime
            // 
            this.LabDateTime.BackColor = System.Drawing.Color.Transparent;
            this.LabDateTime.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabDateTime.ForeColor = System.Drawing.Color.White;
            this.LabDateTime.Location = new System.Drawing.Point(165, 347);
            this.LabDateTime.Name = "LabDateTime";
            this.LabDateTime.Size = new System.Drawing.Size(221, 20);
            this.LabDateTime.TabIndex = 167;
            this.LabDateTime.Text = "2000-01-01 00:00:00";
            this.LabDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label13
            // 
            this.Label13.BackColor = System.Drawing.Color.Transparent;
            this.Label13.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label13.ForeColor = System.Drawing.Color.White;
            this.Label13.Location = new System.Drawing.Point(89, 347);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(70, 20);
            this.Label13.TabIndex = 166;
            this.Label13.Text = "已校准";
            this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabGain
            // 
            this.LabGain.BackColor = System.Drawing.Color.Black;
            this.LabGain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabGain.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabGain.ForeColor = System.Drawing.Color.White;
            this.LabGain.Location = new System.Drawing.Point(164, 204);
            this.LabGain.Name = "LabGain";
            this.LabGain.Size = new System.Drawing.Size(100, 50);
            this.LabGain.TabIndex = 165;
            this.LabGain.Text = "0.00";
            this.LabGain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabSLPV
            // 
            this.LabSLPV.BackColor = System.Drawing.Color.Black;
            this.LabSLPV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabSLPV.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabSLPV.ForeColor = System.Drawing.Color.White;
            this.LabSLPV.Location = new System.Drawing.Point(164, 66);
            this.LabSLPV.Name = "LabSLPV";
            this.LabSLPV.Size = new System.Drawing.Size(100, 50);
            this.LabSLPV.TabIndex = 164;
            this.LabSLPV.Text = "0.0";
            this.LabSLPV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(269, 81);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(80, 20);
            this.Label5.TabIndex = 163;
            this.Label5.Text = "mm/min";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(28, 219);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(131, 20);
            this.Label2.TabIndex = 162;
            this.Label2.Text = "增益";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(28, 81);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(131, 20);
            this.Label1.TabIndex = 161;
            this.Label1.Text = "实际速度";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabName
            // 
            this.LabName.BackColor = System.Drawing.Color.Transparent;
            this.LabName.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabName.ForeColor = System.Drawing.Color.White;
            this.LabName.Location = new System.Drawing.Point(72, 14);
            this.LabName.Name = "LabName";
            this.LabName.Size = new System.Drawing.Size(245, 31);
            this.LabName.TabIndex = 160;
            this.LabName.Text = "晶升速度校准";
            this.LabName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 500;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // FrmSL_Speed
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(394, 380);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.LabSLCalib);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.LabDateTime);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.LabGain);
            this.Controls.Add(this.LabSLPV);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.LabName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSL_Speed";
            this.Text = "FrmSL_Speed";
            this.Load += new System.EventHandler(this.FrmSL_Speed_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label LabSLCalib;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label LabDateTime;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label LabGain;
        internal System.Windows.Forms.Label LabSLPV;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label LabName;
        private System.Windows.Forms.Timer Timer1;
    }
}