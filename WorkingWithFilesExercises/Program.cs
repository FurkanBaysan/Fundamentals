using System;
using System.Collections.Generic;
using System.IO;

namespace WorkingWithFilesExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            String path = @"C:\Users\LENOVO\Desktop\C# Basics\Text\IntroducingMyself.txt";
            Console.WriteLine("Number of Words: " + FindNumberOfWords(path));
            Console.WriteLine("Longest Word: " + FindLongestWord(path));
        }

        public static int FindNumberOfWords(String text)
        {
            List<String> processingReadyList = new List<string>(File.ReadAllText(text).Split(' '));
            return processingReadyList.Count;
        }
        public static String FindLongestWord(String text)
        {
            List<String> processingReadyText = new List<string>(File.ReadAllText(text).Split(' '));

            String longestWord = "";
            foreach (string word in processingReadyText)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }
            return longestWord;
        }
    }
}
