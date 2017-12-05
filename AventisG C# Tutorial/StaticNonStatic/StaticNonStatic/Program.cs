using System;

namespace StaticNonStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Mike", "Silb");
            Console.WriteLine(person.FormatFullName());
            Console.WriteLine(Person.FormatFullNameStatic("Michael", "Silberstein"));
        }
    }

    class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public Person (string Firstname, string Lastname) 
        {
            this.Firstname = Firstname;
            this.Lastname = Lastname;
        }

        public static string FormatFullNameStatic(string Firstname, string Lastname)
        {
            return $"{Firstname} - {Lastname}";
        }

        public string FormatFullName()
        {
            return $"{Firstname} - {Lastname}";
        }

    }
}
