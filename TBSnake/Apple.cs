using System;
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
        Snake _snake;

        public Apple(Game game, Snake snake)
        {
            _game = game;
            _pos = new Point();
            _rand = new Random();
            _snake = snake;
        }

        public void GenerateApple(int max)
        {
            do
            {
                int x = _rand.Next(1, max - 1);
                int y = _rand.Next(1, max - 1);
                while (_snake._x == x || _snake._y == y)
                {
                    x = _rand.Next(1, max - 1);
                    y = _rand.Next(1, max - 1);
                }
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
