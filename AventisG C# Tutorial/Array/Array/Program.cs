using System;
using System.Collections.Generic;

namespace array1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5] {1, 10, 100, 1000, 10000};
            int[,] array1 = new int[5, 2];

            List<int> numbers = new List<int>() { 1, 10, 100, 1000, 10000 };
            numbers.Add(1);
            numbers.Add(50);
            numbers.RemoveAt(2);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            //array[0] = 1;
            //array[1] = 10;
            //array[2] = 100;
            //array[3] = 1000;
            //array[4] = 10000;

            for (int index = 0; index < array.Length; index++)
            {
                Console.WriteLine(array[index]);
            }

            foreach (var element in array)
            {
                Console.WriteLine(element);
            }

            array1[0,0] = 1;
            array1[0,1] = 1;
            array1[1,0] = 1;
            array1[1,1] = 1;
            array1[2,0] = 1;
            array1[2,1] = 1;
            array1[3,0] = 1;
            array1[3,1] = 1;
            array1[4,0] = 1;
            array1[4,1] = 1;
       


            Console.Write(array1[0, 0]);
            Console.Write(array1[0, 1]);
            Console.WriteLine();

            Console.Write(array1[1, 0]);
            Console.Write(array1[1, 1]);
            Console.WriteLine();

            Console.Write(array1[2, 0]);
            Console.Write(array1[2, 1]);
            Console.WriteLine();

            Console.Write(array1[3, 0]);
            Console.Write(array1[3, 1]);
            Console.WriteLine();

            Console.Write(array1[4, 0]);
            Console.Write(array1[4, 1]);
            Console.WriteLine();


            





        }
    }
}
