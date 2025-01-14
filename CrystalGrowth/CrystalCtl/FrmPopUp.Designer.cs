namespace CrystalGrowth.CrystalCtl
{
    partial class FrmPopUp
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
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.LabText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnConfirm.BackColor = System.Drawing.Color.Blue;
            this.BtnConfirm.FlatAppearance.BorderSize = 0;
            this.BtnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirm.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnConfirm.ForeColor = System.Drawing.Color.White;
            this.BtnConfirm.Location = new System.Drawing.Point(82, 106);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(146, 53);
            this.BtnConfirm.TabIndex = 139;
            this.BtnConfirm.Text = "确认旋转完成";
            this.BtnConfirm.UseVisualStyleBackColor = false;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // LabText
            // 
            this.LabText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabText.BackColor = System.Drawing.Color.Transparent;
            this.LabText.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabText.ForeColor = System.Drawing.Color.White;
            this.LabText.Location = new System.Drawing.Point(52, 35);
            this.LabText.Name = "LabText";
            this.LabText.Size = new System.Drawing.Size(213, 42);
            this.LabText.TabIndex = 138;
            this.LabText.Text = "等待副室旋转完成！";
            this.LabText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(307, 205);
            this.ControlBox = false;
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.LabText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmPopUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "提示";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button BtnConfirm;
        internal System.Windows.Forms.Label LabText;
    }
}