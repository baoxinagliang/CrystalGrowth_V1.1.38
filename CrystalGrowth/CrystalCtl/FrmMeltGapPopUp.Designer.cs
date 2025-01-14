namespace CrystalGrowth.CrystalCtl
{
    partial class FrmMeltGapPopUp
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
            this.LabText = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LabText
            // 
            this.LabText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabText.BackColor = System.Drawing.Color.Transparent;
            this.LabText.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabText.ForeColor = System.Drawing.Color.White;
            this.LabText.Location = new System.Drawing.Point(168, 0);
            this.LabText.Name = "LabText";
            this.LabText.Size = new System.Drawing.Size(314, 30);
            this.LabText.TabIndex = 2;
            this.LabText.Text = "视觉液口距测量错误！";
            this.LabText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer1
            // 
            this.Timer1.Interval = 1000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // FrmMeltGapPopUp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(650, 30);
            this.Controls.Add(this.LabText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMeltGapPopUp";
            this.Text = "FrmMeltGapPopUp";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label LabText;
        private System.Windows.Forms.Timer Timer1;
    }
}