using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 循环的中断Continue
{
    class Program
    {
        static void Main(string[] args)
        {
            //int index = 1;
            //while (true)
            //{
            //    index++;
            //    if (index == 5) 
            //    {
            //        continue;
            //    }

            //    if (index == 10)
            //    {
            //        break;
            //    }

            //    Console.WriteLine(index);
            //}

            int sum = 0;

            while (true)
            {
                int num = Convert.ToInt32(Console.ReadLine());

                if (num == 0)
                {
                    break;
                }
                if (num % 2 == 1)
                {
                    continue;
                }

                sum += num;
            }

            Console.WriteLine(sum);

            Console.ReadKey();
            
        }
    }
}
