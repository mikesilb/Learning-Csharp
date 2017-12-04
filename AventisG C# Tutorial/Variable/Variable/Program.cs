using System;

namespace Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            int theNewVariable = 1;
            string myName = "Mike";
            bool IsCompatible = true;
            string number = "2";
            int numberConverted = Convert.ToInt32(number);

            Console.WriteLine(theNewVariable);
            Console.WriteLine(myName);
            Console.WriteLine(IsCompatible);
            Console.WriteLine(number);
            Console.WriteLine(numberConverted);
        }
    }
}
