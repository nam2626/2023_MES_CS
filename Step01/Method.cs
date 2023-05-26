using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step01
{
    internal class Method
    {
        public static int sum(int n1, int n2)
        {
            return n1 + n2;
        }

        public static int mul(int n1=10, int n2=20)
        {
            return n1 * n2;
        }

        static void Swap(int n1, int n2)
        {
            int temp = n1;
            n1 = n2;
            n2 = temp;
        }
        
        static void RefSwap(ref int n1, ref int n2)
        {
            int temp = n1;
            n1 = n2;
            n2 = temp;
        }

        static void CircleArea(int r, out double area)
        {
            area = r * r * 3.1415;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(sum(1, 2));
            Console.WriteLine(mul());
            Console.WriteLine(mul(30));
            Console.WriteLine(mul(30,40));

            int n1 = 10;
            int n2 = 20;

            //Call By Value 방식이라 값이 서로 바뀌지 않음 
            Swap(n1, n2);
            Console.WriteLine(n1 + " " + n2);

            RefSwap(ref n1, ref n2);
            Console.WriteLine(n1 + " " + n2);

            double area = 0.0;
            CircleArea(3, out area);
            Console.WriteLine(area);
        }
    }
}
