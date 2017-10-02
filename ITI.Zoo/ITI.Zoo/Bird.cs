using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Zoo
{
    public class Bird
    {
        ZooContext _ctx;
        string _name;
        double _health;
        readonly double _speed;
        bool _isFlying;
        Position _position;

        internal Bird(ZooContext ctx, string name, double health, double speed, bool isFlying, Position position)
        {
            _ctx = ctx;
            _name = name;
            _health = health;
            _speed = speed;
            _isFlying = isFlying;
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

        public bool IsFlying
        {
            get { return _isFlying; }
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
