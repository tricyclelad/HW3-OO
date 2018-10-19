using System;

namespace Shapes
{
    public class Validator
    {
        public static void ValidateDouble(double value, string errorMessage)
        {
            if (double.IsInfinity(value) || double.IsNaN(value))
                throw new ShapeException(errorMessage);
        }

        public static void ValidatePositiveDouble(double value, String errorMessage) 
        {
                ValidateDouble(value, errorMessage);
                if (value<0)
                    throw new ShapeException(errorMessage);
        }
        public static bool AreLinesEqual(Line Line1, Line Line2)
        {
            if (ArePointsEqual(Line1.Point1, Line2.Point1) && ArePointsEqual(Line1.Point2, Line2.Point2))
                return true;
            return false;

        }
        public static bool ArePointsEqual(Point Point1, Point Point2)
        {
            if (Point1.X == Point2.X && Point1.Y == Point2.Y)
            {
                return true;
            }
            return false;

        }
        public static bool AreLineSlopesEqual(Line Line1, Line Line2)
        {
            if(Line1.ComputeSlope() == Line2.ComputeSlope())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool AreLineLengthsEqual(Line Line1, Line Line2)
        {
            if (Line1.ComputeLength() == Line2.ComputeLength())
                return true;
            return false;
        }
    }
}
