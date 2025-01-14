using System;

namespace CrystalGrowth.Unities
{
    internal class DateT
    {
        public DateTime Value;
        public DateT()
        {
            Value = DateTime.Now;
        }
        public string Add(string selectStr)
        {
            switch (selectStr)
            {
                case "Year":
                    Value = Value.AddYears(1);
                    break;
                case "Mouth":
                    Value = Value.AddMonths(1);
                    break;
                case "Day":
                    Value = Value.AddDays(1);
                    break;
                case "Hour":
                    Value = Value.AddHours(1);
                    break;
                case "Minute":
                    Value = Value.AddMinutes(1);
                    break;
                default:
                    Value = Value.AddSeconds(1);
                    break;
            }
            return Value.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public string Reduce(string selectStr)
        {
            switch (selectStr)
            {
                case "Year":
                    Value = Value.AddYears(-1);
                    break;
                case "Mouth":
                    Value = Value.AddMonths(-1);
                    break;
                case "Day":
                    Value = Value.AddDays(-1);
                    break;
                case "Hour":
                    Value = Value.AddHours(-1);
                    break;
                case "Minute":
                    Value = Value.AddMinutes(-1);
                    break;
                default:
                    Value = Value.AddSeconds(-1);
                    break;

            }
            return Value.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
