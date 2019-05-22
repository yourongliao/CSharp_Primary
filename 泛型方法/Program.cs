using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型方法
{
    class Program
    {
        public static string GetSum<T,T2,T3,T4>(T a, T b)
        {
            return a + "" + b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetSum<int,int,int,int>(15, 65));

            Console.WriteLine(GetSum<double,string,int,float>(14.5, 446.1));

            Console.WriteLine(GetSum<string,int,double,double>("asfda1", "asfsaf11"));

            Console.ReadKey();
        }
    }
}
