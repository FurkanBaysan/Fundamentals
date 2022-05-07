using System;
using System.Collections.Generic;

namespace ListsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Int32> numbers = new List<int>() { 1, 2, 3, 4 };
            Console.WriteLine("\t" + "Printing List");
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();

            Console.WriteLine("\t" + "Add Operation");
            numbers.Add(1);
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();

            Console.WriteLine("\t" + "Adding an Array/List to the existing List");
            numbers.AddRange(new int[3] { 6, 7, 8 });

            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();

            Console.WriteLine("\t" + "IndexOf(..) Usage");
            int index = numbers.IndexOf(1);
            Console.WriteLine("Index of 1: " + index);
            Console.WriteLine("Last Index of 1: " + numbers.LastIndexOf(1));

            Console.WriteLine("\t" + "Count Property Usage");
            Console.WriteLine("Count: " + numbers.Count);

            Console.WriteLine("\t" + "Remove Operation");
            numbers.Remove(1);
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();

            Console.WriteLine("\t" + "Remove all 1's from the List");
            // In C#, we're not allowed to modify a Collection inside a foreach loop.
            //foreach (var number in numbers)
            //{
            //    if (number == 1)
            //    {
            //        numbers.Remove(1);
            //    }

            //}
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                {
                    numbers.Remove(numbers[i]);
                }
            }
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();

            Console.WriteLine("\t" + "Clear(..) Method Usage");
            numbers.Clear();
            Console.WriteLine("Count: " + numbers.Count);
        }
    }
}
