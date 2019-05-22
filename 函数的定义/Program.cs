using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 函数的定义
{
    class Program
    {

        static int Plus(int num1, int num2)
        {
            int sum = num1 + num2;

            return sum;
        }

        static void Main(string[] args)
        {

            int num1 = 45;

            int num2 = 50;

            int res = Plus(num1, num2);

            int res2 = Plus(2, 3);

            Console.WriteLine(res + ":" + res2);

            Console.ReadKey();
        }
    }
}
