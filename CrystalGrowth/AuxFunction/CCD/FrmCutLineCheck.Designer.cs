namespace CrystalGrowth.AuxFunction.CCD
{
    partial class FrmCutLineCheck
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
            this.LabLastCount = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.LabCutLineProb = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.LabIsCutLineStart = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.LabCurrentLineCount = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.LabCountAlarm = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.LabThroshold = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.LabCheckPeriod = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.LabName = new System.Windows.Forms.Label();
            this.LabStartLine = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 250;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // LabLastCount
            // 
            this.LabLastCount.BackColor = System.Drawing.Color.Black;
            this.LabLastCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabLastCount.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabLastCount.ForeColor = System.Drawing.Color.White;
            this.LabLastCount.Location = new System.Drawing.Point(229, 317);
            this.LabLastCount.Name = "LabLastCount";
            this.LabLastCount.Size = new System.Drawing.Size(97, 40);
            this.LabLastCount.TabIndex = 190;
            this.LabLastCount.Text = "0";
            this.LabLastCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label9
            // 
            this.Label9.BackColor = System.Drawing.Color.Transparent;
            this.Label9.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label9.ForeColor = System.Drawing.Color.White;
            this.Label9.Location = new System.Drawing.Point(3, 317);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(196, 40);
            this.Label9.TabIndex = 191;
            this.Label9.Text = "上周期棱线计数:";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabCutLineProb
            // 
            this.LabCutLineProb.BackColor = System.Drawing.Color.Black;
            this.LabCutLineProb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabCutLineProb.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabCutLineProb.ForeColor = System.Drawing.Color.White;
            this.LabCutLineProb.Location = new System.Drawing.Point(229, 421);
            this.LabCutLineProb.Name = "LabCutLineProb";
            this.LabCutLineProb.Size = new System.Drawing.Size(97, 40);
            this.LabCutLineProb.TabIndex = 188;
            this.LabCutLineProb.Text = "0";
            this.LabCutLineProb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label11
            // 
            this.Label11.BackColor = System.Drawing.Color.Transparent;
            this.Label11.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label11.ForeColor = System.Drawing.Color.White;
            this.Label11.Location = new System.Drawing.Point(39, 421);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(160, 40);
            this.Label11.TabIndex = 189;
            this.Label11.Text = "断线率:";
            this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabIsCutLineStart
            // 
            this.LabIsCutLineStart.BackColor = System.Drawing.Color.Transparent;
            this.LabIsCutLineStart.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabIsCutLineStart.ForeColor = System.Drawing.Color.Red;
            this.LabIsCutLineStart.Location = new System.Drawing.Point(229, 265);
            this.LabIsCutLineStart.Name = "LabIsCutLineStart";
            this.LabIsCutLineStart.Size = new System.Drawing.Size(97, 40);
            this.LabIsCutLineStart.TabIndex = 187;
            this.LabIsCutLineStart.Text = "关闭";
            this.LabIsCutLineStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label8
            // 
            this.Label8.BackColor = System.Drawing.Color.Transparent;
            this.Label8.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label8.ForeColor = System.Drawing.Color.White;
            this.Label8.Location = new System.Drawing.Point(39, 265);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(160, 40);
            this.Label8.TabIndex = 186;
            this.Label8.Text = "开启状态:";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabCurrentLineCount
            // 
            this.LabCurrentLineCount.BackColor = System.Drawing.Color.Black;
            this.LabCurrentLineCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabCurrentLineCount.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabCurrentLineCount.ForeColor = System.Drawing.Color.White;
            this.LabCurrentLineCount.Location = new System.Drawing.Point(229, 369);
            this.LabCurrentLineCount.Name = "LabCurrentLineCount";
            this.LabCurrentLineCount.Size = new System.Drawing.Size(97, 40);
            this.LabCurrentLineCount.TabIndex = 184;
            this.LabCurrentLineCount.Text = "0";
            this.LabCurrentLineCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label7.ForeColor = System.Drawing.Color.White;
            this.Label7.Location = new System.Drawing.Point(39, 369);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(160, 40);
            this.Label7.TabIndex = 185;
            this.Label7.Text = "棱线计数:";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.DarkGray;
            this.Panel1.Controls.Add(this.LabCutLineProb);
            this.Panel1.Controls.Add(this.LabLastCount);
            this.Panel1.Controls.Add(this.Label11);
            this.Panel1.Controls.Add(this.LabCountAlarm);
            this.Panel1.Controls.Add(this.LabCurrentLineCount);
            this.Panel1.Controls.Add(this.Label9);
            this.Panel1.Controls.Add(this.Label7);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.LabThroshold);
            this.Panel1.Controls.Add(this.Label4);
            this.Panel1.Controls.Add(this.LabIsCutLineStart);
            this.Panel1.Controls.Add(this.LabCheckPeriod);
            this.Panel1.Controls.Add(this.Label8);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.LabName);
            this.Panel1.Controls.Add(this.LabStartLine);
            this.Panel1.Controls.Add(this.Label5);
            this.Panel1.Location = new System.Drawing.Point(12, 8);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(357, 470);
            this.Panel1.TabIndex = 190;
            // 
            // LabCountAlarm
            // 
            this.LabCountAlarm.BackColor = System.Drawing.Color.White;
            this.LabCountAlarm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabCountAlarm.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabCountAlarm.ForeColor = System.Drawing.Color.Black;
            this.LabCountAlarm.Location = new System.Drawing.Point(229, 213);
            this.LabCountAlarm.Name = "LabCountAlarm";
            this.LabCountAlarm.Size = new System.Drawing.Size(97, 40);
            this.LabCountAlarm.TabIndex = 189;
            this.LabCountAlarm.Text = "0";
            this.LabCountAlarm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabCountAlarm.Click += new System.EventHandler(this.LabCountAlarm_Click);
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(39, 213);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(160, 40);
            this.Label3.TabIndex = 190;
            this.Label3.Text = "计数报警阈值:";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabThroshold
            // 
            this.LabThroshold.BackColor = System.Drawing.Color.White;
            this.LabThroshold.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabThroshold.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabThroshold.ForeColor = System.Drawing.Color.Black;
            this.LabThroshold.Location = new System.Drawing.Point(229, 161);
            this.LabThroshold.Name = "LabThroshold";
            this.LabThroshold.Size = new System.Drawing.Size(97, 40);
            this.LabThroshold.TabIndex = 187;
            this.LabThroshold.Text = "0.0";
            this.LabThroshold.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabThroshold.Click += new System.EventHandler(this.LabThroshold_Click);
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(39, 161);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(160, 40);
            this.Label4.TabIndex = 188;
            this.Label4.Text = "检测阈值:";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabCheckPeriod
            // 
            this.LabCheckPeriod.BackColor = System.Drawing.Color.White;
            this.LabCheckPeriod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabCheckPeriod.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabCheckPeriod.ForeColor = System.Drawing.Color.Black;
            this.LabCheckPeriod.Location = new System.Drawing.Point(229, 109);
            this.LabCheckPeriod.Name = "LabCheckPeriod";
            this.LabCheckPeriod.Size = new System.Drawing.Size(97, 40);
            this.LabCheckPeriod.TabIndex = 185;
            this.LabCheckPeriod.Text = "0.0";
            this.LabCheckPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabCheckPeriod.Click += new System.EventHandler(this.LabCheckPeriod_Click);
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(17, 109);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(182, 40);
            this.Label2.TabIndex = 186;
            this.Label2.Text = "检测周期(min):";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabName
            // 
            this.LabName.BackColor = System.Drawing.Color.Transparent;
            this.LabName.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabName.ForeColor = System.Drawing.Color.Black;
            this.LabName.Location = new System.Drawing.Point(75, 7);
            this.LabName.Name = "LabName";
            this.LabName.Size = new System.Drawing.Size(198, 40);
            this.LabName.TabIndex = 184;
            this.LabName.Text = "断线检测参数";
            this.LabName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabStartLine
            // 
            this.LabStartLine.BackColor = System.Drawing.Color.White;
            this.LabStartLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabStartLine.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabStartLine.ForeColor = System.Drawing.Color.Black;
            this.LabStartLine.Location = new System.Drawing.Point(229, 57);
            this.LabStartLine.Name = "LabStartLine";
            this.LabStartLine.Size = new System.Drawing.Size(97, 40);
            this.LabStartLine.TabIndex = 182;
            this.LabStartLine.Text = "0.0";
            this.LabStartLine.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabStartLine.Click += new System.EventHandler(this.LabStartLine_Click);
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(39, 57);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(160, 40);
            this.Label5.TabIndex = 183;
            this.Label5.Text = "开启长度(mm):";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.BtnQuit.TabIndex = 192;
            this.BtnQuit.Text = "返回";
            this.BtnQuit.UseVisualStyleBackColor = false;
            this.BtnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
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
            this.BtnSave.TabIndex = 193;
            this.BtnSave.Text = "保存";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // FrmCutLineCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(380, 638);
            this.Controls.Add(this.BtnQuit);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCutLineCheck";
            this.Text = "FrmCutLine";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCutLineCheck_FormClosed);
            this.Load += new System.EventHandler(this.FrmCutLineCheck_Load);
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer Timer1;
        internal System.Windows.Forms.Label LabLastCount;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label LabCutLineProb;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label LabIsCutLineStart;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label LabCurrentLineCount;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label LabCountAlarm;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label LabThroshold;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label LabCheckPeriod;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label LabName;
        internal System.Windows.Forms.Label LabStartLine;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Button BtnQuit;
        internal System.Windows.Forms.Button BtnSave;
    }
}