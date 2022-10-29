namespace FigureApp
{
    public abstract class FigureWithSides : Figure
    {
        public List<double> Sides { get; set; }

        public override void FindPerimeter()
        {
            Perimeter = SumOfSides();
        }

        public double SumOfSides()
        {
            double SumOfSides = 0;
            for (int i = 0; i < Sides.Count; i++)
            {
                SumOfSides += Sides[i];
            }
            return SumOfSides;
        }

        public void RotateFigure(double degree)
        {
            foreach (var p in Points)
            {
                p.CoordinateX = p.CoordinateX * Math.Cos(degree) - p.CoordinateY * Math.Sin(degree);
                p.CoordinateY = p.CoordinateY * Math.Cos(degree) + p.CoordinateX * Math.Sin(degree);
            }
        }

        public override void ScaleFigure(double scale)
        {
            foreach (var p in Points)
            {
                p.CoordinateX = Center.CoordinateX - scale * (Center.CoordinateX - p.CoordinateX);
                p.CoordinateY = Center.CoordinateY - scale * (Center.CoordinateY - p.CoordinateY);
            }
            this.FindPerimeter();
            this.FindArea();

        }
        public override void MoveFigure(double x, double y)
        {

            foreach (var p in Points)
            {
                p.CoordinateX += x;
                p.CoordinateY += y;
            }
        }

        public override void FindCenter()
        {
            double sumX = 0, sumY = 0;
            foreach (var p in Points)
            {
                sumX += p.CoordinateX;
                sumY += p.CoordinateY;
            }
            Center = new Point(sumX / Sides.Count, sumY / Sides.Count);
        }
    }
}

