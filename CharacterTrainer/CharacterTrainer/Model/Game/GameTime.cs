using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterTrainer.Model
{
    class GameTime
    {
        private int Time { get; set; }
        private int YearDuration { get; set; }
        private int TimeCounter { get; set; }
        private int DayCounter { get; set; }
        private int YearCounter { get; set; }

        public GameTime(int _time, int _year)
        {
            this.Time = _time;
            this.YearDuration = _year;
            this.YearCounter = 0;
            this.TimeCounter = 0;
            this.DayCounter = 0;
        }

        public int GetTime()
        {
            return Time;
        }

        public int GetCurrentTime()
        {
            return TimeCounter;
        }

        public int GetYear()
        {
            return YearDuration;
        }

        public int GetCurrentYear()
        {
            return YearCounter;
        }

        public bool IsNewYear()
        {
            if (DayCounter == YearDuration)
            {
                YearCounter++;
                DayCounter = 0;
                return true;
            }
            return false;
        }

        internal void incrementTime()
        {
            TimeCounter++;
        }

        public bool IsNewDay()
        {
            if (TimeCounter == Time)
            {
                DayCounter++;
                TimeCounter = 0;
                return true;
            }
            return false;
        }
    }
}
