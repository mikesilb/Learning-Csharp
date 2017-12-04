using System;

namespace LoopingDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {

            string input2 = string.Empty;
            do
            {

                input2 = Console.ReadLine();
                Console.WriteLine("Your input is {0}.", input2);


            } while (!input2.Equals(string.Empty));
        }
    }
}
