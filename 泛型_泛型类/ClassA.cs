using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型_泛型类
{
    class ClassA<T,C,A>
    {
        private T a;
        private C b;

        private A c;

        public ClassA(T a, C b, int v)
        {
            this.a = a;
            this.b = b;
        }

        public string GetSum()
        {
            return a + "" + b;
        }
    }
}
