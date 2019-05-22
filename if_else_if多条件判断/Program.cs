using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else_if多条件判断
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            int score = Convert.ToInt32(str);

            //string res = num > 90 ? "大于90" : num > 80 ? "大于80" : num > 70 ? "大于70" : "很小";

            //Console.WriteLine(res);

            if (score >= 90)
            {
                Console.WriteLine("优秀");
            }
            else if (score >= 80 && score <= 89)
            {
                Console.WriteLine("良");
            }
            else if (score >= 60 && score <= 79)
            {
                Console.WriteLine("中");
            }
            else
            {
                Console.WriteLine("不及格，请继续努力哦");
            }

            Console.ReadKey();
        }
    }
}
