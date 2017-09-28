using System;

namespace ITI.GameOfLife
{
    public class Game
    {
        readonly int _width;
        readonly int _height;
        readonly bool[] _cells;

        public Game(int width, int height)
        {
            if (width <= 0) throw new ArgumentException("The width must be greater than 0.", nameof(width));
            if (height <= 0) throw new ArgumentException("The height must be greater than 0.", nameof(height));

            _width = width;
            _height = height;
            _cells = new bool[width * height];
        }

        public int Width
        {
            get { return _width; }
        }

        public int Height
        {
            get { return _height; }
        }

        public bool IsAlive(int x, int y)
        {
            CheckCoordinates(x, y);
            return _cells[GetCellIndex(x, y)];
        }

        public void GiveLife(int x, int y)
        {
            CheckCoordinates(x, y);
            SetState(x, y, true);
        }

        public void Kill(int x, int y)
        {
            CheckCoordinates(x, y);
            SetState(x, y, false);
        }

        void SetState(int x, int y, bool isAlive)
        {
            _cells[GetCellIndex(x, y)] = isAlive;
        }

        int GetCellIndex(int x, int y)
        {
            return x + y * Width;
        }

        void CheckCoordinates(int x, int y)
        {
            if (0 > x || x >= Width) throw new ArgumentException("X must be between 0 and width.", nameof(x));
            if (0 > y || y >= Height) throw new ArgumentException("Y must be between 0 and width.", nameof(y));
        }

        public bool NextTurn()
        {
            throw new System.NotImplementedException();
        }
    }
}
