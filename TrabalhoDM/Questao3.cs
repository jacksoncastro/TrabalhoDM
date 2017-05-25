using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoDM
{
    class Questao3 : Question
    {
        public void Execute()
        {
            Console.WriteLine("Digite um escore entre 1 e 9:");

            try
            {
                int escore = Int32.Parse(Console.ReadLine());
                int multiplacator = 0;
                switch (escore)
                {
                    case (1):
                    case (2):
                    case (3):
                        {
                            multiplacator = 10;
                        }
                        break;
                    case (4):
                    case (5):
                    case (6):
                        {
                            multiplacator = 100;
                        }
                        break;
                    case (7):
                    case (8):
                    case (9):
                        {
                            multiplacator = 1000;
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("O número {0} está fora do range válido", escore);
                            break;
                        }
                }
                if (multiplacator != 0)
                {
                    int newNumberCalculate = escore * multiplacator;
                    Console.WriteLine("O novo número calculado foi: {0}", newNumberCalculate);
                }
            } catch(FormatException)
            {
                Console.WriteLine("Número digitado é invalido");
            }
        }
    }
}
