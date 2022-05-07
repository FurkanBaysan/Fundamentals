using System;

namespace DateTimeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(2022, 4, 21);
            var now = DateTime.Now;
            var today = DateTime.Today;

            // Accessing object's attributes

            Console.WriteLine("Current DateTime and Time: " + now);
            Console.WriteLine("Current Hour: " + now.Hour);
            Console.WriteLine("Current Minute: " + now.Minute);

            //DateTime objects are immutable. Exactly like String objects.
            String currentStr = new string("Furkan");
            String newStr = currentStr.Insert(6, "Baysan");
            Console.WriteLine(newStr);

            DateTime tomorrow = now.AddDays(1);
            Console.WriteLine("Tomorrow: " + tomorrow);
            DateTime yesterday = now.AddDays(-1);
            Console.WriteLine("Yesterday: " + yesterday);


            //Converting DateTime objects to a String
            String currentDateString = now.ToLongDateString();
            Console.WriteLine(currentDateString);

            String currentTimeString = now.ToLongTimeString();
            Console.WriteLine(currentTimeString);

            Console.WriteLine();

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            //Prints entire current Date and Time together
            Console.WriteLine(now.ToString());

            //Format Specifiers
            Console.WriteLine(now.ToString("yyyy-MM-dd"));
            Console.WriteLine(now.ToString("yy-MMM-dd ddd"));

            //We can also add Time to String type DateTime
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));
            Console.WriteLine(now.ToString("yy-MMM-dd ddd HH:mm"));
        }
    }
}
