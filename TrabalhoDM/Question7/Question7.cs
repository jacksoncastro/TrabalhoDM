using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoDM
{
    class Question7 : Question
    {
        public void Execute()
        {
            try
            {
                Console.WriteLine("Digite o tamanho da matriz a ser criada");
                int sizeMatriz = Int32.Parse(Console.ReadLine());
                if (sizeMatriz < 1 || sizeMatriz > 19)
                {
                    throw new ArgumentOutOfRangeException("Valor inválido para matriz, que deve ser entre 1 e 20");
                }
                int[,] matriz = new int[sizeMatriz, sizeMatriz];
                for (int i=1; i <= sizeMatriz; i++)
                {
                    for (int j=i; j < sizeMatriz + i; j++)
                    {
                        Console.Write(j + "\t");
                    }
                    Console.WriteLine();
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
    }
}
