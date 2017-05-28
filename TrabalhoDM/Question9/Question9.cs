using System;
using System.Collections.Generic;
using System.Linq;

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
                Dictionary<int, int[]> greaterSequence = GreaterSequence(array);

                greaterSequence = (from c in greaterSequence orderby c.Value.Length descending select c).ToDictionary(c => c.Key, c => c.Value);

                int maxSize = 0;
                foreach (KeyValuePair<int, int[]> greater in greaterSequence)
                {
                    if (greater.Value.Length > maxSize)
                    {
                        maxSize = greater.Value.Length;
                    }

                    if (greater.Value.Length == maxSize)
                    {
                        Console.WriteLine("Maior sequência:");
                        foreach(int number in greater.Value)
                        {
                            Console.Write(number);
                        }
                        Console.WriteLine();
                    }
                }
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


        private Dictionary<int, int[]> GreaterSequence(int[] array)
        {
            Dictionary<int, int[]> dictionary = new Dictionary<int, int[]>();
            int indexDictionary = 0;
            for (int i= 0; i < array.Length; i++)
            {
                int lastIndex = ExtractLastIndexSequence(i, array);
                dictionary[indexDictionary] = array.Skip(i).Take((lastIndex + 1) - i).ToArray();
                indexDictionary++;
                i = lastIndex;
            }
            return dictionary;
        }

        private int ExtractLastIndexSequence(int i, int[] array)
        {
            if (i < array.Length - 1 && array[i+1] == (array[i] + 1))
            {
                return ExtractLastIndexSequence(i+1, array);
            }
            return i;
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
