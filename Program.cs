using System;
using System.Collections.Generic;
using System.Text;

namespace CamelCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            int result = camelCase2(s);
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


        private static int camelCase2(string str)
        {
            StringBuilder sb = new StringBuilder();
            //sb.Append(str[0]);

            List<char> items = new List<char>();
           

            for (int i = 1; i < str.Length - 1; i++)
            {
                if (char.IsPunctuation(str[i]) || char.IsWhiteSpace(str[i]))
                {

                    items.Add(str[i]);        
                }
            }

            char[] pattern = items.ToArray();
            var temp = str.Split(pattern);
            sb.Append(temp[0]);

            for(int i = 1; i < temp.Length; i++)
            {
                string camelCaseItem = temp[i][0].ToString().ToUpper();
                for(int j = 1; j < temp[i].Length; j++)
                {
                    camelCaseItem += temp[i][j].ToString().ToLower();
                }

                sb.Append(camelCaseItem);
            }

            var result = sb.ToString();
            return 0;
        }
    }
}
