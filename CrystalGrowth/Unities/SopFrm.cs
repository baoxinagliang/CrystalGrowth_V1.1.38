﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using NPOI.HSSF.UserModel;
using NPOI.HSSF.Util;
using NPOI.SS.UserModel;
using NPOI.SS.Util;

namespace CrystalGrowth.Unities
{
    internal class SopFrm
    {
        public struct TabCtrl
        {
            public string Name;
            public List<Page> PageList;
        }
        public struct Page
        {
            public string Name;
            public DataGridView DgvTable;
        }
        readonly List<TabCtrl> TabCtrlList;
        readonly string Version;
        public SopFrm(string version, List<TabCtrl> tabCtrlList)
        {
            this.Version = version;
            this.TabCtrlList = tabCtrlList;
        }
        public void GenerateExcelFromDataFile(string SrcDataFilePath, string DesExcelFilePath)
        {
            HSSFWorkbook Excel = new HSSFWorkbook();
            Excel.CreateSheet("SOP版本号");
            for (int i = 0; i < TabCtrlList.Count; i++)
            {
                Excel.CreateSheet(TabCtrlList[i].Name);
            }
            //构建Sop版本信息
            ISheet SopSheet = Excel.GetSheet("SOP版本号");
            SopSheet.CreateRow(0);
            SopSheet.GetRow(0).CreateCell(0).SetCellValue("SOP版本号:");
            SopSheet.GetRow(0).CreateCell(1).SetCellValue(Version);
            SopSheet.SetColumnWidth(0, 7680);
            SopSheet.SetColumnWidth(1, 7680);
            //混淆角度放肩参数
            SopSheet.CreateRow(1);
            SopSheet.GetRow(1).CreateCell(0).SetCellValue("SOP校验码(修改后会造成程序崩溃):");
            SopSheet.SetColumnWidth(0, 7680);
            //创建表格标题栏样式
            ICellStyle HeaderStyle = Excel.CreateCellStyle();
            IFont Font = Excel.CreateFont();
            Font.FontHeightInPoints = 10.0F;
            Font.FontName = "微软雅黑";
            Font.Color = HSSFColor.Black.Index;
            HeaderStyle.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;
            HeaderStyle.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;
            HeaderStyle.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;
            HeaderStyle.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;
            HeaderStyle.SetFont(Font);
            HeaderStyle.FillForegroundColor = HSSFColor.Yellow.Index;
            HeaderStyle.FillPattern = FillPattern.SolidForeground;
            HeaderStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
            HeaderStyle.VerticalAlignment = VerticalAlignment.Center;
            //创建列属性标题栏样式   
            ICellStyle CellStyle = Excel.CreateCellStyle();
            CellStyle.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;
            CellStyle.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;
            CellStyle.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;
            CellStyle.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;
            CellStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
            CellStyle.VerticalAlignment = VerticalAlignment.Center;
            CellStyle.SetFont(Font);
            string[] Lines = File.ReadAllLines(SrcDataFilePath, Encoding.UTF8);
            for (int i = 0; i < TabCtrlList.Count; i++)
            {
                ISheet Sheet = Excel.GetSheet(TabCtrlList[i].Name);
                string[] DataStr = Lines[i].Split(' ');
                int Index = 0;
                int StartRowIndex = 0;
                int total = 0;
                string str = "";
                for (int j = 0; j < TabCtrlList[i].PageList.Count; j++)
                {
                    if (TabCtrlList[i].Name == "放肩")
                    {
                        if (TabCtrlList[i].PageList[j].Name != "角度放肩参数表")
                        {
                            total += TabCtrlList[i].PageList[j].DgvTable.ColumnCount * TabCtrlList[i].PageList[j].DgvTable.RowCount;
                        }
                        else
                        {
                            for (int m = total; m < DataStr.Length; m++)
                            {
                                str = string.Concat(str, DataStr[m], " ");
                            }
                            ISheet TempSheet = Excel.GetSheet("SOP版本号");
                            TempSheet.GetRow(1).CreateCell(1).SetCellValue(EncryptString(str));
                            SopSheet.SetColumnWidth(1, 7680);
                            Index += TabCtrlList[i].PageList[j].DgvTable.ColumnCount * TabCtrlList[i].PageList[j].DgvTable.RowCount;
                            continue;
                        }
                    }
                    else
                    {
                        total = 0;
                        str = "";
                    }
                    DataGridView Dgv = TabCtrlList[i].PageList[j].DgvTable;
                    int Cols = Dgv.Columns.Count;
                    int Rows = Dgv.Rows.Count;
                    //生成行的时候需要多生成两行给标题头和列属性名各留一行
                    //构建表格
                    CreateTable(CellStyle, HeaderStyle, Sheet, StartRowIndex, Rows, Cols);
                    Sheet.GetRow(StartRowIndex).GetCell(0).SetCellValue(TabCtrlList[i].PageList[j].Name);
                    IRow FirstRow = Sheet.GetRow(StartRowIndex + 1);
                    //填充数据
                    for (int iCol = 0; iCol <= Cols; iCol++)
                    {
                        if (iCol != Cols)
                        {
                            FirstRow.GetCell(iCol + 1).SetCellValue(Dgv.Columns[iCol].HeaderText); //生成列属性名
                        }
                        for (int iRow = StartRowIndex + 2; iRow < StartRowIndex + 2 + Rows; iRow++)
                        {
                            if (iCol == 0)
                            {
                                if (Dgv.Rows[iRow - (StartRowIndex + 2)].HeaderCell.Value != null)
                                {
                                    //生成行属性名
                                    Sheet.GetRow(iRow).GetCell(iCol).SetCellValue(Dgv.Rows[iRow - (StartRowIndex + 2)].HeaderCell.Value.ToString());
                                }
                            }
                            else
                            {
                                Sheet.GetRow(iRow).GetCell(iCol).SetCellValue(DataStr[Index++]);
                            }
                        }
                    }
                    //产生新的起始行
                    StartRowIndex += Rows + 2;
                }
            }
            //导出文件
            using (FileStream Fs = new FileStream(DesExcelFilePath, FileMode.Create))
            {
                Excel.Write(Fs);
                Fs.Flush();
            }
        }
        private void CreateTable(ICellStyle DataStyle, ICellStyle HeaderStyle, ISheet Sheet, int StartRowIndex, int Rows, int Cols)
        {
            for (int iRow = StartRowIndex; iRow <= StartRowIndex + Rows + 1; iRow++)
            {
                IRow Row = Sheet.CreateRow(iRow);
                Row.Height = 600;
                //生成列的时候多一列是因为列头在表格中没有被计算
                for (int iCol = 0; iCol <= Cols; iCol++)
                {
                    Row.CreateCell(iCol).CellStyle = DataStyle;
                    Sheet.SetColumnWidth(iCol, 3840);
                }
            }
            Sheet.SetColumnWidth(0, 7680);
            //合并单元格
            Sheet.AddMergedRegion(new CellRangeAddress(StartRowIndex, StartRowIndex, 0, Cols));
            Sheet.GetRow(StartRowIndex).GetCell(0).CellStyle = HeaderStyle;
            //添加表格名
        }
        public string ImportSop(string SrcExcelFilePath, string DesDataFilePath)
        {
            List<string> listStr = new List<string>();//读取Excel文件
            HSSFWorkbook Excel = new HSSFWorkbook(new FileStream(SrcExcelFilePath, FileMode.Open, FileAccess.Read));
            //校验版本号
            string ExcelVersion = Excel.GetSheet("SOP版本号").GetRow(0).GetCell(1).StringCellValue;
            if (ExcelVersion.Equals(Version) == false)
            {
                return "Excel文件SOP版本号与当前系统SOP版本不匹配！";
            }
            //生成数据
            for (int i = 0; i < TabCtrlList.Count; i++)
            {
                int StartRowIndex = 0;
                //通过工艺步骤名称获取相应的Sheet
                ISheet Sheet = Excel.GetSheet(TabCtrlList[i].Name);
                string DataLine = "";
                //通过循环获取每个工艺步骤中的各个表
                for (int j = 0; j < TabCtrlList[i].PageList.Count; j++)
                {
                    if (TabCtrlList[i].Name == "放肩" && TabCtrlList[i].PageList[j].Name == "角度放肩参数表")
                    {
                        //解析角度放肩参数
                        DataLine = string.Concat(DataLine, DecryptString(Excel.GetSheet("SOP版本号").GetRow(1).GetCell(1).StringCellValue.ToString()));
                        continue;
                    }
                    DataGridView Dgv = TabCtrlList[i].PageList[j].DgvTable;
                    //计算行数的时候会把表格头部也算上
                    int Rows = Dgv.Rows.Count;
                    //计算列数的时候表格的每行的头不会计算上
                    int Cols = Dgv.Columns.Count;
                    //获取数据
                    for (int iCol = 1; iCol <= Cols; iCol++)
                    {
                        for (int iRow = StartRowIndex + 3; iRow <= StartRowIndex + 2 + Rows; iRow++)
                        {
                            Sheet.GetRow(iRow - 1).GetCell(iCol).SetCellType(CellType.String);
                            if (!string.IsNullOrEmpty(Sheet.GetRow(iRow - 1).GetCell(iCol).StringCellValue))
                            {
                                DataLine = string.Concat(DataLine, Sheet.GetRow(iRow - 1).GetCell(iCol).StringCellValue.ToString(), " ");
                            }
                            else
                            {
                                DataLine = string.Concat(DataLine, " ");
                            }
                        }
                    }
                    StartRowIndex += Rows + 2;
                }
                listStr.Add(DataLine);
            }
            //创建输出Data数据文件流
            using (StreamWriter Sr = new StreamWriter(new FileStream(DesDataFilePath, FileMode.Create, FileAccess.Write)))
            {
                foreach (string str in listStr)
                {
                    Sr.WriteLine(str);
                    Sr.Flush();
                }
            }
            return "导入成功";
        }
        public string DecryptString(string Str)
        {
            char[] CharArray = Str.ToCharArray();
            int Length = CharArray.Length;
            byte[] ByteArray = new byte[Length];
            for (int i = 0; i < Length; i++)
            {
                ByteArray[i] = (byte)(Convert.ToByte(CharArray[i]) - 10);
            }
            return Encoding.ASCII.GetString(ByteArray);
        }
        public string EncryptString(string Str)
        {
            char[] CharArray = Str.ToCharArray();
            int Length = CharArray.Length - 1;
            byte[] ByteArray = new byte[Length];
            for (int i = 0; i < Length; i++)
            {
                ByteArray[i] = (byte)(Convert.ToByte(CharArray[i]) + 10);
            }
            return Encoding.ASCII.GetString(ByteArray);
        }
    }
}
