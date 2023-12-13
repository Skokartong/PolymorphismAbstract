using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAbstract
{
    // Inheritance
    class Circle : Geometry
    {
        public Circle()
        {
            Radius = 4;
        }

        // Each subclass implements its own version of the shared 'Area' method
        public override void Area()
        {
            Result = Math.PI * Radius * Radius;
            Console.WriteLine("The area of the circle is: " + Result);
        }
    }
}
