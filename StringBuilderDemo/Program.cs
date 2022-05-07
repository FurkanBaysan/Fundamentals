using System;
using System.Text;

namespace StringBuilderDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            StringBuilder builder = new StringBuilder();

            builder.Append('-', 10);
            builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 10);

            builder.Replace('-', '+');

            builder.Remove(0, 10);

            builder.Insert(0, new String('-', 10));

            Console.WriteLine(builder);

            Console.WriteLine("First Character: " + builder[0]);

            Console.WriteLine("\t" + "Chaining Manipulation Methods");
            StringBuilder newBuilder = new StringBuilder("Courses: ");
            newBuilder.AppendLine()
                .Append("Intro to Programming with C/C++")
                .AppendLine()
                .Append("C# Basics ")
                .AppendLine()
                .Append("C# OOP")
                .AppendLine()
                .Append("C# Advanced")
                .Replace("C#", "Java");
            //.Remove(0, 20)
            //.Insert(0, new String("Data Structures with C"));

            Console.WriteLine(newBuilder);
        }
    }
}
