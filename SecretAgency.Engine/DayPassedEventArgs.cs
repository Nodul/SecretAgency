using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretAgency.Engine
{
    public class DayPassedEventArgs : EventArgs
    {
        public DayPassedEventArgs(int day, int month, int year, int totalDays)
        {
            Day = day;
            Month = month;
            Year = year;
            TotalDays = totalDays;
        }

        public int Day { get; protected set; }
        public int Month { get; protected set; }
        public int Year { get; protected set; }
        public int TotalDays { get; protected set; }

    }
}
