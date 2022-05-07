using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummarisingTextDemo
{
    public class StringUtility
    {
        public static String SummarizeText(String text, int maxLength = 20)
        {
            if (text.Length < maxLength)
            {
                return text;
            }

            String[] words = text.Split(' ');
            var totalCharacters = 0;
            List<String> summaryWords = new List<string>();
            foreach (var word in words)
            {
                summaryWords.Add(word);
                totalCharacters = totalCharacters + word.Length + 1;
                if (totalCharacters > maxLength)
                {
                    break;
                }
            }

            String summary = String.Join(" ", summaryWords) + "...";
            return summary;
        }
    }
}
