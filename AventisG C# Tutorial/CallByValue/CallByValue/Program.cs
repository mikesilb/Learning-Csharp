using System;

namespace CallByValue
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            makeItFalse(a);
            Console.WriteLine(a);
        }

        static void makeItFalse(bool a)
        {
            a = false;
        }
    }
}
