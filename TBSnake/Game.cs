using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBSnake
{
    internal class Game
    {
        private Snake snake;
        public List<Tuple<int, int>> _grid;
        public int _gridSize;

        public Game(int gridSize)
        {
            _gridSize = gridSize;
        }

        public void CreateBoard()
        {
            _grid = new List<Tuple<int, int>>();
            int counter = 0;
            for (int y = 0; y < _gridSize; y++)
            {
                for (int x = 0; x < _gridSize; x++)
                {
                    Tuple<int, int> tuple = new Tuple<int, int>(x, y);
                    _grid.Add(tuple);
                    Console.Write(_grid[counter]);
                    counter++;
                }
                Console.WriteLine();
            }
        }
        // Spel loop
        public void Run()
        {

        }
    }
}
