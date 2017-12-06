using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string sampleString1 = "someString";
            string sampleString2 = "somestring";
            string sampleString3 = "someString    ";

            if (sampleString1.Equals(sampleString2, StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("They are the same");
            }

            Console.WriteLine(sampleString1[4]);

            for (int i = 0; i < sampleString1.Length; i++)
            {
                Console.WriteLine(sampleString1[i]);
            }

            string substringOfSampleString1 = sampleString1.Substring(1, 4);
            Console.WriteLine(substringOfSampleString1);

            Console.WriteLine(sampleString1.ToUpper());
            Console.WriteLine(sampleString1.ToLower());

            string sampleEmptyString = string.Empty;

            if (string.IsNullOrEmpty(sampleEmptyString))
            {
                Console.WriteLine("It is empty");
            }

            string cleanString = sampleString3.Trim();
            Console.WriteLine(cleanString);

            Console.WriteLine(sampleString2.Replace("some", "apple"));

            string sampleString4 = "someString,someString1,someString2,someString3";
            string[] words = sampleString4.Split(',');
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
            string joinedString = string.Join(',', words);
            Console.WriteLine(joinedString);                  
        }
    }
}
