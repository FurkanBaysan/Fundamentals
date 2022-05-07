using System;

namespace VariablesAndConstants
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t" + "Variables" + "\n");
            byte minimumEvenNumber = 2;
            int numberOfCourses = 3;
            // float totalPrice = 20.95; // => Requires Type-Casting.
            float totalPrice = 20.95f;
            char character = 'F';
            string firstName = "Furkan";
            string lastName = "Baysan";
            bool isLogged = false;

            Console.WriteLine("Minimum Even Number: " + minimumEvenNumber);
            Console.WriteLine("Number of Courses: " + numberOfCourses);
            Console.WriteLine("Total Price: " + totalPrice);
            Console.WriteLine("First Letter of my Name: " + character);
            Console.WriteLine("FirstName: " + firstName);
            Console.WriteLine("User is Logged or Not: " + isLogged);
            Console.WriteLine("Founder of Software Concepts: " + firstName + " " + lastName + "\n");


            Console.WriteLine("byte Range: " + "{0},{1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("float range: " + "{0},{1}", float.MinValue, float.MaxValue + "\n");


            Console.WriteLine("\t" + "Constants" + "\n");
            const double pi = 3.14;
            Console.WriteLine("Constant Pi Data: " + pi);
        }
    }
}
