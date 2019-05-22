using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 派生类的构造函数
{
    class DerivedClass:BaseClass
    {
        private int y;

        public DerivedClass() : base()
        {
            Console.WriteLine("这是DerivedClass 无参的构造函数");
        }

        public DerivedClass(int x, int y) : base(x)
        {
            this.y = y;

            base.z = 100;

            Console.WriteLine("y赋值完成,是 "+this.y);
        }
    }
}
