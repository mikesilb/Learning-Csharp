using System;

namespace CallByReferenceUsingOut
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a;
            makeItFalse(out a);
            Console.WriteLine(a);
        }

        static void makeItFalse(out bool a)
        {
            a = false;
        }
    }
}
