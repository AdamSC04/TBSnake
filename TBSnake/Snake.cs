﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBSnake
{
    internal class Snake
    {
        public int _length, _x, _y, _direction;
        public List<Point> _body;

        public Snake(int gridSize_x, int gridSize_y)
        {
            _length = 1;
            _x = gridSize_x / 2;
            _y = gridSize_y / 2;
            _direction = 0;
            _body = new List<Point>() { new Point(gridSize_x, gridSize_y) };
        }

        public void HandleInput(ConsoleKey key)
        {   
            switch(key)
            {
                case ConsoleKey.RightArrow:
                    _direction = 0;
                    break;
                case ConsoleKey.DownArrow:
                    _direction = 1;
                    break;
                case ConsoleKey.LeftArrow:
                    _direction = 2;
                    break;
                case ConsoleKey.UpArrow:
                    _direction = 3;
                    break;
                default:
                    break;
            }
        }

        public void Step()
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

        public void DrawStep(int gridSize, List<Point> grid)
        {
            foreach (Point point in _body)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    if (grid[j] == point)
                    {
                        Console.SetCursorPosition(point.X, point.Y);
                        Console.Write("O");
                        grid[j] = point; //Blir ju samma. //Ta bort? //Fixa så att den skriver ut endast detta istället för hela griden.
                    }
                }
            }
        }

        public bool IsColliding()
        {
            foreach (Point point in _body)
            {
                if (point.X == _x && point.Y == _y)
                {
                    return true;
                }
            }
            return false;
        }

        public void UpdateSnake()
        { //Olle //Här fixa snaken inför varje frame innan man använder DrawStep()

        }
    }
}

