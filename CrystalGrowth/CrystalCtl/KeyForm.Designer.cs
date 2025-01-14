namespace CrystalGrowth.CrystalCtl
{
    partial class KeyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeyForm));
            this.LabLimit = new System.Windows.Forms.Label();
            this.BtnSub = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.LabMax = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.LabMin = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.BtnNegative = new System.Windows.Forms.Button();
            this.LabValue = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnOne = new System.Windows.Forms.Button();
            this.BtnEnter = new System.Windows.Forms.Button();
            this.BtnDot = new System.Windows.Forms.Button();
            this.BtnBackspace = new System.Windows.Forms.Button();
            this.BtnZero = new System.Windows.Forms.Button();
            this.BtnNine = new System.Windows.Forms.Button();
            this.BtnEight = new System.Windows.Forms.Button();
            this.BtnSeven = new System.Windows.Forms.Button();
            this.BtnSix = new System.Windows.Forms.Button();
            this.BtnFive = new System.Windows.Forms.Button();
            this.BtnFour = new System.Windows.Forms.Button();
            this.BtnThree = new System.Windows.Forms.Button();
            this.BtnTwo = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LabLimit
            // 
            this.LabLimit.BackColor = System.Drawing.Color.Black;
            this.LabLimit.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabLimit.ForeColor = System.Drawing.Color.Red;
            this.LabLimit.Location = new System.Drawing.Point(18, 21);
            this.LabLimit.Name = "LabLimit";
            this.LabLimit.Size = new System.Drawing.Size(73, 20);
            this.LabLimit.TabIndex = 124;
            this.LabLimit.Text = "超限";
            this.LabLimit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabLimit.Visible = false;
            // 
            // BtnSub
            // 
            this.BtnSub.BackColor = System.Drawing.Color.Blue;
            this.BtnSub.FlatAppearance.BorderSize = 0;
            this.BtnSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSub.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnSub.ForeColor = System.Drawing.Color.White;
            this.BtnSub.Image = ((System.Drawing.Image)(resources.GetObject("BtnSub.Image")));
            this.BtnSub.Location = new System.Drawing.Point(145, 93);
            this.BtnSub.Name = "BtnSub";
            this.BtnSub.Size = new System.Drawing.Size(110, 60);
            this.BtnSub.TabIndex = 123;
            this.BtnSub.UseVisualStyleBackColor = false;
            this.BtnSub.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnSub_MouseDown);
            this.BtnSub.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnSub_MouseUp);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.Blue;
            this.BtnAdd.FlatAppearance.BorderSize = 0;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdd.Image")));
            this.BtnAdd.Location = new System.Drawing.Point(275, 93);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(110, 60);
            this.BtnAdd.TabIndex = 122;
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnAdd_MouseDown);
            this.BtnAdd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnAdd_MouseUp);
            // 
            // LabMax
            // 
            this.LabMax.BackColor = System.Drawing.Color.Transparent;
            this.LabMax.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabMax.ForeColor = System.Drawing.Color.White;
            this.LabMax.Location = new System.Drawing.Point(236, 63);
            this.LabMax.Name = "LabMax";
            this.LabMax.Size = new System.Drawing.Size(105, 20);
            this.LabMax.TabIndex = 121;
            this.LabMax.Text = "0.0";
            this.LabMax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(181, 63);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(76, 20);
            this.Label5.TabIndex = 120;
            this.Label5.Text = "最大：";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabMin
            // 
            this.LabMin.BackColor = System.Drawing.Color.Transparent;
            this.LabMin.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabMin.ForeColor = System.Drawing.Color.White;
            this.LabMin.Location = new System.Drawing.Point(70, 63);
            this.LabMin.Name = "LabMin";
            this.LabMin.Size = new System.Drawing.Size(105, 20);
            this.LabMin.TabIndex = 119;
            this.LabMin.Text = "0.0";
            this.LabMin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(15, 63);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(76, 20);
            this.Label2.TabIndex = 118;
            this.Label2.Text = "最小：";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnNegative
            // 
            this.BtnNegative.BackColor = System.Drawing.Color.Blue;
            this.BtnNegative.FlatAppearance.BorderSize = 0;
            this.BtnNegative.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNegative.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNegative.ForeColor = System.Drawing.Color.White;
            this.BtnNegative.Location = new System.Drawing.Point(16, 357);
            this.BtnNegative.Name = "BtnNegative";
            this.BtnNegative.Size = new System.Drawing.Size(110, 60);
            this.BtnNegative.TabIndex = 117;
            this.BtnNegative.Text = "+/-";
            this.BtnNegative.UseVisualStyleBackColor = false;
            this.BtnNegative.Click += new System.EventHandler(this.BtnNegative_Click);
            // 
            // LabValue
            // 
            this.LabValue.BackColor = System.Drawing.Color.Black;
            this.LabValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabValue.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabValue.ForeColor = System.Drawing.Color.White;
            this.LabValue.Location = new System.Drawing.Point(16, 11);
            this.LabValue.Name = "LabValue";
            this.LabValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabValue.Size = new System.Drawing.Size(369, 40);
            this.LabValue.TabIndex = 116;
            this.LabValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.Blue;
            this.BtnCancel.FlatAppearance.BorderSize = 0;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(145, 423);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(110, 60);
            this.BtnCancel.TabIndex = 115;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnOne
            // 
            this.BtnOne.BackColor = System.Drawing.Color.Blue;
            this.BtnOne.FlatAppearance.BorderSize = 0;
            this.BtnOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOne.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOne.ForeColor = System.Drawing.Color.White;
            this.BtnOne.Location = new System.Drawing.Point(16, 291);
            this.BtnOne.Name = "BtnOne";
            this.BtnOne.Size = new System.Drawing.Size(110, 60);
            this.BtnOne.TabIndex = 114;
            this.BtnOne.Text = "1";
            this.BtnOne.UseVisualStyleBackColor = false;
            this.BtnOne.Click += new System.EventHandler(this.BtnOne_Click);
            // 
            // BtnEnter
            // 
            this.BtnEnter.BackColor = System.Drawing.Color.Blue;
            this.BtnEnter.FlatAppearance.BorderSize = 0;
            this.BtnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEnter.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnEnter.ForeColor = System.Drawing.Color.White;
            this.BtnEnter.Location = new System.Drawing.Point(275, 423);
            this.BtnEnter.Name = "BtnEnter";
            this.BtnEnter.Size = new System.Drawing.Size(110, 60);
            this.BtnEnter.TabIndex = 113;
            this.BtnEnter.Text = "输入";
            this.BtnEnter.UseVisualStyleBackColor = false;
            this.BtnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // BtnDot
            // 
            this.BtnDot.BackColor = System.Drawing.Color.Blue;
            this.BtnDot.FlatAppearance.BorderSize = 0;
            this.BtnDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDot.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDot.ForeColor = System.Drawing.Color.White;
            this.BtnDot.Location = new System.Drawing.Point(275, 357);
            this.BtnDot.Name = "BtnDot";
            this.BtnDot.Size = new System.Drawing.Size(110, 60);
            this.BtnDot.TabIndex = 112;
            this.BtnDot.Text = ".";
            this.BtnDot.UseVisualStyleBackColor = false;
            this.BtnDot.Click += new System.EventHandler(this.BtnDot_Click);
            // 
            // BtnBackspace
            // 
            this.BtnBackspace.BackColor = System.Drawing.Color.Blue;
            this.BtnBackspace.FlatAppearance.BorderSize = 0;
            this.BtnBackspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBackspace.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnBackspace.ForeColor = System.Drawing.Color.White;
            this.BtnBackspace.Image = ((System.Drawing.Image)(resources.GetObject("BtnBackspace.Image")));
            this.BtnBackspace.Location = new System.Drawing.Point(16, 93);
            this.BtnBackspace.Name = "BtnBackspace";
            this.BtnBackspace.Size = new System.Drawing.Size(110, 60);
            this.BtnBackspace.TabIndex = 111;
            this.BtnBackspace.UseVisualStyleBackColor = false;
            this.BtnBackspace.Click += new System.EventHandler(this.BtnBackspace_Click);
            // 
            // BtnZero
            // 
            this.BtnZero.BackColor = System.Drawing.Color.Blue;
            this.BtnZero.FlatAppearance.BorderSize = 0;
            this.BtnZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnZero.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnZero.ForeColor = System.Drawing.Color.White;
            this.BtnZero.Location = new System.Drawing.Point(145, 357);
            this.BtnZero.Name = "BtnZero";
            this.BtnZero.Size = new System.Drawing.Size(110, 60);
            this.BtnZero.TabIndex = 110;
            this.BtnZero.Text = "0";
            this.BtnZero.UseVisualStyleBackColor = false;
            this.BtnZero.Click += new System.EventHandler(this.BtnZero_Click);
            // 
            // BtnNine
            // 
            this.BtnNine.BackColor = System.Drawing.Color.Blue;
            this.BtnNine.FlatAppearance.BorderSize = 0;
            this.BtnNine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNine.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNine.ForeColor = System.Drawing.Color.White;
            this.BtnNine.Location = new System.Drawing.Point(275, 159);
            this.BtnNine.Name = "BtnNine";
            this.BtnNine.Size = new System.Drawing.Size(110, 60);
            this.BtnNine.TabIndex = 109;
            this.BtnNine.Text = "9";
            this.BtnNine.UseVisualStyleBackColor = false;
            this.BtnNine.Click += new System.EventHandler(this.BtnNine_Click);
            // 
            // BtnEight
            // 
            this.BtnEight.BackColor = System.Drawing.Color.Blue;
            this.BtnEight.FlatAppearance.BorderSize = 0;
            this.BtnEight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEight.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEight.ForeColor = System.Drawing.Color.White;
            this.BtnEight.Location = new System.Drawing.Point(145, 159);
            this.BtnEight.Name = "BtnEight";
            this.BtnEight.Size = new System.Drawing.Size(110, 60);
            this.BtnEight.TabIndex = 108;
            this.BtnEight.Text = "8";
            this.BtnEight.UseVisualStyleBackColor = false;
            this.BtnEight.Click += new System.EventHandler(this.BtnEight_Click);
            // 
            // BtnSeven
            // 
            this.BtnSeven.BackColor = System.Drawing.Color.Blue;
            this.BtnSeven.FlatAppearance.BorderSize = 0;
            this.BtnSeven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSeven.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeven.ForeColor = System.Drawing.Color.White;
            this.BtnSeven.Location = new System.Drawing.Point(16, 159);
            this.BtnSeven.Name = "BtnSeven";
            this.BtnSeven.Size = new System.Drawing.Size(110, 60);
            this.BtnSeven.TabIndex = 107;
            this.BtnSeven.Text = "7";
            this.BtnSeven.UseVisualStyleBackColor = false;
            this.BtnSeven.Click += new System.EventHandler(this.BtnSeven_Click);
            // 
            // BtnSix
            // 
            this.BtnSix.BackColor = System.Drawing.Color.Blue;
            this.BtnSix.FlatAppearance.BorderSize = 0;
            this.BtnSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSix.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSix.ForeColor = System.Drawing.Color.White;
            this.BtnSix.Location = new System.Drawing.Point(275, 225);
            this.BtnSix.Name = "BtnSix";
            this.BtnSix.Size = new System.Drawing.Size(110, 60);
            this.BtnSix.TabIndex = 106;
            this.BtnSix.Text = "6";
            this.BtnSix.UseVisualStyleBackColor = false;
            this.BtnSix.Click += new System.EventHandler(this.BtnSix_Click);
            // 
            // BtnFive
            // 
            this.BtnFive.BackColor = System.Drawing.Color.Blue;
            this.BtnFive.FlatAppearance.BorderSize = 0;
            this.BtnFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFive.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFive.ForeColor = System.Drawing.Color.White;
            this.BtnFive.Location = new System.Drawing.Point(145, 225);
            this.BtnFive.Name = "BtnFive";
            this.BtnFive.Size = new System.Drawing.Size(110, 60);
            this.BtnFive.TabIndex = 105;
            this.BtnFive.Text = "5";
            this.BtnFive.UseVisualStyleBackColor = false;
            this.BtnFive.Click += new System.EventHandler(this.BtnFive_Click);
            // 
            // BtnFour
            // 
            this.BtnFour.BackColor = System.Drawing.Color.Blue;
            this.BtnFour.FlatAppearance.BorderSize = 0;
            this.BtnFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFour.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFour.ForeColor = System.Drawing.Color.White;
            this.BtnFour.Location = new System.Drawing.Point(16, 225);
            this.BtnFour.Name = "BtnFour";
            this.BtnFour.Size = new System.Drawing.Size(110, 60);
            this.BtnFour.TabIndex = 104;
            this.BtnFour.Text = "4";
            this.BtnFour.UseVisualStyleBackColor = false;
            this.BtnFour.Click += new System.EventHandler(this.BtnFour_Click);
            // 
            // BtnThree
            // 
            this.BtnThree.BackColor = System.Drawing.Color.Blue;
            this.BtnThree.FlatAppearance.BorderSize = 0;
            this.BtnThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnThree.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnThree.ForeColor = System.Drawing.Color.White;
            this.BtnThree.Location = new System.Drawing.Point(275, 291);
            this.BtnThree.Name = "BtnThree";
            this.BtnThree.Size = new System.Drawing.Size(110, 60);
            this.BtnThree.TabIndex = 103;
            this.BtnThree.Text = "3";
            this.BtnThree.UseVisualStyleBackColor = false;
            this.BtnThree.Click += new System.EventHandler(this.BtnThree_Click);
            // 
            // BtnTwo
            // 
            this.BtnTwo.BackColor = System.Drawing.Color.Blue;
            this.BtnTwo.FlatAppearance.BorderSize = 0;
            this.BtnTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTwo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTwo.ForeColor = System.Drawing.Color.White;
            this.BtnTwo.Location = new System.Drawing.Point(145, 291);
            this.BtnTwo.Name = "BtnTwo";
            this.BtnTwo.Size = new System.Drawing.Size(110, 60);
            this.BtnTwo.TabIndex = 102;
            this.BtnTwo.Text = "2";
            this.BtnTwo.UseVisualStyleBackColor = false;
            this.BtnTwo.Click += new System.EventHandler(this.BtnTwo_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Blue;
            this.BtnDelete.FlatAppearance.BorderSize = 0;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(16, 423);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(110, 60);
            this.BtnDelete.TabIndex = 101;
            this.BtnDelete.Text = "清空";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // KeyForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(400, 494);
            this.Controls.Add(this.LabLimit);
            this.Controls.Add(this.BtnSub);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.LabMax);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.LabMin);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.BtnNegative);
            this.Controls.Add(this.LabValue);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOne);
            this.Controls.Add(this.BtnEnter);
            this.Controls.Add(this.BtnDot);
            this.Controls.Add(this.BtnBackspace);
            this.Controls.Add(this.BtnZero);
            this.Controls.Add(this.BtnNine);
            this.Controls.Add(this.BtnEight);
            this.Controls.Add(this.BtnSeven);
            this.Controls.Add(this.BtnSix);
            this.Controls.Add(this.BtnFive);
            this.Controls.Add(this.BtnFour);
            this.Controls.Add(this.BtnThree);
            this.Controls.Add(this.BtnTwo);
            this.Controls.Add(this.BtnDelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KeyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "KeyForm";
            this.Load += new System.EventHandler(this.KeyForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label LabLimit;
        internal System.Windows.Forms.Button BtnSub;
        internal System.Windows.Forms.Button BtnAdd;
        internal System.Windows.Forms.Label LabMax;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label LabMin;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button BtnNegative;
        internal System.Windows.Forms.Label LabValue;
        internal System.Windows.Forms.Button BtnCancel;
        internal System.Windows.Forms.Button BtnOne;
        internal System.Windows.Forms.Button BtnEnter;
        internal System.Windows.Forms.Button BtnDot;
        internal System.Windows.Forms.Button BtnBackspace;
        internal System.Windows.Forms.Button BtnZero;
        internal System.Windows.Forms.Button BtnNine;
        internal System.Windows.Forms.Button BtnEight;
        internal System.Windows.Forms.Button BtnSeven;
        internal System.Windows.Forms.Button BtnSix;
        internal System.Windows.Forms.Button BtnFive;
        internal System.Windows.Forms.Button BtnFour;
        internal System.Windows.Forms.Button BtnThree;
        internal System.Windows.Forms.Button BtnTwo;
        internal System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Timer Timer1;
    }
}