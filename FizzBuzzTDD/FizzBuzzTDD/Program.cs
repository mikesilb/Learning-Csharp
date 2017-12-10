using System;
using FizzBuzz.Library;

namespace FizzBuzzTDD
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int num = 1; num < 101; num++)
            {
                Console.WriteLine(FizzBuzzer.GetValue(num));
            }
        }
    }
}
