using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Delegate1
    {
        static void Display(string msg)
        {
            Console.WriteLine("The message is : " + msg);
        }
        public delegate void SinglecastDelegate(string msg);
        static void Main(string[] args)
        {
            SinglecastDelegate scd = new SinglecastDelegate(Display);
            scd("Hello,how are you");
            Console.Read();
        }
    }
}
