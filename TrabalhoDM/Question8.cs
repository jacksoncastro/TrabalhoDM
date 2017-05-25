using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoDM
{
    class Question8 : Question
    {
        const int SIZE_ARRAY = 20;
        const int MULTIPLICATOR = 6;
        public void Execute()
        {
            int[] array = new int[SIZE_ARRAY];
            for (int i=0; i < array.Length; i++)
            {
                array[i] = i * MULTIPLICATOR;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("{0} => {1}", i, array[i]);
            }
            Console.WriteLine();
        }
    }
}
