namespace Task007_Timer
{
    using System;
    using System.Timers;
    using System.Threading;

    public class Timer
    {
        //fields
        private int timeDelay;

        public delegate void DelegateTimerMethod(string instuction);

        private DelegateTimerMethod NewMethod;

        //constructor
        public Timer(int seconds)
        {
            this.TimeDelay = seconds;
        }

        //properties
        public DelegateTimerMethod Method
        {
            get { return NewMethod; }
            set { NewMethod = value; }
        } 
        public int TimeDelay
        {
            get { return timeDelay; }
            set { timeDelay = value; }
        }

        //methods
        public void Start(string test)
        {
            while (true)
            {
                NewMethod(test);
                Thread.Sleep(timeDelay * 1000);
            }
        }

    }
}
