using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 三元运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            //int test = 100;

            //string resStr = (test < 10)
            //    ? "小于"
            //    : "大于";

            //Console.WriteLine(resStr);

            //Console.ReadKey();

            string str = Console.ReadLine();

            int score = Convert.ToInt32(str);

            string res = score > 50 ? "大于" : "小于";

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
