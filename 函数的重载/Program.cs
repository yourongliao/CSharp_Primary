using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 函数的重载
{

    class Program
    {
        static int MaxValue(params int[] array)
        {

            Console.WriteLine("这是int类型的，被调用");
            int maxValue = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }
            }

            return maxValue;
        }


        static double MaxValue(params double[] array)
        {
            Console.WriteLine("这是double类型的，被调用");
            double maxValue = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }
            }

            return maxValue;
        }


        static void Main(string[] args)
        {

            int res = MaxValue(12, 35, 14, 1);

            double res1 = MaxValue(23.4, 26.2, 3646);

            Console.WriteLine(res + "|" + res1);

            Console.ReadKey();
        }
    }
}
