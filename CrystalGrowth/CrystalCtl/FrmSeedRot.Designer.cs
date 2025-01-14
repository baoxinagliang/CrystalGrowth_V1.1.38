namespace CrystalGrowth.CrystalCtl
{
    partial class FrmSeedRot
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
            this.BtnAux = new System.Windows.Forms.Button();
            this.BtnCCW = new System.Windows.Forms.Button();
            this.BtnCW = new System.Windows.Forms.Button();
            this.LabSP = new System.Windows.Forms.Label();
            this.LabPV = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.LabName = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.LabTorque = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnAux
            // 
            this.BtnAux.BackColor = System.Drawing.Color.Blue;
            this.BtnAux.FlatAppearance.BorderSize = 0;
            this.BtnAux.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAux.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnAux.ForeColor = System.Drawing.Color.White;
            this.BtnAux.Location = new System.Drawing.Point(263, 285);
            this.BtnAux.Name = "BtnAux";
            this.BtnAux.Size = new System.Drawing.Size(100, 55);
            this.BtnAux.TabIndex = 118;
            this.BtnAux.Text = "辅助";
            this.BtnAux.UseVisualStyleBackColor = false;
            this.BtnAux.Click += new System.EventHandler(this.BtnAux_Click);
            // 
            // BtnCCW
            // 
            this.BtnCCW.BackColor = System.Drawing.Color.Blue;
            this.BtnCCW.FlatAppearance.BorderSize = 0;
            this.BtnCCW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCCW.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCCW.ForeColor = System.Drawing.Color.White;
            this.BtnCCW.Location = new System.Drawing.Point(33, 317);
            this.BtnCCW.Name = "BtnCCW";
            this.BtnCCW.Size = new System.Drawing.Size(100, 35);
            this.BtnCCW.TabIndex = 117;
            this.BtnCCW.Text = "逆时针";
            this.BtnCCW.UseVisualStyleBackColor = false;
            this.BtnCCW.Click += new System.EventHandler(this.BtnCCW_Click);
            // 
            // BtnCW
            // 
            this.BtnCW.BackColor = System.Drawing.Color.Blue;
            this.BtnCW.FlatAppearance.BorderSize = 0;
            this.BtnCW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCW.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCW.ForeColor = System.Drawing.Color.White;
            this.BtnCW.Location = new System.Drawing.Point(33, 272);
            this.BtnCW.Name = "BtnCW";
            this.BtnCW.Size = new System.Drawing.Size(100, 35);
            this.BtnCW.TabIndex = 116;
            this.BtnCW.Text = "顺时针";
            this.BtnCW.UseVisualStyleBackColor = false;
            this.BtnCW.Click += new System.EventHandler(this.BtnCW_Click);
            // 
            // LabSP
            // 
            this.LabSP.BackColor = System.Drawing.Color.White;
            this.LabSP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabSP.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabSP.ForeColor = System.Drawing.Color.Black;
            this.LabSP.Location = new System.Drawing.Point(168, 140);
            this.LabSP.Name = "LabSP";
            this.LabSP.Size = new System.Drawing.Size(100, 50);
            this.LabSP.TabIndex = 115;
            this.LabSP.Text = "0.0";
            this.LabSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabSP.Click += new System.EventHandler(this.LabSP_Click);
            // 
            // LabPV
            // 
            this.LabPV.BackColor = System.Drawing.Color.Black;
            this.LabPV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabPV.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabPV.ForeColor = System.Drawing.Color.White;
            this.LabPV.Location = new System.Drawing.Point(168, 77);
            this.LabPV.Name = "LabPV";
            this.LabPV.Size = new System.Drawing.Size(100, 50);
            this.LabPV.TabIndex = 114;
            this.LabPV.Text = "0.0";
            this.LabPV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(273, 92);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(80, 20);
            this.Label5.TabIndex = 113;
            this.Label5.Text = "rpm";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(274, 155);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(80, 20);
            this.Label4.TabIndex = 112;
            this.Label4.Text = "rpm";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(43, 155);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(120, 20);
            this.Label2.TabIndex = 111;
            this.Label2.Text = "设定转速";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(43, 92);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(120, 20);
            this.Label1.TabIndex = 110;
            this.Label1.Text = "实际转速";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabName
            // 
            this.LabName.BackColor = System.Drawing.Color.Transparent;
            this.LabName.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabName.ForeColor = System.Drawing.Color.White;
            this.LabName.Location = new System.Drawing.Point(76, 25);
            this.LabName.Name = "LabName";
            this.LabName.Size = new System.Drawing.Size(245, 31);
            this.LabName.TabIndex = 109;
            this.LabName.Text = "晶转";
            this.LabName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 500;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(43, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 119;
            this.label3.Text = "晶转扭矩";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabTorque
            // 
            this.LabTorque.BackColor = System.Drawing.Color.Black;
            this.LabTorque.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabTorque.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabTorque.ForeColor = System.Drawing.Color.White;
            this.LabTorque.Location = new System.Drawing.Point(168, 203);
            this.LabTorque.Name = "LabTorque";
            this.LabTorque.Size = new System.Drawing.Size(100, 50);
            this.LabTorque.TabIndex = 120;
            this.LabTorque.Text = "0.0";
            this.LabTorque.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(274, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 121;
            this.label7.Text = "%";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmSeedRot
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(394, 380);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LabTorque);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnAux);
            this.Controls.Add(this.BtnCCW);
            this.Controls.Add(this.BtnCW);
            this.Controls.Add(this.LabSP);
            this.Controls.Add(this.LabPV);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.LabName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSeedRot";
            this.Text = "FrmSeedRot";
            this.Load += new System.EventHandler(this.FrmSeedRot_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button BtnAux;
        internal System.Windows.Forms.Button BtnCCW;
        internal System.Windows.Forms.Button BtnCW;
        internal System.Windows.Forms.Label LabSP;
        internal System.Windows.Forms.Label LabPV;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label LabName;
        private System.Windows.Forms.Timer Timer1;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label LabTorque;
        internal System.Windows.Forms.Label label7;
    }
}