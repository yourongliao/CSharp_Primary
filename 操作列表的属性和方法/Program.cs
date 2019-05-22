using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 操作列表的属性和方法
{
    class Program
    {
        static void Main(string[] args)
        {
            var scoreList = new List<int>();

            scoreList.Add(100);

            scoreList.Add(200);

            scoreList.Add(300);

            scoreList.Add(100);

            foreach (var temp in scoreList)
            {
                Console.Write(temp + " ");
            }

            //scoreList.Insert(3, -1);

            //Console.WriteLine();

            //scoreList.RemoveAt(0);



            //foreach (var temp in scoreList)
            //{
            //    Console.Write(temp + " ");
            //}

            int index1 = scoreList.IndexOf(200);
            int index2 = scoreList.IndexOf(400);
            int index3 = scoreList.IndexOf(100);
            int index4 = scoreList.LastIndexOf(100);


            Console.WriteLine(index1 + ":" + index2 + ":" + index3 + ":" + index4);

            scoreList.Sort();

            foreach (var temp in scoreList)
            {
                Console.Write(temp + " ");
            }


            Console.ReadKey();
        }
    }
}
