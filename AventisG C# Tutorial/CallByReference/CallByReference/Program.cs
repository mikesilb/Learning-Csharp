using System;

namespace CallByReference
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            makeItFalse(ref a);
            Console.WriteLine(a);
        }

        static void makeItFalse(ref bool a)
        {
            a = false;
        }
    }
}

