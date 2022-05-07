using System;

namespace ControlFlowExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            FirstSolution(number);
            Console.WriteLine("Please Enter the First Number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter a Second Number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            SecondSolution(firstNumber, secondNumber);
            Console.WriteLine("Please Enter the First Number: ");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter the Second Number: ");
            int height = Convert.ToInt32(Console.ReadLine());
            ThirdSolution(width, height);
            Console.WriteLine("Enter the Speed Limit: ");
            int speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Speed of Car: ");
            int speed = Convert.ToInt32(Console.ReadLine());
            FourthSolution(speedLimit, speed);
            Console.WriteLine("\t" + "\t" + "Loop Exercises");
            CalculateDivisibleNumbers();
            SumOfTakenNumbersFromUser();
            Console.Write("Enter a Number: ");
            int currentNumber = Convert.ToInt32(Console.ReadLine());
            CalculateFactorial(number);
            PlayingGuessingGame();
            FindMaximumNumber();
        }
        #region ConditionalBlocksExercises
        static void FirstSolution(int number)
        {
            if (number >= 1 && number <= 10)
            {
                Console.WriteLine("Valid Number");
            }
            else
            {
                Console.WriteLine("Invalid Number");
            }
        }
        static void SecondSolution(int firstNumber, int secondNumber)
        {

            if (firstNumber > secondNumber)
            {
                Console.WriteLine("Bigger One: " + firstNumber);
            }
            else
            {
                Console.WriteLine("Bigger One: " + secondNumber);
            }
        }
        static void ThirdSolution(int width, int height)
        {
            if (width == height)
            {
                Console.WriteLine("Image is a Portrait");
            }
            else
            {
                Console.WriteLine("Image is Landscape");
            }
        }
        static void FourthSolution(int speedLimit, int speed)
        {

            if (speed <= speedLimit)
            {
                Console.WriteLine("That's Okay");
            }
            else if (speed > speedLimit)
            {
                int demeritPoint = (speed - speedLimit) / 5;
                if (demeritPoint > 12)
                {
                    Console.WriteLine("License Suspended");
                }
                else
                {
                    Console.WriteLine("You've been Punished");
                }
            }
        }
        #endregion
        #region LoopingExercises
        static void CalculateDivisibleNumbers()
        {
            int count = 0;
            for (int i = 0; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    count = count + 1;
                }
            }

            Console.WriteLine("Count of Numbers Divisible by 3: " + count);
        }
        static void SumOfTakenNumbersFromUser()
        {
            int sum = 0;
            while (true)
            {
                Console.WriteLine("Please, Enter a Number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                sum = sum + number;

                Console.WriteLine("If you want to quit the Algorithm, Say " + "Ok");
                string quit = Console.ReadLine();

                if (quit == "Ok")
                {
                    Console.WriteLine("Sum: " + sum);
                    break;
                }
            }
        }
        static void CalculateFactorial(int number)
        {
            int factorialResult = 1;
            for (int i = number; i >= 1; i--)
            {
                factorialResult = factorialResult * i;
            }

            Console.WriteLine("Factorial Result: " + factorialResult);
        }
        static void PlayingGuessingGame()
        {
            Random random = new Random();
            int number = random.Next(1, 10);
            bool flag = false;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Guess the Number: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (number == choice)
                {
                    flag = true;
                    Console.WriteLine("Congratulations");
                    break;
                }
            }
            if (flag == false)
                Console.WriteLine("You Lost.");
        }
        static void FindMaximumNumber()
        {
            int[] numbers = new int[10];
            int biggestNumber = Int32.MinValue;
            int i = 0;
            int count = 0;
            while (i < numbers.Length)
            {
                Console.WriteLine("Enter a Number: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                count++;

                if (numbers[i] > biggestNumber)
                {
                    biggestNumber = numbers[i];
                }

                if (count == 5)
                {
                    break;
                }

                i++;
            }

            Console.WriteLine();

            for (int j = 0; j < count; j++)
            {
                Console.Write(numbers[j] + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Biggest Number: " + biggestNumber);
        }
        #endregion
    }
}
