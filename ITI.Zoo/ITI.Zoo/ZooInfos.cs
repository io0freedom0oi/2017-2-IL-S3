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
            BirdFlyingThreshold = 0.8;
            BirdLandingThreshold = 0.2;
            BirdRecoverySpeed = 0.05;
            CatRecoverySpeed = 0.5;
            CatExhaustionSpeed = 0.02;
        }

        public double MinCatSpeed { get; set; }

        public double MaxCatSpeed { get; set; }

        public double MinBirdSpeed { get; set; }

        public double MaxBirdSpeed { get; set; }

        public double Size { get; set; }

        public double BirdFlyingThreshold { get; set; }

        public double BirdLandingThreshold { get; set; }

        public double BirdRecoverySpeed { get; set; }

        public double CatRecoverySpeed { get; set; }

        public double CatExhaustionSpeed { get; set; }
    }
}
