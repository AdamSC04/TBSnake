using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TBSnake
{
    internal class Program
    {

        protected class Snake
        {
            public int length, x, y, direction;
            List<Point> body;

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
                return false;
            }
        }

        protected class Game
        {
            private Snake snake;
            private int width, height;

            // Spel loop
            public void Run()
            {

            }
        }

        static void Main(string[] args)
        {

        }
    }
}
