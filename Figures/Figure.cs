using System.IO;
using System.Xml.Serialization;

namespace FigureApp
{
    [Serializable()]
    public abstract class Figure
    {
        public double Area { get; protected set; }
        public double Perimeter { get; protected set; }
        public List<Point> Points { get; protected set; }
        public Point Center { get; protected set; }

        public Figure(List<Point> points)
        {
            Points = points;
            FindArea();
            FindPerimeter();
            FindCenter();
        }
        public Figure()
        {

        }

        public abstract void FindArea();
        public abstract void FindPerimeter();
        public abstract void FindCenter();
        public abstract void MoveFigure(double x, double y);
        public abstract void ScaleFigure(double scale);

    }
}

