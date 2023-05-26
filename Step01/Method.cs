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

        static void Main(string[] args)
        {
            Console.WriteLine(sum(1, 2));
            Console.WriteLine(mul());
            Console.WriteLine(mul(30));
            Console.WriteLine(mul(30,40));

            int n1 = 10;
            int n2 = 20;

            Swap(n1, n2);
            Console.WriteLine(n1 + " " + n2);

        }
    }
}
