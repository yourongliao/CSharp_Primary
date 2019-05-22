using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习10_11_循环结构练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sum = 0;

            //int k = 0;

            //while (sum < 2000)
            //{
            //    k++;
            //    sum += k * k;
            //}

            //Console.WriteLine(k - 1);
            //Console.ReadKey();

            for (int i = 0; i <= 100 / 5; i++)
            {
                for (int j = 0; j <= (100 - (i * 5))/3; j++)
                {
                    int remain = 100 - 5 * i - 3 * j;

                    int number = remain * 3;

                    if ((i + j + number) == 100)
                    {
                        Console.WriteLine("公鸡" + i + " 母鸡" + j + " 小鸡" + number);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
