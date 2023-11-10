namespace Constructor
{
    internal class Program
    {
        class Person
        {
            private string name;
            private int age;

            public Person()
            {
                name = "Unknown";
            }
            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
                Console.WriteLine("Person 객체 생성");
            }

            public void PrintInfo()
            {
                Console.WriteLine($"Name : {name}, Age : {age}");
            }
        }

        static void Main(string[] args)
        {
            Person person1 = new Person("Hong", 28);
            person1.PrintInfo();
        }
    }
}