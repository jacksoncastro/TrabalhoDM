using System;

namespace TrabalhoDM
{
    class Question5 : Question
    {
        public void Execute()
        {
            try
            {
                Console.WriteLine("Digite a quantidade de números a serem testados:");
                int sizeList = Int32.Parse(Console.ReadLine());
                if (sizeList < 1)
                {
                    throw new ArgumentOutOfRangeException("Valor inválido para um tamanho");
                }
                int higherNumber = Int32.MinValue;
                int smallerNumber = Int32.MaxValue;

                for (int i = 1; i <= sizeList; i++)
                {
                    Console.Write("Digite o {0}º número: ", i);
                    int number = Int32.Parse(Console.ReadLine());
                    if (number > higherNumber)
                    {
                        higherNumber = number;
                    }
                    if (number < smallerNumber)
                    {
                        smallerNumber = number;
                    }
                }
                Console.WriteLine("O maior número digitado foi {0}", higherNumber);
                Console.WriteLine("O menor número digitado foi {0}", smallerNumber);
            }
            catch (FormatException)
            {
                Console.WriteLine("Número digitado é invalido");
            } catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
