using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数组的遍历
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] scores = { 23, 5, 75, 624, 99, 84, 64 };

            //for (int i = 0; i < scores.Length; i++)
            //{
            //    Console.WriteLine(scores[i]);
            //}

            //int i = 0;

            //while (i < scores.Length)
            //{
            //    Console.WriteLine(scores[i]);
            //    i++;
            //}

            //Console.ReadKey();

            foreach (int temp in scores)
            {
                Console.WriteLine(temp);
            }

            Console.ReadKey();
        }
    }
}
