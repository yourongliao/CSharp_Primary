using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 匿名类型
{
    class Vector
    {
        public Vector()
        {
            Console.WriteLine("这是构造函数被调用了");
        }

        public Vector(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }



        private float x, y, z;

        public float X
        {
            get { return x; }
            set { x = value; }
        }

        public string Name { get; set; }

        public void SetX(float x)
        {
            this.x = x;
        }

        public void SetY(float y)
        {
            this.y = y;
        }
        public void SetZ(float z)
        {
            this.z = z;
        }


        public float Length()
        {
            return (float)Math.Sqrt(x * x + y * y + z * z);
        }

        //定义属性
        public int MyIntProperty
        {
            set
            {
                Console.WriteLine("属性中set块被调用");
                Console.WriteLine("在set块中，被调用的值是： " + value);
            }

            get
            {
                Console.WriteLine("属性中的get块被调用了");

                return 100;
            }
        }
    }
}
