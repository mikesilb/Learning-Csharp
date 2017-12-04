using System;

namespace ControlFlowDecision
{
    class Program
    {
        static void Main(string[] args)
        {
            string player = Console.ReadLine();

            if (player.Equals("AI"))
            {
                Console.WriteLine("The player is AI.");
            }
            else if (player.Equals("Human"))
            {
                Console.WriteLine("The player is Human.");
            }
            else 
            {
                Console.WriteLine("The player is not AI and not Human.");       
            }
            if (player.Equals("Robot"))
            {
                Console.WriteLine("The player is Robot.");
            }    
        }
    }
}
