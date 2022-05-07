using System;

namespace RandomClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                int randomNum = random.Next(1, 10);
                Console.Write(randomNum + " ");
            }

            Console.WriteLine();

            Console.WriteLine("a: " + (int)'a'); // Output:97
            Console.WriteLine("z: " + (int)'z');// Output: 122

            Console.WriteLine('a' + (int)'a');// Output: 194
            Console.WriteLine('z' + (int)'z');// Output: 244


            for (int i = 0; i < 10; i++)
            {
                char randomChar = (char)random.Next(97, 122);
                Console.Write(randomChar);
            }

            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                char randomChar = (char)('a' + random.Next(0, 26));
                Console.Write(randomChar);
            }

            Console.WriteLine();

            Console.WriteLine("\t" + "Final Solution: One More Improvement");
            PasswordGeneratorAlgorithm();
        }

        #region PasswordGeneratorFinalSolution
        static void PasswordGeneratorAlgorithm()
        {
            Random random = new Random();

            const int passwordLength = 10;
            char[] passwordBuffer = new char[passwordLength];
            for (int i = 0; i < passwordBuffer.Length; i++)
            {
                passwordBuffer[i] = (char)('a' + random.Next(0, 26));
            }
            String password = new String(passwordBuffer);
            Console.Write(password);

        }
        #endregion
    }
}
