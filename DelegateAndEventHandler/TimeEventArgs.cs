using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEventHandler
{
    public class TimeEventArgs:EventArgs
    {
        public readonly int Hour;
        public readonly int Minute;
        public readonly int Second;

        public TimeEventArgs(int h,int m,int s)
        {
            Hour = h;
            Minute = m;
            Second = s;
        }

    }
}
