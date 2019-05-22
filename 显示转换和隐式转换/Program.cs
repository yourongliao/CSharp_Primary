using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 显示转换和隐式转换
{
    class Program
    {
        static void Main(string[] args)
        {

            //byte myByte = 123;

            //int myInt = myByte;

            //myByte = (byte)myInt;

            //float myfloat = myInt;

            //myInt = (int)myfloat;

            //char c = 'a';

            //myfloat = c;

            int num = 45656;

            string str = Convert.ToString(num);

            string str2 = num + "" + str;

            Console.WriteLine(str2);

            Console.ReadKey();

        }
    }
}
