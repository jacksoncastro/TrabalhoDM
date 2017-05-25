using System;
using System.Text;
using TrabalhoDM.Extensions;

namespace TrabalhoDM
{
    internal class Question16 : Question
    {
        public void Execute()
        {
            StringBuilder builder = new StringBuilder("Será que o substring funciona?");
            StringBuilder substring = builder.Substring(11, 18);
            Console.WriteLine(substring);
        }
    }
}