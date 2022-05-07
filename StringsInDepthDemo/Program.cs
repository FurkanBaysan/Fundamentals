using System;

namespace StringsInDepthDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            String fullName = "Furkan Baysan ";

            Console.WriteLine("Trim:'{0}'", fullName.Trim());

            Console.WriteLine("ToUpper:'{0}'", fullName.Trim().ToUpper());

            int index = fullName.IndexOf(' ');
            String firstName = fullName.Substring(0, index);
            String lastName = fullName.Substring(index + 1);
            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);

            String[] names = fullName.Split(' ');
            Console.WriteLine("First Name: " + names[0]);
            Console.WriteLine("Last Name: " + names[1]);

            Console.WriteLine(fullName.Replace("Furkan", "Omer"));

            if (String.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("Invalid");
            }

            var ageString = "25";
            byte age = Convert.ToByte(ageString);
            Console.WriteLine(age);

            double price = 29.95;
            Console.WriteLine(price.ToString());
            Console.WriteLine(price.ToString("C"));
            Console.WriteLine(price.ToString("C0"));
        }
    }
}
