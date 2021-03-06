﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2_vackarklocka
{
    class AlarmClock
    {
        private int _alarmHour;
        private int _alarmMinute;
        private int _hour;
        private int _minute;

        public AlarmClock() : this(0, 0)
        {

        }

        public AlarmClock(int hour, int minute) : this(hour, minute, 0, 0)
        {

        }

        public AlarmClock(int hour, int minute, int alarmHour, int alarmMinute)
        {
            Hour = hour;
            Minute = minute;
            AlarmHour = alarmHour;
            AlarmMinute = alarmMinute;
        }

        public int AlarmHour
        {
            get { return _alarmHour; }
            set
            {
                if (value > 23 || value < 0)
                {
                    throw new ArgumentException();
                }

                _alarmHour = value; 
            }
        }

        public int AlarmMinute
        {
            get { return _alarmMinute; }
            set
            {
                if (value > 59 || value < 0)
                {
                    throw new ArgumentException();
                }

                _alarmMinute = value;
            }
        }

        public int Hour
        {
            get { return _hour; }
            set
            {
                if (value > 23 || value < 0)
                {
                    throw new ArgumentException();
                }

                _hour = value;
            }
        }

        public int Minute
        {
            get { return _minute; }
            set
            {
                if (value > 59 || value < 0)
                {
                    throw new ArgumentException();
                }

                _minute = value;
            }
        }
        

        public bool TickTock()
        {
            
            if (_minute < 59)
            {
                _minute++;
            }
            else
            {
                _minute = 0;
                if (_hour < 23)
                {
                    _hour++;
                }
                else
                {
                    _hour = 0;
                }
            }

            return _hour == _alarmHour && _minute == _alarmMinute;
        }

        public override string ToString()
        {
            return String.Format("{0,10}:{1:00} <{2}:{3:00}>", _hour, _minute, _alarmHour, _alarmMinute);
        }
    }
}
