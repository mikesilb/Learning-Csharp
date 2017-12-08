using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Firstname = "Mike";
            person.Lastname = "Silb";

            ChangeFirstname(person);

            Console.WriteLine(person.Firstname);
            Console.WriteLine(person.Lastname);
        }

        static void ChangeFirstname(Person person)
        {
            person.Firstname = "John";
        }
    }
}
