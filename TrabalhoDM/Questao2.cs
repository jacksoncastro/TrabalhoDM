using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoDM
{
    class Questao2 : Question

    {
        public void Execute()
        {
            int[] numbers = new int[5];
            for (int i=0; i < 5; i++)
            {
                Console.Write("Digite o {0}º número: ", i + 1);
                string readLine = Console.ReadLine();

                try
                {
                    numbers[i] = Int32.Parse(readLine);
                } catch (Exception)
                {
                    Console.WriteLine("Número inválido digitado, digite um número válido");
                    i--;
                }
            }
            Console.WriteLine("O maior número digitado foi {0}", getMaxNumber(numbers));
        }

        private int getMaxNumber(int[] numbers)
        {
            int maxNumber = numbers[0];
            for (int i = 1; i < 5; i++)
            {
                if (numbers[i] > maxNumber)
                {
                    maxNumber = numbers[i];
                }
            }
            return maxNumber;
        }
    }
}
