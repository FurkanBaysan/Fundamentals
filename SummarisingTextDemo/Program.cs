using System;
using System.Collections.Generic;

namespace SummarisingTextDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is going to be a really really really " +
                           "really really long text";

            String summary = StringUtility.SummarizeText(sentence, 25);
            Console.WriteLine(summary);
        }
    }
}

