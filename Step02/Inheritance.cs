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
            Console.WriteLine("Animal 생성자");
        }

        ~Animal()
        {
            //소멸자 호출은 자식부터 먼저 소멸되고 부모가 소멸
            Console.WriteLine("Animal 소멸자 호출");
        }

        public int Age { get => age; set => age = value; }

        public virtual void printInfo()
        {
            Console.WriteLine($"이 동물의 나이 : {Age}");
        }
    }

    class Person : Animal
    {
        public Person(int age) : base(age)
        {
            Console.WriteLine("Person 생성자");
        }
        ~Person()
        {
            Console.WriteLine("Person 소멸자");
        }
        public override void printInfo()
        {
            base.printInfo();//부모가 가지고 있는 printInfo 실행
            Console.WriteLine($"이 사람의 나이{age}");
        }


    }
    internal class Inheritance
    {
        static void test()
        {
            Person p = new Person(1);
        }
        static void Main(string[] args)
        {
            Person p = new Person(100);
            p.printInfo();
            Animal a = p;
            a.printInfo();

            Animal b = new Animal(100);
            b.printInfo();
            test();
            GC.Collect();
            Console.ReadLine();
        }
    }
}
