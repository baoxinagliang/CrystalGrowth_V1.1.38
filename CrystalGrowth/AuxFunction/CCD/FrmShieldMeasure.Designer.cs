namespace CrystalGrowth.AuxFunction.CCD
{
    partial class FrmShieldMeasure
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
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.BtnManualCalib = new System.Windows.Forms.Button();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCalib = new System.Windows.Forms.Button();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.LabUpAlarmValue = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LabDownAlarmValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LabShieldCenterX = new System.Windows.Forms.Label();
            this.LabShieldCorrectCoef = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.LabShieldPixelDia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LabDiaCoef = new System.Windows.Forms.Label();
            this.Lab1 = new System.Windows.Forms.Label();
            this.LabShieldCenterY = new System.Windows.Forms.Label();
            this.Label22 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.LabShieldRealDia = new System.Windows.Forms.Label();
            this.LabThreshholdRight = new System.Windows.Forms.Label();
            this.LabThreshholdLeft = new System.Windows.Forms.Label();
            this.LabShieldTargetDia = new System.Windows.Forms.Label();
            this.LabRightX = new System.Windows.Forms.Label();
            this.LabLeftH = new System.Windows.Forms.Label();
            this.LabRightH = new System.Windows.Forms.Label();
            this.LabLeftW = new System.Windows.Forms.Label();
            this.Label21 = new System.Windows.Forms.Label();
            this.Label20 = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            this.Label18 = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.LabRightW = new System.Windows.Forms.Label();
            this.LabLeftY = new System.Windows.Forms.Label();
            this.LabRightY = new System.Windows.Forms.Label();
            this.LabLeftX = new System.Windows.Forms.Label();
            this.LabName = new System.Windows.Forms.Label();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 250;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // BtnManualCalib
            // 
            this.BtnManualCalib.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnManualCalib.FlatAppearance.BorderSize = 0;
            this.BtnManualCalib.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnManualCalib.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnManualCalib.ForeColor = System.Drawing.Color.White;
            this.BtnManualCalib.Location = new System.Drawing.Point(9, 568);
            this.BtnManualCalib.Name = "BtnManualCalib";
            this.BtnManualCalib.Size = new System.Drawing.Size(117, 60);
            this.BtnManualCalib.TabIndex = 196;
            this.BtnManualCalib.Text = "手动标定";
            this.BtnManualCalib.UseVisualStyleBackColor = false;
            this.BtnManualCalib.Click += new System.EventHandler(this.BtnManualCalib_Click);
            // 
            // BtnQuit
            // 
            this.BtnQuit.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnQuit.FlatAppearance.BorderSize = 0;
            this.BtnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnQuit.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnQuit.ForeColor = System.Drawing.Color.White;
            this.BtnQuit.Location = new System.Drawing.Point(251, 568);
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.Size = new System.Drawing.Size(117, 60);
            this.BtnQuit.TabIndex = 192;
            this.BtnQuit.Text = "返回";
            this.BtnQuit.UseVisualStyleBackColor = false;
            this.BtnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnSave.FlatAppearance.BorderSize = 0;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Location = new System.Drawing.Point(251, 496);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(117, 60);
            this.BtnSave.TabIndex = 194;
            this.BtnSave.Text = "保存";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCalib
            // 
            this.BtnCalib.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnCalib.FlatAppearance.BorderSize = 0;
            this.BtnCalib.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalib.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCalib.ForeColor = System.Drawing.Color.White;
            this.BtnCalib.Location = new System.Drawing.Point(9, 496);
            this.BtnCalib.Name = "BtnCalib";
            this.BtnCalib.Size = new System.Drawing.Size(117, 60);
            this.BtnCalib.TabIndex = 195;
            this.BtnCalib.Text = "自动标定";
            this.BtnCalib.UseVisualStyleBackColor = false;
            this.BtnCalib.Click += new System.EventHandler(this.BtnCalib_Click);
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.DarkGray;
            this.Panel2.Controls.Add(this.LabUpAlarmValue);
            this.Panel2.Controls.Add(this.label9);
            this.Panel2.Controls.Add(this.LabDownAlarmValue);
            this.Panel2.Controls.Add(this.label3);
            this.Panel2.Controls.Add(this.LabShieldCenterX);
            this.Panel2.Controls.Add(this.LabShieldCorrectCoef);
            this.Panel2.Controls.Add(this.Label6);
            this.Panel2.Controls.Add(this.LabShieldPixelDia);
            this.Panel2.Controls.Add(this.label1);
            this.Panel2.Controls.Add(this.LabDiaCoef);
            this.Panel2.Controls.Add(this.Lab1);
            this.Panel2.Controls.Add(this.LabShieldCenterY);
            this.Panel2.Controls.Add(this.Label22);
            this.Panel2.Controls.Add(this.Label15);
            this.Panel2.Controls.Add(this.LabShieldRealDia);
            this.Panel2.Controls.Add(this.LabThreshholdRight);
            this.Panel2.Controls.Add(this.LabThreshholdLeft);
            this.Panel2.Controls.Add(this.LabShieldTargetDia);
            this.Panel2.Controls.Add(this.LabRightX);
            this.Panel2.Controls.Add(this.LabLeftH);
            this.Panel2.Controls.Add(this.LabRightH);
            this.Panel2.Controls.Add(this.LabLeftW);
            this.Panel2.Controls.Add(this.Label21);
            this.Panel2.Controls.Add(this.Label20);
            this.Panel2.Controls.Add(this.Label19);
            this.Panel2.Controls.Add(this.Label18);
            this.Panel2.Controls.Add(this.Label16);
            this.Panel2.Controls.Add(this.Label14);
            this.Panel2.Controls.Add(this.Label12);
            this.Panel2.Controls.Add(this.Label2);
            this.Panel2.Controls.Add(this.Label5);
            this.Panel2.Controls.Add(this.label4);
            this.Panel2.Controls.Add(this.label7);
            this.Panel2.Controls.Add(this.Label8);
            this.Panel2.Controls.Add(this.LabRightW);
            this.Panel2.Controls.Add(this.LabLeftY);
            this.Panel2.Controls.Add(this.LabRightY);
            this.Panel2.Controls.Add(this.LabLeftX);
            this.Panel2.Controls.Add(this.LabName);
            this.Panel2.Location = new System.Drawing.Point(9, 5);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(361, 485);
            this.Panel2.TabIndex = 193;
            // 
            // LabUpAlarmValue
            // 
            this.LabUpAlarmValue.BackColor = System.Drawing.Color.White;
            this.LabUpAlarmValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabUpAlarmValue.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabUpAlarmValue.ForeColor = System.Drawing.Color.Black;
            this.LabUpAlarmValue.Location = new System.Drawing.Point(259, 299);
            this.LabUpAlarmValue.Name = "LabUpAlarmValue";
            this.LabUpAlarmValue.Size = new System.Drawing.Size(80, 32);
            this.LabUpAlarmValue.TabIndex = 193;
            this.LabUpAlarmValue.Text = "0";
            this.LabUpAlarmValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabUpAlarmValue.Click += new System.EventHandler(this.LabUpAlarmValue_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(171, 299);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 32);
            this.label9.TabIndex = 192;
            this.label9.Text = "像素直径\r\n正限报警";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabDownAlarmValue
            // 
            this.LabDownAlarmValue.BackColor = System.Drawing.Color.White;
            this.LabDownAlarmValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabDownAlarmValue.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabDownAlarmValue.ForeColor = System.Drawing.Color.Black;
            this.LabDownAlarmValue.Location = new System.Drawing.Point(80, 299);
            this.LabDownAlarmValue.Name = "LabDownAlarmValue";
            this.LabDownAlarmValue.Size = new System.Drawing.Size(80, 32);
            this.LabDownAlarmValue.TabIndex = 191;
            this.LabDownAlarmValue.Text = "0";
            this.LabDownAlarmValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabDownAlarmValue.Click += new System.EventHandler(this.LabDownAlarmValue_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 32);
            this.label3.TabIndex = 190;
            this.label3.Text = "像素直径\r\n负限报警";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabShieldCenterX
            // 
            this.LabShieldCenterX.BackColor = System.Drawing.Color.Black;
            this.LabShieldCenterX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabShieldCenterX.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabShieldCenterX.ForeColor = System.Drawing.Color.White;
            this.LabShieldCenterX.Location = new System.Drawing.Point(74, 446);
            this.LabShieldCenterX.Name = "LabShieldCenterX";
            this.LabShieldCenterX.Size = new System.Drawing.Size(80, 32);
            this.LabShieldCenterX.TabIndex = 185;
            this.LabShieldCenterX.Text = "0";
            this.LabShieldCenterX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabShieldCenterX.TextChanged += new System.EventHandler(this.LabShieldCenterX_TextChanged);
            this.LabShieldCenterX.Click += new System.EventHandler(this.LabShieldCenterX_Click);
            // 
            // LabShieldCorrectCoef
            // 
            this.LabShieldCorrectCoef.BackColor = System.Drawing.Color.Black;
            this.LabShieldCorrectCoef.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabShieldCorrectCoef.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabShieldCorrectCoef.ForeColor = System.Drawing.Color.White;
            this.LabShieldCorrectCoef.Location = new System.Drawing.Point(242, 372);
            this.LabShieldCorrectCoef.Name = "LabShieldCorrectCoef";
            this.LabShieldCorrectCoef.Size = new System.Drawing.Size(97, 32);
            this.LabShieldCorrectCoef.TabIndex = 189;
            this.LabShieldCorrectCoef.Text = "0.00";
            this.LabShieldCorrectCoef.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label6.ForeColor = System.Drawing.Color.White;
            this.Label6.Location = new System.Drawing.Point(50, 372);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(118, 32);
            this.Label6.TabIndex = 188;
            this.Label6.Text = "修正系数:";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabShieldPixelDia
            // 
            this.LabShieldPixelDia.BackColor = System.Drawing.Color.Black;
            this.LabShieldPixelDia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabShieldPixelDia.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabShieldPixelDia.ForeColor = System.Drawing.Color.White;
            this.LabShieldPixelDia.Location = new System.Drawing.Point(242, 336);
            this.LabShieldPixelDia.Name = "LabShieldPixelDia";
            this.LabShieldPixelDia.Size = new System.Drawing.Size(97, 32);
            this.LabShieldPixelDia.TabIndex = 182;
            this.LabShieldPixelDia.Text = "0.00";
            this.LabShieldPixelDia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabShieldPixelDia.Click += new System.EventHandler(this.LabShieldPixelDia_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 32);
            this.label1.TabIndex = 181;
            this.label1.Text = "实测像素直径:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabDiaCoef
            // 
            this.LabDiaCoef.BackColor = System.Drawing.Color.Black;
            this.LabDiaCoef.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabDiaCoef.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabDiaCoef.ForeColor = System.Drawing.Color.White;
            this.LabDiaCoef.Location = new System.Drawing.Point(242, 409);
            this.LabDiaCoef.Name = "LabDiaCoef";
            this.LabDiaCoef.Size = new System.Drawing.Size(97, 32);
            this.LabDiaCoef.TabIndex = 189;
            this.LabDiaCoef.Text = "0";
            this.LabDiaCoef.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lab1
            // 
            this.Lab1.BackColor = System.Drawing.Color.Transparent;
            this.Lab1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab1.ForeColor = System.Drawing.Color.White;
            this.Lab1.Location = new System.Drawing.Point(50, 409);
            this.Lab1.Name = "Lab1";
            this.Lab1.Size = new System.Drawing.Size(118, 32);
            this.Lab1.TabIndex = 188;
            this.Lab1.Text = "比例系数:";
            this.Lab1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabShieldCenterY
            // 
            this.LabShieldCenterY.BackColor = System.Drawing.Color.Black;
            this.LabShieldCenterY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabShieldCenterY.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabShieldCenterY.ForeColor = System.Drawing.Color.White;
            this.LabShieldCenterY.Location = new System.Drawing.Point(242, 446);
            this.LabShieldCenterY.Name = "LabShieldCenterY";
            this.LabShieldCenterY.Size = new System.Drawing.Size(97, 32);
            this.LabShieldCenterY.TabIndex = 187;
            this.LabShieldCenterY.Text = "0";
            this.LabShieldCenterY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabShieldCenterY.TextChanged += new System.EventHandler(this.LabShieldCenterY_TextChanged);
            this.LabShieldCenterY.Click += new System.EventHandler(this.LabShieldCenterY_Click);
            // 
            // Label22
            // 
            this.Label22.BackColor = System.Drawing.Color.Transparent;
            this.Label22.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label22.ForeColor = System.Drawing.Color.White;
            this.Label22.Location = new System.Drawing.Point(160, 446);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(81, 32);
            this.Label22.TabIndex = 186;
            this.Label22.Text = "筒中心Y:";
            this.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label15
            // 
            this.Label15.BackColor = System.Drawing.Color.Transparent;
            this.Label15.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label15.ForeColor = System.Drawing.Color.White;
            this.Label15.Location = new System.Drawing.Point(3, 446);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(82, 32);
            this.Label15.TabIndex = 184;
            this.Label15.Text = "筒中心X:";
            this.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabShieldRealDia
            // 
            this.LabShieldRealDia.BackColor = System.Drawing.Color.White;
            this.LabShieldRealDia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabShieldRealDia.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabShieldRealDia.ForeColor = System.Drawing.Color.Black;
            this.LabShieldRealDia.Location = new System.Drawing.Point(242, 224);
            this.LabShieldRealDia.Name = "LabShieldRealDia";
            this.LabShieldRealDia.Size = new System.Drawing.Size(97, 32);
            this.LabShieldRealDia.TabIndex = 182;
            this.LabShieldRealDia.Text = "0";
            this.LabShieldRealDia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabShieldRealDia.Click += new System.EventHandler(this.LabShieldRealDia_Click);
            // 
            // LabThreshholdRight
            // 
            this.LabThreshholdRight.BackColor = System.Drawing.Color.White;
            this.LabThreshholdRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabThreshholdRight.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabThreshholdRight.ForeColor = System.Drawing.Color.Black;
            this.LabThreshholdRight.Location = new System.Drawing.Point(242, 187);
            this.LabThreshholdRight.Name = "LabThreshholdRight";
            this.LabThreshholdRight.Size = new System.Drawing.Size(97, 32);
            this.LabThreshholdRight.TabIndex = 182;
            this.LabThreshholdRight.Text = "0";
            this.LabThreshholdRight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabThreshholdRight.Click += new System.EventHandler(this.LabThreshholdRight_Click);
            // 
            // LabThreshholdLeft
            // 
            this.LabThreshholdLeft.BackColor = System.Drawing.Color.White;
            this.LabThreshholdLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabThreshholdLeft.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabThreshholdLeft.ForeColor = System.Drawing.Color.Black;
            this.LabThreshholdLeft.Location = new System.Drawing.Point(71, 187);
            this.LabThreshholdLeft.Name = "LabThreshholdLeft";
            this.LabThreshholdLeft.Size = new System.Drawing.Size(97, 32);
            this.LabThreshholdLeft.TabIndex = 182;
            this.LabThreshholdLeft.Text = "0";
            this.LabThreshholdLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabThreshholdLeft.Click += new System.EventHandler(this.LabThreshholdLeft_Click);
            // 
            // LabShieldTargetDia
            // 
            this.LabShieldTargetDia.BackColor = System.Drawing.Color.White;
            this.LabShieldTargetDia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabShieldTargetDia.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabShieldTargetDia.ForeColor = System.Drawing.Color.Black;
            this.LabShieldTargetDia.Location = new System.Drawing.Point(242, 261);
            this.LabShieldTargetDia.Name = "LabShieldTargetDia";
            this.LabShieldTargetDia.Size = new System.Drawing.Size(97, 32);
            this.LabShieldTargetDia.TabIndex = 182;
            this.LabShieldTargetDia.Text = "0.00";
            this.LabShieldTargetDia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabShieldTargetDia.TextChanged += new System.EventHandler(this.LabShieldTargetDia_TextChanged);
            this.LabShieldTargetDia.Click += new System.EventHandler(this.LabShieldTargetDia_Click);
            // 
            // LabRightX
            // 
            this.LabRightX.BackColor = System.Drawing.Color.White;
            this.LabRightX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabRightX.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabRightX.ForeColor = System.Drawing.Color.Black;
            this.LabRightX.Location = new System.Drawing.Point(71, 113);
            this.LabRightX.Name = "LabRightX";
            this.LabRightX.Size = new System.Drawing.Size(97, 32);
            this.LabRightX.TabIndex = 182;
            this.LabRightX.Text = "0";
            this.LabRightX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabRightX.Click += new System.EventHandler(this.LabRightX_Click);
            // 
            // LabLeftH
            // 
            this.LabLeftH.BackColor = System.Drawing.Color.White;
            this.LabLeftH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabLeftH.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabLeftH.ForeColor = System.Drawing.Color.Black;
            this.LabLeftH.Location = new System.Drawing.Point(242, 76);
            this.LabLeftH.Name = "LabLeftH";
            this.LabLeftH.Size = new System.Drawing.Size(97, 32);
            this.LabLeftH.TabIndex = 182;
            this.LabLeftH.Text = "0";
            this.LabLeftH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabLeftH.Click += new System.EventHandler(this.LabLeftH_Click);
            // 
            // LabRightH
            // 
            this.LabRightH.BackColor = System.Drawing.Color.White;
            this.LabRightH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabRightH.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabRightH.ForeColor = System.Drawing.Color.Black;
            this.LabRightH.Location = new System.Drawing.Point(242, 150);
            this.LabRightH.Name = "LabRightH";
            this.LabRightH.Size = new System.Drawing.Size(97, 32);
            this.LabRightH.TabIndex = 182;
            this.LabRightH.Text = "0";
            this.LabRightH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabRightH.Click += new System.EventHandler(this.LabRightH_Click);
            // 
            // LabLeftW
            // 
            this.LabLeftW.BackColor = System.Drawing.Color.White;
            this.LabLeftW.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabLeftW.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabLeftW.ForeColor = System.Drawing.Color.Black;
            this.LabLeftW.Location = new System.Drawing.Point(71, 76);
            this.LabLeftW.Name = "LabLeftW";
            this.LabLeftW.Size = new System.Drawing.Size(97, 32);
            this.LabLeftW.TabIndex = 182;
            this.LabLeftW.Text = "0";
            this.LabLeftW.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabLeftW.Click += new System.EventHandler(this.LabLeftW_Click);
            // 
            // Label21
            // 
            this.Label21.BackColor = System.Drawing.Color.Transparent;
            this.Label21.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label21.ForeColor = System.Drawing.Color.White;
            this.Label21.Location = new System.Drawing.Point(180, 150);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(61, 32);
            this.Label21.TabIndex = 181;
            this.Label21.Text = "高:";
            this.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label20
            // 
            this.Label20.BackColor = System.Drawing.Color.Transparent;
            this.Label20.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label20.ForeColor = System.Drawing.Color.White;
            this.Label20.Location = new System.Drawing.Point(3, 150);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(61, 32);
            this.Label20.TabIndex = 181;
            this.Label20.Text = "宽:";
            this.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label19
            // 
            this.Label19.BackColor = System.Drawing.Color.Transparent;
            this.Label19.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label19.ForeColor = System.Drawing.Color.White;
            this.Label19.Location = new System.Drawing.Point(180, 113);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(61, 32);
            this.Label19.TabIndex = 181;
            this.Label19.Text = "右Y:";
            this.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label18
            // 
            this.Label18.BackColor = System.Drawing.Color.Transparent;
            this.Label18.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label18.ForeColor = System.Drawing.Color.White;
            this.Label18.Location = new System.Drawing.Point(3, 113);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(61, 32);
            this.Label18.TabIndex = 181;
            this.Label18.Text = "右X:";
            this.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label16
            // 
            this.Label16.BackColor = System.Drawing.Color.Transparent;
            this.Label16.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label16.ForeColor = System.Drawing.Color.White;
            this.Label16.Location = new System.Drawing.Point(180, 76);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(61, 35);
            this.Label16.TabIndex = 181;
            this.Label16.Text = "高:";
            this.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label14
            // 
            this.Label14.BackColor = System.Drawing.Color.Transparent;
            this.Label14.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label14.ForeColor = System.Drawing.Color.White;
            this.Label14.Location = new System.Drawing.Point(3, 76);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(61, 32);
            this.Label14.TabIndex = 181;
            this.Label14.Text = "宽:";
            this.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label12
            // 
            this.Label12.BackColor = System.Drawing.Color.Transparent;
            this.Label12.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label12.ForeColor = System.Drawing.Color.White;
            this.Label12.Location = new System.Drawing.Point(180, 39);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(61, 32);
            this.Label12.TabIndex = 181;
            this.Label12.Text = "左Y:";
            this.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(13, 261);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(164, 32);
            this.Label2.TabIndex = 181;
            this.Label2.Text = "目标像素直径:";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(3, 39);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(61, 32);
            this.Label5.TabIndex = 181;
            this.Label5.Text = "左X:";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(53, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 32);
            this.label4.TabIndex = 181;
            this.label4.Text = "筒内径:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(180, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 32);
            this.label7.TabIndex = 181;
            this.label7.Text = "右阈:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label8
            // 
            this.Label8.BackColor = System.Drawing.Color.Transparent;
            this.Label8.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label8.ForeColor = System.Drawing.Color.White;
            this.Label8.Location = new System.Drawing.Point(3, 187);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(61, 32);
            this.Label8.TabIndex = 181;
            this.Label8.Text = "左阈:";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabRightW
            // 
            this.LabRightW.BackColor = System.Drawing.Color.White;
            this.LabRightW.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabRightW.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabRightW.ForeColor = System.Drawing.Color.Black;
            this.LabRightW.Location = new System.Drawing.Point(71, 150);
            this.LabRightW.Name = "LabRightW";
            this.LabRightW.Size = new System.Drawing.Size(97, 32);
            this.LabRightW.TabIndex = 180;
            this.LabRightW.Text = "0";
            this.LabRightW.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabRightW.Click += new System.EventHandler(this.LabRightW_Click);
            // 
            // LabLeftY
            // 
            this.LabLeftY.BackColor = System.Drawing.Color.White;
            this.LabLeftY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabLeftY.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabLeftY.ForeColor = System.Drawing.Color.Black;
            this.LabLeftY.Location = new System.Drawing.Point(242, 39);
            this.LabLeftY.Name = "LabLeftY";
            this.LabLeftY.Size = new System.Drawing.Size(97, 32);
            this.LabLeftY.TabIndex = 180;
            this.LabLeftY.Text = "0";
            this.LabLeftY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabLeftY.Click += new System.EventHandler(this.LabLeftY_Click);
            // 
            // LabRightY
            // 
            this.LabRightY.BackColor = System.Drawing.Color.White;
            this.LabRightY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabRightY.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabRightY.ForeColor = System.Drawing.Color.Black;
            this.LabRightY.Location = new System.Drawing.Point(242, 113);
            this.LabRightY.Name = "LabRightY";
            this.LabRightY.Size = new System.Drawing.Size(97, 32);
            this.LabRightY.TabIndex = 178;
            this.LabRightY.Text = "0";
            this.LabRightY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabRightY.Click += new System.EventHandler(this.LabRightY_Click);
            // 
            // LabLeftX
            // 
            this.LabLeftX.BackColor = System.Drawing.Color.White;
            this.LabLeftX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabLeftX.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabLeftX.ForeColor = System.Drawing.Color.Black;
            this.LabLeftX.Location = new System.Drawing.Point(71, 39);
            this.LabLeftX.Name = "LabLeftX";
            this.LabLeftX.Size = new System.Drawing.Size(97, 32);
            this.LabLeftX.TabIndex = 178;
            this.LabLeftX.Text = "0";
            this.LabLeftX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabLeftX.Click += new System.EventHandler(this.LabLeftX_Click);
            // 
            // LabName
            // 
            this.LabName.BackColor = System.Drawing.Color.Transparent;
            this.LabName.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabName.ForeColor = System.Drawing.Color.Black;
            this.LabName.Location = new System.Drawing.Point(66, 3);
            this.LabName.Name = "LabName";
            this.LabName.Size = new System.Drawing.Size(238, 30);
            this.LabName.TabIndex = 172;
            this.LabName.Text = "导流筒检测区域";
            this.LabName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmShieldMeasure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(380, 638);
            this.Controls.Add(this.BtnManualCalib);
            this.Controls.Add(this.BtnQuit);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnCalib);
            this.Controls.Add(this.Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmShieldMeasure";
            this.Text = "FrmDraftTube";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmShieldMeasure_FormClosed);
            this.Load += new System.EventHandler(this.FrmShieldMeasure_Load);
            this.Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer Timer1;
        internal System.Windows.Forms.Button BtnManualCalib;
        internal System.Windows.Forms.Button BtnQuit;
        internal System.Windows.Forms.Button BtnSave;
        internal System.Windows.Forms.Button BtnCalib;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Label LabShieldCorrectCoef;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label LabDiaCoef;
        internal System.Windows.Forms.Label Lab1;
        internal System.Windows.Forms.Label LabShieldCenterY;
        internal System.Windows.Forms.Label Label22;
        internal System.Windows.Forms.Label LabShieldCenterX;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Label LabShieldRealDia;
        internal System.Windows.Forms.Label LabThreshholdRight;
        internal System.Windows.Forms.Label LabThreshholdLeft;
        internal System.Windows.Forms.Label LabShieldTargetDia;
        internal System.Windows.Forms.Label LabShieldPixelDia;
        internal System.Windows.Forms.Label LabRightX;
        internal System.Windows.Forms.Label LabLeftH;
        internal System.Windows.Forms.Label LabRightH;
        internal System.Windows.Forms.Label LabLeftW;
        internal System.Windows.Forms.Label Label21;
        internal System.Windows.Forms.Label Label20;
        internal System.Windows.Forms.Label Label19;
        internal System.Windows.Forms.Label Label18;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label LabRightW;
        internal System.Windows.Forms.Label LabLeftY;
        internal System.Windows.Forms.Label LabRightY;
        internal System.Windows.Forms.Label LabLeftX;
        internal System.Windows.Forms.Label LabName;
        internal System.Windows.Forms.Label LabDownAlarmValue;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label LabUpAlarmValue;
        internal System.Windows.Forms.Label label9;
    }
}