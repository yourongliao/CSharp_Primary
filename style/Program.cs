using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace style
{
    class Program
    {
        static void Main(string[] args)
        {
            byte myByte = 34;

            int score = 6000;

            long count = 10000000000300;

            Console.WriteLine("byte:{0},score:{1},count:{2}", myByte, score, count);

            float myFloat = 12.5f;

            double myDouble = 12.6;

            Console.WriteLine("float:{1},double:{0}", myDouble, myFloat);

            char myChar = 'a';

            string myString = "mine";

            string myString2 = "yours";

            bool myBool = false;

            Console.WriteLine("test begin:myChar:{0},String1:{1},String2:{2},myBool:{3}", myChar, myString, myString2, myBool);

            Console.ReadKey();
        }
    }
}
