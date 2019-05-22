using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 错误处理_异常处理
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] myArray = { 1, 2, 3, 4 };

                //int myEle = myArray[4];

                int myEle = myArray[3];
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("发生了异常");

                Console.WriteLine("下标越界了");


            }
            finally
            {
                Console.WriteLine("这里是finally里面，执行的代码");
            }

            Console.WriteLine("test");

            Console.ReadKey();
        }
    }
}
