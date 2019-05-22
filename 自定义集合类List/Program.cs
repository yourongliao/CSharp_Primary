using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 自定义集合类List
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> mylist = new MyList<int>();

            mylist.Add(235);

            mylist.Add(12);

            mylist.Add(238);

            mylist.Add(67);

            mylist.Add(12);

            mylist.Add(7886);

            

            mylist[0] = 56;

            mylist.Insert(3, 2);

            mylist.Remove(4);


            for (int i = 0; i < mylist.Count; i++)
            {
                //Console.WriteLine(mylist.GetItem(i));

                Console.WriteLine(mylist[i]);
            }

            Console.WriteLine(mylist.IndexOf(12));

            Console.WriteLine(mylist.LastIndexOf(12));

            mylist.Sort();

            Console.WriteLine();

            for (int i = 0; i < mylist.Count; i++)
            {
                Console.WriteLine(mylist[i]);
            }

            Console.ReadKey();
        }
    }
}
