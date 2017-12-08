using System;
namespace MethodHiding
{
    class SomeDerivedClass : SomeBaseClass
    {
        public new void Method1()
        {
            Console.WriteLine("This is a method in SomeDerivedClass!");
        }

        public override void Method2()
        {
            Console.WriteLine("This is the virtual method overridden in SomeDerivedClass!");
        }
    }
}
