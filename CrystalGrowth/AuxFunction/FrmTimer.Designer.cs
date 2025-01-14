
namespace CrystalGrowth.AuxFunction
{
    partial class FrmTimer
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
            this.Panel1 = new System.Windows.Forms.Panel();
            this.LabTimerTxt = new System.Windows.Forms.Label();
            this.LabMinute = new System.Windows.Forms.Label();
            this.LabMinuteTxt = new System.Windows.Forms.Label();
            this.LabName = new System.Windows.Forms.Label();
            this.BtnOFF = new System.Windows.Forms.Button();
            this.BtnON = new System.Windows.Forms.Button();
            this.LabHour = new System.Windows.Forms.Label();
            this.LabHourTxt = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.DarkGray;
            this.Panel1.Controls.Add(this.LabTimerTxt);
            this.Panel1.Controls.Add(this.LabMinute);
            this.Panel1.Controls.Add(this.LabMinuteTxt);
            this.Panel1.Controls.Add(this.LabName);
            this.Panel1.Controls.Add(this.BtnOFF);
            this.Panel1.Controls.Add(this.BtnON);
            this.Panel1.Controls.Add(this.LabHour);
            this.Panel1.Controls.Add(this.LabHourTxt);
            this.Panel1.Location = new System.Drawing.Point(10, 37);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(520, 535);
            this.Panel1.TabIndex = 5;
            // 
            // LabTimerTxt
            // 
            this.LabTimerTxt.BackColor = System.Drawing.Color.Transparent;
            this.LabTimerTxt.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabTimerTxt.ForeColor = System.Drawing.Color.White;
            this.LabTimerTxt.Location = new System.Drawing.Point(210, 231);
            this.LabTimerTxt.Name = "LabTimerTxt";
            this.LabTimerTxt.Size = new System.Drawing.Size(106, 22);
            this.LabTimerTxt.TabIndex = 69;
            this.LabTimerTxt.Text = "倒计时";
            this.LabTimerTxt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabMinute
            // 
            this.LabMinute.BackColor = System.Drawing.Color.White;
            this.LabMinute.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabMinute.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabMinute.ForeColor = System.Drawing.Color.Black;
            this.LabMinute.Location = new System.Drawing.Point(323, 215);
            this.LabMinute.Name = "LabMinute";
            this.LabMinute.Size = new System.Drawing.Size(120, 54);
            this.LabMinute.TabIndex = 68;
            this.LabMinute.Text = "0";
            this.LabMinute.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabMinute.TextChanged += new System.EventHandler(this.LabMinute_TextChanged);
            this.LabMinute.Click += new System.EventHandler(this.LabMinute_Click);
            // 
            // LabMinuteTxt
            // 
            this.LabMinuteTxt.BackColor = System.Drawing.Color.Transparent;
            this.LabMinuteTxt.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabMinuteTxt.ForeColor = System.Drawing.Color.White;
            this.LabMinuteTxt.Location = new System.Drawing.Point(323, 183);
            this.LabMinuteTxt.Name = "LabMinuteTxt";
            this.LabMinuteTxt.Size = new System.Drawing.Size(120, 22);
            this.LabMinuteTxt.TabIndex = 67;
            this.LabMinuteTxt.Text = "分钟";
            this.LabMinuteTxt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabName
            // 
            this.LabName.BackColor = System.Drawing.Color.Transparent;
            this.LabName.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabName.ForeColor = System.Drawing.Color.White;
            this.LabName.Location = new System.Drawing.Point(138, 20);
            this.LabName.Name = "LabName";
            this.LabName.Size = new System.Drawing.Size(245, 34);
            this.LabName.TabIndex = 66;
            this.LabName.Text = "倒计时器";
            this.LabName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnOFF
            // 
            this.BtnOFF.BackColor = System.Drawing.Color.Blue;
            this.BtnOFF.FlatAppearance.BorderSize = 0;
            this.BtnOFF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOFF.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnOFF.ForeColor = System.Drawing.Color.White;
            this.BtnOFF.Location = new System.Drawing.Point(327, 425);
            this.BtnOFF.Name = "BtnOFF";
            this.BtnOFF.Size = new System.Drawing.Size(100, 54);
            this.BtnOFF.TabIndex = 65;
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
            this.BtnON.Location = new System.Drawing.Point(97, 425);
            this.BtnON.Name = "BtnON";
            this.BtnON.Size = new System.Drawing.Size(100, 54);
            this.BtnON.TabIndex = 64;
            this.BtnON.Text = "ON";
            this.BtnON.UseVisualStyleBackColor = false;
            this.BtnON.Click += new System.EventHandler(this.BtnON_Click);
            // 
            // LabHour
            // 
            this.LabHour.BackColor = System.Drawing.Color.White;
            this.LabHour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabHour.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabHour.ForeColor = System.Drawing.Color.Black;
            this.LabHour.Location = new System.Drawing.Point(77, 215);
            this.LabHour.Name = "LabHour";
            this.LabHour.Size = new System.Drawing.Size(120, 54);
            this.LabHour.TabIndex = 63;
            this.LabHour.Text = "0";
            this.LabHour.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabHour.TextChanged += new System.EventHandler(this.LabHour_TextChanged);
            this.LabHour.Click += new System.EventHandler(this.LabHour_Click);
            // 
            // LabHourTxt
            // 
            this.LabHourTxt.BackColor = System.Drawing.Color.Transparent;
            this.LabHourTxt.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabHourTxt.ForeColor = System.Drawing.Color.White;
            this.LabHourTxt.Location = new System.Drawing.Point(77, 183);
            this.LabHourTxt.Name = "LabHourTxt";
            this.LabHourTxt.Size = new System.Drawing.Size(120, 22);
            this.LabHourTxt.TabIndex = 61;
            this.LabHourTxt.Text = "小时";
            this.LabHourTxt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 1000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // FrmTimer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(1350, 599);
            this.Controls.Add(this.Panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTimer";
            this.Text = "FrmTimer";
            this.Load += new System.EventHandler(this.FrmTimer_Load);
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label LabTimerTxt;
        internal System.Windows.Forms.Label LabMinute;
        internal System.Windows.Forms.Label LabMinuteTxt;
        internal System.Windows.Forms.Label LabName;
        internal System.Windows.Forms.Button BtnOFF;
        internal System.Windows.Forms.Button BtnON;
        internal System.Windows.Forms.Label LabHour;
        internal System.Windows.Forms.Label LabHourTxt;
        private System.Windows.Forms.Timer Timer1;
    }
}