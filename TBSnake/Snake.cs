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
        public int length, x, y, direction;
        List<Point> body;

        public Snake(int x, int y)
        {
            length = 1;
            this.x = x;
            this.y = y;
            direction = 0;
            body = new List<Point>();
        }

        public void HandleInput(ConsoleKey key)
        {

        }

        public void Step()
        {

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

