using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 运算符的优先级
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 12 + 90;

            int num2 = 12 + 90 * 2;

            int num3 = (12 + 90) * 2;

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);

            Console.ReadKey();
        }
    }
}
