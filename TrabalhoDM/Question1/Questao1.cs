using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoDM
{
    class Question1: Question
    {
        public void Execute()
        {
            string hello = "hello";
            string world = "world";

            object concat = hello + " " + world;
            string helloWorld = (string) concat;

            Console.WriteLine(helloWorld);
        }
    }
}
