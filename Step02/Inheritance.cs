using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step02
{
    class Animal
    {
        protected int age;

        public Animal(int age)
        {
            this.age = age;
        }

        public int Age { get => age; set => age = value; }

        public void printInfo()
        {
            Console.WriteLine($"이 동물의 나이 : {Age}");
        }
    }
    internal class Inheritance
    {
        static void Main(string[] args)
        {

        }
    }
}
