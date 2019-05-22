using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 结构函数的定义和使用
{
    struct Name
    {
        public string firstName;
        public string lastName;

        public string GetName()
        {
            return firstName + " " + lastName;
        }
    }

    struct Vector3
    {
        public float x;

        public float y;

        public float z;

        public double Distance()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Name name;

            //name.firstName = "isscuss";

            //name.lastName = "love Elaine";

            ////Console.WriteLine("say it " + name.firstName + " always " + name.lastName);

            //Console.WriteLine(name.GetName());

            //Console.ReadKey();

            Vector3 myVector3;

            myVector3.x = 3;

            myVector3.y = 1;

            myVector3.z = 5;

            Console.WriteLine(myVector3.Distance());

            Console.ReadKey();
        }
    }
}
