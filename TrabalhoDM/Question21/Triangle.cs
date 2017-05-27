using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoDM.spaceQuestion21
{
    class Triangle : Shape
    {

        public Triangle(int Width, int Height): base(Width, Height) { }


        public override double CalculateSurface()
        {
            return Height * Width / 2;
        }
    }
}
