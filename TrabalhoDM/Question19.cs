using System;
using TrabalhoDM.Extensions;

namespace TrabalhoDM
{
    internal class Question19 : Question
    {
        public void Execute()
        {
            Console.WriteLine("Escreva um texto:");
            string text = Console.ReadLine();
            Console.WriteLine(text.ToCaptalize());

        }
    }
}