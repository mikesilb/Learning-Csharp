using System;

namespace ControlFlowSwitchVsIf
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = Console.ReadLine();
            string choice2 = Console.ReadLine();

            switch (choice)
            {
                case "Avetis":
                    Console.WriteLine("This is my name");
                    break;
                case "Visual Studio":
                    Console.WriteLine("This is my IDE");
                    break;
                default:
                    Console.WriteLine("There was no match");
                    break;

            }

            if (choice.Equals("Avetis") && choice2.Equals("Mike"))            
            {
                Console.WriteLine("This is my name");
            }

            else if (choice.Equals("Visual Studio"))
            {
                Console.WriteLine("This is my IDE");
            }

            else 
            {
                Console.WriteLine("There was no match");    
            }
        }
    }
}
