using System;

namespace LoopingFor
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 6) continue;
                Console.Write("The i is {0}", i);
            }
        }
    }
}
