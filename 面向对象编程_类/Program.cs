using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象编程_类
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1;

            customer1 = new Customer();

            customer1.name = "isscuss";

            customer1.Show();

            Console.ReadKey();
        }
    }
}
