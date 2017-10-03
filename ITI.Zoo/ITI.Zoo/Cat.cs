using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Zoo
{
    public class Cat
    {
        Zoo _ctx;
        string _name;
        double _health;
        readonly double _speed;
        Vector _position;

        internal Cat(Zoo ctx, string name, double health, double speed, Vector position)
        {
            _ctx = ctx;
            _name = name;
            _health = health;
            _speed = speed;
            _position = position;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _ctx.OnRename(this, value);
                _name = value;
            }
        }

        public double Health
        {
            get { return _health; }
        }

        public double Speed
        {
            get { return _speed; }
        }

        public Vector Position
        {
            get { return _position; }
        }

        public double X
        {
            get { return _position.X; }
        }

        public double Y
        {
            get { return _position.Y; }
        }

        public bool IsAlive
        {
            get { return _health > 0; }
        }

        internal void Update()
        {
            if(!IsAlive)
            {
                _ctx.OnDie(this);
                _ctx = null;
            }
        }
    }
}
