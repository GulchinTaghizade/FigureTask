using System;
namespace FigureApp.FigureFactory
{
    public class FigureFactory
    {
        public ICreator FigureeCreator(int num)
        {
            switch (num)
            {
                case 1:
                    return new SquareCreator();
                case 2:
                    return new RectangleCreator();
                case 3:
                    return new CircleCreator();
                case 4:
                    return new TriangleCreator();
                default:
                    return null;
            }
        }
    }
}

