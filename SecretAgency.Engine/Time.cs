using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretAgency.Engine
{
    public class Time
    {
        private int _totalDays; // total full days passed since game start
        public int TotalDays { get { return _totalDays; } }

        private int _dayOfMonth;
        public int DayOfMonth { get { return _dayOfMonth; } }

        private int _month;
        public int Month { get { return _month; } }

        private int _year;
        public int Year { get { return _year; } }


        public event DayPassedHandler DayPassed;
        public delegate void DayPassedHandler(Time t, DayPassedEventArgs e);

        private static Time _instance;
        public static Time Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Time(1,1,2015);
                }
                return _instance;
            }
        }
        private Time(int day, int month, int year)
        {
            _totalDays = 0;
            _dayOfMonth = day;
            _month = month;
            _year = year;
        }

        public void RequestNextDay()
        {
            //Console.WriteLine("Requested next day. Processing...");
            ProcessTime();
        }

        private void ProcessTime()
        {
            _totalDays++;
            _dayOfMonth++;

            if(_dayOfMonth > 31)
            {
                _dayOfMonth = 1;
                _month++;
                if(Month > 12)
                {
                    _year = 1;
                    _year++;
                }

            }

            DayPassed?.Invoke(this, new DayPassedEventArgs(this._dayOfMonth, this._month, this._year, this._totalDays));

        }

    }
}
