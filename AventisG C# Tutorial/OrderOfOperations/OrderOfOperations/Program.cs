using System;

namespace OrderOfOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer1 = 10 + 2 * 3;
            int answer2 = (10 + 2) * 3;
            int answer3 = 10 / 2 * 3;
            int answer4 = 10 / (2 * 3);

            Console.WriteLine(answer1);
            Console.WriteLine(answer2);
            Console.WriteLine(answer3);
            Console.WriteLine(answer4);

        }
    }
}
