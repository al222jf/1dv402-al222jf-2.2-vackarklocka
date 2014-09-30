using System;
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
        public AlarmClock()
        {

        }

        public AlarmClock(int hour, int minute)
        {

        }

        public AlarmClock(int hour, int minute, int alarmHour, int alarmMinute)
        {
            hour = _hour;
            minute = _minute;
            alarmHour = _alarmHour;
            alarmMinute = _alarmMinute;
        }

        public bool TickTock()
        {
            _minute++;

            if (_minute == 60)
            {
                _minute = 0;
                _hour++;

                if (_hour == 24)
                {
                    _hour = 0;
                }
            }

            if (_hour == _alarmHour)
            {
                if (_minute == _alarmMinute)
                {
                    return true;
                }
            }
            return false;
        }

        public string ToString()
        {
            return String.Format("{0}:{1}", _hour, _minute);
        }
    }
}
