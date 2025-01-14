using System;
using System.IO;
using System.Text;

namespace CrystalGrowth.Unities
{
    internal class FeedCur
    {
        public string[] Lines;
        public int Index = 0;
        public string Time;
        public string Value;
        public void WriteIn()
        {
            if (Lines != null && Lines.Length == 10)
            {
                if (Index == 9) { Index = 0; }
                Lines[Index] = string.Concat(Time, ",", Value);
                Index = Index > 8 ? 0 : Index + 1;
                Lines[9] = Index.ToString();
                for (int i = Index; i < 9; i++)
                {
                    Lines[i] = "1990-01-01 00:00:00,0";
                }
                File.WriteAllLines(FileHelper.FeedCurPath, Lines);
            }
        }
        public void ReadOut()
        {
            if (File.Exists(FileHelper.FeedCurPath))
            {
                Lines = File.ReadAllLines(FileHelper.FeedCurPath, Encoding.UTF8);
                if (Lines != null && Lines.Length == 10)
                {
                    Index = Convert.ToInt32(Lines[9]);
                }
            }
        }
    }
    internal class Feed
    {
        public int Index = 0;
        public string[] Lines;
        public Feed()
        {
            if (File.Exists(FileHelper.FeedPath))
            {
                Lines = File.ReadAllLines(FileHelper.FeedPath, Encoding.UTF8);
                if (Lines != null && Lines.Length == 10)
                {
                    Index = Convert.ToInt32(Lines[9]);
                }
            }
        }
        public void WriteIn()
        {
            if (Lines != null && Lines.Length == 10)
            {
                string[] strArray;
                StringBuilder sb = new StringBuilder();
                FeedCur feedCur = new FeedCur();
                feedCur.ReadOut();
                if (feedCur.Lines != null && feedCur.Lines.Length == 10)
                {
                    double total = 0.0;
                    for (int i = 0; i < 9; i++)
                    {
                        strArray = feedCur.Lines[i].Split(new char[] { ',' });
                        if (strArray.Length == 2 && strArray[0] != "1990-01-01 00:00:00,0")
                        {
                            if (i == 0) { sb.Append(strArray[0]); }
                            sb.Append(string.Concat(",", strArray[1]));
                            total += Convert.ToDouble(strArray[1]);
                        }
                        else
                        {
                            sb.Append(string.Concat(",", "0"));
                        }
                        feedCur.Lines[i] = "1990-01-01 00:00:00,0";
                    }
                    feedCur.Lines[9] = "0";
                    sb.Append(string.Concat(",", total.ToString("f2")));
                    Lines[Index] = sb.ToString();
                    if (Index == 9) { Index = 0; }
                    Index = Index > 8 ? 0 : Index + 1;
                    Lines[9] = Index.ToString();
                    File.WriteAllLines(FileHelper.FeedPath, Lines);
                    File.WriteAllLines(FileHelper.FeedCurPath, feedCur.Lines);
                }
            }
        }
    }
}
