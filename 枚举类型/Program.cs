using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 枚举类型 {
    enum GameState:byte
    {
        Pause=12,
        Fail=25,
        Success=45,
        Start=78
    }
    class Program
    {
        static void Main(string[] args)
        {
            GameState state = GameState.Start;

            //if (state == GameState.Start)
            //{
            //    Console.WriteLine("游戏正在运行中");
            //}

            //Console.WriteLine(state);

            int num = (int)state;

            Console.WriteLine(num);

            Console.ReadKey();
        }
    }
}
