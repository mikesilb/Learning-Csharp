using System;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.GetFullName("Mike", "Silberstein");
        }
    }

    class Person
    {
        public void GetFullName(string FirstName, string LastName)
        {
            Console.WriteLine($"The fullname of the person is {FirstName} {LastName}.");
        }
    }
}
