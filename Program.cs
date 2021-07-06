using System;
using System.Collections.Generic;

namespace CamelCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            int result = camelCase(s);
            Console.WriteLine(result);
        }

        private static int camelCase(string s)
        {
            List<string> wordList = new List<string>();
            int wordCount = 0;

            for (int i = 0; i < s.Length-1; i++)
            {
                if (char.IsUpper(s[i]))
                {
                    wordCount++;
                }
            }

            return wordCount + 1;
        }
    }
}
