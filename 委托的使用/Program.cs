using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托的使用
{
    public delegate double MyDelegate(double param1, double param2);

    class Program
    {

        static double Multiply(double param1, double param2)
        {
            return param1 * param2;
        }

        static double Divide(double param1, double param2)
        {
            return param1 / param2; 
        }

        static void Main(string[] args)
        {

            MyDelegate de;

            de = Multiply;

            Console.WriteLine(de(2.0, 34.1));

            de = Divide;

            Console.WriteLine(de(2.0, 34.1));

            Console.ReadKey();
        }
    }
}
