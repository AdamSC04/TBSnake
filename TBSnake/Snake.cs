using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBSnake
{
    internal class Snake
    {
        public int length, x, y,direction;
        List<Point> body;

        public Snake(int x, int y)
        {
            length = 1;
            this.x = x;
            this.y = y;
            direction = 0;
            body = new List<Point>() { new Point(x, y) };
        }

        public void HandleInput(ConsoleKey key)
        {   
            switch(key)
            {
                case ConsoleKey.RightArrow:
                    direction = 0;
                    break;
                case ConsoleKey.DownArrow:
                    direction = 1;
                    break;
                case ConsoleKey.LeftArrow:
                    direction = 2;
                    break;
                case ConsoleKey.UpArrow:
                    direction = 3;
                    break;
                default:
                    break;
            }
        }

        public void Step()
        {
            switch (direction)
            {
                case 0:
                    x++;
                    break;
                case 1:
                    y--;
                    break;
                case 2:
                    x--;
                    break;
                case 3:
                    y++;
                    break;
            }
        }

        public void DrawStep()
        {

        }

        public bool IsColliding()
        {
            foreach (Point point in body)
            {
                if (point.X == x && point.Y == y)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

