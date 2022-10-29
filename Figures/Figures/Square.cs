using System;
using FigureApp;
using System.Reflection.Metadata;

namespace FigureApp
{
    public class Square:FigureWithSides
    {
        public Square(List<Point> points, List<double> sides = null) : base()
        {
            Sides = sides;
            Points = points;
            FindArea();
            FindPerimeter();
            FindCenter();
        }

        
        public override void FindArea()
        {
            this.Area= Sides[0] * Sides[0];
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
            return $"{nameof(Square)}\nSide:{Sides[0]}\nArea:{Area}\nPerimeter:{Perimeter}\nCenter:({Center.CoordinateX};{Center.CoordinateY})\n";
        }
    }
}

