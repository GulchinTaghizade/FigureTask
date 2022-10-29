using System;
namespace FigureApp
{
    public class Point
    {
        public double CoordinateX { get; set; }
        public double CoordinateY { get; set; }

        public Point( double coordinateX, double CoordinateY)
        {
            this.CoordinateX = coordinateX;
            this.CoordinateY = CoordinateY;
        }
}
}

