using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate double De11(int x,float  y,double z);
    public delegate void Del2(int x,float  y);
    public delegate bool Del3(string s);
    class Delegate7
    {
        public static  double AddNums1(int x,float y,double z)
        {
            return x + y + z;
        }
        public static void AddNums2(int x, float y)
        {
            Console.WriteLine(x + y);
        }
        public static bool CheckLength(String s)
        {
            if(s.Length>5)
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            Func<int, float, double,double> obj1 = AddNums1;
            double Results=obj1.Invoke(10,34.5f,36.24);
            Console.WriteLine(Results);

            Action<int, float> obj2 = AddNums2;
            obj2.Invoke(12, 125.3f);

            Predicate<string> obj3 = CheckLength;
            bool Res = obj3.Invoke("Hello every one");
            Console.WriteLine(Res);
            Console.Read();
        }
    }
}
