using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step01
{
    internal class ConstEnum
    {
        //열거형 : 사용할려는 상수들을 나열
        //첫번째 상수는 별다른 값을 지정하지 않으면 0
        //두번째 상수부터는 이전 상수의 + 1, 또는 값을 직접 지정이 가능
        enum Result { YES, NO=100, CANCEL, OK }
        static void Main(string[] args)
        {
            const int MAX_NUM = 10;
            const int MIN_NUM = 10;
            //MAX_NUM = 100; // 상수는 데이터 변경 X
            Console.WriteLine(MAX_NUM);
            Console.WriteLine(MIN_NUM);
        
            Console.WriteLine((int)Result.YES);
            Console.WriteLine((int)Result.NO);
            Console.WriteLine((int)Result.CANCEL);
            Console.WriteLine((int)Result.OK);
        }

    }
}
