using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 函数的递归调用
{
    class Program
    {
        static int F(int n)
        {
            if (n == 0) return 2;
            if (n == 1) return 3;

            return F(n - 1) + F(n - 2);
        }

        static void Main(string[] args)
        {

            int res = F(40);

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
