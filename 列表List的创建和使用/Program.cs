using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 列表List的创建和使用
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> scoreList = new List<int>();

            //var scoreList = new List<int>();

            //var scoreList = new List<int>() { 1, 2, 3 };

            //var scoreList = new List<int>();

            //scoreList.Add(12);

            //scoreList.Add(52);

            //Console.WriteLine(scoreList[0]);

            //Console.ReadKey();

            //var scoreList = new List<int>();

            //Console.WriteLine("capacity:" + scoreList.Capacity + " count:" + scoreList.Count);

            //scoreList.Add(12);

            //Console.WriteLine("capacity:" + scoreList.Capacity + " count:" + scoreList.Count);

            //scoreList.Add(45);

            //Console.WriteLine("capacity:" + scoreList.Capacity + " count:" + scoreList.Count);

            //Console.WriteLine(scoreList[0]);

            //Console.ReadKey();

            List<int> scoreList = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("capacity：" + scoreList.Capacity + " Count:" + scoreList.Count);

                scoreList.Add(10);
            }

            Console.ReadKey();
        }
    }
}
