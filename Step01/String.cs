using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step01
{
    internal class String
    {
        static void Main(string[] args)
        {
            string str1 = "Hello World";
            Console.WriteLine(str1);

            string str2 = Console.ReadLine();
            Console.WriteLine(str2);

            //숫자 하나 입력을 받아서 * 2를 한 결과를 출력
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(n*2);
        }
    }
}
