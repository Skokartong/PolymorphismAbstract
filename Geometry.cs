using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
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
