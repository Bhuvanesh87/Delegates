using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Delegates
{
    class Calculations
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("the addition of two numbers is :" + (a + b));
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine("the difference of two numbers is :" + (a - b));
        }
        public  void Mul(int a, int b)
        {
            Console.WriteLine("the Product of two numbers is :" + (a * b));
        }
        public  void Div(int a, int b)
        {
            Console.WriteLine("the quoefficient of two numbers is :" + (a / b));
        }
    }
    public delegate void MulCastDelegate(int a, int b);
    class Delegate2
    {
        public static void Main(string[] args)
        {
            Calculations cal = new Calculations();
            MulCastDelegate mcd = new MulCastDelegate(cal.Add);
            mcd += cal.Sub;
            mcd += cal.Mul;
            mcd += cal.Div;

            mcd(10, 20);
            Console.Read();
        }
    }
}
