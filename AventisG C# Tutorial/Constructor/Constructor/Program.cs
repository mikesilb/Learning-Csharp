using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Mike", "Silb");
            Person person2 = new Person("Mike", 25);
            Person person3 = new Person("Mike", "Silb", 23);
            Person defaultPerson = new Person();
                
            Console.WriteLine(person1.GetFullNameWithAge());
            Console.WriteLine(person1.GetFullNameWithAge(27));

            Console.WriteLine(person2.GetFullNameWithAge());
            Console.WriteLine(person3.GetFullNameWithAge());

            Console.WriteLine(defaultPerson.GetFullNameWithAge());
        }
    }

    class Person 
    {
        private string _firstname;
        private string _lastname;
        private int _age = 25;

        public Person()
        {
            _firstname = "John";
            _lastname = "Smith";
        }

        public Person(string firstname, int age)
        {
            _firstname = firstname;
            _lastname = "Smith";
            _age = age;
        }  

        public Person(string firstname, string lastname)
        {
            _firstname = firstname;
            _lastname = lastname;
            _age = 25;
        }  

        public Person(string firstname, string lastname, int age)
        {
            _firstname = firstname;
            _lastname = lastname;
            _age = age;
        }  

        public string GetFullNameWithAge()
        {
            return $"{_firstname} {_lastname} {_age }";
        }

        public string GetFullNameWithAge(int age)
        {
            return $"{_firstname} {_lastname} {age}";
        }

    }
}
