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

        //연산자 오버로딩 --> 기존 연산자에 기능을 추가하는 것
        public static bool operator ==(Animal? left, Animal? right)
        {
            return EqualityComparer<Animal>.Default.Equals(left, right);
        }

        public static bool operator !=(Animal? left, Animal? right)
        {
            return !(left == right);
        }
    }

    //학생 클래스
    //학번 이름 학과명 평점
    //생성자, 프로퍼티, Equals, 정보출력 메서드
    class Student
    {
        private string studentNo;
        private string name;
        private string major;
        private double score;

        public Student(string studentNo, string name, string major, double score)
        {
            this.studentNo = studentNo;
            this.name = name;
            this.major = major;
            this.score = score;
        }

        public string StudentNo
        {
            get => studentNo;   set => studentNo = value;
        }
        public string Name
        {
            get => name; set => name = value;
        }
        public string Major
        {
            get => major; set => major = value;
        }
        public double Score
        {
            get => score; set => score = value;
        }

        public override bool Equals(object? obj)
        {
            return obj is Student student &&
                   studentNo == student.studentNo &&
                   name == student.name &&
                   major == student.major &&
                   score == student.score;
        }

        public static bool operator ==(Student? left, Student? right)
        {
            return EqualityComparer<Student>.Default.Equals(left, right);
        }

        public static bool operator !=(Student? left, Student? right)
        {
            return !(left == right);
        }

        public void printInfo()
        {
            Console.WriteLine($"{StudentNo}\t{Name}\t{Major}\t{Score}");
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

            Animal c = a;
            Animal d = new Animal("개", 20);

            Console.WriteLine(a == d);
            Console.WriteLine(a == c);
            Console.WriteLine(a.Equals(d));
        }

    }
}