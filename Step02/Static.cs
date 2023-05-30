using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step02
{
    class StaticEx
    {
        public static int Num = 10;
        private static double PI = Math.PI;
        public static double GetPI
        {
            get => PI;
        }
    }

    //싱글톤 패턴 적용
    class Number
    {
        private static Number instance = new Number();
        private int count = 0;

        private Number(){
            count++;
        }
        public static Number getInstance(){
            if(instance == null)
                instance = new Number();
            return instance; 
        }
        public int GetCount { get => count; }
    }

    internal class Static
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StaticEx.Num);
            Console.WriteLine(StaticEx.Num++);
            Console.WriteLine(StaticEx.Num++);
            Console.WriteLine(StaticEx.Num);
            //private 멤버로 선언된 static 변수를 접근해서 출력
            //Console.WriteLine(StaticEx.PI);
            Console.WriteLine(StaticEx.GetPI);

            Console.WriteLine(Number.getInstance().GetCount);
            Console.WriteLine(Number.getInstance().GetCount);
            Console.WriteLine(Number.getInstance().GetCount);
            Console.WriteLine(Number.getInstance().GetCount);
        }
    }
}
