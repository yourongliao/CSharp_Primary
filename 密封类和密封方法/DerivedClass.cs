using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 密封类和密封方法
{
    class DerivedClass:BaseClass
    {
        public sealed override void Move()
        {
            base.Move();
        }
    }
}
