using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习5和6
{
    class Program
    {
        static void Main(string[] args)
        {

            //for (int i = 1; i <= 100; i++)
            //{
            //    if ((i % 3 == 0) && (i % 5 == 0))
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.ReadKey();

            for (int i = 2; i < 1001; i++)
            {
                bool isZhishu = true;

                for (int j = 2; j <= i - 1; j++)
                {
                    if (i % j == 0)
                    {
                        isZhishu = false;
                        break;
                    }
                }

                if (isZhishu)
                Console.WriteLine(i + "是质数");
            }

            Console.ReadKey();
        }
    }
}
