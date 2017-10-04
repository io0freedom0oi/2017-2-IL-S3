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
                return;
            }

            Bird bird = ClosestBird();
            if (bird != null)
            {
                if (GetDistanceTo(bird.Position) <= _speed)
                {
                    _position = bird.Position;
                    bird.Kill();
                    _health = Math.Min(1.0, _health + _ctx.Infos.CatRecoverySpeed);
                }
                else
                {
                    Vector direction = DirectionTo(bird.Position);
                    _position = _position.Add(direction.Mult(_speed));
                    _position = _position.Limit(-1, -1, 1, 1);
                    _health -= _ctx.Infos.CatExhaustionSpeed;
                }
            }
        }

        Vector DirectionTo(Vector destination)
        {
            double h = GetDistanceTo(destination);
            double o = destination.Y - Y;
            double sin = o / h;
            double alpha = Math.Asin(sin);

            return new Vector(Math.Sin(alpha), Math.Cos(alpha));
        }

        Bird ClosestBird()
        {
            Bird closest = null;
            double shortestDistance = double.MaxValue;

            foreach(Bird bird in _ctx.Birds)
            {
                double distance = GetDistanceTo(bird.Position);
                if (distance < shortestDistance)
                {
                    closest = bird;
                    shortestDistance = distance;
                }
            }

            return closest;
        }

        double GetDistanceTo(Vector destination)
        {
            return Math.Sqrt(Math.Pow(destination.X - X, 2) + Math.Pow(destination.Y - Y, 2));
        }
    }
}
