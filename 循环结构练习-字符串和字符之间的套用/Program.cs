using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 循环结构练习_字符串和字符之间的套用
{
    class Program
    {
        static void Main(string[] args)
        {

            //int index = 1;

            //do
            //{
            //    Console.WriteLine(index * index);
            //    index++;
            //} while (index < 6);

            //Console.ReadKey();

            while (true)
            {
                string str = Console.ReadLine();

                bool isAllUpperChar = true;

                for (int i = 0; i < 5; i++)
                {
                    if (str[i] >= 'A' && str[i] <= 'Z')
                    {

                    }
                    else
                    {
                        isAllUpperChar = false;

                        break;
                    }
                }

                if (isAllUpperChar == false)
                {
                    Console.WriteLine("您输入的5个字母，并不全是大写字母，请重新输入");
                }
                else
                {
                    break;
                }

            }

            Console.ReadKey();


            
        }
    }
}
