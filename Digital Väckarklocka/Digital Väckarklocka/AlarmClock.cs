using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Väckarklocka
{
    public class AlarmClock
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
                if (value < 0 || value > 23)
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
                if (value < 0 || value > 59)
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
                if (value < 0 || value > 23)
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
                if (value < 0 || value > 59)
                {
                    throw new ArgumentException();
                }
                _minute = value;
            }
        }

        public AlarmClock()
            : this(0,0)
        {
        }

        public AlarmClock(int hour, int minute)
            :this(hour, minute, 0, 0)
        {
        }

        public AlarmClock(int hour, int minute, int alarmHour, int alarmMinute)
        {
            Hour = hour;
            Minute = minute;
            AlarmHour = alarmHour;
            AlarmMinute = alarmMinute;
        }

        public bool TickTock()
        {
            _minute++;

            if (_minute == 60)
            {
                _minute = 0;
                ++_hour;

                if (_hour == 24)
                {
                    _hour = 0;                    
                }
            }
            
            if ((_hour == _alarmHour) && (_minute == _alarmMinute))
            {                
                return true;
            }
            return false; 
        }

        public string ToString()
        {
            if (_minute < 10 && _alarmMinute < 10)
            {
                return String.Format("{0,4}:0{1} <{2}:0{3}>", _hour, _minute, _alarmHour, _alarmMinute);
            }
            if (_minute < 10)
            {
                return String.Format("{0,4}:0{1} <{2}:{3}>", _hour, _minute, _alarmHour, _alarmMinute);
            }
            if (_alarmMinute < 10)
            {
                return String.Format("{0,4}:{1} <{2}:0{3}>", _hour, _minute, _alarmHour, _alarmMinute);
            }            
            return String.Format("{0,4}:{1} <{2}:{3}>", _hour, _minute, _alarmHour, _alarmMinute);            
        }
    }
}
