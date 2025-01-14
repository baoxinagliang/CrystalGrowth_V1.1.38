namespace CrystalGrowth.SOP
{
    partial class FrmSaveFile
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.LabTxtName = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.BtnAck = new System.Windows.Forms.Button();
            this.LabName = new System.Windows.Forms.Label();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.DarkGray;
            this.Panel1.Controls.Add(this.LabTxtName);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Location = new System.Drawing.Point(389, 79);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(629, 109);
            this.Panel1.TabIndex = 50;
            // 
            // LabTxtName
            // 
            this.LabTxtName.BackColor = System.Drawing.Color.White;
            this.LabTxtName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabTxtName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabTxtName.ForeColor = System.Drawing.Color.Black;
            this.LabTxtName.Location = new System.Drawing.Point(133, 41);
            this.LabTxtName.Name = "LabTxtName";
            this.LabTxtName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabTxtName.Size = new System.Drawing.Size(448, 26);
            this.LabTxtName.TabIndex = 71;
            this.LabTxtName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabTxtName.Click += new System.EventHandler(this.LabTxtName_Click);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(46, 43);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(102, 23);
            this.Label1.TabIndex = 39;
            this.Label1.Text = "文件名称：";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnQuit
            // 
            this.BtnQuit.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnQuit.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnQuit.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.BtnQuit.FlatAppearance.BorderSize = 0;
            this.BtnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnQuit.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnQuit.ForeColor = System.Drawing.Color.White;
            this.BtnQuit.Location = new System.Drawing.Point(901, 0);
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.Size = new System.Drawing.Size(117, 60);
            this.BtnQuit.TabIndex = 49;
            this.BtnQuit.Text = "退出";
            this.BtnQuit.UseVisualStyleBackColor = false;
            this.BtnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // BtnAck
            // 
            this.BtnAck.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnAck.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnAck.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.BtnAck.FlatAppearance.BorderSize = 0;
            this.BtnAck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAck.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnAck.ForeColor = System.Drawing.Color.White;
            this.BtnAck.Location = new System.Drawing.Point(645, 0);
            this.BtnAck.Name = "BtnAck";
            this.BtnAck.Size = new System.Drawing.Size(117, 60);
            this.BtnAck.TabIndex = 48;
            this.BtnAck.Text = "确定";
            this.BtnAck.UseVisualStyleBackColor = false;
            this.BtnAck.Click += new System.EventHandler(this.BtnAck_Click);
            // 
            // LabName
            // 
            this.LabName.BackColor = System.Drawing.Color.Transparent;
            this.LabName.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabName.ForeColor = System.Drawing.Color.White;
            this.LabName.Location = new System.Drawing.Point(5, 55);
            this.LabName.Name = "LabName";
            this.LabName.Size = new System.Drawing.Size(93, 23);
            this.LabName.TabIndex = 47;
            this.LabName.Text = "工艺文件";
            this.LabName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToResizeColumns = false;
            this.DataGridView1.AllowUserToResizeRows = false;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridView1.ColumnHeadersVisible = false;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView1.GridColor = System.Drawing.Color.White;
            this.DataGridView1.Location = new System.Drawing.Point(5, 79);
            this.DataGridView1.MultiSelect = false;
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridView1.RowTemplate.Height = 30;
            this.DataGridView1.Size = new System.Drawing.Size(378, 550);
            this.DataGridView1.TabIndex = 46;
            // 
            // Column1
            // 
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 375;
            // 
            // FrmSaveFile
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(1366, 638);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.BtnQuit);
            this.Controls.Add(this.BtnAck);
            this.Controls.Add(this.LabName);
            this.Controls.Add(this.DataGridView1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSaveFile";
            this.Text = "FrmSaveFile";
            this.Load += new System.EventHandler(this.FrmSaveFile_Load);
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label LabTxtName;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button BtnQuit;
        internal System.Windows.Forms.Button BtnAck;
        internal System.Windows.Forms.Label LabName;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}