using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t" + "Implicit Type Conversion");

            byte firstNumber = 1;
            int secondNumber = firstNumber;
            Console.WriteLine(secondNumber);

            Console.WriteLine("\t" + "Explicit Type Conversion");

            int thirdNumber = 1000;
            byte fourthNumber = (byte)thirdNumber; // Data Loss.
            Console.WriteLine(fourthNumber);

            Console.WriteLine("\t" + "\t" + "Non-Compatible Types Conversion");

            Console.WriteLine("\t" + "Scenario 1");
            string currentString = "1234";
            int correspondingNumber = Convert.ToInt32(currentString);
            Console.WriteLine(correspondingNumber);

            Console.WriteLine("\t" + "Scenario 2");
            try
            {
                string newString = "1234";
                byte number = Convert.ToByte(newString);
                Console.WriteLine(number);
            }
            catch (Exception exception)
            {
                //Console.WriteLine(exception);
                Console.WriteLine("The number could not be converted to a byte.");
            }

            Console.WriteLine("\t" + "Scenario 3");
            try
            {
                string anotherString = "true";
                bool isBool = Convert.ToBoolean(anotherString);
                Console.WriteLine(isBool);
            }
            catch (Exception exception)
            {
                Console.WriteLine("The string data can not be converted to a bool");
            }
        }
    }
}
