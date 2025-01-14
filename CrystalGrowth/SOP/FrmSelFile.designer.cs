namespace SOP
{
    partial class FrmSelFile
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
            this.Label4 = new System.Windows.Forms.Label();
            this.BtnExport = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.LabFileName = new System.Windows.Forms.Label();
            this.LabCreatTime = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.LabModifyTIme = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.LabName = new System.Windows.Forms.Label();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnImport = new System.Windows.Forms.Button();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.LabInfo = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Label4.Location = new System.Drawing.Point(19, 109);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(117, 23);
            this.Label4.TabIndex = 42;
            this.Label4.Text = "修改时间：";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnExport
            // 
            this.BtnExport.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnExport.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnExport.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.BtnExport.FlatAppearance.BorderSize = 0;
            this.BtnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExport.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnExport.ForeColor = System.Drawing.Color.White;
            this.BtnExport.Location = new System.Drawing.Point(261, 0);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(117, 60);
            this.BtnExport.TabIndex = 54;
            this.BtnExport.Text = "导出";
            this.BtnExport.UseVisualStyleBackColor = false;
            this.BtnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Black;
            this.Panel1.Controls.Add(this.LabFileName);
            this.Panel1.Controls.Add(this.LabCreatTime);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.LabModifyTIme);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.Label4);
            this.Panel1.Location = new System.Drawing.Point(389, 79);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(629, 147);
            this.Panel1.TabIndex = 52;
            // 
            // LabFileName
            // 
            this.LabFileName.BackColor = System.Drawing.Color.Transparent;
            this.LabFileName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabFileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LabFileName.Location = new System.Drawing.Point(113, 18);
            this.LabFileName.Name = "LabFileName";
            this.LabFileName.Size = new System.Drawing.Size(285, 23);
            this.LabFileName.TabIndex = 40;
            this.LabFileName.Text = "----------";
            this.LabFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabCreatTime
            // 
            this.LabCreatTime.BackColor = System.Drawing.Color.Transparent;
            this.LabCreatTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabCreatTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LabCreatTime.Location = new System.Drawing.Point(113, 64);
            this.LabCreatTime.Name = "LabCreatTime";
            this.LabCreatTime.Size = new System.Drawing.Size(285, 23);
            this.LabCreatTime.TabIndex = 41;
            this.LabCreatTime.Text = "----------";
            this.LabCreatTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Label1.Location = new System.Drawing.Point(19, 17);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(117, 23);
            this.Label1.TabIndex = 38;
            this.Label1.Text = "文件名称：";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabModifyTIme
            // 
            this.LabModifyTIme.BackColor = System.Drawing.Color.Transparent;
            this.LabModifyTIme.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabModifyTIme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LabModifyTIme.Location = new System.Drawing.Point(113, 110);
            this.LabModifyTIme.Name = "LabModifyTIme";
            this.LabModifyTIme.Size = new System.Drawing.Size(285, 23);
            this.LabModifyTIme.TabIndex = 43;
            this.LabModifyTIme.Text = "----------";
            this.LabModifyTIme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Label2.Location = new System.Drawing.Point(19, 63);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(117, 23);
            this.Label2.TabIndex = 39;
            this.Label2.Text = "创建时间：";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabName
            // 
            this.LabName.BackColor = System.Drawing.Color.Transparent;
            this.LabName.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabName.ForeColor = System.Drawing.Color.White;
            this.LabName.Location = new System.Drawing.Point(5, 55);
            this.LabName.Name = "LabName";
            this.LabName.Size = new System.Drawing.Size(116, 23);
            this.LabName.TabIndex = 51;
            this.LabName.Text = "工艺文件";
            this.LabName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.BtnQuit.TabIndex = 50;
            this.BtnQuit.Text = "退出";
            this.BtnQuit.UseVisualStyleBackColor = false;
            this.BtnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnDelete.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.BtnDelete.FlatAppearance.BorderSize = 0;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(645, 0);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(117, 60);
            this.BtnDelete.TabIndex = 49;
            this.BtnDelete.Text = "删除";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnSelect
            // 
            this.BtnSelect.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnSelect.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnSelect.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.BtnSelect.FlatAppearance.BorderSize = 0;
            this.BtnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSelect.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnSelect.ForeColor = System.Drawing.Color.White;
            this.BtnSelect.Location = new System.Drawing.Point(517, 0);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(117, 60);
            this.BtnSelect.TabIndex = 48;
            this.BtnSelect.Text = "选择";
            this.BtnSelect.UseVisualStyleBackColor = false;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
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
            this.DataGridView1.TabIndex = 47;
            this.DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
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
            // BtnImport
            // 
            this.BtnImport.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnImport.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnImport.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.BtnImport.FlatAppearance.BorderSize = 0;
            this.BtnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImport.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnImport.ForeColor = System.Drawing.Color.White;
            this.BtnImport.Location = new System.Drawing.Point(133, 0);
            this.BtnImport.Name = "BtnImport";
            this.BtnImport.Size = new System.Drawing.Size(117, 60);
            this.BtnImport.TabIndex = 53;
            this.BtnImport.Text = "导入";
            this.BtnImport.UseVisualStyleBackColor = false;
            this.BtnImport.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "openFileDialog1";
            // 
            // LabInfo
            // 
            this.LabInfo.BackColor = System.Drawing.Color.Transparent;
            this.LabInfo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabInfo.ForeColor = System.Drawing.Color.Red;
            this.LabInfo.Location = new System.Drawing.Point(389, 239);
            this.LabInfo.Name = "LabInfo";
            this.LabInfo.Size = new System.Drawing.Size(412, 23);
            this.LabInfo.TabIndex = 57;
            this.LabInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmSelFile
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(1366, 638);
            this.Controls.Add(this.LabInfo);
            this.Controls.Add(this.BtnExport);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.LabName);
            this.Controls.Add(this.BtnQuit);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnSelect);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.BtnImport);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSelFile";
            this.Text = "FrmSelFile";
            this.Load += new System.EventHandler(this.FrmSelFile_Load);
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button BtnExport;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label LabFileName;
        internal System.Windows.Forms.Label LabCreatTime;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label LabModifyTIme;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label LabName;
        internal System.Windows.Forms.Button BtnQuit;
        internal System.Windows.Forms.Button BtnDelete;
        internal System.Windows.Forms.Button BtnSelect;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        internal System.Windows.Forms.Button BtnImport;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog1;
        internal System.Windows.Forms.Label LabInfo;
    }
}