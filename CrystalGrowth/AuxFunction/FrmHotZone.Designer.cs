namespace CrystalGrowth.AuxFunction
{
    partial class FrmHotZone
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HotZoneName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Change = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HotCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RatedDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsageTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChangeReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhangeTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblFieldSize = new System.Windows.Forms.Label();
            this.BtnOK = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(964, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "热场尺寸：";
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AllowUserToResizeColumns = false;
            this.DataGridView1.AllowUserToResizeRows = false;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.DataGridView1.ColumnHeadersHeight = 25;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.HotZoneName,
            this.Change,
            this.Material,
            this.HotCode,
            this.StartTime,
            this.RatedDays,
            this.UsageTime,
            this.ChangeReason,
            this.GhangeTime});
            this.DataGridView1.EnableHeadersVisualStyles = false;
            this.DataGridView1.GridColor = System.Drawing.Color.Black;
            this.DataGridView1.Location = new System.Drawing.Point(7, 48);
            this.DataGridView1.Name = "DataGridView1";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.DataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DataGridView1.RowTemplate.Height = 33;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DataGridView1.Size = new System.Drawing.Size(1342, 589);
            this.DataGridView1.TabIndex = 0;
            this.DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            this.DataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
            // 
            // No
            // 
            this.No.FillWeight = 43.16424F;
            this.No.HeaderText = "序号";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.No.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.No.Width = 50;
            // 
            // HotZoneName
            // 
            this.HotZoneName.FillWeight = 115.3102F;
            this.HotZoneName.HeaderText = "热场件名称";
            this.HotZoneName.Name = "HotZoneName";
            this.HotZoneName.ReadOnly = true;
            this.HotZoneName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.HotZoneName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.HotZoneName.Width = 150;
            // 
            // Change
            // 
            this.Change.DataPropertyName = "CheckFlag";
            this.Change.FalseValue = "False";
            this.Change.FillWeight = 64.97462F;
            this.Change.HeaderText = "是否更换";
            this.Change.IndeterminateValue = "False";
            this.Change.Name = "Change";
            this.Change.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Change.TrueValue = "True";
            this.Change.Width = 90;
            // 
            // Material
            // 
            this.Material.FillWeight = 115.3102F;
            this.Material.HeaderText = "材质";
            this.Material.Name = "Material";
            this.Material.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Material.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Material.Width = 150;
            // 
            // HotCode
            // 
            this.HotCode.FillWeight = 115.3102F;
            this.HotCode.HeaderText = "热场件编码";
            this.HotCode.Name = "HotCode";
            this.HotCode.ReadOnly = true;
            this.HotCode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.HotCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.HotCode.Width = 200;
            // 
            // StartTime
            // 
            this.StartTime.FillWeight = 115.3102F;
            this.StartTime.HeaderText = "开始使用时间";
            this.StartTime.Name = "StartTime";
            this.StartTime.ReadOnly = true;
            this.StartTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.StartTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.StartTime.Width = 160;
            // 
            // RatedDays
            // 
            this.RatedDays.FillWeight = 115.3102F;
            this.RatedDays.HeaderText = "额定使用时间(天)";
            this.RatedDays.Name = "RatedDays";
            this.RatedDays.ReadOnly = true;
            this.RatedDays.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RatedDays.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.RatedDays.Width = 110;
            // 
            // UsageTime
            // 
            this.UsageTime.HeaderText = "使用时间(天)";
            this.UsageTime.Name = "UsageTime";
            this.UsageTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.UsageTime.Width = 110;
            // 
            // ChangeReason
            // 
            this.ChangeReason.HeaderText = "更换原因";
            this.ChangeReason.Name = "ChangeReason";
            this.ChangeReason.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ChangeReason.Width = 158;
            // 
            // GhangeTime
            // 
            this.GhangeTime.HeaderText = "更换日期";
            this.GhangeTime.Name = "GhangeTime";
            this.GhangeTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.GhangeTime.Width = 160;
            // 
            // LblFieldSize
            // 
            this.LblFieldSize.BackColor = System.Drawing.Color.White;
            this.LblFieldSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblFieldSize.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFieldSize.ForeColor = System.Drawing.Color.Black;
            this.LblFieldSize.Location = new System.Drawing.Point(1085, 4);
            this.LblFieldSize.Name = "LblFieldSize";
            this.LblFieldSize.Size = new System.Drawing.Size(108, 40);
            this.LblFieldSize.TabIndex = 129;
            this.LblFieldSize.Text = "0";
            this.LblFieldSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblFieldSize.DoubleClick += new System.EventHandler(this.LblFieldSize_DoubleClick);
            // 
            // BtnOK
            // 
            this.BtnOK.BackColor = System.Drawing.Color.Blue;
            this.BtnOK.FlatAppearance.BorderSize = 0;
            this.BtnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOK.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnOK.ForeColor = System.Drawing.Color.White;
            this.BtnOK.Location = new System.Drawing.Point(1228, 4);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(108, 40);
            this.BtnOK.TabIndex = 130;
            this.BtnOK.Text = "确定修改";
            this.BtnOK.UseVisualStyleBackColor = false;
            this.BtnOK.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(473, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 40);
            this.button1.TabIndex = 131;
            this.button1.Text = "加热器开启";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(667, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 40);
            this.button2.TabIndex = 132;
            this.button2.Text = "加热器关闭";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmHotZone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(1350, 638);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.LblFieldSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHotZone";
            this.Text = "FrmThermalField";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmHotZone_FormClosed);
            this.Load += new System.EventHandler(this.FrmThermalField_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.Label LblFieldSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn HotZoneName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Change;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn HotCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn RatedDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsageTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChangeReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhangeTime;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}