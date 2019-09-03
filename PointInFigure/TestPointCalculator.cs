using System;

namespace PointInFigure
{
    class TestPointCalculator
    {
        static void Main(string[] args)
        {
            PointCalculator.FindPointPlace(2, 3, 10);
            PointCalculator.FindPointPlace(2, 3, 1);
            PointCalculator.FindPointPlace(2, 2, 2);
            PointCalculator.FindPointPlace(2, 6, 0);
            PointCalculator.FindPointPlace(2, 0, 6);
            PointCalculator.FindPointPlace(15, 13, 55);
            PointCalculator.FindPointPlace(15, 29, 37);
            PointCalculator.FindPointPlace(15, 37, 18);
            PointCalculator.FindPointPlace(15, -4, 7);
            PointCalculator.FindPointPlace(15, 30, 0);
        }
    }
}
