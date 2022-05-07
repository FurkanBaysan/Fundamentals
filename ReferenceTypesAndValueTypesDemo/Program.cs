using System;

namespace ReferenceTypesAndValueTypesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 10;
            int secondNumber = 20;
            secondNumber = firstNumber;
            secondNumber++;
            Console.WriteLine(String.Format("FirstNumber: {0}, SecondNumber: {1}", firstNumber, secondNumber));

            int[] firstArray = new int[] { 1, 2, 3 };
            var secondArray = firstArray;
            secondArray[0] = 524;
            Console.WriteLine(String.Format("firstArray [0]: {0}, secondArray[0]: {1}", firstArray[0], secondArray[0]));
        }
    }
}
