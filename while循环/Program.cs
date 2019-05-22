using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while循环
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 1;

            while (index<9)
            {
                Console.WriteLine(index);
                index++;
            }

            Console.ReadKey();
        }
    }
}
