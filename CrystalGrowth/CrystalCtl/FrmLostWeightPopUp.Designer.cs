namespace CrystalGrowth.CrystalCtl
{
    partial class FrmLostWeightPopUp
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
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.LabTextMsg = new System.Windows.Forms.Label();
            this.LabTextTime = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.LabLostWeight = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnCancel.BackColor = System.Drawing.Color.Blue;
            this.BtnCancel.FlatAppearance.BorderSize = 0;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(254, 190);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(147, 62);
            this.BtnCancel.TabIndex = 140;
            this.BtnCancel.Text = "取  消";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnConfirm.BackColor = System.Drawing.Color.Blue;
            this.BtnConfirm.FlatAppearance.BorderSize = 0;
            this.BtnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirm.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnConfirm.ForeColor = System.Drawing.Color.White;
            this.BtnConfirm.Location = new System.Drawing.Point(49, 190);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(147, 62);
            this.BtnConfirm.TabIndex = 141;
            this.BtnConfirm.Text = "确  定";
            this.BtnConfirm.UseVisualStyleBackColor = false;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // LabTextMsg
            // 
            this.LabTextMsg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabTextMsg.BackColor = System.Drawing.Color.Transparent;
            this.LabTextMsg.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabTextMsg.ForeColor = System.Drawing.Color.White;
            this.LabTextMsg.Location = new System.Drawing.Point(112, 20);
            this.LabTextMsg.Name = "LabTextMsg";
            this.LabTextMsg.Size = new System.Drawing.Size(229, 42);
            this.LabTextMsg.TabIndex = 138;
            this.LabTextMsg.Text = "XXXXX";
            this.LabTextMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabTextTime
            // 
            this.LabTextTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabTextTime.BackColor = System.Drawing.Color.Transparent;
            this.LabTextTime.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabTextTime.ForeColor = System.Drawing.Color.White;
            this.LabTextTime.Location = new System.Drawing.Point(112, 70);
            this.LabTextTime.Name = "LabTextTime";
            this.LabTextTime.Size = new System.Drawing.Size(229, 42);
            this.LabTextTime.TabIndex = 139;
            this.LabTextTime.Text = "XXXXX";
            this.LabTextTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 500;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // LabLostWeight
            // 
            this.LabLostWeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabLostWeight.BackColor = System.Drawing.Color.Transparent;
            this.LabLostWeight.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabLostWeight.ForeColor = System.Drawing.Color.White;
            this.LabLostWeight.Location = new System.Drawing.Point(226, 121);
            this.LabLostWeight.Name = "LabLostWeight";
            this.LabLostWeight.Size = new System.Drawing.Size(92, 42);
            this.LabLostWeight.TabIndex = 142;
            this.LabLostWeight.Text = "XXXXX";
            this.LabLostWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(112, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 42);
            this.label1.TabIndex = 143;
            this.label1.Text = "失重重量:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(315, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 42);
            this.label2.TabIndex = 144;
            this.label2.Text = "kg";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmLostWeightPopUp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(450, 284);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabLostWeight);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.LabTextMsg);
            this.Controls.Add(this.LabTextTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLostWeightPopUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLostWeightPopUp";
            this.Load += new System.EventHandler(this.FrmLostWeightPopUp_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button BtnCancel;
        internal System.Windows.Forms.Button BtnConfirm;
        internal System.Windows.Forms.Label LabTextMsg;
        internal System.Windows.Forms.Label LabTextTime;
        private System.Windows.Forms.Timer Timer1;
        internal System.Windows.Forms.Label LabLostWeight;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label2;
    }
}