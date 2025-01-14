namespace CrystalGrowth.CrystalCtl
{
    partial class FrmCLSL
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
            this.BtnFixed = new System.Windows.Forms.Button();
            this.BtnOFF = new System.Windows.Forms.Button();
            this.BtnON = new System.Windows.Forms.Button();
            this.BtnAuto = new System.Windows.Forms.Button();
            this.LabCL_SL = new System.Windows.Forms.Label();
            this.LabCL = new System.Windows.Forms.Label();
            this.LabSL = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.LabName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 500;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // BtnFixed
            // 
            this.BtnFixed.BackColor = System.Drawing.Color.Blue;
            this.BtnFixed.FlatAppearance.BorderSize = 0;
            this.BtnFixed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFixed.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnFixed.ForeColor = System.Drawing.Color.White;
            this.BtnFixed.Location = new System.Drawing.Point(257, 329);
            this.BtnFixed.Name = "BtnFixed";
            this.BtnFixed.Size = new System.Drawing.Size(100, 35);
            this.BtnFixed.TabIndex = 110;
            this.BtnFixed.Text = "固定值";
            this.BtnFixed.UseVisualStyleBackColor = false;
            this.BtnFixed.Visible = false;
            this.BtnFixed.Click += new System.EventHandler(this.BtnFixed_Click);
            // 
            // BtnOFF
            // 
            this.BtnOFF.BackColor = System.Drawing.Color.Blue;
            this.BtnOFF.FlatAppearance.BorderSize = 0;
            this.BtnOFF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOFF.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnOFF.ForeColor = System.Drawing.Color.White;
            this.BtnOFF.Location = new System.Drawing.Point(142, 329);
            this.BtnOFF.Name = "BtnOFF";
            this.BtnOFF.Size = new System.Drawing.Size(100, 35);
            this.BtnOFF.TabIndex = 108;
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
            this.BtnON.Location = new System.Drawing.Point(142, 284);
            this.BtnON.Name = "BtnON";
            this.BtnON.Size = new System.Drawing.Size(100, 35);
            this.BtnON.TabIndex = 107;
            this.BtnON.Text = "ON";
            this.BtnON.UseVisualStyleBackColor = false;
            this.BtnON.Click += new System.EventHandler(this.BtnON_Click);
            // 
            // BtnAuto
            // 
            this.BtnAuto.BackColor = System.Drawing.Color.Blue;
            this.BtnAuto.FlatAppearance.BorderSize = 0;
            this.BtnAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAuto.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnAuto.ForeColor = System.Drawing.Color.White;
            this.BtnAuto.Location = new System.Drawing.Point(257, 284);
            this.BtnAuto.Name = "BtnAuto";
            this.BtnAuto.Size = new System.Drawing.Size(100, 35);
            this.BtnAuto.TabIndex = 109;
            this.BtnAuto.Text = "自动";
            this.BtnAuto.UseVisualStyleBackColor = false;
            this.BtnAuto.Visible = false;
            this.BtnAuto.Click += new System.EventHandler(this.BtnAuto_Click);
            // 
            // LabCL_SL
            // 
            this.LabCL_SL.BackColor = System.Drawing.Color.Gray;
            this.LabCL_SL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabCL_SL.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabCL_SL.ForeColor = System.Drawing.Color.Black;
            this.LabCL_SL.Location = new System.Drawing.Point(162, 139);
            this.LabCL_SL.Name = "LabCL_SL";
            this.LabCL_SL.Size = new System.Drawing.Size(100, 50);
            this.LabCL_SL.TabIndex = 106;
            this.LabCL_SL.Text = "0.000";
            this.LabCL_SL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabCL_SL.Click += new System.EventHandler(this.LabCL_SL_Click);
            // 
            // LabCL
            // 
            this.LabCL.BackColor = System.Drawing.Color.White;
            this.LabCL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabCL.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabCL.ForeColor = System.Drawing.Color.Black;
            this.LabCL.Location = new System.Drawing.Point(162, 209);
            this.LabCL.Name = "LabCL";
            this.LabCL.Size = new System.Drawing.Size(100, 50);
            this.LabCL.TabIndex = 105;
            this.LabCL.Text = "0.0";
            this.LabCL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabCL.Click += new System.EventHandler(this.LabCL_Click);
            // 
            // LabSL
            // 
            this.LabSL.BackColor = System.Drawing.Color.Black;
            this.LabSL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabSL.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabSL.ForeColor = System.Drawing.Color.White;
            this.LabSL.Location = new System.Drawing.Point(162, 69);
            this.LabSL.Name = "LabSL";
            this.LabSL.Size = new System.Drawing.Size(100, 50);
            this.LabSL.TabIndex = 104;
            this.LabSL.Text = "0.0";
            this.LabSL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label6.ForeColor = System.Drawing.Color.White;
            this.Label6.Location = new System.Drawing.Point(267, 224);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(80, 20);
            this.Label6.TabIndex = 103;
            this.Label6.Text = "mm/hr";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(267, 84);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(80, 20);
            this.Label5.TabIndex = 102;
            this.Label5.Text = "mm/hr";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(37, 224);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(120, 20);
            this.Label3.TabIndex = 101;
            this.Label3.Text = "埚升速度";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(37, 154);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(120, 20);
            this.Label2.TabIndex = 100;
            this.Label2.Text = "CL/SL";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(37, 84);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(120, 20);
            this.Label1.TabIndex = 99;
            this.Label1.Text = "晶升速度";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabName
            // 
            this.LabName.BackColor = System.Drawing.Color.Transparent;
            this.LabName.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabName.ForeColor = System.Drawing.Color.White;
            this.LabName.Location = new System.Drawing.Point(70, 17);
            this.LabName.Name = "LabName";
            this.LabName.Size = new System.Drawing.Size(245, 31);
            this.LabName.TabIndex = 98;
            this.LabName.Text = "埚跟比控制";
            this.LabName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmCLSL
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(394, 380);
            this.Controls.Add(this.BtnFixed);
            this.Controls.Add(this.BtnOFF);
            this.Controls.Add(this.BtnON);
            this.Controls.Add(this.BtnAuto);
            this.Controls.Add(this.LabCL_SL);
            this.Controls.Add(this.LabCL);
            this.Controls.Add(this.LabSL);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.LabName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCLSL";
            this.Text = "FrmCLSL";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button BtnFixed;
        internal System.Windows.Forms.Button BtnOFF;
        internal System.Windows.Forms.Button BtnON;
        internal System.Windows.Forms.Button BtnAuto;
        internal System.Windows.Forms.Label LabCL_SL;
        internal System.Windows.Forms.Label LabCL;
        internal System.Windows.Forms.Label LabSL;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label LabName;
        private System.Windows.Forms.Timer Timer1;
    }
}