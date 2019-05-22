using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_类的定义和声明
{
    class Program
    {
        static void Main(string[] args)
        {

            //Vehicle car1 = new Vehicle();

            //car1.speed = 100;

            //car1.Run();

            //car1.Stop();

            //Console.WriteLine(car1.speed);

            //Console.ReadKey();

            //Vector v1 = new Vector();

            ////v1.x = 1;
            ////v1.y = 1;
            ////v1.z = 1;

            //v1.SetX(1);
            //v1.SetY(1);
            //v1.SetZ(1);

            //Console.WriteLine(v1.Length());

            //Console.ReadKey();

            //Vector v1 = new Vector(1, 1, 1);

            //Console.WriteLine(v1.Length());

            //v1.MyIntProperty = 600;

            //Console.WriteLine(v1.MyIntProperty);

            //Console.ReadKey();

            Vector v1 = new Vector();

            v1.X = 123;

            Console.WriteLine(v1.X);

            v1.Name = "lalla";

            Console.WriteLine(v1.Name);

            Console.ReadKey();
            
        }
    }
}
