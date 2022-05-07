using System;

namespace ArrayManipulationMethodsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 3, 7, 9, 2, 14, 6 };

            //Length => Return the Size of the Array
            Console.WriteLine("Length: " + numbers.Length);

            //IndexOf(..)
            //Suppose that, We're looking for 9.
            int position = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9: " + position);

            //Clear(..)
            Array.Clear(numbers, 0, 2);
            Console.WriteLine("Effect of Clear(..)");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            //Copy(..)
            int[] nextArray = new int[3];
            Array.Copy(numbers, nextArray, 3);
            Console.WriteLine("Effect of Copy(..)");
            foreach (int number in nextArray)
            {
                Console.WriteLine(number);
            }
            // Sort(..)
            Array.Sort(numbers);
            Console.WriteLine("Effects of Sort(..)");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            // Reverse(..)
            Array.Reverse(numbers);
            Console.WriteLine("Effects of Reverse(..)");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
