using System;

namespace LoopsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t" + "Scenario: Even Numbers between 1-10");
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }

            for (int i = 10; i > 0; i--)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }

            //Console.WriteLine();
            //Console.WriteLine("\t" + "Scenario: Print the letters of a Sentence from top to bottom");
            //Console.WriteLine("\t" + "First Way: Using For Loop");
            //String name = "Furkan Baysan";
            //for (int i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name.Substring(i, 1));
            //}
            //Console.WriteLine(" " + "Second Way: Using ForEach Loop");
            //foreach (var number in name)
            //{
            //    Console.WriteLine(number);
            //}

            //Console.WriteLine("\t" + "Iterate over an Array");
            //int[] numbers = new int[4] { 10, 20, 30, 40 };
            //foreach (int number in numbers)
            //{
            //    Console.Write(number + " ");
            //}

            Console.WriteLine();

            Console.WriteLine("\t" + "Scenario: Even Numbers between 1-10 using While Loop");
            int iter = 2;
            while (iter <= 10)
            {
                if (iter % 2 == 0)
                {
                    Console.WriteLine(iter);
                }

                iter++;
            }

            Console.WriteLine();

            Console.WriteLine("Scenario: The scenario that we should use While Loop ");
            while (true)
            {
                Console.Write("Type Your Name: ");
                String inputData = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(inputData))
                {
                    break;
                }

                Console.WriteLine("@Echo: " + inputData);
            }
            //Console.WriteLine("\t" + "Alternative Way of implementing that Same Scenario");
            //while (true)
            //{
            //    Console.Write("Type Your Name: ");
            //    String inputData = Console.ReadLine();

            //    if (!String.IsNullOrWhiteSpace(inputData))
            //    {
            //        Console.WriteLine("@Echo: " + inputData);
            //        continue;
            //    }
            //    break;
            //}
        }
    }
}
