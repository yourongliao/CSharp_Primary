using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while循环
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 1;

            do
            {
                Console.WriteLine(index);

                index++;
            } while (index<9);

            Console.ReadKey();
        }
    }
}
