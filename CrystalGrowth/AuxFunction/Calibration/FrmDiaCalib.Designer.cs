namespace CrystalGrowth.AuxFunction.Calibration
{
    partial class FrmDiaCalib
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
            this.TCDiaCalib = new System.Windows.Forms.TabControl();
            this.TPNeck = new System.Windows.Forms.TabPage();
            this.BtnCalibNeck = new System.Windows.Forms.Button();
            this.LabDiaCoefNeck = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.LabRawPxlPVNeck = new System.Windows.Forms.Label();
            this.LabDiaCalibNeck = new System.Windows.Forms.Label();
            this.LabDiaPVNeck = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.TPCrown = new System.Windows.Forms.TabPage();
            this.BtnCalibCrown = new System.Windows.Forms.Button();
            this.LabDiaCoefCrown = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            this.LabRawPxlPVCrown = new System.Windows.Forms.Label();
            this.LabDiaCalibCrown = new System.Windows.Forms.Label();
            this.LabDiaPVCrown = new System.Windows.Forms.Label();
            this.Label23 = new System.Windows.Forms.Label();
            this.Label24 = new System.Windows.Forms.Label();
            this.Label25 = new System.Windows.Forms.Label();
            this.Label26 = new System.Windows.Forms.Label();
            this.Label27 = new System.Windows.Forms.Label();
            this.TPBody = new System.Windows.Forms.TabPage();
            this.BtnCalibBody = new System.Windows.Forms.Button();
            this.LabDiaCoefBody = new System.Windows.Forms.Label();
            this.Label29 = new System.Windows.Forms.Label();
            this.LabRawPxlPVBody = new System.Windows.Forms.Label();
            this.LabDiaCalibBody = new System.Windows.Forms.Label();
            this.LabDiaPVBody = new System.Windows.Forms.Label();
            this.Label33 = new System.Windows.Forms.Label();
            this.Label34 = new System.Windows.Forms.Label();
            this.Label35 = new System.Windows.Forms.Label();
            this.Label36 = new System.Windows.Forms.Label();
            this.Label37 = new System.Windows.Forms.Label();
            this.LabDateTime = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.TCDiaCalib.SuspendLayout();
            this.TPNeck.SuspendLayout();
            this.TPCrown.SuspendLayout();
            this.TPBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // TCDiaCalib
            // 
            this.TCDiaCalib.Controls.Add(this.TPNeck);
            this.TCDiaCalib.Controls.Add(this.TPCrown);
            this.TCDiaCalib.Controls.Add(this.TPBody);
            this.TCDiaCalib.Location = new System.Drawing.Point(9, 12);
            this.TCDiaCalib.Name = "TCDiaCalib";
            this.TCDiaCalib.SelectedIndex = 0;
            this.TCDiaCalib.Size = new System.Drawing.Size(375, 325);
            this.TCDiaCalib.TabIndex = 183;
            this.TCDiaCalib.SelectedIndexChanged += new System.EventHandler(this.TCDiaCalib_SelectedIndexChanged);
            // 
            // TPNeck
            // 
            this.TPNeck.BackColor = System.Drawing.Color.DarkGray;
            this.TPNeck.Controls.Add(this.BtnCalibNeck);
            this.TPNeck.Controls.Add(this.LabDiaCoefNeck);
            this.TPNeck.Controls.Add(this.Label7);
            this.TPNeck.Controls.Add(this.LabRawPxlPVNeck);
            this.TPNeck.Controls.Add(this.LabDiaCalibNeck);
            this.TPNeck.Controls.Add(this.LabDiaPVNeck);
            this.TPNeck.Controls.Add(this.Label11);
            this.TPNeck.Controls.Add(this.Label14);
            this.TPNeck.Controls.Add(this.Label15);
            this.TPNeck.Controls.Add(this.Label16);
            this.TPNeck.Controls.Add(this.Label17);
            this.TPNeck.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TPNeck.Location = new System.Drawing.Point(4, 22);
            this.TPNeck.Name = "TPNeck";
            this.TPNeck.Padding = new System.Windows.Forms.Padding(3);
            this.TPNeck.Size = new System.Drawing.Size(367, 299);
            this.TPNeck.TabIndex = 0;
            this.TPNeck.Text = "引晶设置";
            // 
            // BtnCalibNeck
            // 
            this.BtnCalibNeck.BackColor = System.Drawing.Color.Blue;
            this.BtnCalibNeck.FlatAppearance.BorderSize = 0;
            this.BtnCalibNeck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalibNeck.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCalibNeck.ForeColor = System.Drawing.Color.White;
            this.BtnCalibNeck.Location = new System.Drawing.Point(175, 234);
            this.BtnCalibNeck.Name = "BtnCalibNeck";
            this.BtnCalibNeck.Size = new System.Drawing.Size(100, 45);
            this.BtnCalibNeck.TabIndex = 186;
            this.BtnCalibNeck.Text = "校准";
            this.BtnCalibNeck.UseVisualStyleBackColor = false;
            this.BtnCalibNeck.Click += new System.EventHandler(this.BtnCalibNeck_Click);
            // 
            // LabDiaCoefNeck
            // 
            this.LabDiaCoefNeck.BackColor = System.Drawing.Color.White;
            this.LabDiaCoefNeck.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabDiaCoefNeck.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabDiaCoefNeck.ForeColor = System.Drawing.Color.Black;
            this.LabDiaCoefNeck.Location = new System.Drawing.Point(175, 26);
            this.LabDiaCoefNeck.Name = "LabDiaCoefNeck";
            this.LabDiaCoefNeck.Size = new System.Drawing.Size(100, 45);
            this.LabDiaCoefNeck.TabIndex = 185;
            this.LabDiaCoefNeck.Text = "0.00";
            this.LabDiaCoefNeck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabDiaCoefNeck.Click += new System.EventHandler(this.LabDiaCoefNeck_Click);
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label7.ForeColor = System.Drawing.Color.White;
            this.Label7.Location = new System.Drawing.Point(37, 38);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(135, 20);
            this.Label7.TabIndex = 184;
            this.Label7.Text = "引晶直径增益值";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabRawPxlPVNeck
            // 
            this.LabRawPxlPVNeck.BackColor = System.Drawing.Color.Black;
            this.LabRawPxlPVNeck.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabRawPxlPVNeck.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabRawPxlPVNeck.ForeColor = System.Drawing.Color.White;
            this.LabRawPxlPVNeck.Location = new System.Drawing.Point(175, 78);
            this.LabRawPxlPVNeck.Name = "LabRawPxlPVNeck";
            this.LabRawPxlPVNeck.Size = new System.Drawing.Size(100, 45);
            this.LabRawPxlPVNeck.TabIndex = 183;
            this.LabRawPxlPVNeck.Text = "0.00";
            this.LabRawPxlPVNeck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabDiaCalibNeck
            // 
            this.LabDiaCalibNeck.BackColor = System.Drawing.Color.White;
            this.LabDiaCalibNeck.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabDiaCalibNeck.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabDiaCalibNeck.ForeColor = System.Drawing.Color.Black;
            this.LabDiaCalibNeck.Location = new System.Drawing.Point(175, 182);
            this.LabDiaCalibNeck.Name = "LabDiaCalibNeck";
            this.LabDiaCalibNeck.Size = new System.Drawing.Size(100, 45);
            this.LabDiaCalibNeck.TabIndex = 182;
            this.LabDiaCalibNeck.Text = "0.00";
            this.LabDiaCalibNeck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabDiaCalibNeck.Click += new System.EventHandler(this.LabDiaCalibNeck_Click);
            // 
            // LabDiaPVNeck
            // 
            this.LabDiaPVNeck.BackColor = System.Drawing.Color.Black;
            this.LabDiaPVNeck.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabDiaPVNeck.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabDiaPVNeck.ForeColor = System.Drawing.Color.White;
            this.LabDiaPVNeck.Location = new System.Drawing.Point(175, 130);
            this.LabDiaPVNeck.Name = "LabDiaPVNeck";
            this.LabDiaPVNeck.Size = new System.Drawing.Size(100, 45);
            this.LabDiaPVNeck.TabIndex = 181;
            this.LabDiaPVNeck.Text = "0.00";
            this.LabDiaPVNeck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label11
            // 
            this.Label11.BackColor = System.Drawing.Color.Transparent;
            this.Label11.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label11.ForeColor = System.Drawing.Color.White;
            this.Label11.Location = new System.Drawing.Point(281, 194);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(36, 20);
            this.Label11.TabIndex = 180;
            this.Label11.Text = "mm";
            this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label14
            // 
            this.Label14.BackColor = System.Drawing.Color.Transparent;
            this.Label14.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label14.ForeColor = System.Drawing.Color.White;
            this.Label14.Location = new System.Drawing.Point(281, 142);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(36, 20);
            this.Label14.TabIndex = 179;
            this.Label14.Text = "mm";
            this.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label15
            // 
            this.Label15.BackColor = System.Drawing.Color.Transparent;
            this.Label15.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label15.ForeColor = System.Drawing.Color.White;
            this.Label15.Location = new System.Drawing.Point(37, 194);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(135, 20);
            this.Label15.TabIndex = 178;
            this.Label15.Text = "直径校准值";
            this.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label16
            // 
            this.Label16.BackColor = System.Drawing.Color.Transparent;
            this.Label16.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label16.ForeColor = System.Drawing.Color.White;
            this.Label16.Location = new System.Drawing.Point(37, 90);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(135, 20);
            this.Label16.TabIndex = 177;
            this.Label16.Text = "像素值";
            this.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label17
            // 
            this.Label17.BackColor = System.Drawing.Color.Transparent;
            this.Label17.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label17.ForeColor = System.Drawing.Color.White;
            this.Label17.Location = new System.Drawing.Point(37, 142);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(135, 20);
            this.Label17.TabIndex = 176;
            this.Label17.Text = "直径值";
            this.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TPCrown
            // 
            this.TPCrown.BackColor = System.Drawing.Color.DarkGray;
            this.TPCrown.Controls.Add(this.BtnCalibCrown);
            this.TPCrown.Controls.Add(this.LabDiaCoefCrown);
            this.TPCrown.Controls.Add(this.Label19);
            this.TPCrown.Controls.Add(this.LabRawPxlPVCrown);
            this.TPCrown.Controls.Add(this.LabDiaCalibCrown);
            this.TPCrown.Controls.Add(this.LabDiaPVCrown);
            this.TPCrown.Controls.Add(this.Label23);
            this.TPCrown.Controls.Add(this.Label24);
            this.TPCrown.Controls.Add(this.Label25);
            this.TPCrown.Controls.Add(this.Label26);
            this.TPCrown.Controls.Add(this.Label27);
            this.TPCrown.Location = new System.Drawing.Point(4, 22);
            this.TPCrown.Name = "TPCrown";
            this.TPCrown.Padding = new System.Windows.Forms.Padding(3);
            this.TPCrown.Size = new System.Drawing.Size(367, 299);
            this.TPCrown.TabIndex = 1;
            this.TPCrown.Text = "放肩设置";
            // 
            // BtnCalibCrown
            // 
            this.BtnCalibCrown.BackColor = System.Drawing.Color.Blue;
            this.BtnCalibCrown.FlatAppearance.BorderSize = 0;
            this.BtnCalibCrown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalibCrown.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCalibCrown.ForeColor = System.Drawing.Color.White;
            this.BtnCalibCrown.Location = new System.Drawing.Point(175, 234);
            this.BtnCalibCrown.Name = "BtnCalibCrown";
            this.BtnCalibCrown.Size = new System.Drawing.Size(100, 45);
            this.BtnCalibCrown.TabIndex = 186;
            this.BtnCalibCrown.Text = "校准";
            this.BtnCalibCrown.UseVisualStyleBackColor = false;
            this.BtnCalibCrown.Click += new System.EventHandler(this.BtnCalibCrown_Click);
            // 
            // LabDiaCoefCrown
            // 
            this.LabDiaCoefCrown.BackColor = System.Drawing.Color.White;
            this.LabDiaCoefCrown.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabDiaCoefCrown.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabDiaCoefCrown.ForeColor = System.Drawing.Color.Black;
            this.LabDiaCoefCrown.Location = new System.Drawing.Point(175, 26);
            this.LabDiaCoefCrown.Name = "LabDiaCoefCrown";
            this.LabDiaCoefCrown.Size = new System.Drawing.Size(100, 45);
            this.LabDiaCoefCrown.TabIndex = 185;
            this.LabDiaCoefCrown.Text = "0.00";
            this.LabDiaCoefCrown.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabDiaCoefCrown.Click += new System.EventHandler(this.LabDiaCoefCrown_Click);
            // 
            // Label19
            // 
            this.Label19.BackColor = System.Drawing.Color.Transparent;
            this.Label19.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label19.ForeColor = System.Drawing.Color.White;
            this.Label19.Location = new System.Drawing.Point(37, 38);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(135, 20);
            this.Label19.TabIndex = 184;
            this.Label19.Text = "放肩直径增益值";
            this.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabRawPxlPVCrown
            // 
            this.LabRawPxlPVCrown.BackColor = System.Drawing.Color.Black;
            this.LabRawPxlPVCrown.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabRawPxlPVCrown.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabRawPxlPVCrown.ForeColor = System.Drawing.Color.White;
            this.LabRawPxlPVCrown.Location = new System.Drawing.Point(175, 78);
            this.LabRawPxlPVCrown.Name = "LabRawPxlPVCrown";
            this.LabRawPxlPVCrown.Size = new System.Drawing.Size(100, 45);
            this.LabRawPxlPVCrown.TabIndex = 183;
            this.LabRawPxlPVCrown.Text = "0.00";
            this.LabRawPxlPVCrown.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabDiaCalibCrown
            // 
            this.LabDiaCalibCrown.BackColor = System.Drawing.Color.White;
            this.LabDiaCalibCrown.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabDiaCalibCrown.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabDiaCalibCrown.ForeColor = System.Drawing.Color.Black;
            this.LabDiaCalibCrown.Location = new System.Drawing.Point(175, 182);
            this.LabDiaCalibCrown.Name = "LabDiaCalibCrown";
            this.LabDiaCalibCrown.Size = new System.Drawing.Size(100, 45);
            this.LabDiaCalibCrown.TabIndex = 182;
            this.LabDiaCalibCrown.Text = "0.00";
            this.LabDiaCalibCrown.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabDiaCalibCrown.Click += new System.EventHandler(this.LabDiaCalibCrown_Click);
            // 
            // LabDiaPVCrown
            // 
            this.LabDiaPVCrown.BackColor = System.Drawing.Color.Black;
            this.LabDiaPVCrown.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabDiaPVCrown.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabDiaPVCrown.ForeColor = System.Drawing.Color.White;
            this.LabDiaPVCrown.Location = new System.Drawing.Point(175, 130);
            this.LabDiaPVCrown.Name = "LabDiaPVCrown";
            this.LabDiaPVCrown.Size = new System.Drawing.Size(100, 45);
            this.LabDiaPVCrown.TabIndex = 181;
            this.LabDiaPVCrown.Text = "0.00";
            this.LabDiaPVCrown.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label23
            // 
            this.Label23.BackColor = System.Drawing.Color.Transparent;
            this.Label23.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label23.ForeColor = System.Drawing.Color.White;
            this.Label23.Location = new System.Drawing.Point(281, 194);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(37, 20);
            this.Label23.TabIndex = 180;
            this.Label23.Text = "mm";
            this.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label24
            // 
            this.Label24.BackColor = System.Drawing.Color.Transparent;
            this.Label24.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label24.ForeColor = System.Drawing.Color.White;
            this.Label24.Location = new System.Drawing.Point(281, 142);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(37, 20);
            this.Label24.TabIndex = 179;
            this.Label24.Text = "mm";
            this.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label25
            // 
            this.Label25.BackColor = System.Drawing.Color.Transparent;
            this.Label25.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label25.ForeColor = System.Drawing.Color.White;
            this.Label25.Location = new System.Drawing.Point(37, 194);
            this.Label25.Name = "Label25";
            this.Label25.Size = new System.Drawing.Size(135, 20);
            this.Label25.TabIndex = 178;
            this.Label25.Text = "直径校准值";
            this.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label26
            // 
            this.Label26.BackColor = System.Drawing.Color.Transparent;
            this.Label26.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label26.ForeColor = System.Drawing.Color.White;
            this.Label26.Location = new System.Drawing.Point(37, 90);
            this.Label26.Name = "Label26";
            this.Label26.Size = new System.Drawing.Size(135, 20);
            this.Label26.TabIndex = 177;
            this.Label26.Text = "像素值";
            this.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label27
            // 
            this.Label27.BackColor = System.Drawing.Color.Transparent;
            this.Label27.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label27.ForeColor = System.Drawing.Color.White;
            this.Label27.Location = new System.Drawing.Point(37, 142);
            this.Label27.Name = "Label27";
            this.Label27.Size = new System.Drawing.Size(135, 20);
            this.Label27.TabIndex = 176;
            this.Label27.Text = "直径值";
            this.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TPBody
            // 
            this.TPBody.BackColor = System.Drawing.Color.DarkGray;
            this.TPBody.Controls.Add(this.BtnCalibBody);
            this.TPBody.Controls.Add(this.LabDiaCoefBody);
            this.TPBody.Controls.Add(this.Label29);
            this.TPBody.Controls.Add(this.LabRawPxlPVBody);
            this.TPBody.Controls.Add(this.LabDiaCalibBody);
            this.TPBody.Controls.Add(this.LabDiaPVBody);
            this.TPBody.Controls.Add(this.Label33);
            this.TPBody.Controls.Add(this.Label34);
            this.TPBody.Controls.Add(this.Label35);
            this.TPBody.Controls.Add(this.Label36);
            this.TPBody.Controls.Add(this.Label37);
            this.TPBody.Location = new System.Drawing.Point(4, 22);
            this.TPBody.Name = "TPBody";
            this.TPBody.Size = new System.Drawing.Size(367, 299);
            this.TPBody.TabIndex = 2;
            this.TPBody.Text = "等径设置";
            // 
            // BtnCalibBody
            // 
            this.BtnCalibBody.BackColor = System.Drawing.Color.Blue;
            this.BtnCalibBody.FlatAppearance.BorderSize = 0;
            this.BtnCalibBody.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalibBody.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCalibBody.ForeColor = System.Drawing.Color.White;
            this.BtnCalibBody.Location = new System.Drawing.Point(175, 234);
            this.BtnCalibBody.Name = "BtnCalibBody";
            this.BtnCalibBody.Size = new System.Drawing.Size(100, 45);
            this.BtnCalibBody.TabIndex = 186;
            this.BtnCalibBody.Text = "校准";
            this.BtnCalibBody.UseVisualStyleBackColor = false;
            this.BtnCalibBody.Click += new System.EventHandler(this.BtnCalibBody_Click);
            // 
            // LabDiaCoefBody
            // 
            this.LabDiaCoefBody.BackColor = System.Drawing.Color.White;
            this.LabDiaCoefBody.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabDiaCoefBody.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabDiaCoefBody.ForeColor = System.Drawing.Color.Black;
            this.LabDiaCoefBody.Location = new System.Drawing.Point(175, 26);
            this.LabDiaCoefBody.Name = "LabDiaCoefBody";
            this.LabDiaCoefBody.Size = new System.Drawing.Size(100, 45);
            this.LabDiaCoefBody.TabIndex = 185;
            this.LabDiaCoefBody.Text = "0.00";
            this.LabDiaCoefBody.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabDiaCoefBody.Click += new System.EventHandler(this.LabDiaCoefBody_Click);
            // 
            // Label29
            // 
            this.Label29.BackColor = System.Drawing.Color.Transparent;
            this.Label29.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label29.ForeColor = System.Drawing.Color.White;
            this.Label29.Location = new System.Drawing.Point(37, 38);
            this.Label29.Name = "Label29";
            this.Label29.Size = new System.Drawing.Size(135, 20);
            this.Label29.TabIndex = 184;
            this.Label29.Text = "等径直径增益值";
            this.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabRawPxlPVBody
            // 
            this.LabRawPxlPVBody.BackColor = System.Drawing.Color.Black;
            this.LabRawPxlPVBody.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabRawPxlPVBody.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabRawPxlPVBody.ForeColor = System.Drawing.Color.White;
            this.LabRawPxlPVBody.Location = new System.Drawing.Point(175, 78);
            this.LabRawPxlPVBody.Name = "LabRawPxlPVBody";
            this.LabRawPxlPVBody.Size = new System.Drawing.Size(100, 45);
            this.LabRawPxlPVBody.TabIndex = 183;
            this.LabRawPxlPVBody.Text = "0.00";
            this.LabRawPxlPVBody.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabDiaCalibBody
            // 
            this.LabDiaCalibBody.BackColor = System.Drawing.Color.White;
            this.LabDiaCalibBody.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabDiaCalibBody.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabDiaCalibBody.ForeColor = System.Drawing.Color.Black;
            this.LabDiaCalibBody.Location = new System.Drawing.Point(175, 182);
            this.LabDiaCalibBody.Name = "LabDiaCalibBody";
            this.LabDiaCalibBody.Size = new System.Drawing.Size(100, 45);
            this.LabDiaCalibBody.TabIndex = 182;
            this.LabDiaCalibBody.Text = "0.00";
            this.LabDiaCalibBody.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabDiaCalibBody.Click += new System.EventHandler(this.LabDiaCalibBody_Click);
            // 
            // LabDiaPVBody
            // 
            this.LabDiaPVBody.BackColor = System.Drawing.Color.Black;
            this.LabDiaPVBody.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabDiaPVBody.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabDiaPVBody.ForeColor = System.Drawing.Color.White;
            this.LabDiaPVBody.Location = new System.Drawing.Point(175, 130);
            this.LabDiaPVBody.Name = "LabDiaPVBody";
            this.LabDiaPVBody.Size = new System.Drawing.Size(100, 45);
            this.LabDiaPVBody.TabIndex = 181;
            this.LabDiaPVBody.Text = "0.00";
            this.LabDiaPVBody.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label33
            // 
            this.Label33.BackColor = System.Drawing.Color.Transparent;
            this.Label33.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label33.ForeColor = System.Drawing.Color.White;
            this.Label33.Location = new System.Drawing.Point(281, 194);
            this.Label33.Name = "Label33";
            this.Label33.Size = new System.Drawing.Size(42, 20);
            this.Label33.TabIndex = 180;
            this.Label33.Text = "mm";
            this.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label34
            // 
            this.Label34.BackColor = System.Drawing.Color.Transparent;
            this.Label34.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label34.ForeColor = System.Drawing.Color.White;
            this.Label34.Location = new System.Drawing.Point(281, 142);
            this.Label34.Name = "Label34";
            this.Label34.Size = new System.Drawing.Size(42, 20);
            this.Label34.TabIndex = 179;
            this.Label34.Text = "mm";
            this.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label35
            // 
            this.Label35.BackColor = System.Drawing.Color.Transparent;
            this.Label35.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label35.ForeColor = System.Drawing.Color.White;
            this.Label35.Location = new System.Drawing.Point(37, 194);
            this.Label35.Name = "Label35";
            this.Label35.Size = new System.Drawing.Size(135, 20);
            this.Label35.TabIndex = 178;
            this.Label35.Text = "直径校准值";
            this.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label36
            // 
            this.Label36.BackColor = System.Drawing.Color.Transparent;
            this.Label36.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label36.ForeColor = System.Drawing.Color.White;
            this.Label36.Location = new System.Drawing.Point(37, 90);
            this.Label36.Name = "Label36";
            this.Label36.Size = new System.Drawing.Size(135, 20);
            this.Label36.TabIndex = 177;
            this.Label36.Text = "像素值";
            this.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label37
            // 
            this.Label37.BackColor = System.Drawing.Color.Transparent;
            this.Label37.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label37.ForeColor = System.Drawing.Color.White;
            this.Label37.Location = new System.Drawing.Point(37, 142);
            this.Label37.Name = "Label37";
            this.Label37.Size = new System.Drawing.Size(135, 20);
            this.Label37.TabIndex = 176;
            this.Label37.Text = "直径值";
            this.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabDateTime
            // 
            this.LabDateTime.BackColor = System.Drawing.Color.Transparent;
            this.LabDateTime.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabDateTime.ForeColor = System.Drawing.Color.White;
            this.LabDateTime.Location = new System.Drawing.Point(155, 351);
            this.LabDateTime.Name = "LabDateTime";
            this.LabDateTime.Size = new System.Drawing.Size(221, 20);
            this.LabDateTime.TabIndex = 185;
            this.LabDateTime.Text = "2000-01-01 00:00:00";
            this.LabDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label13
            // 
            this.Label13.BackColor = System.Drawing.Color.Transparent;
            this.Label13.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label13.ForeColor = System.Drawing.Color.White;
            this.Label13.Location = new System.Drawing.Point(83, 351);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(70, 20);
            this.Label13.TabIndex = 184;
            this.Label13.Text = "已校准";
            this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 500;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // FrmDiaCalib
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(394, 380);
            this.Controls.Add(this.LabDateTime);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.TCDiaCalib);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDiaCalib";
            this.Text = "FrmDiaCalib";
            this.Load += new System.EventHandler(this.FrmDiaCalib_Load);
            this.TCDiaCalib.ResumeLayout(false);
            this.TPNeck.ResumeLayout(false);
            this.TPCrown.ResumeLayout(false);
            this.TPBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TabControl TCDiaCalib;
        internal System.Windows.Forms.TabPage TPNeck;
        internal System.Windows.Forms.Button BtnCalibNeck;
        internal System.Windows.Forms.Label LabDiaCoefNeck;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label LabRawPxlPVNeck;
        internal System.Windows.Forms.Label LabDiaCalibNeck;
        internal System.Windows.Forms.Label LabDiaPVNeck;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.TabPage TPCrown;
        internal System.Windows.Forms.Button BtnCalibCrown;
        internal System.Windows.Forms.Label LabDiaCoefCrown;
        internal System.Windows.Forms.Label Label19;
        internal System.Windows.Forms.Label LabRawPxlPVCrown;
        internal System.Windows.Forms.Label LabDiaCalibCrown;
        internal System.Windows.Forms.Label LabDiaPVCrown;
        internal System.Windows.Forms.Label Label23;
        internal System.Windows.Forms.Label Label24;
        internal System.Windows.Forms.Label Label25;
        internal System.Windows.Forms.Label Label26;
        internal System.Windows.Forms.Label Label27;
        internal System.Windows.Forms.TabPage TPBody;
        internal System.Windows.Forms.Button BtnCalibBody;
        internal System.Windows.Forms.Label LabDiaCoefBody;
        internal System.Windows.Forms.Label Label29;
        internal System.Windows.Forms.Label LabRawPxlPVBody;
        internal System.Windows.Forms.Label LabDiaCalibBody;
        internal System.Windows.Forms.Label LabDiaPVBody;
        internal System.Windows.Forms.Label Label33;
        internal System.Windows.Forms.Label Label34;
        internal System.Windows.Forms.Label Label35;
        internal System.Windows.Forms.Label Label36;
        internal System.Windows.Forms.Label Label37;
        internal System.Windows.Forms.Label LabDateTime;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Timer Timer1;
    }
}