using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoDM.spaceQuestion21
{
    class Question21 : Question
    {
        public void Execute()
        {
            Shape[] figures = new Shape[] {
                new Circle(4),
                new Triangle(4, 5),
                new Rectangle(5, 3),
                new Circle(2),
                new Triangle(6, 7),
                new Rectangle(2, 5)
            };

            foreach (Shape shape in figures)
            {
                Console.WriteLine("A área do {0} é {1}", shape.GetType().Name, shape.CalculateSurface());
            }
        }
    }
}
