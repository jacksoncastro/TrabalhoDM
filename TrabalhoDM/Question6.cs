using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoDM
{
    class Question6 : Question
    {
        public void Execute()
        {
            try
            {
                Console.WriteLine("Digite a quantidade de termos a serem somados da sequência Fibonacci:");
                int sizeList = Int32.Parse(Console.ReadLine());
                if (sizeList < 1)
                {
                    throw new ArgumentOutOfRangeException("Valor inválido para um tamanho");
                }

                // Dado que a soma dos primeiros N termos da sequência Fibonacci pode ser dada pela formula:
                // F(m+2) - F(n+2) - 2, a onde m é a última posição e n a primeira
                // Podemos simplificar a formula para: F(m + 2) -1
                int sumFibonacci = Fibonacci(sizeList + 2) - 1;

                Console.WriteLine("A soma dos {0} termos é: {1}", sizeList, sumFibonacci);
            }
            catch (FormatException)
            {
                Console.WriteLine("Número digitado é invalido");
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }


        private int Fibonacci(int number)
        {
            if (number > 1)
            {
                return Fibonacci(number - 1) + Fibonacci(number - 2);
            }
            return number;
        }
    }
}
