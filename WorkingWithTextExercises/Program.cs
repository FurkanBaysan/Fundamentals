using System;
using System.Collections.Generic;

namespace WorkingWithTextExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //FindConsecutive();
            //FindDuplicate();
            //ValidateTimeFormat();
            //ConvertToPascalCase();
            //FindNumberOfVowels();
        }

        static void FindConsecutive()
        {
            Console.Write("Enter a few numbers: ");
            String input = Console.ReadLine();

            List<Int32> numbers = new List<Int32>();

            foreach (String number in input.Split('-'))
            {
                numbers.Add(Convert.ToInt32(number));
            }
            numbers.Sort();

            bool isConsecutive = true;
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] != numbers[i - 1] + 1)
                {
                    isConsecutive = false;
                    break;
                }
            }

            if (isConsecutive)
            {
                Console.WriteLine("Consecutive");
            }
            else
            {
                Console.WriteLine("Not Consecutive");
            }
        }

        static void FindDuplicate()
        {
            Console.WriteLine("Enter a few Numbers: ");
            String input = Console.ReadLine();

            List<Int32> numbers = new List<Int32>();

            bool isDuplicate = false;


            foreach (String number in input.Split('-'))
            {
                if (String.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Input is Null or Empty");
                    break;
                }
                else
                {
                    numbers.Add(Convert.ToInt32(number));
                }

            }
            numbers.Sort();

            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = i + 1; j < numbers.Count; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }
            }

            if (isDuplicate)
            {
                Console.WriteLine("Duplicate");
            }
            else
            {
                Console.WriteLine("All the Elements are Unique");
            }
        }

        static void ValidateTimeFormat()
        {
            try
            {
                Console.Write("Enter a time value in 24-hour format: ");
                DateTime input = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("OK");
            }
            catch (Exception exception)
            {
                Console.WriteLine("Invalid Time");
                //Console.WriteLine(exception.Message);
            }
        }

        static void ConvertToPascalCase()
        {
            Console.WriteLine("Enter a Few Words: ");
            String inputWord = Console.ReadLine();
            String[] currentInput = inputWord.Split(' ');


            for (int i = 0; i < currentInput.Length; i++)
            {
                String wordWithUpperCharacter = currentInput[i].Substring(0, 1).ToUpper() +
                                               currentInput[i].Substring(1, currentInput[i].Length - 1).ToLower();
                Console.Write(wordWithUpperCharacter.Trim());
            }
        }

        static void FindNumberOfVowels()
        {
            Console.WriteLine("Enter an English Word: ");
            String word = Console.ReadLine();
            String currentWord = word.Trim().ToLower();
            char[] vowels = new char[] { 'a', 'e', 'o', 'u', 'i' };

            int sum = 0;
            for (int i = 0; i < currentWord.Length; i++)
            {
                char characterOfWord = currentWord[i];

                for (int j = 0; j < vowels.Length; j++)
                {
                    if (characterOfWord == vowels[j])
                    {
                        sum = sum + 1;
                    }
                }
            }
            Console.WriteLine("Total Vowel Number: " + sum);
        }
    }
}
