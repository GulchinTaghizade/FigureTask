namespace FigureApp
{
    internal static class MathHelper
    {
        public static double FindSide(List<Point> points)
        {
            double lengthX = (points[1].CoordinateX - points[0].CoordinateX);
            double lengthY = (points[1].CoordinateY - points[0].CoordinateY);
            return Math.Sqrt(lengthX * lengthX + lengthY * lengthY);
        }

        public static List<double> FindAllSides(List<Point> points)
        {
            List<double> sides = new();
            for (int i = 0; i < points.Count(); i++)
            {
                if (i == points.Count() - 1)
                {
                    sides.Add(FindSide(new List<Point> { points[i], points[0] }));
                }
                else sides.Add(FindSide(new List<Point> { points[i], points[i + 1] }));
            }
            return sides;
        }
    }
}
