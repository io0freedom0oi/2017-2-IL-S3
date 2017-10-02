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

        public ZooContext()
        {
            _cats = new Dictionary<string, Cat>();
            _birds = new Dictionary<string, Bird>();
        }

        public Cat FindOrCreateCat(string name)
        {
            Cat cat;
            if (!_cats.ContainsKey(name))
            {
                cat = new Cat(name, 1.0, 1.0, new Position(0.0, 0.0));
                _cats.Add(name, cat);
            }
            else
            {
                cat = _cats[name];
            }

            return cat;
        }

        public Bird FindOrCreateBird(string name)
        {
            Bird bird;
            if (!_birds.ContainsKey(name))
            {
                bird = new Bird(name, 1.0, 1.0, false, new Position(0.0, 0.0));
                _birds.Add(name, bird);
            }
            else
            {
                bird = _birds[name];
            }

            return bird;
        }
    }
}
