using System;
namespace AbstractClass
{
    class Mike : Person
    {
        public Mike(string firstname, string lastname)
            : base(firstname, lastname)
        {
            
        }

        public override void Greet()
        {
            Console.WriteLine("Hi there from Mike Class");
        }
    }


}
