﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBSnake
{
    internal class Apple
    {
        public Point _pos;
        Random _rand;
        public Game _game;

        public Apple(Game game)
        {
            _game = game;
            _pos = new Point();
            _rand = new Random();
        }

        public void GenerateApple(int max)
        {
            do
            {
                int x = _rand.Next(0, max);
                int y = _rand.Next(0, max);
                _pos.X = x;
                _pos.Y = y;
            } while (_game._snake.IsOverlapping(_pos));
        }

        public void DrawApple()
        {
            Console.SetCursorPosition(_pos.X, _pos.Y);
            Console.Write("O");
        }
    }
}
