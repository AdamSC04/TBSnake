using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TBSnake
{
    internal class Snake
    {
        public int _length, _x, _y, _direction;
        public List<Point> _body;
        //Skapa game objekt

        public Snake(int gridSize_x, int gridSize_y) //spawn snake
        {
            _length = 3;
            _x = gridSize_x / 2;
            _y = gridSize_y / 2;
            _direction = 0;
            _body = new List<Point>() { new Point(gridSize_x, gridSize_y) };
        }

        public void HandleInput(ConsoleKey key) // input change to numbers
        {   
            switch(key)
            {
                case ConsoleKey.RightArrow:
                    if (_direction == 2)
                    {
                        break;
                    }
                    _direction = 0;
                    break;
                case ConsoleKey.DownArrow:
                    if (_direction == 1)
                    {
                        break;
                    }
                    _direction = 3;
                    break;
                case ConsoleKey.LeftArrow:
                    if (_direction == 0)
                    {
                        break;
                    }
                    _direction = 2;
                    break;
                case ConsoleKey.UpArrow:
                    if (_direction == 3)
                    {
                        break;
                    }
                    _direction = 1;
                    break;
                default:
                    break;
            }
        }

        public void Step() // speed 
        {
            switch (_direction)
            {
                case 0:
                    _x++;
                    break;
                case 1:
                    _y--;
                    break;
                case 2:
                    _x--;
                    break;
                case 3:
                    _y++;
                    break;
            }
        }

        public void DrawStep() // snake body and movement
        {
            Console.SetCursorPosition(_x, _y);
            Console.Write("#");
            Console.SetCursorPosition(_body.Last().X, _body.Last().Y);
            Console.Write(" ");
            _body.Insert(0, new Point(_x, _y)); 
            if (_length < _body.Count)
            {
                _body.RemoveAt(_length);
            }
        }
        public bool IsOverlapping(Point point)
        {
            foreach (Point p in _body)
            {
                if (p == point) return true;
            }
            return false;
        }
    }
}

