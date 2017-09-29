using System;

namespace ITI.GameOfLife
{
    public class Game
    {
        readonly int _width;
        readonly int _height;
        bool[] _cells;

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
            SetState(x, y, isAlive, _cells);
        }

        void SetState(int x, int y, bool isAlive, bool[] cells)
        {
            cells[GetCellIndex(x, y)] = isAlive;
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

        bool IsInGrid(int x, int y)
        {
            return 0 <= x && x < Width && 0 <= y && y < Height;
        }

        public bool NextTurn()
        {
            bool[] newCells = new bool[Width * Height];
            Array.Copy(_cells, newCells, newCells.Length);

            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    bool isAlive = DeadOrAlive(x, y);
                    SetState(x, y, isAlive, newCells);
                }
            }

            _cells = newCells;
            return true;
        }

        bool DeadOrAlive(int x, int y)
        {
            int aliveCount = 0;
            for (int i = x - 1; i < x + 2; i++)
            {
                for (int j = y - 1; j < y + 2; j++)
                {
                    if (!IsMe(x, y, i, j) && IsInGrid(i, j) && IsAlive(i, j)) aliveCount++;
                }
            }

            bool current = IsAlive(x, y);
            if (aliveCount == 2) return current;
            if (aliveCount == 3) return true;
            return false;
        }

        bool IsMe(int x1, int y1, int x2, int y2)
        {
            return x1 == x2 && y1 == y2;
        }
    }
}
