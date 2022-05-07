using System;

namespace ConditionalStatementsDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\t" + "Scenario 1: If Statement");

            Console.Write("Can you Tell me the Time ? ");
            int hour = Convert.ToInt32(Console.ReadLine());

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's Morning");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's Afternoon");
            }
            else if (hour >= 18 && hour < 22)
            {
                Console.WriteLine("It's Evening");
            }
            else
            {
                Console.WriteLine("It's the Night");
            }

            Console.WriteLine("\t" + "Scenario 2: If Statement");

            bool isGoldCustomer = false;
            double price = 0.0;

            if (isGoldCustomer)
            {
                price = 19.95;
                Console.WriteLine("Price: " + price);
            }
            else
            {
                price = 29.95;
                Console.WriteLine("Price: " + price);
            }
            //Console.WriteLine("\t" + "Conditional (Ternary) Operator");
            /*price = (isGoldCustomer) ? 19.95 : 29.95*/
            //Console.WriteLine(price);


            Console.WriteLine("\t" + "Switch Statement");


            var season = Season.Spring;

            switch (season)
            {
                case Season.Summer:
                    Console.WriteLine("Let's go the Beach Party !");
                    break;
                case Season.Spring:
                    Console.WriteLine("Right time for loving someone");
                    break;
                case Season.Autumn:
                    Console.WriteLine("Seems like we're going back to School or Work");
                    break;
                case Season.Winter:
                    Console.WriteLine("Right time to cuddle and sleep with someone, over coffee.");
                    break;
                default:
                    Console.WriteLine("No Available Season");
                    break;
            }
        }
    }
}
