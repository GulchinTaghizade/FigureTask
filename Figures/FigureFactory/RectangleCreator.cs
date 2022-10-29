using System;
namespace FigureApp.FigureFactory
{
    public class RectangleCreator:ICreator
    {

        public Figure CreateFigure()
        {
            Console.WriteLine("Please insert the coordinates of rectangle:");
            Console.WriteLine("Coordinates of first edge:");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Coordinates of second edge:");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Coordinates of second edge:");
            double x3 = Convert.ToDouble(Console.ReadLine());
            double y3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Coordinates of second edge:");
            double x4 = Convert.ToDouble(Console.ReadLine());
            double y4 = Convert.ToDouble(Console.ReadLine());
            List<Point> pointsOfRectangle = new()
    {
        new Point(x1, y1),
        new Point(x2, y2),
        new Point(x3, y3),
        new Point(x4, y4)
    };
            List<double> sidesOfRectangle = MathHelper.FindAllSides(pointsOfRectangle);
            Rectangle rectangle = new Rectangle(pointsOfRectangle, sidesOfRectangle);
            return rectangle;
        }
    }
}

