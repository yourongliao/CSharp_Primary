using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 值类型和引用类型
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test3();

            Test4();

            Console.ReadKey();
        }

        static void Test1()
        {
            int i = 34;

            int j = 35;

            int temp = 546;

            char c = 'a';

            bool b = true;
        }

        static void Test2()
        {
            int i = 34;
            int j = 234;
            string name = "isscuss";
        }

        static void Test3()
        {
            string name = "siki";

            string name2 = "Elaine";

            name = name2;

            name = "sasasa";

            Console.WriteLine(name + ":" + name2);
        }

        static void Test4()
        {
            Vector3 v = new Vector3();

            v.x = 100;

            v.y = 100;

            v.z = 100;

            Vector3 v2 = new Vector3();

            v2.x = 200;

            v2.y = 200;

            v2.z = 200;

            v2 = v;

            v2.x = 300;

            Console.WriteLine(v.x);
        }
    }
}
