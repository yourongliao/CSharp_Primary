using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _
{
    class Program
    {
        static void Main(string[] args)
        {

            string str1 = "I'm a good man,\n You are my Love!";

            string str2= @"I'm a good man,\n ""You are my Love!";

            string str3 = @"I'm a good man,
You are my Love!";

            Console.WriteLine(str1);

            Console.WriteLine(str2);

            Console.WriteLine(str3);

            Console.ReadKey();
        }
    }
}
