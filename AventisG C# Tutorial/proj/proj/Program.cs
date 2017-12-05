using System;

namespace proj
{
    class Program
    {
        public const string something = "the best";
        public readonly string somethingelse = "the greatest";

        static void Main(string[] args)
        {
            Console.WriteLine(Program.something);

            Program program = new Program();       
            Console.WriteLine(program.somethingelse);
        }
    }
}
