namespace CrystalGrowth.CrystalCtl
{
    partial class FrmSaveProtected
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
            this.LabAckNote = new System.Windows.Forms.Label();
            this.LabCountDown = new System.Windows.Forms.Label();
            this.LabCountDownUnit = new System.Windows.Forms.Label();
            this.LabCountDownTxt = new System.Windows.Forms.Label();
            this.BtnAck = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnErrHandle = new System.Windows.Forms.Button();
            this.BtnAckSafe = new System.Windows.Forms.Button();
            this.LabName = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LabAckNote
            // 
            this.LabAckNote.BackColor = System.Drawing.Color.IndianRed;
            this.LabAckNote.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabAckNote.ForeColor = System.Drawing.Color.White;
            this.LabAckNote.Location = new System.Drawing.Point(28, 147);
            this.LabAckNote.Name = "LabAckNote";
            this.LabAckNote.Size = new System.Drawing.Size(325, 31);
            this.LabAckNote.TabIndex = 150;
            this.LabAckNote.Text = "请确认是否处理？";
            this.LabAckNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabCountDown
            // 
            this.LabCountDown.BackColor = System.Drawing.Color.Black;
            this.LabCountDown.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabCountDown.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabCountDown.ForeColor = System.Drawing.Color.White;
            this.LabCountDown.Location = new System.Drawing.Point(178, 75);
            this.LabCountDown.Name = "LabCountDown";
            this.LabCountDown.Size = new System.Drawing.Size(100, 50);
            this.LabCountDown.TabIndex = 149;
            this.LabCountDown.Text = "0";
            this.LabCountDown.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabCountDownUnit
            // 
            this.LabCountDownUnit.BackColor = System.Drawing.Color.Transparent;
            this.LabCountDownUnit.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabCountDownUnit.ForeColor = System.Drawing.Color.White;
            this.LabCountDownUnit.Location = new System.Drawing.Point(283, 90);
            this.LabCountDownUnit.Name = "LabCountDownUnit";
            this.LabCountDownUnit.Size = new System.Drawing.Size(80, 20);
            this.LabCountDownUnit.TabIndex = 148;
            this.LabCountDownUnit.Text = "s";
            this.LabCountDownUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabCountDownTxt
            // 
            this.LabCountDownTxt.BackColor = System.Drawing.Color.Transparent;
            this.LabCountDownTxt.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabCountDownTxt.ForeColor = System.Drawing.Color.White;
            this.LabCountDownTxt.Location = new System.Drawing.Point(18, 90);
            this.LabCountDownTxt.Name = "LabCountDownTxt";
            this.LabCountDownTxt.Size = new System.Drawing.Size(155, 20);
            this.LabCountDownTxt.TabIndex = 147;
            this.LabCountDownTxt.Text = "自动处理倒计时";
            this.LabCountDownTxt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnAck
            // 
            this.BtnAck.BackColor = System.Drawing.Color.Blue;
            this.BtnAck.FlatAppearance.BorderSize = 0;
            this.BtnAck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAck.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnAck.ForeColor = System.Drawing.Color.White;
            this.BtnAck.Location = new System.Drawing.Point(203, 303);
            this.BtnAck.Name = "BtnAck";
            this.BtnAck.Size = new System.Drawing.Size(100, 55);
            this.BtnAck.TabIndex = 146;
            this.BtnAck.Text = "确定";
            this.BtnAck.UseVisualStyleBackColor = false;
            this.BtnAck.Click += new System.EventHandler(this.BtnAck_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.Blue;
            this.BtnCancel.FlatAppearance.BorderSize = 0;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(83, 303);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(100, 55);
            this.BtnCancel.TabIndex = 145;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnErrHandle
            // 
            this.BtnErrHandle.BackColor = System.Drawing.Color.Blue;
            this.BtnErrHandle.FlatAppearance.BorderSize = 0;
            this.BtnErrHandle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnErrHandle.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnErrHandle.ForeColor = System.Drawing.Color.White;
            this.BtnErrHandle.Location = new System.Drawing.Point(203, 228);
            this.BtnErrHandle.Name = "BtnErrHandle";
            this.BtnErrHandle.Size = new System.Drawing.Size(150, 55);
            this.BtnErrHandle.TabIndex = 144;
            this.BtnErrHandle.Text = "异常处理";
            this.BtnErrHandle.UseVisualStyleBackColor = false;
            this.BtnErrHandle.Click += new System.EventHandler(this.BtnErrHandle_Click);
            // 
            // BtnAckSafe
            // 
            this.BtnAckSafe.BackColor = System.Drawing.Color.Blue;
            this.BtnAckSafe.FlatAppearance.BorderSize = 0;
            this.BtnAckSafe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAckSafe.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnAckSafe.ForeColor = System.Drawing.Color.White;
            this.BtnAckSafe.Location = new System.Drawing.Point(33, 228);
            this.BtnAckSafe.Name = "BtnAckSafe";
            this.BtnAckSafe.Size = new System.Drawing.Size(150, 55);
            this.BtnAckSafe.TabIndex = 143;
            this.BtnAckSafe.Text = "确认安全";
            this.BtnAckSafe.UseVisualStyleBackColor = false;
            this.BtnAckSafe.Click += new System.EventHandler(this.BtnAckSafe_Click);
            // 
            // LabName
            // 
            this.LabName.BackColor = System.Drawing.Color.Transparent;
            this.LabName.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabName.ForeColor = System.Drawing.Color.White;
            this.LabName.Location = new System.Drawing.Point(71, 23);
            this.LabName.Name = "LabName";
            this.LabName.Size = new System.Drawing.Size(245, 31);
            this.LabName.TabIndex = 142;
            this.LabName.Text = "停电保护";
            this.LabName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 1000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // FrmSaveProtected
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(380, 380);
            this.Controls.Add(this.LabAckNote);
            this.Controls.Add(this.LabCountDown);
            this.Controls.Add(this.LabCountDownUnit);
            this.Controls.Add(this.LabCountDownTxt);
            this.Controls.Add(this.BtnAck);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnErrHandle);
            this.Controls.Add(this.BtnAckSafe);
            this.Controls.Add(this.LabName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSaveProtected";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSaveProtected";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label LabAckNote;
        internal System.Windows.Forms.Label LabCountDown;
        internal System.Windows.Forms.Label LabCountDownUnit;
        internal System.Windows.Forms.Label LabCountDownTxt;
        internal System.Windows.Forms.Button BtnAck;
        internal System.Windows.Forms.Button BtnCancel;
        internal System.Windows.Forms.Button BtnErrHandle;
        internal System.Windows.Forms.Button BtnAckSafe;
        internal System.Windows.Forms.Label LabName;
        internal System.Windows.Forms.Timer Timer1;
    }
}