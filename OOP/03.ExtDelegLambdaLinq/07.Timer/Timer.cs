using System;
using System.Threading;

namespace _07.Timer
{
    /* 07. Using delegates write a class Timer that can execute certain method at each t seconds. */
    
    internal class Timer
    {
        public delegate void ExecuteDelegate();
        public ExecuteDelegate execute { get; set; }
        private int interval;

        public Timer(int seconds = 1)
        {
            this.Interval = seconds;
        }

        public int Interval
        {
            get 
            {
                return this.interval * 1000; 
            }
            set 
            {
                if (value < 1)
                {  
                    throw new ArgumentOutOfRangeException("interval", "The minimal interval is 1 second.");
                }

                this.interval = value; 
            }
        }

        public void Run()
        {
            while (true)
            {
                this.execute();
                Thread.Sleep(this.Interval);
            }
        }
    }
}
