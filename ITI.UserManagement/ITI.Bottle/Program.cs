using System;

namespace ITI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var b = new Bottle(500, 133);

            b.Volume = 54;

            Console.WriteLine(b.Capacity);
            Console.WriteLine(b.Volume);


            //b.Capacity = 67;
            b.Volume = 7676;

            Console.ReadLine();
        }
    }
}
