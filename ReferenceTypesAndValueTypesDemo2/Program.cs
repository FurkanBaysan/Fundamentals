using System;

namespace ReferenceTypesAndValueTypesDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 20;
            Increment(number);
            Console.WriteLine(number);

            Person person = new Person();
            person.Age = 20;
            MakeOld(person);
            Console.WriteLine(person.Age);
        }

        public static void Increment(int number)
        {
            number = number + 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age = person.Age + 10;
        }
    }
}
