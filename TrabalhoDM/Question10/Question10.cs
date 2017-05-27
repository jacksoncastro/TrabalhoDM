using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoDM
{
    class Question10 : Question
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

                ShowGreaterNumber(array);
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

        private void ShowGreaterNumber(int[] array)
        {
            Dictionary<int, int> greaterMap = new Dictionary<int, int>();
            foreach (int number in array)
            {
                if (greaterMap.ContainsKey(number)) {
                    int count = greaterMap[number];
                    greaterMap[number] = count + 1;
                } else
                {
                    greaterMap[number] = 1;
                }
            }

            KeyValuePair<int, int> orderedMap = greaterMap.OrderBy(data => data.Value).Last();

            Console.WriteLine("O número {0} apareceu {1} vezes", orderedMap.Key, orderedMap.Value);
        }

        private int[] ReadArray(int size)
        {
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Digite o {0}º número:", (i + 1));
                try
                {
                    array[i] = Int32.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Número inválido, digite um número válido");
                    i--;
                }
            }
            return array;
        }
    }
}
