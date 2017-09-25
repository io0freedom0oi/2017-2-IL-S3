using System;
using System.Collections.Generic;
using System.Text;

namespace ITI
{
    public class Bottle
    {
        readonly int _capacity;
        int _currentVolume;

        /// <summary>
        /// Initializes a new bottle with a capacity and
        /// an initial volume.
        /// All volumes are in milliliters.
        /// </summary>
        /// <param name="capacity">The bottle capacity.</param>
        /// <param name="initialVolume">The initial volume.</param>
        public Bottle( int capacity, int initialVolume )
        {
            _capacity = capacity;
            _currentVolume = initialVolume;
        }

        /// <summary>
        /// Gets the capacity in milliliter.
        /// </summary>
        public int Capacity => _capacity;

        public int Volume
        {
            get { return _currentVolume; }
            set
            {
                if( value < 0 ) _currentVolume = 0;
                else if( value > _capacity ) _currentVolume = _capacity;
                else _currentVolume = value;
            }
        }

        public bool IsEmpty => _currentVolume == 0;

        public bool IsFull => _currentVolume == _capacity;

    }
}
