using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step01
{
    internal class ConstEnum
    {
        enum Result { YES, NO, CANCEL, OK }
        static void Main(string[] args)
        {
            const int MAX_NUM = 10;
            const int MIN_NUM = 10;
            //MAX_NUM = 100; // 상수는 데이터 변경 X
            Console.WriteLine(MAX_NUM);
            Console.WriteLine(MIN_NUM);
        
            Console.WriteLine(Result.YES);
            Console.WriteLine(Result.NO);
            Console.WriteLine(Result.CANCEL);
            Console.WriteLine(Result.OK);
        }

    }
}
