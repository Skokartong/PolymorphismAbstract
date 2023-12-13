using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAbstract
{
    class Parallelogram : Geometry
    {
        public Parallelogram()
        {
            Width = 5;
            Height = 12;
        }
        public override void Area()
        {
            Result = Width * Height;
            Console.WriteLine("The area of the parallelogram is: " + Result);
        }
    }
}
