namespace CrystalGrowth.Trend
{
    partial class FrmChangeTime
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
            this.BtnBack = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.LabHistorySpan = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LabRealSpan = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnBack.FlatAppearance.BorderSize = 0;
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBack.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnBack.ForeColor = System.Drawing.Color.White;
            this.BtnBack.Location = new System.Drawing.Point(606, 2);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(117, 60);
            this.BtnBack.TabIndex = 19;
            this.BtnBack.Text = "返回";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.DarkGray;
            this.Panel1.Controls.Add(this.LabHistorySpan);
            this.Panel1.Controls.Add(this.label3);
            this.Panel1.Controls.Add(this.label5);
            this.Panel1.Controls.Add(this.LabRealSpan);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.Label4);
            this.Panel1.Location = new System.Drawing.Point(2, 73);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(721, 180);
            this.Panel1.TabIndex = 18;
            // 
            // LabHistorySpan
            // 
            this.LabHistorySpan.BackColor = System.Drawing.Color.White;
            this.LabHistorySpan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabHistorySpan.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabHistorySpan.ForeColor = System.Drawing.Color.Black;
            this.LabHistorySpan.Location = new System.Drawing.Point(508, 65);
            this.LabHistorySpan.Name = "LabHistorySpan";
            this.LabHistorySpan.Size = new System.Drawing.Size(100, 50);
            this.LabHistorySpan.TabIndex = 98;
            this.LabHistorySpan.Text = "0";
            this.LabHistorySpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabHistorySpan.Click += new System.EventHandler(this.LabHistorySpan_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(613, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 97;
            this.label3.Text = "min";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(357, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 20);
            this.label5.TabIndex = 96;
            this.label5.Text = "历史曲线时间";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabRealSpan
            // 
            this.LabRealSpan.BackColor = System.Drawing.Color.White;
            this.LabRealSpan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabRealSpan.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabRealSpan.ForeColor = System.Drawing.Color.Black;
            this.LabRealSpan.Location = new System.Drawing.Point(160, 65);
            this.LabRealSpan.Name = "LabRealSpan";
            this.LabRealSpan.Size = new System.Drawing.Size(100, 50);
            this.LabRealSpan.TabIndex = 95;
            this.LabRealSpan.Text = "0";
            this.LabRealSpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabRealSpan.Click += new System.EventHandler(this.LabRealSpan_Click);
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(265, 80);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(80, 20);
            this.Label2.TabIndex = 94;
            this.Label2.Text = "min";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label4.ForeColor = System.Drawing.Color.Black;
            this.Label4.Location = new System.Drawing.Point(10, 80);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(145, 20);
            this.Label4.TabIndex = 93;
            this.Label4.Text = "曲线间隔时间";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmChangeTime
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(1366, 254);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.Panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmChangeTime";
            this.Text = "FrmChangeTime";
            this.Load += new System.EventHandler(this.FrmChangeTime_Load);
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button BtnBack;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label LabRealSpan;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label LabHistorySpan;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label5;
    }
}