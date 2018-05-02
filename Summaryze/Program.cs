using System;
using System.Collections.Generic;

namespace Summaryze
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence =
                "This is going to be an extremely long, really, really extremeley long sentence with lots and lots of words, tokens, numbers etc.";
            Console.WriteLine(SummarizeText(sentence));
            Console.WriteLine(SummarizeText(sentence, 40));
            Console.WriteLine(SummarizeText(sentence, 10));

        }

        static string SummarizeText(string text, int maxL = 25)
        {
            //var maxL = 20;
            if (text.Length < maxL)
                //Console.WriteLine(text);
                return text;
            else
            {
                var words = text.Split(' ');
                var totalCharacters = 0;
                var summaryWords = new List<string>();

                foreach (var word in words)
                {
                    summaryWords.Add(word);
                    totalCharacters += word.Length + 1;
                    if (totalCharacters > maxL)
                        break;
                    ;
                }
                //var summary = string.Join(" ", summaryWords) + " ...";
                // Console.WriteLine(summary);
                return string.Join(" ", summaryWords) + " ...";

            }
        }
    }
}
