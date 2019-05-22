using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for的循环套用
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = i; j < 10; j++)
            //    {
            //        Console.Write(i + "*" + j + "=" + (i * j) + " ");
            //    }

            //    Console.WriteLine();
            //}

            //Console.ReadKey();

            Random random = new Random();

            int num = random.Next(1, 7);

            Console.WriteLine(num);

            Console.ReadKey();
        }
    }
}
