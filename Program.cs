using PolymorphismAbstract;
using System.Drawing;

namespace PolymorphismAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            // Five geometric objects of the base class 'Geometry' are created
            Circle circle = new Circle();
            Square square = new Square();
            Rectangle rectangle = new Rectangle();
            Ellipse ellipse = new Ellipse();
            Parallelogram parallelogram = new Parallelogram();

            // The subclasses of 'Geometry' are put in an array to iterate through their respective 'Area' methods
            Geometry[] geometric = { circle, square, rectangle, ellipse, parallelogram };

            foreach (Geometry geometri in geometric)
            {
                geometri.Area();
            }

            Console.ReadKey();
        }
    }
}