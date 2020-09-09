using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TLY.World
{
    public class Calender
    {
        public  int day { get; internal set; }
        public int month { get; internal set; }

        public int year { get; internal set; }

        public Calender()
        {
            day = 1;
            month = 3;
            year = 145;
        }

        internal void AdvanceDay()
        {
            day++;
            if(day > 30)
            {
                AdvanceMonth();
            }
        }

        private void AdvanceMonth()
        {
            day = 1;
            month++;
            if(month > 12)
            {
                AdvanceYear();
            }
        }

        private void AdvanceYear()
        {
            month=1;
            year++;
        }
    }
}
