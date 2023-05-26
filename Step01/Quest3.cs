using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step01
{
    internal class Quest3
    {
        /*
         * 숫자 하나 입력 받아서
         * 입력 받은 숫자가 완전수 인지 아닌지 출력
         */
        static void Main(string[] args)
        {
            Console.Write("숫자 입력 >>> ");
            int n = int.Parse(Console.ReadLine());

            int r = 0;

            for(int i = 1; i < n; i++)
            {
                if (n % i == 0) r += i;
            }

            if (n == r) Console.WriteLine("완전수 입니다.");
            else Console.WriteLine("완전수가 아닙니다.");
        }
    }
}
