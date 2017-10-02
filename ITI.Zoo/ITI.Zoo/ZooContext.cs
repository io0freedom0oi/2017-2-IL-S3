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
            throw new NotImplementedException();
        }

        public Cat FindCatByName(string name)
        {
            throw new NotImplementedException();
        }

        public void CreateBird(string name)
        {
            throw new NotImplementedException();
        }

        public Bird FindBirdByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
