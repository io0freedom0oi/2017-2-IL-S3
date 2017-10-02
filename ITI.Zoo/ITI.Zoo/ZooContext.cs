using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Zoo
{
    public class ZooContext
    {
        readonly Dictionary<string, Cat> _cats;
        readonly Dictionary<string, Bird> _birds;
        readonly Random _random;
        readonly double _meterSize;

        public ZooContext()
            : this(1000.0)
        {
        }

        public ZooContext(double size)
        {
            _cats = new Dictionary<string, Cat>();
            _birds = new Dictionary<string, Bird>();
            _random = new Random();
            _meterSize = 1 / size / 2;
        }

        public Cat FindOrCreateCat(string name)
        {
            Cat cat;
            if(!_cats.TryGetValue(name, out cat))
            {
                cat = new Cat(this, name, 1.0, 1.0, RandomPosition());
                _cats.Add(name, cat);
            }

            return cat;
        }

        public Bird FindOrCreateBird(string name)
        {
            Bird bird;
            if (!_birds.TryGetValue(name, out bird))
            {
                bird = new Bird(this, name, 1.0, 1.0, false, RandomPosition());
                _birds.Add(name, bird);
            }

            return bird;
        }

        internal void OnRename(Cat cat, string newName)
        {
            if (_cats.ContainsKey(newName)) throw new ArgumentException("A cat with this name already exists.");
            _cats.Remove(cat.Name);
            _cats.Add(newName, cat);
        }

        internal void OnRename(Bird bird, string newName)
        {
            if (_birds.ContainsKey(newName)) throw new ArgumentException("A bird with this name already exists.");
            _birds.Remove(bird.Name);
            _birds.Add(newName, bird);
        }

        double RandomDouble(double min, double max)
        {
            return _random.NextDouble() * (max - min) + min;
        }

        Position RandomPosition()
        {
            return new Position(RandomDouble(-1.0, 1.0), RandomDouble(-1.0, 1.0));
        }
    }
}
