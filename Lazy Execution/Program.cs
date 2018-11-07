using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lazy_Execution
{
    class Program
    {
        //http://blog.naver.com/dotnethelper/60104797637
        // Linq Execution 방식

        /// <summary>
        /// 연산되는 factor 변수의 값은 10일까? 20일까? LINQ쿼리의 실제적인 실행은 선안하는 시점이 아니라 루프문(foreach, while, for 등)이 실행되는 시점에 비로서 처리가 일어 나게 된다
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<int> number = new List<int> {1, 2, 3, 4, 5};

            int factor = 10;

            var result = from x in number
                select x * factor;

            factor = 20;

            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadKey();
        }
    }
}
