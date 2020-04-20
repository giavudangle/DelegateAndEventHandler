using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEventHandler
{
    class Method
    {
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

    


    class Program
    {
        //public delegate void ShowLog(string message);
        static void Main(string[] args)
        {
            //ShowLog info = new ShowLog(Method.Info);
            //ShowLog warning = new ShowLog(Method.Warning);
            //ShowLog hello = new ShowLog(Method.Hello);

            //ShowLog rootDelegate = info + warning + hello;
            //rootDelegate("Test LOG");
            

        }
    }
}
