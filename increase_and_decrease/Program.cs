using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace increase_and_decrease
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1 = 45;

            //int res1 = num1++;

            //int res1 = ++num1;

            //Console.WriteLine(res1+":"+num1);

            int res1 = num1--;

            int res2 = --num1;

            Console.WriteLine(res1 + ":" + res2);


            Console.ReadKey();
        }
    }
}
