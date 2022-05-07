using System;
using System.Collections.Generic;

namespace ProceduralProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ReverseStringScenario
            Console.WriteLine("\t" + "Reverse String Scenario");

            Console.Write("What's your Name: ");
            String name = Console.ReadLine();
            String reversedName = FindReverse(name);
            Console.WriteLine("Reversed Name: " + reversedName);

            #endregion

            #region UniqueNumbersListScenario
            Console.WriteLine("\t" + "Find Unique Numbers Scenario");

            List<Int32> numbers = new List<int>();
            while (true)
            {
                Console.WriteLine("Enter a Number (or 'Quit' to Exit): ");
                String input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    break;
                }
                numbers.Add(Convert.ToInt32(input));
            }

            List<Int32> uniques = GetUniqueNumbers(numbers);

            Console.WriteLine("Unique Numbers: ");
            foreach (int number in uniques)
            {
                Console.WriteLine(number);
            }

            #endregion
        }

        public static String FindReverse(String name)
        {
            char[] tempArray = new Char[name.Length];
            for (int i = 0; i < name.Length; i++)
            {
                tempArray[i] = name[name.Length - 1 - i];
            }
            String reversedName = new string(tempArray);

            return reversedName;
        }
        public static List<Int32> GetUniqueNumbers(List<Int32> numbers)
        {
            List<Int32> uniques = new List<int>();
            foreach (int number in numbers)
            {
                if (!uniques.Contains(number))
                {
                    uniques.Add(number);
                }
            }
            return uniques;
        }
    }
}
