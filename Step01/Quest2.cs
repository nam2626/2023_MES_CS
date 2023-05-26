using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step01
{
    internal class Quest2
    {
        /*
            숫자하나 입력 받아서
            성적 등급 출력
         */
        static void Main(string[] args)
        {
            Console.Write("점수 입력 >>> ");
            int score = int.Parse(Console.ReadLine());

            if (score >= 90)
                Console.WriteLine("A");
            else if (score >= 80)
                Console.WriteLine("B");
            else if (score >= 70)
                Console.WriteLine("C");
            else if (score >= 60)
                Console.WriteLine("D");
            else
                Console.WriteLine("F");
        }
    }
}
