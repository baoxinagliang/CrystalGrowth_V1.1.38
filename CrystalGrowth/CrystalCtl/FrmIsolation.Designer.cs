namespace CrystalGrowth.CrystalCtl
{
    partial class FrmIsolation
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
            this.LabGasFlow = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.LabPCPress = new System.Windows.Forms.Label();
            this.LabFTPress = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LabStatTime
            // 
            this.LabStatTime.BackColor = System.Drawing.Color.Black;
            this.LabStatTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabStatTime.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabStatTime.ForeColor = System.Drawing.Color.White;
            this.LabStatTime.Location = new System.Drawing.Point(221, 292);
            this.LabStatTime.Name = "LabStatTime";
            this.LabStatTime.Size = new System.Drawing.Size(120, 40);
            this.LabStatTime.TabIndex = 82;
            this.LabStatTime.Text = "00:00:00";
            this.LabStatTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabRunTime
            // 
            this.LabRunTime.BackColor = System.Drawing.Color.Black;
            this.LabRunTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabRunTime.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabRunTime.ForeColor = System.Drawing.Color.White;
            this.LabRunTime.Location = new System.Drawing.Point(221, 357);
            this.LabRunTime.Name = "LabRunTime";
            this.LabRunTime.Size = new System.Drawing.Size(120, 40);
            this.LabRunTime.TabIndex = 81;
            this.LabRunTime.Text = "00:00:00";
            this.LabRunTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabGasFlow
            // 
            this.LabGasFlow.BackColor = System.Drawing.Color.Black;
            this.LabGasFlow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabGasFlow.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabGasFlow.ForeColor = System.Drawing.Color.White;
            this.LabGasFlow.Location = new System.Drawing.Point(221, 227);
            this.LabGasFlow.Name = "LabGasFlow";
            this.LabGasFlow.Size = new System.Drawing.Size(120, 40);
            this.LabGasFlow.TabIndex = 80;
            this.LabGasFlow.Text = "0.0";
            this.LabGasFlow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label11
            // 
            this.Label11.BackColor = System.Drawing.Color.Transparent;
            this.Label11.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label11.ForeColor = System.Drawing.Color.White;
            this.Label11.Location = new System.Drawing.Point(346, 237);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(80, 20);
            this.Label11.TabIndex = 79;
            this.Label11.Text = "slpm";
            this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label13
            // 
            this.Label13.BackColor = System.Drawing.Color.Transparent;
            this.Label13.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label13.ForeColor = System.Drawing.Color.White;
            this.Label13.Location = new System.Drawing.Point(94, 367);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(120, 20);
            this.Label13.TabIndex = 78;
            this.Label13.Text = "运行时间";
            this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label14
            // 
            this.Label14.BackColor = System.Drawing.Color.Transparent;
            this.Label14.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label14.ForeColor = System.Drawing.Color.White;
            this.Label14.Location = new System.Drawing.Point(94, 302);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(120, 20);
            this.Label14.TabIndex = 77;
            this.Label14.Text = "状态时间";
            this.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label15
            // 
            this.Label15.BackColor = System.Drawing.Color.Transparent;
            this.Label15.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label15.ForeColor = System.Drawing.Color.White;
            this.Label15.Location = new System.Drawing.Point(94, 237);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(120, 20);
            this.Label15.TabIndex = 76;
            this.Label15.Text = "氩气流量";
            this.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabPCPress
            // 
            this.LabPCPress.BackColor = System.Drawing.Color.Black;
            this.LabPCPress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabPCPress.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabPCPress.ForeColor = System.Drawing.Color.White;
            this.LabPCPress.Location = new System.Drawing.Point(221, 97);
            this.LabPCPress.Name = "LabPCPress";
            this.LabPCPress.Size = new System.Drawing.Size(120, 40);
            this.LabPCPress.TabIndex = 75;
            this.LabPCPress.Text = "0.0";
            this.LabPCPress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabFTPress
            // 
            this.LabFTPress.BackColor = System.Drawing.Color.Black;
            this.LabFTPress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabFTPress.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabFTPress.ForeColor = System.Drawing.Color.White;
            this.LabFTPress.Location = new System.Drawing.Point(221, 162);
            this.LabFTPress.Name = "LabFTPress";
            this.LabFTPress.Size = new System.Drawing.Size(120, 40);
            this.LabFTPress.TabIndex = 74;
            this.LabFTPress.Text = "0.0";
            this.LabFTPress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label6.ForeColor = System.Drawing.Color.White;
            this.Label6.Location = new System.Drawing.Point(347, 172);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(80, 20);
            this.Label6.TabIndex = 73;
            this.Label6.Text = "torr";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(346, 107);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(80, 20);
            this.Label4.TabIndex = 72;
            this.Label4.Text = "torr";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(95, 172);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(120, 20);
            this.Label3.TabIndex = 71;
            this.Label3.Text = "主室压力";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(94, 107);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(120, 20);
            this.Label2.TabIndex = 70;
            this.Label2.Text = "副室压力";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 500;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // FrmIsolation
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(520, 494);
            this.Controls.Add(this.LabStatTime);
            this.Controls.Add(this.LabRunTime);
            this.Controls.Add(this.LabGasFlow);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.LabPCPress);
            this.Controls.Add(this.LabFTPress);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmIsolation";
            this.Text = "FrmIsolation";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label LabStatTime;
        internal System.Windows.Forms.Label LabRunTime;
        internal System.Windows.Forms.Label LabGasFlow;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Label LabPCPress;
        internal System.Windows.Forms.Label LabFTPress;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Timer Timer1;
    }
}