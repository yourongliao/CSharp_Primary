using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = Console.ReadLine();

            //Console.WriteLine(str);

            //Console.ReadKey();

            //string str = "123";

            string str = Console.ReadLine();


            //int num = Convert.ToInt32(str);

            double num = Convert.ToDouble(str);

            num++;

            Console.WriteLine(num);

            Console.ReadKey();
        }
    }
}
