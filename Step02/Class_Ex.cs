namespace Step02
{
    class Animal
    {
        private string name;
        private int age;

        //생성자
        public Animal()
        {
            Console.WriteLine("기본 생성자");
        }

        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        //프로퍼티(Property)
        public int Age
        {
            get => age;
            set => age = value;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }

        public override bool Equals(object? obj)
        {
            return obj is Animal animal &&
                   name == animal.name &&
                   age == animal.age;
        }

        //정보 출력하는 메서드
        public void printAnimalInfo()
        {
            Console.WriteLine($"이 동물의 이름 : {Name}, 나이 : {Age}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal();
            a.Age = 20;
            a.Name = "개";
            a.printAnimalInfo();

        }

    }
}