using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Zoo
{
    public class Cat
    {
        string _name;
        double _health;
        readonly double _speed;
        Position _position;

        internal Cat(string name, double health, double speed, Position position)
        {
            _name = name;
            _health = health;
            _speed = speed;
            _position = position;
        }

        public string Name
        {
            get { return _name; }
            set { throw new NotImplementedException(); }
        }

        public double Health
        {
            get { return _health; }
        }

        public double Speed
        {
            get { return _speed; }
        }

        public Position Position
        {
            get { return _position; }
        }

        public bool IsAlive
        {
            get { return _health > 0; }
        }
    }
}
