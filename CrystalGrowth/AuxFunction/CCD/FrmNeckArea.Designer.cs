namespace CrystalGrowth.AuxFunction.CCD
{
    partial class FrmNeckArea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNeckArea));
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.BtnSave = new System.Windows.Forms.Button();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.LabNeckArrayNum = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LabThreshold = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.BtnBottomYOffsetAdd = new System.Windows.Forms.Button();
            this.BtnBottomYOffsetSub = new System.Windows.Forms.Button();
            this.BtnTopYOffsetAdd = new System.Windows.Forms.Button();
            this.LabTopYOffsetSub = new System.Windows.Forms.Button();
            this.BtnRightXOffsetSub = new System.Windows.Forms.Button();
            this.BtnRightXOffsetAdd = new System.Windows.Forms.Button();
            this.BtnLeftXOffsetSub = new System.Windows.Forms.Button();
            this.BtnLeftXOffsetAdd = new System.Windows.Forms.Button();
            this.LabBottomYOffset = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.LabTopYOffset = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.LabRightXOffset = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.LabLeftXOffset = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.LabName = new System.Windows.Forms.Label();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.LabDis = new System.Windows.Forms.Label();
            this.Panel3.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 250;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
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
            this.BtnSave.TabIndex = 176;
            this.BtnSave.Text = "保存";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.DarkGray;
            this.Panel3.Controls.Add(this.LabNeckArrayNum);
            this.Panel3.Controls.Add(this.label4);
            this.Panel3.Controls.Add(this.LabThreshold);
            this.Panel3.Controls.Add(this.Label7);
            this.Panel3.Location = new System.Drawing.Point(14, 357);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(354, 110);
            this.Panel3.TabIndex = 175;
            // 
            // LabNeckArrayNum
            // 
            this.LabNeckArrayNum.BackColor = System.Drawing.Color.White;
            this.LabNeckArrayNum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabNeckArrayNum.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabNeckArrayNum.ForeColor = System.Drawing.Color.Black;
            this.LabNeckArrayNum.Location = new System.Drawing.Point(199, 7);
            this.LabNeckArrayNum.Name = "LabNeckArrayNum";
            this.LabNeckArrayNum.Size = new System.Drawing.Size(97, 40);
            this.LabNeckArrayNum.TabIndex = 166;
            this.LabNeckArrayNum.Text = "0";
            this.LabNeckArrayNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabNeckArrayNum.Click += new System.EventHandler(this.LabNeckArrayNum_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 40);
            this.label4.TabIndex = 165;
            this.label4.Text = "滤波值:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabThreshold
            // 
            this.LabThreshold.BackColor = System.Drawing.Color.White;
            this.LabThreshold.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabThreshold.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabThreshold.ForeColor = System.Drawing.Color.Black;
            this.LabThreshold.Location = new System.Drawing.Point(199, 60);
            this.LabThreshold.Name = "LabThreshold";
            this.LabThreshold.Size = new System.Drawing.Size(97, 40);
            this.LabThreshold.TabIndex = 164;
            this.LabThreshold.Text = "0";
            this.LabThreshold.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabThreshold.Click += new System.EventHandler(this.LabThreshold_Click);
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label7.ForeColor = System.Drawing.Color.White;
            this.Label7.Location = new System.Drawing.Point(15, 60);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(130, 40);
            this.Label7.TabIndex = 163;
            this.Label7.Text = "阈值:";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.DarkGray;
            this.Panel2.Controls.Add(this.BtnBottomYOffsetAdd);
            this.Panel2.Controls.Add(this.BtnBottomYOffsetSub);
            this.Panel2.Controls.Add(this.BtnTopYOffsetAdd);
            this.Panel2.Controls.Add(this.LabTopYOffsetSub);
            this.Panel2.Controls.Add(this.BtnRightXOffsetSub);
            this.Panel2.Controls.Add(this.BtnRightXOffsetAdd);
            this.Panel2.Controls.Add(this.BtnLeftXOffsetSub);
            this.Panel2.Controls.Add(this.BtnLeftXOffsetAdd);
            this.Panel2.Controls.Add(this.LabBottomYOffset);
            this.Panel2.Controls.Add(this.Label6);
            this.Panel2.Controls.Add(this.LabTopYOffset);
            this.Panel2.Controls.Add(this.Label3);
            this.Panel2.Controls.Add(this.LabRightXOffset);
            this.Panel2.Controls.Add(this.Label5);
            this.Panel2.Controls.Add(this.LabLeftXOffset);
            this.Panel2.Controls.Add(this.Label2);
            this.Panel2.Controls.Add(this.LabName);
            this.Panel2.Location = new System.Drawing.Point(13, 11);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(355, 340);
            this.Panel2.TabIndex = 174;
            // 
            // BtnBottomYOffsetAdd
            // 
            this.BtnBottomYOffsetAdd.BackColor = System.Drawing.Color.White;
            this.BtnBottomYOffsetAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnBottomYOffsetAdd.BackgroundImage")));
            this.BtnBottomYOffsetAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBottomYOffsetAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnBottomYOffsetAdd.FlatAppearance.BorderSize = 0;
            this.BtnBottomYOffsetAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBottomYOffsetAdd.Location = new System.Drawing.Point(153, 278);
            this.BtnBottomYOffsetAdd.Name = "BtnBottomYOffsetAdd";
            this.BtnBottomYOffsetAdd.Size = new System.Drawing.Size(40, 40);
            this.BtnBottomYOffsetAdd.TabIndex = 204;
            this.BtnBottomYOffsetAdd.UseVisualStyleBackColor = false;
            this.BtnBottomYOffsetAdd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnBottomYOffsetAdd_MouseDown);
            this.BtnBottomYOffsetAdd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnBottomYOffsetAdd_MouseUp);
            // 
            // BtnBottomYOffsetSub
            // 
            this.BtnBottomYOffsetSub.BackColor = System.Drawing.Color.White;
            this.BtnBottomYOffsetSub.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnBottomYOffsetSub.BackgroundImage")));
            this.BtnBottomYOffsetSub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBottomYOffsetSub.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnBottomYOffsetSub.FlatAppearance.BorderSize = 0;
            this.BtnBottomYOffsetSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBottomYOffsetSub.Location = new System.Drawing.Point(302, 278);
            this.BtnBottomYOffsetSub.Name = "BtnBottomYOffsetSub";
            this.BtnBottomYOffsetSub.Size = new System.Drawing.Size(40, 40);
            this.BtnBottomYOffsetSub.TabIndex = 203;
            this.BtnBottomYOffsetSub.UseVisualStyleBackColor = false;
            this.BtnBottomYOffsetSub.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnBottomYOffsetSub_MouseDown);
            this.BtnBottomYOffsetSub.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnBottomYOffsetSub_MouseUp);
            // 
            // BtnTopYOffsetAdd
            // 
            this.BtnTopYOffsetAdd.BackColor = System.Drawing.Color.White;
            this.BtnTopYOffsetAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnTopYOffsetAdd.BackgroundImage")));
            this.BtnTopYOffsetAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnTopYOffsetAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnTopYOffsetAdd.FlatAppearance.BorderSize = 0;
            this.BtnTopYOffsetAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTopYOffsetAdd.Location = new System.Drawing.Point(153, 204);
            this.BtnTopYOffsetAdd.Name = "BtnTopYOffsetAdd";
            this.BtnTopYOffsetAdd.Size = new System.Drawing.Size(40, 40);
            this.BtnTopYOffsetAdd.TabIndex = 202;
            this.BtnTopYOffsetAdd.UseVisualStyleBackColor = false;
            this.BtnTopYOffsetAdd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnTopYOffsetAdd_MouseDown);
            this.BtnTopYOffsetAdd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnTopYOffsetAdd_MouseUp);
            // 
            // LabTopYOffsetSub
            // 
            this.LabTopYOffsetSub.BackColor = System.Drawing.Color.White;
            this.LabTopYOffsetSub.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LabTopYOffsetSub.BackgroundImage")));
            this.LabTopYOffsetSub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LabTopYOffsetSub.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabTopYOffsetSub.FlatAppearance.BorderSize = 0;
            this.LabTopYOffsetSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabTopYOffsetSub.Location = new System.Drawing.Point(302, 204);
            this.LabTopYOffsetSub.Name = "LabTopYOffsetSub";
            this.LabTopYOffsetSub.Size = new System.Drawing.Size(40, 40);
            this.LabTopYOffsetSub.TabIndex = 201;
            this.LabTopYOffsetSub.UseVisualStyleBackColor = false;
            this.LabTopYOffsetSub.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabTopYOffsetSub_MouseDown);
            this.LabTopYOffsetSub.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LabTopYOffsetSub_MouseUp);
            // 
            // BtnRightXOffsetSub
            // 
            this.BtnRightXOffsetSub.BackColor = System.Drawing.Color.White;
            this.BtnRightXOffsetSub.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnRightXOffsetSub.BackgroundImage")));
            this.BtnRightXOffsetSub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRightXOffsetSub.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnRightXOffsetSub.FlatAppearance.BorderSize = 0;
            this.BtnRightXOffsetSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRightXOffsetSub.Location = new System.Drawing.Point(153, 130);
            this.BtnRightXOffsetSub.Name = "BtnRightXOffsetSub";
            this.BtnRightXOffsetSub.Size = new System.Drawing.Size(40, 40);
            this.BtnRightXOffsetSub.TabIndex = 200;
            this.BtnRightXOffsetSub.UseVisualStyleBackColor = false;
            this.BtnRightXOffsetSub.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnRightXOffsetSub_MouseDown);
            this.BtnRightXOffsetSub.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnRightXOffsetSub_MouseUp);
            // 
            // BtnRightXOffsetAdd
            // 
            this.BtnRightXOffsetAdd.BackColor = System.Drawing.Color.White;
            this.BtnRightXOffsetAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnRightXOffsetAdd.BackgroundImage")));
            this.BtnRightXOffsetAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRightXOffsetAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnRightXOffsetAdd.FlatAppearance.BorderSize = 0;
            this.BtnRightXOffsetAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRightXOffsetAdd.Location = new System.Drawing.Point(302, 130);
            this.BtnRightXOffsetAdd.Name = "BtnRightXOffsetAdd";
            this.BtnRightXOffsetAdd.Size = new System.Drawing.Size(40, 40);
            this.BtnRightXOffsetAdd.TabIndex = 199;
            this.BtnRightXOffsetAdd.UseVisualStyleBackColor = false;
            this.BtnRightXOffsetAdd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnRightXOffsetAdd_MouseDown);
            this.BtnRightXOffsetAdd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnRightXOffsetAdd_MouseUp);
            // 
            // BtnLeftXOffsetSub
            // 
            this.BtnLeftXOffsetSub.BackColor = System.Drawing.Color.White;
            this.BtnLeftXOffsetSub.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnLeftXOffsetSub.BackgroundImage")));
            this.BtnLeftXOffsetSub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnLeftXOffsetSub.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnLeftXOffsetSub.FlatAppearance.BorderSize = 0;
            this.BtnLeftXOffsetSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLeftXOffsetSub.Location = new System.Drawing.Point(153, 56);
            this.BtnLeftXOffsetSub.Name = "BtnLeftXOffsetSub";
            this.BtnLeftXOffsetSub.Size = new System.Drawing.Size(40, 40);
            this.BtnLeftXOffsetSub.TabIndex = 198;
            this.BtnLeftXOffsetSub.UseVisualStyleBackColor = false;
            this.BtnLeftXOffsetSub.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnLeftXOffsetSub_MouseDown);
            this.BtnLeftXOffsetSub.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnLeftXOffsetSub_MouseUp);
            // 
            // BtnLeftXOffsetAdd
            // 
            this.BtnLeftXOffsetAdd.BackColor = System.Drawing.Color.White;
            this.BtnLeftXOffsetAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnLeftXOffsetAdd.BackgroundImage")));
            this.BtnLeftXOffsetAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnLeftXOffsetAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnLeftXOffsetAdd.FlatAppearance.BorderSize = 0;
            this.BtnLeftXOffsetAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLeftXOffsetAdd.Location = new System.Drawing.Point(302, 56);
            this.BtnLeftXOffsetAdd.Name = "BtnLeftXOffsetAdd";
            this.BtnLeftXOffsetAdd.Size = new System.Drawing.Size(40, 40);
            this.BtnLeftXOffsetAdd.TabIndex = 197;
            this.BtnLeftXOffsetAdd.UseVisualStyleBackColor = false;
            this.BtnLeftXOffsetAdd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnLeftXOffsetAdd_MouseDown);
            this.BtnLeftXOffsetAdd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnLeftXOffsetAdd_MouseUp);
            // 
            // LabBottomYOffset
            // 
            this.LabBottomYOffset.BackColor = System.Drawing.Color.White;
            this.LabBottomYOffset.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabBottomYOffset.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabBottomYOffset.ForeColor = System.Drawing.Color.Black;
            this.LabBottomYOffset.Location = new System.Drawing.Point(199, 278);
            this.LabBottomYOffset.Name = "LabBottomYOffset";
            this.LabBottomYOffset.Size = new System.Drawing.Size(97, 40);
            this.LabBottomYOffset.TabIndex = 184;
            this.LabBottomYOffset.Text = "0";
            this.LabBottomYOffset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabBottomYOffset.Click += new System.EventHandler(this.LabBottomYOffset_Click);
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label6.ForeColor = System.Drawing.Color.White;
            this.Label6.Location = new System.Drawing.Point(15, 278);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(130, 40);
            this.Label6.TabIndex = 183;
            this.Label6.Text = "下边线Y:";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabTopYOffset
            // 
            this.LabTopYOffset.BackColor = System.Drawing.Color.White;
            this.LabTopYOffset.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabTopYOffset.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabTopYOffset.ForeColor = System.Drawing.Color.Black;
            this.LabTopYOffset.Location = new System.Drawing.Point(199, 204);
            this.LabTopYOffset.Name = "LabTopYOffset";
            this.LabTopYOffset.Size = new System.Drawing.Size(97, 40);
            this.LabTopYOffset.TabIndex = 182;
            this.LabTopYOffset.Text = "0";
            this.LabTopYOffset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabTopYOffset.Click += new System.EventHandler(this.LabTopYOffset_Click);
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(15, 204);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(130, 40);
            this.Label3.TabIndex = 181;
            this.Label3.Text = "上边线Y:";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabRightXOffset
            // 
            this.LabRightXOffset.BackColor = System.Drawing.Color.White;
            this.LabRightXOffset.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabRightXOffset.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabRightXOffset.ForeColor = System.Drawing.Color.Black;
            this.LabRightXOffset.Location = new System.Drawing.Point(199, 130);
            this.LabRightXOffset.Name = "LabRightXOffset";
            this.LabRightXOffset.Size = new System.Drawing.Size(97, 40);
            this.LabRightXOffset.TabIndex = 180;
            this.LabRightXOffset.Text = "0";
            this.LabRightXOffset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabRightXOffset.Click += new System.EventHandler(this.LabRightXOffset_Click);
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(15, 130);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(130, 40);
            this.Label5.TabIndex = 179;
            this.Label5.Text = "右边线X:";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabLeftXOffset
            // 
            this.LabLeftXOffset.BackColor = System.Drawing.Color.White;
            this.LabLeftXOffset.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabLeftXOffset.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabLeftXOffset.ForeColor = System.Drawing.Color.Black;
            this.LabLeftXOffset.Location = new System.Drawing.Point(199, 56);
            this.LabLeftXOffset.Name = "LabLeftXOffset";
            this.LabLeftXOffset.Size = new System.Drawing.Size(97, 40);
            this.LabLeftXOffset.TabIndex = 178;
            this.LabLeftXOffset.Text = "0";
            this.LabLeftXOffset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabLeftXOffset.Click += new System.EventHandler(this.LabLeftXOffset_Click);
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(15, 56);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(130, 40);
            this.Label2.TabIndex = 177;
            this.Label2.Text = "左边线X:";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabName
            // 
            this.LabName.BackColor = System.Drawing.Color.Transparent;
            this.LabName.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabName.ForeColor = System.Drawing.Color.Black;
            this.LabName.Location = new System.Drawing.Point(77, 4);
            this.LabName.Name = "LabName";
            this.LabName.Size = new System.Drawing.Size(200, 40);
            this.LabName.TabIndex = 172;
            this.LabName.Text = "引晶区域";
            this.LabName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.BtnQuit.TabIndex = 173;
            this.BtnQuit.Text = "返回";
            this.BtnQuit.UseVisualStyleBackColor = false;
            this.BtnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // LabDis
            // 
            this.LabDis.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabDis.ForeColor = System.Drawing.Color.Red;
            this.LabDis.Location = new System.Drawing.Point(14, 470);
            this.LabDis.Name = "LabDis";
            this.LabDis.Size = new System.Drawing.Size(354, 23);
            this.LabDis.TabIndex = 186;
            this.LabDis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmNeckArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(380, 638);
            this.Controls.Add(this.LabDis);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.BtnQuit);
            this.Controls.Add(this.Panel3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNeckArea";
            this.Text = "FrmNeckArea";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmNeckArea_FormClosed);
            this.Load += new System.EventHandler(this.FrmNeckArea_Load);
            this.Panel3.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Timer1;
        internal System.Windows.Forms.Button BtnSave;
        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.Label LabThreshold;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Button BtnBottomYOffsetAdd;
        internal System.Windows.Forms.Button BtnBottomYOffsetSub;
        internal System.Windows.Forms.Button BtnTopYOffsetAdd;
        internal System.Windows.Forms.Button LabTopYOffsetSub;
        internal System.Windows.Forms.Button BtnRightXOffsetSub;
        internal System.Windows.Forms.Button BtnRightXOffsetAdd;
        internal System.Windows.Forms.Button BtnLeftXOffsetSub;
        internal System.Windows.Forms.Button BtnLeftXOffsetAdd;
        internal System.Windows.Forms.Label LabBottomYOffset;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label LabTopYOffset;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label LabRightXOffset;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label LabLeftXOffset;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label LabName;
        internal System.Windows.Forms.Button BtnQuit;
        private System.Windows.Forms.Label LabDis;
        internal System.Windows.Forms.Label LabNeckArrayNum;
        internal System.Windows.Forms.Label label4;
    }
}