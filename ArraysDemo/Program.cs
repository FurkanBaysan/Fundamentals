using System;

namespace ArraysDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            numbers[0] = 1;
            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers[2]);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();

            bool[] flags = new bool[3];
            flags[0] = true;
            for (int i = 0; i < flags.Length; i++)
            {
                Console.Write(flags[i] + " ");
            }

            Console.WriteLine();

            Console.WriteLine("\t" + "Courses Scenario");
            string[] courses = new string[3]
            {
                "Introduction to Java",
                "Object-Oriented Programming with Java",
                "Advanced Java"
            };
            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine(courses[i]);
            }
        }
    }
}
