using System;

namespace ITI.Zoo
{
    public class Vector
    {
        readonly double _x;
        readonly double _y;

        public Vector(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public double X
        {
            get { return _x; }
        }

        public double Y
        {
            get { return _y; }
        }

        public Vector Add(Vector v)
        {
            return new Vector(_x + v._x, _y + v._y);
        }

        public Vector Mult(double n)
        {
            return new Vector(_x * n, _y * n);
        }

        public Vector Limit(double xMin, double yMin, double xMax, double yMax)
        {
            return new Vector(Math.Max(xMin, Math.Min(xMax, _x)), Math.Max(yMin, Math.Min(yMax, _y)));
        }
    }
}
