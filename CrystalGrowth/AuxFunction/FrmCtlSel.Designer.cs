
namespace CrystalGrowth.AuxFunction
{
    partial class FrmCtlSel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Label3 = new System.Windows.Forms.Label();
            this.BtnPressCtl = new System.Windows.Forms.Button();
            this.DataGridView3 = new System.Windows.Forms.DataGridView();
            this.Column3_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Label1 = new System.Windows.Forms.Label();
            this.BtnHtrSel = new System.Windows.Forms.Button();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(695, 12);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(240, 23);
            this.Label3.TabIndex = 46;
            this.Label3.Text = "炉压控制选择";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnPressCtl
            // 
            this.BtnPressCtl.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnPressCtl.FlatAppearance.BorderSize = 0;
            this.BtnPressCtl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPressCtl.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnPressCtl.ForeColor = System.Drawing.Color.White;
            this.BtnPressCtl.Location = new System.Drawing.Point(818, 168);
            this.BtnPressCtl.Name = "BtnPressCtl";
            this.BtnPressCtl.Size = new System.Drawing.Size(117, 60);
            this.BtnPressCtl.TabIndex = 45;
            this.BtnPressCtl.Text = "选择";
            this.BtnPressCtl.UseVisualStyleBackColor = false;
            this.BtnPressCtl.Click += new System.EventHandler(this.BtnPressCtl_Click);
            // 
            // DataGridView3
            // 
            this.DataGridView3.AllowUserToAddRows = false;
            this.DataGridView3.AllowUserToResizeColumns = false;
            this.DataGridView3.AllowUserToResizeRows = false;
            this.DataGridView3.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridView3.ColumnHeadersVisible = false;
            this.DataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3_1,
            this.Column3_2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView3.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView3.GridColor = System.Drawing.Color.White;
            this.DataGridView3.Location = new System.Drawing.Point(695, 35);
            this.DataGridView3.Name = "DataGridView3";
            this.DataGridView3.ReadOnly = true;
            this.DataGridView3.RowHeadersVisible = false;
            this.DataGridView3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridView3.RowTemplate.Height = 24;
            this.DataGridView3.Size = new System.Drawing.Size(240, 120);
            this.DataGridView3.TabIndex = 44;
            this.DataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView3_CellClick);
            // 
            // Column3_1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.Column3_1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column3_1.HeaderText = "Column3_1";
            this.Column3_1.Name = "Column3_1";
            this.Column3_1.ReadOnly = true;
            this.Column3_1.Width = 190;
            // 
            // Column3_2
            // 
            this.Column3_2.HeaderText = "Column3_2";
            this.Column3_2.Name = "Column3_2";
            this.Column3_2.ReadOnly = true;
            this.Column3_2.Width = 47;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(97, 12);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(240, 23);
            this.Label1.TabIndex = 43;
            this.Label1.Text = "拉晶工艺选择";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnHtrSel
            // 
            this.BtnHtrSel.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnHtrSel.FlatAppearance.BorderSize = 0;
            this.BtnHtrSel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHtrSel.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnHtrSel.ForeColor = System.Drawing.Color.White;
            this.BtnHtrSel.Location = new System.Drawing.Point(220, 168);
            this.BtnHtrSel.Name = "BtnHtrSel";
            this.BtnHtrSel.Size = new System.Drawing.Size(117, 60);
            this.BtnHtrSel.TabIndex = 42;
            this.BtnHtrSel.Text = "选择";
            this.BtnHtrSel.UseVisualStyleBackColor = false;
            this.BtnHtrSel.Click += new System.EventHandler(this.BtnHtrSel_Click);
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
            this.Column1_1,
            this.Column1_2});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridView1.GridColor = System.Drawing.Color.White;
            this.DataGridView1.Location = new System.Drawing.Point(97, 35);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.Size = new System.Drawing.Size(240, 120);
            this.DataGridView1.TabIndex = 41;
            this.DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // Column1_1
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.Column1_1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column1_1.HeaderText = "Column1_1";
            this.Column1_1.Name = "Column1_1";
            this.Column1_1.ReadOnly = true;
            this.Column1_1.Width = 190;
            // 
            // Column1_2
            // 
            this.Column1_2.HeaderText = "Column1_2";
            this.Column1_2.Name = "Column1_2";
            this.Column1_2.ReadOnly = true;
            this.Column1_2.Width = 47;
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 500;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // FrmCtlSel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(1350, 599);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.BtnPressCtl);
            this.Controls.Add(this.DataGridView3);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.BtnHtrSel);
            this.Controls.Add(this.DataGridView1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCtlSel";
            this.Text = "FrmCtlSel";
            this.Load += new System.EventHandler(this.FrmCtlSel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button BtnPressCtl;
        internal System.Windows.Forms.DataGridView DataGridView3;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button BtnHtrSel;
        internal System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3_2;
    }
}