namespace CrystalGrowth.CrystalCtl
{
    partial class FrmManual
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
            this.LabStatTime = new System.Windows.Forms.Label();
            this.LabRunTime = new System.Windows.Forms.Label();
            this.LabFTPress = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.LabHtrTemp = new System.Windows.Forms.Label();
            this.LabSeedSpeed = new System.Windows.Forms.Label();
            this.LabMainPower = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LabStatTime
            // 
            this.LabStatTime.BackColor = System.Drawing.Color.Black;
            this.LabStatTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabStatTime.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabStatTime.ForeColor = System.Drawing.Color.White;
            this.LabStatTime.Location = new System.Drawing.Point(221, 316);
            this.LabStatTime.Name = "LabStatTime";
            this.LabStatTime.Size = new System.Drawing.Size(120, 40);
            this.LabStatTime.TabIndex = 69;
            this.LabStatTime.Text = "00:00:00";
            this.LabStatTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabRunTime
            // 
            this.LabRunTime.BackColor = System.Drawing.Color.Black;
            this.LabRunTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabRunTime.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabRunTime.ForeColor = System.Drawing.Color.White;
            this.LabRunTime.Location = new System.Drawing.Point(221, 380);
            this.LabRunTime.Name = "LabRunTime";
            this.LabRunTime.Size = new System.Drawing.Size(120, 40);
            this.LabRunTime.TabIndex = 68;
            this.LabRunTime.Text = "00:00:00";
            this.LabRunTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabFTPress
            // 
            this.LabFTPress.BackColor = System.Drawing.Color.Black;
            this.LabFTPress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabFTPress.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabFTPress.ForeColor = System.Drawing.Color.White;
            this.LabFTPress.Location = new System.Drawing.Point(221, 252);
            this.LabFTPress.Name = "LabFTPress";
            this.LabFTPress.Size = new System.Drawing.Size(120, 40);
            this.LabFTPress.TabIndex = 67;
            this.LabFTPress.Text = "0.0";
            this.LabFTPress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label11
            // 
            this.Label11.BackColor = System.Drawing.Color.DarkGray;
            this.Label11.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label11.ForeColor = System.Drawing.Color.White;
            this.Label11.Location = new System.Drawing.Point(346, 262);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(80, 20);
            this.Label11.TabIndex = 66;
            this.Label11.Text = "torr";
            this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label13
            // 
            this.Label13.BackColor = System.Drawing.Color.DarkGray;
            this.Label13.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label13.ForeColor = System.Drawing.Color.White;
            this.Label13.Location = new System.Drawing.Point(94, 390);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(120, 20);
            this.Label13.TabIndex = 65;
            this.Label13.Text = "运行时间";
            this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label14
            // 
            this.Label14.BackColor = System.Drawing.Color.DarkGray;
            this.Label14.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label14.ForeColor = System.Drawing.Color.White;
            this.Label14.Location = new System.Drawing.Point(94, 326);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(120, 20);
            this.Label14.TabIndex = 64;
            this.Label14.Text = "状态时间";
            this.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label15
            // 
            this.Label15.BackColor = System.Drawing.Color.DarkGray;
            this.Label15.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label15.ForeColor = System.Drawing.Color.White;
            this.Label15.Location = new System.Drawing.Point(94, 262);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(120, 20);
            this.Label15.TabIndex = 63;
            this.Label15.Text = "主室压力";
            this.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabHtrTemp
            // 
            this.LabHtrTemp.BackColor = System.Drawing.Color.Black;
            this.LabHtrTemp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabHtrTemp.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabHtrTemp.ForeColor = System.Drawing.Color.White;
            this.LabHtrTemp.Location = new System.Drawing.Point(221, 124);
            this.LabHtrTemp.Name = "LabHtrTemp";
            this.LabHtrTemp.Size = new System.Drawing.Size(120, 40);
            this.LabHtrTemp.TabIndex = 62;
            this.LabHtrTemp.Text = "0.0";
            this.LabHtrTemp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabSeedSpeed
            // 
            this.LabSeedSpeed.BackColor = System.Drawing.Color.Black;
            this.LabSeedSpeed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabSeedSpeed.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabSeedSpeed.ForeColor = System.Drawing.Color.White;
            this.LabSeedSpeed.Location = new System.Drawing.Point(220, 188);
            this.LabSeedSpeed.Name = "LabSeedSpeed";
            this.LabSeedSpeed.Size = new System.Drawing.Size(120, 40);
            this.LabSeedSpeed.TabIndex = 61;
            this.LabSeedSpeed.Text = "0.0";
            this.LabSeedSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabMainPower
            // 
            this.LabMainPower.BackColor = System.Drawing.Color.Black;
            this.LabMainPower.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabMainPower.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabMainPower.ForeColor = System.Drawing.Color.White;
            this.LabMainPower.Location = new System.Drawing.Point(220, 60);
            this.LabMainPower.Name = "LabMainPower";
            this.LabMainPower.Size = new System.Drawing.Size(120, 40);
            this.LabMainPower.TabIndex = 60;
            this.LabMainPower.Text = "0.00";
            this.LabMainPower.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.DarkGray;
            this.Label6.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label6.ForeColor = System.Drawing.Color.White;
            this.Label6.Location = new System.Drawing.Point(346, 198);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(80, 20);
            this.Label6.TabIndex = 59;
            this.Label6.Text = "mm/hr";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.DarkGray;
            this.Label5.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(346, 70);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(80, 20);
            this.Label5.TabIndex = 58;
            this.Label5.Text = "KW";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.DarkGray;
            this.Label4.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(346, 134);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(80, 20);
            this.Label4.TabIndex = 57;
            this.Label4.Text = "units";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.DarkGray;
            this.Label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(94, 198);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(120, 20);
            this.Label3.TabIndex = 56;
            this.Label3.Text = "晶升速度";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.DarkGray;
            this.Label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(94, 134);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(120, 20);
            this.Label2.TabIndex = 55;
            this.Label2.Text = "热场温度";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.DarkGray;
            this.Label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(94, 70);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(120, 20);
            this.Label1.TabIndex = 54;
            this.Label1.Text = "主功率";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 500;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // FrmManual
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(520, 494);
            this.Controls.Add(this.LabStatTime);
            this.Controls.Add(this.LabRunTime);
            this.Controls.Add(this.LabFTPress);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.LabHtrTemp);
            this.Controls.Add(this.LabSeedSpeed);
            this.Controls.Add(this.LabMainPower);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmManual";
            this.Text = "FrmManual";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label LabStatTime;
        internal System.Windows.Forms.Label LabRunTime;
        internal System.Windows.Forms.Label LabFTPress;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Label LabHtrTemp;
        internal System.Windows.Forms.Label LabSeedSpeed;
        internal System.Windows.Forms.Label LabMainPower;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Timer Timer1;
    }
}