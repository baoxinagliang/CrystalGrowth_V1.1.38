namespace CrystalGrowth.AuxFunction.CCD
{
    partial class FrmMeltCheckArea
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
            this.BtnQuit = new System.Windows.Forms.Button();
            this.BtnOpen = new System.Windows.Forms.Button();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LabAverage = new System.Windows.Forms.Label();
            this.LabPecent = new System.Windows.Forms.Label();
            this.LabSp = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.LabName = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 500;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
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
            this.BtnQuit.TabIndex = 178;
            this.BtnQuit.Text = "返回";
            this.BtnQuit.UseVisualStyleBackColor = false;
            this.BtnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // BtnOpen
            // 
            this.BtnOpen.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnOpen.FlatAppearance.BorderSize = 0;
            this.BtnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOpen.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnOpen.ForeColor = System.Drawing.Color.White;
            this.BtnOpen.Location = new System.Drawing.Point(13, 568);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(117, 60);
            this.BtnOpen.TabIndex = 180;
            this.BtnOpen.Text = "打开检测";
            this.BtnOpen.UseVisualStyleBackColor = false;
            this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.DarkGray;
            this.Panel2.Controls.Add(this.label1);
            this.Panel2.Controls.Add(this.LabAverage);
            this.Panel2.Controls.Add(this.LabPecent);
            this.Panel2.Controls.Add(this.LabSp);
            this.Panel2.Controls.Add(this.Label5);
            this.Panel2.Controls.Add(this.Label2);
            this.Panel2.Controls.Add(this.LabName);
            this.Panel2.Location = new System.Drawing.Point(13, 12);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(353, 349);
            this.Panel2.TabIndex = 179;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 40);
            this.label1.TabIndex = 191;
            this.label1.Text = "报警下限值:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabAverage
            // 
            this.LabAverage.BackColor = System.Drawing.Color.Black;
            this.LabAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabAverage.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabAverage.ForeColor = System.Drawing.Color.White;
            this.LabAverage.Location = new System.Drawing.Point(167, 168);
            this.LabAverage.Name = "LabAverage";
            this.LabAverage.Size = new System.Drawing.Size(142, 40);
            this.LabAverage.TabIndex = 190;
            this.LabAverage.Text = "0.000";
            this.LabAverage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabPecent
            // 
            this.LabPecent.BackColor = System.Drawing.Color.Black;
            this.LabPecent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabPecent.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabPecent.ForeColor = System.Drawing.Color.White;
            this.LabPecent.Location = new System.Drawing.Point(167, 80);
            this.LabPecent.Name = "LabPecent";
            this.LabPecent.Size = new System.Drawing.Size(142, 40);
            this.LabPecent.TabIndex = 189;
            this.LabPecent.Text = "0.000";
            this.LabPecent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabSp
            // 
            this.LabSp.BackColor = System.Drawing.Color.White;
            this.LabSp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabSp.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabSp.ForeColor = System.Drawing.Color.Black;
            this.LabSp.Location = new System.Drawing.Point(167, 256);
            this.LabSp.Name = "LabSp";
            this.LabSp.Size = new System.Drawing.Size(142, 40);
            this.LabSp.TabIndex = 180;
            this.LabSp.Text = "0.000";
            this.LabSp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabSp.Click += new System.EventHandler(this.LabSp_Click);
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(10, 167);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(145, 40);
            this.Label5.TabIndex = 179;
            this.Label5.Text = "检测平均值:";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(10, 79);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(145, 40);
            this.Label2.TabIndex = 177;
            this.Label2.Text = "固体百分比:";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabName
            // 
            this.LabName.BackColor = System.Drawing.Color.Transparent;
            this.LabName.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabName.ForeColor = System.Drawing.Color.Black;
            this.LabName.Location = new System.Drawing.Point(74, 5);
            this.LabName.Name = "LabName";
            this.LabName.Size = new System.Drawing.Size(198, 40);
            this.LabName.TabIndex = 172;
            this.LabName.Text = "全熔检测区域";
            this.LabName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.BtnSave.TabIndex = 181;
            this.BtnSave.Text = "保存";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // FrmMeltCheckArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(380, 638);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnQuit);
            this.Controls.Add(this.BtnOpen);
            this.Controls.Add(this.Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMeltCheckArea";
            this.Text = "FrmMeltCheckArea";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMeltCheckArea_FormClosed);
            this.Load += new System.EventHandler(this.FrmMeltCheckArea_Load);
            this.Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Timer1;
        internal System.Windows.Forms.Button BtnQuit;
        internal System.Windows.Forms.Button BtnOpen;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Label LabSp;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label LabName;
        internal System.Windows.Forms.Label LabPecent;
        internal System.Windows.Forms.Label LabAverage;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button BtnSave;
    }
}