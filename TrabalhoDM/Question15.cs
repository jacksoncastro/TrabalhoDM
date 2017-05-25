using System;

namespace TrabalhoDM
{
    internal class Question15 : Question
    {
        public void Execute()
        {
            try
            {
                Console.WriteLine("Digite o primeiro número:");
                int firstNumber = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo número:");
                int secondNumber = Int32.Parse(Console.ReadLine());

                double division = firstNumber / secondNumber;
                Console.WriteLine("A divisão de {0} por {1} é {2}", firstNumber, secondNumber, division);
            } catch(FormatException)
            {
                Console.WriteLine("Número inválido");
            } catch (DivideByZeroException)
            {
                Console.WriteLine("Divisão por zero não é permitido");
            } catch (Exception)
            {
                Console.WriteLine("Um erro desconhecido aconteceu");
            }
        }
    }
}