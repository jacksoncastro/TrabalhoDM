using System;

namespace TrabalhoDM
{
    internal class Question11 : Question
    {
        public void Execute()
        {
            char[] alphabet = new char[26];
            int i = 0;
            for (char letra = 'A';  letra <= 'Z'; letra++, i++)
            {
                alphabet[i] = letra;
            }

            Console.WriteLine("Digite uma palavra:");
            string word = Console.ReadLine();
            for (int j=0; j < word.Length; j++)
            {
                int indice = Array.IndexOf(alphabet, word[j].ToString().ToUpper().ToCharArray()[0]);
                Console.WriteLine("Letra {0} => {1}", word[j], indice);
            }
        }
    }
}