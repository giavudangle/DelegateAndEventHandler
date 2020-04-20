using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEventHandler
{
    class Method
    {
        public delegate void ShowLog(string message);
        public static void Info(string s)
        {
            Console.WriteLine("Info" + s);
        }

        public static void Warning(string s)
        {
            Console.WriteLine("Warning" + s);
        }

        public static void Hello(string s)
        {
            Console.WriteLine("Hello" + s);
        }

    }
}
