using System;

namespace MethodHiding
{
    class Program
    {
        static void Main(string[] args)
        {
            SomeBaseClass someBaseClass1 = new SomeBaseClass();
            someBaseClass1.Method1();
            someBaseClass1.Method2();

            SomeBaseClass someBaseClass2 = new SomeDerivedClass();
            someBaseClass2.Method1();
            someBaseClass2.Method2();

            SomeDerivedClass someDerivedClass = new SomeDerivedClass();
            someDerivedClass.Method1();
            someDerivedClass.Method2();
        }
    }
}
