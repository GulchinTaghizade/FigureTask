using System;
namespace FigureApp
{
    [Serializable()]

    public class Circle : Figure
    {
        public double Radius { get; set; }
        public Circle(List<Point> points) : base(points)
        {
            FindRadius();
        }

        public void FindRadius()
        {
            this.Radius = MathHelper.FindSide(Points);

        }

        public override void FindArea()
        {
            this.Area = Math.PI * Radius * Radius;
        }

        public override void FindPerimeter()
        {
            this.Perimeter = 2 * Math.PI * Radius;
        }

        public override void MoveFigure(double x, double y)
        {
            this.Center.CoordinateX = Center.CoordinateX + x;
            this.Center.CoordinateY = Center.CoordinateX + y;
        }

        public override void ScaleFigure(double scale)
        {
            Radius = Radius * scale;
            this.FindPerimeter();
            this.FindArea();
        }

        public override void FindCenter()
        {
            Center = new Point(Points[0].CoordinateX, Points[0].CoordinateY);

        }
        public override string ToString()
        {
            return $"{nameof(Circle)} Points: ({Points[0].CoordinateX},{Points[0].CoordinateY}),({Points[1].CoordinateX},{Points[1].CoordinateY})  Radius: {Radius} Area:{Area} Perimeter:{Perimeter} Center:({Center.CoordinateX};{Center.CoordinateY})\n";
        }
    }
}

