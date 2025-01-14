namespace CrystalGrowth.GrowRecord
{
    partial class FrmHistTrend
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.Chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CBGrid = new System.Windows.Forms.CheckBox();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BtnVarSel = new System.Windows.Forms.Button();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // Chart2
            // 
            this.Chart2.BackColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.LabelStyle.Format = "yyyy-MM-dd HH:mm:ss";
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.DarkSlateGray;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisX.ScrollBar.BackColor = System.Drawing.Color.RosyBrown;
            chartArea1.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.White;
            chartArea1.AxisX.ScrollBar.ButtonStyle = System.Windows.Forms.DataVisualization.Charting.ScrollBarButtonStyles.SmallScroll;
            chartArea1.AxisX.ScrollBar.IsPositionedInside = false;
            chartArea1.AxisX.ScrollBar.Size = 20D;
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisY.IsMarginVisible = false;
            chartArea1.AxisY.LabelStyle.Enabled = false;
            chartArea1.AxisY.MajorGrid.Interval = 10D;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.DarkSlateGray;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.MajorTickMark.Enabled = false;
            chartArea1.AxisY.Maximum = 100D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 100F;
            chartArea1.Position.Width = 100F;
            this.Chart2.ChartAreas.Add(chartArea1);
            this.Chart2.Location = new System.Drawing.Point(0, 354);
            this.Chart2.Name = "Chart2";
            this.Chart2.Size = new System.Drawing.Size(1366, 284);
            this.Chart2.TabIndex = 53;
            this.Chart2.Text = "Chart2";
            // 
            // CBGrid
            // 
            this.CBGrid.AutoCheck = false;
            this.CBGrid.Checked = true;
            this.CBGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBGrid.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CBGrid.ForeColor = System.Drawing.Color.White;
            this.CBGrid.Location = new System.Drawing.Point(5, 36);
            this.CBGrid.Name = "CBGrid";
            this.CBGrid.Size = new System.Drawing.Size(93, 24);
            this.CBGrid.TabIndex = 52;
            this.CBGrid.Text = "网格线";
            this.CBGrid.UseVisualStyleBackColor = true;
            this.CBGrid.Click += new System.EventHandler(this.CBGrid_Click);
            // 
            // Chart1
            // 
            this.Chart1.BackColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea2.AxisX.IsMarginVisible = false;
            chartArea2.AxisX.LabelStyle.Format = "yyyy-MM-dd HH:mm:ss";
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.DarkSlateGray;
            chartArea2.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.AxisX.MajorTickMark.Enabled = false;
            chartArea2.AxisX.ScrollBar.BackColor = System.Drawing.Color.RosyBrown;
            chartArea2.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.White;
            chartArea2.AxisX.ScrollBar.ButtonStyle = System.Windows.Forms.DataVisualization.Charting.ScrollBarButtonStyles.SmallScroll;
            chartArea2.AxisX.ScrollBar.IsPositionedInside = false;
            chartArea2.AxisX.ScrollBar.Size = 20D;
            chartArea2.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea2.AxisY.IsMarginVisible = false;
            chartArea2.AxisY.LabelStyle.Enabled = false;
            chartArea2.AxisY.MajorGrid.Interval = 10D;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.DarkSlateGray;
            chartArea2.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.AxisY.MajorTickMark.Enabled = false;
            chartArea2.AxisY.Maximum = 100D;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.AxisY.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.BackColor = System.Drawing.Color.Black;
            chartArea2.Name = "ChartArea1";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 100F;
            chartArea2.Position.Width = 100F;
            this.Chart1.ChartAreas.Add(chartArea2);
            this.Chart1.Location = new System.Drawing.Point(0, 65);
            this.Chart1.Name = "Chart1";
            this.Chart1.Size = new System.Drawing.Size(1366, 284);
            this.Chart1.TabIndex = 49;
            this.Chart1.Text = "Chart1";
            // 
            // BtnVarSel
            // 
            this.BtnVarSel.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnVarSel.FlatAppearance.BorderSize = 0;
            this.BtnVarSel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVarSel.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnVarSel.ForeColor = System.Drawing.Color.White;
            this.BtnVarSel.Location = new System.Drawing.Point(517, 0);
            this.BtnVarSel.Name = "BtnVarSel";
            this.BtnVarSel.Size = new System.Drawing.Size(117, 60);
            this.BtnVarSel.TabIndex = 51;
            this.BtnVarSel.Text = "变量";
            this.BtnVarSel.UseVisualStyleBackColor = false;
            this.BtnVarSel.Click += new System.EventHandler(this.BtnVarSel_Click);
            // 
            // BtnQuit
            // 
            this.BtnQuit.BackColor = System.Drawing.Color.RoyalBlue;
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
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 50;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // FrmHistTrend
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(1366, 638);
            this.Controls.Add(this.Chart2);
            this.Controls.Add(this.CBGrid);
            this.Controls.Add(this.Chart1);
            this.Controls.Add(this.BtnVarSel);
            this.Controls.Add(this.BtnQuit);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHistTrend";
            this.Text = "FrmHistTrend";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmHistTrend_FormClosed);
            this.Load += new System.EventHandler(this.FrmHistTrend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataVisualization.Charting.Chart Chart2;
        internal System.Windows.Forms.CheckBox CBGrid;
        internal System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
        internal System.Windows.Forms.Button BtnVarSel;
        internal System.Windows.Forms.Button BtnQuit;
        private System.Windows.Forms.Timer Timer1;
    }
}