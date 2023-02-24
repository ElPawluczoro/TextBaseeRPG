using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextBasedRPG.Classes.GeneralClasses;

namespace TextBasedRPG.Classes.World_
{
    internal class Time
    {
        private int minutes; public int Minutes { get => minutes; set => minutes = value; }
        private int hours; public int Hours { get => hours; set => hours = value; }
        private int days; public int Days { get => days; set => days = value; }

        public Time(int minutes, int hours, int days)
        {
            this.minutes = minutes;
            this.hours = hours;
            this.days = days;
        }

        public void TimePasses(int min = 0, int h = 0, int d = 0)
        {
            minutes += min;
            while(minutes >= 60)
            {
                hours++;
                minutes -= 60;
            }

            hours += h;
            while (hours >= 24)
            {
                days++;
                hours -= 24;
            }

            days += d;
        }

        public void DisplayTime()
        {
            Console.WriteLine("Time:\n" +
                              "Day: " + days +"\n" +
                              "Hour: " + hours +"\n" +
                              "Minute: " + minutes);
            WriteMethods.WriteSeparator();
        }




    }
}
