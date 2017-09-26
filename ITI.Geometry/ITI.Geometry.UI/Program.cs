using System;

namespace ITI.Geometry.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Segment s1 = new Segment(3, 5);
            DisplaySegment(s1);

            s1.Move(4);
            DisplaySegment(s1);

            bool contains = s1.Contains(10);
            Console.WriteLine("Is (10) on segment ? {0}", contains);

            contains = s1.Contains(0);
            Console.WriteLine("Is (0) on segment ? {0}", contains);

            Segment s2 = new Segment(1, 7);
            bool areEqual = s1.EqualTo(s2);
            Console.WriteLine("[3, 8[ == [1, 8[ ? {0}", areEqual);

            Segment s3 = new Segment(1, 7);
            areEqual = s2.EqualTo(s3);
            Console.WriteLine("[1, 8[ == [1, 8[ ? {0}", areEqual);

            Segment s4 = new Segment(-2, 2);
            bool overlaps = s3.Overlaps(s4);
            Console.WriteLine("[1, 8[ overlaps [-2, 0[ ? {0}", overlaps);

            s4 = new Segment(-1, 11);
            overlaps = s3.Overlaps(s4);
            Console.WriteLine("[1, 8[ overlaps [-1, 10[ ? {0}", overlaps);

            s4 = new Segment(9, 2);
            overlaps = s3.Overlaps(s4);
            Console.WriteLine("[1, 8[ overlaps [9, 11[ ? {0}", overlaps);

            s4 = new Segment(6, 4);
            overlaps = s3.Overlaps(s4);
            Console.WriteLine("[1, 8[ overlaps [6, 10[ ? {0}", overlaps);

            s4 = new Segment(3, 1);
            overlaps = s3.Overlaps(s4);
            Console.WriteLine("[1, 8[ overlaps [3, 4[ ? {0}", overlaps);

            s4 = new Segment(-1, 3);
            overlaps = s3.Overlaps(s4);
            Console.WriteLine("[1, 8[ overlaps [-1, 2[ ? {0}", overlaps);
        }

        static void DisplaySegment(Segment s)
        {
            Console.WriteLine("Start: {0} - End: {1} - Length: {2}", s.Start, s.End, s.Length);
        }
    }
}
