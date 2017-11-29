using System;

// Namespace
namespace NumberGuesser
{
    // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {

            GetAppInfo();
            GreetUser();

            while (true)
            {
                Random random = new Random();
                int correctNumber = random.Next(1, 11);


                int guess = 0;
                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    string inputNumber = Console.ReadLine();

                    if (!int.TryParse(inputNumber, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Terrible format! Please add an actual number.");
                        continue;
                    }

                    guess = Int32.Parse(inputNumber);
                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Incorrect guess!  Try again! \n Guess a number between 1 and 10");
                    }
                }

                PrintColorMessage(ConsoleColor.Yellow, "Awesome Job!");

                Console.WriteLine("Play again? [Y or N]");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    continue;
                }
                else if(answer == "N") {
                    return;
                }
            }
        }

        static void GetAppInfo(){
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Mike Silberstein";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();
        }

        static void GreetUser(){
            Console.WriteLine("What is your name?");
            string inputname = Console.ReadLine();
            Console.WriteLine("Hello {0}, lets play a game...", inputname);
        }
        static void PrintColorMessage(ConsoleColor color, string message){
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
