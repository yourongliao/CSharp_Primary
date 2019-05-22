using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型_泛型类
{
    class Program
    {
        static void Main(string[] args)
        {
            //var o1 = new ClassA<int>(12, 36);

            //string s = o1.GetSum();

            //Console.WriteLine(s);

            //Console.ReadKey();

            var o2 = new ClassA<string,double,double>("wwasas", "dadafa",34343);

            Console.WriteLine(o2.GetSum());

            Console.ReadKey();
        }
    }
}
