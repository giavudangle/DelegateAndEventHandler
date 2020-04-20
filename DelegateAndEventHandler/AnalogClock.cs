using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEventHandler
{
    class AnalogClock
    {
        public void Subscribe(Clock theClock)
        {
            theClock.OnSecondChange += new Clock.SecondChangeHandler(Show);
        }

        public void Show(object obj,EventArgs args)
        {
            DateTime date = DateTime.Now;
            Console.WriteLine($"Analog Clock : {date.Hour}:{date.Minute}:{date.Second}");
        }
    }
}
