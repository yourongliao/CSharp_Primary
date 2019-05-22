using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace goto和return跳出循环
{
    class Program
    {
        static void Main(string[] args)
        {
            //    while (true)
            //    {
            //        int num = Convert.ToInt32(Console.ReadLine());

            //        if (num == 0)
            //        {
            //            goto mylabel;
            //        }
            //    }

            //mylabel:
            //    Console.WriteLine("我特喵跳出循环啦");
            //    Console.ReadKey();


            while (true)
            {
                int num = Convert.ToInt32(Console.ReadLine());

                if (num == 0)
                {
                    return;
                }
            }

            Console.WriteLine("已跳出循环");//return是用来终止程序的

            Console.ReadKey();


        
        }
    }
}
