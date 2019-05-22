using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 梯形面积
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("上底");
            //string str1 = Console.ReadLine();
            //double num1 = Convert.ToDouble(str1);

            //Console.WriteLine("下底");
            //string str2 = Console.ReadLine();
            //double num2 = Convert.ToDouble(str2);

            //Console.WriteLine("高");
            //string str3 = Console.ReadLine();
            //double num3 = Convert.ToDouble(str3);

            //Console.WriteLine("面积");
            //double res = ((num1 + num2) * num3) / 2;

            //Console.WriteLine(res);

            //Console.ReadKey();

            Console.WriteLine("半径");
            string str1 = Console.ReadLine();

            double num = Convert.ToDouble(str1);

            Console.WriteLine("圆的周长是:" + (2 * num * 3.14));

            Console.WriteLine("圆的面积是：" + (num * num * 3.14));

            Console.ReadKey();
        }
    }
}
