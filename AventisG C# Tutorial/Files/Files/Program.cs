using System;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string file1 = System.IO.File.ReadAllText(@"/Users/michaelsilberstein/launch_academy/output_file.txt");
            string[] file2 = System.IO.File.ReadAllLines(@"/Users/michaelsilberstein/launch_academy/output_file2.txt");
            Console.WriteLine(file1);

            foreach (var line in file2)
            {
                Console.WriteLine(line);
            }

            string text = "This is the new information";
            System.IO.File.WriteAllText(@"/Users/michaelsilberstein/launch_academy/output_file3.txt", text);

            string[] lines = { "This is line1", "This is line2", "This is line3" };

            System.IO.File.WriteAllLines(@"/Users/michaelsilberstein/launch_academy/output_file4.txt", lines);

            using(System.IO.StreamWriter writer =  new System.IO.StreamWriter(@"/Users/michaelsilberstein/launch_academy/output_file5.txt"))
            {
                foreach (var line in lines)
                {
                    writer.WriteLine(line);
                }
            }

        }
    }
}
