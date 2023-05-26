using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step01
{
    internal class Variable
    {
        static void Main(string[] args)
        {
            bool flag = true;
            Console.WriteLine(flag);

            int n1 = 1000;
            //unsigned int 
            uint n2 = 2000;
            Console.WriteLine($"n1 = {n1}, n2 = {n2}");

            uint n3 = uint.MaxValue;
            int n4 = int.MaxValue;
            Console.WriteLine($"n3 = {n3}, n4 = {n4}");

            string str = "Hello World";
            Console.WriteLine(str);

            //모든 데이터 타입을 지정할 수 있는 변수 타입
            var a = 10;
            var b = "HelloWorld";
            var c = 3.1415;
            var d = true;
            var e = 'C';

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
        }
    }
}
