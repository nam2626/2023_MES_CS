using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step02
{
    class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public override bool Equals(object? obj)
        {
            return obj is Person person &&
                   name == person.name &&
                   age == person.age;
        }

        public static bool operator ==(Person? left, Person? right)
        {
            Console.WriteLine("equals");
            return EqualityComparer<Person>.Default.Equals(left, right);
        }

        public static bool operator !=(Person? left, Person? right)
        {
            return !(left == right);
        }

        public override string? ToString()
        {
            return $"{name} - {age}";
        }
    }
    internal class ListTest
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            list.Add(new Person("홍1", 20));
            list.Add(new Person("홍2", 30));
            list.Add(new Person("홍3", 40));
            list.Add(new Person("홍4", 50));
            list.Add(new Person("홍5", 60));

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
