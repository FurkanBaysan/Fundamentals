namespace ClassesDemo.Math
{
    internal class Calculator
    {
        public double Add(int FirstNumber, int SecondNumber)
        {
            double sum = FirstNumber + SecondNumber;
            return sum;
        }

        public double Subtract(int FirstNumber, int SecondNumber)
        {
            double subtractionResult = FirstNumber - SecondNumber;
            return subtractionResult;
        }

        public double Multiply(int FirstNumber, int SecondNumber)
        {
            double multiplicationResult = FirstNumber * SecondNumber;
            return multiplicationResult;
        }
        public double Divide(int FirstNumber, int SecondNumber)
        {
            double multiplicationResult = FirstNumber / SecondNumber;
            return multiplicationResult;
        }

        public int Modding(int FirstNumber, int SecondNumber)
        {
            int moddingResult = FirstNumber % SecondNumber;
            return moddingResult;
        }
    }
}
