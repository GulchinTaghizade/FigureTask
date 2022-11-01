using System;
namespace FigureApp
{
    [Serializable()]

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
        public Triangle()
        {

        }
        

        public override void FindArea()
        {
            double sum = SumOfSides();
            double s = sum / 2;
            this.Area= Math.Sqrt(s * (s - Sides[0]) * (s - Sides[1]) * (s - Sides[2]));
        }
        
        public override string ToString()
        {
            return $"{nameof(Triangle)} Points: ({Points[0].CoordinateX},{Points[0].CoordinateY}),({Points[1].CoordinateX},{Points[1].CoordinateY}),({Points[2].CoordinateX},{Points[2].CoordinateY}) Sides: {Sides[0]}, {Sides[1]}, {Sides[2]} Area:{Area} Perimeter:{Perimeter} Center:({Center.CoordinateX};{Center.CoordinateY})\n";
        }
    }
}

