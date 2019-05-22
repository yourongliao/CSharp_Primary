using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习1和2_布尔运算符和数学运算符的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //int num3 = Convert.ToInt32(Console.ReadLine());
            //int num4 = Convert.ToInt32(Console.ReadLine());

            //int max = 0;
            //int min = 0;

            //if (num1 > max)
            //{
            //    max = num1;
            //}
            //if (num2 > max)
            //{
            //    max = num2;
            //}
            //if (num3 > max)
            //{
            //    max = num3;
            //}
            //if (num4 > max)
            //{
            //    max = num4;
            //}

            //min = num1;

            //if (num2 < min)
            //{
            //    min = num2;
            //}
            //if (num3 < min)
            //{
            //    min = num3;
            //}
            //if (num4 < min)
            //{
            //    min = num4;
            //}

            //Console.WriteLine(max + ":" + min);

            //Console.ReadKey();

            Console.WriteLine("请输入第一个数字");

            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("请输入第二个数字");

            int num2 = Convert.ToInt32(Console.ReadLine());




            Console.WriteLine("请选择一种计算方式");

            int num4 = Convert.ToInt32(Console.ReadLine());

            int res = 0;

            switch (num4)
            {
                case 0:
                    res = num1 + num2;
                    break;
                case 1:
                    res = num1 - num2;
                    break;
                case 2:
                    res = num1 - num2;
                    break;
                case 3:
                    res = num1 * num2;
                    break;
                case 4:
                    res = num1 / num2;
                    break;
            }

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
