﻿using System;
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
            _snake = new Snake(10, 10);
            _apple = new Apple(this);
            _gridSize = 10;
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

        public void Run()
        {
            _apple.GenerateApple(_gridSize);
            _apple.DrawApple();
            while (true)
            {
                while (Console.KeyAvailable)
                {
                    Console.CursorVisible = false;
                    ConsoleKey key = Console.ReadKey(true).Key;
                    _snake.HandleInput(key);
                }
                if(_snake.IsOverlapping(_apple._pos))
                {
                    _apple.GenerateApple(_gridSize);
                    _apple.DrawApple();
                    _snake._length = _snake._length + 1;
                }
                _snake.Step();
                _snake.DrawStep();
                Thread.Sleep(100);
            }
        }
    }
}
