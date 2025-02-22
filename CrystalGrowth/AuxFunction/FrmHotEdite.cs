﻿using CrystalGrowth.CrystalCtl;
using CrystalGrowth.Unities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CrystalGrowth.AuxFunction
{
    internal partial class FrmHotEdite : Form
    {
        HotEquipmentParts[] hep;
        int serialnum = 0;
        public FrmHotEdite(HotEquipmentParts[] hept, int index)
        {
            InitializeComponent();
            serialnum = index;
            hep = hept;
            LblName.Text = hep[index].Name;
            ComBoxMaterial.Text = hep[index].Material;
            TxtCode.Text = hep[index].Code;
            DTPStartTime.Value = Convert.ToDateTime(hep[index].StartTime);
            LabRatedDays.Text = hep[index].RatedDays;
            LabUsageTime.Text = hep[index].UsageTime;
            ComBoxChangeReason.Text = hep[index].ChangeReason;
            DTPGhangeTime.Value = Convert.ToDateTime(hep[index].GhangeTime);
        }
        private void BtnCannel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (CBoxChoice.Checked == false)
            {
                DbRecord(hep[serialnum]);
            }
            hep[serialnum].Name = LblName.Text.Trim();
            hep[serialnum].Material = ComBoxMaterial.Text.Trim();
            hep[serialnum].Code = TxtCode.Text.Trim();
            hep[serialnum].StartTime = CBoxChoice.Checked ? DTPStartTime.Value.ToString("yyyy-MM-dd HH:mm:ss") : DTPGhangeTime.Value.ToString("yyyy-MM-dd HH:mm:ss");
            hep[serialnum].RatedDays = LabRatedDays.Text.Trim();
            hep[serialnum].UsageTime = LabUsageTime.Text.Trim();
            hep[serialnum].ChangeReason = ComBoxChangeReason.Text.Trim();
            hep[serialnum].GhangeTime = DTPGhangeTime.Value.ToString("yyyy-MM-dd HH:mm:ss");
            if (CBoxChoice.Checked == false) { hep[serialnum].Flag = "false"; }
            HotHandle.WriteIn(hep);         
            HotHandle.IsStart = "false";
            DialogResult = DialogResult.OK;
        }
        private static void DbRecord(HotEquipmentParts hept)
        {
            SqliteHelper.ExecDataBySql(string.Format("INSERT INTO HOT_DATA (DATE_TIME,NAME,MATEIAL,CODE,STARTTIME,RATEDDAYS,USAGETIME,CHANGEREASON,GHANGETIME)VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), hept.Name, hept.Material, hept.Code, hept.StartTime, hept.RatedDays, hept.UsageTime, hept.ChangeReason, hept.GhangeTime));
            SqliteHelper.ExecDataBySql("DELETE FROM HOT_DATA WHERE DATE('NOW', '-365 DAY') >= DATE(DATE_TIME)");
        }
        private void TxtCode_TextChanged(object sender, EventArgs e)
        {
            if (CBoxChoice.Checked == false)
            {
                DTPGhangeTime.Value = DateTime.Now;
                LabUsageTime.Text = "0";
            }
        }
        private void LabRatedDays_Click(object sender, EventArgs e)
        {
            if (CBoxChoice.Checked)
            {
                KeyForm kf = new KeyForm
                {
                    Location = new Point(400, 130)
                };
                kf.ImportData(ref LabRatedDays, 0, 36500);
                kf.ShowDialog();
            }
        }
        private void CBoxChoice_Click(object sender, EventArgs e)
        {
            CBoxChoice.Text = CBoxChoice.Checked ? "修改参数" : "更换配件";
        }

        private void FrmHotEdite_FormClosed(object sender, FormClosedEventArgs e)
        {
            hep = null;
        }
    }
}
