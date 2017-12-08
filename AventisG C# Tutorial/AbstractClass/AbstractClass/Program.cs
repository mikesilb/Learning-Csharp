using System;

namespace AbstractClass
{
    abstract class Person
    {
        private readonly string _firstname;
        private readonly string _lastname;

        protected Person(string firstname, string lastname)
        {
            _firstname = firstname;
            _lastname = lastname;
        }

        public virtual void Greet()
        {
           Console.WriteLine("Hello from the Person Base Class"); 
        }

        public string GetFullName()
        {
            return $"{_firstname} {_lastname}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person mike = new Mike("Michael", "Silberstein");
            Console.WriteLine(mike.GetFullName());
            mike.Greet();

        }   
    }
   
}
