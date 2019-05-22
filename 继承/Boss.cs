using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承
{
    class Boss:Enemy
    {
        public new void Move()
        {
            
            //base.Move();

            Console.WriteLine("这是boss的移动方法");
        }

        public void Attack()
        {
            Console.WriteLine("boss正在进行攻击");

            //AI();

            Move();

            HP = 100;
        }
    }
}
