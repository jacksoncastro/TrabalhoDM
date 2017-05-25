using System;

namespace TrabalhoDM
{
    internal class Question14 : Question
    {
        public void Execute()
        {
            Console.WriteLine("Escreva um número inteiro:");
            try
            {
                int number = Int32.Parse(Console.ReadLine());
                if (number < 0) {// number negative
                    throw new FormatException();
                }
                double sqrt = Math.Sqrt(number);
                Console.WriteLine("Raiz quadrada de {0} é {1}", number, sqrt);
            } catch(FormatException)
            {
                Console.WriteLine("Número inválido");
            } finally
            {
                Console.WriteLine("Good Bye");
            }
        }
    }
}