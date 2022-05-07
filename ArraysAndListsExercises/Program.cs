using System;
using System.Collections.Generic;
using System.Linq;

namespace ArraysAndListsExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayFacebookLikes();
            FindReverse();
            CheckUnique();
            DisplayUniqueData();
            FindMinimumThreeElements();
        }

        #region ArraysAndListsSolutionAlgorithms

        static void DisplayFacebookLikes()
        {
            Console.WriteLine("\t" + "Facebook Likes");

            List<String> likes = new List<string>();
            while (true)
            {
                Console.WriteLine("Please, Enter a Name: ");
                String name = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(name))
                {
                    break;
                }

                likes.Add(name);
            }

            if (likes.Count == 1)
            {
                Console.WriteLine("Number of Likes : " + likes.Count);
                foreach (var like in likes)
                {
                    Console.WriteLine(like + " liked your post");
                }
            }

            if (likes.Count == 2)
            {
                Console.WriteLine("Number of Likes : " + likes.Count);
                Console.WriteLine(likes[0] + " and " + likes[1] + " liked your Post");
            }

            if (likes.Count > 2)
            {
                Console.Write(likes[0] + " " + "," + likes[1] + " and " + (likes.Count - 2) + " more liked your Post");
            }
        }
        static void FindReverse()
        {
            Console.WriteLine("\t" + "Reverse of Given String");

            Console.WriteLine("Enter Your Name: ");
            String name = Console.ReadLine();
            Char[] charName = name.ToCharArray();
            for (int i = 0; i < name.Length; i++)
            {
                Console.Write(name[name.Length - (i + 1)].ToString().ToLower() + " ");
            }
        }
        static void CheckUnique()
        {
            var numbers = new int[5];
            Console.WriteLine("Enter 5 unique numbers: ");

            for (int i = 0; i < 5; i++)
            {
                while (true)
                {
                    int inputNumber = Convert.ToInt32(Console.ReadLine());
                    int currentIndex = Array.IndexOf(numbers, inputNumber);
                    if (currentIndex == -1)
                    {
                        numbers[i] = inputNumber; // Accept New value
                        break;
                    }
                    Console.WriteLine("Hold on, you already entered that number. Try again.");
                }
            }
            Array.Sort(numbers);
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
        }
        static void DisplayUniqueData()
        {
            List<Int32> numbers = new List<int>();
            Boolean choice = false;

            while (true)
            {
                Console.Write("To Exit, Type False: ");
                Boolean quit = Convert.ToBoolean(Console.ReadLine());
                if (quit == choice)
                {
                    numbers.Sort();
                    foreach (var number in numbers)
                    {
                        Console.Write(number + " ");
                    }
                    break;
                }

                Console.WriteLine();

                Console.WriteLine("Enter a Number: ");
                int inputNumber = Convert.ToInt32(Console.ReadLine());
                int inputIndex = numbers.IndexOf(inputNumber);
                if (inputIndex == -1)
                {
                    numbers.Add(inputNumber);
                }
                else
                {
                    Console.WriteLine("Already Available. Try Again");
                }
            }
        }
        static void FindMinimumThreeElements()
        {
            var numbers = new List<Int32>();
            while (true)
            {
                Console.WriteLine("Please Enter a Number: ");
                int input = Convert.ToInt32(Console.ReadLine());
                numbers.Add(input);

                if (numbers.Count == 0 || numbers.Count < 5)
                {
                    Console.WriteLine("Invalid List, Try Again");
                    continue;
                }
                else
                {
                    numbers.Sort();
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine("Number " + (i + 1) + " : " + numbers[i]);
                    }
                    break;
                }

            }
        }

        #endregion
    }
}
