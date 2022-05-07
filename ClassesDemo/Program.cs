using System;
using ClassesDemo.Math;


namespace ClassesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.FirstName = "Furkan";
            person.LastName = "Baysan";
            person.Weight = 78.5;
            person.Introduce();
            Console.WriteLine("Weight: " + person.Weight);
            person.Eating(2);
            Console.WriteLine("Current Weight: " + person.Weight);
            person.Dieting(5);
            Console.WriteLine("Current Weight: " + person.Weight);

            Calculator calculator = new Calculator();
            double result =
                calculator.Add(10, 20);
            Console.WriteLine(result);
        }
    }
}
