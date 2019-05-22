using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace goto语句
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInteger = 5;

            goto mylabel;

            myInteger++;

        mylabel: Console.WriteLine(myInteger);

            Console.ReadKey();
        }
    }
}
