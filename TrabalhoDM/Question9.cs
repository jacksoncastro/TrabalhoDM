using System;


namespace TrabalhoDM
{
    class Question9 : Question
    {
        public void Execute()
        {
            try
            {
                Console.WriteLine("Digite o tamanho do array:");
                int sizeList = Int32.Parse(Console.ReadLine());
                if (sizeList < 1)
                {
                    throw new ArgumentOutOfRangeException("Valor inválido para um tamanho");
                }
                int[] array = ReadArray(sizeList);
                int[] greaterSequence = GreaterSequence(array);
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


        private int[] GreaterSequence(int[] array)
        {
            int[,] GreaterSequence = new int[array.Length, array.Length];
            for (int i= 0; i < array.Length; i++)
            {

            }
            return null;
        }


        private int[] ReadArray(int size)
        {
            int[] array = new int[size];
            for (int i=0; i < size; i++)
            {
                Console.WriteLine("Digite o {0}º número:", (i + 1));
                try
                {
                    array[i] = Int32.Parse(Console.ReadLine());
                } catch (FormatException)
                {
                    Console.WriteLine("Número inválido, digite um número válido");
                    i--;
                }
            }
            return array;
        }
    }
}
