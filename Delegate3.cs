using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    delegate void Del(int i, double j);    
    class Delegate3
    {
        void MulitplyNumbers(int m,double n)
        {
            Console.Write(m * n + " ");
        }
        static void Main(string[] args)
        {
            Delegate3 dl3 = new Delegate3();
            //instance for delegate
            Del d3=dl3.MulitplyNumbers;
            Console.WriteLine("Invoking the delegate: ");
            for(int i=1;i<=10;i++)
            {
                d3(i, 2);
            }
            Console.Read();
        }
    }
}
