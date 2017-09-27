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
            if( capacity <= 0 ) throw new ArgumentException( "The capacity must be greater than 0.", nameof( capacity ) );
            if( initialVolume > capacity ) throw new ArgumentException( "The capacity must be lower or equal to the volume." );
            if( initialVolume < 0 ) throw new ArgumentException( "The initial volume must be greater or equal to 0.", nameof( initialVolume ) );

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
                if( value < 0 ) throw new ArgumentException( "The volume must be greater or equal to 0.", nameof( value ) );
                if( value > _capacity ) throw new ArgumentException( "The volume must be lower or equal to the capacity.", nameof( value ) );

                _currentVolume = value;
            }
        }

        public bool IsEmpty => _currentVolume == 0;

        public bool IsFull => _currentVolume == _capacity;

    }
}
