using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习1和2_循环结构
{
    class Program
    {
        static void Main(string[] args)
        {
            //for(int i=100;i<1000;i++)
            //{
            //    int ge = i % 10;
            //    int shi = (i / 10) % 10;
            //    int bai = i / 100;

            //    int res = ge * ge * ge + shi * shi * shi + bai * bai * bai;

            //    if (res == i)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.ReadKey();

            int sum = 364;

            int numEmpty = 364;

            while (numEmpty > 3)
            {
                int newSum = numEmpty / 3;

                sum += newSum;

                int count = newSum;

                int newSumEmpty = numEmpty % 3;

                numEmpty = count + newSumEmpty;
            }

            Console.WriteLine("一共能喝" + sum + "瓶，剩下" + numEmpty + "个空瓶子");

            Console.ReadKey();

        }
    }
}
