namespace CrystalGrowth.AuxFunction.Calibration
{
    partial class FrmWeightCalib
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
            this.BtnSetSpan = new System.Windows.Forms.Button();
            this.BtnSetZero = new System.Windows.Forms.Button();
            this.LabDateTime = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.LabWeigSP = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.LabNetWeig = new System.Windows.Forms.Label();
            this.LabRawWeig = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.LabName = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.Label7 = new System.Windows.Forms.Label();
            this.LabWeightLoad = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnSetSpan
            // 
            this.BtnSetSpan.BackColor = System.Drawing.Color.Blue;
            this.BtnSetSpan.FlatAppearance.BorderSize = 0;
            this.BtnSetSpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSetSpan.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnSetSpan.ForeColor = System.Drawing.Color.White;
            this.BtnSetSpan.Location = new System.Drawing.Point(157, 283);
            this.BtnSetSpan.Name = "BtnSetSpan";
            this.BtnSetSpan.Size = new System.Drawing.Size(100, 50);
            this.BtnSetSpan.TabIndex = 156;
            this.BtnSetSpan.Text = "标定";
            this.BtnSetSpan.UseVisualStyleBackColor = false;
            this.BtnSetSpan.Click += new System.EventHandler(this.BtnSetSpan_Click);
            // 
            // BtnSetZero
            // 
            this.BtnSetZero.BackColor = System.Drawing.Color.Blue;
            this.BtnSetZero.FlatAppearance.BorderSize = 0;
            this.BtnSetZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSetZero.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnSetZero.ForeColor = System.Drawing.Color.White;
            this.BtnSetZero.Location = new System.Drawing.Point(157, 163);
            this.BtnSetZero.Name = "BtnSetZero";
            this.BtnSetZero.Size = new System.Drawing.Size(100, 50);
            this.BtnSetZero.TabIndex = 155;
            this.BtnSetZero.Text = "设零位";
            this.BtnSetZero.UseVisualStyleBackColor = false;
            this.BtnSetZero.Click += new System.EventHandler(this.BtnSetZero_Click);
            // 
            // LabDateTime
            // 
            this.LabDateTime.BackColor = System.Drawing.Color.Transparent;
            this.LabDateTime.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabDateTime.ForeColor = System.Drawing.Color.White;
            this.LabDateTime.Location = new System.Drawing.Point(153, 348);
            this.LabDateTime.Name = "LabDateTime";
            this.LabDateTime.Size = new System.Drawing.Size(221, 20);
            this.LabDateTime.TabIndex = 154;
            this.LabDateTime.Text = "2000-01-01 00:00:00";
            this.LabDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label13
            // 
            this.Label13.BackColor = System.Drawing.Color.Transparent;
            this.Label13.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label13.ForeColor = System.Drawing.Color.White;
            this.Label13.Location = new System.Drawing.Point(77, 348);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(70, 20);
            this.Label13.TabIndex = 153;
            this.Label13.Text = "已校准";
            this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label11
            // 
            this.Label11.BackColor = System.Drawing.Color.Transparent;
            this.Label11.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label11.ForeColor = System.Drawing.Color.White;
            this.Label11.Location = new System.Drawing.Point(262, 238);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(38, 20);
            this.Label11.TabIndex = 152;
            this.Label11.Text = "kg";
            this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabWeigSP
            // 
            this.LabWeigSP.BackColor = System.Drawing.Color.White;
            this.LabWeigSP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabWeigSP.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabWeigSP.ForeColor = System.Drawing.Color.Black;
            this.LabWeigSP.Location = new System.Drawing.Point(157, 223);
            this.LabWeigSP.Name = "LabWeigSP";
            this.LabWeigSP.Size = new System.Drawing.Size(100, 50);
            this.LabWeigSP.TabIndex = 151;
            this.LabWeigSP.Text = "0.00";
            this.LabWeigSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabWeigSP.TextChanged += new System.EventHandler(this.LabWeigSP_TextChanged);
            this.LabWeigSP.Click += new System.EventHandler(this.LabWeigSP_Click);
            // 
            // Label9
            // 
            this.Label9.BackColor = System.Drawing.Color.Transparent;
            this.Label9.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label9.ForeColor = System.Drawing.Color.White;
            this.Label9.Location = new System.Drawing.Point(61, 238);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(91, 20);
            this.Label9.TabIndex = 150;
            this.Label9.Text = "标定重量";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabNetWeig
            // 
            this.LabNetWeig.BackColor = System.Drawing.Color.Black;
            this.LabNetWeig.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabNetWeig.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabNetWeig.ForeColor = System.Drawing.Color.White;
            this.LabNetWeig.Location = new System.Drawing.Point(157, 103);
            this.LabNetWeig.Name = "LabNetWeig";
            this.LabNetWeig.Size = new System.Drawing.Size(100, 50);
            this.LabNetWeig.TabIndex = 149;
            this.LabNetWeig.Text = "0.00";
            this.LabNetWeig.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabRawWeig
            // 
            this.LabRawWeig.BackColor = System.Drawing.Color.Black;
            this.LabRawWeig.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabRawWeig.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabRawWeig.ForeColor = System.Drawing.Color.White;
            this.LabRawWeig.Location = new System.Drawing.Point(157, 43);
            this.LabRawWeig.Name = "LabRawWeig";
            this.LabRawWeig.Size = new System.Drawing.Size(100, 50);
            this.LabRawWeig.TabIndex = 148;
            this.LabRawWeig.Text = "0.00";
            this.LabRawWeig.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(262, 58);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(38, 20);
            this.Label5.TabIndex = 147;
            this.Label5.Text = "kg";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(262, 118);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(38, 20);
            this.Label4.TabIndex = 146;
            this.Label4.Text = "kg";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(61, 118);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(91, 20);
            this.Label2.TabIndex = 145;
            this.Label2.Text = "净重";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(61, 58);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(91, 20);
            this.Label1.TabIndex = 144;
            this.Label1.Text = "原始重量";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabName
            // 
            this.LabName.BackColor = System.Drawing.Color.Transparent;
            this.LabName.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabName.ForeColor = System.Drawing.Color.White;
            this.LabName.Location = new System.Drawing.Point(65, 6);
            this.LabName.Name = "LabName";
            this.LabName.Size = new System.Drawing.Size(245, 31);
            this.LabName.TabIndex = 143;
            this.LabName.Text = "称重校准";
            this.LabName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 500;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label7.ForeColor = System.Drawing.Color.White;
            this.Label7.Location = new System.Drawing.Point(436, 89);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(43, 20);
            this.Label7.TabIndex = 159;
            this.Label7.Text = "kg";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabWeightLoad
            // 
            this.LabWeightLoad.BackColor = System.Drawing.Color.White;
            this.LabWeightLoad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabWeightLoad.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabWeightLoad.ForeColor = System.Drawing.Color.Black;
            this.LabWeightLoad.Location = new System.Drawing.Point(331, 74);
            this.LabWeightLoad.Name = "LabWeightLoad";
            this.LabWeightLoad.Size = new System.Drawing.Size(100, 50);
            this.LabWeightLoad.TabIndex = 158;
            this.LabWeightLoad.Text = "0.00";
            this.LabWeightLoad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabWeightLoad.TextChanged += new System.EventHandler(this.LabWeightLoad_TextChanged);
            this.LabWeightLoad.Click += new System.EventHandler(this.LabWeightLoad_Click);
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(319, 46);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(132, 20);
            this.Label3.TabIndex = 157;
            this.Label3.Text = "重锤初始重量";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmWeightCalib
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(499, 380);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.LabWeightLoad);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.BtnSetSpan);
            this.Controls.Add(this.BtnSetZero);
            this.Controls.Add(this.LabDateTime);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.LabWeigSP);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.LabNetWeig);
            this.Controls.Add(this.LabRawWeig);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.LabName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmWeightCalib";
            this.Text = "FrmWeightCalib";
            this.Load += new System.EventHandler(this.FrmWeightCalib_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button BtnSetSpan;
        internal System.Windows.Forms.Button BtnSetZero;
        internal System.Windows.Forms.Label LabDateTime;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label LabWeigSP;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label LabNetWeig;
        internal System.Windows.Forms.Label LabRawWeig;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label LabName;
        private System.Windows.Forms.Timer Timer1;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label LabWeightLoad;
        internal System.Windows.Forms.Label Label3;
    }
}