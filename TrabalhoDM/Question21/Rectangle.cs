using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoDM.spaceQuestion21
{
    public class Rectangle : Shape
    {

        public Rectangle(int Width, int Height): base(Width, Height) { }

        public override double CalculateSurface()
        {
            return Height * Width;
        }
    }
}
