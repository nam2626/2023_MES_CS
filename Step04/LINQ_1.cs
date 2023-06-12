using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step04
{
    internal class LINQ_1
    {
        /* select 추출할 데이터
         * where 조건절
         * from 데이터 집합
         */
        static void Main(string[] args)
        {
            int[] numbers = { 9, 2, 6, 4, 5, 3, 7, 8, 1, 10 };

            var result = from n in numbers
                         where n % 2 == 0
                         select n;

            foreach(int n in result)
            {
                Console.WriteLine(n);
            }
        }
    }
}











