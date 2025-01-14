﻿namespace CrystalGrowth.AuxFunction.Calibration
{
    partial class FrmSR_Speed
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
            this.LabSRCalib = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.LabDateTime = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.LabGain = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.LabSRPV = new System.Windows.Forms.Label();
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
            this.Label3.Size = new System.Drawing.Size(48, 20);
            this.Label3.TabIndex = 180;
            this.Label3.Text = "rpm";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabSRCalib
            // 
            this.LabSRCalib.BackColor = System.Drawing.Color.White;
            this.LabSRCalib.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabSRCalib.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabSRCalib.ForeColor = System.Drawing.Color.Black;
            this.LabSRCalib.Location = new System.Drawing.Point(164, 135);
            this.LabSRCalib.Name = "LabSRCalib";
            this.LabSRCalib.Size = new System.Drawing.Size(100, 50);
            this.LabSRCalib.TabIndex = 179;
            this.LabSRCalib.Text = "0.0";
            this.LabSRCalib.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabSRCalib.Click += new System.EventHandler(this.LabSRCalib_Click);
            // 
            // Label10
            // 
            this.Label10.BackColor = System.Drawing.Color.Transparent;
            this.Label10.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label10.ForeColor = System.Drawing.Color.White;
            this.Label10.Location = new System.Drawing.Point(47, 150);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(112, 20);
            this.Label10.TabIndex = 178;
            this.Label10.Text = "转速校准值";
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
            this.LabDateTime.TabIndex = 177;
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
            this.Label13.TabIndex = 176;
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
            this.LabGain.TabIndex = 175;
            this.LabGain.Text = "0.00";
            this.LabGain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(269, 81);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(48, 20);
            this.Label5.TabIndex = 173;
            this.Label5.Text = "rpm";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(47, 219);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(112, 20);
            this.Label2.TabIndex = 172;
            this.Label2.Text = "增益";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabSRPV
            // 
            this.LabSRPV.BackColor = System.Drawing.Color.Black;
            this.LabSRPV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabSRPV.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabSRPV.ForeColor = System.Drawing.Color.White;
            this.LabSRPV.Location = new System.Drawing.Point(164, 66);
            this.LabSRPV.Name = "LabSRPV";
            this.LabSRPV.Size = new System.Drawing.Size(100, 50);
            this.LabSRPV.TabIndex = 174;
            this.LabSRPV.Text = "0.0";
            this.LabSRPV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(47, 81);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(112, 20);
            this.Label1.TabIndex = 171;
            this.Label1.Text = "实际转速";
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
            this.LabName.TabIndex = 170;
            this.LabName.Text = "晶转速度校准";
            this.LabName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 500;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // FrmSR_Speed
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(394, 380);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.LabSRCalib);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.LabDateTime);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.LabGain);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.LabSRPV);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.LabName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSR_Speed";
            this.Text = "FrmSR_Speed";
            this.Load += new System.EventHandler(this.FrmSR_Speed_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label LabSRCalib;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label LabDateTime;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label LabGain;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label LabSRPV;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label LabName;
        private System.Windows.Forms.Timer Timer1;
    }
}