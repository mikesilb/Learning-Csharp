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

        public abstract void Greet();

        public string GetFullName()
        {
            return $"{_firstname} {_lastname}";
        }
    }
}
