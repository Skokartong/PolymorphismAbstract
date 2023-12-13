using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAbstract
{
    public abstract class Geometry
    {
        // Shared properties across the classes
        public double Radius { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Result { get; set; }

        // Abstract method is used 
        public abstract void Area();
    }
}
