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

        }
    }
}
