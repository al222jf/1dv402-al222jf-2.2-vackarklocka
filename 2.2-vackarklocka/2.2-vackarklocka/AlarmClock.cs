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
            }
        }
    }
}
