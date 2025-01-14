namespace CrystalGrowth.CrystalCtl
{
    partial class FrmFeedManual
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.BtnCannel = new System.Windows.Forms.Button();
            this.LabTotalWeight = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(61, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "加料量：";
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnConfirm.BackColor = System.Drawing.Color.Blue;
            this.BtnConfirm.FlatAppearance.BorderSize = 0;
            this.BtnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirm.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnConfirm.ForeColor = System.Drawing.Color.White;
            this.BtnConfirm.Location = new System.Drawing.Point(65, 175);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(102, 45);
            this.BtnConfirm.TabIndex = 141;
            this.BtnConfirm.Text = "确定";
            this.BtnConfirm.UseVisualStyleBackColor = false;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // BtnCannel
            // 
            this.BtnCannel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnCannel.BackColor = System.Drawing.Color.Blue;
            this.BtnCannel.FlatAppearance.BorderSize = 0;
            this.BtnCannel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCannel.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCannel.ForeColor = System.Drawing.Color.White;
            this.BtnCannel.Location = new System.Drawing.Point(219, 175);
            this.BtnCannel.Name = "BtnCannel";
            this.BtnCannel.Size = new System.Drawing.Size(102, 45);
            this.BtnCannel.TabIndex = 142;
            this.BtnCannel.Text = "取消";
            this.BtnCannel.UseVisualStyleBackColor = false;
            this.BtnCannel.Click += new System.EventHandler(this.BtnCannel_Click);
            // 
            // LabTotalWeight
            // 
            this.LabTotalWeight.BackColor = System.Drawing.Color.White;
            this.LabTotalWeight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabTotalWeight.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabTotalWeight.ForeColor = System.Drawing.Color.Black;
            this.LabTotalWeight.Location = new System.Drawing.Point(186, 52);
            this.LabTotalWeight.Name = "LabTotalWeight";
            this.LabTotalWeight.Size = new System.Drawing.Size(100, 50);
            this.LabTotalWeight.TabIndex = 153;
            this.LabTotalWeight.Text = "0.00";
            this.LabTotalWeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabTotalWeight.Click += new System.EventHandler(this.LabTotalWeight_Click);
            // 
            // Label8
            // 
            this.Label8.BackColor = System.Drawing.Color.Transparent;
            this.Label8.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label8.ForeColor = System.Drawing.Color.Black;
            this.Label8.Location = new System.Drawing.Point(292, 67);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(41, 20);
            this.Label8.TabIndex = 157;
            this.Label8.Text = "kg";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmFeedManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.ControlBox = false;
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.LabTotalWeight);
            this.Controls.Add(this.BtnCannel);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmFeedManual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "请确认是否为手动加料";
            this.Load += new System.EventHandler(this.FrmFeedConfirm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button BtnConfirm;
        internal System.Windows.Forms.Button BtnCannel;
        internal System.Windows.Forms.Label LabTotalWeight;
        internal System.Windows.Forms.Label Label8;
    }
}