namespace CrystalGrowth.CrystalCtl
{
    partial class FrmGrowCtlTemp
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
            this.BtnFixed = new System.Windows.Forms.Button();
            this.BtnAuto = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.LabIntegTxt = new System.Windows.Forms.Label();
            this.LabDifferTxt = new System.Windows.Forms.Label();
            this.LabGainVal = new System.Windows.Forms.Label();
            this.LabGainTxt = new System.Windows.Forms.Label();
            this.LabDifferVal = new System.Windows.Forms.Label();
            this.LabIntegVal = new System.Windows.Forms.Label();
            this.BtnOFF = new System.Windows.Forms.Button();
            this.BtnON = new System.Windows.Forms.Button();
            this.BtnLimit = new System.Windows.Forms.Button();
            this.LabSP = new System.Windows.Forms.Label();
            this.BtnTune = new System.Windows.Forms.Button();
            this.LabOut = new System.Windows.Forms.Label();
            this.LabPV = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.LabName = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnFixed
            // 
            this.BtnFixed.BackColor = System.Drawing.Color.Blue;
            this.BtnFixed.FlatAppearance.BorderSize = 0;
            this.BtnFixed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFixed.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnFixed.ForeColor = System.Drawing.Color.White;
            this.BtnFixed.Location = new System.Drawing.Point(262, 330);
            this.BtnFixed.Name = "BtnFixed";
            this.BtnFixed.Size = new System.Drawing.Size(100, 35);
            this.BtnFixed.TabIndex = 114;
            this.BtnFixed.Text = "固定值";
            this.BtnFixed.UseVisualStyleBackColor = false;
            this.BtnFixed.Visible = false;
            this.BtnFixed.Click += new System.EventHandler(this.BtnFixed_Click);
            // 
            // BtnAuto
            // 
            this.BtnAuto.BackColor = System.Drawing.Color.Blue;
            this.BtnAuto.FlatAppearance.BorderSize = 0;
            this.BtnAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAuto.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnAuto.ForeColor = System.Drawing.Color.White;
            this.BtnAuto.Location = new System.Drawing.Point(262, 285);
            this.BtnAuto.Name = "BtnAuto";
            this.BtnAuto.Size = new System.Drawing.Size(100, 35);
            this.BtnAuto.TabIndex = 113;
            this.BtnAuto.Text = "自动";
            this.BtnAuto.UseVisualStyleBackColor = false;
            this.BtnAuto.Visible = false;
            this.BtnAuto.Click += new System.EventHandler(this.BtnAuto_Click);
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.LabIntegTxt);
            this.Panel1.Controls.Add(this.LabDifferTxt);
            this.Panel1.Controls.Add(this.LabGainVal);
            this.Panel1.Controls.Add(this.LabGainTxt);
            this.Panel1.Controls.Add(this.LabDifferVal);
            this.Panel1.Controls.Add(this.LabIntegVal);
            this.Panel1.Location = new System.Drawing.Point(-1, 379);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(395, 114);
            this.Panel1.TabIndex = 112;
            // 
            // LabIntegTxt
            // 
            this.LabIntegTxt.BackColor = System.Drawing.Color.Transparent;
            this.LabIntegTxt.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabIntegTxt.ForeColor = System.Drawing.Color.White;
            this.LabIntegTxt.Location = new System.Drawing.Point(267, 23);
            this.LabIntegTxt.Name = "LabIntegTxt";
            this.LabIntegTxt.Size = new System.Drawing.Size(100, 20);
            this.LabIntegTxt.TabIndex = 47;
            this.LabIntegTxt.Text = "积分";
            this.LabIntegTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabDifferTxt
            // 
            this.LabDifferTxt.BackColor = System.Drawing.Color.Transparent;
            this.LabDifferTxt.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabDifferTxt.ForeColor = System.Drawing.Color.White;
            this.LabDifferTxt.Location = new System.Drawing.Point(146, 23);
            this.LabDifferTxt.Name = "LabDifferTxt";
            this.LabDifferTxt.Size = new System.Drawing.Size(100, 20);
            this.LabDifferTxt.TabIndex = 46;
            this.LabDifferTxt.Text = "微分";
            this.LabDifferTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabGainVal
            // 
            this.LabGainVal.BackColor = System.Drawing.Color.White;
            this.LabGainVal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabGainVal.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabGainVal.ForeColor = System.Drawing.Color.Black;
            this.LabGainVal.Location = new System.Drawing.Point(23, 52);
            this.LabGainVal.Name = "LabGainVal";
            this.LabGainVal.Size = new System.Drawing.Size(100, 50);
            this.LabGainVal.TabIndex = 42;
            this.LabGainVal.Text = "0.0000";
            this.LabGainVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabGainVal.Click += new System.EventHandler(this.LabGainVal_Click);
            // 
            // LabGainTxt
            // 
            this.LabGainTxt.BackColor = System.Drawing.Color.Transparent;
            this.LabGainTxt.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabGainTxt.ForeColor = System.Drawing.Color.White;
            this.LabGainTxt.Location = new System.Drawing.Point(23, 23);
            this.LabGainTxt.Name = "LabGainTxt";
            this.LabGainTxt.Size = new System.Drawing.Size(100, 20);
            this.LabGainTxt.TabIndex = 45;
            this.LabGainTxt.Text = "增益";
            this.LabGainTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabDifferVal
            // 
            this.LabDifferVal.BackColor = System.Drawing.Color.White;
            this.LabDifferVal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabDifferVal.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabDifferVal.ForeColor = System.Drawing.Color.Black;
            this.LabDifferVal.Location = new System.Drawing.Point(145, 52);
            this.LabDifferVal.Name = "LabDifferVal";
            this.LabDifferVal.Size = new System.Drawing.Size(100, 50);
            this.LabDifferVal.TabIndex = 43;
            this.LabDifferVal.Text = "0.0000";
            this.LabDifferVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabDifferVal.Click += new System.EventHandler(this.LabDifferVal_Click);
            // 
            // LabIntegVal
            // 
            this.LabIntegVal.BackColor = System.Drawing.Color.White;
            this.LabIntegVal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabIntegVal.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabIntegVal.ForeColor = System.Drawing.Color.Black;
            this.LabIntegVal.Location = new System.Drawing.Point(267, 52);
            this.LabIntegVal.Name = "LabIntegVal";
            this.LabIntegVal.Size = new System.Drawing.Size(100, 50);
            this.LabIntegVal.TabIndex = 44;
            this.LabIntegVal.Text = "0.0000";
            this.LabIntegVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabIntegVal.Click += new System.EventHandler(this.LabIntegVal_Click);
            // 
            // BtnOFF
            // 
            this.BtnOFF.BackColor = System.Drawing.Color.Blue;
            this.BtnOFF.FlatAppearance.BorderSize = 0;
            this.BtnOFF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOFF.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnOFF.ForeColor = System.Drawing.Color.White;
            this.BtnOFF.Location = new System.Drawing.Point(147, 330);
            this.BtnOFF.Name = "BtnOFF";
            this.BtnOFF.Size = new System.Drawing.Size(100, 35);
            this.BtnOFF.TabIndex = 111;
            this.BtnOFF.Text = "OFF";
            this.BtnOFF.UseVisualStyleBackColor = false;
            this.BtnOFF.Click += new System.EventHandler(this.BtnOFF_Click);
            // 
            // BtnON
            // 
            this.BtnON.BackColor = System.Drawing.Color.Blue;
            this.BtnON.FlatAppearance.BorderSize = 0;
            this.BtnON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnON.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnON.ForeColor = System.Drawing.Color.White;
            this.BtnON.Location = new System.Drawing.Point(147, 285);
            this.BtnON.Name = "BtnON";
            this.BtnON.Size = new System.Drawing.Size(100, 35);
            this.BtnON.TabIndex = 110;
            this.BtnON.Text = "ON";
            this.BtnON.UseVisualStyleBackColor = false;
            this.BtnON.Click += new System.EventHandler(this.BtnON_Click);
            // 
            // BtnLimit
            // 
            this.BtnLimit.BackColor = System.Drawing.Color.Blue;
            this.BtnLimit.FlatAppearance.BorderSize = 0;
            this.BtnLimit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimit.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnLimit.ForeColor = System.Drawing.Color.White;
            this.BtnLimit.Location = new System.Drawing.Point(32, 330);
            this.BtnLimit.Name = "BtnLimit";
            this.BtnLimit.Size = new System.Drawing.Size(100, 35);
            this.BtnLimit.TabIndex = 109;
            this.BtnLimit.Text = "极限值";
            this.BtnLimit.UseVisualStyleBackColor = false;
            this.BtnLimit.Click += new System.EventHandler(this.BtnLimit_Click);
            // 
            // LabSP
            // 
            this.LabSP.BackColor = System.Drawing.Color.Gray;
            this.LabSP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabSP.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabSP.ForeColor = System.Drawing.Color.Black;
            this.LabSP.Location = new System.Drawing.Point(167, 140);
            this.LabSP.Name = "LabSP";
            this.LabSP.Size = new System.Drawing.Size(100, 50);
            this.LabSP.TabIndex = 107;
            this.LabSP.Text = "0.0";
            this.LabSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabSP.Click += new System.EventHandler(this.LabSP_Click);
            // 
            // BtnTune
            // 
            this.BtnTune.BackColor = System.Drawing.Color.Blue;
            this.BtnTune.FlatAppearance.BorderSize = 0;
            this.BtnTune.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTune.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnTune.ForeColor = System.Drawing.Color.White;
            this.BtnTune.Location = new System.Drawing.Point(32, 285);
            this.BtnTune.Name = "BtnTune";
            this.BtnTune.Size = new System.Drawing.Size(100, 35);
            this.BtnTune.TabIndex = 108;
            this.BtnTune.Text = "调节";
            this.BtnTune.UseVisualStyleBackColor = false;
            this.BtnTune.Click += new System.EventHandler(this.BtnTune_Click);
            // 
            // LabOut
            // 
            this.LabOut.BackColor = System.Drawing.Color.White;
            this.LabOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabOut.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabOut.ForeColor = System.Drawing.Color.Black;
            this.LabOut.Location = new System.Drawing.Point(167, 210);
            this.LabOut.Name = "LabOut";
            this.LabOut.Size = new System.Drawing.Size(100, 50);
            this.LabOut.TabIndex = 106;
            this.LabOut.Text = "0.0";
            this.LabOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabOut.Click += new System.EventHandler(this.LabOut_Click);
            // 
            // LabPV
            // 
            this.LabPV.BackColor = System.Drawing.Color.Black;
            this.LabPV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabPV.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabPV.ForeColor = System.Drawing.Color.White;
            this.LabPV.Location = new System.Drawing.Point(167, 70);
            this.LabPV.Name = "LabPV";
            this.LabPV.Size = new System.Drawing.Size(100, 50);
            this.LabPV.TabIndex = 105;
            this.LabPV.Text = "0.0";
            this.LabPV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label6.ForeColor = System.Drawing.Color.White;
            this.Label6.Location = new System.Drawing.Point(272, 225);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(80, 20);
            this.Label6.TabIndex = 104;
            this.Label6.Text = "units";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(272, 85);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(80, 20);
            this.Label5.TabIndex = 103;
            this.Label5.Text = "mm/hr";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(272, 155);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(80, 20);
            this.Label4.TabIndex = 102;
            this.Label4.Text = "mm/hr";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(32, 225);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(130, 20);
            this.Label3.TabIndex = 101;
            this.Label3.Text = "设定热场温度";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(42, 155);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(120, 20);
            this.Label2.TabIndex = 100;
            this.Label2.Text = "设定速度";
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
            this.LabName.TabIndex = 98;
            this.LabName.Text = "生长控制";
            this.LabName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(42, 85);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(120, 20);
            this.Label1.TabIndex = 99;
            this.Label1.Text = "生长速度";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 500;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // FrmGrowCtlTemp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(394, 494);
            this.Controls.Add(this.BtnFixed);
            this.Controls.Add(this.BtnAuto);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.BtnOFF);
            this.Controls.Add(this.BtnON);
            this.Controls.Add(this.BtnLimit);
            this.Controls.Add(this.LabSP);
            this.Controls.Add(this.BtnTune);
            this.Controls.Add(this.LabOut);
            this.Controls.Add(this.LabPV);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.LabName);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGrowCtlTemp";
            this.Text = "FrmGrowCtlTemp";
            this.Load += new System.EventHandler(this.FrmGrowCtlTemp_Load);
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button BtnFixed;
        internal System.Windows.Forms.Button BtnAuto;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label LabIntegTxt;
        internal System.Windows.Forms.Label LabDifferTxt;
        internal System.Windows.Forms.Label LabGainVal;
        internal System.Windows.Forms.Label LabGainTxt;
        internal System.Windows.Forms.Label LabDifferVal;
        internal System.Windows.Forms.Label LabIntegVal;
        internal System.Windows.Forms.Button BtnOFF;
        internal System.Windows.Forms.Button BtnON;
        internal System.Windows.Forms.Button BtnLimit;
        internal System.Windows.Forms.Label LabSP;
        internal System.Windows.Forms.Button BtnTune;
        internal System.Windows.Forms.Label LabOut;
        internal System.Windows.Forms.Label LabPV;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label LabName;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Timer Timer1;
    }
}