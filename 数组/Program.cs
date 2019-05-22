using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数组
{
    class Program
    {
        static void Main(string[] args)
        {
            //第一种方式
            //int[] scores = { 23, 43, 432, 42, 34, 234, 234, 2, 34 };

            //第二种方式
            //int[] scores = new int[10];

            //第三种方式
            //int[] scores;
            //scores = new int[10];

            //int[] scores = { 23, 43, 432, 42, 34, 234, 234, 2, 34 };

            //Console.WriteLine(scores[1]);

            //Console.ReadKey();

            //char[] charArray = new char[2] { 'a', 'b' };

            //Console.WriteLine(charArray[1]);

            //Console.ReadKey();

            string[] names = new string[] { "isscuss", "love", "Elaine" };

            Console.WriteLine(names[2]);

            Console.ReadKey();
        }
    }
}
