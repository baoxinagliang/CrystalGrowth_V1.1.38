namespace CrystalGrowth.CrystalCtl
{
    partial class FrmShieldPos
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
            this.BtnBoxCtl = new System.Windows.Forms.Button();
            this.BtnForce = new System.Windows.Forms.Button();
            this.BtnManu = new System.Windows.Forms.Button();
            this.BtnAuto = new System.Windows.Forms.Button();
            this.BtnShieldDown = new System.Windows.Forms.Button();
            this.BtnShieldUp = new System.Windows.Forms.Button();
            this.BtnLoc = new System.Windows.Forms.Button();
            this.LabMasterLocSP = new System.Windows.Forms.Label();
            this.LabMasterLocPV = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.LabName = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.LabMasterTorque = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LabSlaveTorque = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.LabSlaveLocSP = new System.Windows.Forms.Label();
            this.LabSlaveLocPV = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.BtnMaster = new System.Windows.Forms.Button();
            this.BtnSingeCtl = new System.Windows.Forms.Button();
            this.LabMasterSpeed = new System.Windows.Forms.Label();
            this.LabSlaveSpeed = new System.Windows.Forms.Label();
            this.BtnSlave = new System.Windows.Forms.Button();
            this.BtnJointCtl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnBoxCtl
            // 
            this.BtnBoxCtl.BackColor = System.Drawing.Color.Blue;
            this.BtnBoxCtl.FlatAppearance.BorderSize = 0;
            this.BtnBoxCtl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBoxCtl.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnBoxCtl.ForeColor = System.Drawing.Color.White;
            this.BtnBoxCtl.Location = new System.Drawing.Point(453, 426);
            this.BtnBoxCtl.Name = "BtnBoxCtl";
            this.BtnBoxCtl.Size = new System.Drawing.Size(117, 55);
            this.BtnBoxCtl.TabIndex = 110;
            this.BtnBoxCtl.Text = "手柄控制";
            this.BtnBoxCtl.UseVisualStyleBackColor = false;
            this.BtnBoxCtl.Click += new System.EventHandler(this.BtnBoxCtl_Click);
            // 
            // BtnForce
            // 
            this.BtnForce.BackColor = System.Drawing.Color.Blue;
            this.BtnForce.FlatAppearance.BorderSize = 0;
            this.BtnForce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnForce.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnForce.ForeColor = System.Drawing.Color.White;
            this.BtnForce.Location = new System.Drawing.Point(306, 426);
            this.BtnForce.Name = "BtnForce";
            this.BtnForce.Size = new System.Drawing.Size(117, 55);
            this.BtnForce.TabIndex = 122;
            this.BtnForce.Text = "强制升降";
            this.BtnForce.UseVisualStyleBackColor = false;
            this.BtnForce.Click += new System.EventHandler(this.BtnForce_Click);
            // 
            // BtnManu
            // 
            this.BtnManu.BackColor = System.Drawing.Color.Blue;
            this.BtnManu.FlatAppearance.BorderSize = 0;
            this.BtnManu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnManu.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnManu.ForeColor = System.Drawing.Color.White;
            this.BtnManu.Location = new System.Drawing.Point(12, 426);
            this.BtnManu.Name = "BtnManu";
            this.BtnManu.Size = new System.Drawing.Size(117, 55);
            this.BtnManu.TabIndex = 134;
            this.BtnManu.Text = "手动";
            this.BtnManu.UseVisualStyleBackColor = false;
            this.BtnManu.Click += new System.EventHandler(this.BtnManu_Click);
            // 
            // BtnAuto
            // 
            this.BtnAuto.BackColor = System.Drawing.Color.Blue;
            this.BtnAuto.FlatAppearance.BorderSize = 0;
            this.BtnAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAuto.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnAuto.ForeColor = System.Drawing.Color.White;
            this.BtnAuto.Location = new System.Drawing.Point(159, 426);
            this.BtnAuto.Name = "BtnAuto";
            this.BtnAuto.Size = new System.Drawing.Size(117, 55);
            this.BtnAuto.TabIndex = 135;
            this.BtnAuto.Text = "自动";
            this.BtnAuto.UseVisualStyleBackColor = false;
            this.BtnAuto.Click += new System.EventHandler(this.BtnAuto_Click);
            // 
            // BtnShieldDown
            // 
            this.BtnShieldDown.BackColor = System.Drawing.Color.Blue;
            this.BtnShieldDown.FlatAppearance.BorderSize = 0;
            this.BtnShieldDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShieldDown.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnShieldDown.ForeColor = System.Drawing.Color.White;
            this.BtnShieldDown.Location = new System.Drawing.Point(357, 354);
            this.BtnShieldDown.Name = "BtnShieldDown";
            this.BtnShieldDown.Size = new System.Drawing.Size(100, 55);
            this.BtnShieldDown.TabIndex = 138;
            this.BtnShieldDown.Text = "下降";
            this.BtnShieldDown.UseVisualStyleBackColor = false;
            this.BtnShieldDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnShieldDown_MouseDown);
            this.BtnShieldDown.MouseLeave += new System.EventHandler(this.BtnShieldDown_MouseLeave);
            this.BtnShieldDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnShieldDown_MouseUp);
            // 
            // BtnShieldUp
            // 
            this.BtnShieldUp.BackColor = System.Drawing.Color.Blue;
            this.BtnShieldUp.FlatAppearance.BorderSize = 0;
            this.BtnShieldUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShieldUp.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnShieldUp.ForeColor = System.Drawing.Color.White;
            this.BtnShieldUp.Location = new System.Drawing.Point(242, 354);
            this.BtnShieldUp.Name = "BtnShieldUp";
            this.BtnShieldUp.Size = new System.Drawing.Size(100, 55);
            this.BtnShieldUp.TabIndex = 137;
            this.BtnShieldUp.Text = "提升";
            this.BtnShieldUp.UseVisualStyleBackColor = false;
            this.BtnShieldUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnShieldUp_MouseDown);
            this.BtnShieldUp.MouseLeave += new System.EventHandler(this.BtnShieldUp_MouseLeave);
            this.BtnShieldUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnShieldUp_MouseUp);
            // 
            // BtnLoc
            // 
            this.BtnLoc.BackColor = System.Drawing.Color.Blue;
            this.BtnLoc.FlatAppearance.BorderSize = 0;
            this.BtnLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLoc.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnLoc.ForeColor = System.Drawing.Color.White;
            this.BtnLoc.Location = new System.Drawing.Point(472, 354);
            this.BtnLoc.Name = "BtnLoc";
            this.BtnLoc.Size = new System.Drawing.Size(100, 55);
            this.BtnLoc.TabIndex = 136;
            this.BtnLoc.Text = "定位";
            this.BtnLoc.UseVisualStyleBackColor = false;
            this.BtnLoc.Click += new System.EventHandler(this.BtnLoc_Click);
            // 
            // LabMasterLocSP
            // 
            this.LabMasterLocSP.BackColor = System.Drawing.Color.White;
            this.LabMasterLocSP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabMasterLocSP.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabMasterLocSP.ForeColor = System.Drawing.Color.Black;
            this.LabMasterLocSP.Location = new System.Drawing.Point(128, 111);
            this.LabMasterLocSP.Name = "LabMasterLocSP";
            this.LabMasterLocSP.Size = new System.Drawing.Size(100, 50);
            this.LabMasterLocSP.TabIndex = 133;
            this.LabMasterLocSP.Text = "0.0";
            this.LabMasterLocSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabMasterLocSP.Click += new System.EventHandler(this.LabSP_Click);
            // 
            // LabMasterLocPV
            // 
            this.LabMasterLocPV.BackColor = System.Drawing.Color.Black;
            this.LabMasterLocPV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabMasterLocPV.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabMasterLocPV.ForeColor = System.Drawing.Color.White;
            this.LabMasterLocPV.Location = new System.Drawing.Point(128, 54);
            this.LabMasterLocPV.Name = "LabMasterLocPV";
            this.LabMasterLocPV.Size = new System.Drawing.Size(100, 50);
            this.LabMasterLocPV.TabIndex = 132;
            this.LabMasterLocPV.Text = "0.0";
            this.LabMasterLocPV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(236, 69);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(32, 20);
            this.Label5.TabIndex = 131;
            this.Label5.Text = "mm";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(236, 124);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(32, 20);
            this.Label4.TabIndex = 130;
            this.Label4.Text = "mm";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(22, 113);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(100, 48);
            this.Label2.TabIndex = 129;
            this.Label2.Text = "主轴目标位置";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(22, 56);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(100, 48);
            this.Label1.TabIndex = 128;
            this.Label1.Text = "主轴当前位置";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabName
            // 
            this.LabName.BackColor = System.Drawing.Color.Transparent;
            this.LabName.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabName.ForeColor = System.Drawing.Color.White;
            this.LabName.Location = new System.Drawing.Point(215, 9);
            this.LabName.Name = "LabName";
            this.LabName.Size = new System.Drawing.Size(164, 31);
            this.LabName.TabIndex = 127;
            this.LabName.Text = "热屏电机";
            this.LabName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 500;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // LabMasterTorque
            // 
            this.LabMasterTorque.BackColor = System.Drawing.Color.Black;
            this.LabMasterTorque.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabMasterTorque.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabMasterTorque.ForeColor = System.Drawing.Color.White;
            this.LabMasterTorque.Location = new System.Drawing.Point(128, 168);
            this.LabMasterTorque.Name = "LabMasterTorque";
            this.LabMasterTorque.Size = new System.Drawing.Size(100, 50);
            this.LabMasterTorque.TabIndex = 143;
            this.LabMasterTorque.Text = "0.0";
            this.LabMasterTorque.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label6.ForeColor = System.Drawing.Color.White;
            this.Label6.Location = new System.Drawing.Point(236, 179);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(32, 20);
            this.Label6.TabIndex = 142;
            this.Label6.Text = "%";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(22, 183);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(100, 20);
            this.Label3.TabIndex = 141;
            this.Label3.Text = "主轴扭矩";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(22, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 144;
            this.label7.Text = "主轴速度";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(305, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 20);
            this.label10.TabIndex = 155;
            this.label10.Text = "从轴速度";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabSlaveTorque
            // 
            this.LabSlaveTorque.BackColor = System.Drawing.Color.Black;
            this.LabSlaveTorque.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabSlaveTorque.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabSlaveTorque.ForeColor = System.Drawing.Color.White;
            this.LabSlaveTorque.Location = new System.Drawing.Point(411, 168);
            this.LabSlaveTorque.Name = "LabSlaveTorque";
            this.LabSlaveTorque.Size = new System.Drawing.Size(100, 50);
            this.LabSlaveTorque.TabIndex = 154;
            this.LabSlaveTorque.Text = "0.0";
            this.LabSlaveTorque.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(519, 179);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 20);
            this.label12.TabIndex = 153;
            this.label12.Text = "%";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(305, 179);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 20);
            this.label13.TabIndex = 152;
            this.label13.Text = "从轴扭矩";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabSlaveLocSP
            // 
            this.LabSlaveLocSP.BackColor = System.Drawing.Color.White;
            this.LabSlaveLocSP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabSlaveLocSP.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabSlaveLocSP.ForeColor = System.Drawing.Color.Black;
            this.LabSlaveLocSP.Location = new System.Drawing.Point(411, 111);
            this.LabSlaveLocSP.Name = "LabSlaveLocSP";
            this.LabSlaveLocSP.Size = new System.Drawing.Size(100, 50);
            this.LabSlaveLocSP.TabIndex = 151;
            this.LabSlaveLocSP.Text = "0.0";
            this.LabSlaveLocSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabSlaveLocPV
            // 
            this.LabSlaveLocPV.BackColor = System.Drawing.Color.Black;
            this.LabSlaveLocPV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabSlaveLocPV.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabSlaveLocPV.ForeColor = System.Drawing.Color.White;
            this.LabSlaveLocPV.Location = new System.Drawing.Point(413, 52);
            this.LabSlaveLocPV.Name = "LabSlaveLocPV";
            this.LabSlaveLocPV.Size = new System.Drawing.Size(100, 50);
            this.LabSlaveLocPV.TabIndex = 150;
            this.LabSlaveLocPV.Text = "0.0";
            this.LabSlaveLocPV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(519, 69);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 20);
            this.label16.TabIndex = 149;
            this.label16.Text = "mm";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(519, 124);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 20);
            this.label17.TabIndex = 148;
            this.label17.Text = "mm";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(305, 111);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 48);
            this.label18.TabIndex = 147;
            this.label18.Text = "从轴目标位置";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(305, 54);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 48);
            this.label19.TabIndex = 146;
            this.label19.Text = "从轴当前位置";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnMaster
            // 
            this.BtnMaster.BackColor = System.Drawing.Color.Blue;
            this.BtnMaster.FlatAppearance.BorderSize = 0;
            this.BtnMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMaster.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnMaster.ForeColor = System.Drawing.Color.White;
            this.BtnMaster.Location = new System.Drawing.Point(128, 282);
            this.BtnMaster.Name = "BtnMaster";
            this.BtnMaster.Size = new System.Drawing.Size(100, 55);
            this.BtnMaster.TabIndex = 157;
            this.BtnMaster.Text = "主轴";
            this.BtnMaster.UseVisualStyleBackColor = false;
            this.BtnMaster.Click += new System.EventHandler(this.BtnMaster_Click);
            // 
            // BtnSingeCtl
            // 
            this.BtnSingeCtl.BackColor = System.Drawing.Color.Blue;
            this.BtnSingeCtl.FlatAppearance.BorderSize = 0;
            this.BtnSingeCtl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSingeCtl.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnSingeCtl.ForeColor = System.Drawing.Color.White;
            this.BtnSingeCtl.Location = new System.Drawing.Point(127, 354);
            this.BtnSingeCtl.Name = "BtnSingeCtl";
            this.BtnSingeCtl.Size = new System.Drawing.Size(100, 55);
            this.BtnSingeCtl.TabIndex = 158;
            this.BtnSingeCtl.Text = "单控";
            this.BtnSingeCtl.UseVisualStyleBackColor = false;
            this.BtnSingeCtl.Visible = false;
            this.BtnSingeCtl.Click += new System.EventHandler(this.BtnSingeCtl_Click);
            // 
            // LabMasterSpeed
            // 
            this.LabMasterSpeed.BackColor = System.Drawing.Color.Black;
            this.LabMasterSpeed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabMasterSpeed.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabMasterSpeed.ForeColor = System.Drawing.Color.White;
            this.LabMasterSpeed.Location = new System.Drawing.Point(128, 225);
            this.LabMasterSpeed.Name = "LabMasterSpeed";
            this.LabMasterSpeed.Size = new System.Drawing.Size(100, 50);
            this.LabMasterSpeed.TabIndex = 159;
            this.LabMasterSpeed.Text = "0.0";
            this.LabMasterSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabSlaveSpeed
            // 
            this.LabSlaveSpeed.BackColor = System.Drawing.Color.Black;
            this.LabSlaveSpeed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabSlaveSpeed.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabSlaveSpeed.ForeColor = System.Drawing.Color.White;
            this.LabSlaveSpeed.Location = new System.Drawing.Point(411, 225);
            this.LabSlaveSpeed.Name = "LabSlaveSpeed";
            this.LabSlaveSpeed.Size = new System.Drawing.Size(100, 50);
            this.LabSlaveSpeed.TabIndex = 160;
            this.LabSlaveSpeed.Text = "0.0";
            this.LabSlaveSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnSlave
            // 
            this.BtnSlave.BackColor = System.Drawing.Color.Blue;
            this.BtnSlave.FlatAppearance.BorderSize = 0;
            this.BtnSlave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSlave.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnSlave.ForeColor = System.Drawing.Color.White;
            this.BtnSlave.Location = new System.Drawing.Point(411, 282);
            this.BtnSlave.Name = "BtnSlave";
            this.BtnSlave.Size = new System.Drawing.Size(100, 55);
            this.BtnSlave.TabIndex = 161;
            this.BtnSlave.Text = "从轴";
            this.BtnSlave.UseVisualStyleBackColor = false;
            this.BtnSlave.Click += new System.EventHandler(this.BtnSlave_Click);
            // 
            // BtnJointCtl
            // 
            this.BtnJointCtl.BackColor = System.Drawing.Color.Blue;
            this.BtnJointCtl.FlatAppearance.BorderSize = 0;
            this.BtnJointCtl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnJointCtl.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnJointCtl.ForeColor = System.Drawing.Color.White;
            this.BtnJointCtl.Location = new System.Drawing.Point(12, 354);
            this.BtnJointCtl.Name = "BtnJointCtl";
            this.BtnJointCtl.Size = new System.Drawing.Size(100, 55);
            this.BtnJointCtl.TabIndex = 162;
            this.BtnJointCtl.Text = "联控";
            this.BtnJointCtl.UseVisualStyleBackColor = false;
            this.BtnJointCtl.Click += new System.EventHandler(this.BtnJointCtl_Click);
            // 
            // FrmShieldPos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(586, 494);
            this.Controls.Add(this.BtnBoxCtl);
            this.Controls.Add(this.BtnJointCtl);
            this.Controls.Add(this.BtnForce);
            this.Controls.Add(this.BtnSlave);
            this.Controls.Add(this.BtnAuto);
            this.Controls.Add(this.BtnManu);
            this.Controls.Add(this.LabSlaveSpeed);
            this.Controls.Add(this.LabMasterSpeed);
            this.Controls.Add(this.BtnSingeCtl);
            this.Controls.Add(this.BtnMaster);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.LabSlaveTorque);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.LabSlaveLocSP);
            this.Controls.Add(this.LabSlaveLocPV);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LabMasterTorque);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.BtnShieldDown);
            this.Controls.Add(this.BtnShieldUp);
            this.Controls.Add(this.BtnLoc);
            this.Controls.Add(this.LabMasterLocSP);
            this.Controls.Add(this.LabMasterLocPV);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.LabName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmShieldPos";
            this.Text = "FrmShieldPos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmShieldPos_FormClosed);
            this.Load += new System.EventHandler(this.FrmShieldPos_Load);
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Button BtnBoxCtl;
        internal System.Windows.Forms.Button BtnForce;
        internal System.Windows.Forms.Button BtnShieldDown;
        internal System.Windows.Forms.Button BtnShieldUp;
        internal System.Windows.Forms.Button BtnLoc;
        internal System.Windows.Forms.Button BtnAuto;
        internal System.Windows.Forms.Button BtnManu;
        internal System.Windows.Forms.Label LabMasterLocSP;
        internal System.Windows.Forms.Label LabMasterLocPV;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label LabName;
        private System.Windows.Forms.Timer Timer1;
        internal System.Windows.Forms.Label LabMasterTorque;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Label LabSlaveTorque;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.Label LabSlaveLocSP;
        internal System.Windows.Forms.Label LabSlaveLocPV;
        internal System.Windows.Forms.Label label16;
        internal System.Windows.Forms.Label label17;
        internal System.Windows.Forms.Label label18;
        internal System.Windows.Forms.Label label19;
        internal System.Windows.Forms.Button BtnMaster;
        internal System.Windows.Forms.Button BtnSingeCtl;
        internal System.Windows.Forms.Label LabMasterSpeed;
        internal System.Windows.Forms.Label LabSlaveSpeed;
        internal System.Windows.Forms.Button BtnSlave;
        internal System.Windows.Forms.Button BtnJointCtl;
    }
}