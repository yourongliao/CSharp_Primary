using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习3和4_练习for循环和字符串操作
{
    class Program
    {
        static void Main(string[] args)
        {

            //Random random = new Random();

            //int number = random.Next(0, 51);

            //Console.WriteLine("请猜一下，我给出的数字，是多少？");

            //while (true)
            //{
            //    int num = Convert.ToInt32(Console.ReadLine());

            //    if (num > number)
            //    {
            //        Console.WriteLine("偏大了");
            //    }
            //    else if (num < number)
            //    {
            //        Console.WriteLine("偏小了");
            //    }
            //    else
            //    {
            //        Console.WriteLine("猜对了");

            //        break;
            //    }
            //}

            //Console.ReadKey();

            string str = Console.ReadLine();

            string tempStr = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'a' && str[i] <= 'z')
                {
                    int num = str[i];

                    num += 3;

                    char temp = (char)num;

                    if (temp > 'z')
                    {
                        temp = (char)(temp - 'z' - 1 + 'a');
                    }

                    tempStr += temp;
                }
                else if (str[i] >= 'A' && str[i] <= 'z')
                {
                    int num = str[i];

                    num += 3;

                    char temp = (char)num;

                    if (temp > 'Z')
                    {
                        temp = (char)(temp - 'Z' - 1 + 'A');
                    }

                    tempStr += temp;

                    
                }
                else
                {
                    tempStr += str[i];
                }
            }

            Console.WriteLine(tempStr);
            Console.ReadKey();
        }
    }
}
