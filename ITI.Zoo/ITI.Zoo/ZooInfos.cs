using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Zoo
{
    public class ZooInfos
    {
        public ZooInfos()
        {
            MinCatSpeed = 35000;
            MaxCatSpeed = 45000;
            MinBirdSpeed = 45000;
            MaxBirdSpeed = 55000;
            Size = 1000;
        }

        public double MinCatSpeed { get; set; }

        public double MaxCatSpeed { get; set; }

        public double MinBirdSpeed { get; set; }

        public double MaxBirdSpeed { get; set; }

        public double Size { get; set; }
    }
}
