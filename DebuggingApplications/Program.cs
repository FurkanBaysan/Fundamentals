using System;
using System.Collections.Generic;

namespace DebuggingApplications
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Int32> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            List<Int32> smallestNumbers = GetSmallests(numbers, 3);
            foreach (int number in smallestNumbers)
            {
                Console.Write(number + " ");
            }
        }
        public static List<Int32> GetSmallests(List<Int32> list, int count)
        {
            if (list == null)
            {
                throw new ArgumentNullException("list");
            }
            if (count > list.Count || count <= 0)
            {
                throw new ArgumentOutOfRangeException("count", "Count should be between 1 and the number of elements in the list.");
            }

            List<int> buffer = new List<int>(list); // For Removing Side Effects
            List<Int32> smallestNumbers = new List<Int32>();

            while (smallestNumbers.Count < count)
            {
                int smallest = GetSmallest(buffer);
                smallestNumbers.Add(smallest);
                buffer.Remove(smallest);
            }

            return smallestNumbers;
        }


        public static int GetSmallest(List<Int32> list)
        {
            int min = list[0];

            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] < min)
                {
                    min = list[i];
                }
            }

            return min;
        }
    }
}
