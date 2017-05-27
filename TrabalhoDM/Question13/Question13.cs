using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace TrabalhoDM
{
    internal class Question13 : Question
    {
        public void Execute()
        {
            Console.WriteLine("Digite um texto:");
            string text = Console.ReadLine();

            string pattern = "[.,\\/#!$%\\^&\\*;:{}=\\-_`~()?]";
            string replacement = " ";
            string result = Regex.Replace(text, pattern, replacement);
            Console.WriteLine(result);

            string[] split = result.Split(' ');

            Dictionary<string, int> counter = new Dictionary<string, int>();
            foreach (string word in split)
            {
                string wordTreated = word.Trim().ToLower();
                if (!wordTreated.Equals(""))
                {
                    if (counter.ContainsKey(wordTreated))
                    {
                        int count = counter[wordTreated];
                        counter[wordTreated] = count + 1;
                    } else
                    {
                        counter[wordTreated] = 1;
                    }
                }
            }
            counter = counter.OrderBy(data => data.Value).ToDictionary(x => x.Key, x => x.Value);
            foreach (KeyValuePair<string, int> count in counter)
            {
                Console.WriteLine("{0} => {1}", count.Key, count.Value);
            }
        }
    }
}