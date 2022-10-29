﻿using System;
namespace FigureApp
{
    public class Triangle:FigureWithSides
    {

        public Triangle(List<Point> points, List<double> sides = null) :base()
        {
            Sides = sides;
            Points = points;
            FindArea();
            FindPerimeter();
            FindCenter();
        }

        

        public override void FindArea()
        {
            double sum = SumOfSides();
            double s = sum / 2;
            this.Area= Math.Sqrt(s * (s - Sides[0]) * (s - Sides[1]) * (s - Sides[2]));
        }
        
        public override string ToString()
        {
            return $"{nameof(Triangle)}\nSides: {Sides[0]}, {Sides[1]}, {Sides[2]}\nArea:{Area}\nPerimeter:{Perimeter}\nCenter:({Center.CoordinateX};{Center.CoordinateY})\n";
        }
    }
}

