using System;

namespace ITI.Geometry
{
    public class Segment
    {
        readonly int _length;
        int _start;

        public Segment(int start, int length)
        {
            _start = start;
            _length = Math.Abs(length);
        }

        public int Start
        {
            get { return _start; }
        }

        public int End
        {
            get { return _start + _length; }
        }

        public int Length
        {
            get { return _length; }
        }

        public void Move(int delta)
        {
            _start += delta;
        }

        public bool Contains(int point)
        {
            return Start <= point && point < End;
        }

        public bool EqualTo(Segment s)
        {
            return Start == s.Start && Length == s.Length;
        }

        public bool Overlaps(Segment s)
        {
            if (s.Start <= Start)
            {
                if (s.End <= Start) return false;
                return true;
            }

            return s.Overlaps(this);
        }
    }
}
