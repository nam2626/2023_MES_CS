﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step01
{
    internal class Quest1
    {
        /*
         * 직사각형의 가로길이, 세로길이 입력을 받아서
         * 입력한 직사각형의 넓이를 계산해서 출력
         */
        static void Main(string[] args)
        {
            Console.Write("가로 길이 입력 : ");
            int width = int.Parse(Console.ReadLine());
            Console.Write("세로 길이 입력 : ");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine(width * height);
        }
    }
}
