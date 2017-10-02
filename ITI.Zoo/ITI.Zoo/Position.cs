namespace ITI.Zoo
{
    public class Position
    {
        readonly double _x;
        readonly double _y;

        public Position(double x, double y)
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
    }
}
