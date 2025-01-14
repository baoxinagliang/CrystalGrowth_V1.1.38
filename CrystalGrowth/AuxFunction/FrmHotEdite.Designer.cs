namespace CrystalGrowth.AuxFunction
{
    partial class FrmHotEdite
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
            this.Label2 = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ComBoxMaterial = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DTPGhangeTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DTPStartTime = new System.Windows.Forms.DateTimePicker();
            this.ComBoxChangeReason = new System.Windows.Forms.ComboBox();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.BtnCannel = new System.Windows.Forms.Button();
            this.TxtCode = new System.Windows.Forms.TextBox();
            this.LabRatedDays = new System.Windows.Forms.Label();
            this.CBoxChoice = new System.Windows.Forms.CheckBox();
            this.LabUsageTime = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(11, 13);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(141, 20);
            this.Label2.TabIndex = 77;
            this.Label2.Text = "热场件名称:";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblName
            // 
            this.LblName.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblName.ForeColor = System.Drawing.Color.White;
            this.LblName.Location = new System.Drawing.Point(153, 9);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(223, 29);
            this.LblName.TabIndex = 78;
            this.LblName.Text = "***";
            this.LblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 79;
            this.label3.Text = "材质:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ComBoxMaterial
            // 
            this.ComBoxMaterial.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ComBoxMaterial.FormattingEnabled = true;
            this.ComBoxMaterial.Items.AddRange(new object[] {
            "石墨",
            "碳碳复合材料",
            "固化毡",
            "软毡"});
            this.ComBoxMaterial.Location = new System.Drawing.Point(153, 55);
            this.ComBoxMaterial.Name = "ComBoxMaterial";
            this.ComBoxMaterial.Size = new System.Drawing.Size(223, 29);
            this.ComBoxMaterial.TabIndex = 80;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 81;
            this.label4.Text = "热场件编码:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 20);
            this.label5.TabIndex = 83;
            this.label5.Text = "额定使用寿命:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DTPGhangeTime
            // 
            this.DTPGhangeTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.DTPGhangeTime.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DTPGhangeTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPGhangeTime.Location = new System.Drawing.Point(153, 333);
            this.DTPGhangeTime.Name = "DTPGhangeTime";
            this.DTPGhangeTime.ShowUpDown = true;
            this.DTPGhangeTime.Size = new System.Drawing.Size(223, 29);
            this.DTPGhangeTime.TabIndex = 84;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(11, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 20);
            this.label6.TabIndex = 85;
            this.label6.Text = "更换原因:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(11, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 20);
            this.label7.TabIndex = 87;
            this.label7.Text = "开始使用日期:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(11, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 20);
            this.label8.TabIndex = 88;
            this.label8.Text = "更换日期:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DTPStartTime
            // 
            this.DTPStartTime.CalendarFont = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DTPStartTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.DTPStartTime.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DTPStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPStartTime.Location = new System.Drawing.Point(153, 147);
            this.DTPStartTime.Name = "DTPStartTime";
            this.DTPStartTime.ShowUpDown = true;
            this.DTPStartTime.Size = new System.Drawing.Size(223, 29);
            this.DTPStartTime.TabIndex = 89;
            // 
            // ComBoxChangeReason
            // 
            this.ComBoxChangeReason.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ComBoxChangeReason.FormattingEnabled = true;
            this.ComBoxChangeReason.Items.AddRange(new object[] {
            "材质异常",
            "事故异常",
            "人为异常",
            "首次安装"});
            this.ComBoxChangeReason.Location = new System.Drawing.Point(153, 287);
            this.ComBoxChangeReason.Name = "ComBoxChangeReason";
            this.ComBoxChangeReason.Size = new System.Drawing.Size(223, 29);
            this.ComBoxChangeReason.TabIndex = 118;
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnConfirm.BackColor = System.Drawing.Color.Blue;
            this.BtnConfirm.FlatAppearance.BorderSize = 0;
            this.BtnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirm.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnConfirm.ForeColor = System.Drawing.Color.White;
            this.BtnConfirm.Location = new System.Drawing.Point(155, 376);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(97, 46);
            this.BtnConfirm.TabIndex = 142;
            this.BtnConfirm.Text = "确认";
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
            this.BtnCannel.Location = new System.Drawing.Point(282, 376);
            this.BtnCannel.Name = "BtnCannel";
            this.BtnCannel.Size = new System.Drawing.Size(97, 46);
            this.BtnCannel.TabIndex = 143;
            this.BtnCannel.Text = "取消";
            this.BtnCannel.UseVisualStyleBackColor = false;
            this.BtnCannel.Click += new System.EventHandler(this.BtnCannel_Click);
            // 
            // TxtCode
            // 
            this.TxtCode.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtCode.Location = new System.Drawing.Point(153, 101);
            this.TxtCode.Name = "TxtCode";
            this.TxtCode.Size = new System.Drawing.Size(223, 29);
            this.TxtCode.TabIndex = 0;
            this.TxtCode.TextChanged += new System.EventHandler(this.TxtCode_TextChanged);
            // 
            // LabRatedDays
            // 
            this.LabRatedDays.BackColor = System.Drawing.Color.White;
            this.LabRatedDays.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabRatedDays.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabRatedDays.ForeColor = System.Drawing.Color.Black;
            this.LabRatedDays.Location = new System.Drawing.Point(153, 193);
            this.LabRatedDays.Name = "LabRatedDays";
            this.LabRatedDays.Size = new System.Drawing.Size(223, 29);
            this.LabRatedDays.TabIndex = 147;
            this.LabRatedDays.Text = "0";
            this.LabRatedDays.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabRatedDays.Click += new System.EventHandler(this.LabRatedDays_Click);
            // 
            // CBoxChoice
            // 
            this.CBoxChoice.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CBoxChoice.ForeColor = System.Drawing.Color.White;
            this.CBoxChoice.Location = new System.Drawing.Point(15, 379);
            this.CBoxChoice.Name = "CBoxChoice";
            this.CBoxChoice.Size = new System.Drawing.Size(110, 46);
            this.CBoxChoice.TabIndex = 148;
            this.CBoxChoice.Text = "更换配件";
            this.CBoxChoice.UseVisualStyleBackColor = true;
            this.CBoxChoice.Click += new System.EventHandler(this.CBoxChoice_Click);
            // 
            // LabUsageTime
            // 
            this.LabUsageTime.BackColor = System.Drawing.Color.White;
            this.LabUsageTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabUsageTime.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabUsageTime.ForeColor = System.Drawing.Color.Black;
            this.LabUsageTime.Location = new System.Drawing.Point(153, 240);
            this.LabUsageTime.Name = "LabUsageTime";
            this.LabUsageTime.Size = new System.Drawing.Size(223, 29);
            this.LabUsageTime.TabIndex = 150;
            this.LabUsageTime.Text = "0";
            this.LabUsageTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(11, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 20);
            this.label9.TabIndex = 149;
            this.label9.Text = "使用时间:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmHotEdite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(384, 435);
            this.ControlBox = false;
            this.Controls.Add(this.LabUsageTime);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CBoxChoice);
            this.Controls.Add(this.LabRatedDays);
            this.Controls.Add(this.TxtCode);
            this.Controls.Add(this.BtnCannel);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.ComBoxChangeReason);
            this.Controls.Add(this.DTPStartTime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DTPGhangeTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ComBoxMaterial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.Label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmHotEdite";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "变更配件";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmHotEdite_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label LblName;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComBoxMaterial;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DTPGhangeTime;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker DTPStartTime;
        private System.Windows.Forms.ComboBox ComBoxChangeReason;
        internal System.Windows.Forms.Button BtnConfirm;
        internal System.Windows.Forms.Button BtnCannel;
        private System.Windows.Forms.TextBox TxtCode;
        internal System.Windows.Forms.Label LabRatedDays;
        private System.Windows.Forms.CheckBox CBoxChoice;
        internal System.Windows.Forms.Label LabUsageTime;
        internal System.Windows.Forms.Label label9;
    }
}