using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 赋值运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 34;

            num1 += 12;
            num1 -= 12;
            num1 *= 12;
            num1 /= 12;
            num1 %= 12;

            Console.WriteLine(num1);

            Console.ReadKey();
        }
    }
}
