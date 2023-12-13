using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAbstract
{
    class Ellipse : Geometry
    {
        public Ellipse()
        {
            Width = 3;
            Height = 2;
        }

        public override void Area()
        {
            Result = Width * Height * Math.PI;
            Console.WriteLine("The area of the ellipse is: " + Result);
        }
    }
}
