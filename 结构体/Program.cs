using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 结构体
{

    struct Position
    {
        public float x;
        public float y;
        public float z;
    }

    enum Direction
    {
        West,
        North,
        East,
        South
    }

    struct Path
    {
        public float distance;
        public Direction dir;
    }
    class Program
    {
        static void Main(string[] args)
        {

            Position enemy1;

            enemy1.x = 34f;

            Path path1;

            path1.dir = Direction.East;

            path1.distance = 10000;

            
        }
    }
}
