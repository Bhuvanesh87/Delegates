using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Num = { 1, 2, 3, 4, 5, 13, 7, 8, 9, 10, 11, 12, 6, 14, 26 };
            int i;
            Console.WriteLine("Given array is ");
            for( i=0;i<Num.Length;i++)
            {
                Console.Write(Num[i] + " ,");
            }
            Console.WriteLine();
            Console.WriteLine("Even numbers in the given array");           
            for (i = 0; i < Num.Length; i++)
            {
              if (Num[i] % 2 == 0)
                {
                    Console.Write(Num[i] + ",");    
                }
            }
            int[] y = new int[Num.Length-i];
            for(i=0;i<y.Length;i++)
            {
                Console.Write(y[i] + ",");
            }
            Console.WriteLine();
            Console.WriteLine("Odd numbers in the given array");
            for (i = 0; i < Num.Length; i++)
            {
                if (Num[i] % 2 == 1)
                {
                    Console.Write(Num[i] + ",");
                }
            }
            int[] z = new int[Num.Length-i];
            for (i = 0; i < z.Length; i++)
            {
                Console.Write(z[i] + ",");
            }
            Console.Read();

        }
    }
}
