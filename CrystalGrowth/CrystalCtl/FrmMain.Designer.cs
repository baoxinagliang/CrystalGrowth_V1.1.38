namespace CrystalGrowth.CrystalCtl
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.Timer2 = new System.Windows.Forms.Timer(this.components);
            this.Timer3 = new System.Windows.Forms.Timer(this.components);
            this.Timer4 = new System.Windows.Forms.Timer(this.components);
            this.Timer5 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnDiaRateCtl = new System.Windows.Forms.Button();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.LabLicense = new System.Windows.Forms.Label();
            this.LabCameraStatus = new System.Windows.Forms.Label();
            this.LabAlarm = new System.Windows.Forms.Label();
            this.LabAutoStat = new System.Windows.Forms.Label();
            this.BtnHtrCtl = new System.Windows.Forms.Button();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.LabStatus = new System.Windows.Forms.Label();
            this.BtnPressCtl = new System.Windows.Forms.Button();
            this.BtnAux = new System.Windows.Forms.Button();
            this.BtnMeltGap = new System.Windows.Forms.Button();
            this.BtnFurnaceCtl = new System.Windows.Forms.Button();
            this.BtnMeltPos = new System.Windows.Forms.Button();
            this.BtnGasVaccum = new System.Windows.Forms.Button();
            this.BtnGrowCtl = new System.Windows.Forms.Button();
            this.BtnTrend = new System.Windows.Forms.Button();
            this.BtnMeltTemp = new System.Windows.Forms.Button();
            this.BtnSOP = new System.Windows.Forms.Button();
            this.BtnPowerRate = new System.Windows.Forms.Button();
            this.BtnRecord = new System.Windows.Forms.Button();
            this.BtnHtrPower = new System.Windows.Forms.Button();
            this.BtnDiaCtl = new System.Windows.Forms.Button();
            this.BtnVarShow = new System.Windows.Forms.Button();
            this.BtnAutoSel = new System.Windows.Forms.Button();
            this.BtnSafeProtect = new System.Windows.Forms.Button();
            this.BtnManuConfirm = new System.Windows.Forms.Button();
            this.BtnShieldPos = new System.Windows.Forms.Button();
            this.BtnSeedLift = new System.Windows.Forms.Button();
            this.BtnCrucPos = new System.Windows.Forms.Button();
            this.BtnMagnetic = new System.Windows.Forms.Button();
            this.BtnCrucLift = new System.Windows.Forms.Button();
            this.BtnCrucRot = new System.Windows.Forms.Button();
            this.BtnSeedRot = new System.Windows.Forms.Button();
            this.LabTime = new System.Windows.Forms.Label();
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Timer1
            // 
            this.Timer1.Interval = 250;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Timer2
            // 
            this.Timer2.Interval = 1000;
            this.Timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // Timer3
            // 
            this.Timer3.Interval = 10000;
            this.Timer3.Tick += new System.EventHandler(this.Timer3_Tick);
            // 
            // Timer4
            // 
            this.Timer4.Interval = 1000;
            this.Timer4.Tick += new System.EventHandler(this.Timer4_Tick);
            // 
            // Timer5
            // 
            this.Timer5.Interval = 5000;
            this.Timer5.Tick += new System.EventHandler(this.Timer5_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.panel1.Controls.Add(this.BtnDiaRateCtl);
            this.panel1.Controls.Add(this.Panel3);
            this.panel1.Controls.Add(this.BtnHtrCtl);
            this.panel1.Controls.Add(this.Panel2);
            this.panel1.Controls.Add(this.BtnPressCtl);
            this.panel1.Controls.Add(this.BtnAux);
            this.panel1.Controls.Add(this.BtnMeltGap);
            this.panel1.Controls.Add(this.BtnFurnaceCtl);
            this.panel1.Controls.Add(this.BtnMeltPos);
            this.panel1.Controls.Add(this.BtnGasVaccum);
            this.panel1.Controls.Add(this.BtnGrowCtl);
            this.panel1.Controls.Add(this.BtnTrend);
            this.panel1.Controls.Add(this.BtnMeltTemp);
            this.panel1.Controls.Add(this.BtnSOP);
            this.panel1.Controls.Add(this.BtnPowerRate);
            this.panel1.Controls.Add(this.BtnRecord);
            this.panel1.Controls.Add(this.BtnHtrPower);
            this.panel1.Controls.Add(this.BtnDiaCtl);
            this.panel1.Controls.Add(this.BtnVarShow);
            this.panel1.Controls.Add(this.BtnAutoSel);
            this.panel1.Controls.Add(this.BtnSafeProtect);
            this.panel1.Controls.Add(this.BtnManuConfirm);
            this.panel1.Controls.Add(this.BtnShieldPos);
            this.panel1.Controls.Add(this.BtnSeedLift);
            this.panel1.Controls.Add(this.BtnCrucPos);
            this.panel1.Controls.Add(this.BtnMagnetic);
            this.panel1.Controls.Add(this.BtnCrucLift);
            this.panel1.Controls.Add(this.BtnCrucRot);
            this.panel1.Controls.Add(this.BtnSeedRot);
            this.panel1.Controls.Add(this.LabTime);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 768);
            this.panel1.TabIndex = 30;
            // 
            // BtnDiaRateCtl
            // 
            this.BtnDiaRateCtl.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnDiaRateCtl.FlatAppearance.BorderSize = 0;
            this.BtnDiaRateCtl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDiaRateCtl.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnDiaRateCtl.ForeColor = System.Drawing.Color.White;
            this.BtnDiaRateCtl.Location = new System.Drawing.Point(157, 705);
            this.BtnDiaRateCtl.Name = "BtnDiaRateCtl";
            this.BtnDiaRateCtl.Size = new System.Drawing.Size(130, 60);
            this.BtnDiaRateCtl.TabIndex = 36;
            this.BtnDiaRateCtl.Text = "直径变化率控制";
            this.BtnDiaRateCtl.UseVisualStyleBackColor = false;
            this.BtnDiaRateCtl.Click += new System.EventHandler(this.BtnDiaRateCtl_Click);
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.Red;
            this.Panel3.Controls.Add(this.LabLicense);
            this.Panel3.Controls.Add(this.LabCameraStatus);
            this.Panel3.Controls.Add(this.LabAlarm);
            this.Panel3.Controls.Add(this.LabAutoStat);
            this.Panel3.Location = new System.Drawing.Point(425, 0);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(658, 50);
            this.Panel3.TabIndex = 35;
            this.Panel3.Click += new System.EventHandler(this.Panel3_Click);
            // 
            // LabLicense
            // 
            this.LabLicense.BackColor = System.Drawing.Color.Transparent;
            this.LabLicense.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabLicense.Location = new System.Drawing.Point(406, 28);
            this.LabLicense.Name = "LabLicense";
            this.LabLicense.Size = new System.Drawing.Size(93, 20);
            this.LabLicense.TabIndex = 36;
            this.LabLicense.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabCameraStatus
            // 
            this.LabCameraStatus.BackColor = System.Drawing.Color.Transparent;
            this.LabCameraStatus.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold);
            this.LabCameraStatus.Location = new System.Drawing.Point(505, 28);
            this.LabCameraStatus.Name = "LabCameraStatus";
            this.LabCameraStatus.Size = new System.Drawing.Size(150, 20);
            this.LabCameraStatus.TabIndex = 34;
            this.LabCameraStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabAlarm
            // 
            this.LabAlarm.BackColor = System.Drawing.Color.Transparent;
            this.LabAlarm.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.LabAlarm.Location = new System.Drawing.Point(0, 5);
            this.LabAlarm.Name = "LabAlarm";
            this.LabAlarm.Size = new System.Drawing.Size(400, 20);
            this.LabAlarm.TabIndex = 33;
            this.LabAlarm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabAutoStat
            // 
            this.LabAutoStat.BackColor = System.Drawing.Color.Transparent;
            this.LabAutoStat.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabAutoStat.Location = new System.Drawing.Point(0, 28);
            this.LabAutoStat.Name = "LabAutoStat";
            this.LabAutoStat.Size = new System.Drawing.Size(400, 20);
            this.LabAutoStat.TabIndex = 32;
            this.LabAutoStat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnHtrCtl
            // 
            this.BtnHtrCtl.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnHtrCtl.FlatAppearance.BorderSize = 0;
            this.BtnHtrCtl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHtrCtl.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnHtrCtl.ForeColor = System.Drawing.Color.White;
            this.BtnHtrCtl.Location = new System.Drawing.Point(309, 705);
            this.BtnHtrCtl.Name = "BtnHtrCtl";
            this.BtnHtrCtl.Size = new System.Drawing.Size(130, 60);
            this.BtnHtrCtl.TabIndex = 33;
            this.BtnHtrCtl.Text = "热场温度";
            this.BtnHtrCtl.UseVisualStyleBackColor = false;
            this.BtnHtrCtl.Click += new System.EventHandler(this.BtnHtrCtl_Click);
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.Yellow;
            this.Panel2.Controls.Add(this.LabStatus);
            this.Panel2.Location = new System.Drawing.Point(0, 0);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(427, 50);
            this.Panel2.TabIndex = 32;
            // 
            // LabStatus
            // 
            this.LabStatus.BackColor = System.Drawing.Color.Transparent;
            this.LabStatus.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabStatus.Location = new System.Drawing.Point(3, 11);
            this.LabStatus.Name = "LabStatus";
            this.LabStatus.Size = new System.Drawing.Size(201, 28);
            this.LabStatus.TabIndex = 25;
            this.LabStatus.Text = "手动";
            this.LabStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnPressCtl
            // 
            this.BtnPressCtl.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnPressCtl.FlatAppearance.BorderSize = 0;
            this.BtnPressCtl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPressCtl.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnPressCtl.ForeColor = System.Drawing.Color.White;
            this.BtnPressCtl.Location = new System.Drawing.Point(1221, 705);
            this.BtnPressCtl.Name = "BtnPressCtl";
            this.BtnPressCtl.Size = new System.Drawing.Size(130, 60);
            this.BtnPressCtl.TabIndex = 24;
            this.BtnPressCtl.Text = "压力控制";
            this.BtnPressCtl.UseVisualStyleBackColor = false;
            this.BtnPressCtl.Click += new System.EventHandler(this.BtnPressCtl_Click);
            // 
            // BtnAux
            // 
            this.BtnAux.BackColor = System.Drawing.Color.Blue;
            this.BtnAux.FlatAppearance.BorderSize = 0;
            this.BtnAux.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAux.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnAux.ForeColor = System.Drawing.Color.White;
            this.BtnAux.Location = new System.Drawing.Point(855, 60);
            this.BtnAux.Name = "BtnAux";
            this.BtnAux.Size = new System.Drawing.Size(156, 60);
            this.BtnAux.TabIndex = 6;
            this.BtnAux.Text = "辅助功能";
            this.BtnAux.UseVisualStyleBackColor = false;
            this.BtnAux.Click += new System.EventHandler(this.BtnAux_Click);
            // 
            // BtnMeltGap
            // 
            this.BtnMeltGap.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnMeltGap.FlatAppearance.BorderSize = 0;
            this.BtnMeltGap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMeltGap.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnMeltGap.ForeColor = System.Drawing.Color.White;
            this.BtnMeltGap.Location = new System.Drawing.Point(1069, 705);
            this.BtnMeltGap.Name = "BtnMeltGap";
            this.BtnMeltGap.Size = new System.Drawing.Size(130, 60);
            this.BtnMeltGap.TabIndex = 23;
            this.BtnMeltGap.Text = "液面位置\r\n液口距";
            this.BtnMeltGap.UseVisualStyleBackColor = false;
            this.BtnMeltGap.Click += new System.EventHandler(this.BtnMeltGap_Click);
            // 
            // BtnFurnaceCtl
            // 
            this.BtnFurnaceCtl.BackColor = System.Drawing.Color.Blue;
            this.BtnFurnaceCtl.FlatAppearance.BorderSize = 0;
            this.BtnFurnaceCtl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFurnaceCtl.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnFurnaceCtl.ForeColor = System.Drawing.Color.White;
            this.BtnFurnaceCtl.Location = new System.Drawing.Point(5, 60);
            this.BtnFurnaceCtl.Name = "BtnFurnaceCtl";
            this.BtnFurnaceCtl.Size = new System.Drawing.Size(156, 60);
            this.BtnFurnaceCtl.TabIndex = 1;
            this.BtnFurnaceCtl.Text = "单晶炉控制";
            this.BtnFurnaceCtl.UseVisualStyleBackColor = false;
            this.BtnFurnaceCtl.Click += new System.EventHandler(this.BtnFurnaceCtl_Click);
            // 
            // BtnMeltPos
            // 
            this.BtnMeltPos.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnMeltPos.FlatAppearance.BorderSize = 0;
            this.BtnMeltPos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMeltPos.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnMeltPos.ForeColor = System.Drawing.Color.White;
            this.BtnMeltPos.Location = new System.Drawing.Point(917, 705);
            this.BtnMeltPos.Name = "BtnMeltPos";
            this.BtnMeltPos.Size = new System.Drawing.Size(130, 60);
            this.BtnMeltPos.TabIndex = 22;
            this.BtnMeltPos.Text = "液面位置\r\n埚跟比";
            this.BtnMeltPos.UseVisualStyleBackColor = false;
            this.BtnMeltPos.Click += new System.EventHandler(this.BtnMeltPos_Click);
            // 
            // BtnGasVaccum
            // 
            this.BtnGasVaccum.BackColor = System.Drawing.Color.Blue;
            this.BtnGasVaccum.FlatAppearance.BorderSize = 0;
            this.BtnGasVaccum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGasVaccum.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnGasVaccum.ForeColor = System.Drawing.Color.White;
            this.BtnGasVaccum.Location = new System.Drawing.Point(175, 60);
            this.BtnGasVaccum.Name = "BtnGasVaccum";
            this.BtnGasVaccum.Size = new System.Drawing.Size(156, 60);
            this.BtnGasVaccum.TabIndex = 2;
            this.BtnGasVaccum.Text = "气体/真空";
            this.BtnGasVaccum.UseVisualStyleBackColor = false;
            this.BtnGasVaccum.Click += new System.EventHandler(this.BtnGasVaccum_Click);
            // 
            // BtnGrowCtl
            // 
            this.BtnGrowCtl.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnGrowCtl.FlatAppearance.BorderSize = 0;
            this.BtnGrowCtl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGrowCtl.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnGrowCtl.ForeColor = System.Drawing.Color.White;
            this.BtnGrowCtl.Location = new System.Drawing.Point(765, 705);
            this.BtnGrowCtl.Name = "BtnGrowCtl";
            this.BtnGrowCtl.Size = new System.Drawing.Size(130, 60);
            this.BtnGrowCtl.TabIndex = 21;
            this.BtnGrowCtl.Text = "生长控制";
            this.BtnGrowCtl.UseVisualStyleBackColor = false;
            this.BtnGrowCtl.Click += new System.EventHandler(this.BtnGrowCtl_Click);
            // 
            // BtnTrend
            // 
            this.BtnTrend.BackColor = System.Drawing.Color.Blue;
            this.BtnTrend.FlatAppearance.BorderSize = 0;
            this.BtnTrend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTrend.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnTrend.ForeColor = System.Drawing.Color.White;
            this.BtnTrend.Location = new System.Drawing.Point(345, 60);
            this.BtnTrend.Name = "BtnTrend";
            this.BtnTrend.Size = new System.Drawing.Size(156, 60);
            this.BtnTrend.TabIndex = 3;
            this.BtnTrend.Text = "趋势图";
            this.BtnTrend.UseVisualStyleBackColor = false;
            this.BtnTrend.Click += new System.EventHandler(this.BtnTrend_Click);
            // 
            // BtnMeltTemp
            // 
            this.BtnMeltTemp.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnMeltTemp.FlatAppearance.BorderSize = 0;
            this.BtnMeltTemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMeltTemp.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnMeltTemp.ForeColor = System.Drawing.Color.White;
            this.BtnMeltTemp.Location = new System.Drawing.Point(613, 705);
            this.BtnMeltTemp.Name = "BtnMeltTemp";
            this.BtnMeltTemp.Size = new System.Drawing.Size(130, 60);
            this.BtnMeltTemp.TabIndex = 20;
            this.BtnMeltTemp.Text = "液面温度";
            this.BtnMeltTemp.UseVisualStyleBackColor = false;
            this.BtnMeltTemp.Click += new System.EventHandler(this.BtnMeltTemp_Click);
            // 
            // BtnSOP
            // 
            this.BtnSOP.BackColor = System.Drawing.Color.Blue;
            this.BtnSOP.FlatAppearance.BorderSize = 0;
            this.BtnSOP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSOP.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnSOP.ForeColor = System.Drawing.Color.White;
            this.BtnSOP.Location = new System.Drawing.Point(515, 60);
            this.BtnSOP.Name = "BtnSOP";
            this.BtnSOP.Size = new System.Drawing.Size(156, 60);
            this.BtnSOP.TabIndex = 4;
            this.BtnSOP.Text = "SOP";
            this.BtnSOP.UseVisualStyleBackColor = false;
            this.BtnSOP.Click += new System.EventHandler(this.BtnSOP_Click);
            // 
            // BtnPowerRate
            // 
            this.BtnPowerRate.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnPowerRate.FlatAppearance.BorderSize = 0;
            this.BtnPowerRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPowerRate.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnPowerRate.ForeColor = System.Drawing.Color.White;
            this.BtnPowerRate.Location = new System.Drawing.Point(461, 705);
            this.BtnPowerRate.Name = "BtnPowerRate";
            this.BtnPowerRate.Size = new System.Drawing.Size(130, 60);
            this.BtnPowerRate.TabIndex = 19;
            this.BtnPowerRate.Text = "热场温度\r\n变化速率";
            this.BtnPowerRate.UseVisualStyleBackColor = false;
            this.BtnPowerRate.Click += new System.EventHandler(this.BtnPowerRate_Click);
            // 
            // BtnRecord
            // 
            this.BtnRecord.BackColor = System.Drawing.Color.Blue;
            this.BtnRecord.FlatAppearance.BorderSize = 0;
            this.BtnRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRecord.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnRecord.ForeColor = System.Drawing.Color.White;
            this.BtnRecord.Location = new System.Drawing.Point(685, 60);
            this.BtnRecord.Name = "BtnRecord";
            this.BtnRecord.Size = new System.Drawing.Size(156, 60);
            this.BtnRecord.TabIndex = 5;
            this.BtnRecord.Text = "生长记录";
            this.BtnRecord.UseVisualStyleBackColor = false;
            this.BtnRecord.Click += new System.EventHandler(this.BtnRecord_Click);
            // 
            // BtnHtrPower
            // 
            this.BtnHtrPower.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnHtrPower.FlatAppearance.BorderSize = 0;
            this.BtnHtrPower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHtrPower.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnHtrPower.ForeColor = System.Drawing.Color.White;
            this.BtnHtrPower.Location = new System.Drawing.Point(613, 130);
            this.BtnHtrPower.Name = "BtnHtrPower";
            this.BtnHtrPower.Size = new System.Drawing.Size(130, 60);
            this.BtnHtrPower.TabIndex = 18;
            this.BtnHtrPower.Text = "加热器功率";
            this.BtnHtrPower.UseVisualStyleBackColor = false;
            this.BtnHtrPower.Click += new System.EventHandler(this.BtnHtrPower_Click);
            // 
            // BtnDiaCtl
            // 
            this.BtnDiaCtl.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnDiaCtl.FlatAppearance.BorderSize = 0;
            this.BtnDiaCtl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDiaCtl.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnDiaCtl.ForeColor = System.Drawing.Color.White;
            this.BtnDiaCtl.Location = new System.Drawing.Point(5, 705);
            this.BtnDiaCtl.Name = "BtnDiaCtl";
            this.BtnDiaCtl.Size = new System.Drawing.Size(130, 60);
            this.BtnDiaCtl.TabIndex = 17;
            this.BtnDiaCtl.Text = "直径控制";
            this.BtnDiaCtl.UseVisualStyleBackColor = false;
            this.BtnDiaCtl.Click += new System.EventHandler(this.BtnDiaCtl_Click);
            // 
            // BtnVarShow
            // 
            this.BtnVarShow.BackColor = System.Drawing.Color.Blue;
            this.BtnVarShow.FlatAppearance.BorderSize = 0;
            this.BtnVarShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVarShow.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnVarShow.ForeColor = System.Drawing.Color.White;
            this.BtnVarShow.Location = new System.Drawing.Point(1025, 60);
            this.BtnVarShow.Name = "BtnVarShow";
            this.BtnVarShow.Size = new System.Drawing.Size(156, 60);
            this.BtnVarShow.TabIndex = 7;
            this.BtnVarShow.Text = "变量显示";
            this.BtnVarShow.UseVisualStyleBackColor = false;
            this.BtnVarShow.Click += new System.EventHandler(this.BtnVarShow_Click);
            // 
            // BtnAutoSel
            // 
            this.BtnAutoSel.BackColor = System.Drawing.Color.Blue;
            this.BtnAutoSel.FlatAppearance.BorderSize = 0;
            this.BtnAutoSel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAutoSel.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnAutoSel.ForeColor = System.Drawing.Color.White;
            this.BtnAutoSel.Location = new System.Drawing.Point(1195, 60);
            this.BtnAutoSel.Name = "BtnAutoSel";
            this.BtnAutoSel.Size = new System.Drawing.Size(156, 60);
            this.BtnAutoSel.TabIndex = 8;
            this.BtnAutoSel.Text = "自动选项";
            this.BtnAutoSel.UseVisualStyleBackColor = false;
            this.BtnAutoSel.Click += new System.EventHandler(this.BtnAutoSel_Click);
            // 
            // BtnSafeProtect
            // 
            this.BtnSafeProtect.BackColor = System.Drawing.Color.Goldenrod;
            this.BtnSafeProtect.FlatAppearance.BorderSize = 0;
            this.BtnSafeProtect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSafeProtect.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnSafeProtect.ForeColor = System.Drawing.Color.White;
            this.BtnSafeProtect.Location = new System.Drawing.Point(1231, 0);
            this.BtnSafeProtect.Name = "BtnSafeProtect";
            this.BtnSafeProtect.Size = new System.Drawing.Size(135, 50);
            this.BtnSafeProtect.TabIndex = 16;
            this.BtnSafeProtect.Text = "紧急保护按钮";
            this.BtnSafeProtect.UseVisualStyleBackColor = false;
            this.BtnSafeProtect.Click += new System.EventHandler(this.BtnSafeProtect_Click);
            // 
            // BtnManuConfirm
            // 
            this.BtnManuConfirm.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnManuConfirm.FlatAppearance.BorderSize = 0;
            this.BtnManuConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnManuConfirm.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnManuConfirm.ForeColor = System.Drawing.Color.White;
            this.BtnManuConfirm.Location = new System.Drawing.Point(1221, 130);
            this.BtnManuConfirm.Name = "BtnManuConfirm";
            this.BtnManuConfirm.Size = new System.Drawing.Size(130, 60);
            this.BtnManuConfirm.TabIndex = 16;
            this.BtnManuConfirm.Text = "人工确认";
            this.BtnManuConfirm.UseVisualStyleBackColor = false;
            this.BtnManuConfirm.Click += new System.EventHandler(this.BtnManuConfirm_Click);
            // 
            // BtnShieldPos
            // 
            this.BtnShieldPos.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnShieldPos.FlatAppearance.BorderSize = 0;
            this.BtnShieldPos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShieldPos.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnShieldPos.ForeColor = System.Drawing.Color.White;
            this.BtnShieldPos.Location = new System.Drawing.Point(1069, 130);
            this.BtnShieldPos.Name = "BtnShieldPos";
            this.BtnShieldPos.Size = new System.Drawing.Size(130, 60);
            this.BtnShieldPos.TabIndex = 16;
            this.BtnShieldPos.Text = "热屏位置";
            this.BtnShieldPos.UseVisualStyleBackColor = false;
            this.BtnShieldPos.Click += new System.EventHandler(this.BtnShieldPos_Click);
            // 
            // BtnSeedLift
            // 
            this.BtnSeedLift.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnSeedLift.FlatAppearance.BorderSize = 0;
            this.BtnSeedLift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSeedLift.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnSeedLift.ForeColor = System.Drawing.Color.White;
            this.BtnSeedLift.Location = new System.Drawing.Point(5, 130);
            this.BtnSeedLift.Name = "BtnSeedLift";
            this.BtnSeedLift.Size = new System.Drawing.Size(130, 60);
            this.BtnSeedLift.TabIndex = 9;
            this.BtnSeedLift.Text = "晶升";
            this.BtnSeedLift.UseVisualStyleBackColor = false;
            this.BtnSeedLift.Click += new System.EventHandler(this.BtnSeedLift_Click);
            // 
            // BtnCrucPos
            // 
            this.BtnCrucPos.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnCrucPos.FlatAppearance.BorderSize = 0;
            this.BtnCrucPos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCrucPos.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCrucPos.ForeColor = System.Drawing.Color.White;
            this.BtnCrucPos.Location = new System.Drawing.Point(917, 130);
            this.BtnCrucPos.Name = "BtnCrucPos";
            this.BtnCrucPos.Size = new System.Drawing.Size(130, 60);
            this.BtnCrucPos.TabIndex = 15;
            this.BtnCrucPos.Text = "坩埚位置";
            this.BtnCrucPos.UseVisualStyleBackColor = false;
            this.BtnCrucPos.Click += new System.EventHandler(this.BtnCrucPos_Click);
            // 
            // BtnMagnetic
            // 
            this.BtnMagnetic.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnMagnetic.FlatAppearance.BorderSize = 0;
            this.BtnMagnetic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMagnetic.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnMagnetic.ForeColor = System.Drawing.Color.White;
            this.BtnMagnetic.Location = new System.Drawing.Point(765, 130);
            this.BtnMagnetic.Name = "BtnMagnetic";
            this.BtnMagnetic.Size = new System.Drawing.Size(130, 60);
            this.BtnMagnetic.TabIndex = 14;
            this.BtnMagnetic.Text = "图像";
            this.BtnMagnetic.UseVisualStyleBackColor = false;
            this.BtnMagnetic.Click += new System.EventHandler(this.BtnMagnetic_Click);
            // 
            // BtnCrucLift
            // 
            this.BtnCrucLift.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnCrucLift.FlatAppearance.BorderSize = 0;
            this.BtnCrucLift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCrucLift.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCrucLift.ForeColor = System.Drawing.Color.White;
            this.BtnCrucLift.Location = new System.Drawing.Point(309, 130);
            this.BtnCrucLift.Name = "BtnCrucLift";
            this.BtnCrucLift.Size = new System.Drawing.Size(130, 60);
            this.BtnCrucLift.TabIndex = 11;
            this.BtnCrucLift.Text = "埚升";
            this.BtnCrucLift.UseVisualStyleBackColor = false;
            this.BtnCrucLift.Click += new System.EventHandler(this.BtnCrucLift_Click);
            // 
            // BtnCrucRot
            // 
            this.BtnCrucRot.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnCrucRot.FlatAppearance.BorderSize = 0;
            this.BtnCrucRot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCrucRot.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCrucRot.ForeColor = System.Drawing.Color.White;
            this.BtnCrucRot.Location = new System.Drawing.Point(461, 130);
            this.BtnCrucRot.Name = "BtnCrucRot";
            this.BtnCrucRot.Size = new System.Drawing.Size(130, 60);
            this.BtnCrucRot.TabIndex = 13;
            this.BtnCrucRot.Text = "埚转";
            this.BtnCrucRot.UseVisualStyleBackColor = false;
            this.BtnCrucRot.Click += new System.EventHandler(this.BtnCrucRot_Click);
            // 
            // BtnSeedRot
            // 
            this.BtnSeedRot.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnSeedRot.FlatAppearance.BorderSize = 0;
            this.BtnSeedRot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSeedRot.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnSeedRot.ForeColor = System.Drawing.Color.White;
            this.BtnSeedRot.Location = new System.Drawing.Point(157, 130);
            this.BtnSeedRot.Name = "BtnSeedRot";
            this.BtnSeedRot.Size = new System.Drawing.Size(130, 60);
            this.BtnSeedRot.TabIndex = 12;
            this.BtnSeedRot.Text = "晶转";
            this.BtnSeedRot.UseVisualStyleBackColor = false;
            this.BtnSeedRot.Click += new System.EventHandler(this.BtnSeedRot_Click);
            // 
            // LabTime
            // 
            this.LabTime.BackColor = System.Drawing.Color.Silver;
            this.LabTime.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabTime.Location = new System.Drawing.Point(1082, 0);
            this.LabTime.Name = "LabTime";
            this.LabTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabTime.Size = new System.Drawing.Size(151, 50);
            this.LabTime.TabIndex = 26;
            this.LabTime.Text = "00:00:00";
            this.LabTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer6
            // 
            this.timer6.Enabled = true;
            this.timer6.Interval = 10000;
            this.timer6.Tick += new System.EventHandler(this.timer6_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CrystalGrowth";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            this.Panel3.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Timer Timer2;
        private System.Windows.Forms.Timer Timer3;
        private System.Windows.Forms.Timer Timer5;
        internal System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Button BtnHtrCtl;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.Label LabLicense;
        internal System.Windows.Forms.Label LabCameraStatus;
        internal System.Windows.Forms.Label LabAlarm;
        internal System.Windows.Forms.Label LabAutoStat;
        internal System.Windows.Forms.Button BtnPressCtl;
        internal System.Windows.Forms.Button BtnAux;
        internal System.Windows.Forms.Button BtnMeltGap;
        internal System.Windows.Forms.Button BtnFurnaceCtl;
        internal System.Windows.Forms.Button BtnMeltPos;
        internal System.Windows.Forms.Button BtnGasVaccum;
        internal System.Windows.Forms.Button BtnGrowCtl;
        internal System.Windows.Forms.Button BtnTrend;
        internal System.Windows.Forms.Button BtnMeltTemp;
        internal System.Windows.Forms.Button BtnSOP;
        internal System.Windows.Forms.Button BtnPowerRate;
        internal System.Windows.Forms.Button BtnRecord;
        internal System.Windows.Forms.Button BtnHtrPower;
        internal System.Windows.Forms.Button BtnDiaCtl;
        internal System.Windows.Forms.Button BtnVarShow;
        internal System.Windows.Forms.Button BtnAutoSel;
        internal System.Windows.Forms.Button BtnSafeProtect;
        internal System.Windows.Forms.Button BtnManuConfirm;
        internal System.Windows.Forms.Button BtnShieldPos;
        internal System.Windows.Forms.Button BtnSeedLift;
        internal System.Windows.Forms.Button BtnCrucPos;
        internal System.Windows.Forms.Button BtnMagnetic;
        internal System.Windows.Forms.Button BtnCrucLift;
        internal System.Windows.Forms.Button BtnCrucRot;
        internal System.Windows.Forms.Button BtnSeedRot;
        internal System.Windows.Forms.Label LabTime;
        internal System.Windows.Forms.Label LabStatus;
        public System.Windows.Forms.Timer Timer4;
        internal System.Windows.Forms.Button BtnDiaRateCtl;
        private System.Windows.Forms.Timer timer6;
    }
}