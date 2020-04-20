using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEventHandler
{
    



    class Program
    {
        
        static void Main(string[] args)
        {
            //Method.ShowLog info = new Method.ShowLog(Method.Info);
            //Method.ShowLog warning = new Method.ShowLog(Method.Warning);
            //Method.ShowLog hello = new Method.ShowLog(Method.Hello);
            //Method.ShowLog rootDelegate = info + warning + hello;
            //rootDelegate("Test LOG");

            MyApplication myApp = new MyApplication();
            Console.WriteLine("User Click on Open Button...");
            myApp.openButton.Clicked();
            Console.WriteLine("\n\n");
            Console.WriteLine("User Click on Save Button...");
            myApp.saveButton.Clicked();
            Console.Read();
        }
    }
}
