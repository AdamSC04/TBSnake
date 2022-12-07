using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBSnake
{
    internal class Game
    {
        private Snake snake;
        public List<Point> _grid;
        public int _gridSize;

        public Game(int gridSize)
        {
            _gridSize = gridSize;
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
                    Console.Write(_grid[counter]);
                    counter++;
                }
                Console.WriteLine();
            }
        }
        // Spel loop
        public void Run()
        {
            int gridSize = int.Parse(Console.ReadLine());

            Game game = new Game(gridSize);
            game.CreateBoard();
        }
    }
}
