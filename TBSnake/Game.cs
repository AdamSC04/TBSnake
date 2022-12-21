using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TBSnake
{
    class Game
    {
        public Apple _apple;
        public Snake _snake;
        public List<Point> _grid; //DELETE
        public int _gridSize;

        public Game()
        {
            _snake = new Snake(6, 6);
            _apple = new Apple(this, _snake);
            _gridSize = 25;
        }

        public void CreateBoard() //DELETE _grid
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

        public void DrawBorder()
        {
            foreach (Point p in _grid)
            {
                if (p.X == _gridSize - 1)
                {
                    Console.SetCursorPosition(p.X, p.Y);
                    Console.Write("|");
                }

                if (p.Y == _gridSize - 1)
                {
                    Console.SetCursorPosition(p.X, p.Y);
                    Console.Write("-");
                }
            }
        }

        public bool InBounds()
        {
            if (_snake._x == 0 || _snake._y == 0 || _snake._x == _gridSize - 1 || _snake._y == _gridSize - 1)
            {
                return true;
            }
            else { return false; }
        }

        public void Run()
        {
            CreateBoard();
            DrawBorder();
            _apple.GenerateApple(_gridSize - 1);
            _apple.DrawApple();
            while (true)
            {
                Console.CursorVisible = false;
                while (Console.KeyAvailable)
                {
                    ConsoleKey key = Console.ReadKey(true).Key;
                    _snake.HandleInput(key);
                }
                if (_snake.IsOverlapping(_apple._pos))
                {
                    _apple.GenerateApple(_gridSize);
                    _apple.DrawApple();
                    _snake._length++;
                }
                if (InBounds())
                {
                    break; //Avslutar programmet
                }
                _snake.Step();
                _snake.DrawStep();
                Thread.Sleep(100);
            }
            Console.Clear();
            Console.WriteLine("Spelet Avslutades.");
            Console.WriteLine("Dina poäng: " + (_snake._length - 3));
        }
    }
}
