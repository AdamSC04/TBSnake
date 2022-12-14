using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TBSnake
{
    class Game
    {
        public Snake snake;
        public List<Point> _grid;
        public int _gridSize;

        public Game()
        {
            snake = new Snake(10, 10);
            _gridSize = 10;
        }

        public void CreateBoard()
        {
            _grid = new List<Point>();
            int counter = 0;
            for (int y = 0; y < _gridSize; y++)
            {
                for (int x = 0; x < _gridSize; x++)
                {
                    Point point = new Point(x, y);
                    _grid.Add(point);
                    //Console.Write(_grid[counter]);
                    counter++;
                }
                //Console.WriteLine();
            }
        }

        public bool InBounds()
        {
            if (snake._x == 0 || snake._y == 0 || snake._x == _gridSize || snake._y == _gridSize)
            {
                return true;
            }
            else { return false; }
        }

        public void Run()
        {
            while (true)
            {
                Console.CursorVisible = false;
                while (Console.KeyAvailable)
                {
                    ConsoleKey key = Console.ReadKey(true).Key;
                    snake.HandleInput(key);
                }
                snake.Step();
                snake.DrawStep();
                Thread.Sleep(100);
            }
        }
    }
}
