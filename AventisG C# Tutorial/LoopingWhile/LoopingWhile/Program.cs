using System;

namespace LoopingWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 0;

            while(index < 10)
            {
                Console.WriteLine("The number is {0}", index);
                index++;
            }
        }
    }
}
