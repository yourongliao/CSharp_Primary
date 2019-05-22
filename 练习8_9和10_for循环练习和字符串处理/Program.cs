using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习8_9和10_for循环练习和字符串处理
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numArray = { 2, 4, 4, 6, 67, 785, 3244 };

            //int num = Convert.ToInt32(Console.ReadLine());


            //int[] numNew = new int[numArray.Length + 1];

            //int index = 0;

            //bool isInsert = false;

            //for (int i = 0; i < numNew.Length; i++)
            //{
            //    if (i == numArray.Length && isInsert == false)
            //    {
            //        numNew[i] = num;

            //        isInsert = true;

            //        break;
            //    }

            //    if (num <= numArray[index]&&isInsert==false)
            //    {
            //        numNew[i] = num;

            //        isInsert = true;
            //    }
            //    else
            //    {
            //        numNew[i] = numArray[index];
            //        index++;
            //    }
            //}

            //for (int i = 0; i < numNew.Length; i++)
            //{
            //    Console.Write(numNew[i] + " ");
            //}

            //int num = Convert.ToInt32(Console.ReadLine());

            //int Count100 = num / 100;

            //int remain = Count100 % 100;

            //int Count50 = remain / 50;

            //remain = remain % 50;

            //int Count10 = remain / 10;

            //remain = remain % 10;

            //int Count5 = remain / 5;

            //remain = remain % 5;

            //int Count2 = remain / 2;

            //remain = remain % 2;

            //Console.WriteLine("100元的准备" + Count100);
            //Console.WriteLine("50元的准备" + Count50);
            //Console.WriteLine("10元的准备" + Count10);
            //Console.WriteLine("5元的准备" + Count5);
            //Console.WriteLine("2元的准备" + Count2);
            //Console.WriteLine("1元的准备" + remain);

            //Console.ReadKey();

            string str = Console.ReadLine();

            bool isRight = true;

            if (str[0] >= 'a' && str[0] <= 'z' || str[0] >= 'A' && str[0] <= 'Z' || str[0] == '_' || str[0] == '@')
            {

            }
            else
            {
                isRight = false;
            }

            for (int i = 1; i < str.Length; i++)
            {
                if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z') || str[i] == '_' || (str[i] >= '0' && str[i] <= '9'))
                {

                }
                else
                {
                    isRight = false;

                    break;
                }
            }

            if (isRight == true)
            {
                Console.WriteLine("是合法字符");
            }
            else
            {
                Console.WriteLine("不是合法字符");
            }

            Console.ReadKey();
        }
    }
}
