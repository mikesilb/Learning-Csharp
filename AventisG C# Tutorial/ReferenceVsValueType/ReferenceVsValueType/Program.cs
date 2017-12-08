using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceVsValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.Firstname = "John";
            person1.Lastname = "Smith";

            Person person2 = person1;
            Person person3 = person2;
            Person person4 = person3;
            Person person5 = person4;

            person5.Firstname = "Jane";
            person5.Lastname = "Jones";

            Console.WriteLine(person5.Firstname);
            Console.WriteLine(person5.Lastname);
            Console.WriteLine(person1.Firstname);
            Console.WriteLine(person1.Lastname);

            ChangeFirstName(person1);

            Console.WriteLine(person1.Firstname);
            Console.WriteLine(person1.Lastname);



        }

        static void ChangeFirstName(Person person)
        {
            person.Firstname = "Mike";
        }
    }
}
