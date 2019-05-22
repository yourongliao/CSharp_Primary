using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 异常处理_案例2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 0;

            Console.WriteLine("请输入第一个数字");

            while (true)
            {
                try
                {
                    num1 = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("您输入的不是一个整数，请重新输入");
                }
            }

            Console.WriteLine("请输入第二个数字");

            while (true)
            {
                try
                {
                    num2 = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("您输入的不是一个整数，请重新输入");
                }
            }

            int sum = num1 + num2;

            Console.WriteLine(sum);

            Console.ReadKey();
            
        }
    }
}
