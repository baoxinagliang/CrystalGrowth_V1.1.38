using CrystalGrowth.SOP;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CrystalGrowth.Unities
{
    internal static class Sop
    {
        public static string SOPFileName = "", Version = "";
        static bool OneTime = false;
        public static SopData<float> SData = new SopData<float>();
        public static SopData<float> SDataB;
        /// <summary>
        /// 定时写入PLC sop 数据
        /// </summary>
        public static void WriteData()
        {
            //LineFile FlieValue = new LineFile();
            if (PLC.IsConn)
            {
                //PLC Reset
                if (PLC.ReadStatus[70] == 1)
                {
                    PLC.SendBit(30, 94, 1);
                    if (OneTime)
                    {
                        OneTime = false;
                    }
                }
                if (OneTime == false)
                {
                    OneTime = true;
                    //Write Calibration Value
                    Calibrate.FileToPlc();
                    //Write SOP
                    //FileToParas(ref FlieValue);
                    //string FileStr = string.Concat(Application.StartupPath, "\\SOP\\", FlieValue.Name);
                    //if (File.Exists(FileStr))
                    //{
                    //    FileToPlc(FileStr);
                    //    Record.WriteIn(FlieValue.Name, "重启下载完成", "Yellow");
                    //}
                    //else
                    //{
                    //    return;
                    //}
                }
            }
            //else
            //{
            //    if (OneTime)
            //    {
            //        OneTime = false;
            //    }
            //}
        }
        public static void FileToParas(ref LineFile FileValue)
        {
            using (StreamReader SReader = new StreamReader(FileHelper.ConfigPath, Encoding.UTF8))
            {
                FileValue.Name = SReader.ReadLine();
                Version = FileValue.Name;
                FileValue.Stat = SReader.ReadLine();
            }
        }
        /// <summary>
        /// 写入时间
        /// </summary>
        public static void ParasToFile(ref LineFile FileValue)
        {
            using (FileStream fStream = new FileStream(FileHelper.ConfigPath, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter SWriter = new StreamWriter(fStream, Encoding.UTF8))
                {
                    SWriter.WriteLine(FileValue.Name);
                    SWriter.WriteLine(FileValue.Stat);
                    SWriter.Flush();
                }
            }
        }
        public static void FileToPlc(string FileName)
        {
            string[] Lines = File.ReadAllLines(FileName, Encoding.Default);
            if (Lines.Length == 24)
            {
                string[] TempStr = FileName.Split(new char[] { '\\' });
                SOPFileName = TempStr[TempStr.Length - 1];
                PLC.SendFloat(33, 296, PLC.ReadValue[1]);
                SData = StrToFloat(ArrayToSData(Lines));
                SDataToPLC(SData);
                PLC.SendFloat(33, 296, 0);
            }
        }
        //读取Sop文件数据到页面
        public static void FileToForm(string FileName)
        {
            if (!File.Exists(FileName))
            {
                return;
            }
            string[] Lines = File.ReadAllLines(FileName, Encoding.Default);
            if (Lines.Length == 24)
            {
                SopData<string> SData1 = ArrayToSData(Lines);
                FormDisPlay(SData1);
            }
        }
        public static void FormDisPlay(SopData<string> sData)
        {
            int Cnt = 0;
            int Length;
            //Read init para DB40         
            if (sData.Initial != null)
            {
                double Temp;
                int ii;
                Length = sData.Initial.Length;
                for (int i = 1; i <= 15; i++)
                {
                    ii = i - 1;
                    if (Cnt + 1 > Length)
                    {
                        ProcSel.Single.frmStab1.DataGridView1.Rows[ii].Cells[0].Value = "";
                    }
                    else
                    {
                        switch (i)
                        {
                            case 7:
                            case 8:
                                if (sData.Initial[Cnt].Length == 0)
                                {
                                    ProcSel.Single.frmStab1.DataGridView1.Rows[ii].Cells[0].Value = "";
                                }
                                else
                                {
                                    Temp = Convert.ToDouble(sData.Initial[Cnt]);
                                    ProcSel.Single.frmStab1.DataGridView1.Rows[ii].Cells[0].Value = Temp > 1 || Temp < 0 ? "0" : sData.Initial[Cnt];
                                }
                                break;
                            case 9:
                                if (sData.Initial[Cnt].Length == 0)
                                {
                                    ProcSel.Single.frmStab1.DataGridView1.Rows[ii].Cells[0].Value = "";
                                }
                                else
                                {
                                    Temp = Convert.ToDouble(sData.Initial[Cnt]);
                                    ProcSel.Single.frmStab1.DataGridView1.Rows[ii].Cells[0].Value = Temp > 20 || Temp < 0 ? "2" : sData.Initial[Cnt];
                                }
                                break;
                            case 10:
                                if (sData.Initial[Cnt].Length == 0)
                                {
                                    ProcSel.Single.frmStab1.DataGridView1.Rows[ii].Cells[0].Value = "";
                                }
                                else
                                {
                                    Temp = Convert.ToDouble(sData.Initial[Cnt]);
                                    ProcSel.Single.frmStab1.DataGridView1.Rows[ii].Cells[0].Value = Temp > 0 || Temp < -20 ? "- 2" : sData.Initial[Cnt];
                                }
                                break;
                            case 13:
                                if (sData.Initial[Cnt].Length == 0)
                                {
                                    ProcSel.Single.frmStab1.DataGridView1.Rows[ii].Cells[0].Value = "";
                                }
                                else
                                {
                                    Temp = Convert.ToDouble(sData.Initial[Cnt]);
                                    ProcSel.Single.frmStab1.DataGridView1.Rows[ii].Cells[0].Value = Temp > 1 || Temp < 0 ? "0" : sData.Initial[Cnt];
                                }
                                break;
                            default:
                                ProcSel.Single.frmStab1.DataGridView1.Rows[ii].Cells[0].Value = sData.Initial[Cnt];
                                break;
                        }
                    }
                    Cnt++;
                }
                Cnt = ReadRow(ProcSel.Single.frmStab1.DataGridView2.Rows, 26, 0, Cnt, Length, ref sData.Initial);
                Cnt = ReadRow(ProcSel.Single.frmStab1.DataGridView3.Rows, 20, 0, Cnt, Length, ref sData.Initial);
                for (int i = 0; i < 2; i++)
                {
                    Cnt = ReadRow(ProcSel.Single.frmStab1.DataGridView4.Rows, 10, i, Cnt, Length, ref sData.Initial);
                }
                ReadRow(ProcSel.Single.frmStab1.DataGridView5.Rows, 55, 0, Cnt, Length, ref sData.Initial);
            }
            //Read PumpDown/LeakBack para DB41
            if (sData.PumpLeak != null)
            {
                ReadRow(ProcSel.Single.frmStab2.DataGridView1.Rows, 14, 0, 0, sData.PumpLeak.Length, ref sData.PumpLeak);
            }
            //Read Pressuration/Melting para DB42
            if (sData.PressMelt != null)
            {
                Length = sData.PressMelt.Length;
                Cnt = ReadRow(ProcSel.Single.frmStab3.DataGridView1.Rows, 9, 0, 0, Length, ref sData.PressMelt);
                Cnt = ReadRow(ProcSel.Single.frmStab3.DataGridView2.Rows, 6, 0, Cnt, Length, ref sData.PressMelt);
                for (int i = 0; i < 8; i++)
                {
                    Cnt = ReadRow(ProcSel.Single.frmStab3.DataGridView3.Rows, 10, i, Cnt, Length, ref sData.PressMelt);
                }
            }
            //Read Stabilize para DB44
            if (sData.Stabilize != null)
            {
                Length = sData.Stabilize.Length;
                Cnt = ReadRow(ProcSel.Single.frmStab4.DataGridView1.Rows, 20, 0, 0, Length, ref sData.Stabilize);
                Cnt = ReadRow(ProcSel.Single.frmStab4.DataGridView2.Rows, 11, 0, Cnt, Length, ref sData.Stabilize);
                ReadRow(ProcSel.Single.frmStab4.DataGridView3.Rows, 5, 0, Cnt, Length, ref sData.Stabilize);
            }
            //Read Dip para DB43
            if (sData.Dip != null)
            {
                Length = sData.Dip.Length;
                Cnt = ReadRow(ProcSel.Single.frmStab5.DataGridView1.Rows, 18, 0, 0, Length, ref sData.Dip);
                Cnt = ReadRow(ProcSel.Single.frmStab5.DataGridView2.Rows, 5, 0, Cnt, Length, ref sData.Dip);
                for (int i = 0; i < 2; i++)
                {
                    Cnt = ReadRow(ProcSel.Single.frmStab5.DataGridView3.Rows, 8, i, Cnt, Length, ref sData.Dip);
                }
            }
            //Read Neck para DB45
            if (sData.Neck != null)
            {
                Length = sData.Neck.Length;
                Cnt = ReadRow(ProcSel.Single.frmStab6.DataGridView1.Rows, 14, 0, 0, Length, ref sData.Neck);
                Cnt = ReadRow(ProcSel.Single.frmStab6.DataGridView2.Rows, 10, 0, Cnt, Length, ref sData.Neck);
                Cnt = ReadRow(ProcSel.Single.frmStab6.DataGridView3.Rows, 1, 0, Cnt, Length, ref sData.Neck);
                for (int i = 0; i < 9; i++)
                {
                    Cnt = ReadRow(ProcSel.Single.frmStab6.DataGridView4.Rows, 10, i, Cnt, Length, ref sData.Neck);
                }
            }
            //Read Crown para DB46
            if (sData.Crown != null)
            {
                Length = sData.Crown.Length;
                Cnt = ReadRow(ProcSel.Single.frmStab7.DataGridView1.Rows, 4, 0, 0, Length, ref sData.Crown);
                for (int i = 0; i < 8; i++)
                {
                    Cnt = ReadRow(ProcSel.Single.frmStab7.DataGridView2.Rows, 16, i, Cnt, Length, ref sData.Crown);
                }
                Cnt = ReadRow(ProcSel.Single.frmStab7.DataGridView3.Rows, 24, 0, Cnt, Length, ref sData.Crown);
                for (int i = 0; i < 10; i++)
                {
                    Cnt = ReadRow(ProcSel.Single.frmStab7.DataGridView4.Rows, 16, i, Cnt, Length, ref sData.Crown);
                }
                Cnt = ReadRow(ProcSel.Single.frmStab7.DataGridView5.Rows, 14, 0, Cnt, Length, ref sData.Crown);
                for (int i = 0; i < 2; i++)
                {
                    Cnt = ReadRow(ProcSel.Single.frmStab7.DataGridView6.Rows, 8, i, Cnt, Length, ref sData.Crown);
                }
                Cnt = ReadRow(ProcSel.Single.frmStab7.DataGridView7.Rows, 15, 0, Cnt, Length, ref sData.Crown);
                for (int i = 0; i < 10; i++)
                {
                    Cnt = ReadRow(ProcSel.Single.frmStab7.DataGridView8.Rows, 8, i, Cnt, Length, ref sData.Crown);
                }
            }
            //Read Shoulder para DB47
            if (sData.Shoulder != null)
            {
                Length = sData.Shoulder.Length;
                Cnt = ReadRow(ProcSel.Single.frmStab8.DataGridView1.Rows, 17, 0, 0, Length, ref sData.Shoulder);
                for (int i = 0; i < 2; i++)
                {
                    Cnt = ReadRow(ProcSel.Single.frmStab8.DataGridView3.Rows, 16, i, Cnt, Length, ref sData.Shoulder);
                }
                Cnt = ReadRow(ProcSel.Single.frmStab8.DataGridView4.Rows, 5, 0, Cnt, Length, ref sData.Shoulder);
                Cnt = ReadRow(ProcSel.Single.frmStab8.DataGridView5.Rows, 5, 0, Cnt, Length, ref sData.Shoulder);
                for (int i = 0; i < 6; i++)
                {
                    Cnt = ReadRow(ProcSel.Single.frmStab8.DataGridView6.Rows, 10, i, Cnt, Length, ref sData.Shoulder);
                }
                for (int i = 0; i < 2; i++)
                {
                    Cnt = ReadRow(ProcSel.Single.frmStab8.DataGridView7.Rows, 8, i, Cnt, Length, ref sData.Shoulder);
                }
                ReadRow(ProcSel.Single.frmStab8.DataGridView2.Rows, 11, 0, Cnt, Length, ref sData.Shoulder);
            }
            //Read Body para DB48
            if (sData.Body != null)
            {
                Length = sData.Body.Length;
                Cnt = ReadRow(ProcSel.Single.frmStab9.DataGridView1.Rows, 20, 0, 0, Length, ref sData.Body);
                for (int i = 0; i < 11; i++)
                {
                    Cnt = ReadRow(ProcSel.Single.frmStab9.DataGridView2.Rows, 25, i, Cnt, Length, ref sData.Body);
                }
                for (int i = 0; i < 11; i++)
                {
                    Cnt = ReadRow(ProcSel.Single.frmStab9.DataGridView3.Rows, 16, i, Cnt, Length, ref sData.Body);
                }
                Cnt = ReadRow(ProcSel.Single.frmStab9.DataGridView4.Rows, 3, 0, Cnt, Length, ref sData.Body);
                for (int i = 0; i < 2; i++)
                {
                    Cnt = ReadRow(ProcSel.Single.frmStab9.DataGridView5.Rows, 25, i, Cnt, Length, ref sData.Body);
                }
            }
            //Read Tail para DB49
            if (sData.Tail != null)
            {
                Length = sData.Tail.Length;
                Cnt = ReadRow(ProcSel.Single.frmStab10.DataGridView1.Rows, 15, 0, 0, Length, ref sData.Tail);
                for (int i = 0; i < 9; i++)
                {
                    Cnt = ReadRow(ProcSel.Single.frmStab10.DataGridView2.Rows, 20, i, Cnt, Length, ref sData.Tail);
                }
                Cnt = ReadRow(ProcSel.Single.frmStab10.DataGridView3.Rows, 5, 0, Cnt, Length, ref sData.Tail);
                for (int i = 0; i < 3; i++)
                {
                    Cnt = ReadRow(ProcSel.Single.frmStab10.DataGridView4.Rows, 10, i, Cnt, Length, ref sData.Tail);
                }
                Cnt = ReadRow(ProcSel.Single.frmStab10.DataGridView5.Rows, 10, 0, Cnt, Length, ref sData.Tail);
                for (int i = 0; i < 9; i++)
                {
                    Cnt = ReadRow(ProcSel.Single.frmStab10.DataGridView6.Rows, 20, i, Cnt, Length, ref sData.Tail);
                }
            }
            //Read Shutdown para DB50
            if (sData.Shutdown != null)
            {
                ReadRow(ProcSel.Single.frmStab11.DataGridView1.Rows, 16, 0, 0, sData.Shutdown.Length, ref sData.Shutdown);
            }
            //Read Purge Parameter DB51
            if (sData.Purge != null)
            {
                ReadRow(ProcSel.Single.frmStab12.DataGridView1.Rows, 7, 0, 0, sData.Purge.Length, ref sData.Purge);
            }
            //Read Backout para DB52
            if (sData.Backout != null)
            {
                Length = sData.Backout.Length;
                Cnt = 0;
                for (int i = 0; i < 6; i++)
                {
                    Cnt = ReadRow(ProcSel.Single.frmStab13.DataGridView1.Rows, 10, i, Cnt, Length, ref sData.Backout);
                }
            }
            //Read Temperatur Controller para DB53
            if (sData.TempCtl != null)
            {
                ReadRow(ProcSel.Single.frmStab14.DataGridView1.Rows, 5, 0, 0, sData.TempCtl.Length, ref sData.TempCtl);
            }
            //Read Crystal Cold PullOut Parameter DB54
            if (sData.CrystalCold != null)
            {
                Length = sData.CrystalCold.Length;
                Cnt = ReadRow(ProcSel.Single.frmStab15.DataGridView1.Rows, 24, 0, 0, Length, ref sData.CrystalCold);
                for (int i = 0; i < 9; i++)
                {
                    Cnt = ReadRow(ProcSel.Single.frmStab15.DataGridView2.Rows, 8, i, Cnt, Length, ref sData.CrystalCold);
                }
                for (int i = 0; i < 3; i++)
                {
                    Cnt = ReadRow(ProcSel.Single.frmStab15.DataGridView3.Rows, 10, i, Cnt, Length, ref sData.CrystalCold);
                }
            }
            //Read Cover PullOut Parameter DB55
            if (sData.CoverOut != null)
            {
                Length = sData.CoverOut.Length;
                Cnt = ReadRow(ProcSel.Single.frmStab16.DataGridView1.Rows, 15, 0, 0, Length, ref sData.CoverOut);
                for (int i = 0; i < 4; i++)
                {
                    Cnt = ReadRow(ProcSel.Single.frmStab16.DataGridView2.Rows, 5, i, Cnt, Length, ref sData.CoverOut);
                }
            }
            //Read Crystal Tube Pull In/Out Parameter DB56
            if (sData.TubeInOut != null)
            {
                ReadRow(ProcSel.Single.frmStab17.DataGridView1.Rows, 14, 0, 0, sData.TubeInOut.Length, ref sData.TubeInOut);
            }
            //Read Seed Pull In Parameter DB57
            if (sData.SeedPullIn != null)
            {
                ReadRow(ProcSel.Single.frmStab18.DataGridView1.Rows, 3, 0, 0, sData.SeedPullIn.Length, ref sData.SeedPullIn);
            }
            //Read CoverRotInOut In Parameter DB58
            if (sData.CoverRotInOut != null)
            {
                ProcSel.Single.frmStab19.DataGridView1.Rows[0].Cells[0].Value = 1 > sData.CoverRotInOut.Length ? "" : sData.CoverRotInOut[0];
            }
            //Read RotInOut In Parameter DB59
            if (sData.FTRotInOut != null)
            {
                ReadRow(ProcSel.Single.frmStab20.DataGridView1.Rows, 5, 0, 0, sData.FTRotInOut.Length, ref sData.FTRotInOut);
            }
            //Read AutoCharing In Parameter DB61
            if (sData.AutoCharing != null)
            {
                ReadRow(ProcSel.Single.frmStab21.DataGridView1.Rows, 4, 0, 0, sData.AutoCharing.Length, ref sData.AutoCharing);
            }
            //Read ReMelting In Parameter DB62
            if (sData.ReMelting != null)
            {
                Length = sData.ReMelting.Length;
                Cnt = ReadRow(ProcSel.Single.frmStab22.DataGridView1.Rows, 13, 0, 0, Length, ref sData.ReMelting);
                ReadRow(ProcSel.Single.frmStab22.DataGridView2.Rows, 16, 0, Cnt, Length, ref sData.ReMelting);
            }
            //Read OneKeySetCru In Parameter DB63
            if (sData.OneKeySetCru != null)
            {
                ReadRow(ProcSel.Single.frmStab23.DataGridView1.Rows, 4, 0, 0, sData.OneKeySetCru.Length, ref sData.OneKeySetCru);
            }
            //Read silicon preheat para DB64
            if (sData.SiliconPreheat != null)
            {
                Length = sData.SiliconPreheat.Length;
                Cnt = 0;
                for (int i = 0; i < 4; i++)
                {
                    Cnt = ReadRow(ProcSel.Single.frmStab24.DataGridView1.Rows, 5, i, Cnt, Length, ref sData.SiliconPreheat);
                }
            }
        }
        /// <summary>
        /// Dgv几列行参数读取
        /// </summary>
        /// <param name="Dgvrc">Dgv名称</param>
        /// <param name="RowNum">循环的行数</param>
        /// <param name="ColumnNum">第几列</param>
        /// <param name="StartAddr">读取文件行数据起始地址</param>
        /// <param name="StrArrayLen">每行元素数组长度</param>
        /// <param name="StrArray">每行元素数组</param>
        /// <returns>返回文件行数</returns>
        private static int ReadRow(DataGridViewRowCollection Dgvrc, int RowNum, int ColumnNum, int StartAddr, int StrArrayLen, ref string[] StrArray)
        {
            for (int i = 0; i < RowNum; i++)
            {
                Dgvrc[i].Cells[ColumnNum].Value = StartAddr + 1 > StrArrayLen ? "" : StrArray[StartAddr];
                StartAddr++;
            }
            return StartAddr;
        }
        public static string[] FileJudge(string FileName)
        {
            if (!File.Exists(FileName))
            {
                if (ProcSel.Single.saveForm.CreateFileFlag)
                {
                    ProcSel.Single.saveForm.CreateFileFlag = false;
                }
                else
                {
                    return null;
                }
            }
            return FormToArray();
        }

        public static string[] FormToArray()
        {
            StringBuilder LineSb = new StringBuilder();
            string[] StrSop = new string[24];
            int TempValue;
            //Write init para DB40
            for (int i = 0; i < 15; i++)
            {
                switch (i)
                {
                    case 6:
                    case 7:
                        if (ProcSel.Single.frmStab1.DataGridView1.Rows[i].Cells[0].Value.ToString() == "")
                        {
                            LineSb.Append(" ");
                        }
                        else
                        {
                            TempValue = Convert.ToInt32(ProcSel.Single.frmStab1.DataGridView1.Rows[i].Cells[0].Value);
                            if (TempValue > 1 || TempValue < 0)
                            {
                                LineSb.Append("0 ");
                            }
                            else
                            {
                                LineSb.Append(string.Concat(TempValue.ToString(), " "));
                            }
                        }
                        break;
                    case 8:
                        if (ProcSel.Single.frmStab1.DataGridView1.Rows[i].Cells[0].ToString() == "")
                        {
                            LineSb.Append(" ");
                        }
                        else
                        {
                            TempValue = Convert.ToInt32(ProcSel.Single.frmStab1.DataGridView1.Rows[i].Cells[0].Value);
                            if (TempValue > 20 || TempValue < 0)
                            {
                                LineSb.Append("2 ");
                            }
                            else
                            {
                                LineSb.Append(string.Concat(TempValue.ToString(), " "));
                            }
                        }
                        break;
                    case 9:
                        if (ProcSel.Single.frmStab1.DataGridView1.Rows[i].Cells[0].Value.ToString() == "")
                        {
                            LineSb.Append(" ");
                        }
                        else
                        {
                            TempValue = Convert.ToInt32(ProcSel.Single.frmStab1.DataGridView1.Rows[i].Cells[0].Value);
                            if (TempValue > 0 || TempValue < -20)
                            {
                                LineSb.Append("-2 ");
                            }
                            else
                            {
                                LineSb.Append(string.Concat(TempValue.ToString(), " "));
                            }
                        }
                        break;
                    case 12:
                        if (ProcSel.Single.frmStab1.DataGridView1.Rows[i].Cells[0].Value.ToString() == "")
                        {
                            LineSb.Append(" ");
                        }
                        else
                        {
                            TempValue = Convert.ToInt32(ProcSel.Single.frmStab1.DataGridView1.Rows[i].Cells[0].Value);
                            LineSb.Append(TempValue > 1 || TempValue < 0 ? "0 " : string.Concat(TempValue.ToString(), " "));
                        }
                        break;
                    default:
                        LineSb.Append(string.Concat(ProcSel.Single.frmStab1.DataGridView1.Rows[i].Cells[0].Value.ToString(), " "));
                        break;
                }
            }
            LineSb.Append(WriteStr(ProcSel.Single.frmStab1.DataGridView2.Rows, 26, 0));
            LineSb.Append(WriteStr(ProcSel.Single.frmStab1.DataGridView3.Rows, 20, 0));
            for (int i = 0; i < 2; i++)
            {
                LineSb.Append(WriteStr(ProcSel.Single.frmStab1.DataGridView4.Rows, 10, i));
            }
            LineSb.Append(WriteStr(ProcSel.Single.frmStab1.DataGridView5.Rows, 55, 0));
            StrSop[0] = LineSb.ToString();
            LineSb.Clear();
            //Write PumpDown/LeakBack para DB41
            LineSb.Append(WriteStr(ProcSel.Single.frmStab2.DataGridView1.Rows, 14, 0));
            StrSop[1] = LineSb.ToString();
            LineSb.Clear();
            //Write Pressuration/Melting para DB42
            LineSb.Append(WriteStr(ProcSel.Single.frmStab3.DataGridView1.Rows, 9, 0));
            LineSb.Append(WriteStr(ProcSel.Single.frmStab3.DataGridView2.Rows, 6, 0));
            for (int i = 0; i < 8; i++)
            {
                LineSb.Append(WriteStr(ProcSel.Single.frmStab3.DataGridView3.Rows, 10, i));
            }
            StrSop[2] = LineSb.ToString();
            LineSb.Clear();
            //Write Stabilize para DB44
            LineSb.Append(WriteStr(ProcSel.Single.frmStab4.DataGridView1.Rows, 20, 0));
            LineSb.Append(WriteStr(ProcSel.Single.frmStab4.DataGridView2.Rows, 11, 0));
            LineSb.Append(WriteStr(ProcSel.Single.frmStab4.DataGridView3.Rows, 5, 0));
            StrSop[3] = LineSb.ToString();
            LineSb.Clear();
            //Write Dip para DB43
            LineSb.Append(WriteStr(ProcSel.Single.frmStab5.DataGridView1.Rows, 18, 0));
            LineSb.Append(WriteStr(ProcSel.Single.frmStab5.DataGridView2.Rows, 5, 0));
            for (int i = 0; i < 2; i++)
            {
                LineSb.Append(WriteStr(ProcSel.Single.frmStab5.DataGridView3.Rows, 8, i));
            }
            StrSop[4] = LineSb.ToString();
            LineSb.Clear();
            //Write Neck para DB45
            LineSb.Append(WriteStr(ProcSel.Single.frmStab6.DataGridView1.Rows, 14, 0));
            LineSb.Append(WriteStr(ProcSel.Single.frmStab6.DataGridView2.Rows, 10, 0));
            LineSb.Append(WriteStr(ProcSel.Single.frmStab6.DataGridView3.Rows, 1, 0));
            for (int i = 0; i < 9; i++)
            {
                LineSb.Append(WriteStr(ProcSel.Single.frmStab6.DataGridView4.Rows, 10, i));
            }
            StrSop[5] = LineSb.ToString();
            LineSb.Clear();
            //Write Crown para DB46
            LineSb.Append(WriteStr(ProcSel.Single.frmStab7.DataGridView1.Rows, 4, 0));
            for (int i = 0; i < 8; i++)
            {
                LineSb.Append(WriteStr(ProcSel.Single.frmStab7.DataGridView2.Rows, 16, i));
            }
            LineSb.Append(WriteStr(ProcSel.Single.frmStab7.DataGridView3.Rows, 24, 0));
            for (int i = 0; i < 10; i++)
            {
                LineSb.Append(WriteStr(ProcSel.Single.frmStab7.DataGridView4.Rows, 16, i));
            }
            LineSb.Append(WriteStr(ProcSel.Single.frmStab7.DataGridView5.Rows, 14, 0));
            for (int i = 0; i < 2; i++)
            {
                LineSb.Append(WriteStr(ProcSel.Single.frmStab7.DataGridView6.Rows, 8, i));
            }
            LineSb.Append(WriteStr(ProcSel.Single.frmStab7.DataGridView7.Rows, 15, 0));
            for (int i = 0; i < 10; i++)
            {
                LineSb.Append(WriteStr(ProcSel.Single.frmStab7.DataGridView8.Rows, 8, i));
            }
            StrSop[6] = LineSb.ToString();
            LineSb.Clear();
            //Write Shoulder para DB47
            LineSb.Append(WriteStr(ProcSel.Single.frmStab8.DataGridView1.Rows, 17, 0));
            for (int i = 0; i < 2; i++)
            {
                LineSb.Append(WriteStr(ProcSel.Single.frmStab8.DataGridView3.Rows, 16, i));
            }
            LineSb.Append(WriteStr(ProcSel.Single.frmStab8.DataGridView4.Rows, 5, 0));
            LineSb.Append(WriteStr(ProcSel.Single.frmStab8.DataGridView5.Rows, 5, 0));
            for (int i = 0; i < 6; i++)
            {
                LineSb.Append(WriteStr(ProcSel.Single.frmStab8.DataGridView6.Rows, 10, i));
            }
            for (int i = 0; i < 2; i++)
            {
                LineSb.Append(WriteStr(ProcSel.Single.frmStab8.DataGridView7.Rows, 8, i));
            }
            LineSb.Append(WriteStr(ProcSel.Single.frmStab8.DataGridView2.Rows, 11, 0));
            StrSop[7] = LineSb.ToString();
            LineSb.Clear();
            //Write Body para DB48
            LineSb.Append(WriteStr(ProcSel.Single.frmStab9.DataGridView1.Rows, 20, 0));
            for (int i = 0; i < 11; i++)
            {
                LineSb.Append(WriteStr(ProcSel.Single.frmStab9.DataGridView2.Rows, 25, i));
            }
            for (int i = 0; i < 11; i++)
            {
                LineSb.Append(WriteStr(ProcSel.Single.frmStab9.DataGridView3.Rows, 16, i));
            }
            LineSb.Append(WriteStr(ProcSel.Single.frmStab9.DataGridView4.Rows, 3, 0));
            for (int i = 0; i < 2; i++)
            {
                LineSb.Append(WriteStr(ProcSel.Single.frmStab9.DataGridView5.Rows, 25, i));
            }
            StrSop[8] = LineSb.ToString();
            LineSb.Clear();
            //Write Tail para DB49
            LineSb.Append(WriteStr(ProcSel.Single.frmStab10.DataGridView1.Rows, 15, 0));
            for (int i = 0; i < 9; i++)
            {
                LineSb.Append(WriteStr(ProcSel.Single.frmStab10.DataGridView2.Rows, 20, i));
            }
            LineSb.Append(WriteStr(ProcSel.Single.frmStab10.DataGridView3.Rows, 5, 0));
            for (int i = 0; i < 3; i++)
            {
                LineSb.Append(WriteStr(ProcSel.Single.frmStab10.DataGridView4.Rows, 10, i));
            }
            LineSb.Append(WriteStr(ProcSel.Single.frmStab10.DataGridView5.Rows, 10, 0));
            for (int i = 0; i < 9; i++)
            {
                LineSb.Append(WriteStr(ProcSel.Single.frmStab10.DataGridView6.Rows, 20, i));
            }
            StrSop[9] = LineSb.ToString();
            LineSb.Clear();
            //Write Shutdown para DB50
            LineSb.Append(WriteStr(ProcSel.Single.frmStab11.DataGridView1.Rows, 16, 0));
            StrSop[10] = LineSb.ToString();
            LineSb.Clear();
            //Write Purge Parameter DB51
            LineSb.Append(WriteStr(ProcSel.Single.frmStab12.DataGridView1.Rows, 7, 0));
            StrSop[11] = LineSb.ToString();
            LineSb.Clear();
            //Write Backout para DB52
            for (int i = 0; i < 6; i++)
            {
                LineSb.Append(WriteStr(ProcSel.Single.frmStab13.DataGridView1.Rows, 10, i));
            }
            StrSop[12] = LineSb.ToString();
            LineSb.Clear();
            //Write temperature controller para DB53
            LineSb.Append(WriteStr(ProcSel.Single.frmStab14.DataGridView1.Rows, 5, 0));
            StrSop[13] = LineSb.ToString();
            LineSb.Clear();
            //Write Crystal Cold Pull Out DB54
            LineSb.Append(WriteStr(ProcSel.Single.frmStab15.DataGridView1.Rows, 24, 0));
            for (int i = 0; i < 9; i++)
            {
                LineSb.Append(WriteStr(ProcSel.Single.frmStab15.DataGridView2.Rows, 8, i));
            }
            for (int i = 0; i < 3; i++)
            {
                LineSb.Append(WriteStr(ProcSel.Single.frmStab15.DataGridView3.Rows, 10, i));
            }
            StrSop[14] = LineSb.ToString();
            LineSb.Clear();
            //Write temperature controller para DB55
            LineSb.Append(WriteStr(ProcSel.Single.frmStab16.DataGridView1.Rows, 15, 0));
            for (int i = 0; i < 4; i++)
            {
                LineSb.Append(WriteStr(ProcSel.Single.frmStab16.DataGridView2.Rows, 5, i));
            }
            StrSop[15] = LineSb.ToString();
            LineSb.Clear();
            //Write tubeInOut controller para DB56
            LineSb.Append(WriteStr(ProcSel.Single.frmStab17.DataGridView1.Rows, 14, 0));
            StrSop[16] = LineSb.ToString();
            LineSb.Clear();
            //Write seedPullIn controller para DB57
            for (int i = 0; i < 3; i++)
            {
                LineSb.Append(string.Concat(ProcSel.Single.frmStab18.DataGridView1.Rows[i].Cells[0].Value.ToString(), " "));
            }
            StrSop[17] = LineSb.ToString();
            LineSb.Clear();
            //Write coverRotInOut controller para DB58
            LineSb.Append(WriteStr(ProcSel.Single.frmStab19.DataGridView1.Rows, 1, 0));
            StrSop[18] = LineSb.ToString();
            LineSb.Clear();
            //Write FTRotInIn controller para DB59
            LineSb.Append(WriteStr(ProcSel.Single.frmStab20.DataGridView1.Rows, 5, 0));
            StrSop[19] = LineSb.ToString();
            LineSb.Clear();
            //Write AutoCharing controller para DB61
            LineSb.Append(WriteStr(ProcSel.Single.frmStab21.DataGridView1.Rows, 4, 0));
            StrSop[20] = LineSb.ToString();
            LineSb.Clear();
            //Write ReMelting controller para DB62
            LineSb.Append(WriteStr(ProcSel.Single.frmStab22.DataGridView1.Rows, 13, 0));
            LineSb.Append(WriteStr(ProcSel.Single.frmStab22.DataGridView2.Rows, 16, 0));
            StrSop[21] = LineSb.ToString();
            LineSb.Clear();
            //Write OneKeySetCru controller para DB63
            LineSb.Append(WriteStr(ProcSel.Single.frmStab23.DataGridView1.Rows, 4, 0));
            StrSop[22] = LineSb.ToString();
            LineSb.Clear();
            //Write silicon preheat para DB64
            for (int i = 0; i < 4; i++)
            {
                LineSb.Append(WriteStr(ProcSel.Single.frmStab24.DataGridView1.Rows, 5, i));
            }
            StrSop[23] = LineSb.ToString();
            LineSb.Clear();
            return StrSop;
        }
        /// <summary>
        /// Dgv每列生成字符串
        /// </summary>
        /// <param name="Dgvrc">表格</param>
        /// <param name="RowNum">总行数</param>
        /// <param name="ColumnNum">第几列</param>
        /// <returns></returns>
        private static string WriteStr(DataGridViewRowCollection Dgvrc, int RowNum, int ColumnNum)
        {
            StringBuilder LineSb = new StringBuilder();
            for (int i = 0; i < RowNum; i++)
            {
                if (Dgvrc[i].Cells[ColumnNum].Value == null)
                {
                    LineSb.Append(string.Concat("", " "));
                }
                else
                {
                    LineSb.Append(string.Concat(Dgvrc[i].Cells[ColumnNum].Value.ToString(), " "));
                }
            }
            return LineSb.ToString();
        }
        public static SopData<string> ArrayToSData(string[] StrSop)
        {
            SopData<string> SDataS = new SopData<string>();
            if (StrSop != null)
            {
                char[] SChar = new char[] { ' ' };
                SDataS.Initial = StrSop[0].Split(SChar).Take(SDataS.Initial.Length).ToArray();
                SDataS.PumpLeak = StrSop[1].Split(SChar).Take(SDataS.PumpLeak.Length).ToArray();
                SDataS.PressMelt = StrSop[2].Split(SChar).Take(SDataS.PressMelt.Length).ToArray();
                SDataS.Stabilize = StrSop[3].Split(SChar).Take(SDataS.Stabilize.Length).ToArray();
                SDataS.Dip = StrSop[4].Split(SChar).Take(SDataS.Dip.Length).ToArray();
                SDataS.Neck = StrSop[5].Split(SChar).Take(SDataS.Neck.Length).ToArray();
                SDataS.Crown = StrSop[6].Split(SChar).Take(SDataS.Crown.Length).ToArray();
                SDataS.Shoulder = StrSop[7].Split(SChar).Take(SDataS.Shoulder.Length).ToArray();
                SDataS.Body = StrSop[8].Split(SChar).Take(SDataS.Body.Length).ToArray();
                SDataS.Tail = StrSop[9].Split(SChar).Take(SDataS.Tail.Length).ToArray();
                SDataS.Shutdown = StrSop[10].Split(SChar).Take(SDataS.Shutdown.Length).ToArray();
                SDataS.Purge = StrSop[11].Split(SChar).Take(SDataS.Purge.Length).ToArray();
                SDataS.Backout = StrSop[12].Split(SChar).Take(SDataS.Backout.Length).ToArray();
                SDataS.TempCtl = StrSop[13].Split(SChar).Take(SDataS.TempCtl.Length).ToArray();
                SDataS.CrystalCold = StrSop[14].Split(SChar).Take(SDataS.CrystalCold.Length).ToArray();
                SDataS.CoverOut = StrSop[15].Split(SChar).Take(SDataS.CoverOut.Length).ToArray();
                SDataS.TubeInOut = StrSop[16].Split(SChar).Take(SDataS.TubeInOut.Length).ToArray();
                SDataS.SeedPullIn = StrSop[17].Split(SChar).Take(SDataS.SeedPullIn.Length).ToArray();
                SDataS.CoverRotInOut = StrSop[18].Split(SChar).Take(SDataS.CoverRotInOut.Length).ToArray();
                SDataS.FTRotInOut = StrSop[19].Split(SChar).Take(SDataS.FTRotInOut.Length).ToArray();
                SDataS.AutoCharing = StrSop[20].Split(SChar).Take(SDataS.AutoCharing.Length).ToArray();
                SDataS.ReMelting = StrSop[21].Split(SChar).Take(SDataS.ReMelting.Length).ToArray();
                SDataS.OneKeySetCru = StrSop[22].Split(SChar).Take(SDataS.OneKeySetCru.Length).ToArray();
                SDataS.SiliconPreheat = StrSop[23].Split(SChar).Take(SDataS.SiliconPreheat.Length).ToArray();
            }
            return SDataS;
        }
        public static SopData<float> RPlcToData()
        {
            SopData<float> SDataF = new SopData<float>();
            if (PLC.IsConn)
            {
                PLC.RecvFloat(40, 0, ref SDataF.Initial);
                PLC.RecvFloat(41, 0, ref SDataF.PumpLeak);
                PLC.RecvFloat(42, 0, ref SDataF.PressMelt);
                PLC.RecvFloat(43, 0, ref SDataF.Dip);
                PLC.RecvFloat(44, 0, ref SDataF.Stabilize);
                PLC.RecvFloat(45, 0, ref SDataF.Neck);
                PLC.RecvFloat(46, 0, ref SDataF.Crown);
                PLC.RecvFloat(47, 0, ref SDataF.Shoulder);
                PLC.RecvFloat(48, 0, ref SDataF.Body);
                PLC.RecvFloat(49, 0, ref SDataF.Tail);
                PLC.RecvFloat(50, 0, ref SDataF.Shutdown);
                PLC.RecvFloat(51, 0, ref SDataF.Purge);
                PLC.RecvFloat(52, 0, ref SDataF.Backout);
                PLC.RecvFloat(53, 0, ref SDataF.TempCtl);
                PLC.RecvFloat(54, 0, ref SDataF.CrystalCold);
                PLC.RecvFloat(55, 0, ref SDataF.CoverOut);
                PLC.RecvFloat(56, 0, ref SDataF.TubeInOut);
                PLC.RecvFloat(57, 0, ref SDataF.SeedPullIn);
                SDataF.CoverRotInOut[0] = PLC.RecvFloat(58, 0, 1);
                PLC.RecvFloat(59, 0, ref SDataF.FTRotInOut);
                PLC.RecvFloat(61, 0, ref SDataF.AutoCharing);
                PLC.RecvFloat(62, 0, ref SDataF.ReMelting);
                PLC.RecvFloat(63, 0, ref SDataF.OneKeySetCru);
                PLC.RecvFloat(64, 0, ref SDataF.SiliconPreheat);
            }
            return SDataF;
        }
        public static void SDataToPLC(SopData<float> SDataS)
        {
            if (SDataS != null)
            {
                PLC.SendFloat(33, 296, PLC.ReadValue[1]);
                PLC.SendMultiFloat(40, SDataS.Initial);
                PLC.SendMultiFloat(41, SDataS.PumpLeak);
                PLC.SendMultiFloat(42, SDataS.PressMelt);
                PLC.SendMultiFloat(43, SDataS.Dip);
                PLC.SendMultiFloat(44, SDataS.Stabilize);
                PLC.SendMultiFloat(45, SDataS.Neck);
                PLC.SendMultiFloat(46, SDataS.Crown);
                PLC.SendMultiFloat(47, SDataS.Shoulder);
                PLC.SendMultiFloat(48, SDataS.Body);
                PLC.SendMultiFloat(49, SDataS.Tail);
                PLC.SendMultiFloat(50, SDataS.Shutdown);
                PLC.SendMultiFloat(51, SDataS.Purge);
                PLC.SendMultiFloat(52, SDataS.Backout);
                PLC.SendMultiFloat(53, SDataS.TempCtl);
                PLC.SendMultiFloat(54, SDataS.CrystalCold);
                PLC.SendMultiFloat(55, SDataS.CoverOut);
                PLC.SendMultiFloat(56, SDataS.TubeInOut);
                PLC.SendMultiFloat(57, SDataS.SeedPullIn);
                PLC.SendMultiFloat(58, SDataS.CoverRotInOut);
                PLC.SendMultiFloat(59, SDataS.FTRotInOut);
                PLC.SendMultiFloat(61, SDataS.AutoCharing);
                PLC.SendMultiFloat(62, SDataS.ReMelting);
                PLC.SendMultiFloat(63, SDataS.OneKeySetCru);
                PLC.SendMultiFloat(64, SDataS.SiliconPreheat);
                PLC.SendFloat(33, 296, 0);
            }
        }
        public static SopData<string> FloatToStr(SopData<float> SDataF)
        {
            SopData<string> SDataS = new SopData<string>();
            if (SDataF != null)
            {
                SDataS.Initial = SDataF.Initial.FloatToStr();
                SDataS.PumpLeak = SDataF.PumpLeak.FloatToStr();
                SDataS.PressMelt = SDataF.PressMelt.FloatToStr();
                SDataS.Stabilize = SDataF.Stabilize.FloatToStr();
                SDataS.Dip = SDataF.Dip.FloatToStr();
                SDataS.Neck = SDataF.Neck.FloatToStr();
                SDataS.Crown = SDataF.Crown.FloatToStr();
                SDataS.Shoulder = SDataF.Shoulder.FloatToStr();
                SDataS.Body = SDataF.Body.FloatToStr();
                SDataS.Tail = SDataF.Tail.FloatToStr();
                SDataS.Shutdown = SDataF.Shutdown.FloatToStr();
                SDataS.Purge = SDataF.Purge.FloatToStr();
                SDataS.Backout = SDataF.Backout.FloatToStr();
                SDataS.TempCtl = SDataF.TempCtl.FloatToStr();
                SDataS.CrystalCold = SDataF.CrystalCold.FloatToStr();
                SDataS.CoverOut = SDataF.CoverOut.FloatToStr();
                SDataS.TubeInOut = SDataF.TubeInOut.FloatToStr();
                SDataS.SeedPullIn = SDataF.SeedPullIn.FloatToStr();
                SDataS.CoverRotInOut = SDataF.CoverRotInOut.FloatToStr();
                SDataS.FTRotInOut = SDataF.FTRotInOut.FloatToStr();
                SDataS.AutoCharing = SDataF.AutoCharing.FloatToStr();
                SDataS.ReMelting = SDataF.ReMelting.FloatToStr();
                SDataS.OneKeySetCru = SDataF.OneKeySetCru.FloatToStr();
                SDataS.SiliconPreheat = SDataF.SiliconPreheat.FloatToStr();
            }
            return SDataS;
        }
        public static SopData<float> StrToFloat(SopData<string> SDataS)
        {
            SopData<float> SDataF = new SopData<float>();
            if (SDataS != null)
            {
                SDataF.Initial = SDataS.Initial.StrToFloat();
                SDataF.PumpLeak = SDataS.PumpLeak.StrToFloat();
                SDataF.PressMelt = SDataS.PressMelt.StrToFloat();
                SDataF.Stabilize = SDataS.Stabilize.StrToFloat();
                SDataF.Dip = SDataS.Dip.StrToFloat();
                SDataF.Neck = SDataS.Neck.StrToFloat();
                SDataF.Crown = SDataS.Crown.StrToFloat();
                SDataF.Shoulder = SDataS.Shoulder.StrToFloat();
                SDataF.Body = SDataS.Body.StrToFloat();
                SDataF.Tail = SDataS.Tail.StrToFloat();
                SDataF.Shutdown = SDataS.Shutdown.StrToFloat();
                SDataF.Purge = SDataS.Purge.StrToFloat();
                SDataF.Backout = SDataS.Backout.StrToFloat();
                SDataF.TempCtl = SDataS.TempCtl.StrToFloat();
                SDataF.CrystalCold = SDataS.CrystalCold.StrToFloat();
                SDataF.CoverOut = SDataS.CoverOut.StrToFloat();
                SDataF.TubeInOut = SDataS.TubeInOut.StrToFloat();
                SDataF.SeedPullIn = SDataS.SeedPullIn.StrToFloat();
                SDataF.CoverRotInOut = SDataS.CoverRotInOut.StrToFloat();
                SDataF.FTRotInOut = SDataS.FTRotInOut.StrToFloat();
                SDataF.AutoCharing = SDataS.AutoCharing.StrToFloat();
                SDataF.ReMelting = SDataS.ReMelting.StrToFloat();
                SDataF.OneKeySetCru = SDataS.OneKeySetCru.StrToFloat();
                SDataF.SiliconPreheat = SDataS.SiliconPreheat.StrToFloat();
            }
            return SDataF;
        }
    }
}
