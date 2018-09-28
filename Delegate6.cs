using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void SampleDelegate();
    class Delegate6
    {
        public static void Method1()
        {
            Console.WriteLine("From Method1");
        }
        public static void Method2()
        {
            Console.WriteLine("From Method2");
        }
        public static void Method3()
        {
            Console.WriteLine("From Method3");
        }
        public static void Method4()
        {
            Console.WriteLine("From Method4");
        }
        static void Main(string[] args)
        {
            SampleDelegate del = new SampleDelegate(Method1);
            del += Method2;
            del += Method3;
            del += Method4;
            del();
            Console.Read();
        }
    }
}
