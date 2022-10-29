using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace FigureApp
{
    [Serializable()]

    public class Rectangle:FigureWithSides
    {

        public Rectangle(List<Point> points, List<double> sides = null) :base()
        {
            Sides = sides;
            Points = points;
            FindArea();
            FindPerimeter();
            FindCenter();
        }

        public override void FindArea()
        {
            this.Area= Sides[0] * Sides[1];
        }

        public override void FindCenter()
        {
            double sumX = 0, sumY = 0;
            foreach (var p in Points)
            {
                sumX += p.CoordinateX;
                sumY += p.CoordinateY;
            }
            this.Center = new Point(sumX / 4, sumY / 4);
        }
        public override string ToString()
        {
            return $"{nameof(Rectangle)} Points:({Points[0].CoordinateX},{Points[0].CoordinateY}),({Points[1].CoordinateX},{Points[1].CoordinateY}),({Points[2].CoordinateX},{Points[2].CoordinateY}),({Points[3].CoordinateX},{Points[3].CoordinateY})  Sides: {Sides[0]}, {Sides[1]}, {Sides[2]} Area:{Area} Perimeter:{Perimeter} Center:({Center.CoordinateX};{Center.CoordinateY})\n";

        }

    }
}

