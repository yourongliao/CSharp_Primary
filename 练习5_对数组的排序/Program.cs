using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习5_对数组的排序
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            string[] strArray = str.Split(' ');

            int[] numArray = new int[strArray.Length];

            for (int i = 0; i < strArray.Length; i++)
            {
                int temp = Convert.ToInt32(strArray[i]);
                numArray[i] = temp;
            }

            //Array.Sort(numArray);

            for (int j = 1; j < str.Length - 1; j++)
            {

                for (int i = 0; i < numArray.Length - 1-(j-1); i++)
                {
                    if (numArray[i + 1] < numArray[i])
                    {
                        int temp = numArray[i];
                        numArray[i] = numArray[i + 1];
                        numArray[i + 1] = temp;
                    }

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
