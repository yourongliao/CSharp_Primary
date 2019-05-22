using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Player
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "isscuss";

            int hp = 100;

            int level = 34;

            float exp = 3.14f;

            Console.WriteLine("myHP:{0}\n\\\tmyLEVEL:{1}\nmyEXP:{2}\nmyNAME:\"{3}\"", hp, level, exp, name);

            Console.WriteLine("I\'s isscuss");

            Console.WriteLine("I\u0027s isscuss");

            Console.ReadKey();
        }
    }
}
