using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Zoo
{
    public class Bird
    {
        Zoo _ctx;
        string _name;
        double _health;
        readonly double _speed;
        bool _isFlying;
        Vector _position;

        internal Bird(Zoo ctx, string name, double health, double speed, bool isFlying, Vector position)
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

            if (_health <= _ctx.Infos.BirdLandingThreshold) _isFlying = false;
            if (_health >= _ctx.Infos.BirdFlyingThreshold) _isFlying = true;

            if(_isFlying)
            {
                _health -= _ctx.Infos.BirdRecoverySpeed;

                Vector direction = _ctx.RandomDirection();
                _position = _position.Add(direction.Mult(_speed));
                _position = _position.Limit(-1, -1, 1, 1);
            }
            else
            {
                _health += _ctx.Infos.BirdRecoverySpeed;
            }
        }

        internal void Kill()
        {
            throw new NotImplementedException();
        }
    }
}
