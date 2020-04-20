using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DelegateAndEventHandler
{
    class MyClock
    {
        public delegate void TimeChangeHandler(object obj, TimeEventArgs args);
        public event TimeChangeHandler OnTimeChange;
        public void Run()
        {
            while (true)
            {
                Thread.Sleep(1000);
                if (OnTimeChange != null)
                {
                    DateTime date = DateTime.Now;
                    TimeEventArgs timeArgs = 
                        new TimeEventArgs(date.Hour, date.Minute, date.Second);
                    OnTimeChange(this, timeArgs);
                    
                }
            }
        }
    }
}
