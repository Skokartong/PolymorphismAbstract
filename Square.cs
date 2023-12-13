using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAbstract
{
    class Square : Geometry
    {
        public Square()
        {
            Width = 5;
        }

        public override void Area()
        {
            Result = Width * Width;
            Console.WriteLine("The area of the square is: " + Result);
        }
    }
}
