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
            throw new System.NotImplementedException();
        }

        public Vector Mult(double n)
        {
            throw new System.NotImplementedException();
        }
    }
}
