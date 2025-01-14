namespace CrystalGrowth.CrystalCtl
{
    partial class FrmMsgBox
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
            this.LabInfo = new System.Windows.Forms.Label();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.BtnCannel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabInfo
            // 
            this.LabInfo.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabInfo.ForeColor = System.Drawing.Color.Red;
            this.LabInfo.Location = new System.Drawing.Point(48, 42);
            this.LabInfo.Name = "LabInfo";
            this.LabInfo.Size = new System.Drawing.Size(297, 93);
            this.LabInfo.TabIndex = 0;
            this.LabInfo.Text = "Info";
            this.LabInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnConfirm.BackColor = System.Drawing.Color.Blue;
            this.BtnConfirm.FlatAppearance.BorderSize = 0;
            this.BtnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirm.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnConfirm.ForeColor = System.Drawing.Color.White;
            this.BtnConfirm.Location = new System.Drawing.Point(65, 161);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(106, 59);
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
            this.BtnCannel.Location = new System.Drawing.Point(219, 161);
            this.BtnCannel.Name = "BtnCannel";
            this.BtnCannel.Size = new System.Drawing.Size(106, 59);
            this.BtnCannel.TabIndex = 142;
            this.BtnCannel.Text = "取消";
            this.BtnCannel.UseVisualStyleBackColor = false;
            this.BtnCannel.Click += new System.EventHandler(this.BtnCannel_Click);
            // 
            // FrmMsgBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.ControlBox = false;
            this.Controls.Add(this.BtnCannel);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.LabInfo);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmMsgBox";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "告警提示";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabInfo;
        internal System.Windows.Forms.Button BtnConfirm;
        internal System.Windows.Forms.Button BtnCannel;
    }
}