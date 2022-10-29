using System;
namespace FigureApp.FigureFactory
{
    public class CircleCreator : ICreator
    {
        public Figure CreateFigure()
        {
                Console.WriteLine("Please insert the coordinates of circle:");
                Console.WriteLine("Coordinates of first point:");
                double x1 = Convert.ToDouble(Console.ReadLine());
                double y1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Coordinates of second point:");
                double x2 = Convert.ToDouble(Console.ReadLine());
                double y2 = Convert.ToDouble(Console.ReadLine());
                Circle circle = new Circle(new List<Point>()
    {
        new Point(x1,y1),
        new Point(x2,y2)
    });
                return circle;
            }
        }
    
}

