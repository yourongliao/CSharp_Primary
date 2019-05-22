using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 函数的定义和使用_案例练习
{
    class Program
    {
        static int[] GetDivisor(int number)
        {
            int count = 0;

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }

            int[] array = new int[count];

            int index = 0;

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    array[index] = i;
                    index++;
                }
            }

            return array;
        }

        static int Max(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            return max;
        }

        static void Main(string[] args)
        {
            //int num = Convert.ToInt32(Console.ReadLine());

            //int[] array = GetDivisor(num);

            //for(int i=0;i<array.Length;i++)
            //{
            //    Console.Write(array[i] + " ");
            //}

            //Console.ReadKey();

            int[] array = { 12, 45, 84, 146, 1450, 78, 6, 488, 6 };

            int max = Max(array);

            Console.WriteLine(max);

            Console.ReadKey();
        }
    }
}
