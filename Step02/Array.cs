using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step02
{
    internal class Array
    {
        static void Main(string[] args)
        {
            //정수형 배열 길이가 5인 배열 생성
            //int[] arr1 = new int[5];
            int[] arr2 = { 1, 2, 3, 4, 5 };

            //전체 데이터 꺼내기 - for
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }

            //for each
            foreach (int i in arr2) { 
                Console.WriteLine(i);
            }
        }

    }
}
