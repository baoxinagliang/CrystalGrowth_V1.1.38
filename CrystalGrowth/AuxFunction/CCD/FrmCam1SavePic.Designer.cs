namespace CrystalGrowth.AuxFunction.CCD
{
    partial class FrmCam1SavePic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCam1SavePic));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.LabSaveInterval = new System.Windows.Forms.Label();
            this.LabName = new System.Windows.Forms.Label();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.LabFilePath = new System.Windows.Forms.Label();
            this.BtnSaveImg = new System.Windows.Forms.Button();
            this.BtnSelectPath = new System.Windows.Forms.Button();
            this.ClbJumpSave = new System.Windows.Forms.CheckedListBox();
            this.CbxSaveAll = new System.Windows.Forms.CheckBox();
            this.CbxSaveJump = new System.Windows.Forms.CheckBox();
            this.ClbFullSave = new System.Windows.Forms.CheckedListBox();
            this.CbxFullSelect = new System.Windows.Forms.CheckBox();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.DarkGray;
            this.Panel1.Controls.Add(this.label2);
            this.Panel1.Controls.Add(this.LabSaveInterval);
            this.Panel1.Controls.Add(this.LabName);
            resources.ApplyResources(this.Panel1, "Panel1");
            this.Panel1.Name = "Panel1";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // LabSaveInterval
            // 
            this.LabSaveInterval.BackColor = System.Drawing.Color.White;
            this.LabSaveInterval.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.LabSaveInterval, "LabSaveInterval");
            this.LabSaveInterval.ForeColor = System.Drawing.Color.Black;
            this.LabSaveInterval.Name = "LabSaveInterval";
            this.LabSaveInterval.Click += new System.EventHandler(this.LabSaveInterval_Click);
            // 
            // LabName
            // 
            this.LabName.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.LabName, "LabName");
            this.LabName.ForeColor = System.Drawing.Color.Black;
            this.LabName.Name = "LabName";
            // 
            // BtnQuit
            // 
            this.BtnQuit.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnQuit.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.BtnQuit, "BtnQuit");
            this.BtnQuit.ForeColor = System.Drawing.Color.White;
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.UseVisualStyleBackColor = false;
            this.BtnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 500;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // LabFilePath
            // 
            resources.ApplyResources(this.LabFilePath, "LabFilePath");
            this.LabFilePath.ForeColor = System.Drawing.Color.Lime;
            this.LabFilePath.Name = "LabFilePath";
            // 
            // BtnSaveImg
            // 
            this.BtnSaveImg.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnSaveImg.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.BtnSaveImg, "BtnSaveImg");
            this.BtnSaveImg.ForeColor = System.Drawing.Color.White;
            this.BtnSaveImg.Name = "BtnSaveImg";
            this.BtnSaveImg.UseVisualStyleBackColor = false;
            this.BtnSaveImg.Click += new System.EventHandler(this.BtnSaveImg_Click);
            // 
            // BtnSelectPath
            // 
            this.BtnSelectPath.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnSelectPath.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.BtnSelectPath, "BtnSelectPath");
            this.BtnSelectPath.ForeColor = System.Drawing.Color.White;
            this.BtnSelectPath.Name = "BtnSelectPath";
            this.BtnSelectPath.UseVisualStyleBackColor = false;
            this.BtnSelectPath.Click += new System.EventHandler(this.BtnSelectPath_Click);
            // 
            // ClbJumpSave
            // 
            this.ClbJumpSave.CheckOnClick = true;
            this.ClbJumpSave.FormattingEnabled = true;
            resources.ApplyResources(this.ClbJumpSave, "ClbJumpSave");
            this.ClbJumpSave.Name = "ClbJumpSave";
            this.ClbJumpSave.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // CbxSaveAll
            // 
            resources.ApplyResources(this.CbxSaveAll, "CbxSaveAll");
            this.CbxSaveAll.ForeColor = System.Drawing.Color.White;
            this.CbxSaveAll.Name = "CbxSaveAll";
            this.CbxSaveAll.UseVisualStyleBackColor = true;
            this.CbxSaveAll.CheckedChanged += new System.EventHandler(this.CbxSaveAll_CheckedChanged);
            // 
            // CbxSaveJump
            // 
            resources.ApplyResources(this.CbxSaveJump, "CbxSaveJump");
            this.CbxSaveJump.ForeColor = System.Drawing.Color.White;
            this.CbxSaveJump.Name = "CbxSaveJump";
            this.CbxSaveJump.UseVisualStyleBackColor = true;
            this.CbxSaveJump.CheckedChanged += new System.EventHandler(this.CbxSaveJump_CheckedChanged);
            // 
            // ClbFullSave
            // 
            this.ClbFullSave.CheckOnClick = true;
            this.ClbFullSave.FormattingEnabled = true;
            resources.ApplyResources(this.ClbFullSave, "ClbFullSave");
            this.ClbFullSave.Name = "ClbFullSave";
            this.ClbFullSave.SelectedIndexChanged += new System.EventHandler(this.ClbFullSave_SelectedIndexChanged);
            // 
            // CbxFullSelect
            // 
            resources.ApplyResources(this.CbxFullSelect, "CbxFullSelect");
            this.CbxFullSelect.ForeColor = System.Drawing.Color.White;
            this.CbxFullSelect.Name = "CbxFullSelect";
            this.CbxFullSelect.UseVisualStyleBackColor = true;
            this.CbxFullSelect.CheckedChanged += new System.EventHandler(this.CbxFullSelect_CheckedChanged);
            // 
            // FrmCam1SavePic
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.CbxFullSelect);
            this.Controls.Add(this.ClbFullSave);
            this.Controls.Add(this.CbxSaveJump);
            this.Controls.Add(this.CbxSaveAll);
            this.Controls.Add(this.ClbJumpSave);
            this.Controls.Add(this.BtnSaveImg);
            this.Controls.Add(this.BtnSelectPath);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.LabFilePath);
            this.Controls.Add(this.BtnQuit);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCam1SavePic";
            this.Load += new System.EventHandler(this.FrmCam1Adjust_Load);
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label LabName;
        internal System.Windows.Forms.Button BtnQuit;
        internal System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Label LabFilePath;
        internal System.Windows.Forms.Button BtnSaveImg;
        internal System.Windows.Forms.Button BtnSelectPath;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label LabSaveInterval;
        private System.Windows.Forms.CheckedListBox ClbJumpSave;
        private System.Windows.Forms.CheckBox CbxSaveAll;
        private System.Windows.Forms.CheckBox CbxSaveJump;
        private System.Windows.Forms.CheckedListBox ClbFullSave;
        private System.Windows.Forms.CheckBox CbxFullSelect;
    }
}