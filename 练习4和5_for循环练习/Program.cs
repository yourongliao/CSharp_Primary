using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习4和5_for循环练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //int count = 0;
            //int sum = 0;

            //for (int i = 1; i <= 1000; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        sum += i;
            //        count++;

            //        Console.WriteLine(i + "可以被7整除");

            //        if (count == 5)
            //        {
            //            Console.WriteLine("这5个的和是：" + sum);

            //            sum = 0;

            //            count = 0;
            //        }
            //    }
            //}

            //Console.ReadKey();

            for (int i = 1; i <= 100; i++)
            {
                int pingfang = i * i;

                double gen = Math.Sqrt(i);

                Console.WriteLine("平方为：" + pingfang + "开根为："+gen);
 
            }

            Console.ReadKey();
        }
    }
}
