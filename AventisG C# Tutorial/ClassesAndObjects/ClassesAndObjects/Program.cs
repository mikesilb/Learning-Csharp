using System;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Person me = new Person();
            me.FirstName = "Mike";
            me.LastName = "Silberstein";

            me.GetFullName();

            me.Walk();
            me.Eat();
            me.Talk();
            me.Sleep();

            SuperPerson superPerson = new SuperPerson();
            superPerson.FirstName = "Super";
            superPerson.LastName = "Dude";

            superPerson.GetFullName();

            superPerson.Walk();
            superPerson.Eat();
            superPerson.Talk();
            superPerson.Sleep();

            superPerson.Fly();

        }
    }


    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public void GetFullName()
        {
            Console.WriteLine("Get my fullname {0} {1}", FirstName, LastName);
        }

        public void Walk()
        {
            Console.WriteLine("I am walking.");
        }

        public void Talk()
        {
            Console.WriteLine("I am talking.");
        }

        public void Eat()
        {
            Console.WriteLine("I am eating.");
        }

        public void Sleep()
        {
            Console.WriteLine("I am sleeping.");
        }
    }



    public class SuperPerson : Person
    {
        public void Fly()
        {
            Console.WriteLine("I am flying.");
        }

    }

}
