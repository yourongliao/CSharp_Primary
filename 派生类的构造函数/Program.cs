using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 派生类的构造函数
{
    class Program
    {
        static void Main(string[] args)
        {
            //DerivedClass o1 = new DerivedClass();

            //DerivedClass o1 = new DerivedClass(1, 2);

            ClassXyz.z = 100;

            Console.WriteLine(ClassXyz.z);

            ClassXyz.TestMethod();

            Console.ReadKey();
        }
    }
}
