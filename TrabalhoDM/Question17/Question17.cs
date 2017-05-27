using System;
using System.Collections.Generic;
using TrabalhoDM.Extensions;

namespace TrabalhoDM
{
    internal class Question17 : Question
    {
        public void Execute()
        {
            IEnumerable<int> enumerable = new int[] { 3, 2, 1, 4 };
            Console.WriteLine("Somatório dos elementos: {0}", enumerable.Sum());
            Console.WriteLine("Produto dos elementos: {0}", enumerable.Product());
            Console.WriteLine("Menor dos elementos: {0}", enumerable.Min());
            Console.WriteLine("Maior dos elementos: {0}", enumerable.Max());
            Console.WriteLine("Média dos elementos: {0}", enumerable.Media());
        }
    }
}