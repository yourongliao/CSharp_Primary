using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象编程_类
{
    class Customer
    {
        public string name;

        public string address;

        public int age;

        public string buyTime;

        public void Show()
        {
            Console.WriteLine("名字：" + name);
            Console.WriteLine("年龄：" + age);
            Console.WriteLine("地址:" + address);
            Console.WriteLine("购买时间:" + buyTime);

        }
    }
}
