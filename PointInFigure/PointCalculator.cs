using System;

namespace PointInFigure
{
    public class PointCalculator
    {
        public static void FindPointPlace(int h, int x, int y)
        {
            bool outRectangle1 = (x < 0 || x > 3 * h) || (y < 0 || y > h);
            bool outRectangle2 = (x < h || x > 2 * h) || (y < h || y > 4 * h);

            bool inRectangle1 = (x > 0 && x < h*3) && (y > 0 && y < h);
            bool inRectangle2 = (x > h && x < 2 * h) && (y > h && y < 4 * h);

            bool commmonBorder = (x > h && x < 2 * h) && y == h;

            if (outRectangle1 && outRectangle2)
            {
                Console.WriteLine("outside");
            }
            else if (inRectangle1 || inRectangle2 || commmonBorder)
            {
                Console.WriteLine("inside");
            }
            else
            {
                Console.WriteLine("border");
            }
        }
    }
}
