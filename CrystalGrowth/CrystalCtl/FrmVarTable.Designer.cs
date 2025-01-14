namespace CrystalGrowth.CrystalCtl
{
    partial class FrmVarTable
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.Panel1 = new System.Windows.Forms.Panel();
            this.LabAckNote = new System.Windows.Forms.Label();
            this.LabCountDown = new System.Windows.Forms.Label();
            this.LabCountDownUnit = new System.Windows.Forms.Label();
            this.LabCountDownTxt = new System.Windows.Forms.Label();
            this.BtnAck = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnErrHandle = new System.Windows.Forms.Button();
            this.BtnAckSafe = new System.Windows.Forms.Button();
            this.LabName = new System.Windows.Forms.Label();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 1000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.DarkGray;
            this.Panel1.Controls.Add(this.LabAckNote);
            this.Panel1.Controls.Add(this.LabCountDown);
            this.Panel1.Controls.Add(this.LabCountDownUnit);
            this.Panel1.Controls.Add(this.LabCountDownTxt);
            this.Panel1.Controls.Add(this.BtnAck);
            this.Panel1.Controls.Add(this.BtnCancel);
            this.Panel1.Controls.Add(this.BtnErrHandle);
            this.Panel1.Controls.Add(this.BtnAckSafe);
            this.Panel1.Controls.Add(this.LabName);
            this.Panel1.Location = new System.Drawing.Point(1, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(380, 380);
            this.Panel1.TabIndex = 35;
            // 
            // LabAckNote
            // 
            this.LabAckNote.BackColor = System.Drawing.Color.Transparent;
            this.LabAckNote.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabAckNote.ForeColor = System.Drawing.Color.White;
            this.LabAckNote.Location = new System.Drawing.Point(28, 142);
            this.LabAckNote.Name = "LabAckNote";
            this.LabAckNote.Size = new System.Drawing.Size(325, 31);
            this.LabAckNote.TabIndex = 141;
            this.LabAckNote.Text = "请确认是否处理？";
            this.LabAckNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabCountDown
            // 
            this.LabCountDown.BackColor = System.Drawing.Color.Black;
            this.LabCountDown.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabCountDown.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabCountDown.ForeColor = System.Drawing.Color.White;
            this.LabCountDown.Location = new System.Drawing.Point(178, 70);
            this.LabCountDown.Name = "LabCountDown";
            this.LabCountDown.Size = new System.Drawing.Size(100, 50);
            this.LabCountDown.TabIndex = 140;
            this.LabCountDown.Text = "0";
            this.LabCountDown.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabCountDownUnit
            // 
            this.LabCountDownUnit.BackColor = System.Drawing.Color.Transparent;
            this.LabCountDownUnit.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabCountDownUnit.ForeColor = System.Drawing.Color.White;
            this.LabCountDownUnit.Location = new System.Drawing.Point(283, 85);
            this.LabCountDownUnit.Name = "LabCountDownUnit";
            this.LabCountDownUnit.Size = new System.Drawing.Size(80, 20);
            this.LabCountDownUnit.TabIndex = 139;
            this.LabCountDownUnit.Text = "s";
            this.LabCountDownUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabCountDownTxt
            // 
            this.LabCountDownTxt.BackColor = System.Drawing.Color.Transparent;
            this.LabCountDownTxt.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabCountDownTxt.ForeColor = System.Drawing.Color.White;
            this.LabCountDownTxt.Location = new System.Drawing.Point(18, 85);
            this.LabCountDownTxt.Name = "LabCountDownTxt";
            this.LabCountDownTxt.Size = new System.Drawing.Size(155, 20);
            this.LabCountDownTxt.TabIndex = 138;
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
            this.BtnAck.Location = new System.Drawing.Point(203, 298);
            this.BtnAck.Name = "BtnAck";
            this.BtnAck.Size = new System.Drawing.Size(100, 55);
            this.BtnAck.TabIndex = 137;
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
            this.BtnCancel.Location = new System.Drawing.Point(83, 298);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(100, 55);
            this.BtnCancel.TabIndex = 136;
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
            this.BtnErrHandle.Location = new System.Drawing.Point(203, 223);
            this.BtnErrHandle.Name = "BtnErrHandle";
            this.BtnErrHandle.Size = new System.Drawing.Size(150, 55);
            this.BtnErrHandle.TabIndex = 135;
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
            this.BtnAckSafe.Location = new System.Drawing.Point(33, 223);
            this.BtnAckSafe.Name = "BtnAckSafe";
            this.BtnAckSafe.Size = new System.Drawing.Size(150, 55);
            this.BtnAckSafe.TabIndex = 134;
            this.BtnAckSafe.Text = "确认安全";
            this.BtnAckSafe.UseVisualStyleBackColor = false;
            this.BtnAckSafe.Click += new System.EventHandler(this.BtnAckSafe_Click);
            // 
            // LabName
            // 
            this.LabName.BackColor = System.Drawing.Color.Transparent;
            this.LabName.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabName.ForeColor = System.Drawing.Color.White;
            this.LabName.Location = new System.Drawing.Point(71, 18);
            this.LabName.Name = "LabName";
            this.LabName.Size = new System.Drawing.Size(245, 31);
            this.LabName.TabIndex = 133;
            this.LabName.Text = "停电保护";
            this.LabName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AllowUserToResizeColumns = false;
            this.DataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridView1.ColumnHeadersVisible = false;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.DataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView1.GridColor = System.Drawing.Color.Black;
            this.DataGridView1.Location = new System.Drawing.Point(0, 0);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridView1.RowTemplate.Height = 23;
            this.DataGridView1.Size = new System.Drawing.Size(636, 485);
            this.DataGridView1.TabIndex = 34;
            this.DataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DataGridView1_MouseDoubleClick);
            // 
            // Column1
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 317;
            // 
            // Column2
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 317;
            // 
            // FrmVarTable
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(636, 485);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.DataGridView1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVarTable";
            this.Text = "FrmVarTable";
            this.Load += new System.EventHandler(this.FrmVarTable_Load);
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer Timer1;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label LabAckNote;
        internal System.Windows.Forms.Label LabCountDown;
        internal System.Windows.Forms.Label LabCountDownUnit;
        internal System.Windows.Forms.Label LabCountDownTxt;
        internal System.Windows.Forms.Button BtnAck;
        internal System.Windows.Forms.Button BtnCancel;
        internal System.Windows.Forms.Button BtnErrHandle;
        internal System.Windows.Forms.Button BtnAckSafe;
        internal System.Windows.Forms.Label LabName;
        internal System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}