using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Zoo
{
    public class Zoo
    {
        readonly List<Cat> _deadCats;
        readonly List<Bird> _deadBirds;
        readonly Dictionary<string, Cat> _cats;
        readonly Dictionary<string, Bird> _birds;
        readonly Random _random;
        readonly double _meterDefinition;
        readonly ZooInfos _zooInfos;

        public Zoo()
            : this(new ZooInfos())
        {
        }

        public Zoo(ZooInfos zooInfos)
        {
            _deadBirds = new List<Bird>();
            _deadCats = new List<Cat>();
            _cats = new Dictionary<string, Cat>();
            _birds = new Dictionary<string, Bird>();
            _random = new Random();
            _meterDefinition = 1 / zooInfos.Size / 2;
            _zooInfos = zooInfos ?? new ZooInfos();
        }

        public Cat CreateCat(string name)
        {
            Cat cat;
            if (!_cats.TryGetValue(name, out cat))
            {
                double speed = RandomDouble(_zooInfos.MinCatSpeed, _zooInfos.MaxCatSpeed) / 3600;
                cat = new Cat(this, name, 1.0, speed * _meterDefinition, RandomPosition());
                _cats.Add(name, cat);
            }

            return cat;
        }

        public Bird CreateBird(string name)
        {
            Bird bird;
            if (!_birds.TryGetValue(name, out bird))
            {
                double speed = RandomDouble(_zooInfos.MinBirdSpeed, _zooInfos.MaxBirdSpeed) / 3600;
                bird = new Bird(this, name, 1.0, speed * _meterDefinition, false, RandomPosition());
                _birds.Add(name, bird);
            }

            return bird;
        }

        internal void OnDie(Cat cat)
        {
            _deadCats.Add(cat);
        }

        internal void OnDie(Bird bird)
        {
            _deadBirds.Add(bird);
        }

        public void Update()
        {
            _deadCats.Clear();
            _deadBirds.Clear();

            foreach (Cat cat in _cats.Values) cat.Update();
            foreach (Bird bird in _birds.Values) bird.Update();

            foreach (Cat cat in _deadCats) _cats.Remove(cat.Name);
            foreach (Bird bird in _deadBirds) _birds.Remove(bird.Name);
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

        internal double RandomDouble(double min, double max)
        {
            return _random.NextDouble() * (max - min) + min;
        }

        Vector RandomPosition()
        {
            return new Vector(RandomDouble(-1.0, 1.0), RandomDouble(-1.0, 1.0));
        }

        internal ZooInfos Infos
        {
            get { return _zooInfos; }
        }

        internal Vector RandomDirection()
        {
            double x = RandomDouble(-1.0, 1.0);
            double y = Math.Sqrt(1 - x * x);
            y = _random.NextDouble() < 0.5 ? y : -y;
            return new Vector(x, y);
        }

        public double MeterDefinition
        {
            get { return _meterDefinition; }
        }

        public List<Bird> Birds
        {
            get
            {
                List<Bird> birds = new List<Bird>();
                foreach (Bird bird in _birds.Values) birds.Add(bird);
                return birds;
            }
        }
    }
}
