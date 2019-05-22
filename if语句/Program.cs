using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if语句
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool var = false;

            //if (var)
            //if(50<=90)
            //{
            //    Console.WriteLine("-----------");
            //}

            //Console.WriteLine("if语句后面的语句");

            //Console.ReadKey();

            string str = Console.ReadLine();

            int score = Convert.ToInt32(str);

            if (score > 50)
                Console.WriteLine("您输入的分数，大于50");
            //if (score <= 50)
            //    Console.WriteLine("您输入的分数，小于或等于50");
            else
                Console.WriteLine("您输入的分数，小于或等于50");

            Console.ReadKey();
        }
    }
}
