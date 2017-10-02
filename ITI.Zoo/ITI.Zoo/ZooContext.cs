using System;
using System.Collections.Generic;
using System.Linq;
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

        public void CreateCat(string name)
        {
            Cat cat = new Cat(name, 1.0, 1.0, new Position(0.0, 0.0));
            _cats.Add(name, cat);
        }

        public Cat FindCatByName(string name)
        {
            return _cats[name];
        }

        public void CreateBird(string name)
        {
            Bird bird = new Bird(name, 1.0, 1.0, false, new Position(0.0, 0.0));
            _birds.Add(name, bird);
        }

        public Bird FindBirdByName(string name)
        {
            return _birds[name];
        }
    }
}
