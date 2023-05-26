using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step01
{
    class Animal
    {
        private int age;

        //프로퍼티(Property)
        public int Age
        {
            get => age; set => age = value;
        }
        

        public Animal() {
            Console.WriteLine("기본 생성자");
            age = 10;
        }
        public Animal(int age) {
            this.age = age;
        }
        public void printAnimalInfo() {
            Console.WriteLine("이 동물의 나이 : " + age);
        }

    }
    internal class ClassEx
    {
        static void Main(string[] args)
        {
            Animal a = new Animal();
            a.printAnimalInfo();

            Animal b = new Animal(100);

            //프로퍼티(property) 사용법
            b.Age = 200;
            Console.WriteLine($"{b.Age}");
            b.printAnimalInfo();
        }
    }
}
