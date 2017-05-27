using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoDM
{
    class Question4 : Question
    {
        public void Execute()
        {
            try
            {
                Console.WriteLine("Digite o maior número a ser testado:");
                int number = Int32.Parse(Console.ReadLine());
                for (int i=1; i <= number; i++)
                {
                    if (i % 3 != 0 || i % 7 != 0)
                    {
                        Console.Write(i + " ");
                    }
                }
                Console.WriteLine();
            } catch(FormatException)
            {
                Console.WriteLine("Número digitado é invalido");
            }
        }
    }
}
