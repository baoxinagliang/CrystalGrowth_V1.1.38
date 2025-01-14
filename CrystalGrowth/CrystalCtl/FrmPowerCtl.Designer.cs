namespace CrystalGrowth.CrystalCtl
{
    partial class FrmPowerCtl
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
            this.Label8 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.LabNeckSP = new System.Windows.Forms.Label();
            this.LabSupplyValid = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.LabBotPV = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.BtnBotManu = new System.Windows.Forms.Button();
            this.BtnBotAuto = new System.Windows.Forms.Button();
            this.LabBotSP = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.LabName = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.LabMainPV = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.BtnMainManu = new System.Windows.Forms.Button();
            this.BtnMainAuto = new System.Windows.Forms.Button();
            this.LabMainSP = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.LabBodySP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label8
            // 
            this.Label8.BackColor = System.Drawing.Color.Transparent;
            this.Label8.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label8.ForeColor = System.Drawing.Color.White;
            this.Label8.Location = new System.Drawing.Point(34, 423);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(136, 20);
            this.Label8.TabIndex = 94;
            this.Label8.Text = "引晶功率设定";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label10
            // 
            this.Label10.BackColor = System.Drawing.Color.Transparent;
            this.Label10.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label10.ForeColor = System.Drawing.Color.White;
            this.Label10.Location = new System.Drawing.Point(280, 423);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(80, 20);
            this.Label10.TabIndex = 95;
            this.Label10.Text = "KW";
            this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabNeckSP
            // 
            this.LabNeckSP.BackColor = System.Drawing.Color.OrangeRed;
            this.LabNeckSP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabNeckSP.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabNeckSP.ForeColor = System.Drawing.Color.Black;
            this.LabNeckSP.Location = new System.Drawing.Point(174, 409);
            this.LabNeckSP.Name = "LabNeckSP";
            this.LabNeckSP.Size = new System.Drawing.Size(100, 45);
            this.LabNeckSP.TabIndex = 96;
            this.LabNeckSP.Text = "0.00";
            this.LabNeckSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabNeckSP.Click += new System.EventHandler(this.LabNeckSP_Click);
            // 
            // LabSupplyValid
            // 
            this.LabSupplyValid.BackColor = System.Drawing.Color.Transparent;
            this.LabSupplyValid.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabSupplyValid.ForeColor = System.Drawing.Color.Red;
            this.LabSupplyValid.Location = new System.Drawing.Point(80, 463);
            this.LabSupplyValid.Name = "LabSupplyValid";
            this.LabSupplyValid.Size = new System.Drawing.Size(248, 20);
            this.LabSupplyValid.TabIndex = 93;
            this.LabSupplyValid.Text = "加热电源连接失败";
            this.LabSupplyValid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(34, 279);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(136, 20);
            this.Label3.TabIndex = 86;
            this.Label3.Text = "设定底部功率";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label6.ForeColor = System.Drawing.Color.White;
            this.Label6.Location = new System.Drawing.Point(38, 221);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(132, 20);
            this.Label6.TabIndex = 85;
            this.Label6.Text = "实际底部功率";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label7.ForeColor = System.Drawing.Color.White;
            this.Label7.Location = new System.Drawing.Point(280, 279);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(80, 20);
            this.Label7.TabIndex = 87;
            this.Label7.Text = "KW";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabBotPV
            // 
            this.LabBotPV.BackColor = System.Drawing.Color.Black;
            this.LabBotPV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabBotPV.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabBotPV.ForeColor = System.Drawing.Color.White;
            this.LabBotPV.Location = new System.Drawing.Point(175, 206);
            this.LabBotPV.Name = "LabBotPV";
            this.LabBotPV.Size = new System.Drawing.Size(100, 45);
            this.LabBotPV.TabIndex = 89;
            this.LabBotPV.Text = "0.00";
            this.LabBotPV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label9
            // 
            this.Label9.BackColor = System.Drawing.Color.Transparent;
            this.Label9.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label9.ForeColor = System.Drawing.Color.White;
            this.Label9.Location = new System.Drawing.Point(280, 221);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(80, 20);
            this.Label9.TabIndex = 88;
            this.Label9.Text = "KW";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnBotManu
            // 
            this.BtnBotManu.BackColor = System.Drawing.Color.Blue;
            this.BtnBotManu.FlatAppearance.BorderSize = 0;
            this.BtnBotManu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBotManu.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnBotManu.ForeColor = System.Drawing.Color.White;
            this.BtnBotManu.Location = new System.Drawing.Point(91, 323);
            this.BtnBotManu.Name = "BtnBotManu";
            this.BtnBotManu.Size = new System.Drawing.Size(100, 35);
            this.BtnBotManu.TabIndex = 91;
            this.BtnBotManu.Text = "手动";
            this.BtnBotManu.UseVisualStyleBackColor = false;
            this.BtnBotManu.Visible = false;
            this.BtnBotManu.Click += new System.EventHandler(this.BtnBotManu_Click);
            // 
            // BtnBotAuto
            // 
            this.BtnBotAuto.BackColor = System.Drawing.Color.Blue;
            this.BtnBotAuto.FlatAppearance.BorderSize = 0;
            this.BtnBotAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBotAuto.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnBotAuto.ForeColor = System.Drawing.Color.White;
            this.BtnBotAuto.Location = new System.Drawing.Point(217, 323);
            this.BtnBotAuto.Name = "BtnBotAuto";
            this.BtnBotAuto.Size = new System.Drawing.Size(100, 35);
            this.BtnBotAuto.TabIndex = 92;
            this.BtnBotAuto.Text = "自动";
            this.BtnBotAuto.UseVisualStyleBackColor = false;
            this.BtnBotAuto.Visible = false;
            this.BtnBotAuto.Click += new System.EventHandler(this.BtnBotAuto_Click);
            // 
            // LabBotSP
            // 
            this.LabBotSP.BackColor = System.Drawing.Color.White;
            this.LabBotSP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabBotSP.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabBotSP.ForeColor = System.Drawing.Color.Black;
            this.LabBotSP.Location = new System.Drawing.Point(175, 264);
            this.LabBotSP.Name = "LabBotSP";
            this.LabBotSP.Size = new System.Drawing.Size(100, 45);
            this.LabBotSP.TabIndex = 90;
            this.LabBotSP.Text = "0.00";
            this.LabBotSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabBotSP.Click += new System.EventHandler(this.LabBotSP_Click);
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(50, 112);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(120, 20);
            this.Label2.TabIndex = 78;
            this.Label2.Text = "设定主功率";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(50, 59);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(120, 20);
            this.Label1.TabIndex = 77;
            this.Label1.Text = "实际主功率";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabName
            // 
            this.LabName.BackColor = System.Drawing.Color.Transparent;
            this.LabName.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabName.ForeColor = System.Drawing.Color.White;
            this.LabName.Location = new System.Drawing.Point(83, 8);
            this.LabName.Name = "LabName";
            this.LabName.Size = new System.Drawing.Size(245, 31);
            this.LabName.TabIndex = 76;
            this.LabName.Text = "加热器功率";
            this.LabName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(280, 112);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(80, 20);
            this.Label4.TabIndex = 79;
            this.Label4.Text = "KW";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabMainPV
            // 
            this.LabMainPV.BackColor = System.Drawing.Color.Black;
            this.LabMainPV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabMainPV.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabMainPV.ForeColor = System.Drawing.Color.White;
            this.LabMainPV.Location = new System.Drawing.Point(175, 44);
            this.LabMainPV.Name = "LabMainPV";
            this.LabMainPV.Size = new System.Drawing.Size(100, 45);
            this.LabMainPV.TabIndex = 81;
            this.LabMainPV.Text = "0.00";
            this.LabMainPV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(280, 59);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(80, 20);
            this.Label5.TabIndex = 80;
            this.Label5.Text = "KW";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnMainManu
            // 
            this.BtnMainManu.BackColor = System.Drawing.Color.Blue;
            this.BtnMainManu.FlatAppearance.BorderSize = 0;
            this.BtnMainManu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMainManu.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnMainManu.ForeColor = System.Drawing.Color.White;
            this.BtnMainManu.Location = new System.Drawing.Point(91, 156);
            this.BtnMainManu.Name = "BtnMainManu";
            this.BtnMainManu.Size = new System.Drawing.Size(100, 35);
            this.BtnMainManu.TabIndex = 83;
            this.BtnMainManu.Text = "手动";
            this.BtnMainManu.UseVisualStyleBackColor = false;
            this.BtnMainManu.Visible = false;
            this.BtnMainManu.Click += new System.EventHandler(this.BtnMainManu_Click);
            // 
            // BtnMainAuto
            // 
            this.BtnMainAuto.BackColor = System.Drawing.Color.Blue;
            this.BtnMainAuto.FlatAppearance.BorderSize = 0;
            this.BtnMainAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMainAuto.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnMainAuto.ForeColor = System.Drawing.Color.White;
            this.BtnMainAuto.Location = new System.Drawing.Point(217, 156);
            this.BtnMainAuto.Name = "BtnMainAuto";
            this.BtnMainAuto.Size = new System.Drawing.Size(100, 35);
            this.BtnMainAuto.TabIndex = 84;
            this.BtnMainAuto.Text = "自动";
            this.BtnMainAuto.UseVisualStyleBackColor = false;
            this.BtnMainAuto.Visible = false;
            this.BtnMainAuto.Click += new System.EventHandler(this.BtnMainAuto_Click);
            // 
            // LabMainSP
            // 
            this.LabMainSP.BackColor = System.Drawing.Color.White;
            this.LabMainSP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabMainSP.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabMainSP.ForeColor = System.Drawing.Color.Black;
            this.LabMainSP.Location = new System.Drawing.Point(175, 97);
            this.LabMainSP.Name = "LabMainSP";
            this.LabMainSP.Size = new System.Drawing.Size(100, 45);
            this.LabMainSP.TabIndex = 82;
            this.LabMainSP.Text = "0.00";
            this.LabMainSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabMainSP.Click += new System.EventHandler(this.LabMainSP_Click);
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 500;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(40, 371);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 28);
            this.label11.TabIndex = 97;
            this.label11.Text = "等径头部功率";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(279, 376);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 20);
            this.label12.TabIndex = 98;
            this.label12.Text = "KW";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabBodySP
            // 
            this.LabBodySP.BackColor = System.Drawing.Color.OrangeRed;
            this.LabBodySP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabBodySP.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabBodySP.ForeColor = System.Drawing.Color.Black;
            this.LabBodySP.Location = new System.Drawing.Point(173, 361);
            this.LabBodySP.Name = "LabBodySP";
            this.LabBodySP.Size = new System.Drawing.Size(100, 45);
            this.LabBodySP.TabIndex = 99;
            this.LabBodySP.Text = "0.00";
            this.LabBodySP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabBodySP.Click += new System.EventHandler(this.LabBodySP_Click);
            // 
            // FrmPowerCtl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(394, 494);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.LabBodySP);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.LabNeckSP);
            this.Controls.Add(this.LabSupplyValid);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.LabBotPV);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.BtnBotManu);
            this.Controls.Add(this.BtnBotAuto);
            this.Controls.Add(this.LabBotSP);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.LabName);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.LabMainPV);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.BtnMainManu);
            this.Controls.Add(this.BtnMainAuto);
            this.Controls.Add(this.LabMainSP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPowerCtl";
            this.Text = "FrmPowerCtl";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label LabNeckSP;
        internal System.Windows.Forms.Label LabSupplyValid;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label LabBotPV;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Button BtnBotManu;
        internal System.Windows.Forms.Button BtnBotAuto;
        internal System.Windows.Forms.Label LabBotSP;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label LabName;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label LabMainPV;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Button BtnMainManu;
        internal System.Windows.Forms.Button BtnMainAuto;
        internal System.Windows.Forms.Label LabMainSP;
        private System.Windows.Forms.Timer Timer1;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.Label LabBodySP;
    }
}