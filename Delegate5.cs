using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    delegate void CustomDel(string s);
    class Delegate5
    {
        static void Hello(string s)
        {
            System.Console.WriteLine("  Hello "+ s);
        }
        static void Goodbye(string s)
        {
            System.Console.WriteLine("  Goodbye "+ s);
        }

        static void Main()
        {
            
            CustomDel hiDel, byeDel, multiDel, multiMinusHiDel;
                   
            hiDel = Hello;
            byeDel = Goodbye;
            multiDel = hiDel + byeDel;
            multiMinusHiDel = multiDel - hiDel;
            Console.WriteLine("Invoking delegate hiDel:");
            hiDel("A");
            Console.WriteLine("Invoking delegate byeDel:");
            byeDel("B");
            Console.WriteLine("Invoking delegate multiDel:");
            multiDel("C");
            Console.WriteLine("Invoking delegate multiMinusHiDel:");
            multiMinusHiDel("D");
            Console.Read();
        }
    }
}
