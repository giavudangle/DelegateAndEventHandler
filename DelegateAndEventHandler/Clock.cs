using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DelegateAndEventHandler
{
    public class Clock
    {
        public delegate void SecondChangeHandler(object clock, EventArgs info);

        public event SecondChangeHandler OnSecondChange;

        public void Run()
        {
            while (!false)
            {
                Thread.Sleep(1000);
                if (OnSecondChange != null)
                {
                    OnSecondChange(this, new EventArgs());
                }
            }
        }
    }
}
