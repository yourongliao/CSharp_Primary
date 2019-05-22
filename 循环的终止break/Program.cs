using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 循环的终止break
{
    class Program
    {
        static void Main(string[] args)
        {
            //    int index = 1;

            //    while (true)
            //    {
            //        Console.WriteLine(index);

            //        if (index == 9)
            //        {
            //            break;
            //        }

            //        index++;
            //    }

            //    Console.ReadKey();

            while (true)
            {
                string str = Console.ReadLine();

                if (str == "0")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("您输入了那啥：" + str);
                }
            }

            Console.ReadKey();
        }

      
    }
}
