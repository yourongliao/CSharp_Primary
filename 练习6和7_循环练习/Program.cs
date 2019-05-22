using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习6和7_循环练习
{
    class Program
    {
        static void Main(string[] args)
        {

            //int n = Convert.ToInt32(Console.ReadLine());

            //int count = 1;

            //for (int i = n - 1; i >= 1; i--)
            //{
            //    count = (count +1) * 2;
            //}

            //Console.WriteLine(count);

            //Console.ReadKey();

            string str = Console.ReadLine();

            string[] strArray = str.Split(' ');

            int[] numArray = new int[strArray.Length];

            for (int i = 0; i < strArray.Length; i++)
            {
                numArray[i] = Convert.ToInt32(strArray[i]);
            }

            //int min = numArray[0];

            //int minIndex = 0;

            for (int i = 1; i < numArray.Length; i++)
            {
                if (numArray[i] < numArray[0])
                {
                    int temp = numArray[0];
                    numArray[0] = numArray[i];
                    numArray[i] = temp;
                }
            }

            for (int i = 0; i < numArray.Length; i++)
            {
                Console.Write(numArray[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
