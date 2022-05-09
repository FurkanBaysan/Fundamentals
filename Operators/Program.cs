using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t" + "Arithmetic Operators");
            int firstNumber = 10;
            int secondNumber = 3;
            int sum = firstNumber + secondNumber;
            Console.WriteLine("Sum: " + sum);
            int subtractionResult = firstNumber - secondNumber;
            Console.WriteLine("Subtraction Result: " + subtractionResult);
            int multiplicationResult = firstNumber * secondNumber;
            Console.WriteLine("Multiplication Result: " + multiplicationResult);
            float divisionResult = (float)firstNumber / (float)secondNumber;
            Console.WriteLine("Division Result: " + divisionResult);
            int remainder = firstNumber % secondNumber;
            Console.WriteLine("Remainder Result: " + remainder + "\n");

            Console.WriteLine("\t" + "Operator Precedence");
            int firstNum = 1;
            int secondNum = 2;
            int thirdNum = 3; 

            Console.WriteLine(firstNum + secondNum * thirdNum); // Output:7
            Console.WriteLine("Changing Operator Precedence => Use Parenthesis");
            Console.WriteLine((firstNum + secondNum) * thirdNum);// Output:9

            Console.WriteLine("\t" + "Comparison Operators");

            Console.WriteLine(firstNumber > secondNumber);
            Console.WriteLine(firstNumber == secondNumber);
            Console.WriteLine(firstNumber != secondNumber);
            Console.WriteLine("Tricky Scenario: " + !(firstNumber != secondNumber) + "\n");

            Console.WriteLine("\t" + "Logical Operators");
            Console.WriteLine(thirdNum > secondNum && thirdNum > firstNum);
            Console.WriteLine(thirdNum > secondNum && thirdNum == firstNum);
            Console.WriteLine(thirdNum > secondNum || thirdNum == firstNum);
            Console.WriteLine(!(thirdNum == secondNum || thirdNum > firstNum));
        }
    }
}
