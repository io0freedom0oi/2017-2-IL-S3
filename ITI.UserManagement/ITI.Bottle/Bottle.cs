using System;
using System.Collections.Generic;
using System.Text;

namespace ITI
{
    public class Bottle
    {
        readonly int _cap;
        int _currentVolume;

        /// <summary>
        /// Initializes a new bottle with a capacity and
        /// an initial volume.
        /// All volumes are in milliliters.
        /// </summary>
        /// <param name="capacity">The bottle capacity.</param>
        /// <param name="initialVolume">The initial volume.</param>
        public Bottle(int capacity, int initialVolume)
        {
            _cap = capacity;
            _currentVolume = initialVolume;
        }

        /// <summary>
        /// Gets the capacity in milliliter.
        /// </summary>
        public int Capacity
        {
            get { return _cap; }
        }

        public int Volume
        {
            get { return _currentVolume; }
            set { _currentVolume = value; }
        }
    }
}
