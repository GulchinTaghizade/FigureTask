using System;
namespace FigureApp.FigureFactory
{
    public class TriangleCreator : ICreator
    {
        public Figure CreateFigure()
        {
              Console.WriteLine("Please insert the coordinates of triangle:");
                Console.WriteLine("Coordinates of first edge:");
                double x1 = Convert.ToDouble(Console.ReadLine());
                double y1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Coordinates of second edge:");
                double x2 = Convert.ToDouble(Console.ReadLine());
                double y2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Coordinates of third edge:");
                double x3 = Convert.ToDouble(Console.ReadLine());
                double y3 = Convert.ToDouble(Console.ReadLine());
                List<Point> pointsOfTriangle = new()
    {
        new Point(x1, y1),
        new Point(x2, y2),
        new Point(x3, y3)
    };
                List<double> sidesOfTriangle = MathHelper.FindAllSides(pointsOfTriangle);
                Triangle triangle = new Triangle(pointsOfTriangle, sidesOfTriangle);
                return triangle;
            }
        }
    
}

