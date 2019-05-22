using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接收输入和输出
{
    class Program
    {
        static void Main(string[] args)
        {

            string str1 = Console.ReadLine();

            int num1 = Convert.ToInt32(str1);

            string str2 = Console.ReadLine();

            int num2 = Convert.ToInt32(str2);

            int num = num1 + num2;

            Console.WriteLine(num);

            Console.ReadKey();
        }
    }
}
