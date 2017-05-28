using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoDM.spaceQuestion21
{
    public class Circle : Shape
    {

        public Circle(int Height) : base(Height, Height) { }

        public override double CalculateSurface()
        {
            // A = π r²
            return Math.PI * Math.Pow(Height / 2 , 2);
        }
    }
}
