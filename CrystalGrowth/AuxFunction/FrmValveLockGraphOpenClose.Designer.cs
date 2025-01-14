namespace CrystalGrowth.AuxFunction
{
    partial class FrmValveLockGraphOpenClose
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmValveLockGraphOpenClose));
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.Label25 = new System.Windows.Forms.Label();
            this.Label79 = new System.Windows.Forms.Label();
            this.Label24 = new System.Windows.Forms.Label();
            this.Label51 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.LabValve102 = new System.Windows.Forms.Label();
            this.LabValve101 = new System.Windows.Forms.Label();
            this.LabValve002 = new System.Windows.Forms.Label();
            this.LabValve001 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 500;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Label25
            // 
            this.Label25.AutoSize = true;
            this.Label25.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label25.ForeColor = System.Drawing.Color.White;
            this.Label25.Location = new System.Drawing.Point(1058, 447);
            this.Label25.Name = "Label25";
            this.Label25.Size = new System.Drawing.Size(57, 12);
            this.Label25.TabIndex = 15;
            this.Label25.Text = "隔离阀关";
            // 
            // Label79
            // 
            this.Label79.AutoSize = true;
            this.Label79.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label79.ForeColor = System.Drawing.Color.White;
            this.Label79.Location = new System.Drawing.Point(1058, 229);
            this.Label79.Name = "Label79";
            this.Label79.Size = new System.Drawing.Size(57, 12);
            this.Label79.TabIndex = 16;
            this.Label79.Text = "隔离阀开";
            // 
            // Label24
            // 
            this.Label24.ForeColor = System.Drawing.Color.White;
            this.Label24.Image = ((System.Drawing.Image)(resources.GetObject("Label24.Image")));
            this.Label24.Location = new System.Drawing.Point(1067, 410);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(32, 32);
            this.Label24.TabIndex = 9;
            this.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label51
            // 
            this.Label51.ForeColor = System.Drawing.Color.White;
            this.Label51.Image = ((System.Drawing.Image)(resources.GetObject("Label51.Image")));
            this.Label51.Location = new System.Drawing.Point(1067, 191);
            this.Label51.Name = "Label51";
            this.Label51.Size = new System.Drawing.Size(32, 32);
            this.Label51.TabIndex = 10;
            this.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label15
            // 
            this.Label15.BackColor = System.Drawing.Color.White;
            this.Label15.Location = new System.Drawing.Point(264, 403);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(3, 49);
            this.Label15.TabIndex = 5;
            // 
            // LabValve102
            // 
            this.LabValve102.BackColor = System.Drawing.Color.Red;
            this.LabValve102.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabValve102.ForeColor = System.Drawing.Color.White;
            this.LabValve102.Location = new System.Drawing.Point(713, 413);
            this.LabValve102.Name = "LabValve102";
            this.LabValve102.Size = new System.Drawing.Size(163, 28);
            this.LabValve102.TabIndex = 11;
            this.LabValve102.Text = "晶体检测开关未触发";
            this.LabValve102.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabValve101
            // 
            this.LabValve101.BackColor = System.Drawing.Color.Red;
            this.LabValve101.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabValve101.ForeColor = System.Drawing.Color.White;
            this.LabValve101.Location = new System.Drawing.Point(343, 391);
            this.LabValve101.Name = "LabValve101";
            this.LabValve101.Size = new System.Drawing.Size(160, 68);
            this.LabValve101.TabIndex = 12;
            this.LabValve101.Text = "籽晶当前位置大于\"关隔离阀保护籽晶位置\"设定值";
            this.LabValve101.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabValve002
            // 
            this.LabValve002.BackColor = System.Drawing.Color.Red;
            this.LabValve002.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabValve002.ForeColor = System.Drawing.Color.White;
            this.LabValve002.Location = new System.Drawing.Point(713, 193);
            this.LabValve002.Name = "LabValve002";
            this.LabValve002.Size = new System.Drawing.Size(163, 28);
            this.LabValve002.TabIndex = 13;
            this.LabValve002.Text = "晶体检测开关未触发";
            this.LabValve002.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabValve001
            // 
            this.LabValve001.BackColor = System.Drawing.Color.Red;
            this.LabValve001.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabValve001.ForeColor = System.Drawing.Color.White;
            this.LabValve001.Location = new System.Drawing.Point(343, 173);
            this.LabValve001.Name = "LabValve001";
            this.LabValve001.Size = new System.Drawing.Size(160, 68);
            this.LabValve001.TabIndex = 14;
            this.LabValve001.Text = "籽晶当前位置大于\"开隔离阀保护籽晶位置\"设定值";
            this.LabValve001.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(264, 184);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(3, 49);
            this.Label3.TabIndex = 6;
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.White;
            this.Label6.Location = new System.Drawing.Point(267, 425);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(800, 3);
            this.Label6.TabIndex = 7;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(267, 206);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(800, 3);
            this.Label2.TabIndex = 8;
            // 
            // FrmValveLockGraphOpenClose
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(1366, 638);
            this.Controls.Add(this.Label25);
            this.Controls.Add(this.Label79);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.LabValve102);
            this.Controls.Add(this.LabValve101);
            this.Controls.Add(this.LabValve002);
            this.Controls.Add(this.LabValve001);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label51);
            this.Controls.Add(this.Label24);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmValveLockGraphOpenClose";
            this.Text = "FrmValveLockGraphOpenClose";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Timer1;
        internal System.Windows.Forms.Label Label25;
        internal System.Windows.Forms.Label Label79;
        internal System.Windows.Forms.Label Label24;
        internal System.Windows.Forms.Label Label51;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Label LabValve102;
        internal System.Windows.Forms.Label LabValve101;
        internal System.Windows.Forms.Label LabValve002;
        internal System.Windows.Forms.Label LabValve001;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label2;
    }
}