using System;

namespace ClassesDemo
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public double Weight;
        public int Height;

        public void Introduce()
        {
            Console.WriteLine(this.FirstName + " " + this.LastName + " " + "Back in Town!");
        }
        public double Eating(int increment)
        {
            this.Weight = this.Weight + increment;
            return this.Weight;
        }

        public double Dieting(int decrement)
        {
            this.Weight = this.Weight - decrement;
            return this.Weight;
        }

    }
}