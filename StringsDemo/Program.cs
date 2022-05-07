using System;

namespace StringsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t" + "String Constitution");

            string firstName = "Furkan";
            String lastName = "Baysan";
            Console.WriteLine("Name: " + firstName);
            Console.WriteLine("Surname: " + lastName);
            string myMotherFirstName = "Serap";
            string myMotherLastName = "Baysan";
            Console.WriteLine("Mother Name: " + myMotherFirstName);
            Console.WriteLine("Mother Surname: " + myMotherLastName);
            string myFatherFirstName = "Omer";
            string myFatherLastName = "Baysan";
            Console.WriteLine("Father Name: " + myFatherFirstName);
            Console.WriteLine("Father Surname: " + myFatherLastName);

            Console.WriteLine("\t" + "String Concatenation");

            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);
            string myMotherFullName = String.Format("My Mother Full Name: {0} {1}", myMotherFirstName, myMotherLastName);
            Console.WriteLine(myMotherFullName);
            string myFatherFullName = String.Concat(myFatherFirstName, " ", myFatherLastName);
            Console.WriteLine("My Father Full Name: " + myFatherFullName);

            Console.WriteLine("\t" + "String Join");

            String[] familyMemberNames = new string[3] { "Furkan", "Omer", "Serap" };
            String resultString = String.Join(",", familyMemberNames);
            Console.WriteLine(resultString + " ");

            Console.WriteLine("\t" + "Verbatim Strings");

            string text = @"Hi Furkan
    Look into the following paths
    c:\folder1\folder2
    c:\folder3\folder4";
            Console.WriteLine(text);
        }
    }
}
