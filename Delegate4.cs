using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    delegate void Del1();
    class SampleClass
    {
        public void InstanceMethod()
        {
            Console.WriteLine("This is from instance method");
        }
        public static void StaticMethod()
        {
            Console.WriteLine("This is from static  method");
        }
    }
    class Delegate4
    {
        static void Main(string[] args)
        {
            SampleClass sc = new SampleClass();
            Del1 d1 = sc.InstanceMethod;
            d1();
            d1 = SampleClass.StaticMethod;
            d1();
            Console.Read();
        }
    }
}
