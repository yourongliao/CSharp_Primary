using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 参数数组
{
    class Program
    {
        static int Sum(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }

        static int Plus(params int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }
        static void Main(string[] args)
        {

            int[] array = new int[] { 23, 45, 78, 366, 42 };

            int sum = Sum(array);

            Console.WriteLine(sum);

            int sum2 = Plus(23, 45, 78, 366, 42);

            Console.WriteLine(sum2);

            Console.ReadKey();
        }
    }
}
