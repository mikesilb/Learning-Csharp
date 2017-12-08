using System;
namespace MethodHiding
{
    class SomeBaseClass
    {
        public void Method1()
        {
            Console.WriteLine("This is a method in SomeBaseClass!");
        }

        public virtual void Method2()
        {
            Console.WriteLine("This is the virtual method in SomeBaseClass!");
        }
    }
}
