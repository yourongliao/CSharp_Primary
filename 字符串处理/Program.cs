using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字符串处理
{
    class Program
    {
        static void Main(string[] args)
        {

            string str = "  www.isscuss.COM  ";

            //for (int i = 0; i < str.Length; i++)
            //{
            //    Console.WriteLine(str[i]);
            //}

            //string res = str.ToLower();

            //string res = str.ToUpper();

            //string res = str.Trim();

            //string res = str.TrimStart();

            //string res = str.TrimEnd();

            string[] strArray = str.Split('.');

            Console.WriteLine(str+"|");

            //Console.WriteLine(res+"|");

            foreach (string temp in strArray)
            {
                Console.WriteLine(temp);
            }

            Console.ReadKey();
        }
    }
}
