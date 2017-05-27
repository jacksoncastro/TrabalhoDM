using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoDM.spaceQuestion21
{
    public abstract class Shape
    {
        public Shape(int Width, int Height)
        {
            this.Width = Width;
            this.Height = Height;
        }

        public int Width { get; set; }

        public int Height { get; set; }

        public abstract double CalculateSurface();
    }
}
