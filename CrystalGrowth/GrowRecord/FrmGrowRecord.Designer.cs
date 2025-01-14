namespace CrystalGrowth.GrowRecord
{
    partial class FrmGrowRecord
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnSaveRecord = new System.Windows.Forms.Button();
            this.BtnReport = new System.Windows.Forms.Button();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnEndPage = new System.Windows.Forms.Button();
            this.BtnNextPage = new System.Windows.Forms.Button();
            this.BtnPrePage = new System.Windows.Forms.Button();
            this.BtnHomePage = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.LabPage = new System.Windows.Forms.Label();
            this.Label18 = new System.Windows.Forms.Label();
            this.LabRunNum = new System.Windows.Forms.Label();
            this.LabCrystalID = new System.Windows.Forms.Label();
            this.LabFurnaceID = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.LabEmployeeID = new System.Windows.Forms.Label();
            this.LabSOP = new System.Windows.Forms.Label();
            this.LabDate = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.LBCurAlarm = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LblJumpPage = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvAlarm = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlarm)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSaveRecord
            // 
            this.BtnSaveRecord.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnSaveRecord.FlatAppearance.BorderSize = 0;
            this.BtnSaveRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSaveRecord.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnSaveRecord.ForeColor = System.Drawing.Color.White;
            this.BtnSaveRecord.Location = new System.Drawing.Point(1255, 383);
            this.BtnSaveRecord.Name = "BtnSaveRecord";
            this.BtnSaveRecord.Size = new System.Drawing.Size(100, 55);
            this.BtnSaveRecord.TabIndex = 46;
            this.BtnSaveRecord.Text = "导出\r\n生长记录";
            this.BtnSaveRecord.UseVisualStyleBackColor = false;
            this.BtnSaveRecord.Click += new System.EventHandler(this.BtnSaveRecord_Click);
            // 
            // BtnReport
            // 
            this.BtnReport.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnReport.FlatAppearance.BorderSize = 0;
            this.BtnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReport.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnReport.ForeColor = System.Drawing.Color.White;
            this.BtnReport.Location = new System.Drawing.Point(1255, 3);
            this.BtnReport.Name = "BtnReport";
            this.BtnReport.Size = new System.Drawing.Size(100, 55);
            this.BtnReport.TabIndex = 45;
            this.BtnReport.Text = "报表";
            this.BtnReport.UseVisualStyleBackColor = false;
            this.BtnReport.Click += new System.EventHandler(this.BtnReport_Click);
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.DarkGray;
            this.Panel2.Controls.Add(this.DataGridView1);
            this.Panel2.Location = new System.Drawing.Point(623, 86);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(627, 547);
            this.Panel2.TabIndex = 44;
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToResizeColumns = false;
            this.DataGridView1.AllowUserToResizeRows = false;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridView1.ColumnHeadersVisible = false;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.DataGridView1.GridColor = System.Drawing.Color.White;
            this.DataGridView1.Location = new System.Drawing.Point(5, 9);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.Size = new System.Drawing.Size(617, 531);
            this.DataGridView1.TabIndex = 31;
            // 
            // BtnEndPage
            // 
            this.BtnEndPage.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnEndPage.FlatAppearance.BorderSize = 0;
            this.BtnEndPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEndPage.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnEndPage.ForeColor = System.Drawing.Color.White;
            this.BtnEndPage.Location = new System.Drawing.Point(1255, 578);
            this.BtnEndPage.Name = "BtnEndPage";
            this.BtnEndPage.Size = new System.Drawing.Size(100, 55);
            this.BtnEndPage.TabIndex = 43;
            this.BtnEndPage.Text = "尾页";
            this.BtnEndPage.UseVisualStyleBackColor = false;
            this.BtnEndPage.Click += new System.EventHandler(this.BtnEndPage_Click);
            // 
            // BtnNextPage
            // 
            this.BtnNextPage.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnNextPage.FlatAppearance.BorderSize = 0;
            this.BtnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNextPage.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnNextPage.ForeColor = System.Drawing.Color.White;
            this.BtnNextPage.Location = new System.Drawing.Point(1255, 478);
            this.BtnNextPage.Name = "BtnNextPage";
            this.BtnNextPage.Size = new System.Drawing.Size(100, 55);
            this.BtnNextPage.TabIndex = 42;
            this.BtnNextPage.Text = "下一页";
            this.BtnNextPage.UseVisualStyleBackColor = false;
            this.BtnNextPage.Click += new System.EventHandler(this.BtnNextPage_Click);
            // 
            // BtnPrePage
            // 
            this.BtnPrePage.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnPrePage.FlatAppearance.BorderSize = 0;
            this.BtnPrePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrePage.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnPrePage.ForeColor = System.Drawing.Color.White;
            this.BtnPrePage.Location = new System.Drawing.Point(1255, 193);
            this.BtnPrePage.Name = "BtnPrePage";
            this.BtnPrePage.Size = new System.Drawing.Size(100, 55);
            this.BtnPrePage.TabIndex = 41;
            this.BtnPrePage.Text = "上一页";
            this.BtnPrePage.UseVisualStyleBackColor = false;
            this.BtnPrePage.Click += new System.EventHandler(this.BtnPrePage_Click);
            // 
            // BtnHomePage
            // 
            this.BtnHomePage.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnHomePage.FlatAppearance.BorderSize = 0;
            this.BtnHomePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHomePage.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnHomePage.ForeColor = System.Drawing.Color.White;
            this.BtnHomePage.Location = new System.Drawing.Point(1255, 98);
            this.BtnHomePage.Name = "BtnHomePage";
            this.BtnHomePage.Size = new System.Drawing.Size(100, 55);
            this.BtnHomePage.TabIndex = 40;
            this.BtnHomePage.Text = "首页";
            this.BtnHomePage.UseVisualStyleBackColor = false;
            this.BtnHomePage.Click += new System.EventHandler(this.BtnHomePage_Click);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.DarkGray;
            this.Panel1.Controls.Add(this.LabPage);
            this.Panel1.Controls.Add(this.Label18);
            this.Panel1.Controls.Add(this.LabRunNum);
            this.Panel1.Controls.Add(this.LabCrystalID);
            this.Panel1.Controls.Add(this.LabFurnaceID);
            this.Panel1.Controls.Add(this.Label10);
            this.Panel1.Controls.Add(this.Label11);
            this.Panel1.Controls.Add(this.Label12);
            this.Panel1.Controls.Add(this.LabEmployeeID);
            this.Panel1.Controls.Add(this.LabSOP);
            this.Panel1.Controls.Add(this.LabDate);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Location = new System.Drawing.Point(623, 4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(627, 82);
            this.Panel1.TabIndex = 39;
            // 
            // LabPage
            // 
            this.LabPage.BackColor = System.Drawing.Color.Transparent;
            this.LabPage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabPage.ForeColor = System.Drawing.Color.Black;
            this.LabPage.Location = new System.Drawing.Point(547, 4);
            this.LabPage.Name = "LabPage";
            this.LabPage.Size = new System.Drawing.Size(75, 23);
            this.LabPage.TabIndex = 45;
            this.LabPage.Text = "XXXXXX";
            this.LabPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label18
            // 
            this.Label18.BackColor = System.Drawing.Color.Transparent;
            this.Label18.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label18.ForeColor = System.Drawing.Color.Black;
            this.Label18.Location = new System.Drawing.Point(493, 4);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(51, 23);
            this.Label18.TabIndex = 42;
            this.Label18.Text = "页:";
            this.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabRunNum
            // 
            this.LabRunNum.BackColor = System.Drawing.Color.Transparent;
            this.LabRunNum.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabRunNum.ForeColor = System.Drawing.Color.Black;
            this.LabRunNum.Location = new System.Drawing.Point(383, 56);
            this.LabRunNum.Name = "LabRunNum";
            this.LabRunNum.Size = new System.Drawing.Size(93, 23);
            this.LabRunNum.TabIndex = 41;
            this.LabRunNum.Text = "XXXXXX";
            this.LabRunNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabCrystalID
            // 
            this.LabCrystalID.BackColor = System.Drawing.Color.Transparent;
            this.LabCrystalID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabCrystalID.ForeColor = System.Drawing.Color.Black;
            this.LabCrystalID.Location = new System.Drawing.Point(383, 29);
            this.LabCrystalID.Name = "LabCrystalID";
            this.LabCrystalID.Size = new System.Drawing.Size(93, 23);
            this.LabCrystalID.TabIndex = 40;
            this.LabCrystalID.Text = "XXXXXX";
            this.LabCrystalID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabFurnaceID
            // 
            this.LabFurnaceID.BackColor = System.Drawing.Color.Transparent;
            this.LabFurnaceID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabFurnaceID.ForeColor = System.Drawing.Color.Black;
            this.LabFurnaceID.Location = new System.Drawing.Point(383, 4);
            this.LabFurnaceID.Name = "LabFurnaceID";
            this.LabFurnaceID.Size = new System.Drawing.Size(93, 23);
            this.LabFurnaceID.TabIndex = 39;
            this.LabFurnaceID.Text = "XXXXXX";
            this.LabFurnaceID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label10
            // 
            this.Label10.BackColor = System.Drawing.Color.Transparent;
            this.Label10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label10.ForeColor = System.Drawing.Color.Black;
            this.Label10.Location = new System.Drawing.Point(259, 56);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(128, 23);
            this.Label10.TabIndex = 38;
            this.Label10.Text = "运行次数编号:";
            this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label11
            // 
            this.Label11.BackColor = System.Drawing.Color.Transparent;
            this.Label11.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label11.ForeColor = System.Drawing.Color.Black;
            this.Label11.Location = new System.Drawing.Point(294, 29);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(93, 23);
            this.Label11.TabIndex = 37;
            this.Label11.Text = "晶体号:";
            this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label12
            // 
            this.Label12.BackColor = System.Drawing.Color.Transparent;
            this.Label12.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label12.ForeColor = System.Drawing.Color.Black;
            this.Label12.Location = new System.Drawing.Point(294, 4);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(93, 23);
            this.Label12.TabIndex = 36;
            this.Label12.Text = "炉号:";
            this.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabEmployeeID
            // 
            this.LabEmployeeID.BackColor = System.Drawing.Color.Transparent;
            this.LabEmployeeID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabEmployeeID.ForeColor = System.Drawing.Color.Black;
            this.LabEmployeeID.Location = new System.Drawing.Point(97, 56);
            this.LabEmployeeID.Name = "LabEmployeeID";
            this.LabEmployeeID.Size = new System.Drawing.Size(169, 23);
            this.LabEmployeeID.TabIndex = 35;
            this.LabEmployeeID.Text = "XXXXXX";
            this.LabEmployeeID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabSOP
            // 
            this.LabSOP.BackColor = System.Drawing.Color.Transparent;
            this.LabSOP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabSOP.ForeColor = System.Drawing.Color.Black;
            this.LabSOP.Location = new System.Drawing.Point(97, 29);
            this.LabSOP.Name = "LabSOP";
            this.LabSOP.Size = new System.Drawing.Size(169, 23);
            this.LabSOP.TabIndex = 34;
            this.LabSOP.Text = "XXXXXX";
            this.LabSOP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabDate
            // 
            this.LabDate.BackColor = System.Drawing.Color.Transparent;
            this.LabDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabDate.ForeColor = System.Drawing.Color.Black;
            this.LabDate.Location = new System.Drawing.Point(97, 4);
            this.LabDate.Name = "LabDate";
            this.LabDate.Size = new System.Drawing.Size(169, 23);
            this.LabDate.TabIndex = 33;
            this.LabDate.Text = "XXXXXX";
            this.LabDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label3.ForeColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(6, 56);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(95, 23);
            this.Label3.TabIndex = 32;
            this.Label3.Text = "员工编号:";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(6, 29);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(95, 23);
            this.Label2.TabIndex = 31;
            this.Label2.Text = "SOP:";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(6, 4);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(95, 23);
            this.Label1.TabIndex = 30;
            this.Label1.Text = "日期:";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 1000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // LBCurAlarm
            // 
            this.LBCurAlarm.BackColor = System.Drawing.Color.Black;
            this.LBCurAlarm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LBCurAlarm.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LBCurAlarm.ForeColor = System.Drawing.Color.Red;
            this.LBCurAlarm.FormattingEnabled = true;
            this.LBCurAlarm.ItemHeight = 19;
            this.LBCurAlarm.Location = new System.Drawing.Point(6, 32);
            this.LBCurAlarm.Name = "LBCurAlarm";
            this.LBCurAlarm.Size = new System.Drawing.Size(617, 285);
            this.LBCurAlarm.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(6, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(617, 27);
            this.label4.TabIndex = 48;
            this.label4.Text = "实时报警信息";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblJumpPage
            // 
            this.LblJumpPage.BackColor = System.Drawing.Color.RoyalBlue;
            this.LblJumpPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblJumpPage.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblJumpPage.Location = new System.Drawing.Point(1255, 288);
            this.LblJumpPage.Name = "LblJumpPage";
            this.LblJumpPage.Size = new System.Drawing.Size(100, 55);
            this.LblJumpPage.TabIndex = 50;
            this.LblJumpPage.Text = "1";
            this.LblJumpPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblJumpPage.Click += new System.EventHandler(this.LblJumpPage_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(6, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(617, 27);
            this.label5.TabIndex = 53;
            this.label5.Text = "历史报警信息";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvAlarm
            // 
            this.dgvAlarm.AllowUserToAddRows = false;
            this.dgvAlarm.AllowUserToDeleteRows = false;
            this.dgvAlarm.AllowUserToResizeColumns = false;
            this.dgvAlarm.AllowUserToResizeRows = false;
            this.dgvAlarm.BackgroundColor = System.Drawing.Color.Black;
            this.dgvAlarm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAlarm.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvAlarm.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAlarm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAlarm.ColumnHeadersVisible = false;
            this.dgvAlarm.Location = new System.Drawing.Point(6, 347);
            this.dgvAlarm.Name = "dgvAlarm";
            this.dgvAlarm.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlarm.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAlarm.RowHeadersVisible = false;
            this.dgvAlarm.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Red;
            this.dgvAlarm.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAlarm.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
            this.dgvAlarm.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Black;
            this.dgvAlarm.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Red;
            this.dgvAlarm.RowTemplate.Height = 27;
            this.dgvAlarm.Size = new System.Drawing.Size(617, 287);
            this.dgvAlarm.TabIndex = 54;
            // 
            // Column1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 290;
            // 
            // Column3
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 174;
            // 
            // FrmGrowRecord
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(1366, 638);
            this.Controls.Add(this.dgvAlarm);
            this.Controls.Add(this.LblJumpPage);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.LBCurAlarm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnSaveRecord);
            this.Controls.Add(this.BtnReport);
            this.Controls.Add(this.BtnEndPage);
            this.Controls.Add(this.BtnNextPage);
            this.Controls.Add(this.BtnPrePage);
            this.Controls.Add(this.BtnHomePage);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.label5);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGrowRecord";
            this.Text = "FrmGrowRecord";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmGrowRecord_FormClosed);
            this.Load += new System.EventHandler(this.FrmGrowRecord_Load);
            this.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlarm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button BtnSaveRecord;
        internal System.Windows.Forms.Button BtnReport;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.Button BtnEndPage;
        internal System.Windows.Forms.Button BtnNextPage;
        internal System.Windows.Forms.Button BtnPrePage;
        internal System.Windows.Forms.Button BtnHomePage;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label LabPage;
        internal System.Windows.Forms.Label Label18;
        internal System.Windows.Forms.Label LabRunNum;
        internal System.Windows.Forms.Label LabCrystalID;
        internal System.Windows.Forms.Label LabFurnaceID;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label LabEmployeeID;
        internal System.Windows.Forms.Label LabSOP;
        internal System.Windows.Forms.Label LabDate;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        internal System.Windows.Forms.ListBox LBCurAlarm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblJumpPage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvAlarm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}