using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAbstract
{
    class Rectangle : Geometry
    {
        public Rectangle()
        {
            Width = 4;
            Height = 6;
        }
        public override void Area()
        {
            Result = Width * Height;
            Console.WriteLine("The area of the rectangle is: " + Result);
        }
    }
}
