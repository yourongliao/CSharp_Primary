using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 列表的遍历
{
    class Program
    {
        static void Main(string[] args)
        {
            var scoreList = new List<int>();

            scoreList.Add(36);
            scoreList.Add(66);
            scoreList.Add(12);
            scoreList.Add(3);
            scoreList.Add(143);
            scoreList.Add(43);
            scoreList.Add(4311);
            scoreList.Add(1243);
            scoreList.Add(576);

            //for (int i = 0; i < scoreList.Count; i++)
            //{
            //    Console.Write(scoreList[i] + " ");
            //}

            //Console.ReadKey();

            foreach (var temp in scoreList)
            {
                Console.Write(temp + " ");
            }

            Console.ReadKey();

        }
    }
}
