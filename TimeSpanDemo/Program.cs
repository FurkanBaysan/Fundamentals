using System;

namespace TimeSpanDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating TimeSpan objects

            TimeSpan timeSpan = new TimeSpan(1, 2, 3);
            Console.WriteLine("Total Time Span: " + timeSpan);
            TimeSpan secondTimeSpan = new TimeSpan(1, 0, 0);

            TimeSpan thirdTimeSpan = TimeSpan.FromHours(1); // Doing the same thing with above instruction.

            DateTime start = DateTime.Now;
            DateTime end = DateTime.Now.AddMinutes(2);
            TimeSpan duration = end - start;
            Console.WriteLine("Duration: " + duration);

            Console.WriteLine();

            // Accessing Properties of TimeSpan object

            Console.WriteLine("Time difference in hours only: " + timeSpan.Hours);
            Console.WriteLine("Expressing the Total time difference as " +
                              "whole and fractional hours: " + timeSpan.TotalHours);

            Console.WriteLine("Just Minutes: " + timeSpan.Minutes);
            Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);

            Console.WriteLine();

            // Modifying TimeSpan object and Returning a new TimeSpan object
            Console.WriteLine(timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine(timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            //Converting TimeSpan objects to a String
            Console.WriteLine("ToString: " + timeSpan.ToString());
            //Converting String objects to a TimeSpan object
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));
        }
    }
}
