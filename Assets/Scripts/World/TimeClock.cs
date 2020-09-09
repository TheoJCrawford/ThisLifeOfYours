using UnityEngine;

namespace TLY.World
{
    class TimeClock:MonoBehaviour
    {
        public bool isPaused = false;
        public Calender cal { get; private set; }
        public int hour { get; private set; }
        public int minute { get; private set; }

        public TimeClock()
        {
            cal = new Calender();
            hour = 7;
            minute = 0;
        }
        private void Update()
        {
            if (!isPaused)
            {
                InvokeRepeating("AddMinute", 3f, 3f);
            }
        }
        private void AddMinute()
        {
            minute++;
            if(minute == 60)
            {
                minute = 0;
                hour++;
                if(hour> 24)
                {
                    hour = 0;
                    cal.AdvanceDay();
                }
            }
        }
    }
}
